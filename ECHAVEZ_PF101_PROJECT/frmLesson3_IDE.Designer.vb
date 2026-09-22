<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLesson3_IDE
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabIDE = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtIDEDetails = New System.Windows.Forms.TextBox()
        Me.lstIDEComponents = New System.Windows.Forms.ListBox()
        Me.tabElements = New System.Windows.Forms.TabPage()
        Me.tabConsole = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtConsoleScreen = New System.Windows.Forms.TextBox()
        Me.btnClearConsole = New System.Windows.Forms.Button()
        Me.btnRunConsole = New System.Windows.Forms.Button()
        Me.txtConsoleInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLanguageElements = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.tabIDE.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabElements.SuspendLayout()
        Me.tabConsole.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabIDE)
        Me.TabControl1.Controls.Add(Me.tabElements)
        Me.TabControl1.Controls.Add(Me.tabConsole)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(804, 461)
        Me.TabControl1.TabIndex = 0
        '
        'tabIDE
        '
        Me.tabIDE.Controls.Add(Me.GroupBox1)
        Me.tabIDE.Controls.Add(Me.lstIDEComponents)
        Me.tabIDE.Location = New System.Drawing.Point(4, 22)
        Me.tabIDE.Name = "tabIDE"
        Me.tabIDE.Padding = New System.Windows.Forms.Padding(3)
        Me.tabIDE.Size = New System.Drawing.Size(796, 435)
        Me.tabIDE.TabIndex = 0
        Me.tabIDE.Text = "IDE Anatomy & Windows"
        Me.tabIDE.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtIDEDetails)
        Me.GroupBox1.Location = New System.Drawing.Point(260, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(510, 390)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Component Details & Shortcut Reference"
        '
        'txtIDEDetails
        '
        Me.txtIDEDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtIDEDetails.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtIDEDetails.Location = New System.Drawing.Point(3, 16)
        Me.txtIDEDetails.Multiline = True
        Me.txtIDEDetails.Name = "txtIDEDetails"
        Me.txtIDEDetails.ReadOnly = True
        Me.txtIDEDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIDEDetails.Size = New System.Drawing.Size(504, 371)
        Me.txtIDEDetails.TabIndex = 0
        '
        'lstIDEComponents
        '
        Me.lstIDEComponents.FormattingEnabled = True
        Me.lstIDEComponents.Location = New System.Drawing.Point(20, 20)
        Me.lstIDEComponents.Name = "lstIDEComponents"
        Me.lstIDEComponents.Size = New System.Drawing.Size(220, 368)
        Me.lstIDEComponents.TabIndex = 0
        '
        'tabElements
        '
        Me.tabElements.Controls.Add(Me.txtLanguageElements)
        Me.tabElements.Location = New System.Drawing.Point(4, 22)
        Me.tabElements.Name = "tabElements"
        Me.tabElements.Padding = New System.Windows.Forms.Padding(3)
        Me.tabElements.Size = New System.Drawing.Size(796, 435)
        Me.tabElements.TabIndex = 1
        Me.tabElements.Text = "Language Elements & Translators"
        Me.tabElements.UseVisualStyleBackColor = True
        '
        'tabConsole
        '
        Me.tabConsole.Controls.Add(Me.GroupBox2)
        Me.tabConsole.Controls.Add(Me.btnClearConsole)
        Me.tabConsole.Controls.Add(Me.btnRunConsole)
        Me.tabConsole.Controls.Add(Me.txtConsoleInput)
        Me.tabConsole.Controls.Add(Me.Label1)
        Me.tabConsole.Location = New System.Drawing.Point(4, 22)
        Me.tabConsole.Name = "tabConsole"
        Me.tabConsole.Size = New System.Drawing.Size(796, 435)
        Me.tabConsole.TabIndex = 2
        Me.tabConsole.Text = "Console Application Runner"
        Me.tabConsole.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtConsoleScreen)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(750, 320)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Command Prompt Simulation (DOS Shell / System.Console)"
        '
        'txtConsoleScreen
        '
        Me.txtConsoleScreen.BackColor = System.Drawing.SystemColors.WindowText
        Me.txtConsoleScreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtConsoleScreen.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.txtConsoleScreen.ForeColor = System.Drawing.SystemColors.Window
        Me.txtConsoleScreen.Location = New System.Drawing.Point(3, 16)
        Me.txtConsoleScreen.Multiline = True
        Me.txtConsoleScreen.Name = "txtConsoleScreen"
        Me.txtConsoleScreen.ReadOnly = True
        Me.txtConsoleScreen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConsoleScreen.Size = New System.Drawing.Size(744, 301)
        Me.txtConsoleScreen.TabIndex = 0
        '
        'btnClearConsole
        '
        Me.btnClearConsole.Location = New System.Drawing.Point(530, 43)
        Me.btnClearConsole.Name = "btnClearConsole"
        Me.btnClearConsole.Size = New System.Drawing.Size(110, 26)
        Me.btnClearConsole.TabIndex = 3
        Me.btnClearConsole.Text = "Clear Screen"
        Me.btnClearConsole.UseVisualStyleBackColor = True
        '
        'btnRunConsole
        '
        Me.btnRunConsole.Location = New System.Drawing.Point(350, 43)
        Me.btnRunConsole.Name = "btnRunConsole"
        Me.btnRunConsole.Size = New System.Drawing.Size(170, 26)
        Me.btnRunConsole.TabIndex = 2
        Me.btnRunConsole.Text = "Execute Sub Main() [F5]"
        Me.btnRunConsole.UseVisualStyleBackColor = True
        '
        'txtConsoleInput
        '
        Me.txtConsoleInput.Location = New System.Drawing.Point(20, 45)
        Me.txtConsoleInput.Name = "txtConsoleInput"
        Me.txtConsoleInput.Size = New System.Drawing.Size(320, 20)
        Me.txtConsoleInput.TabIndex = 1
        Me.txtConsoleInput.Text = "This is my first Console Application"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Text to Print in Console:"
        '
        'txtLanguageElements
        '
        Me.txtLanguageElements.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLanguageElements.Font = New System.Drawing.Font("Consolas", 9.5!)
        Me.txtLanguageElements.Location = New System.Drawing.Point(3, 3)
        Me.txtLanguageElements.Multiline = True
        Me.txtLanguageElements.Name = "txtLanguageElements"
        Me.txtLanguageElements.ReadOnly = True
        Me.txtLanguageElements.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLanguageElements.Size = New System.Drawing.Size(790, 429)
        Me.txtLanguageElements.TabIndex = 0
        '
        'frmLesson3_IDE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 461)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmLesson3_IDE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lesson 3 - Getting Started with Microsoft Visual Basic .NET"
        Me.TabControl1.ResumeLayout(False)
        Me.tabIDE.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabElements.ResumeLayout(False)
        Me.tabElements.PerformLayout()
        Me.tabConsole.ResumeLayout(False)
        Me.tabConsole.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabIDE As TabPage
    Friend WithEvents tabElements As TabPage
    Friend WithEvents tabConsole As TabPage
    Friend WithEvents lstIDEComponents As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtIDEDetails As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtConsoleInput As TextBox
    Friend WithEvents btnRunConsole As Button
    Friend WithEvents btnClearConsole As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtConsoleScreen As TextBox
    Friend WithEvents txtLanguageElements As TextBox
End Class
