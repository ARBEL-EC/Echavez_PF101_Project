<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClassesObjects
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

    'NOTE: The following procedure is required by the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rootLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.headerPanel = New System.Windows.Forms.Panel()
        Me.headerLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.lblHeaderSubtitle = New System.Windows.Forms.Label()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.mainLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.leftLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.inputLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.btnInstantiate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTheory = New System.Windows.Forms.TextBox()
        Me.outputGroupBox = New System.Windows.Forms.GroupBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.rootLayout.SuspendLayout()
        Me.headerPanel.SuspendLayout()
        Me.headerLayout.SuspendLayout()
        Me.mainLayout.SuspendLayout()
        Me.leftLayout.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.inputLayout.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.outputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'rootLayout
        '
        Me.rootLayout.BackColor = System.Drawing.Color.FromArgb(15, 17, 23)
        Me.rootLayout.ColumnCount = 1
        Me.rootLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.rootLayout.Controls.Add(Me.headerPanel, 0, 0)
        Me.rootLayout.Controls.Add(Me.mainLayout, 0, 1)
        Me.rootLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rootLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.rootLayout.Name = "rootLayout"
        Me.rootLayout.Padding = New System.Windows.Forms.Padding(16)
        Me.rootLayout.RowCount = 2
        Me.rootLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94.0!))
        Me.rootLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.rootLayout.TabIndex = 0
        '
        'headerPanel
        '
        Me.headerPanel.BackColor = System.Drawing.Color.FromArgb(26, 30, 38)
        Me.headerPanel.Controls.Add(Me.headerLayout)
        Me.headerPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.headerPanel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 12)
        Me.headerPanel.Name = "headerPanel"
        Me.headerPanel.Padding = New System.Windows.Forms.Padding(18, 8, 18, 8)
        Me.headerPanel.TabIndex = 0
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
        Me.headerLayout.Padding = New System.Windows.Forms.Padding(0)
        Me.headerLayout.RowCount = 2
        Me.headerLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.headerLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.headerLayout.TabIndex = 0
        '
        'lblHeaderSubtitle
        '
        Me.lblHeaderSubtitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblHeaderSubtitle.AutoSize = True
        Me.lblHeaderSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184)
        Me.lblHeaderSubtitle.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.lblHeaderSubtitle.Name = "lblHeaderSubtitle"
        Me.lblHeaderSubtitle.TabIndex = 1
        Me.lblHeaderSubtitle.Text = "Explore object creation, inspect state, and review the class definition."
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.lblHeaderTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "Classes & Objects Testbench"
        '
        'mainLayout
        '
        Me.mainLayout.BackColor = System.Drawing.Color.FromArgb(15, 17, 23)
        Me.mainLayout.ColumnCount = 2
        Me.mainLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.0!))
        Me.mainLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.0!))
        Me.mainLayout.Controls.Add(Me.leftLayout, 0, 0)
        Me.mainLayout.Controls.Add(Me.outputGroupBox, 1, 0)
        Me.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.mainLayout.Name = "mainLayout"
        Me.mainLayout.Padding = New System.Windows.Forms.Padding(0)
        Me.mainLayout.RowCount = 1
        Me.mainLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mainLayout.TabIndex = 1
        '
        'leftLayout
        '
        Me.leftLayout.BackColor = System.Drawing.Color.FromArgb(15, 17, 23)
        Me.leftLayout.ColumnCount = 1
        Me.leftLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.leftLayout.Controls.Add(Me.GroupBox2, 0, 0)
        Me.leftLayout.Controls.Add(Me.GroupBox1, 0, 1)
        Me.leftLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.leftLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.leftLayout.Name = "leftLayout"
        Me.leftLayout.Padding = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.leftLayout.RowCount = 2
        Me.leftLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.0!))
        Me.leftLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.0!))
        Me.leftLayout.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(26, 30, 38)
        Me.GroupBox2.Controls.Add(Me.inputLayout)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(10, 8, 10, 10)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Create an Object"
        '
        'inputLayout
        '
        Me.inputLayout.BackColor = System.Drawing.Color.FromArgb(26, 30, 38)
        Me.inputLayout.ColumnCount = 2
        Me.inputLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.0!))
        Me.inputLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.0!))
        Me.inputLayout.Controls.Add(Me.Label1, 0, 0)
        Me.inputLayout.Controls.Add(Me.txtName, 1, 0)
        Me.inputLayout.Controls.Add(Me.Label2, 0, 1)
        Me.inputLayout.Controls.Add(Me.txtAge, 1, 1)
        Me.inputLayout.Controls.Add(Me.btnInstantiate, 1, 2)
        Me.inputLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inputLayout.Margin = New System.Windows.Forms.Padding(6)
        Me.inputLayout.Name = "inputLayout"
        Me.inputLayout.Padding = New System.Windows.Forms.Padding(12)
        Me.inputLayout.RowCount = 3
        Me.inputLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.inputLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.inputLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.inputLayout.TabIndex = 0
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
        Me.Label1.Text = "Enter Name:"
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(38, 44, 58)
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.txtName.Margin = New System.Windows.Forms.Padding(6)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(180, 24)
        Me.txtName.TabIndex = 1
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
        Me.Label2.Text = "Enter Age:"
        '
        'txtAge
        '
        Me.txtAge.Anchor = System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        Me.txtAge.BackColor = System.Drawing.Color.FromArgb(38, 44, 58)
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAge.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.txtAge.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(6)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(100, 24)
        Me.txtAge.TabIndex = 2
        '
        'btnInstantiate
        '
        Me.btnInstantiate.Anchor = System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        Me.btnInstantiate.BackColor = System.Drawing.Color.FromArgb(37, 99, 235)
        Me.btnInstantiate.FlatAppearance.BorderSize = 0
        Me.btnInstantiate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInstantiate.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnInstantiate.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.btnInstantiate.Margin = New System.Windows.Forms.Padding(6)
        Me.btnInstantiate.Name = "btnInstantiate"
        Me.btnInstantiate.Size = New System.Drawing.Size(150, 36)
        Me.btnInstantiate.TabIndex = 3
        Me.btnInstantiate.Text = "Instantiate Object"
        Me.btnInstantiate.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(26, 30, 38)
        Me.GroupBox1.Controls.Add(Me.txtTheory)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(10, 8, 10, 10)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Code & Theory"
        '
        'txtTheory
        '
        Me.txtTheory.BackColor = System.Drawing.Color.FromArgb(38, 44, 58)
        Me.txtTheory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTheory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTheory.Font = New System.Drawing.Font("Consolas", 9.5!, System.Drawing.FontStyle.Regular)
        Me.txtTheory.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.txtTheory.Margin = New System.Windows.Forms.Padding(6)
        Me.txtTheory.Multiline = True
        Me.txtTheory.Name = "txtTheory"
        Me.txtTheory.ReadOnly = True
        Me.txtTheory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTheory.TabIndex = 0
        Me.txtTheory.WordWrap = False
        '
        'outputGroupBox
        '
        Me.outputGroupBox.BackColor = System.Drawing.Color.FromArgb(26, 30, 38)
        Me.outputGroupBox.Controls.Add(Me.lblResult)
        Me.outputGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.outputGroupBox.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.outputGroupBox.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.outputGroupBox.Margin = New System.Windows.Forms.Padding(6)
        Me.outputGroupBox.Name = "outputGroupBox"
        Me.outputGroupBox.Padding = New System.Windows.Forms.Padding(12, 10, 12, 12)
        Me.outputGroupBox.TabIndex = 1
        Me.outputGroupBox.TabStop = False
        Me.outputGroupBox.Text = "Object State Output"
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.FromArgb(38, 44, 58)
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblResult.Font = New System.Drawing.Font("Consolas", 9.5!, System.Drawing.FontStyle.Regular)
        Me.lblResult.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(6)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Padding = New System.Windows.Forms.Padding(16)
        Me.lblResult.TabIndex = 0
        Me.lblResult.Text = "Object State: (None)"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'frmClassesObjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(15, 17, 23)
        Me.ClientSize = New System.Drawing.Size(1120, 760)
        Me.Controls.Add(Me.rootLayout)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.MinimumSize = New System.Drawing.Size(900, 620)
        Me.Name = "frmClassesObjects"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Classes & Objects Testbench"
        Me.rootLayout.ResumeLayout(False)
        Me.headerPanel.ResumeLayout(False)
        Me.headerLayout.ResumeLayout(False)
        Me.headerLayout.PerformLayout()
        Me.mainLayout.ResumeLayout(False)
        Me.leftLayout.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.inputLayout.ResumeLayout(False)
        Me.inputLayout.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.outputGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rootLayout As TableLayoutPanel
    Friend WithEvents headerPanel As Panel
    Friend WithEvents headerLayout As TableLayoutPanel
    Friend WithEvents lblHeaderSubtitle As Label
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents mainLayout As TableLayoutPanel
    Friend WithEvents leftLayout As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTheory As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents inputLayout As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents btnInstantiate As Button
    Friend WithEvents outputGroupBox As GroupBox
    Friend WithEvents lblResult As Label
End Class
