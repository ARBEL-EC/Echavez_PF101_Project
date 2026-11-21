<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPolymorphism
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
        Me.mainLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTheory = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.testLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.actionPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.btnPrintDoc = New System.Windows.Forms.Button()
        Me.outputPanel = New System.Windows.Forms.Panel()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.rootLayout.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.headerLayout.SuspendLayout()
        Me.mainLayout.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.testLayout.SuspendLayout()
        Me.actionPanel.SuspendLayout()
        Me.outputPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'rootLayout
        '
        Me.rootLayout.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.rootLayout.ColumnCount = 1
        Me.rootLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.rootLayout.Controls.Add(Me.pnlHeader, 0, 0)
        Me.rootLayout.Controls.Add(Me.mainLayout, 0, 1)
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
        Me.lblHeaderTitle.Size = New System.Drawing.Size(283, 31)
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "Polymorphism Testbench"
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
        Me.lblHeaderSubtitle.Size = New System.Drawing.Size(502, 17)
        Me.lblHeaderSubtitle.TabIndex = 1
        Me.lblHeaderSubtitle.Text = "Invoke runtime behavior through a shared base type and explore interface contract" &
    "s."
        '
        'mainLayout
        '
        Me.mainLayout.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.mainLayout.ColumnCount = 2
        Me.mainLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.0!))
        Me.mainLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.0!))
        Me.mainLayout.Controls.Add(Me.GroupBox1, 0, 0)
        Me.mainLayout.Controls.Add(Me.GroupBox2, 1, 0)
        Me.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainLayout.Location = New System.Drawing.Point(16, 108)
        Me.mainLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.mainLayout.Name = "mainLayout"
        Me.mainLayout.RowCount = 1
        Me.mainLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mainLayout.Size = New System.Drawing.Size(1008, 576)
        Me.mainLayout.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtTheory)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBox1.Size = New System.Drawing.Size(431, 564)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Polymorphism & Interface Theory"
        '
        'txtTheory
        '
        Me.txtTheory.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.txtTheory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTheory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTheory.Font = New System.Drawing.Font("Consolas", 9.5!)
        Me.txtTheory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtTheory.Location = New System.Drawing.Point(12, 29)
        Me.txtTheory.Margin = New System.Windows.Forms.Padding(6)
        Me.txtTheory.Multiline = True
        Me.txtTheory.Name = "txtTheory"
        Me.txtTheory.ReadOnly = True
        Me.txtTheory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTheory.Size = New System.Drawing.Size(407, 523)
        Me.txtTheory.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.testLayout)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(449, 6)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBox2.Size = New System.Drawing.Size(553, 564)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Polymorphic Testbench"
        '
        'testLayout
        '
        Me.testLayout.ColumnCount = 2
        Me.testLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.testLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.0!))
        Me.testLayout.Controls.Add(Me.Label1, 0, 0)
        Me.testLayout.Controls.Add(Me.cboType, 1, 0)
        Me.testLayout.Controls.Add(Me.actionPanel, 0, 1)
        Me.testLayout.Controls.Add(Me.outputPanel, 0, 2)
        Me.testLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.testLayout.Location = New System.Drawing.Point(12, 29)
        Me.testLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.testLayout.Name = "testLayout"
        Me.testLayout.Padding = New System.Windows.Forms.Padding(8)
        Me.testLayout.RowCount = 3
        Me.testLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.testLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.testLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.testLayout.Size = New System.Drawing.Size(529, 523)
        Me.testLayout.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(14, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Object Type:"
        '
        'cboType
        '
        Me.cboType.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboType.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cboType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(188, 25)
        Me.cboType.Margin = New System.Windows.Forms.Padding(6)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(327, 25)
        Me.cboType.TabIndex = 1
        '
        'actionPanel
        '
        Me.actionPanel.AutoScroll = True
        Me.testLayout.SetColumnSpan(Me.actionPanel, 2)
        Me.actionPanel.Controls.Add(Me.btnExecute)
        Me.actionPanel.Controls.Add(Me.btnPrintDoc)
        Me.actionPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.actionPanel.Location = New System.Drawing.Point(12, 68)
        Me.actionPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.actionPanel.Name = "actionPanel"
        Me.actionPanel.Padding = New System.Windows.Forms.Padding(2)
        Me.actionPanel.Size = New System.Drawing.Size(505, 48)
        Me.actionPanel.TabIndex = 2
        '
        'btnExecute
        '
        Me.btnExecute.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnExecute.FlatAppearance.BorderSize = 0
        Me.btnExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExecute.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnExecute.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnExecute.Location = New System.Drawing.Point(6, 6)
        Me.btnExecute.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(180, 36)
        Me.btnExecute.TabIndex = 2
        Me.btnExecute.Text = "Invoke Speak()"
        Me.btnExecute.UseVisualStyleBackColor = False
        '
        'btnPrintDoc
        '
        Me.btnPrintDoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnPrintDoc.FlatAppearance.BorderSize = 0
        Me.btnPrintDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintDoc.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnPrintDoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnPrintDoc.Location = New System.Drawing.Point(194, 6)
        Me.btnPrintDoc.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrintDoc.Name = "btnPrintDoc"
        Me.btnPrintDoc.Size = New System.Drawing.Size(180, 36)
        Me.btnPrintDoc.TabIndex = 3
        Me.btnPrintDoc.Text = "Test IPrintable"
        Me.btnPrintDoc.UseVisualStyleBackColor = False
        '
        'outputPanel
        '
        Me.outputPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.outputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.testLayout.SetColumnSpan(Me.outputPanel, 2)
        Me.outputPanel.Controls.Add(Me.lblOutput)
        Me.outputPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.outputPanel.Location = New System.Drawing.Point(14, 126)
        Me.outputPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.outputPanel.Name = "outputPanel"
        Me.outputPanel.Padding = New System.Windows.Forms.Padding(12)
        Me.outputPanel.Size = New System.Drawing.Size(501, 383)
        Me.outputPanel.TabIndex = 3
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOutput.Font = New System.Drawing.Font("Consolas", 9.5!)
        Me.lblOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblOutput.Location = New System.Drawing.Point(12, 12)
        Me.lblOutput.Margin = New System.Windows.Forms.Padding(0)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Padding = New System.Windows.Forms.Padding(12)
        Me.lblOutput.Size = New System.Drawing.Size(475, 357)
        Me.lblOutput.TabIndex = 4
        Me.lblOutput.Text = "Polymorphic Output: (Select an option)"
        '
        'frmPolymorphism
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1040, 700)
        Me.Controls.Add(Me.rootLayout)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.MinimumSize = New System.Drawing.Size(820, 580)
        Me.Name = "frmPolymorphism"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Object-Oriented Programming - Polymorphism & Interfaces"
        Me.rootLayout.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.headerLayout.ResumeLayout(False)
        Me.headerLayout.PerformLayout()
        Me.mainLayout.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.testLayout.ResumeLayout(False)
        Me.testLayout.PerformLayout()
        Me.actionPanel.ResumeLayout(False)
        Me.outputPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rootLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents headerLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblHeaderTitle As System.Windows.Forms.Label
    Friend WithEvents lblHeaderSubtitle As System.Windows.Forms.Label
    Friend WithEvents mainLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTheory As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents testLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents btnExecute As System.Windows.Forms.Button
    Friend WithEvents btnPrintDoc As System.Windows.Forms.Button
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents actionPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents outputPanel As System.Windows.Forms.Panel
End Class
