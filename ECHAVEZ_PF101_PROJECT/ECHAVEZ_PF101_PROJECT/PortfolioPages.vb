Option Strict On

Friend Enum PortfolioInfoPage
    About
    Coverage
    Developer
    Midterm
End Enum

Public Class frmPortfolioInfo
    Inherits Form

    Public Sub New()
        Me.New(PortfolioInfoPage.About)
    End Sub

    Friend Sub New(page As PortfolioInfoPage)
        AutoScaleMode = AutoScaleMode.Font
        Padding = New Padding(24)
        Select Case page
            Case PortfolioInfoPage.Coverage
                PortfolioPages.BuildCoverage(Me)
            Case PortfolioInfoPage.Developer
                PortfolioPages.BuildTextPage(Me, "Developer Information",
                    "Arbel · BSIT, Section SBIT-2E", "Quezon City University",
                    "PF101 · Object-Oriented Programming",
                    "This portfolio is built in Visual Basic .NET and Windows Forms on .NET Framework 4.7.2.")
            Case PortfolioInfoPage.Midterm
                PortfolioPages.BuildTextPage(Me, "Week 9 · Midterm",
                    "Course material pending",
                    "The syllabus lists the midterm assessment here. The supplied course materials include no separate Week 9 presentation.",
                    "Use Midterm Practice in Practice & Activities to review Weeks 1–8.")
            Case Else
                PortfolioPages.BuildTextPage(Me, "About This Project",
                    "PF101 Object-Oriented Programming Portfolio",
                    "The portfolio uses interactive VB.NET Windows Forms examples to demonstrate OOP, control flow, desktop interfaces, and data access.",
                    "Weeks 1–15 follow the supplied course materials. The practice quizzes are unofficial study material.",
                    "Student Performance Records and the Catch Game leaderboard use separate offline SQLite databases in the current Windows user profile.")
        End Select
    End Sub
End Class

Friend Module PortfolioPages
    Friend Sub BuildOverview(host As Panel, picture As PictureBox, navigate As Action(Of String))
        Dim content As TableLayoutPanel = CreateStack(host)
        AddRow(content, PageLabel("PF101 Object-Oriented Programming Portfolio", 23.0F, bold:=True))
        AddRow(content, PageLabel("Explore how Visual Basic classes, objects, interfaces, and Windows Forms work together in practical exercises.", 11.0F))

        If picture.Image IsNot Nothing Then
            picture.Anchor = AnchorStyles.Left
            picture.Margin = New Padding(3, 6, 3, 8)
            picture.AccessibleName = "Portfolio illustration"
            AddRow(content, picture)
        Else
            picture.Dispose()
        End If

        AddRow(content, PageLabel("Course lessons", 14.0F, bold:=True))
        AddRow(content, PageLabel("Start with OOP and VB.NET fundamentals in Weeks 1–8. Weeks 10–15 cover debugging, drawing, printing, SQLite, and DataSets.", 10.0F))
        AddRow(content, PageLabel("Practice and activities", 14.0F, bold:=True))
        AddRow(content, PageLabel("Review the course with two practice quizzes, try the event-driven Catch Game, or explore offline CRUD and DataRow states.", 10.0F))

        Dim shortcuts As New FlowLayoutPanel With {.Dock = DockStyle.Fill, .AutoSize = True}
        AddShortcut(shortcuts, "Start Course", Sub() navigate("week1"))
        AddShortcut(shortcuts, "Course Coverage", Sub() navigate("coverage"))
        AddShortcut(shortcuts, "Midterm Practice", Sub() navigate("midterm"))
        AddShortcut(shortcuts, "Finals Practice", Sub() navigate("finals"))
        AddShortcut(shortcuts, "Catch Game", Sub() navigate("game"))
        AddShortcut(shortcuts, "SQLite Records", Sub() navigate("week13"))
        AddRow(content, shortcuts)
    End Sub

    Friend Sub BuildTextPage(host As Control, title As String, ParamArray paragraphs As String())
        Dim content As TableLayoutPanel = CreateStack(host)
        AddRow(content, PageLabel(title, 22.0F, bold:=True))
        For Each paragraph As String In paragraphs
            AddRow(content, PageLabel(paragraph, 11.0F))
        Next
    End Sub

    Friend Sub BuildCoverage(host As Control)
        Dim grid As New DataGridView With {
            .Dock = DockStyle.Fill, .ReadOnly = True, .AllowUserToAddRows = False, .AllowUserToDeleteRows = False,
            .AllowUserToResizeRows = False, .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells, .RowHeadersVisible = False,
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect, .MultiSelect = False, .AccessibleName = "Course coverage by week"
        }
        grid.Columns.Add(New DataGridViewTextBoxColumn With {.HeaderText = "Week", .FillWeight = 10, .SortMode = DataGridViewColumnSortMode.NotSortable})
        grid.Columns.Add(New DataGridViewTextBoxColumn With {.HeaderText = "Learning objective", .FillWeight = 45, .SortMode = DataGridViewColumnSortMode.NotSortable})
        grid.Columns.Add(New DataGridViewTextBoxColumn With {.HeaderText = "In the portfolio", .FillWeight = 45, .SortMode = DataGridViewColumnSortMode.NotSortable})
        grid.Columns(1).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        grid.Columns(2).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        grid.Rows.Add("1", "Explain course expectations and compute grades.", "Orientation and grading calculator")
        grid.Rows.Add("2", "Create classes and apply encapsulation, inheritance, polymorphism, and interfaces.", "Four OOP labs, including a simulated interface call")
        grid.Rows.Add("3", "Identify IDE tools and follow the flow of a VB.NET program.", "IDE walkthrough and console simulation")
        grid.Rows.Add("4", "Build a form with controls, properties, and events.", "Live form property testbench and event exercises")
        grid.Rows.Add("5", "Choose data types and apply conversions, operators, and scope.", "Conversion, operator, and counter exercises")
        grid.Rows.Add("6", "Apply decisions, loops, and date and string operations.", "Grade branches, bounded loop traces, and date and text exercises")
        grid.Rows.Add("7", "Create and traverse arrays and collections.", "Months ListBox, score search, and matrix totals")
        grid.Rows.Add("8", "Work with common dialogs, editable text, and data views.", "TXT and RTF editor with a TreeView and ListView browser")
        grid.Rows.Add("9", "Review the material before the midterm assessment.", "Course material pending. Midterm Practice is available separately.")
        grid.Rows.Add("10", "Trace code and handle file and runtime errors.", "Debugger walkthrough and file recovery exercise")
        grid.Rows.Add("11", "Use .NET Framework drawing and manage MDI child windows.", "GDI+ shape canvas and MDI workspace")
        grid.Rows.Add("12", "Preview and print a document and handle text.", "Paginated editor printing and the Week 6 string lab")
        grid.Rows.Add("13", "Connect to a database and use parameterized CRUD.", "SQLite Student Performance Records")
        grid.Rows.Add("14", "Bind disconnected data and explain DataRow states.", "DataSet snapshot and isolated row-state exercise")
        grid.Rows.Add("15", "Verify persistence and deploy a data-driven desktop app.", "Offline Release ZIP and first-run database guide")
        Dim heading As Label = PageLabel("Course Coverage", 22.0F, bold:=True)
        heading.Dock = DockStyle.Top
        Dim description As Label = PageLabel("Learning objectives and the portfolio activity that demonstrates each one.", 10.0F)
        description.Dock = DockStyle.Top
        host.Controls.Add(grid)
        host.Controls.Add(description)
        host.Controls.Add(heading)
    End Sub

    Private Function CreateStack(host As Control) As TableLayoutPanel
        Dim layout As New TableLayoutPanel With {.ColumnCount = 1, .Dock = DockStyle.Top, .AutoSize = True,
                                                  .AutoSizeMode = AutoSizeMode.GrowAndShrink}
        layout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        Dim viewport As New Panel With {.AutoScroll = True, .Dock = DockStyle.Fill}
        viewport.Controls.Add(layout)
        host.Controls.Add(viewport)
        AddHandler viewport.ClientSizeChanged,
            Sub(sender, args)
                For Each child As Control In layout.Controls
                    If TypeOf child Is Label Then child.MaximumSize = LabelWrapSize(viewport)
                Next
            End Sub
        Return layout
    End Function

    Private Function LabelWrapSize(viewport As Control) As Size
        Return New Size(Math.Max(100, viewport.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 8), 0)
    End Function

    Private Sub AddRow(layout As TableLayoutPanel, control As Control)
        If TypeOf control Is Label Then control.MaximumSize = LabelWrapSize(layout.Parent)
        layout.RowCount += 1
        layout.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        layout.Controls.Add(control, 0, layout.RowCount - 1)
    End Sub

    Private Function PageLabel(text As String, size As Single, Optional bold As Boolean = False) As Label
        Return New Label With {
            .Text = text, .AutoSize = True, .Dock = DockStyle.Fill, .Margin = New Padding(3, 4, 3, 7),
            .ForeColor = If(bold, ThemeManager.ClrText, ThemeManager.ClrTextMuted),
            .Font = ThemeManager.GetFont("Segoe UI", size, If(bold, FontStyle.Bold, FontStyle.Regular))
        }
    End Function

    Private Sub AddShortcut(parent As Control, caption As String, action As Action)
        Dim button As New Button With {.Text = caption, .AutoSize = True, .UseMnemonic = False}
        parent.Controls.Add(button)
        ThemeManager.ApplyTheme(button)
        ThemeManager.SetButtonKind(button, ThemeManager.ButtonKind.Secondary)
        AddHandler button.Click, Sub(sender, args) action()
    End Sub
End Module
