<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrientations
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.components.Add(Me.BackgroundWorker1)
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.headerLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.lblHeaderSubtitle = New System.Windows.Forms.Label()
        Me.tabOrientation = New System.Windows.Forms.TabControl()
        Me.txtVision = New System.Windows.Forms.TabPage()
        Me.tabGrading = New System.Windows.Forms.TabPage()
        Me.tabPolicies = New System.Windows.Forms.TabPage()
        Me.gradingLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.termLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtClassStanding = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtExam = New System.Windows.Forms.TextBox()
        Me.btnCalculateTerm = New System.Windows.Forms.Button()
        Me.termOutputPanel = New System.Windows.Forms.Panel()
        Me.lblTermResult = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.finalLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMTG = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFTG = New System.Windows.Forms.TextBox()
        Me.btnCalculateFinal = New System.Windows.Forms.Button()
        Me.finalOutputPanel = New System.Windows.Forms.Panel()
        Me.lblFinalResult = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.headerLayout.SuspendLayout()
        Me.tabOrientation.SuspendLayout()
        Me.txtVision.SuspendLayout()
        Me.tabGrading.SuspendLayout()
        Me.gradingLayout.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.termLayout.SuspendLayout()
        Me.termOutputPanel.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.finalLayout.SuspendLayout()
        Me.finalOutputPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(26, 30, 38)
        Me.pnlHeader.Controls.Add(Me.headerLayout)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Padding = New System.Windows.Forms.Padding(18, 8, 18, 8)
        Me.pnlHeader.Size = New System.Drawing.Size(1040, 92)
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
        Me.lblHeaderTitle.Text = "Course Orientation"
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
        Me.lblHeaderSubtitle.Text = "Review university values and policies, then calculate term and final grades."
        '
        'tabOrientation
        '
        Me.tabOrientation.Controls.Add(Me.txtVision)
        Me.tabOrientation.Controls.Add(Me.tabGrading)
        Me.tabOrientation.Controls.Add(Me.tabPolicies)
        Me.tabOrientation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabOrientation.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.tabOrientation.Name = "tabOrientation"
        Me.tabOrientation.SelectedIndex = 0
        Me.tabOrientation.TabIndex = 1
        '
        'txtVision
        '
        Me.txtVision.BackColor = System.Drawing.Color.FromArgb(15, 17, 23)
        Me.txtVision.Name = "txtVision"
        Me.txtVision.Padding = New System.Windows.Forms.Padding(8)
        Me.txtVision.TabIndex = 0
        Me.txtVision.Text = "Vision, Mission & Values"
        '
        'tabGrading
        '
        Me.tabGrading.BackColor = System.Drawing.Color.FromArgb(15, 17, 23)
        Me.tabGrading.Controls.Add(Me.gradingLayout)
        Me.tabGrading.Name = "tabGrading"
        Me.tabGrading.Padding = New System.Windows.Forms.Padding(8)
        Me.tabGrading.TabIndex = 1
        Me.tabGrading.Text = "Grading System Calculator"
        '
        'tabPolicies
        '
        Me.tabPolicies.BackColor = System.Drawing.Color.FromArgb(15, 17, 23)
        Me.tabPolicies.Name = "tabPolicies"
        Me.tabPolicies.Padding = New System.Windows.Forms.Padding(8)
        Me.tabPolicies.TabIndex = 2
        Me.tabPolicies.Text = "Policies & Attendance"
        '
        'gradingLayout
        '
        Me.gradingLayout.ColumnCount = 2
        Me.gradingLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.gradingLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.gradingLayout.Controls.Add(Me.GroupBox1, 0, 0)
        Me.gradingLayout.Controls.Add(Me.GroupBox2, 1, 0)
        Me.gradingLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gradingLayout.Name = "gradingLayout"
        Me.gradingLayout.Padding = New System.Windows.Forms.Padding(4)
        Me.gradingLayout.RowCount = 1
        Me.gradingLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.gradingLayout.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(26, 30, 38)
        Me.GroupBox1.Controls.Add(Me.termLayout)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Term Grade - 60% Class Standing + 40% Exam"
        '
        'termLayout
        '
        Me.termLayout.ColumnCount = 2
        Me.termLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.0!))
        Me.termLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.0!))
        Me.termLayout.Controls.Add(Me.Label1, 0, 0)
        Me.termLayout.Controls.Add(Me.txtClassStanding, 1, 0)
        Me.termLayout.Controls.Add(Me.Label2, 0, 1)
        Me.termLayout.Controls.Add(Me.txtExam, 1, 1)
        Me.termLayout.Controls.Add(Me.btnCalculateTerm, 0, 2)
        Me.termLayout.Controls.Add(Me.termOutputPanel, 0, 3)
        Me.termLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.termLayout.Name = "termLayout"
        Me.termLayout.Padding = New System.Windows.Forms.Padding(8)
        Me.termLayout.RowCount = 4
        Me.termLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.termLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.termLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.termLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.termLayout.SetColumnSpan(Me.btnCalculateTerm, 2)
        Me.termLayout.SetColumnSpan(Me.termOutputPanel, 2)
        Me.termLayout.TabIndex = 0
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
        Me.Label1.Text = "Class Standing (0 - 100):"
        '
        'txtClassStanding
        '
        Me.txtClassStanding.Anchor = System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        Me.txtClassStanding.BackColor = System.Drawing.Color.FromArgb(38, 44, 58)
        Me.txtClassStanding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClassStanding.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.txtClassStanding.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.txtClassStanding.Margin = New System.Windows.Forms.Padding(6)
        Me.txtClassStanding.Name = "txtClassStanding"
        Me.txtClassStanding.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Exam Score (0 - 100):"
        '
        'txtExam
        '
        Me.txtExam.Anchor = System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        Me.txtExam.BackColor = System.Drawing.Color.FromArgb(38, 44, 58)
        Me.txtExam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExam.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.txtExam.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.txtExam.Margin = New System.Windows.Forms.Padding(6)
        Me.txtExam.Name = "txtExam"
        Me.txtExam.TabIndex = 2
        '
        'btnCalculateTerm
        '
        Me.btnCalculateTerm.BackColor = System.Drawing.Color.FromArgb(37, 99, 235)
        Me.btnCalculateTerm.FlatAppearance.BorderSize = 0
        Me.btnCalculateTerm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculateTerm.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnCalculateTerm.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.btnCalculateTerm.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCalculateTerm.Name = "btnCalculateTerm"
        Me.btnCalculateTerm.Size = New System.Drawing.Size(300, 36)
        Me.btnCalculateTerm.TabIndex = 3
        Me.btnCalculateTerm.Text = "Calculate Term Grade"
        Me.btnCalculateTerm.UseVisualStyleBackColor = False
        '
        'termOutputPanel
        '
        Me.termOutputPanel.BackColor = System.Drawing.Color.FromArgb(38, 44, 58)
        Me.termOutputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.termOutputPanel.Controls.Add(Me.lblTermResult)
        Me.termOutputPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.termOutputPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.termOutputPanel.Name = "termOutputPanel"
        Me.termOutputPanel.Padding = New System.Windows.Forms.Padding(12)
        Me.termOutputPanel.TabIndex = 4
        '
        'lblTermResult
        '
        Me.lblTermResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTermResult.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTermResult.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.lblTermResult.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTermResult.Name = "lblTermResult"
        Me.lblTermResult.TabIndex = 0
        Me.lblTermResult.Text = "Term Grade: --"
        Me.lblTermResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(26, 30, 38)
        Me.GroupBox2.Controls.Add(Me.finalLayout)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Final Grade - Average of MTG and FTG"
        '
        'finalLayout
        '
        Me.finalLayout.ColumnCount = 2
        Me.finalLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.0!))
        Me.finalLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.0!))
        Me.finalLayout.Controls.Add(Me.Label4, 0, 0)
        Me.finalLayout.Controls.Add(Me.txtMTG, 1, 0)
        Me.finalLayout.Controls.Add(Me.Label5, 0, 1)
        Me.finalLayout.Controls.Add(Me.txtFTG, 1, 1)
        Me.finalLayout.Controls.Add(Me.btnCalculateFinal, 0, 2)
        Me.finalLayout.Controls.Add(Me.finalOutputPanel, 0, 3)
        Me.finalLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.finalLayout.Name = "finalLayout"
        Me.finalLayout.Padding = New System.Windows.Forms.Padding(8)
        Me.finalLayout.RowCount = 4
        Me.finalLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.finalLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.finalLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.finalLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.finalLayout.SetColumnSpan(Me.btnCalculateFinal, 2)
        Me.finalLayout.SetColumnSpan(Me.finalOutputPanel, 2)
        Me.finalLayout.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Midterm Grade (MTG):"
        '
        'txtMTG
        '
        Me.txtMTG.Anchor = System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        Me.txtMTG.BackColor = System.Drawing.Color.FromArgb(38, 44, 58)
        Me.txtMTG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMTG.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.txtMTG.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.txtMTG.Margin = New System.Windows.Forms.Padding(6)
        Me.txtMTG.Name = "txtMTG"
        Me.txtMTG.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6)
        Me.Label5.Name = "Label5"
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Final Term Grade (FTG):"
        '
        'txtFTG
        '
        Me.txtFTG.Anchor = System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        Me.txtFTG.BackColor = System.Drawing.Color.FromArgb(38, 44, 58)
        Me.txtFTG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFTG.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.txtFTG.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.txtFTG.Margin = New System.Windows.Forms.Padding(6)
        Me.txtFTG.Name = "txtFTG"
        Me.txtFTG.TabIndex = 2
        '
        'btnCalculateFinal
        '
        Me.btnCalculateFinal.BackColor = System.Drawing.Color.FromArgb(37, 99, 235)
        Me.btnCalculateFinal.FlatAppearance.BorderSize = 0
        Me.btnCalculateFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculateFinal.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnCalculateFinal.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.btnCalculateFinal.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCalculateFinal.Name = "btnCalculateFinal"
        Me.btnCalculateFinal.Size = New System.Drawing.Size(300, 36)
        Me.btnCalculateFinal.TabIndex = 3
        Me.btnCalculateFinal.Text = "Calculate Final Grade"
        Me.btnCalculateFinal.UseVisualStyleBackColor = False
        '
        'finalOutputPanel
        '
        Me.finalOutputPanel.BackColor = System.Drawing.Color.FromArgb(38, 44, 58)
        Me.finalOutputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.finalOutputPanel.Controls.Add(Me.lblFinalResult)
        Me.finalOutputPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.finalOutputPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.finalOutputPanel.Name = "finalOutputPanel"
        Me.finalOutputPanel.Padding = New System.Windows.Forms.Padding(12)
        Me.finalOutputPanel.TabIndex = 4
        '
        'lblFinalResult
        '
        Me.lblFinalResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFinalResult.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblFinalResult.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.lblFinalResult.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFinalResult.Name = "lblFinalResult"
        Me.lblFinalResult.TabIndex = 0
        Me.lblFinalResult.Text = "Final Grade: --"
        Me.lblFinalResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmOrientations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(15, 17, 23)
        Me.ClientSize = New System.Drawing.Size(1040, 700)
        Me.Controls.Add(Me.tabOrientation)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.MinimumSize = New System.Drawing.Size(820, 580)
        Me.Name = "frmOrientations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Course Orientation & University Guidelines"
        Me.pnlHeader.ResumeLayout(False)
        Me.headerLayout.ResumeLayout(False)
        Me.headerLayout.PerformLayout()
        Me.tabOrientation.ResumeLayout(False)
        Me.txtVision.ResumeLayout(False)
        Me.tabGrading.ResumeLayout(False)
        Me.gradingLayout.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.termLayout.ResumeLayout(False)
        Me.termLayout.PerformLayout()
        Me.termOutputPanel.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.finalLayout.ResumeLayout(False)
        Me.finalLayout.PerformLayout()
        Me.finalOutputPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents tabPolicies As System.Windows.Forms.TabPage
    Friend WithEvents txtVision As System.Windows.Forms.TabPage
    Friend WithEvents tabOrientation As System.Windows.Forms.TabControl
    Friend WithEvents tabGrading As System.Windows.Forms.TabPage
    Friend WithEvents btnCalculateTerm As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblFinalResult As System.Windows.Forms.Label
    Friend WithEvents txtMTG As System.Windows.Forms.TextBox
    Friend WithEvents txtFTG As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCalculateFinal As System.Windows.Forms.Button
    Friend WithEvents lblTermResult As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtExam As System.Windows.Forms.TextBox
    Friend WithEvents txtClassStanding As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents headerLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblHeaderTitle As System.Windows.Forms.Label
    Friend WithEvents lblHeaderSubtitle As System.Windows.Forms.Label
    Friend WithEvents gradingLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents termLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents finalLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents termOutputPanel As System.Windows.Forms.Panel
    Friend WithEvents finalOutputPanel As System.Windows.Forms.Panel
End Class
