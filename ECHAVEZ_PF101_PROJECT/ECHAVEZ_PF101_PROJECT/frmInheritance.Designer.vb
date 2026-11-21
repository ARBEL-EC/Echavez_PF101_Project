<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInheritance
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
        Me.txtDogName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBreed = New System.Windows.Forms.TextBox()
        Me.actionPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnCallEat = New System.Windows.Forms.Button()
        Me.btnCallSpeak = New System.Windows.Forms.Button()
        Me.btnCallFetch = New System.Windows.Forms.Button()
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
        Me.rootLayout.BackColor = System.Drawing.Color.FromArgb(15, 17, 23)
        Me.rootLayout.ColumnCount = 1
        Me.rootLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.rootLayout.Controls.Add(Me.pnlHeader, 0, 0)
        Me.rootLayout.Controls.Add(Me.mainLayout, 0, 1)
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
        Me.lblHeaderTitle.Text = "Inheritance Testbench"
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
        Me.lblHeaderSubtitle.Text = "Explore inherited, overridden, and subclass-specific behavior with a live Dog object."
        '
        'mainLayout
        '
        Me.mainLayout.BackColor = System.Drawing.Color.FromArgb(15, 17, 23)
        Me.mainLayout.ColumnCount = 2
        Me.mainLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.0!))
        Me.mainLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.0!))
        Me.mainLayout.Controls.Add(Me.GroupBox1, 0, 0)
        Me.mainLayout.Controls.Add(Me.GroupBox2, 1, 0)
        Me.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.mainLayout.Name = "mainLayout"
        Me.mainLayout.RowCount = 1
        Me.mainLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mainLayout.TabIndex = 1
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
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inheritance Theory & Syntax"
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
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(26, 30, 38)
        Me.GroupBox2.Controls.Add(Me.testLayout)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Object Behavior"
        '
        'testLayout
        '
        Me.testLayout.ColumnCount = 2
        Me.testLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.testLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.0!))
        Me.testLayout.Controls.Add(Me.Label1, 0, 0)
        Me.testLayout.Controls.Add(Me.txtDogName, 1, 0)
        Me.testLayout.Controls.Add(Me.Label2, 0, 1)
        Me.testLayout.Controls.Add(Me.txtBreed, 1, 1)
        Me.testLayout.Controls.Add(Me.actionPanel, 0, 2)
        Me.testLayout.Controls.Add(Me.outputPanel, 0, 3)
        Me.testLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.testLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.testLayout.Name = "testLayout"
        Me.testLayout.Padding = New System.Windows.Forms.Padding(8)
        Me.testLayout.RowCount = 4
        Me.testLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.testLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.testLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.testLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.testLayout.SetColumnSpan(Me.actionPanel, 2)
        Me.testLayout.SetColumnSpan(Me.outputPanel, 2)
        Me.testLayout.TabIndex = 0
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
        Me.Label1.Text = "Dog Name:"
        '
        'txtDogName
        '
        Me.txtDogName.Anchor = System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        Me.txtDogName.BackColor = System.Drawing.Color.FromArgb(38, 44, 58)
        Me.txtDogName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDogName.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.txtDogName.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.txtDogName.Margin = New System.Windows.Forms.Padding(6)
        Me.txtDogName.Name = "txtDogName"
        Me.txtDogName.Size = New System.Drawing.Size(250, 24)
        Me.txtDogName.TabIndex = 1
        Me.txtDogName.Text = "Buddy"
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
        Me.Label2.Text = "Breed:"
        '
        'txtBreed
        '
        Me.txtBreed.Anchor = System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        Me.txtBreed.BackColor = System.Drawing.Color.FromArgb(38, 44, 58)
        Me.txtBreed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBreed.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.txtBreed.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.txtBreed.Margin = New System.Windows.Forms.Padding(6)
        Me.txtBreed.Name = "txtBreed"
        Me.txtBreed.Size = New System.Drawing.Size(250, 24)
        Me.txtBreed.TabIndex = 2
        Me.txtBreed.Text = "Golden Retriever"
        '
        'actionPanel
        '
        Me.actionPanel.AutoScroll = True
        Me.actionPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.actionPanel.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight
        Me.actionPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.actionPanel.Name = "actionPanel"
        Me.actionPanel.Padding = New System.Windows.Forms.Padding(2)
        Me.actionPanel.WrapContents = True
        Me.actionPanel.Controls.Add(Me.btnCallEat)
        Me.actionPanel.Controls.Add(Me.btnCallSpeak)
        Me.actionPanel.Controls.Add(Me.btnCallFetch)
        Me.actionPanel.TabIndex = 3
        '
        'btnCallEat
        '
        Me.btnCallEat.BackColor = System.Drawing.Color.FromArgb(37, 99, 235)
        Me.btnCallEat.FlatAppearance.BorderSize = 0
        Me.btnCallEat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCallEat.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnCallEat.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.btnCallEat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCallEat.Name = "btnCallEat"
        Me.btnCallEat.Size = New System.Drawing.Size(170, 36)
        Me.btnCallEat.TabIndex = 3
        Me.btnCallEat.Text = "Inherited: Eat()"
        Me.btnCallEat.UseVisualStyleBackColor = False
        '
        'btnCallSpeak
        '
        Me.btnCallSpeak.BackColor = System.Drawing.Color.FromArgb(38, 44, 58)
        Me.btnCallSpeak.FlatAppearance.BorderSize = 0
        Me.btnCallSpeak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCallSpeak.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnCallSpeak.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.btnCallSpeak.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCallSpeak.Name = "btnCallSpeak"
        Me.btnCallSpeak.Size = New System.Drawing.Size(170, 36)
        Me.btnCallSpeak.TabIndex = 4
        Me.btnCallSpeak.Text = "Overridden: Speak()"
        Me.btnCallSpeak.UseVisualStyleBackColor = False
        '
        'btnCallFetch
        '
        Me.btnCallFetch.BackColor = System.Drawing.Color.FromArgb(38, 44, 58)
        Me.btnCallFetch.FlatAppearance.BorderSize = 0
        Me.btnCallFetch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCallFetch.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnCallFetch.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.btnCallFetch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCallFetch.Name = "btnCallFetch"
        Me.btnCallFetch.Size = New System.Drawing.Size(170, 36)
        Me.btnCallFetch.TabIndex = 5
        Me.btnCallFetch.Text = "Subclass: Fetch()"
        Me.btnCallFetch.UseVisualStyleBackColor = False
        '
        'outputPanel
        '
        Me.outputPanel.BackColor = System.Drawing.Color.FromArgb(26, 30, 38)
        Me.outputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.outputPanel.Controls.Add(Me.lblOutput)
        Me.outputPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.outputPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.outputPanel.Name = "outputPanel"
        Me.outputPanel.Padding = New System.Windows.Forms.Padding(12)
        Me.outputPanel.TabIndex = 6
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.Color.FromArgb(38, 44, 58)
        Me.lblOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOutput.Font = New System.Drawing.Font("Consolas", 9.5!, System.Drawing.FontStyle.Regular)
        Me.lblOutput.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.lblOutput.Margin = New System.Windows.Forms.Padding(0)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Padding = New System.Windows.Forms.Padding(12)
        Me.lblOutput.TabIndex = 0
        Me.lblOutput.Text = "Click a button to inspect behavior."
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'frmInheritance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(15, 17, 23)
        Me.ClientSize = New System.Drawing.Size(1040, 700)
        Me.Controls.Add(Me.rootLayout)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.MinimumSize = New System.Drawing.Size(820, 580)
        Me.Name = "frmInheritance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Object-Oriented Programming - Inheritance"
        Me.rootLayout.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.headerLayout.ResumeLayout(False)
        Me.headerLayout.PerformLayout()
        Me.mainLayout.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
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
    Friend WithEvents txtDogName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBreed As System.Windows.Forms.TextBox
    Friend WithEvents actionPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnCallEat As System.Windows.Forms.Button
    Friend WithEvents btnCallSpeak As System.Windows.Forms.Button
    Friend WithEvents btnCallFetch As System.Windows.Forms.Button
    Friend WithEvents outputPanel As System.Windows.Forms.Panel
    Friend WithEvents lblOutput As System.Windows.Forms.Label
End Class
