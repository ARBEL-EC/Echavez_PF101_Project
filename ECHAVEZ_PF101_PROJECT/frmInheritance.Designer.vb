<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInheritance
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTheory = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDogName = New System.Windows.Forms.TextBox()
        Me.txtBreed = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCallEat = New System.Windows.Forms.Button()
        Me.btnCallFetch = New System.Windows.Forms.Button()
        Me.btnCallSpeak = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTheory)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 340)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inheritance Theory & Syntax"
        '
        'txtTheory
        '
        Me.txtTheory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTheory.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.txtTheory.Location = New System.Drawing.Point(3, 16)
        Me.txtTheory.Multiline = True
        Me.txtTheory.Name = "txtTheory"
        Me.txtTheory.ReadOnly = True
        Me.txtTheory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTheory.Size = New System.Drawing.Size(314, 321)
        Me.txtTheory.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblOutput)
        Me.GroupBox2.Controls.Add(Me.btnCallSpeak)
        Me.GroupBox2.Controls.Add(Me.btnCallFetch)
        Me.GroupBox2.Controls.Add(Me.btnCallEat)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtBreed)
        Me.GroupBox2.Controls.Add(Me.txtDogName)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(360, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 340)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Inheritance Testbench"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dog Name:"
        '
        'txtDogName
        '
        Me.txtDogName.Location = New System.Drawing.Point(110, 32)
        Me.txtDogName.Name = "txtDogName"
        Me.txtDogName.Size = New System.Drawing.Size(140, 20)
        Me.txtDogName.TabIndex = 1
        Me.txtDogName.Text = "Buddy"
        '
        'txtBreed
        '
        Me.txtBreed.Location = New System.Drawing.Point(110, 67)
        Me.txtBreed.Name = "txtBreed"
        Me.txtBreed.Size = New System.Drawing.Size(140, 20)
        Me.txtBreed.TabIndex = 2
        Me.txtBreed.Text = "Golden Retriever"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Breed:"
        '
        'btnCallEat
        '
        Me.btnCallEat.Location = New System.Drawing.Point(20, 110)
        Me.btnCallEat.Name = "btnCallEat"
        Me.btnCallEat.Size = New System.Drawing.Size(145, 32)
        Me.btnCallEat.TabIndex = 4
        Me.btnCallEat.Text = "Inherited: Eat()"
        Me.btnCallEat.UseVisualStyleBackColor = True
        '
        'btnCallFetch
        '
        Me.btnCallFetch.Location = New System.Drawing.Point(20, 150)
        Me.btnCallFetch.Name = "btnCallFetch"
        Me.btnCallFetch.Size = New System.Drawing.Size(145, 32)
        Me.btnCallFetch.TabIndex = 5
        Me.btnCallFetch.Text = "Subclass: Fetch()"
        Me.btnCallFetch.UseVisualStyleBackColor = True
        '
        'btnCallSpeak
        '
        Me.btnCallSpeak.Location = New System.Drawing.Point(180, 110)
        Me.btnCallSpeak.Name = "btnCallSpeak"
        Me.btnCallSpeak.Size = New System.Drawing.Size(155, 32)
        Me.btnCallSpeak.TabIndex = 6
        Me.btnCallSpeak.Text = "Overridden: Speak()"
        Me.btnCallSpeak.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblOutput.Location = New System.Drawing.Point(20, 210)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(237, 19)
        Me.lblOutput.TabIndex = 7
        Me.lblOutput.Text = "Click a button to inspect behavior."
        '
        'frmInheritance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 391)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmInheritance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Introduction to OOP - Inheritance"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTheory As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCallSpeak As Button
    Friend WithEvents btnCallFetch As Button
    Friend WithEvents btnCallEat As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBreed As TextBox
    Friend WithEvents txtDogName As TextBox
    Friend WithEvents lblOutput As Label
End Class
