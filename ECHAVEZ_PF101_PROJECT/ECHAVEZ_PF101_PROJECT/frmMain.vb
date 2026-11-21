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

    ' Runtime-only state
    Private currentActiveBtn As Button = Nothing
    Private currentLoadedForm As Form = Nothing
    Private backgroundImageStream As IO.MemoryStream = Nothing

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Apply Windows 10/11 Dark Titlebar
        Try
            Dim darkMode As Integer = 1
            DwmSetWindowAttribute(Me.Handle, 20, darkMode, 4)
            Dim captionColor As Integer = &H161312
            DwmSetWindowAttribute(Me.Handle, 35, captionColor, 4)
        Catch ex As Exception
        End Try

        ' 2. Configure Background PictureBox
        picBg.Dock = DockStyle.None
        picBg.Anchor = AnchorStyles.None
        picBg.SizeMode = PictureBoxSizeMode.StretchImage
        picBg.BackColor = Color.FromArgb(15, 17, 23)
        picBg.TabStop = False

        Try
            Dim bgPath As String = IO.Path.Combine(Application.StartupPath, "Assets", "background.gif")
            If IO.File.Exists(bgPath) Then
                backgroundImageStream = New IO.MemoryStream(IO.File.ReadAllBytes(bgPath))
                picBg.Image = Image.FromStream(backgroundImageStream, True, True)
                ImageAnimator.Animate(picBg.Image, AddressOf OnBackgroundFrameChanged)
            End If
        Catch ex As Exception
            If picBg.Image IsNot Nothing Then
                picBg.Image.Dispose()
                picBg.Image = Nothing
            End If
            If backgroundImageStream IsNot Nothing Then
                backgroundImageStream.Dispose()
                backgroundImageStream = Nothing
            End If
            System.Diagnostics.Debug.WriteLine("frmMain: could not load the overview background: " & ex.Message)
        End Try

        If Not pnlOverview.Controls.Contains(picBg) Then
            pnlOverview.Controls.Add(picBg)
        End If
        picBg.SendToBack()

        ' 3. Extend Wallpaper behind Sidebar & Wire dynamic resizing
        LayoutOverviewBackground()
        AddHandler pnlOverview.Resize, AddressOf LayoutOverviewBackground

        pnlOverview.BackColor = Color.FromArgb(15, 17, 23)
        pnlSidebar.BackColor = Color.FromArgb(18, 20, 28)
        pnlSidebar.Dock = DockStyle.Left
        pnlContent.BackColor = Color.FromArgb(15, 17, 23)
        pnlContent.Dock = DockStyle.Fill

        pnlCardName.BackColor = Color.FromArgb(30, 34, 45)
        pnlCardCourse.BackColor = Color.FromArgb(30, 34, 45)
        pnlCardModules.BackColor = Color.FromArgb(30, 34, 45)
        pnlCardTheme.BackColor = Color.FromArgb(30, 34, 45)
        lblOverviewHeader.BringToFront()
        tblCards.BringToFront()
        pnlCardName.BringToFront()
        pnlCardCourse.BringToFront()
        pnlCardModules.BringToFront()
        pnlCardTheme.BringToFront()

        ' 4. Double-buffer panels for fluid rendering
        EnableDoubleBuffering(pnlOverview)
        EnableDoubleBuffering(tblCards)
        EnableDoubleBuffering(pnlProfile)
        EnableDoubleBuffering(pnlCardName)
        EnableDoubleBuffering(pnlCardCourse)
        EnableDoubleBuffering(pnlCardModules)
        EnableDoubleBuffering(pnlCardTheme)

        ' 5. Mark "Overview" as active view
        SetActiveButton(btnNavOverview)
        ShowOverviewDashboard()
    End Sub

    ''' <summary>
    ''' Extends the wallpaper to start at the screen's left edge (X = 0),
    ''' hiding the bottom-left watermark behind the sidebar.
    ''' </summary>
    Private Sub LayoutOverviewBackground()
        If picBg Is Nothing OrElse pnlOverview Is Nothing OrElse pnlSidebar Is Nothing Then Return
        Dim sidebarOffset As Integer = pnlSidebar.Width
        picBg.SetBounds(-sidebarOffset, 0, pnlOverview.ClientSize.Width + sidebarOffset, pnlOverview.ClientSize.Height)
    End Sub

    Private Sub OnBackgroundFrameChanged(sender As Object, e As EventArgs)
        If picBg Is Nothing OrElse picBg.IsDisposed OrElse Not picBg.IsHandleCreated Then Return
        If picBg.InvokeRequired Then
            picBg.BeginInvoke(New Action(AddressOf picBg.Invalidate))
        Else
            picBg.Invalidate()
        End If
    End Sub

    ' =========================================================
    ' OVERVIEW DASHBOARD
    ' =========================================================
    Private Sub ShowOverviewDashboard()
        If currentLoadedForm IsNot Nothing Then
            pnlContent.Controls.Remove(currentLoadedForm)
            currentLoadedForm.Dispose()
            currentLoadedForm = Nothing
        End If
        pnlOverview.Visible = True
        pnlContent.BackColor = Color.FromArgb(15, 17, 23)
        pnlOverview.BringToFront()
        LayoutOverviewBackground()
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
        If picBg.Image IsNot Nothing Then
            Dim backgroundImage As Image = picBg.Image
            ImageAnimator.StopAnimate(backgroundImage, AddressOf OnBackgroundFrameChanged)
            picBg.Image = Nothing
            backgroundImage.Dispose()
        End If
        If backgroundImageStream IsNot Nothing Then
            backgroundImageStream.Dispose()
            backgroundImageStream = Nothing
        End If
    End Sub

    ' =========================================================
    ' INSTANT EMBEDDED VIEW ENGINE
    ' =========================================================
    Public Sub LoadView(childForm As Form)
        pnlOverview.Visible = False
        pnlContent.BackColor = Color.FromArgb(15, 17, 23)

        SendMessage(pnlContent.Handle, WM_SETREDRAW, False, 0)
        pnlContent.SuspendLayout()

        Try
            If currentLoadedForm IsNot Nothing Then
                pnlContent.Controls.Remove(currentLoadedForm)
                currentLoadedForm.Dispose()
                currentLoadedForm = Nothing
            End If

            childForm.BackColor = COLOR_BG
            childForm.ForeColor = COLOR_TEXT
            childForm.TopLevel = False
            childForm.FormBorderStyle = FormBorderStyle.None
            childForm.Dock = DockStyle.Fill

            ThemeManager.ApplyTheme(childForm)

            pnlContent.Controls.Add(childForm)
            childForm.Show()
            childForm.FormBorderStyle = FormBorderStyle.None
            currentLoadedForm = childForm
        Finally
            pnlContent.ResumeLayout(True)
            SendMessage(pnlContent.Handle, WM_SETREDRAW, True, 0)
            pnlContent.Refresh()
        End Try
    End Sub

    ' =========================================================
    ' NAVIGATION CLICK HANDLERS
    ' =========================================================
    Private Sub Nav_Overview_Click(sender As Object, e As EventArgs) Handles btnNavOverview.Click
        SetActiveButton(DirectCast(sender, Button))
        ShowOverviewDashboard()
    End Sub

    Private Sub Nav_Orientations_Click(sender As Object, e As EventArgs) Handles btnNavOrientations.Click
        SetActiveButton(DirectCast(sender, Button))
        LoadView(New frmOrientations())
    End Sub

    Private Sub Nav_OOPConcepts_Click(sender As Object, e As EventArgs) Handles btnNavOOPConcepts.Click
        pnlNavOOPChildren.Visible = Not pnlNavOOPChildren.Visible
        btnNavOOPConcepts.Text = If(pnlNavOOPChildren.Visible,
                                    "  Lesson 2: OOP Concepts ▾",
                                    "  Lesson 2: OOP Concepts ▸")
        pnlNavList.PerformLayout()
    End Sub

    Private Sub Nav_Classes_Click(sender As Object, e As EventArgs) Handles btnNavClasses.Click
        SetActiveButton(DirectCast(sender, Button))
        LoadView(New frmClassesObjects())
    End Sub

    Private Sub Nav_Encapsulation_Click(sender As Object, e As EventArgs) Handles btnNavEncapsulation.Click
        SetActiveButton(DirectCast(sender, Button))
        LoadView(New frmEncapsulation())
    End Sub

    Private Sub Nav_Inheritance_Click(sender As Object, e As EventArgs) Handles btnNavInheritance.Click
        SetActiveButton(DirectCast(sender, Button))
        LoadView(New frmInheritance())
    End Sub

    Private Sub Nav_Polymorphism_Click(sender As Object, e As EventArgs) Handles btnNavPolymorphism.Click
        SetActiveButton(DirectCast(sender, Button))
        LoadView(New frmPolymorphism())
    End Sub

    Private Sub Nav_Lesson3_Click(sender As Object, e As EventArgs) Handles btnNavLesson3.Click
        SetActiveButton(DirectCast(sender, Button))
        LoadView(New frmLesson3_IDE())
    End Sub

    Private Sub Nav_Lesson4_Click(sender As Object, e As EventArgs) Handles btnNavLesson4.Click
        SetActiveButton(DirectCast(sender, Button))
        LoadView(New frmLesson4_Controls())
    End Sub

    Private Sub Nav_Lesson5_Click(sender As Object, e As EventArgs) Handles btnNavLesson5.Click
        SetActiveButton(DirectCast(sender, Button))
        LoadView(New frmLesson5_DataHandling())
    End Sub

    Private Sub Nav_Lesson6_Click(sender As Object, e As EventArgs) Handles btnNavLesson6.Click
        SetActiveButton(DirectCast(sender, Button))
        LoadView(New frmLesson6_SelectionRepetition())
    End Sub

    Private Sub Nav_Lesson7_Click(sender As Object, e As EventArgs) Handles btnNavLesson7.Click
        SetActiveButton(DirectCast(sender, Button))
        LoadView(New frmLesson7_Arrays())
    End Sub

    Private Sub Nav_Lesson8_Click(sender As Object, e As EventArgs) Handles btnNavLesson8.Click
        SetActiveButton(DirectCast(sender, Button))
        LoadView(New frmLesson8_Controls())
    End Sub

    Private Sub Nav_Game_Click(sender As Object, e As EventArgs) Handles btnNavGame.Click
        SetActiveButton(DirectCast(sender, Button))
        LoadView(New frmCatchGame())
    End Sub

    ' =========================================================
    ' HOVER STATE
    ' =========================================================
    Private Sub NavButton_MouseEnter(sender As Object, e As EventArgs) Handles _
        btnNavOverview.MouseEnter, btnNavOrientations.MouseEnter, btnNavClasses.MouseEnter,
        btnNavEncapsulation.MouseEnter, btnNavInheritance.MouseEnter, btnNavPolymorphism.MouseEnter,
        btnNavLesson3.MouseEnter, btnNavLesson4.MouseEnter, btnNavLesson5.MouseEnter, btnNavLesson6.MouseEnter,
        btnNavLesson7.MouseEnter, btnNavLesson8.MouseEnter, btnNavGame.MouseEnter, btnNavOOPConcepts.MouseEnter

        Dim btn = DirectCast(sender, Button)
        If btn IsNot currentActiveBtn Then btn.BackColor = COLOR_HOVER
    End Sub

    Private Sub NavButton_MouseLeave(sender As Object, e As EventArgs) Handles _
        btnNavOverview.MouseLeave, btnNavOrientations.MouseLeave, btnNavClasses.MouseLeave,
        btnNavEncapsulation.MouseLeave, btnNavInheritance.MouseLeave, btnNavPolymorphism.MouseLeave,
        btnNavLesson3.MouseLeave, btnNavLesson4.MouseLeave, btnNavLesson5.MouseLeave, btnNavLesson6.MouseLeave,
        btnNavLesson7.MouseLeave, btnNavLesson8.MouseLeave, btnNavGame.MouseLeave, btnNavOOPConcepts.MouseLeave

        Dim btn = DirectCast(sender, Button)
        If btn IsNot currentActiveBtn Then btn.BackColor = Color.Transparent
    End Sub

    Private Sub lblCardModulesMain_Click(sender As Object, e As EventArgs) Handles lblCardModulesMain.Click
    End Sub

    Private Sub lblSidebarCategory_Click(sender As Object, e As EventArgs) Handles lblSidebarCategory.Click
    End Sub
End Class