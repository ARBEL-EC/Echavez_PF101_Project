<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrientations
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.tabPolicies = New System.Windows.Forms.TabPage()
        Me.txtVision = New System.Windows.Forms.TabPage()
        Me.tabOrientation = New System.Windows.Forms.TabControl()
        Me.tabGrading = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblFinalResult = New System.Windows.Forms.Label()
        Me.txtMTG = New System.Windows.Forms.TextBox()
        Me.txtFTG = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCalculateFinal = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCalculateTerm = New System.Windows.Forms.Button()
        Me.lblTermResult = New System.Windows.Forms.Label()
        Me.txtExam = New System.Windows.Forms.TextBox()
        Me.txtClassStanding = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabOrientation.SuspendLayout()
        Me.tabGrading.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabPolicies
        '
        Me.tabPolicies.Location = New System.Drawing.Point(4, 22)
        Me.tabPolicies.Name = "tabPolicies"
        Me.tabPolicies.Size = New System.Drawing.Size(776, 415)
        Me.tabPolicies.TabIndex = 2
        Me.tabPolicies.Text = "Policies & Attendance"
        Me.tabPolicies.UseVisualStyleBackColor = True
        '
        'txtVision
        '
        Me.txtVision.Location = New System.Drawing.Point(4, 22)
        Me.txtVision.Name = "txtVision"
        Me.txtVision.Padding = New System.Windows.Forms.Padding(3)
        Me.txtVision.Size = New System.Drawing.Size(776, 415)
        Me.txtVision.TabIndex = 1
        Me.txtVision.Text = "Vision, Mission & Values"
        Me.txtVision.UseVisualStyleBackColor = True
        '
        'tabOrientation
        '
        Me.tabOrientation.Controls.Add(Me.txtVision)
        Me.tabOrientation.Controls.Add(Me.tabGrading)
        Me.tabOrientation.Controls.Add(Me.tabPolicies)
        Me.tabOrientation.Location = New System.Drawing.Point(0, 0)
        Me.tabOrientation.Name = "tabOrientation"
        Me.tabOrientation.SelectedIndex = 0
        Me.tabOrientation.Size = New System.Drawing.Size(784, 441)
        Me.tabOrientation.TabIndex = 0
        '
        'tabGrading
        '
        Me.tabGrading.Controls.Add(Me.GroupBox2)
        Me.tabGrading.Controls.Add(Me.GroupBox1)
        Me.tabGrading.Location = New System.Drawing.Point(4, 22)
        Me.tabGrading.Name = "tabGrading"
        Me.tabGrading.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGrading.Size = New System.Drawing.Size(776, 415)
        Me.tabGrading.TabIndex = 0
        Me.tabGrading.Text = "Grading System Calculator"
        Me.tabGrading.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lblFinalResult)
        Me.GroupBox2.Controls.Add(Me.txtMTG)
        Me.GroupBox2.Controls.Add(Me.txtFTG)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnCalculateFinal)
        Me.GroupBox2.Location = New System.Drawing.Point(400, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 360)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Final Grade Computation ((MTG + FTG) / 2)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Midterm Grade (MTG):"
        '
        'lblFinalResult
        '
        Me.lblFinalResult.AutoSize = True
        Me.lblFinalResult.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFinalResult.Location = New System.Drawing.Point(20, 180)
        Me.lblFinalResult.Name = "lblFinalResult"
        Me.lblFinalResult.Size = New System.Drawing.Size(105, 19)
        Me.lblFinalResult.TabIndex = 5
        Me.lblFinalResult.Text = "Final Grade: --"
        '
        'txtMTG
        '
        Me.txtMTG.Location = New System.Drawing.Point(190, 32)
        Me.txtMTG.Name = "txtMTG"
        Me.txtMTG.Size = New System.Drawing.Size(120, 20)
        Me.txtMTG.TabIndex = 6
        '
        'txtFTG
        '
        Me.txtFTG.Location = New System.Drawing.Point(190, 72)
        Me.txtFTG.Name = "txtFTG"
        Me.txtFTG.Size = New System.Drawing.Size(120, 20)
        Me.txtFTG.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Final Term Grade (FTG):"
        '
        'btnCalculateFinal
        '
        Me.btnCalculateFinal.Location = New System.Drawing.Point(20, 120)
        Me.btnCalculateFinal.Name = "btnCalculateFinal"
        Me.btnCalculateFinal.Size = New System.Drawing.Size(290, 32)
        Me.btnCalculateFinal.TabIndex = 11
        Me.btnCalculateFinal.Text = "Calculate Final Grade"
        Me.btnCalculateFinal.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCalculateTerm)
        Me.GroupBox1.Controls.Add(Me.lblTermResult)
        Me.GroupBox1.Controls.Add(Me.txtExam)
        Me.GroupBox1.Controls.Add(Me.txtClassStanding)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 360)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Term Grade Computation (60% Class Standing + 40% Exam)"
        '
        'btnCalculateTerm
        '
        Me.btnCalculateTerm.Location = New System.Drawing.Point(18, 120)
        Me.btnCalculateTerm.Name = "btnCalculateTerm"
        Me.btnCalculateTerm.Size = New System.Drawing.Size(300, 32)
        Me.btnCalculateTerm.TabIndex = 10
        Me.btnCalculateTerm.Text = "Calculate Term Grade"
        Me.btnCalculateTerm.UseVisualStyleBackColor = True
        '
        'lblTermResult
        '
        Me.lblTermResult.AutoSize = True
        Me.lblTermResult.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTermResult.Location = New System.Drawing.Point(16, 180)
        Me.lblTermResult.Name = "lblTermResult"
        Me.lblTermResult.Size = New System.Drawing.Size(108, 19)
        Me.lblTermResult.TabIndex = 2
        Me.lblTermResult.Text = "Term Grade: --"
        '
        'txtExam
        '
        Me.txtExam.Location = New System.Drawing.Point(180, 68)
        Me.txtExam.Name = "txtExam"
        Me.txtExam.Size = New System.Drawing.Size(120, 20)
        Me.txtExam.TabIndex = 8
        '
        'txtClassStanding
        '
        Me.txtClassStanding.Location = New System.Drawing.Point(180, 32)
        Me.txtClassStanding.Name = "txtClassStanding"
        Me.txtClassStanding.Size = New System.Drawing.Size(120, 20)
        Me.txtClassStanding.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Class Standing (0 - 100):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Exam Score (0 - 100):"
        '
        'frmOrientations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.Controls.Add(Me.tabOrientation)
        Me.Name = "frmOrientations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lesson 1 - Course Orientation & University Guidelines"
        Me.tabOrientation.ResumeLayout(False)
        Me.tabGrading.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents tabPolicies As TabPage
    Friend WithEvents txtVision As TabPage
    Friend WithEvents tabOrientation As TabControl
    Friend WithEvents tabGrading As TabPage
    Friend WithEvents btnCalculateTerm As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblFinalResult As Label
    Friend WithEvents txtMTG As TextBox
    Friend WithEvents txtFTG As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCalculateFinal As Button
    Friend WithEvents lblTermResult As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtExam As TextBox
    Friend WithEvents txtClassStanding As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
