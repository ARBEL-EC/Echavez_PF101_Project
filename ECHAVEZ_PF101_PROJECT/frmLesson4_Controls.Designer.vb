<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLesson4_Controls
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabFormProperties = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtLayoutTheory = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkTopMost = New System.Windows.Forms.CheckBox()
        Me.cboBorderStyle = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblOpacityVal = New System.Windows.Forms.Label()
        Me.tbOpacity = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabBasicControls = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblDialogPreview = New System.Windows.Forms.Label()
        Me.btnConfirmDialog = New System.Windows.Forms.Button()
        Me.btnFontDialog = New System.Windows.Forms.Button()
        Me.btnColorDialog = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.prgBar = New System.Windows.Forms.ProgressBar()
        Me.btnProgressStep = New System.Windows.Forms.Button()
        Me.dtpTarget = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbSpeedFast = New System.Windows.Forms.RadioButton()
        Me.rbSpeedNormal = New System.Windows.Forms.RadioButton()
        Me.chkEnable = New System.Windows.Forms.CheckBox()
        Me.tabRuntimeEvents = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlDynamic = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnClearDynamic = New System.Windows.Forms.Button()
        Me.btnCreateDynamic = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tabFormProperties.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tbOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBasicControls.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tabRuntimeEvents.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabFormProperties)
        Me.TabControl1.Controls.Add(Me.tabBasicControls)
        Me.TabControl1.Controls.Add(Me.tabRuntimeEvents)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(824, 481)
        Me.TabControl1.TabIndex = 0
        '
        'tabFormProperties
        '
        Me.tabFormProperties.Controls.Add(Me.GroupBox2)
        Me.tabFormProperties.Controls.Add(Me.GroupBox1)
        Me.tabFormProperties.Location = New System.Drawing.Point(4, 22)
        Me.tabFormProperties.Name = "tabFormProperties"
        Me.tabFormProperties.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFormProperties.Size = New System.Drawing.Size(816, 455)
        Me.tabFormProperties.TabIndex = 0
        Me.tabFormProperties.Text = "Form Features & Layout"
        Me.tabFormProperties.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtLayoutTheory)
        Me.GroupBox2.Location = New System.Drawing.Point(410, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(390, 420)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Anchor vs. Dock Mechanics"
        '
        'txtLayoutTheory
        '
        Me.txtLayoutTheory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLayoutTheory.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtLayoutTheory.Location = New System.Drawing.Point(3, 16)
        Me.txtLayoutTheory.Multiline = True
        Me.txtLayoutTheory.Name = "txtLayoutTheory"
        Me.txtLayoutTheory.ReadOnly = True
        Me.txtLayoutTheory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLayoutTheory.Size = New System.Drawing.Size(384, 401)
        Me.txtLayoutTheory.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkTopMost)
        Me.GroupBox1.Controls.Add(Me.cboBorderStyle)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblOpacityVal)
        Me.GroupBox1.Controls.Add(Me.tbOpacity)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 420)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Live Form Property Controller"
        '
        'chkTopMost
        '
        Me.chkTopMost.AutoSize = True
        Me.chkTopMost.Location = New System.Drawing.Point(20, 205)
        Me.chkTopMost.Name = "chkTopMost"
        Me.chkTopMost.Size = New System.Drawing.Size(215, 17)
        Me.chkTopMost.TabIndex = 5
        Me.chkTopMost.Text = "TopMost (Keep form above all windows)"
        Me.chkTopMost.UseVisualStyleBackColor = True
        '
        'cboBorderStyle
        '
        Me.cboBorderStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBorderStyle.FormattingEnabled = True
        Me.cboBorderStyle.Location = New System.Drawing.Point(20, 160)
        Me.cboBorderStyle.Name = "cboBorderStyle"
        Me.cboBorderStyle.Size = New System.Drawing.Size(220, 21)
        Me.cboBorderStyle.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Form Border Style:"
        '
        'lblOpacityVal
        '
        Me.lblOpacityVal.AutoSize = True
        Me.lblOpacityVal.Location = New System.Drawing.Point(20, 100)
        Me.lblOpacityVal.Name = "lblOpacityVal"
        Me.lblOpacityVal.Size = New System.Drawing.Size(112, 13)
        Me.lblOpacityVal.TabIndex = 2
        Me.lblOpacityVal.Text = "Current Opacity: 100%"
        '
        'tbOpacity
        '
        Me.tbOpacity.Location = New System.Drawing.Point(20, 55)
        Me.tbOpacity.Maximum = 100
        Me.tbOpacity.Minimum = 20
        Me.tbOpacity.Name = "tbOpacity"
        Me.tbOpacity.Size = New System.Drawing.Size(320, 45)
        Me.tbOpacity.TabIndex = 1
        Me.tbOpacity.TickFrequency = 10
        Me.tbOpacity.Value = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Window Opacity (Alpha):"
        '
        'tabBasicControls
        '
        Me.tabBasicControls.Controls.Add(Me.GroupBox4)
        Me.tabBasicControls.Controls.Add(Me.GroupBox3)
        Me.tabBasicControls.Location = New System.Drawing.Point(4, 22)
        Me.tabBasicControls.Name = "tabBasicControls"
        Me.tabBasicControls.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBasicControls.Size = New System.Drawing.Size(816, 455)
        Me.tabBasicControls.TabIndex = 1
        Me.tabBasicControls.Text = "Basic Controls & Dialogs"
        Me.tabBasicControls.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblDialogPreview)
        Me.GroupBox4.Controls.Add(Me.btnConfirmDialog)
        Me.GroupBox4.Controls.Add(Me.btnFontDialog)
        Me.GroupBox4.Controls.Add(Me.btnColorDialog)
        Me.GroupBox4.Location = New System.Drawing.Point(410, 20)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(390, 420)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dialog Boxes Testbench"
        '
        'lblDialogPreview
        '
        Me.lblDialogPreview.AutoSize = True
        Me.lblDialogPreview.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblDialogPreview.Location = New System.Drawing.Point(25, 180)
        Me.lblDialogPreview.Name = "lblDialogPreview"
        Me.lblDialogPreview.Size = New System.Drawing.Size(168, 21)
        Me.lblDialogPreview.TabIndex = 3
        Me.lblDialogPreview.Text = "Sample Preview Text"
        Me.lblDialogPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnConfirmDialog
        '
        Me.btnConfirmDialog.Location = New System.Drawing.Point(25, 125)
        Me.btnConfirmDialog.Name = "btnConfirmDialog"
        Me.btnConfirmDialog.Size = New System.Drawing.Size(280, 32)
        Me.btnConfirmDialog.TabIndex = 2
        Me.btnConfirmDialog.Text = "Show DialogResult MessageBox"
        Me.btnConfirmDialog.UseVisualStyleBackColor = True
        '
        'btnFontDialog
        '
        Me.btnFontDialog.Location = New System.Drawing.Point(25, 80)
        Me.btnFontDialog.Name = "btnFontDialog"
        Me.btnFontDialog.Size = New System.Drawing.Size(280, 32)
        Me.btnFontDialog.TabIndex = 1
        Me.btnFontDialog.Text = "Select Banner Font (FontDialog)"
        Me.btnFontDialog.UseVisualStyleBackColor = True
        '
        'btnColorDialog
        '
        Me.btnColorDialog.Location = New System.Drawing.Point(25, 35)
        Me.btnColorDialog.Name = "btnColorDialog"
        Me.btnColorDialog.Size = New System.Drawing.Size(280, 32)
        Me.btnColorDialog.TabIndex = 0
        Me.btnColorDialog.Text = "Choose Accent Color (ColorDialog)"
        Me.btnColorDialog.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblProgress)
        Me.GroupBox3.Controls.Add(Me.prgBar)
        Me.GroupBox3.Controls.Add(Me.btnProgressStep)
        Me.GroupBox3.Controls.Add(Me.dtpTarget)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.rbSpeedFast)
        Me.GroupBox3.Controls.Add(Me.rbSpeedNormal)
        Me.GroupBox3.Controls.Add(Me.chkEnable)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(370, 420)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Control Suite Simulator"
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Location = New System.Drawing.Point(20, 268)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(68, 13)
        Me.lblProgress.TabIndex = 1
        Me.lblProgress.Text = "Progress: 0%"
        '
        'prgBar
        '
        Me.prgBar.Location = New System.Drawing.Point(20, 235)
        Me.prgBar.Name = "prgBar"
        Me.prgBar.Size = New System.Drawing.Size(320, 25)
        Me.prgBar.TabIndex = 6
        '
        'btnProgressStep
        '
        Me.btnProgressStep.Location = New System.Drawing.Point(20, 190)
        Me.btnProgressStep.Name = "btnProgressStep"
        Me.btnProgressStep.Size = New System.Drawing.Size(200, 32)
        Me.btnProgressStep.TabIndex = 5
        Me.btnProgressStep.Text = "Increment Progress Bar"
        Me.btnProgressStep.UseVisualStyleBackColor = True
        '
        'dtpTarget
        '
        Me.dtpTarget.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTarget.Location = New System.Drawing.Point(20, 145)
        Me.dtpTarget.Name = "dtpTarget"
        Me.dtpTarget.Size = New System.Drawing.Size(200, 20)
        Me.dtpTarget.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Event Target Date:"
        '
        'rbSpeedFast
        '
        Me.rbSpeedFast.AutoSize = True
        Me.rbSpeedFast.Location = New System.Drawing.Point(20, 85)
        Me.rbSpeedFast.Name = "rbSpeedFast"
        Me.rbSpeedFast.Size = New System.Drawing.Size(139, 17)
        Me.rbSpeedFast.TabIndex = 2
        Me.rbSpeedFast.Text = "Turbo Speed (Step +25)"
        Me.rbSpeedFast.UseVisualStyleBackColor = True
        '
        'rbSpeedNormal
        '
        Me.rbSpeedNormal.AutoSize = True
        Me.rbSpeedNormal.Checked = True
        Me.rbSpeedNormal.Location = New System.Drawing.Point(20, 60)
        Me.rbSpeedNormal.Name = "rbSpeedNormal"
        Me.rbSpeedNormal.Size = New System.Drawing.Size(144, 17)
        Me.rbSpeedNormal.TabIndex = 1
        Me.rbSpeedNormal.TabStop = True
        Me.rbSpeedNormal.Text = "Normal Speed (Step +10)"
        Me.rbSpeedNormal.UseVisualStyleBackColor = True
        '
        'chkEnable
        '
        Me.chkEnable.AutoSize = True
        Me.chkEnable.Location = New System.Drawing.Point(20, 30)
        Me.chkEnable.Name = "chkEnable"
        Me.chkEnable.Size = New System.Drawing.Size(154, 17)
        Me.chkEnable.TabIndex = 0
        Me.chkEnable.Text = "Enable Progress Simulation"
        Me.chkEnable.UseVisualStyleBackColor = True
        '
        'tabRuntimeEvents
        '
        Me.tabRuntimeEvents.Controls.Add(Me.Label5)
        Me.tabRuntimeEvents.Controls.Add(Me.pnlDynamic)
        Me.tabRuntimeEvents.Controls.Add(Me.btnClearDynamic)
        Me.tabRuntimeEvents.Controls.Add(Me.btnCreateDynamic)
        Me.tabRuntimeEvents.Location = New System.Drawing.Point(4, 22)
        Me.tabRuntimeEvents.Name = "tabRuntimeEvents"
        Me.tabRuntimeEvents.Size = New System.Drawing.Size(816, 455)
        Me.tabRuntimeEvents.TabIndex = 2
        Me.tabRuntimeEvents.Text = "Runtime Event Handlers"
        Me.tabRuntimeEvents.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(20, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(269, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Dynamically Created Controls with AddHandler:"
        '
        'pnlDynamic
        '
        Me.pnlDynamic.AutoScroll = True
        Me.pnlDynamic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDynamic.Location = New System.Drawing.Point(20, 90)
        Me.pnlDynamic.Name = "pnlDynamic"
        Me.pnlDynamic.Size = New System.Drawing.Size(780, 340)
        Me.pnlDynamic.TabIndex = 3
        '
        'btnClearDynamic
        '
        Me.btnClearDynamic.Location = New System.Drawing.Point(270, 45)
        Me.btnClearDynamic.Name = "btnClearDynamic"
        Me.btnClearDynamic.Size = New System.Drawing.Size(180, 32)
        Me.btnClearDynamic.TabIndex = 2
        Me.btnClearDynamic.Text = "Clear Dynamic Controls"
        Me.btnClearDynamic.UseVisualStyleBackColor = True
        '
        'btnCreateDynamic
        '
        Me.btnCreateDynamic.Location = New System.Drawing.Point(20, 45)
        Me.btnCreateDynamic.Name = "btnCreateDynamic"
        Me.btnCreateDynamic.Size = New System.Drawing.Size(240, 32)
        Me.btnCreateDynamic.TabIndex = 1
        Me.btnCreateDynamic.Text = "Generate Dynamic Button at Runtime"
        Me.btnCreateDynamic.UseVisualStyleBackColor = True
        '
        'frmLesson4_Controls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 481)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmLesson4_Controls"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lesson 4 - Planning Applications & Designing Interfaces"
        Me.TabControl1.ResumeLayout(False)
        Me.tabFormProperties.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tbOpacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBasicControls.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tabRuntimeEvents.ResumeLayout(False)
        Me.tabRuntimeEvents.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabFormProperties As TabPage
    Friend WithEvents tabBasicControls As TabPage
    Friend WithEvents tabRuntimeEvents As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblOpacityVal As Label
    Friend WithEvents tbOpacity As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents cboBorderStyle As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkTopMost As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtLayoutTheory As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtpTarget As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents rbSpeedFast As RadioButton
    Friend WithEvents rbSpeedNormal As RadioButton
    Friend WithEvents chkEnable As CheckBox
    Friend WithEvents prgBar As ProgressBar
    Friend WithEvents btnProgressStep As Button
    Friend WithEvents lblProgress As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnConfirmDialog As Button
    Friend WithEvents btnFontDialog As Button
    Friend WithEvents btnColorDialog As Button
    Friend WithEvents lblDialogPreview As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pnlDynamic As FlowLayoutPanel
    Friend WithEvents btnClearDynamic As Button
    Friend WithEvents btnCreateDynamic As Button
End Class
