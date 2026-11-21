Public Class frmLesson3_IDE

    Friend Property FollowUpWeek As Integer

    Private Sub frmLesson3_IDE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeManager.ApplyTheme(Me)
        ' =========================================================
        ' 1. POPULATE IDE COMPONENTS LIST (Week 3 Slides 12-27)
        ' =========================================================
        lstIDEComponents.Items.Clear()
        lstIDEComponents.Items.Add("Start Page")
        lstIDEComponents.Items.Add("Form Designer Window")
        lstIDEComponents.Items.Add("Solution Explorer")
        lstIDEComponents.Items.Add("Properties Window")
        lstIDEComponents.Items.Add("Toolbox Window")
        lstIDEComponents.Items.Add("Standard Toolbar")
        lstIDEComponents.Items.Add("Menu Bar")
        lstIDEComponents.Items.Add("Output Window")
        lstIDEComponents.Items.Add("Error List Window")
        lstIDEComponents.Items.Add("Command Window")
        lstIDEComponents.Items.Add("Auto Hide & Docking")
        lstIDEComponents.SelectedIndex = 1 ' Default to Form Designer

        ' =========================================================
        ' 2. POPULATE PROGRAMMING BASICS (Week 3 Slides 4-11)
        ' =========================================================
        txtLanguageElements.Text =
            "WEEK 3: GETTING STARTED WITH VB.NET - CORE CONCEPTS" & vbCrLf &
            "=================================================================" & vbCrLf & vbCrLf &
            "1. WHAT IS COMPUTER PROGRAMMING?" & vbCrLf &
            "   A computer program is a set of instructions on how to solve a problem" & vbCrLf &
            "   or perform a task. Programming is the process of developing and" & vbCrLf &
            "   implementing instructions that enable a computer to operate smoothly." & vbCrLf & vbCrLf &
            "2. TRANSLATION OF PROGRAMMING LANGUAGES:" & vbCrLf &
            "   A translator or compiler converts human-readable high-level statements" & vbCrLf &
            "   into machine language instructions (1s and 0s) understood by the CPU" & vbCrLf &
            "   without losing the logical essence of the original program." & vbCrLf & vbCrLf &
            "3. WHAT IS A PROGRAM MADE OF?" & vbCrLf &
            "   • Keywords (Reserved Words): Words with special pre-assigned meanings" & vbCrLf &
            "     (e.g., Dim, Const, Sub, Class, If, As). Cannot be used as variable names." & vbCrLf &
            "   • Operators: Special symbols performing operations (+, -, *, /, ^, \)." & vbCrLf &
            "   • Variables: Symbolic memory locations used to store program data." & vbCrLf &
            "   • Syntax: Strict grammar rules; any violation halts compilation." & vbCrLf &
            "   • Statements: Complete instructions combining keywords, operators, and variables." & vbCrLf &
            "   • Procedures: Subroutines or functions executing dedicated tasks." & vbCrLf &
            "   • Comments (Remarks): Lines beginning with an apostrophe ('). Ignored at runtime." & vbCrLf & vbCrLf &
            "4. POPULAR PROGRAMMING LANGUAGES:" & vbCrLf &
            "   • Visual Basic, C#: Modern Windows and Web enterprise applications." & vbCrLf &
            "   • C, C++: High-performance advanced systems programming." & vbCrLf &
            "   • Java: Multi-platform object-oriented applications." & vbCrLf &
            "   • Python: Scripting, graphics, AI, and rapid application building." & vbCrLf &
            "   • PHP & JavaScript: Rich interactive web browsers and server logic."

        ' Initialize Console Shell Display
        ResetConsoleScreen()
        AddFollowUpLab()
    End Sub

    ' Update Component Description on selection change
    Private Sub lstIDEComponents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstIDEComponents.SelectedIndexChanged
        Dim component As String = TryCast(lstIDEComponents.SelectedItem, String)
        If component Is Nothing Then
            txtIDEDetails.Clear()
            Return
        End If
        Select Case component
            Case "Start Page"
                txtIDEDetails.Text = "START PAGE:" & vbCrLf & vbCrLf &
                    "Provides access to recent projects, solution creation templates, and getting-started tutorials."

            Case "Form Designer Window"
                txtIDEDetails.Text = "FORM DESIGNER WINDOW:" & vbCrLf & vbCrLf &
                    "Allows visual user-interface design by dragging controls onto a design-time representation of the application form."

            Case "Solution Explorer"
                txtIDEDetails.Text = "SOLUTION EXPLORER WINDOW:" & vbCrLf & vbCrLf &
                    "Views and manages all files, forms, modules, references, and system configurations inside the solution." & vbCrLf &
                    "Shortcut: Ctrl + Alt + L"

            Case "Properties Window"
                txtIDEDetails.Text = "PROPERTIES WINDOW:" & vbCrLf & vbCrLf &
                    "Modifies design-time properties of forms and selected controls (e.g., Name, Text, BackColor, Size, Anchor, Dock)." & vbCrLf &
                    "Shortcut: F4"

            Case "Toolbox Window"
                txtIDEDetails.Text = "TOOLBOX WINDOW:" & vbCrLf & vbCrLf &
                    "Contains ready-to-use user interface controls grouped into categories like 'Common Controls' and 'All Windows Forms'." & vbCrLf &
                    "Shortcut: Ctrl + Alt + X"

            Case "Standard Toolbar"
                txtIDEDetails.Text = "STANDARD TOOLBAR:" & vbCrLf & vbCrLf &
                    "Provides one-click execution of frequent commands: New Project, Save All, Start Debugging (F5), Comment/Uncomment, and Find."

            Case "Menu Bar"
                txtIDEDetails.Text = "MENU BAR:" & vbCrLf & vbCrLf &
                    "Organized drop-down menus at the top of the IDE: File, Edit, View, Project, Build, Debug, Tools, Architecture, Window, Help."

            Case "Output Window"
                txtIDEDetails.Text = "OUTPUT WINDOW:" & vbCrLf & vbCrLf &
                    "Displays runtime status messages, compilation diagnostics, and build results from the compiler." & vbCrLf &
                    "Shortcut: Ctrl + Alt + O"

            Case "Error List Window"
                txtIDEDetails.Text = "ERROR LIST WINDOW:" & vbCrLf & vbCrLf &
                    "Displays compile-time syntax errors, warning messages, and line references. Double-clicking an error jumps directly to the problem line."

            Case "Command Window"
                txtIDEDetails.Text = "COMMAND WINDOW:" & vbCrLf & vbCrLf &
                    "Executes Visual Studio aliases and commands directly without requiring menu navigation."

            Case "Auto Hide & Docking"
                txtIDEDetails.Text = "AUTO HIDE & DOCKING:" & vbCrLf & vbCrLf &
                    "• Auto Hide: Uses the pushpin icon to minimize panels into side tabs to save screen space." & vbCrLf &
                    "• Docked vs. Floating: Windows can snap to IDE edges (Docked) or float freely over the canvas."
        End Select
    End Sub

    ' Run Console Application Simulator (Week 3 Slides 28-33)
    Private Sub btnRunConsole_Click(sender As Object, e As EventArgs) Handles btnRunConsole.Click
        Dim userInput As String = txtConsoleInput.Text.Trim()
        If String.IsNullOrEmpty(userInput) Then
            userInput = "This is my first Console Application"
        End If

        txtConsoleScreen.AppendText(vbCrLf & "C:\Users\Student\Documents\Visual Studio 2012\Projects> ConsoleApplication.exe" & vbCrLf)
        txtConsoleScreen.AppendText(userInput & vbCrLf)
        txtConsoleScreen.AppendText("[Process completed - Press any key to continue...]" & vbCrLf)
    End Sub

    Private Sub btnClearConsole_Click(sender As Object, e As EventArgs) Handles btnClearConsole.Click
        ResetConsoleScreen()
    End Sub

    Private Sub ResetConsoleScreen()
        txtConsoleScreen.Text =
            "Microsoft Windows [Version 10.0.19045.3803]" & vbCrLf &
            "(c) Microsoft Corporation. All rights reserved." & vbCrLf & vbCrLf &
            "' Console Application Simulation: System.Console.Write() & Read()" & vbCrLf &
            "Module Module1" & vbCrLf &
            "    Sub Main()" & vbCrLf &
            "        System.Console.Write(""This is my first Console Application"")" & vbCrLf &
            "        System.Console.ReadLine()" & vbCrLf &
            "    End Sub" & vbCrLf &
            "End Module" & vbCrLf &
            "------------------------------------------------------------------" & vbCrLf
    End Sub

    Private Sub AddFollowUpLab()
        Dim debugging As TabPage = AddFollowUpTab("Debugging",
            "WEEK 10 - DEBUGGING AND TRACING" & vbCrLf & vbCrLf &
            "A syntax error stops the build. A runtime error happens during execution. A logic error produces an incorrect result." & vbCrLf & vbCrLf &
            "In Visual Studio, open the active nested project in Debug. Set a breakpoint in the Week 7 months button handler (F9), " &
            "start debugging (F5), and click Load Months. Step over array initialization (F10) and inspect months.Length " &
            "and months(0) in Locals or Watch. Continue with F5 and compare the ListBox with the watch value and the count in Debug Output." &
            vbCrLf & vbCrLf &
            "For structured file error handling, use Open in the Week 8 editor with a plain-text file named .rtf. " &
            "Set a breakpoint in ShowFileError to observe the exception type. Open a valid file to verify recovery.")

        Dim launchButton As New Button With {.Text = "Open MDI Lab", .Dock = DockStyle.Bottom, .Height = 36}
        AddHandler launchButton.Click, AddressOf OpenMdiLab
        Dim mdi As TabPage = AddFollowUpTab("MDI",
            "WEEK 11 - .NET FRAMEWORK AND MULTIPLE DOCUMENT INTERFACE" & vbCrLf & vbCrLf &
            "The Common Language Runtime runs managed code. Windows Forms, System.IO, and drawing classes come from the .NET Framework." &
            vbCrLf & vbCrLf &
            "Open the MDI lab, choose File > New Note twice, and type something different in each document. " &
            "Use the Window menu to switch between notes, cascade them, or tile them. " &
            "The parent owns the MenuStrip and each note is a child form with its MdiParent set.", launchButton)
        If FollowUpWeek = 10 Then TabControl1.SelectedTab = debugging
        If FollowUpWeek = 11 Then TabControl1.SelectedTab = mdi
    End Sub

    Private Function AddFollowUpTab(title As String, content As String, Optional action As Button = Nothing) As TabPage
        Dim tab As New TabPage(title) With {.Padding = New Padding(8)}
        tab.Controls.Add(New TextBox With {
            .Dock = DockStyle.Fill, .Multiline = True, .ReadOnly = True, .ScrollBars = ScrollBars.Vertical, .Text = content
        })
        If action IsNot Nothing Then tab.Controls.Add(action)
        TabControl1.TabPages.Add(tab)
        ThemeManager.ApplyTheme(tab)
        Return tab
    End Function

    Private Sub OpenMdiLab(sender As Object, e As EventArgs)
        Using lab As New Form With {.Text = "PF101 - MDI Lab",
                                    .IsMdiContainer = True,
                                    .StartPosition = FormStartPosition.CenterParent,
                                    .ClientSize = New Size(760, 470),
                                    .ShowInTaskbar = False}
            Dim menu As New MenuStrip()
            Dim fileMenu As New ToolStripMenuItem("&File")
            Dim windowMenu As New ToolStripMenuItem("&Window")
            menu.Items.AddRange(New ToolStripItem() {fileMenu, windowMenu})
            menu.MdiWindowListItem = windowMenu
            lab.MainMenuStrip = menu
            lab.Controls.Add(menu)

            Dim nextNote As Integer = 0
            Dim openNote As EventHandler =
                Sub(item, args)
                    nextNote += 1
                    Dim note As New Form With {.Text = "Note " & nextNote.ToString(),
                                               .MdiParent = lab, .ClientSize = New Size(310, 190)}
                    note.Controls.Add(New TextBox With {.Multiline = True, .Dock = DockStyle.Fill,
                                                        .AcceptsReturn = True, .ScrollBars = ScrollBars.Vertical})
                    ThemeManager.ApplyTheme(note)
                    note.Show()
                End Sub

            fileMenu.DropDownItems.Add("&New Note", Nothing, openNote)
            fileMenu.DropDownItems.Add("Close &Active Note", Nothing, Sub(item, args) lab.ActiveMdiChild?.Close())
            windowMenu.DropDownItems.Add("&Cascade", Nothing, Sub(item, args) lab.LayoutMdi(MdiLayout.Cascade))
            windowMenu.DropDownItems.Add("&Tile Vertically", Nothing, Sub(item, args) lab.LayoutMdi(MdiLayout.TileVertical))
            ThemeManager.ApplyTheme(lab)
            lab.ShowDialog(TopLevelControl)
        End Using
    End Sub

End Class