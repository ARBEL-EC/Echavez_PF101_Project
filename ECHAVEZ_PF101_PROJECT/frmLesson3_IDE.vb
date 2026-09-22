Public Class frmLesson3_IDE

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
    End Sub

    ' Update Component Description on selection change
    Private Sub lstIDEComponents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstIDEComponents.SelectedIndexChanged
        Select Case lstIDEComponents.SelectedItem.ToString()
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
            "        Read()" & vbCrLf &
            "    End Sub" & vbCrLf &
            "End Module" & vbCrLf &
            "------------------------------------------------------------------" & vbCrLf
    End Sub

End Class