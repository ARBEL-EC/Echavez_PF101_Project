

Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices

Public Class frmMain
    ' Windows API to freeze/unfreeze screen redrawing during form swapping
    <DllImport("user32.dll")>
    Private Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wParam As Boolean, lParam As Integer) As Integer
    End Function
    Private Const WM_SETREDRAW As Integer = &HB
    ' =========================================================
    ' ANTI-FLICKER ENGINE (WS_EX_COMPOSITED)
    ' =========================================================
    ' Instructs Windows to paint all nested controls together in one pass,
    ' eliminating background GIF tearing and flickering around cards.
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000 ' WS_EX_COMPOSITED
            Return cp
        End Get
    End Property

    ' =========================================================
    ' COLOR PALETTE
    ' =========================================================
    Private ReadOnly COLOR_BG As Color = ColorTranslator.FromHtml("#0C0D0F")
    Private ReadOnly COLOR_SIDEBAR As Color = ColorTranslator.FromHtml("#121316")
    Private ReadOnly COLOR_CARD As Color = ColorTranslator.FromHtml("#181A1E")
    Private ReadOnly COLOR_HOVER As Color = ColorTranslator.FromHtml("#22252B")
    Private ReadOnly COLOR_ACTIVE As Color = ColorTranslator.FromHtml("#2C3038")
    Private ReadOnly COLOR_TEXT As Color = ColorTranslator.FromHtml("#F8FAFC")
    Private ReadOnly COLOR_TEXT_MUTED As Color = ColorTranslator.FromHtml("#8E95A2")
    Private ReadOnly COLOR_GREEN As Color = ColorTranslator.FromHtml("#22C55E")

    ' Windows DWM Titlebar API
    <DllImport("dwmapi.dll", CharSet:=CharSet.Unicode, PreserveSig:=True)>
    Private Shared Function DwmSetWindowAttribute(hwnd As IntPtr, attr As Integer, ByRef attrValue As Integer, attrSize As Integer) As Integer
    End Function

    ' Containers & Controls
    Private pnlSidebar As Panel
    Private pnlContent As Panel
    Private pnlOverview As Panel = Nothing
    Private currentActiveBtn As Button = Nothing
    Private currentLoadedForm As Form = Nothing

    ' GIF Animation Engine
    Private bgAnimation As Image = Nothing

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Apply Windows 10/11 Dark Titlebar
        Try
            Dim darkMode As Integer = 1
            DwmSetWindowAttribute(Me.Handle, 20, darkMode, 4)
            Dim captionColor As Integer = &H161312
            DwmSetWindowAttribute(Me.Handle, 35, captionColor, 4)
        Catch ex As Exception
        End Try

        ' 2. Form Base Settings
        Me.BackColor = COLOR_BG
        Me.Size = New Size(1280, 750)
        Me.MinimumSize = New Size(1024, 620)
        Me.StartPosition = FormStartPosition.CenterScreen

        ' 3. Load GIF from Resources safely
        Try
            bgAnimation = My.Resources.background
            If bgAnimation IsNot Nothing AndAlso ImageAnimator.CanAnimate(bgAnimation) Then
                ImageAnimator.Animate(bgAnimation, AddressOf OnFrameChanged)
            End If
        Catch ex As Exception
        End Try

        ' 4. Construct Layout Containers
        InitializeLayoutContainers()

        ' 5. Build Sidebar Navigation & Display Overview
        BuildSidebar()
        ShowOverviewDashboard()
    End Sub

    ' =========================================================
    ' PROGRAMMATIC LAYOUT
    ' =========================================================
    Private Sub InitializeLayoutContainers()
        Me.Controls.Clear()

        ' 1. Sidebar on the left
        pnlSidebar = New Panel()
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Width = 240
        pnlSidebar.BackColor = COLOR_SIDEBAR
        Me.Controls.Add(pnlSidebar)
        pnlSidebar.SendToBack()

        ' 2. Main content area on the right
        pnlContent = New Panel()
        pnlContent.Name = "pnlContent"
        pnlContent.Dock = DockStyle.Fill
        pnlContent.BackColor = COLOR_BG
        Me.Controls.Add(pnlContent)
        pnlContent.BringToFront()
    End Sub

    ' =========================================================
    ' OVERVIEW DASHBOARD WITH HIDDEN WATERMARK
    ' =========================================================
    Private Sub ShowOverviewDashboard()
        If currentLoadedForm IsNot Nothing Then
            pnlContent.Controls.Remove(currentLoadedForm)
            currentLoadedForm.Dispose()
            currentLoadedForm = Nothing
        End If
        pnlContent.Controls.Clear()

        pnlOverview = New Panel()
        pnlOverview.Dock = DockStyle.Fill
        pnlOverview.AutoScroll = True
        pnlOverview.Padding = New Padding(36, 28, 36, 28)

        ' Double-buffer overview panel
        EnableDoubleBuffering(pnlOverview)
        AddHandler pnlOverview.Paint, AddressOf Overview_Paint

        ' Header Label
        Dim lblOverviewHeader As New Label()
        lblOverviewHeader.Text = "Overview"
        lblOverviewHeader.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblOverviewHeader.ForeColor = COLOR_TEXT
        lblOverviewHeader.BackColor = Color.Transparent
        lblOverviewHeader.Dock = DockStyle.Top
        lblOverviewHeader.Height = 45
        pnlOverview.Controls.Add(lblOverviewHeader)

        ' Dashboard Cards Grid
        Dim tblCards As New TableLayoutPanel()
        tblCards.Dock = DockStyle.Top
        tblCards.Height = 320
        tblCards.ColumnCount = 2
        tblCards.RowCount = 2
        tblCards.BackColor = Color.Transparent
        tblCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        tblCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        tblCards.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        tblCards.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        EnableDoubleBuffering(tblCards)

        tblCards.Controls.Add(CreateDashboardCard("Name", "ARBEL", "SBIT-2E", COLOR_GREEN), 0, 0)
        tblCards.Controls.Add(CreateDashboardCard("Course", "PF101 - OOP", "Quezon City University", COLOR_TEXT_MUTED), 1, 0)
        tblCards.Controls.Add(CreateDashboardCard("Modules Status", "6/6 Loaded", "All Weeks Ready", COLOR_GREEN), 0, 1)
        tblCards.Controls.Add(CreateDashboardCard("Runtime Theme", "Dark Obsidian", "Centralized Engine Active", COLOR_TEXT_MUTED), 1, 1)

        pnlOverview.Controls.Add(tblCards)
        tblCards.BringToFront()

        pnlContent.Controls.Add(pnlOverview)
    End Sub

    ' Paints the GIF stretched behind the sidebar (hiding the watermark)
    Private Sub Overview_Paint(sender As Object, e As PaintEventArgs)
        If bgAnimation IsNot Nothing AndAlso pnlOverview IsNot Nothing Then
            ImageAnimator.UpdateFrames()

            ' Offset drawing by the sidebar width: the left edge of the GIF
            ' (where the watermark is) is pushed completely outside the visible view.
            Dim sidebarWidth As Integer = If(pnlSidebar IsNot Nothing, pnlSidebar.Width, 240)
            Dim totalWidth As Integer = pnlOverview.Width + sidebarWidth
            Dim targetRect As New Rectangle(-sidebarWidth, 0, totalWidth, pnlOverview.Height)

            e.Graphics.DrawImage(bgAnimation, targetRect)

            ' Dark wash overlay over the visible area
            Using darkTint As New SolidBrush(Color.FromArgb(160, 12, 13, 15))
                e.Graphics.FillRectangle(darkTint, New Rectangle(0, 0, pnlOverview.Width, pnlOverview.Height))
            End Using
        End If
    End Sub

    Private Sub OnFrameChanged(sender As Object, e As EventArgs)
        If pnlOverview IsNot Nothing AndAlso Not pnlOverview.IsDisposed AndAlso pnlOverview.Visible Then
            If pnlOverview.InvokeRequired Then
                pnlOverview.BeginInvoke(Sub() pnlOverview.Invalidate())
            Else
                pnlOverview.Invalidate()
            End If
        End If
    End Sub

    Private Function CreateDashboardCard(title As String, mainVal As String, subVal As String, statusColor As Color) As Panel
        Dim card As New Panel()
        card.Dock = DockStyle.Fill
        card.BackColor = COLOR_CARD
        card.Margin = New Padding(8, 8, 8, 8)
        card.Padding = New Padding(18, 16, 18, 16)
        EnableDoubleBuffering(card)

        Dim lblTitle As New Label()
        lblTitle.Text = title
        lblTitle.ForeColor = COLOR_TEXT_MUTED
        lblTitle.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        lblTitle.Dock = DockStyle.Top
        lblTitle.Height = 22

        Dim lblMain As New Label()
        lblMain.Text = mainVal
        lblMain.ForeColor = COLOR_TEXT
        lblMain.Font = New Font("Segoe UI", 13.5F, FontStyle.Bold)
        lblMain.Dock = DockStyle.Top
        lblMain.Height = 32

        Dim lblSub As New Label()
        lblSub.Text = subVal
        lblSub.ForeColor = statusColor
        lblSub.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular)
        lblSub.Dock = DockStyle.Top
        lblSub.Height = 22

        card.Controls.AddRange({lblSub, lblMain, lblTitle})
        Return card
    End Function
    ' =========================================================
    ' INSTANT EMBEDDED VIEW ENGINE (Zero White Flash & Zero Lag)
    ' =========================================================
    Public Sub LoadView(childForm As Form)
        pnlOverview = Nothing

        ' 1. Freeze visual repaints on the content container
        SendMessage(pnlContent.Handle, WM_SETREDRAW, False, 0)
        pnlContent.SuspendLayout()

        Try
            ' 2. Clean up previous view
            If currentLoadedForm IsNot Nothing Then
                pnlContent.Controls.Remove(currentLoadedForm)
                currentLoadedForm.Dispose()
                currentLoadedForm = Nothing
            End If
            pnlContent.Controls.Clear()

            ' 3. Pre-color the child form to dark BEFORE it renders on screen
            childForm.BackColor = COLOR_BG
            childForm.ForeColor = COLOR_TEXT
            childForm.TopLevel = False
            childForm.FormBorderStyle = FormBorderStyle.None
            childForm.Dock = DockStyle.Fill

            ' 4. Pre-apply the dark theme while drawing is still frozen
            ThemeManager.ApplyTheme(childForm)

            ' 5. Add and show the form
            pnlContent.Controls.Add(childForm)
            childForm.Show()
            childForm.FormBorderStyle = FormBorderStyle.None
            currentLoadedForm = childForm

        Finally
            ' 6. Resume layout and unfreeze repaints
            pnlContent.ResumeLayout(True)
            SendMessage(pnlContent.Handle, WM_SETREDRAW, True, 0)

            ' 7. Paint the completed dark UI in a single instantaneous frame
            pnlContent.Refresh()
        End Try
    End Sub

    ' =========================================================
    ' SIDEBAR BUILDER
    ' =========================================================
    Private Sub BuildSidebar()
        pnlSidebar.Controls.Clear()
        pnlSidebar.Padding = New Padding(12, 16, 12, 14)

        Dim lblTitle As New Label()
        lblTitle.Text = "PF101 OOP"
        lblTitle.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblTitle.ForeColor = COLOR_TEXT
        lblTitle.Dock = DockStyle.Top
        lblTitle.Height = 35

        Dim lblCategory As New Label()
        lblCategory.Text = "Lessons"
        lblCategory.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblCategory.ForeColor = COLOR_TEXT_MUTED
        lblCategory.Dock = DockStyle.Top
        lblCategory.Height = 30

        pnlSidebar.Controls.Add(lblCategory)
        pnlSidebar.Controls.Add(lblTitle)
        lblTitle.BringToFront()

        ' Bottom Student Profile Card
        Dim pnlProfile As New Panel()
        pnlProfile.Height = 54
        pnlProfile.Dock = DockStyle.Bottom
        pnlProfile.BackColor = COLOR_CARD
        pnlProfile.Padding = New Padding(8, 8, 8, 8)
        EnableDoubleBuffering(pnlProfile)

        Dim lblAvatar As New Label()
        lblAvatar.Text = "●"
        lblAvatar.ForeColor = COLOR_GREEN
        lblAvatar.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblAvatar.Size = New Size(24, 30)
        lblAvatar.Location = New Point(10, 10)

        Dim lblName As New Label()
        lblName.Text = "ARBEL"
        lblName.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblName.ForeColor = COLOR_TEXT
        lblName.Location = New Point(38, 8)
        lblName.AutoSize = True

        Dim lblStatus As New Label()
        lblStatus.Text = "BSIT Student"
        lblStatus.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular)
        lblStatus.ForeColor = COLOR_TEXT_MUTED
        lblStatus.Location = New Point(38, 27)
        lblStatus.AutoSize = True

        pnlProfile.Controls.AddRange({lblAvatar, lblName, lblStatus})
        pnlSidebar.Controls.Add(pnlProfile)

        ' Navigation Buttons Panel
        Dim pnlNavList As New Panel()
        pnlNavList.Dock = DockStyle.Fill
        pnlNavList.AutoScroll = True
        pnlNavList.BackColor = Color.Transparent
        pnlSidebar.Controls.Add(pnlNavList)
        pnlNavList.BringToFront()

        Dim navItems As (Text As String, Handler As EventHandler)() = {
            ("Overview", AddressOf Nav_Overview_Click),
            ("Orientations", AddressOf Nav_Orientations_Click),
            ("Classes & Objects", AddressOf Nav_Classes_Click),
            ("Encapsulation", AddressOf Nav_Encapsulation_Click),
            ("Inheritance", AddressOf Nav_Inheritance_Click),
            ("Polymorphism", AddressOf Nav_Polymorphism_Click),
            ("Lesson 3: IDE Basics", AddressOf Nav_Lesson3_Click),
            ("Lesson 4: Designing UI", AddressOf Nav_Lesson4_Click),
            ("Lesson 5: Data Handling", AddressOf Nav_Lesson5_Click),
            ("Lesson 6: Selection & Loops", AddressOf Nav_Lesson6_Click)
        }

        For i As Integer = navItems.Length - 1 To 0 Step -1
            Dim item = navItems(i)
            Dim btn As New Button()
            btn.Text = "  " & item.Text
            btn.Height = 40
            btn.Dock = DockStyle.Top
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.TextAlign = ContentAlignment.MiddleLeft
            btn.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
            btn.ForeColor = COLOR_TEXT_MUTED
            btn.BackColor = Color.Transparent
            btn.Cursor = Cursors.Hand
            btn.Margin = New Padding(0, 2, 0, 2)

            AddHandler btn.Click, item.Handler
            AddHandler btn.MouseEnter, Sub(s, e)
                                           If btn IsNot currentActiveBtn Then btn.BackColor = COLOR_HOVER
                                       End Sub
            AddHandler btn.MouseLeave, Sub(s, e)
                                           If btn IsNot currentActiveBtn Then btn.BackColor = Color.Transparent
                                       End Sub

            pnlNavList.Controls.Add(btn)
            If i = 0 Then SetActiveButton(btn)
        Next
    End Sub

    Private Sub SetActiveButton(btn As Button)
        If currentActiveBtn IsNot Nothing Then
            currentActiveBtn.BackColor = Color.Transparent
            currentActiveBtn.ForeColor = COLOR_TEXT_MUTED
            currentActiveBtn.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
        End If

        currentActiveBtn = btn
        currentActiveBtn.BackColor = COLOR_ACTIVE
        currentActiveBtn.ForeColor = COLOR_TEXT
        currentActiveBtn.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
    End Sub

    Private Sub EnableDoubleBuffering(ctrl As Control)
        Try
            Dim prop = GetType(Control).GetProperty("DoubleBuffered",
                Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
            prop?.SetValue(ctrl, True, Nothing)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If bgAnimation IsNot Nothing Then
            ImageAnimator.StopAnimate(bgAnimation, AddressOf OnFrameChanged)
        End If
    End Sub

    ' =========================================================
    ' NAVIGATION CLICK HANDLERS
    ' =========================================================
    Private Sub Nav_Overview_Click(sender As Object, e As EventArgs)
        SetActiveButton(DirectCast(sender, Button))
        ShowOverviewDashboard()
    End Sub

    Private Sub Nav_Orientations_Click(sender As Object, e As EventArgs)
        SetActiveButton(DirectCast(sender, Button))
        LoadView(New frmOrientations())
    End Sub

    Private Sub Nav_Classes_Click(sender As Object, e As EventArgs)
        SetActiveButton(DirectCast(sender, Button))
        LoadView(New frmClassesObjects())
    End Sub

    Private Sub Nav_Encapsulation_Click(sender As Object, e As EventArgs)
        SetActiveButton(DirectCast(sender, Button))
        LoadView(New frmEncapsulation())
    End Sub

    Private Sub Nav_Inheritance_Click(sender As Object, e As EventArgs)
        SetActiveButton(DirectCast(sender, Button))
        LoadView(New frmInheritance())
    End Sub

    Private Sub Nav_Polymorphism_Click(sender As Object, e As EventArgs)
        SetActiveButton(DirectCast(sender, Button))
        LoadView(New frmPolymorphism())
    End Sub

    Private Sub Nav_Lesson3_Click(sender As Object, e As EventArgs)
        SetActiveButton(DirectCast(sender, Button))
        LoadView(New frmLesson3_IDE())
    End Sub

    Private Sub Nav_Lesson4_Click(sender As Object, e As EventArgs)
        SetActiveButton(DirectCast(sender, Button))
        LoadView(New frmLesson4_Controls())
    End Sub

    Private Sub Nav_Lesson5_Click(sender As Object, e As EventArgs)
        SetActiveButton(DirectCast(sender, Button))
        LoadView(New frmLesson5_DataHandling())
    End Sub

    Private Sub Nav_Lesson6_Click(sender As Object, e As EventArgs)
        SetActiveButton(DirectCast(sender, Button))
        LoadView(New frmLesson6_SelectionRepetition())
    End Sub

End Class