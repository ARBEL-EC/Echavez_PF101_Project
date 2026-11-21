<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatchGame
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing Then
                Me.ReleaseGameResources()
                If components IsNot Nothing Then components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlHud = New System.Windows.Forms.Panel()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblLives = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.pnlPlayfield = New System.Windows.Forms.Panel()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.lblGameMessage = New System.Windows.Forms.Label()
        Me.gameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pnlHud.SuspendLayout()
        Me.pnlPlayfield.SuspendLayout()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHud
        '
        Me.pnlHud.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.pnlHud.Controls.Add(Me.lblScore)
        Me.pnlHud.Controls.Add(Me.lblLives)
        Me.pnlHud.Controls.Add(Me.btnStart)
        Me.pnlHud.Controls.Add(Me.btnRestart)
        Me.pnlHud.Controls.Add(Me.lblHint)
        Me.pnlHud.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHud.Location = New System.Drawing.Point(0, 0)
        Me.pnlHud.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlHud.Name = "pnlHud"
        Me.pnlHud.Size = New System.Drawing.Size(960, 52)
        Me.pnlHud.TabIndex = 0
        '
        'lblScore
        '
        Me.lblScore.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblScore.Location = New System.Drawing.Point(20, 8)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(132, 36)
        Me.lblScore.TabIndex = 0
        Me.lblScore.Text = "SCORE 0000"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLives
        '
        Me.lblLives.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblLives.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblLives.Location = New System.Drawing.Point(164, 8)
        Me.lblLives.Name = "lblLives"
        Me.lblLives.Size = New System.Drawing.Size(110, 36)
        Me.lblLives.TabIndex = 1
        Me.lblLives.Text = "LIVES 3"
        Me.lblLives.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnStart
        '
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnStart.Location = New System.Drawing.Point(296, 8)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(124, 36)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start Game"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnRestart
        '
        Me.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestart.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRestart.Location = New System.Drawing.Point(432, 8)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(108, 36)
        Me.btnRestart.TabIndex = 3
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = False
        '
        'lblHint
        '
        Me.lblHint.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblHint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblHint.Location = New System.Drawing.Point(558, 8)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(382, 36)
        Me.lblHint.TabIndex = 4
        Me.lblHint.Text = "Move: Left / Right or A / D    Food +10    Avoid hazards"
        Me.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlPlayfield
        '
        Me.pnlPlayfield.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlPlayfield.Controls.Add(Me.picPlayer)
        Me.pnlPlayfield.Controls.Add(Me.lblGameMessage)
        Me.pnlPlayfield.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPlayfield.Location = New System.Drawing.Point(0, 52)
        Me.pnlPlayfield.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlPlayfield.Name = "pnlPlayfield"
        Me.pnlPlayfield.Size = New System.Drawing.Size(960, 568)
        Me.pnlPlayfield.TabIndex = 1
        Me.pnlPlayfield.TabStop = True
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer.Location = New System.Drawing.Point(432, 440)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(96, 120)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        '
        'lblGameMessage
        '
        Me.lblGameMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.lblGameMessage.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblGameMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblGameMessage.Location = New System.Drawing.Point(200, 218)
        Me.lblGameMessage.Name = "lblGameMessage"
        Me.lblGameMessage.Size = New System.Drawing.Size(560, 116)
        Me.lblGameMessage.TabIndex = 1
        Me.lblGameMessage.Text = "CATCH FOOD - AVOID HAZARDS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press Start Game to play"
        Me.lblGameMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gameTimer
        '
        Me.gameTimer.Interval = 16
        '
        'frmCatchGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(960, 620)
        Me.Controls.Add(Me.pnlPlayfield)
        Me.Controls.Add(Me.pnlHud)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmCatchGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pou Catch Game"
        Me.pnlHud.ResumeLayout(False)
        Me.pnlPlayfield.ResumeLayout(False)
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHud As System.Windows.Forms.Panel
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblLives As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents lblHint As System.Windows.Forms.Label
    Friend WithEvents pnlPlayfield As System.Windows.Forms.Panel
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents lblGameMessage As System.Windows.Forms.Label
    Friend WithEvents gameTimer As System.Windows.Forms.Timer
End Class
