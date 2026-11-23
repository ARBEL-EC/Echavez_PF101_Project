<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing Then
                ReleaseOverviewImage()
                If components IsNot Nothing Then components.Dispose()
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
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.pnlProfile = New System.Windows.Forms.Panel()
        Me.lblAvatar = New System.Windows.Forms.Label()
        Me.lblProfileName = New System.Windows.Forms.Label()
        Me.lblProfileStatus = New System.Windows.Forms.Label()
        Me.pnlNavList = New System.Windows.Forms.Panel()
        Me.lblSidebarTitle = New System.Windows.Forms.Label()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.pnlOverview = New System.Windows.Forms.Panel()
        Me.picBg = New System.Windows.Forms.PictureBox()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlProfile.SuspendLayout()
        Me.pnlNavList.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.pnlOverview.SuspendLayout()
        CType(Me.picBg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.pnlNavList)
        Me.pnlSidebar.Controls.Add(Me.pnlProfile)
        Me.pnlSidebar.Controls.Add(Me.lblSidebarTitle)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Padding = New System.Windows.Forms.Padding(12, 16, 12, 14)
        Me.pnlSidebar.Size = New System.Drawing.Size(240, 750)
        Me.pnlSidebar.TabIndex = 1
        '
        'pnlProfile
        '
        Me.pnlProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlProfile.Controls.Add(Me.lblAvatar)
        Me.pnlProfile.Controls.Add(Me.lblProfileName)
        Me.pnlProfile.Controls.Add(Me.lblProfileStatus)
        Me.pnlProfile.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlProfile.Location = New System.Drawing.Point(12, 682)
        Me.pnlProfile.Name = "pnlProfile"
        Me.pnlProfile.Padding = New System.Windows.Forms.Padding(8)
        Me.pnlProfile.Size = New System.Drawing.Size(216, 54)
        Me.pnlProfile.TabIndex = 2
        '
        'lblAvatar
        '
        Me.lblAvatar.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblAvatar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblAvatar.Location = New System.Drawing.Point(10, 10)
        Me.lblAvatar.Name = "lblAvatar"
        Me.lblAvatar.Size = New System.Drawing.Size(24, 30)
        Me.lblAvatar.TabIndex = 3
        Me.lblAvatar.Text = "●"
        Me.lblAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProfileName
        '
        Me.lblProfileName.AutoSize = True
        Me.lblProfileName.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblProfileName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblProfileName.Location = New System.Drawing.Point(38, 8)
        Me.lblProfileName.Name = "lblProfileName"
        Me.lblProfileName.Size = New System.Drawing.Size(47, 17)
        Me.lblProfileName.TabIndex = 4
        Me.lblProfileName.Text = "ARBEL"
        '
        'lblProfileStatus
        '
        Me.lblProfileStatus.AutoSize = True
        Me.lblProfileStatus.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblProfileStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.lblProfileStatus.Location = New System.Drawing.Point(38, 27)
        Me.lblProfileStatus.Name = "lblProfileStatus"
        Me.lblProfileStatus.Size = New System.Drawing.Size(72, 13)
        Me.lblProfileStatus.TabIndex = 5
        Me.lblProfileStatus.Text = "BSIT Student"
        '
        'pnlNavList
        '
        Me.pnlNavList.AutoScroll = True
        Me.pnlNavList.BackColor = System.Drawing.Color.Transparent
        Me.pnlNavList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlNavList.Location = New System.Drawing.Point(12, 51)
        Me.pnlNavList.Name = "pnlNavList"
        Me.pnlNavList.Size = New System.Drawing.Size(216, 631)
        Me.pnlNavList.TabIndex = 6
        '
        'lblSidebarTitle
        '
        Me.lblSidebarTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSidebarTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblSidebarTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblSidebarTitle.Location = New System.Drawing.Point(12, 16)
        Me.lblSidebarTitle.Name = "lblSidebarTitle"
        Me.lblSidebarTitle.Size = New System.Drawing.Size(216, 35)
        Me.lblSidebarTitle.TabIndex = 18
        Me.lblSidebarTitle.Text = "PF101 OOP"
        '
        'pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.pnlContent.Controls.Add(Me.pnlOverview)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(240, 0)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1040, 750)
        Me.pnlContent.TabIndex = 19
        '
        'pnlOverview
        '
        Me.pnlOverview.AutoScroll = True
        Me.pnlOverview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOverview.Location = New System.Drawing.Point(0, 0)
        Me.pnlOverview.Name = "pnlOverview"
        Me.pnlOverview.Padding = New System.Windows.Forms.Padding(24)
        Me.pnlOverview.Size = New System.Drawing.Size(1040, 750)
        Me.pnlOverview.TabIndex = 20
        '
        'picBg
        '
        Me.picBg.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.picBg.Dock = System.Windows.Forms.DockStyle.None
        Me.picBg.Location = New System.Drawing.Point(36, 28)
        Me.picBg.Name = "picBg"
        Me.picBg.Size = New System.Drawing.Size(160, 100)
        Me.picBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBg.TabStop = False
        Me.picBg.TabIndex = 21
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 750)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlSidebar)
        Me.IsMdiContainer = True
        Me.MinimumSize = New System.Drawing.Size(1024, 620)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PF 101 – Object Oriented Programming       Created By: Echavez, Arlvel L."
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlProfile.ResumeLayout(False)
        Me.pnlProfile.PerformLayout()
        Me.pnlNavList.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.pnlOverview.ResumeLayout(False)
        CType(Me.picBg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlProfile As Panel
    Friend WithEvents lblAvatar As Label
    Friend WithEvents lblProfileName As Label
    Friend WithEvents lblProfileStatus As Label
    Friend WithEvents pnlNavList As Panel
    Friend WithEvents lblSidebarTitle As Label
    Friend WithEvents pnlContent As Panel
    Friend WithEvents pnlOverview As Panel
    Friend WithEvents picBg As PictureBox
End Class