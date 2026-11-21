<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLesson6_SelectionRepetition
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
        Me.components = New System.ComponentModel.Container()
        Me.rootLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.headerLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.lblHeaderSubtitle = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabDecision = New System.Windows.Forms.TabPage()
        Me.decisionLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.decisionContentLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.inputLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGradeInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboDecisionMode = New System.Windows.Forms.ComboBox()
        Me.chkGoodMoral = New System.Windows.Forms.CheckBox()
        Me.btnEvaluateGrade = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDecisionOutput = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDecisionTheory = New System.Windows.Forms.TextBox()
        Me.tabLoops = New System.Windows.Forms.TabPage()
        Me.loopLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.loopContentLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.loopInputLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboLoopType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLoopStart = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLoopEnd = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLoopStep = New System.Windows.Forms.TextBox()
        Me.chkUseBreak = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnExecuteLoop = New System.Windows.Forms.Button()
        Me.lstLoopResults = New System.Windows.Forms.ListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtLoopTheory = New System.Windows.Forms.TextBox()
        Me.tabStringLoop = New System.Windows.Forms.TabPage()
        Me.stringLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.stringContentLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.stringInputLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtStringInput = New System.Windows.Forms.TextBox()
        Me.btnAnalyzeString = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.nudDays = New System.Windows.Forms.NumericUpDown()
        Me.btnGenerateDates = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtStringOutput = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtStringTheory = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.rootLayout.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.headerLayout.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabDecision.SuspendLayout()
        Me.decisionLayout.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.decisionContentLayout.SuspendLayout()
        Me.inputLayout.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tabLoops.SuspendLayout()
        Me.loopLayout.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.loopContentLayout.SuspendLayout()
        Me.loopInputLayout.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.tabStringLoop.SuspendLayout()
        Me.stringLayout.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.stringContentLayout.SuspendLayout()
        Me.stringInputLayout.SuspendLayout()
        CType(Me.nudDays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'rootLayout
        '
        Me.rootLayout.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.rootLayout.ColumnCount = 1
        Me.rootLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.rootLayout.Controls.Add(Me.pnlHeader, 0, 0)
        Me.rootLayout.Controls.Add(Me.TabControl1, 0, 1)
        Me.rootLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rootLayout.Location = New System.Drawing.Point(0, 0)
        Me.rootLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.rootLayout.Name = "rootLayout"
        Me.rootLayout.Padding = New System.Windows.Forms.Padding(16)
        Me.rootLayout.RowCount = 2
        Me.rootLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.rootLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.rootLayout.Size = New System.Drawing.Size(1040, 700)
        Me.rootLayout.TabIndex = 0
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.headerLayout)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHeader.Location = New System.Drawing.Point(16, 16)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(0, 0, 0, 12)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Padding = New System.Windows.Forms.Padding(18, 8, 18, 8)
        Me.pnlHeader.Size = New System.Drawing.Size(1008, 80)
        Me.pnlHeader.TabIndex = 0
        '
        'headerLayout
        '
        Me.headerLayout.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.headerLayout.ColumnCount = 1
        Me.headerLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.headerLayout.Controls.Add(Me.lblHeaderTitle, 0, 0)
        Me.headerLayout.Controls.Add(Me.lblHeaderSubtitle, 0, 1)
        Me.headerLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.headerLayout.Location = New System.Drawing.Point(18, 8)
        Me.headerLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.headerLayout.Name = "headerLayout"
        Me.headerLayout.RowCount = 2
        Me.headerLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.headerLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.headerLayout.Size = New System.Drawing.Size(972, 64)
        Me.headerLayout.TabIndex = 0
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblHeaderTitle.Location = New System.Drawing.Point(0, 3)
        Me.lblHeaderTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(352, 31)
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "Selection & Repetition Structures"
        '
        'lblHeaderSubtitle
        '
        Me.lblHeaderSubtitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblHeaderSubtitle.AutoSize = True
        Me.lblHeaderSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblHeaderSubtitle.Location = New System.Drawing.Point(0, 42)
        Me.lblHeaderSubtitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHeaderSubtitle.Name = "lblHeaderSubtitle"
        Me.lblHeaderSubtitle.Size = New System.Drawing.Size(422, 17)
        Me.lblHeaderSubtitle.TabIndex = 1
        Me.lblHeaderSubtitle.Text = "Evaluate decisions, execute loop traces, and process strings and dates."
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabDecision)
        Me.TabControl1.Controls.Add(Me.tabLoops)
        Me.TabControl1.Controls.Add(Me.tabStringLoop)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.TabControl1.Location = New System.Drawing.Point(19, 111)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1002, 570)
        Me.TabControl1.TabIndex = 0
        '
        'tabDecision
        '
        Me.tabDecision.Controls.Add(Me.decisionLayout)
        Me.tabDecision.Location = New System.Drawing.Point(4, 26)
        Me.tabDecision.Name = "tabDecision"
        Me.tabDecision.Padding = New System.Windows.Forms.Padding(8)
        Me.tabDecision.Size = New System.Drawing.Size(994, 540)
        Me.tabDecision.TabIndex = 0
        Me.tabDecision.Text = "Decision Structures (If & Select Case)"
        Me.tabDecision.UseVisualStyleBackColor = True
        '
        'decisionLayout
        '
        Me.decisionLayout.ColumnCount = 2
        Me.decisionLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.0!))
        Me.decisionLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.0!))
        Me.decisionLayout.Controls.Add(Me.GroupBox1, 0, 0)
        Me.decisionLayout.Controls.Add(Me.GroupBox2, 1, 0)
        Me.decisionLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.decisionLayout.Location = New System.Drawing.Point(8, 8)
        Me.decisionLayout.Name = "decisionLayout"
        Me.decisionLayout.Padding = New System.Windows.Forms.Padding(4)
        Me.decisionLayout.RowCount = 1
        Me.decisionLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.decisionLayout.Size = New System.Drawing.Size(978, 524)
        Me.decisionLayout.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.decisionContentLayout)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBox1.Size = New System.Drawing.Size(453, 504)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Interactive Academic Evaluation Engine"
        '
        'decisionContentLayout
        '
        Me.decisionContentLayout.ColumnCount = 1
        Me.decisionContentLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.decisionContentLayout.Controls.Add(Me.inputLayout, 0, 0)
        Me.decisionContentLayout.Controls.Add(Me.Label3, 0, 1)
        Me.decisionContentLayout.Controls.Add(Me.txtDecisionOutput, 0, 2)
        Me.decisionContentLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.decisionContentLayout.Location = New System.Drawing.Point(12, 29)
        Me.decisionContentLayout.Name = "decisionContentLayout"
        Me.decisionContentLayout.Padding = New System.Windows.Forms.Padding(6)
        Me.decisionContentLayout.RowCount = 3
        Me.decisionContentLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210.0!))
        Me.decisionContentLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.decisionContentLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.decisionContentLayout.Size = New System.Drawing.Size(429, 463)
        Me.decisionContentLayout.TabIndex = 0
        '
        'inputLayout
        '
        Me.inputLayout.ColumnCount = 2
        Me.inputLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.inputLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.inputLayout.Controls.Add(Me.Label1, 0, 0)
        Me.inputLayout.Controls.Add(Me.txtGradeInput, 1, 0)
        Me.inputLayout.Controls.Add(Me.Label2, 0, 1)
        Me.inputLayout.Controls.Add(Me.cboDecisionMode, 1, 1)
        Me.inputLayout.Controls.Add(Me.chkGoodMoral, 0, 2)
        Me.inputLayout.Controls.Add(Me.btnEvaluateGrade, 0, 3)
        Me.inputLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inputLayout.Location = New System.Drawing.Point(9, 9)
        Me.inputLayout.Name = "inputLayout"
        Me.inputLayout.Padding = New System.Windows.Forms.Padding(6)
        Me.inputLayout.RowCount = 4
        Me.inputLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.inputLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.inputLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.inputLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.inputLayout.Size = New System.Drawing.Size(411, 204)
        Me.inputLayout.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numerical Grade (0 - 100):"
        '
        'txtGradeInput
        '
        Me.txtGradeInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGradeInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.txtGradeInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGradeInput.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtGradeInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtGradeInput.Location = New System.Drawing.Point(191, 18)
        Me.txtGradeInput.Margin = New System.Windows.Forms.Padding(6)
        Me.txtGradeInput.Name = "txtGradeInput"
        Me.txtGradeInput.Size = New System.Drawing.Size(208, 24)
        Me.txtGradeInput.TabIndex = 1
        Me.txtGradeInput.Text = "94.5"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Evaluation Strategy:"
        '
        'cboDecisionMode
        '
        Me.cboDecisionMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDecisionMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.cboDecisionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDecisionMode.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cboDecisionMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cboDecisionMode.FormattingEnabled = True
        Me.cboDecisionMode.Location = New System.Drawing.Point(191, 68)
        Me.cboDecisionMode.Margin = New System.Windows.Forms.Padding(6)
        Me.cboDecisionMode.Name = "cboDecisionMode"
        Me.cboDecisionMode.Size = New System.Drawing.Size(208, 25)
        Me.cboDecisionMode.TabIndex = 2
        '
        'chkGoodMoral
        '
        Me.chkGoodMoral.Checked = True
        Me.chkGoodMoral.CheckState = System.Windows.Forms.CheckState.Checked
        Me.inputLayout.SetColumnSpan(Me.chkGoodMoral, 2)
        Me.chkGoodMoral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkGoodMoral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkGoodMoral.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.chkGoodMoral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.chkGoodMoral.Location = New System.Drawing.Point(12, 114)
        Me.chkGoodMoral.Margin = New System.Windows.Forms.Padding(6)
        Me.chkGoodMoral.Name = "chkGoodMoral"
        Me.chkGoodMoral.Size = New System.Drawing.Size(387, 34)
        Me.chkGoodMoral.TabIndex = 3
        Me.chkGoodMoral.Text = "Has Good Moral Record (Required for Honors)"
        Me.chkGoodMoral.UseVisualStyleBackColor = True
        '
        'btnEvaluateGrade
        '
        Me.btnEvaluateGrade.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.inputLayout.SetColumnSpan(Me.btnEvaluateGrade, 2)
        Me.btnEvaluateGrade.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEvaluateGrade.FlatAppearance.BorderSize = 0
        Me.btnEvaluateGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEvaluateGrade.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnEvaluateGrade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnEvaluateGrade.Location = New System.Drawing.Point(12, 160)
        Me.btnEvaluateGrade.Margin = New System.Windows.Forms.Padding(6)
        Me.btnEvaluateGrade.MinimumSize = New System.Drawing.Size(160, 36)
        Me.btnEvaluateGrade.Name = "btnEvaluateGrade"
        Me.btnEvaluateGrade.Size = New System.Drawing.Size(387, 36)
        Me.btnEvaluateGrade.TabIndex = 4
        Me.btnEvaluateGrade.Text = "Evaluate Decision Branching"
        Me.btnEvaluateGrade.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 225)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Evaluation Result & Diagnostic Trace:"
        '
        'txtDecisionOutput
        '
        Me.txtDecisionOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.txtDecisionOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDecisionOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDecisionOutput.Font = New System.Drawing.Font("Consolas", 9.5!)
        Me.txtDecisionOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtDecisionOutput.Location = New System.Drawing.Point(12, 258)
        Me.txtDecisionOutput.Margin = New System.Windows.Forms.Padding(6)
        Me.txtDecisionOutput.Multiline = True
        Me.txtDecisionOutput.Name = "txtDecisionOutput"
        Me.txtDecisionOutput.ReadOnly = True
        Me.txtDecisionOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDecisionOutput.Size = New System.Drawing.Size(405, 193)
        Me.txtDecisionOutput.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.txtDecisionTheory)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(475, 10)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBox2.Size = New System.Drawing.Size(493, 504)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Decision Structure Architecture"
        '
        'txtDecisionTheory
        '
        Me.txtDecisionTheory.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.txtDecisionTheory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDecisionTheory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDecisionTheory.Font = New System.Drawing.Font("Consolas", 9.5!)
        Me.txtDecisionTheory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtDecisionTheory.Location = New System.Drawing.Point(12, 29)
        Me.txtDecisionTheory.Margin = New System.Windows.Forms.Padding(6)
        Me.txtDecisionTheory.Multiline = True
        Me.txtDecisionTheory.Name = "txtDecisionTheory"
        Me.txtDecisionTheory.ReadOnly = True
        Me.txtDecisionTheory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDecisionTheory.Size = New System.Drawing.Size(469, 463)
        Me.txtDecisionTheory.TabIndex = 0
        '
        'tabLoops
        '
        Me.tabLoops.Controls.Add(Me.loopLayout)
        Me.tabLoops.Location = New System.Drawing.Point(4, 26)
        Me.tabLoops.Name = "tabLoops"
        Me.tabLoops.Padding = New System.Windows.Forms.Padding(8)
        Me.tabLoops.Size = New System.Drawing.Size(994, 540)
        Me.tabLoops.TabIndex = 1
        Me.tabLoops.Text = "Repetition Structures (Loops)"
        Me.tabLoops.UseVisualStyleBackColor = True
        '
        'loopLayout
        '
        Me.loopLayout.ColumnCount = 2
        Me.loopLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.0!))
        Me.loopLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.0!))
        Me.loopLayout.Controls.Add(Me.GroupBox3, 0, 0)
        Me.loopLayout.Controls.Add(Me.GroupBox4, 1, 0)
        Me.loopLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.loopLayout.Location = New System.Drawing.Point(8, 8)
        Me.loopLayout.Name = "loopLayout"
        Me.loopLayout.Padding = New System.Windows.Forms.Padding(4)
        Me.loopLayout.RowCount = 1
        Me.loopLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.loopLayout.Size = New System.Drawing.Size(978, 524)
        Me.loopLayout.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.loopContentLayout)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBox3.Size = New System.Drawing.Size(492, 504)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Loop Execution Simulator"
        '
        'loopContentLayout
        '
        Me.loopContentLayout.ColumnCount = 1
        Me.loopContentLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.loopContentLayout.Controls.Add(Me.loopInputLayout, 0, 0)
        Me.loopContentLayout.Controls.Add(Me.Label5, 0, 1)
        Me.loopContentLayout.Controls.Add(Me.btnExecuteLoop, 0, 2)
        Me.loopContentLayout.Controls.Add(Me.lstLoopResults, 0, 3)
        Me.loopContentLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.loopContentLayout.Location = New System.Drawing.Point(12, 29)
        Me.loopContentLayout.Name = "loopContentLayout"
        Me.loopContentLayout.Padding = New System.Windows.Forms.Padding(6)
        Me.loopContentLayout.RowCount = 4
        Me.loopContentLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 230.0!))
        Me.loopContentLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.loopContentLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.loopContentLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.loopContentLayout.Size = New System.Drawing.Size(468, 463)
        Me.loopContentLayout.TabIndex = 0
        '
        'loopInputLayout
        '
        Me.loopInputLayout.ColumnCount = 2
        Me.loopInputLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.loopInputLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.loopInputLayout.Controls.Add(Me.Label4, 0, 0)
        Me.loopInputLayout.Controls.Add(Me.cboLoopType, 1, 0)
        Me.loopInputLayout.Controls.Add(Me.Label6, 0, 1)
        Me.loopInputLayout.Controls.Add(Me.txtLoopStart, 1, 1)
        Me.loopInputLayout.Controls.Add(Me.Label7, 0, 2)
        Me.loopInputLayout.Controls.Add(Me.txtLoopEnd, 1, 2)
        Me.loopInputLayout.Controls.Add(Me.Label8, 0, 3)
        Me.loopInputLayout.Controls.Add(Me.txtLoopStep, 1, 3)
        Me.loopInputLayout.Controls.Add(Me.chkUseBreak, 0, 4)
        Me.loopInputLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.loopInputLayout.Location = New System.Drawing.Point(9, 9)
        Me.loopInputLayout.Name = "loopInputLayout"
        Me.loopInputLayout.Padding = New System.Windows.Forms.Padding(6)
        Me.loopInputLayout.RowCount = 5
        Me.loopInputLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.loopInputLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.loopInputLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.loopInputLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.loopInputLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.loopInputLayout.Size = New System.Drawing.Size(450, 224)
        Me.loopInputLayout.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 24)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Loop Construct:"
        '
        'cboLoopType
        '
        Me.cboLoopType.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboLoopType.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.cboLoopType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLoopType.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cboLoopType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cboLoopType.FormattingEnabled = True
        Me.cboLoopType.Location = New System.Drawing.Point(165, 20)
        Me.cboLoopType.Margin = New System.Windows.Forms.Padding(6)
        Me.cboLoopType.Name = "cboLoopType"
        Me.cboLoopType.Size = New System.Drawing.Size(273, 25)
        Me.cboLoopType.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(12, 73)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Start:"
        '
        'txtLoopStart
        '
        Me.txtLoopStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLoopStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.txtLoopStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLoopStart.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtLoopStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtLoopStart.Location = New System.Drawing.Point(165, 70)
        Me.txtLoopStart.Margin = New System.Windows.Forms.Padding(6)
        Me.txtLoopStart.Name = "txtLoopStart"
        Me.txtLoopStart.Size = New System.Drawing.Size(273, 24)
        Me.txtLoopStart.TabIndex = 2
        Me.txtLoopStart.Text = "1"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(12, 117)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "End:"
        '
        'txtLoopEnd
        '
        Me.txtLoopEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLoopEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.txtLoopEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLoopEnd.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtLoopEnd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtLoopEnd.Location = New System.Drawing.Point(165, 114)
        Me.txtLoopEnd.Margin = New System.Windows.Forms.Padding(6)
        Me.txtLoopEnd.Name = "txtLoopEnd"
        Me.txtLoopEnd.Size = New System.Drawing.Size(273, 24)
        Me.txtLoopEnd.TabIndex = 3
        Me.txtLoopEnd.Text = "10"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(12, 161)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 17)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Step:"
        '
        'txtLoopStep
        '
        Me.txtLoopStep.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLoopStep.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.txtLoopStep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLoopStep.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtLoopStep.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtLoopStep.Location = New System.Drawing.Point(165, 158)
        Me.txtLoopStep.Margin = New System.Windows.Forms.Padding(6)
        Me.txtLoopStep.Name = "txtLoopStep"
        Me.txtLoopStep.Size = New System.Drawing.Size(273, 24)
        Me.txtLoopStep.TabIndex = 4
        Me.txtLoopStep.Text = "1"
        '
        'chkUseBreak
        '
        Me.loopInputLayout.SetColumnSpan(Me.chkUseBreak, 2)
        Me.chkUseBreak.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkUseBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkUseBreak.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.chkUseBreak.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.chkUseBreak.Location = New System.Drawing.Point(12, 198)
        Me.chkUseBreak.Margin = New System.Windows.Forms.Padding(6)
        Me.chkUseBreak.MinimumSize = New System.Drawing.Size(320, 28)
        Me.chkUseBreak.Name = "chkUseBreak"
        Me.chkUseBreak.Size = New System.Drawing.Size(426, 28)
        Me.chkUseBreak.TabIndex = 5
        Me.chkUseBreak.Text = "Exit loop when the counter reaches 7"
        Me.chkUseBreak.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 245)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(280, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Configure a loop and inspect each iteration:"
        '
        'btnExecuteLoop
        '
        Me.btnExecuteLoop.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnExecuteLoop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnExecuteLoop.FlatAppearance.BorderSize = 0
        Me.btnExecuteLoop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExecuteLoop.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnExecuteLoop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnExecuteLoop.Location = New System.Drawing.Point(12, 278)
        Me.btnExecuteLoop.Margin = New System.Windows.Forms.Padding(6)
        Me.btnExecuteLoop.MinimumSize = New System.Drawing.Size(160, 36)
        Me.btnExecuteLoop.Name = "btnExecuteLoop"
        Me.btnExecuteLoop.Size = New System.Drawing.Size(444, 42)
        Me.btnExecuteLoop.TabIndex = 6
        Me.btnExecuteLoop.Text = "Execute Loop Cycle"
        Me.btnExecuteLoop.UseVisualStyleBackColor = False
        '
        'lstLoopResults
        '
        Me.lstLoopResults.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lstLoopResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstLoopResults.Font = New System.Drawing.Font("Consolas", 9.5!)
        Me.lstLoopResults.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lstLoopResults.FormattingEnabled = True
        Me.lstLoopResults.IntegralHeight = False
        Me.lstLoopResults.ItemHeight = 15
        Me.lstLoopResults.Location = New System.Drawing.Point(12, 332)
        Me.lstLoopResults.Margin = New System.Windows.Forms.Padding(6)
        Me.lstLoopResults.Name = "lstLoopResults"
        Me.lstLoopResults.Size = New System.Drawing.Size(444, 119)
        Me.lstLoopResults.TabIndex = 7
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.txtLoopTheory)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(514, 10)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBox4.Size = New System.Drawing.Size(454, 504)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Loop Mechanics & Pre/Post-Test Rules"
        '
        'txtLoopTheory
        '
        Me.txtLoopTheory.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.txtLoopTheory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLoopTheory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLoopTheory.Font = New System.Drawing.Font("Consolas", 9.5!)
        Me.txtLoopTheory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtLoopTheory.Location = New System.Drawing.Point(12, 29)
        Me.txtLoopTheory.Margin = New System.Windows.Forms.Padding(6)
        Me.txtLoopTheory.Multiline = True
        Me.txtLoopTheory.Name = "txtLoopTheory"
        Me.txtLoopTheory.ReadOnly = True
        Me.txtLoopTheory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLoopTheory.Size = New System.Drawing.Size(430, 463)
        Me.txtLoopTheory.TabIndex = 0
        '
        'tabStringLoop
        '
        Me.tabStringLoop.Controls.Add(Me.stringLayout)
        Me.tabStringLoop.Location = New System.Drawing.Point(4, 26)
        Me.tabStringLoop.Name = "tabStringLoop"
        Me.tabStringLoop.Padding = New System.Windows.Forms.Padding(8)
        Me.tabStringLoop.Size = New System.Drawing.Size(994, 540)
        Me.tabStringLoop.TabIndex = 2
        Me.tabStringLoop.Text = "String & Date Processing"
        Me.tabStringLoop.UseVisualStyleBackColor = True
        '
        'stringLayout
        '
        Me.stringLayout.ColumnCount = 2
        Me.stringLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.0!))
        Me.stringLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.0!))
        Me.stringLayout.Controls.Add(Me.GroupBox5, 0, 0)
        Me.stringLayout.Controls.Add(Me.GroupBox6, 1, 0)
        Me.stringLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stringLayout.Location = New System.Drawing.Point(8, 8)
        Me.stringLayout.Name = "stringLayout"
        Me.stringLayout.Padding = New System.Windows.Forms.Padding(4)
        Me.stringLayout.RowCount = 1
        Me.stringLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.stringLayout.Size = New System.Drawing.Size(978, 524)
        Me.stringLayout.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.stringContentLayout)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GroupBox5.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBox5.Size = New System.Drawing.Size(492, 504)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "String & Date Iterator"
        '
        'stringContentLayout
        '
        Me.stringContentLayout.ColumnCount = 1
        Me.stringContentLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.stringContentLayout.Controls.Add(Me.stringInputLayout, 0, 0)
        Me.stringContentLayout.Controls.Add(Me.Label10, 0, 1)
        Me.stringContentLayout.Controls.Add(Me.txtStringOutput, 0, 2)
        Me.stringContentLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stringContentLayout.Location = New System.Drawing.Point(12, 29)
        Me.stringContentLayout.Name = "stringContentLayout"
        Me.stringContentLayout.Padding = New System.Windows.Forms.Padding(6)
        Me.stringContentLayout.RowCount = 3
        Me.stringContentLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 290.0!))
        Me.stringContentLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.stringContentLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.stringContentLayout.Size = New System.Drawing.Size(468, 463)
        Me.stringContentLayout.TabIndex = 0
        '
        'stringInputLayout
        '
        Me.stringInputLayout.ColumnCount = 2
        Me.stringInputLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.0!))
        Me.stringInputLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.0!))
        Me.stringInputLayout.Controls.Add(Me.Label9, 0, 0)
        Me.stringInputLayout.Controls.Add(Me.txtStringInput, 1, 0)
        Me.stringInputLayout.Controls.Add(Me.btnAnalyzeString, 0, 1)
        Me.stringInputLayout.Controls.Add(Me.Label11, 0, 2)
        Me.stringInputLayout.Controls.Add(Me.Label12, 0, 3)
        Me.stringInputLayout.Controls.Add(Me.nudDays, 1, 3)
        Me.stringInputLayout.Controls.Add(Me.btnGenerateDates, 0, 4)
        Me.stringInputLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stringInputLayout.Location = New System.Drawing.Point(9, 9)
        Me.stringInputLayout.Name = "stringInputLayout"
        Me.stringInputLayout.Padding = New System.Windows.Forms.Padding(6)
        Me.stringInputLayout.RowCount = 5
        Me.stringInputLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.stringInputLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.stringInputLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.stringInputLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.stringInputLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.stringInputLayout.Size = New System.Drawing.Size(450, 284)
        Me.stringInputLayout.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(12, 26)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(154, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Enter String to Analyze:"
        '
        'txtStringInput
        '
        Me.txtStringInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStringInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.txtStringInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStringInput.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtStringInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtStringInput.Location = New System.Drawing.Point(195, 23)
        Me.txtStringInput.Margin = New System.Windows.Forms.Padding(6)
        Me.txtStringInput.Name = "txtStringInput"
        Me.txtStringInput.Size = New System.Drawing.Size(243, 24)
        Me.txtStringInput.TabIndex = 1
        Me.txtStringInput.Text = "Quezon City University"
        '
        'btnAnalyzeString
        '
        Me.btnAnalyzeString.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.stringInputLayout.SetColumnSpan(Me.btnAnalyzeString, 2)
        Me.btnAnalyzeString.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAnalyzeString.FlatAppearance.BorderSize = 0
        Me.btnAnalyzeString.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnalyzeString.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnAnalyzeString.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnAnalyzeString.Location = New System.Drawing.Point(12, 70)
        Me.btnAnalyzeString.Margin = New System.Windows.Forms.Padding(6)
        Me.btnAnalyzeString.MinimumSize = New System.Drawing.Size(160, 36)
        Me.btnAnalyzeString.Name = "btnAnalyzeString"
        Me.btnAnalyzeString.Size = New System.Drawing.Size(426, 42)
        Me.btnAnalyzeString.TabIndex = 2
        Me.btnAnalyzeString.Text = "Analyze Characters"
        Me.btnAnalyzeString.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label11.AutoSize = True
        Me.stringInputLayout.SetColumnSpan(Me.Label11, 2)
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(12, 136)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(246, 17)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Generate Schedule (Date Range Loop):"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(12, 190)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 17)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Days to Add:"
        '
        'nudDays
        '
        Me.nudDays.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudDays.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.nudDays.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.nudDays.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.nudDays.Location = New System.Drawing.Point(195, 187)
        Me.nudDays.Margin = New System.Windows.Forms.Padding(6)
        Me.nudDays.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.nudDays.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDays.Name = "nudDays"
        Me.nudDays.Size = New System.Drawing.Size(243, 24)
        Me.nudDays.TabIndex = 3
        Me.nudDays.Value = New Decimal(New Integer() {9, 0, 0, 0})
        '
        'btnGenerateDates
        '
        Me.btnGenerateDates.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.stringInputLayout.SetColumnSpan(Me.btnGenerateDates, 2)
        Me.btnGenerateDates.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGenerateDates.FlatAppearance.BorderSize = 0
        Me.btnGenerateDates.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateDates.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnGenerateDates.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnGenerateDates.Location = New System.Drawing.Point(12, 232)
        Me.btnGenerateDates.Margin = New System.Windows.Forms.Padding(6)
        Me.btnGenerateDates.MinimumSize = New System.Drawing.Size(160, 36)
        Me.btnGenerateDates.Name = "btnGenerateDates"
        Me.btnGenerateDates.Size = New System.Drawing.Size(426, 46)
        Me.btnGenerateDates.TabIndex = 4
        Me.btnGenerateDates.Text = "Iterate Calendar"
        Me.btnGenerateDates.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(12, 305)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(206, 17)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "String and date analysis output:"
        '
        'txtStringOutput
        '
        Me.txtStringOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.txtStringOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStringOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtStringOutput.Font = New System.Drawing.Font("Consolas", 9.5!)
        Me.txtStringOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtStringOutput.Location = New System.Drawing.Point(12, 338)
        Me.txtStringOutput.Margin = New System.Windows.Forms.Padding(6)
        Me.txtStringOutput.Multiline = True
        Me.txtStringOutput.Name = "txtStringOutput"
        Me.txtStringOutput.ReadOnly = True
        Me.txtStringOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtStringOutput.Size = New System.Drawing.Size(444, 113)
        Me.txtStringOutput.TabIndex = 5
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.GroupBox6.Controls.Add(Me.txtStringTheory)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GroupBox6.Location = New System.Drawing.Point(514, 10)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBox6.Size = New System.Drawing.Size(454, 504)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Built-in String & Date Functions"
        '
        'txtStringTheory
        '
        Me.txtStringTheory.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.txtStringTheory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStringTheory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtStringTheory.Font = New System.Drawing.Font("Consolas", 9.5!)
        Me.txtStringTheory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtStringTheory.Location = New System.Drawing.Point(12, 29)
        Me.txtStringTheory.Margin = New System.Windows.Forms.Padding(6)
        Me.txtStringTheory.Multiline = True
        Me.txtStringTheory.Name = "txtStringTheory"
        Me.txtStringTheory.ReadOnly = True
        Me.txtStringTheory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtStringTheory.Size = New System.Drawing.Size(430, 463)
        Me.txtStringTheory.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'frmLesson6_SelectionRepetition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1040, 700)
        Me.Controls.Add(Me.rootLayout)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.MinimumSize = New System.Drawing.Size(820, 580)
        Me.Name = "frmLesson6_SelectionRepetition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selection & Repetition Structures"
        Me.rootLayout.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.headerLayout.ResumeLayout(False)
        Me.headerLayout.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabDecision.ResumeLayout(False)
        Me.decisionLayout.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.decisionContentLayout.ResumeLayout(False)
        Me.decisionContentLayout.PerformLayout()
        Me.inputLayout.ResumeLayout(False)
        Me.inputLayout.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tabLoops.ResumeLayout(False)
        Me.loopLayout.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.loopContentLayout.ResumeLayout(False)
        Me.loopContentLayout.PerformLayout()
        Me.loopInputLayout.ResumeLayout(False)
        Me.loopInputLayout.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.tabStringLoop.ResumeLayout(False)
        Me.stringLayout.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.stringContentLayout.ResumeLayout(False)
        Me.stringContentLayout.PerformLayout()
        Me.stringInputLayout.ResumeLayout(False)
        Me.stringInputLayout.PerformLayout()
        CType(Me.nudDays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabDecision As System.Windows.Forms.TabPage
    Friend WithEvents tabLoops As System.Windows.Forms.TabPage
    Friend WithEvents tabStringLoop As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents txtGradeInput As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboDecisionMode As System.Windows.Forms.ComboBox
    Friend WithEvents btnEvaluateGrade As System.Windows.Forms.Button
    Friend WithEvents chkGoodMoral As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDecisionOutput As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDecisionTheory As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboLoopType As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLoopStart As System.Windows.Forms.TextBox
    Friend WithEvents txtLoopStep As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtLoopEnd As System.Windows.Forms.TextBox
    Friend WithEvents btnExecuteLoop As System.Windows.Forms.Button
    Friend WithEvents chkUseBreak As System.Windows.Forms.CheckBox
    Friend WithEvents lstLoopResults As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLoopTheory As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtStringInput As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnAnalyzeString As System.Windows.Forms.Button
    Friend WithEvents nudDays As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtStringTheory As System.Windows.Forms.TextBox
    Friend WithEvents txtStringOutput As System.Windows.Forms.TextBox
    Friend WithEvents btnGenerateDates As System.Windows.Forms.Button
    Friend WithEvents decisionLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents decisionContentLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents inputLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents loopLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents loopContentLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents loopInputLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents stringLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents stringContentLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents stringInputLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rootLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents headerLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblHeaderTitle As System.Windows.Forms.Label
    Friend WithEvents lblHeaderSubtitle As System.Windows.Forms.Label
End Class
