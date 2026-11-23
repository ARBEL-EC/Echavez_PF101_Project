Imports System.Runtime.InteropServices

Public Class frmMain
    <DllImport("user32.dll")>
    Private Shared Function SendMessage(hWnd As IntPtr, message As Integer, wParam As IntPtr, lParam As IntPtr) As IntPtr
    End Function

    <DllImport("dwmapi.dll", PreserveSig:=True)>
    Private Shared Function DwmSetWindowAttribute(hwnd As IntPtr, attribute As Integer, ByRef value As Integer, size As Integer) As Integer
    End Function

    Private Const WM_SETREDRAW As Integer = &HB
    Private ReadOnly _navHover As Color = Color.FromArgb(34, 37, 43)
    Private ReadOnly _navActive As Color = Color.FromArgb(44, 48, 56)
    Private ReadOnly _pages As New Dictionary(Of String, NavigationPage)(StringComparer.Ordinal)
    Private ReadOnly _groups As New Dictionary(Of Panel, NavigationGroup)()
    Private ReadOnly _midtermPractice As New CourseReviewAttempt(PracticeQuestions.Midterm())
    Private ReadOnly _finalsPractice As New CourseReviewAttempt(PracticeQuestions.Finals())
    Private _activePage As Button
    Private _currentForm As Form
    Private _backgroundImageStream As IO.MemoryStream
    Private _overviewImage As Image

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim parameters As CreateParams = MyBase.CreateParams
            parameters.ExStyle = parameters.ExStyle Or &H2000000
            Return parameters
        End Get
    End Property

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim darkMode As Integer = 1
            DwmSetWindowAttribute(Handle, 20, darkMode, 4)
            Dim captionColor As Integer = &H161312
            DwmSetWindowAttribute(Handle, 35, captionColor, 4)
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

        pnlSidebar.BackColor = Color.FromArgb(18, 20, 28)
        pnlContent.BackColor = ThemeManager.ClrBackground
        pnlOverview.BackColor = ThemeManager.ClrBackground
        BuildNavigation()
        LoadOverviewImage()
        PortfolioPages.BuildOverview(pnlOverview, picBg, AddressOf NavigateTo)
        NavigateTo("overview")
    End Sub

    Private Sub LoadOverviewImage()
        Try
            Dim path As String = IO.Path.Combine(Application.StartupPath, "Assets", "background.gif")
            _backgroundImageStream = New IO.MemoryStream(IO.File.ReadAllBytes(path), writable:=False)
            _overviewImage = Image.FromStream(_backgroundImageStream, True, True)
            picBg.Image = _overviewImage
        Catch ex As Exception When TypeOf ex Is IO.IOException OrElse TypeOf ex Is UnauthorizedAccessException OrElse
                                   TypeOf ex Is ArgumentException OrElse TypeOf ex Is OutOfMemoryException OrElse
                                   TypeOf ex Is ExternalException OrElse TypeOf ex Is Security.SecurityException
            Debug.WriteLine("Overview image: " & ex.Message)
            ReleaseOverviewImage()
        End Try
    End Sub

    Private Sub ReleaseOverviewImage()
        If picBg IsNot Nothing AndAlso Not picBg.IsDisposed Then picBg.Image = Nothing
        If _overviewImage IsNot Nothing Then
            _overviewImage.Dispose()
            _overviewImage = Nothing
        End If
        If _backgroundImageStream IsNot Nothing Then
            _backgroundImageStream.Dispose()
            _backgroundImageStream = Nothing
        End If
    End Sub

    Private Sub BuildNavigation()
        pnlNavList.SuspendLayout()
        Try
            RegisterPage(pnlNavList, "overview", "Overview", Nothing)
            Dim course As Panel = RegisterGroup(pnlNavList, "Course Lessons", indent:=0)
            RegisterPage(course, "week1", "Week 1 · Orientation", Function() New frmOrientations(), 1)
            Dim oop As Panel = RegisterGroup(course, "Week 2 · OOP Concepts", indent:=1)
            RegisterPage(oop, "classes", "Classes & Objects", Function() New frmClassesObjects(), 2)
            RegisterPage(oop, "encapsulation", "Encapsulation", Function() New frmEncapsulation(), 2)
            RegisterPage(oop, "inheritance", "Inheritance", Function() New frmInheritance(), 2)
            RegisterPage(oop, "polymorphism", "Polymorphism", Function() New frmPolymorphism(), 2)
            RegisterPage(course, "week3", "Week 3 · VB.NET IDE", Function() New frmLesson3_IDE(), 1)
            RegisterPage(course, "week4", "Week 4 · Form Design", Function() New frmLesson4_Controls(), 1)
            RegisterPage(course, "week5", "Week 5 · Data Handling", Function() New frmLesson5_DataHandling(), 1)
            RegisterPage(course, "week6", "Week 6 · Control Flow", Function() New frmLesson6_SelectionRepetition(), 1)
            RegisterPage(course, "week7", "Week 7 · Arrays", Function() New frmLesson7_Arrays(), 1)
            RegisterPage(course, "week8", "Week 8 · Dialogs", Function() New frmLesson8_Controls(), 1)
            RegisterPage(course, "week9", "Week 9 · Midterm",
                         Function() New frmPortfolioInfo(PortfolioInfoPage.Midterm), 1)
            RegisterPage(course, "week10", "Week 10 · Debugging",
                         Function() New frmLesson3_IDE With {.FollowUpWeek = 10}, 1)
            RegisterPage(course, "week11", "Week 11 · MDI & Drawing",
                         Function() New frmLesson3_IDE With {.FollowUpWeek = 11}, 1)
            RegisterPage(course, "week12", "Week 12 · Printing",
                         Function() New frmLesson8_Controls With {.OpenPrintingLab = True}, 1)
            RegisterPage(course, "week13", "Week 13 · SQLite Records",
                         Function() New frmStudentRecords With {.StartWeek = 13}, 1)
            RegisterPage(course, "week14", "Week 14 · DataSets",
                         Function() New frmStudentRecords With {.StartWeek = 14}, 1)
            RegisterPage(course, "week15", "Week 15 · Deployment",
                         Function() New frmStudentRecords With {.StartWeek = 15}, 1)

            Dim practice As Panel = RegisterGroup(pnlNavList, "Practice & Activities", indent:=0)
            RegisterPage(practice, "midterm", "Midterm Practice",
                         Function() New frmCourseReview("Midterm Practice", _midtermPractice), 1)
            RegisterPage(practice, "finals", "Finals Practice",
                         Function() New frmCourseReview("Finals Practice", _finalsPractice), 1)
            RegisterPage(practice, "game", "Animation Catch Game", Function() New frmCatchGame(), 1)

            Dim info As Panel = RegisterGroup(pnlNavList, "Project Information", indent:=0)
            RegisterPage(info, "about", "About This Project", Function() New frmPortfolioInfo(PortfolioInfoPage.About), 1)
            RegisterPage(info, "coverage", "Course Coverage", Function() New frmPortfolioInfo(PortfolioInfoPage.Coverage), 1)
            RegisterPage(info, "developer", "Developer Information", Function() New frmPortfolioInfo(PortfolioInfoPage.Developer), 1)
        Finally
            pnlNavList.ResumeLayout(True)
        End Try
    End Sub

    Private Function RegisterGroup(parent As Control, title As String, indent As Integer) As Panel
        Dim button As Button = AddNavigationButton(parent, title, indent)
        Dim body As New Panel With {.Dock = DockStyle.Top, .AutoSize = True, .AutoSizeMode = AutoSizeMode.GrowAndShrink,
                                    .Height = 0, .TabIndex = parent.Controls.Count, .BackColor = pnlSidebar.BackColor}
        parent.Controls.Add(body)
        parent.Controls.SetChildIndex(body, 0)
        Dim group As New NavigationGroup(button, title)
        _groups.Add(body, group)
        AddHandler button.Click,
            Sub(sender, args)
                group.Expanded = Not group.Expanded
                UpdateGroup(body, group)
            End Sub
        UpdateGroup(body, group)
        Return body
    End Function

    Private Sub RegisterPage(parent As Control, id As String, title As String,
                             createView As Func(Of Form), Optional indent As Integer = 0)
        Dim button As Button = AddNavigationButton(parent, title, indent)
        _pages.Add(id, New NavigationPage(button, createView))
        AddHandler button.Click, Sub(sender, args) NavigateTo(id)
    End Sub

    Private Function AddNavigationButton(parent As Control, title As String, indent As Integer) As Button
        Dim button As New Button With {
            .Text = title, .Dock = DockStyle.Top, .Height = LogicalToDeviceUnits(36),
            .TextAlign = ContentAlignment.MiddleLeft, .Padding = New Padding(LogicalToDeviceUnits(8 + 10 * indent), 0, 0, 0),
            .FlatStyle = FlatStyle.Flat, .BackColor = Color.Transparent, .ForeColor = ThemeManager.ClrTextMuted,
            .Font = ThemeManager.GetFont("Segoe UI", 9.5F, FontStyle.Regular),
            .Cursor = Cursors.Hand, .UseVisualStyleBackColor = False, .UseMnemonic = False, .AutoEllipsis = True,
            .TabIndex = parent.Controls.Count, .AccessibleName = title
        }
        button.FlatAppearance.BorderSize = 0
        button.FlatAppearance.MouseOverBackColor = _navHover
        parent.Controls.Add(button)
        parent.Controls.SetChildIndex(button, 0)
        Return button
    End Function

    Private Sub UpdateGroup(body As Panel, group As NavigationGroup)
        body.Visible = group.Expanded
        group.Button.Text = If(group.Expanded, "▾  ", "▸  ") & group.Title
        group.Button.AccessibleDescription = If(group.Expanded, "Expanded", "Collapsed")
        group.Button.ForeColor = If(_activePage IsNot Nothing AndAlso body.Contains(_activePage) AndAlso Not group.Expanded,
                                    ThemeManager.ClrText, ThemeManager.ClrTextMuted)
    End Sub

    Private Sub MarkActive(page As NavigationPage)
        If _activePage IsNot Nothing Then
            _activePage.BackColor = Color.Transparent
            _activePage.FlatAppearance.MouseOverBackColor = _navHover
            _activePage.ForeColor = ThemeManager.ClrTextMuted
            _activePage.Font = ThemeManager.GetFont("Segoe UI", 9.5F, FontStyle.Regular)
            _activePage.AccessibleDescription = Nothing
        End If

        _activePage = page.Button
        _activePage.BackColor = _navActive
        _activePage.FlatAppearance.MouseOverBackColor = _navActive
        _activePage.ForeColor = ThemeManager.ClrText
        _activePage.Font = ThemeManager.GetFont("Segoe UI", 9.5F, FontStyle.Bold)
        _activePage.AccessibleDescription = "Current page"

        Dim ancestor As Panel = TryCast(_activePage.Parent, Panel)
        While ancestor IsNot Nothing AndAlso _groups.ContainsKey(ancestor)
            _groups(ancestor).Expanded = True
            ancestor = TryCast(ancestor.Parent, Panel)
        End While
        For Each group In _groups
            UpdateGroup(group.Key, group.Value)
        Next
        pnlNavList.ScrollControlIntoView(_activePage)
    End Sub

    Private Sub NavigateTo(id As String)
        Dim page As NavigationPage = _pages(id)
        If _activePage Is page.Button Then
            MarkActive(page)
            Return
        End If

        Dim previous As Form = _currentForm
        Try
            SwapView(page)
        Catch ex As Exception
            Debug.WriteLine(ex.ToString())
            MessageBox.Show(Me, "This page could not be opened. The current page is still available.",
                            "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End Try

        MarkActive(page)
        If previous IsNot Nothing Then previous.Dispose()
    End Sub

    Private Sub SwapView(page As NavigationPage)
        Dim nextView As Form = Nothing
        SendMessage(pnlContent.Handle, WM_SETREDRAW, IntPtr.Zero, IntPtr.Zero)
        pnlContent.SuspendLayout()
        Try
            If page.CreateView IsNot Nothing Then
                nextView = page.CreateView()
                nextView.TopLevel = False
                nextView.FormBorderStyle = FormBorderStyle.None
                nextView.Dock = DockStyle.Fill
                ThemeManager.ApplyTheme(nextView)
                pnlContent.Controls.Add(nextView)
                nextView.Show()
                nextView.BringToFront()
            End If
            If _currentForm IsNot Nothing Then pnlContent.Controls.Remove(_currentForm)
            _currentForm = nextView
            pnlOverview.Visible = nextView Is Nothing
            If nextView Is Nothing Then pnlOverview.BringToFront()
        Catch
            If nextView IsNot Nothing Then
                pnlContent.Controls.Remove(nextView)
                nextView.Dispose()
            End If
            Throw
        Finally
            SendMessage(pnlContent.Handle, WM_SETREDRAW, New IntPtr(1), IntPtr.Zero)
            pnlContent.ResumeLayout(True)
            pnlContent.Refresh()
        End Try
    End Sub

    Private NotInheritable Class NavigationPage
        Friend ReadOnly Button As Button
        Friend ReadOnly CreateView As Func(Of Form)

        Friend Sub New(button As Button, createView As Func(Of Form))
            Me.Button = button
            Me.CreateView = createView
        End Sub
    End Class

    Private NotInheritable Class NavigationGroup
        Friend ReadOnly Button As Button
        Friend ReadOnly Title As String
        Friend Expanded As Boolean

        Friend Sub New(button As Button, title As String)
            Me.Button = button
            Me.Title = title
        End Sub
    End Class
End Class
