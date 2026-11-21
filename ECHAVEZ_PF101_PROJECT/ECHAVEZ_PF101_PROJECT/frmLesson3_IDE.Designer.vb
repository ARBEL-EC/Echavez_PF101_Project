<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLesson3_IDE
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rootLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.headerLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.lblHeaderSubtitle = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabIDE = New System.Windows.Forms.TabPage()
        Me.ideLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.lstIDEComponents = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtIDEDetails = New System.Windows.Forms.TextBox()
        Me.tabElements = New System.Windows.Forms.TabPage()
        Me.txtLanguageElements = New System.Windows.Forms.TextBox()
        Me.tabConsole = New System.Windows.Forms.TabPage()
        Me.consoleLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConsoleInput = New System.Windows.Forms.TextBox()
        Me.consoleActions = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnRunConsole = New System.Windows.Forms.Button()
        Me.btnClearConsole = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtConsoleScreen = New System.Windows.Forms.TextBox()
        Me.rootLayout.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.headerLayout.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabIDE.SuspendLayout()
        Me.ideLayout.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabElements.SuspendLayout()
        Me.tabConsole.SuspendLayout()
        Me.consoleLayout.SuspendLayout()
        Me.consoleActions.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'rootLayout
        '
        Me.rootLayout.BackColor = System.Drawing.Color.FromArgb(15, 17, 23)
        Me.rootLayout.ColumnCount = 1
        Me.rootLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.rootLayout.Controls.Add(Me.pnlHeader, 0, 0)
        Me.rootLayout.Controls.Add(Me.TabControl1, 0, 1)
        Me.rootLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rootLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.rootLayout.Name = "rootLayout"
        Me.rootLayout.Padding = New System.Windows.Forms.Padding(16)
        Me.rootLayout.RowCount = 2
        Me.rootLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.rootLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.rootLayout.TabIndex = 0
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(26, 30, 38)
        Me.pnlHeader.Controls.Add(Me.headerLayout)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(0, 0, 0, 12)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Padding = New System.Windows.Forms.Padding(18, 8, 18, 8)
        Me.pnlHeader.TabIndex = 0
        '
        'headerLayout
        '
        Me.headerLayout.BackColor = System.Drawing.Color.FromArgb(26, 30, 38)
        Me.headerLayout.ColumnCount = 1
        Me.headerLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.headerLayout.Controls.Add(Me.lblHeaderTitle, 0, 0)
        Me.headerLayout.Controls.Add(Me.lblHeaderSubtitle, 0, 1)
        Me.headerLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.headerLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.headerLayout.Name = "headerLayout"
        Me.headerLayout.RowCount = 2
        Me.headerLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.headerLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.headerLayout.TabIndex = 0
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.lblHeaderTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "Visual Basic .NET Development"
        '
        'lblHeaderSubtitle
        '
        Me.lblHeaderSubtitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblHeaderSubtitle.AutoSize = True
        Me.lblHeaderSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184)
        Me.lblHeaderSubtitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHeaderSubtitle.Name = "lblHeaderSubtitle"
        Me.lblHeaderSubtitle.TabIndex = 1
        Me.lblHeaderSubtitle.Text = "Explore the IDE, core language concepts, and a simulated console application."
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabIDE)
        Me.TabControl1.Controls.Add(Me.tabElements)
        Me.TabControl1.Controls.Add(Me.tabConsole)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.TabIndex = 1
        '
        'tabIDE
        '
        Me.tabIDE.Controls.Add(Me.ideLayout)
        Me.tabIDE.Name = "tabIDE"
        Me.tabIDE.Padding = New System.Windows.Forms.Padding(8)
        Me.tabIDE.TabIndex = 0
        Me.tabIDE.Text = "IDE Anatomy & Windows"
        Me.tabIDE.UseVisualStyleBackColor = True
        '
        'ideLayout
        '
        Me.ideLayout.ColumnCount = 2
        Me.ideLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.0!))
        Me.ideLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.0!))
        Me.ideLayout.Controls.Add(Me.lstIDEComponents, 0, 0)
        Me.ideLayout.Controls.Add(Me.GroupBox1, 1, 0)
        Me.ideLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ideLayout.Name = "ideLayout"
        Me.ideLayout.Padding = New System.Windows.Forms.Padding(4)
        Me.ideLayout.RowCount = 1
        Me.ideLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ideLayout.TabIndex = 0
        '
        'lstIDEComponents
        '
        Me.lstIDEComponents.BackColor = System.Drawing.Color.FromArgb(38, 44, 58)
        Me.lstIDEComponents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstIDEComponents.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.lstIDEComponents.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.lstIDEComponents.FormattingEnabled = True
        Me.lstIDEComponents.IntegralHeight = False
        Me.lstIDEComponents.ItemHeight = 17
        Me.lstIDEComponents.Margin = New System.Windows.Forms.Padding(6)
        Me.lstIDEComponents.Name = "lstIDEComponents"
        Me.lstIDEComponents.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(26, 30, 38)
        Me.GroupBox1.Controls.Add(Me.txtIDEDetails)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Component Details & Shortcut Reference"
        '
        'txtIDEDetails
        '
        Me.txtIDEDetails.BackColor = System.Drawing.Color.FromArgb(38, 44, 58)
        Me.txtIDEDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIDEDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtIDEDetails.Font = New System.Drawing.Font("Consolas", 9.5!, System.Drawing.FontStyle.Regular)
        Me.txtIDEDetails.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.txtIDEDetails.Margin = New System.Windows.Forms.Padding(6)
        Me.txtIDEDetails.Multiline = True
        Me.txtIDEDetails.Name = "txtIDEDetails"
        Me.txtIDEDetails.ReadOnly = True
        Me.txtIDEDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIDEDetails.TabIndex = 0
        '
        'tabElements
        '
        Me.tabElements.Controls.Add(Me.txtLanguageElements)
        Me.tabElements.Name = "tabElements"
        Me.tabElements.Padding = New System.Windows.Forms.Padding(8)
        Me.tabElements.TabIndex = 1
        Me.tabElements.Text = "Language Elements & Translators"
        Me.tabElements.UseVisualStyleBackColor = True
        '
        'txtLanguageElements
        '
        Me.txtLanguageElements.BackColor = System.Drawing.Color.FromArgb(38, 44, 58)
        Me.txtLanguageElements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLanguageElements.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLanguageElements.Font = New System.Drawing.Font("Consolas", 9.5!, System.Drawing.FontStyle.Regular)
        Me.txtLanguageElements.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.txtLanguageElements.Margin = New System.Windows.Forms.Padding(6)
        Me.txtLanguageElements.Multiline = True
        Me.txtLanguageElements.Name = "txtLanguageElements"
        Me.txtLanguageElements.ReadOnly = True
        Me.txtLanguageElements.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLanguageElements.TabIndex = 0
        Me.txtLanguageElements.WordWrap = False
        '
        'tabConsole
        '
        Me.tabConsole.Controls.Add(Me.consoleLayout)
        Me.tabConsole.Name = "tabConsole"
        Me.tabConsole.Padding = New System.Windows.Forms.Padding(8)
        Me.tabConsole.TabIndex = 2
        Me.tabConsole.Text = "Console Application Runner"
        Me.tabConsole.UseVisualStyleBackColor = True
        '
        'consoleLayout
        '
        Me.consoleLayout.ColumnCount = 1
        Me.consoleLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.consoleLayout.Controls.Add(Me.Label1, 0, 0)
        Me.consoleLayout.Controls.Add(Me.txtConsoleInput, 0, 1)
        Me.consoleLayout.Controls.Add(Me.consoleActions, 0, 2)
        Me.consoleLayout.Controls.Add(Me.GroupBox2, 0, 3)
        Me.consoleLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.consoleLayout.Name = "consoleLayout"
        Me.consoleLayout.Padding = New System.Windows.Forms.Padding(4)
        Me.consoleLayout.RowCount = 4
        Me.consoleLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.consoleLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.consoleLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.consoleLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.consoleLayout.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter text to print in the console:"
        '
        'txtConsoleInput
        '
        Me.txtConsoleInput.Anchor = System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        Me.txtConsoleInput.BackColor = System.Drawing.Color.FromArgb(38, 44, 58)
        Me.txtConsoleInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConsoleInput.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.txtConsoleInput.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.txtConsoleInput.Margin = New System.Windows.Forms.Padding(6)
        Me.txtConsoleInput.Name = "txtConsoleInput"
        Me.txtConsoleInput.TabIndex = 1
        Me.txtConsoleInput.Text = "This is my first Console Application"
        '
        'consoleActions
        '
        Me.consoleActions.AutoScroll = True
        Me.consoleActions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.consoleActions.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight
        Me.consoleActions.Margin = New System.Windows.Forms.Padding(0)
        Me.consoleActions.Name = "consoleActions"
        Me.consoleActions.Padding = New System.Windows.Forms.Padding(2)
        Me.consoleActions.WrapContents = True
        Me.consoleActions.Controls.Add(Me.btnRunConsole)
        Me.consoleActions.Controls.Add(Me.btnClearConsole)
        Me.consoleActions.TabIndex = 2
        '
        'btnRunConsole
        '
        Me.btnRunConsole.BackColor = System.Drawing.Color.FromArgb(37, 99, 235)
        Me.btnRunConsole.FlatAppearance.BorderSize = 0
        Me.btnRunConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRunConsole.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnRunConsole.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.btnRunConsole.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRunConsole.Name = "btnRunConsole"
        Me.btnRunConsole.Size = New System.Drawing.Size(220, 36)
        Me.btnRunConsole.TabIndex = 2
        Me.btnRunConsole.Text = "Execute Sub Main() [F5]"
        Me.btnRunConsole.UseVisualStyleBackColor = False
        '
        'btnClearConsole
        '
        Me.btnClearConsole.BackColor = System.Drawing.Color.FromArgb(38, 44, 58)
        Me.btnClearConsole.FlatAppearance.BorderSize = 0
        Me.btnClearConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearConsole.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnClearConsole.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.btnClearConsole.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClearConsole.Name = "btnClearConsole"
        Me.btnClearConsole.Size = New System.Drawing.Size(150, 36)
        Me.btnClearConsole.TabIndex = 3
        Me.btnClearConsole.Text = "Clear Screen"
        Me.btnClearConsole.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(26, 30, 38)
        Me.GroupBox2.Controls.Add(Me.txtConsoleScreen)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Command Prompt Simulation - System.Console"
        '
        'txtConsoleScreen
        '
        Me.txtConsoleScreen.BackColor = System.Drawing.Color.FromArgb(15, 17, 23)
        Me.txtConsoleScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConsoleScreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtConsoleScreen.Font = New System.Drawing.Font("Consolas", 9.5!, System.Drawing.FontStyle.Regular)
        Me.txtConsoleScreen.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.txtConsoleScreen.Margin = New System.Windows.Forms.Padding(6)
        Me.txtConsoleScreen.Multiline = True
        Me.txtConsoleScreen.Name = "txtConsoleScreen"
        Me.txtConsoleScreen.ReadOnly = True
        Me.txtConsoleScreen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConsoleScreen.TabIndex = 0
        '
        'frmLesson3_IDE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(15, 17, 23)
        Me.ClientSize = New System.Drawing.Size(1040, 700)
        Me.Controls.Add(Me.rootLayout)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.MinimumSize = New System.Drawing.Size(820, 580)
        Me.Name = "frmLesson3_IDE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Getting Started with Visual Basic .NET"
        Me.rootLayout.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.headerLayout.ResumeLayout(False)
        Me.headerLayout.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabIDE.ResumeLayout(False)
        Me.ideLayout.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabElements.ResumeLayout(False)
        Me.tabElements.PerformLayout()
        Me.tabConsole.ResumeLayout(False)
        Me.consoleLayout.ResumeLayout(False)
        Me.consoleLayout.PerformLayout()
        Me.consoleActions.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents rootLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents headerLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblHeaderTitle As System.Windows.Forms.Label
    Friend WithEvents lblHeaderSubtitle As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabIDE As System.Windows.Forms.TabPage
    Friend WithEvents tabElements As System.Windows.Forms.TabPage
    Friend WithEvents tabConsole As System.Windows.Forms.TabPage
    Friend WithEvents ideLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lstIDEComponents As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtIDEDetails As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtConsoleInput As System.Windows.Forms.TextBox
    Friend WithEvents btnRunConsole As System.Windows.Forms.Button
    Friend WithEvents btnClearConsole As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtConsoleScreen As System.Windows.Forms.TextBox
    Friend WithEvents txtLanguageElements As System.Windows.Forms.TextBox
    Friend WithEvents consoleLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents consoleActions As System.Windows.Forms.FlowLayoutPanel
End Class
