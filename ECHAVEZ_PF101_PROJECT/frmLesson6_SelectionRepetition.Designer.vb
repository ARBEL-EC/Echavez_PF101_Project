<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLesson6_SelectionRepetition
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabDecision = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDecisionTheory = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDecisionOutput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEvaluateGrade = New System.Windows.Forms.Button()
        Me.chkGoodMoral = New System.Windows.Forms.CheckBox()
        Me.cboDecisionMode = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGradeInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabLoops = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtLoopTheory = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lstLoopResults = New System.Windows.Forms.ListBox()
        Me.btnExecuteLoop = New System.Windows.Forms.Button()
        Me.chkUseBreak = New System.Windows.Forms.CheckBox()
        Me.txtLoopStep = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLoopEnd = New System.Windows.Forms.TextBox()
        Me.txtLoopStart = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboLoopType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tabStringLoop = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtStringTheory = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtStringOutput = New System.Windows.Forms.TextBox()
        Me.btnGenerateDates = New System.Windows.Forms.Button()
        Me.nudDays = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnAnalyzeString = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtStringInput = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.tabDecision.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabLoops.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tabStringLoop.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.nudDays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabDecision)
        Me.TabControl1.Controls.Add(Me.tabLoops)
        Me.TabControl1.Controls.Add(Me.tabStringLoop)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(844, 491)
        Me.TabControl1.TabIndex = 0
        '
        'tabDecision
        '
        Me.tabDecision.Controls.Add(Me.GroupBox2)
        Me.tabDecision.Controls.Add(Me.GroupBox1)
        Me.tabDecision.Location = New System.Drawing.Point(4, 22)
        Me.tabDecision.Name = "tabDecision"
        Me.tabDecision.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDecision.Size = New System.Drawing.Size(836, 465)
        Me.tabDecision.TabIndex = 0
        Me.tabDecision.Text = "Decision Structures (If & Select Case)"
        Me.tabDecision.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDecisionTheory)
        Me.GroupBox2.Location = New System.Drawing.Point(420, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(395, 435)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Decision Structure Architecture"
        '
        'txtDecisionTheory
        '
        Me.txtDecisionTheory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDecisionTheory.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtDecisionTheory.Location = New System.Drawing.Point(3, 16)
        Me.txtDecisionTheory.Multiline = True
        Me.txtDecisionTheory.Name = "txtDecisionTheory"
        Me.txtDecisionTheory.ReadOnly = True
        Me.txtDecisionTheory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDecisionTheory.Size = New System.Drawing.Size(389, 416)
        Me.txtDecisionTheory.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDecisionOutput)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnEvaluateGrade)
        Me.GroupBox1.Controls.Add(Me.chkGoodMoral)
        Me.GroupBox1.Controls.Add(Me.cboDecisionMode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtGradeInput)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 435)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Interactive Academic Evaluation Engine"
        '
        'txtDecisionOutput
        '
        Me.txtDecisionOutput.Font = New System.Drawing.Font("Consolas", 9.5!)
        Me.txtDecisionOutput.Location = New System.Drawing.Point(20, 200)
        Me.txtDecisionOutput.Multiline = True
        Me.txtDecisionOutput.Name = "txtDecisionOutput"
        Me.txtDecisionOutput.ReadOnly = True
        Me.txtDecisionOutput.Size = New System.Drawing.Size(340, 210)
        Me.txtDecisionOutput.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Evaluation Result & Diagnostic Trace:"
        '
        'btnEvaluateGrade
        '
        Me.btnEvaluateGrade.Location = New System.Drawing.Point(20, 125)
        Me.btnEvaluateGrade.Name = "btnEvaluateGrade"
        Me.btnEvaluateGrade.Size = New System.Drawing.Size(340, 32)
        Me.btnEvaluateGrade.TabIndex = 5
        Me.btnEvaluateGrade.Text = "Evaluate Decision Branching"
        Me.btnEvaluateGrade.UseVisualStyleBackColor = True
        '
        'chkGoodMoral
        '
        Me.chkGoodMoral.AutoSize = True
        Me.chkGoodMoral.Checked = True
        Me.chkGoodMoral.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGoodMoral.Location = New System.Drawing.Point(20, 90)
        Me.chkGoodMoral.Name = "chkGoodMoral"
        Me.chkGoodMoral.Size = New System.Drawing.Size(248, 17)
        Me.chkGoodMoral.TabIndex = 4
        Me.chkGoodMoral.Text = "Has Good Moral Record (Required for Honors),"
        Me.chkGoodMoral.UseVisualStyleBackColor = True
        '
        'cboDecisionMode
        '
        Me.cboDecisionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDecisionMode.FormattingEnabled = True
        Me.cboDecisionMode.Location = New System.Drawing.Point(190, 52)
        Me.cboDecisionMode.Name = "cboDecisionMode"
        Me.cboDecisionMode.Size = New System.Drawing.Size(170, 21)
        Me.cboDecisionMode.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(190, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Evaluation Strategy:"
        '
        'txtGradeInput
        '
        Me.txtGradeInput.Location = New System.Drawing.Point(20, 52)
        Me.txtGradeInput.Name = "txtGradeInput"
        Me.txtGradeInput.Size = New System.Drawing.Size(150, 20)
        Me.txtGradeInput.TabIndex = 1
        Me.txtGradeInput.Text = "94.5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numerical Grade (0 - 100):"
        '
        'tabLoops
        '
        Me.tabLoops.Controls.Add(Me.GroupBox4)
        Me.tabLoops.Controls.Add(Me.Label5)
        Me.tabLoops.Controls.Add(Me.GroupBox3)
        Me.tabLoops.Location = New System.Drawing.Point(4, 22)
        Me.tabLoops.Name = "tabLoops"
        Me.tabLoops.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLoops.Size = New System.Drawing.Size(836, 465)
        Me.tabLoops.TabIndex = 1
        Me.tabLoops.Text = "Repetition Structures (Loops)"
        Me.tabLoops.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtLoopTheory)
        Me.GroupBox4.Location = New System.Drawing.Point(420, 15)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(395, 435)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Loop Mechanics & Pre/Post Test Rules"
        '
        'txtLoopTheory
        '
        Me.txtLoopTheory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLoopTheory.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtLoopTheory.Location = New System.Drawing.Point(3, 16)
        Me.txtLoopTheory.Multiline = True
        Me.txtLoopTheory.Name = "txtLoopTheory"
        Me.txtLoopTheory.ReadOnly = True
        Me.txtLoopTheory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLoopTheory.Size = New System.Drawing.Size(389, 416)
        Me.txtLoopTheory.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Label5"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lstLoopResults)
        Me.GroupBox3.Controls.Add(Me.btnExecuteLoop)
        Me.GroupBox3.Controls.Add(Me.chkUseBreak)
        Me.GroupBox3.Controls.Add(Me.txtLoopStep)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtLoopEnd)
        Me.GroupBox3.Controls.Add(Me.txtLoopStart)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.cboLoopType)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 15)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(380, 435)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Loop Execution Simulator"
        '
        'lstLoopResults
        '
        Me.lstLoopResults.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.lstLoopResults.FormattingEnabled = True
        Me.lstLoopResults.ItemHeight = 14
        Me.lstLoopResults.Location = New System.Drawing.Point(20, 218)
        Me.lstLoopResults.Name = "lstLoopResults"
        Me.lstLoopResults.Size = New System.Drawing.Size(340, 186)
        Me.lstLoopResults.TabIndex = 10
        '
        'btnExecuteLoop
        '
        Me.btnExecuteLoop.Location = New System.Drawing.Point(20, 175)
        Me.btnExecuteLoop.Name = "btnExecuteLoop"
        Me.btnExecuteLoop.Size = New System.Drawing.Size(340, 32)
        Me.btnExecuteLoop.TabIndex = 9
        Me.btnExecuteLoop.Text = "Execute Loop Cycle"
        Me.btnExecuteLoop.UseVisualStyleBackColor = True
        '
        'chkUseBreak
        '
        Me.chkUseBreak.AutoSize = True
        Me.chkUseBreak.Location = New System.Drawing.Point(20, 145)
        Me.chkUseBreak.Name = "chkUseBreak"
        Me.chkUseBreak.Size = New System.Drawing.Size(224, 17)
        Me.chkUseBreak.TabIndex = 8
        Me.chkUseBreak.Text = "Exit Loop Early When Iteration Reaches 7"
        Me.chkUseBreak.UseVisualStyleBackColor = True
        '
        'txtLoopStep
        '
        Me.txtLoopStep.Location = New System.Drawing.Point(260, 105)
        Me.txtLoopStep.Name = "txtLoopStep"
        Me.txtLoopStep.Size = New System.Drawing.Size(100, 20)
        Me.txtLoopStep.TabIndex = 7
        Me.txtLoopStep.Text = "1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(260, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Step:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(140, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "End:"
        '
        'txtLoopEnd
        '
        Me.txtLoopEnd.Location = New System.Drawing.Point(140, 105)
        Me.txtLoopEnd.Name = "txtLoopEnd"
        Me.txtLoopEnd.Size = New System.Drawing.Size(90, 20)
        Me.txtLoopEnd.TabIndex = 4
        Me.txtLoopEnd.Text = "10"
        '
        'txtLoopStart
        '
        Me.txtLoopStart.Location = New System.Drawing.Point(20, 105)
        Me.txtLoopStart.Name = "txtLoopStart"
        Me.txtLoopStart.Size = New System.Drawing.Size(90, 20)
        Me.txtLoopStart.TabIndex = 3
        Me.txtLoopStart.Text = "1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Start:"
        '
        'cboLoopType
        '
        Me.cboLoopType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLoopType.FormattingEnabled = True
        Me.cboLoopType.Location = New System.Drawing.Point(20, 48)
        Me.cboLoopType.Name = "cboLoopType"
        Me.cboLoopType.Size = New System.Drawing.Size(340, 21)
        Me.cboLoopType.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Loop Construct:"
        '
        'tabStringLoop
        '
        Me.tabStringLoop.Controls.Add(Me.GroupBox6)
        Me.tabStringLoop.Controls.Add(Me.GroupBox5)
        Me.tabStringLoop.Location = New System.Drawing.Point(4, 22)
        Me.tabStringLoop.Name = "tabStringLoop"
        Me.tabStringLoop.Size = New System.Drawing.Size(836, 465)
        Me.tabStringLoop.TabIndex = 2
        Me.tabStringLoop.Text = "String & Date Processing"
        Me.tabStringLoop.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtStringTheory)
        Me.GroupBox6.Location = New System.Drawing.Point(420, 15)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(395, 435)
        Me.GroupBox6.TabIndex = 10
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Built-in String & Date Functions"
        '
        'txtStringTheory
        '
        Me.txtStringTheory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtStringTheory.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtStringTheory.Location = New System.Drawing.Point(3, 16)
        Me.txtStringTheory.Multiline = True
        Me.txtStringTheory.Name = "txtStringTheory"
        Me.txtStringTheory.ReadOnly = True
        Me.txtStringTheory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtStringTheory.Size = New System.Drawing.Size(389, 416)
        Me.txtStringTheory.TabIndex = 9
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtStringOutput)
        Me.GroupBox5.Controls.Add(Me.btnGenerateDates)
        Me.GroupBox5.Controls.Add(Me.nudDays)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.btnAnalyzeString)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.txtStringInput)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Location = New System.Drawing.Point(20, 15)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(380, 435)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Tag = ""
        Me.GroupBox5.Text = "String & Date Iterator"
        '
        'txtStringOutput
        '
        Me.txtStringOutput.Font = New System.Drawing.Font("Consolas", 9.5!)
        Me.txtStringOutput.Location = New System.Drawing.Point(20, 190)
        Me.txtStringOutput.Multiline = True
        Me.txtStringOutput.Name = "txtStringOutput"
        Me.txtStringOutput.ReadOnly = True
        Me.txtStringOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtStringOutput.Size = New System.Drawing.Size(340, 225)
        Me.txtStringOutput.TabIndex = 8
        '
        'btnGenerateDates
        '
        Me.btnGenerateDates.Location = New System.Drawing.Point(210, 146)
        Me.btnGenerateDates.Name = "btnGenerateDates"
        Me.btnGenerateDates.Size = New System.Drawing.Size(150, 28)
        Me.btnGenerateDates.TabIndex = 7
        Me.btnGenerateDates.Text = "Iterate Calendar"
        Me.btnGenerateDates.UseVisualStyleBackColor = True
        '
        'nudDays
        '
        Me.nudDays.Location = New System.Drawing.Point(120, 148)
        Me.nudDays.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.nudDays.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDays.Name = "nudDays"
        Me.nudDays.Size = New System.Drawing.Size(80, 20)
        Me.nudDays.TabIndex = 6
        Me.nudDays.Value = New Decimal(New Integer() {9, 0, 0, 0})
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(20, 150)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Days to Add:"
        '
        'btnAnalyzeString
        '
        Me.btnAnalyzeString.Location = New System.Drawing.Point(20, 80)
        Me.btnAnalyzeString.Name = "btnAnalyzeString"
        Me.btnAnalyzeString.Size = New System.Drawing.Size(340, 30)
        Me.btnAnalyzeString.TabIndex = 5
        Me.btnAnalyzeString.Text = "Parse Characters & Vowels (For Each)"
        Me.btnAnalyzeString.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(196, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Generate Schedule (Date Range Loop):"
        '
        'txtStringInput
        '
        Me.txtStringInput.Location = New System.Drawing.Point(20, 48)
        Me.txtStringInput.Name = "txtStringInput"
        Me.txtStringInput.Size = New System.Drawing.Size(340, 20)
        Me.txtStringInput.TabIndex = 4
        Me.txtStringInput.Text = "Quezon City University"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(196, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Generate Schedule (Date Range Loop):"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Enter String to Analyze:"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'frmLesson6_SelectionRepetition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 491)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmLesson6_SelectionRepetition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lesson 6 - Selection & Repetition Structures"
        Me.TabControl1.ResumeLayout(False)
        Me.tabDecision.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabLoops.ResumeLayout(False)
        Me.tabLoops.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tabStringLoop.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.nudDays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabDecision As TabPage
    Friend WithEvents tabLoops As TabPage
    Friend WithEvents tabStringLoop As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtGradeInput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboDecisionMode As ComboBox
    Friend WithEvents btnEvaluateGrade As Button
    Friend WithEvents chkGoodMoral As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDecisionOutput As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtDecisionTheory As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboLoopType As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLoopStart As TextBox
    Friend WithEvents txtLoopStep As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtLoopEnd As TextBox
    Friend WithEvents btnExecuteLoop As Button
    Friend WithEvents chkUseBreak As CheckBox
    Friend WithEvents lstLoopResults As ListBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtLoopTheory As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtStringInput As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnAnalyzeString As Button
    Friend WithEvents nudDays As NumericUpDown
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtStringTheory As TextBox
    Friend WithEvents txtStringOutput As TextBox
    Friend WithEvents btnGenerateDates As Button
End Class
