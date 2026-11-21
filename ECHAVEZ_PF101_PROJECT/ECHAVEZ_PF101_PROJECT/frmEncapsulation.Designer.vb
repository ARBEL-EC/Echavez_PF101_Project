<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEncapsulation
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
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rootLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.headerPanel = New System.Windows.Forms.Panel()
        Me.headerLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.lblHeaderSubtitle = New System.Windows.Forms.Label()
        Me.mainLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTheory = New System.Windows.Forms.TextBox()
        Me.contentLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.transactionLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.actionPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.btnWithdraw = New System.Windows.Forms.Button()
        Me.btnCheckBalance = New System.Windows.Forms.Button()
        Me.balancePanel = New System.Windows.Forms.Panel()
        Me.balanceLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.lblBalanceCaption = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.lblStatusCaption = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.rootLayout.SuspendLayout()
        Me.headerPanel.SuspendLayout()
        Me.headerLayout.SuspendLayout()
        Me.mainLayout.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.contentLayout.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.transactionLayout.SuspendLayout()
        Me.actionPanel.SuspendLayout()
        Me.balancePanel.SuspendLayout()
        Me.balanceLayout.SuspendLayout()
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
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.lblHeaderTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "Encapsulation Testbench"
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
        Me.lblHeaderSubtitle.Text = "Explore data hiding and controlled access through account property accessors."
        '
        'mainLayout
        '
        Me.mainLayout.BackColor = System.Drawing.Color.FromArgb(15, 17, 23)
        Me.mainLayout.ColumnCount = 2
        Me.mainLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.mainLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.mainLayout.Controls.Add(Me.GroupBox1, 0, 0)
        Me.mainLayout.Controls.Add(Me.contentLayout, 1, 0)
        Me.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.mainLayout.Name = "mainLayout"
        Me.mainLayout.Padding = New System.Windows.Forms.Padding(0)
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
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(10, 8, 10, 10)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Encapsulation Concept & Code"
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
        'contentLayout
        '
        Me.contentLayout.BackColor = System.Drawing.Color.FromArgb(15, 17, 23)
        Me.contentLayout.ColumnCount = 1
        Me.contentLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.contentLayout.Controls.Add(Me.GroupBox2, 0, 0)
        Me.contentLayout.Controls.Add(Me.balancePanel, 0, 1)
        Me.contentLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.contentLayout.Name = "contentLayout"
        Me.contentLayout.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.contentLayout.RowCount = 2
        Me.contentLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.0!))
        Me.contentLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.0!))
        Me.contentLayout.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(26, 30, 38)
        Me.GroupBox2.Controls.Add(Me.transactionLayout)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(10, 8, 10, 10)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Account Transactions"
        '
        'transactionLayout
        '
        Me.transactionLayout.BackColor = System.Drawing.Color.FromArgb(26, 30, 38)
        Me.transactionLayout.ColumnCount = 2
        Me.transactionLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.transactionLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.transactionLayout.Controls.Add(Me.Label1, 0, 0)
        Me.transactionLayout.Controls.Add(Me.txtAmount, 1, 0)
        Me.transactionLayout.Controls.Add(Me.actionPanel, 0, 1)
        Me.transactionLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.transactionLayout.Margin = New System.Windows.Forms.Padding(6)
        Me.transactionLayout.Name = "transactionLayout"
        Me.transactionLayout.Padding = New System.Windows.Forms.Padding(12)
        Me.transactionLayout.RowCount = 2
        Me.transactionLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.0!))
        Me.transactionLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.0!))
        Me.transactionLayout.TabIndex = 0
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
        Me.Label1.Text = "Amount (PHP):"
        '
        'txtAmount
        '
        Me.txtAmount.Anchor = System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        Me.txtAmount.BackColor = System.Drawing.Color.FromArgb(38, 44, 58)
        Me.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmount.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.txtAmount.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(6)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(180, 24)
        Me.txtAmount.TabIndex = 1
        '
        'actionPanel
        '
        Me.actionPanel.AutoSize = True
        Me.actionPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.actionPanel.BackColor = System.Drawing.Color.FromArgb(26, 30, 38)
        Me.transactionLayout.SetColumnSpan(Me.actionPanel, 2)
        Me.actionPanel.Controls.Add(Me.btnDeposit)
        Me.actionPanel.Controls.Add(Me.btnWithdraw)
        Me.actionPanel.Controls.Add(Me.btnCheckBalance)
        Me.actionPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.actionPanel.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight
        Me.actionPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.actionPanel.Name = "actionPanel"
        Me.actionPanel.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.actionPanel.TabIndex = 2
        Me.actionPanel.WrapContents = True
        '
        'btnDeposit
        '
        Me.btnDeposit.BackColor = System.Drawing.Color.FromArgb(37, 99, 235)
        Me.btnDeposit.FlatAppearance.BorderSize = 0
        Me.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeposit.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnDeposit.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.btnDeposit.Margin = New System.Windows.Forms.Padding(0, 0, 8, 8)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(126, 36)
        Me.btnDeposit.TabIndex = 2
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = False
        '
        'btnWithdraw
        '
        Me.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(38, 44, 58)
        Me.btnWithdraw.FlatAppearance.BorderSize = 0
        Me.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWithdraw.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnWithdraw.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.btnWithdraw.Margin = New System.Windows.Forms.Padding(0, 0, 8, 8)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(126, 36)
        Me.btnWithdraw.TabIndex = 3
        Me.btnWithdraw.Text = "Withdraw"
        Me.btnWithdraw.UseVisualStyleBackColor = False
        '
        'btnCheckBalance
        '
        Me.btnCheckBalance.BackColor = System.Drawing.Color.FromArgb(38, 44, 58)
        Me.btnCheckBalance.FlatAppearance.BorderSize = 0
        Me.btnCheckBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckBalance.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnCheckBalance.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.btnCheckBalance.Margin = New System.Windows.Forms.Padding(0, 0, 8, 8)
        Me.btnCheckBalance.Name = "btnCheckBalance"
        Me.btnCheckBalance.Size = New System.Drawing.Size(140, 36)
        Me.btnCheckBalance.TabIndex = 4
        Me.btnCheckBalance.Text = "Check Balance"
        Me.btnCheckBalance.UseVisualStyleBackColor = False
        '
        'balancePanel
        '
        Me.balancePanel.BackColor = System.Drawing.Color.FromArgb(26, 30, 38)
        Me.balancePanel.Controls.Add(Me.balanceLayout)
        Me.balancePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.balancePanel.Margin = New System.Windows.Forms.Padding(6)
        Me.balancePanel.Name = "balancePanel"
        Me.balancePanel.Padding = New System.Windows.Forms.Padding(18)
        Me.balancePanel.TabIndex = 1
        '
        'balanceLayout
        '
        Me.balanceLayout.BackColor = System.Drawing.Color.FromArgb(26, 30, 38)
        Me.balanceLayout.ColumnCount = 1
        Me.balanceLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.balanceLayout.Controls.Add(Me.lblBalanceCaption, 0, 0)
        Me.balanceLayout.Controls.Add(Me.lblBalance, 0, 1)
        Me.balanceLayout.Controls.Add(Me.lblStatusCaption, 0, 2)
        Me.balanceLayout.Controls.Add(Me.lblStatus, 0, 3)
        Me.balanceLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.balanceLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.balanceLayout.Name = "balanceLayout"
        Me.balanceLayout.Padding = New System.Windows.Forms.Padding(0)
        Me.balanceLayout.RowCount = 4
        Me.balanceLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.balanceLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.0!))
        Me.balanceLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.balanceLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.0!))
        Me.balanceLayout.TabIndex = 0
        '
        'lblBalanceCaption
        '
        Me.lblBalanceCaption.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblBalanceCaption.AutoSize = True
        Me.lblBalanceCaption.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblBalanceCaption.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184)
        Me.lblBalanceCaption.Margin = New System.Windows.Forms.Padding(0)
        Me.lblBalanceCaption.Name = "lblBalanceCaption"
        Me.lblBalanceCaption.TabIndex = 0
        Me.lblBalanceCaption.Text = "ACCOUNT BALANCE"
        '
        'lblBalance
        '
        Me.lblBalance.AutoEllipsis = True
        Me.lblBalance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBalance.Font = New System.Drawing.Font("Consolas", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblBalance.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.lblBalance.Margin = New System.Windows.Forms.Padding(0, 0, 0, 14)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.TabIndex = 1
        Me.lblBalance.Text = "Current Balance: PHP 0.00"
        Me.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatusCaption
        '
        Me.lblStatusCaption.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblStatusCaption.AutoSize = True
        Me.lblStatusCaption.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblStatusCaption.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184)
        Me.lblStatusCaption.Margin = New System.Windows.Forms.Padding(0)
        Me.lblStatusCaption.Name = "lblStatusCaption"
        Me.lblStatusCaption.TabIndex = 2
        Me.lblStatusCaption.Text = "LATEST TRANSACTION"
        '
        'lblStatus
        '
        Me.lblStatus.AutoEllipsis = True
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStatus.Font = New System.Drawing.Font("Consolas", 9.5!, System.Drawing.FontStyle.Regular)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.TabIndex = 3
        Me.lblStatus.Text = "Status: Ready"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'frmEncapsulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(15, 17, 23)
        Me.ClientSize = New System.Drawing.Size(1120, 760)
        Me.Controls.Add(Me.rootLayout)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular)
        Me.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.MinimumSize = New System.Drawing.Size(900, 620)
        Me.Name = "frmEncapsulation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encapsulation Testbench"
        Me.rootLayout.ResumeLayout(False)
        Me.headerPanel.ResumeLayout(False)
        Me.headerLayout.ResumeLayout(False)
        Me.headerLayout.PerformLayout()
        Me.mainLayout.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.contentLayout.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.transactionLayout.ResumeLayout(False)
        Me.transactionLayout.PerformLayout()
        Me.actionPanel.ResumeLayout(False)
        Me.balancePanel.ResumeLayout(False)
        Me.balanceLayout.ResumeLayout(False)
        Me.balanceLayout.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rootLayout As TableLayoutPanel
    Friend WithEvents headerPanel As Panel
    Friend WithEvents headerLayout As TableLayoutPanel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblHeaderSubtitle As Label
    Friend WithEvents mainLayout As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTheory As TextBox
    Friend WithEvents contentLayout As TableLayoutPanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents transactionLayout As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents actionPanel As FlowLayoutPanel
    Friend WithEvents btnDeposit As Button
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents btnCheckBalance As Button
    Friend WithEvents balancePanel As Panel
    Friend WithEvents balanceLayout As TableLayoutPanel
    Friend WithEvents lblBalanceCaption As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents lblStatusCaption As Label
    Friend WithEvents lblStatus As Label
End Class
