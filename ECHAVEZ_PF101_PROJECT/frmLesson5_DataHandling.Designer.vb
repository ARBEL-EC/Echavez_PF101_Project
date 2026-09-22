<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLesson5_DataHandling
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
        Me.tabDataTypes = New System.Windows.Forms.TabPage()
        Me.tabScope = New System.Windows.Forms.TabPage()
        Me.tabOperators = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRawInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConvertType = New System.Windows.Forms.Button()
        Me.txtConversionOutput = New System.Windows.Forms.TextBox()
        Me.cboTargetType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTypeTheory = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLocalVar = New System.Windows.Forms.Button()
        Me.btnStaticVar = New System.Windows.Forms.Button()
        Me.btnClassVar = New System.Windows.Forms.Button()
        Me.btnResetCounters = New System.Windows.Forms.Button()
        Me.lblLocalCount = New System.Windows.Forms.Label()
        Me.lblClassCount = New System.Windows.Forms.Label()
        Me.lblStaticCount = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtScopeTheory = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtOperandB = New System.Windows.Forms.TextBox()
        Me.txtOperandA = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboOperator = New System.Windows.Forms.ComboBox()
        Me.btnCalculateExpression = New System.Windows.Forms.Button()
        Me.lblExpressionResult = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtOperatorTheory = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.tabDataTypes.SuspendLayout()
        Me.tabScope.SuspendLayout()
        Me.tabOperators.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabDataTypes)
        Me.TabControl1.Controls.Add(Me.tabScope)
        Me.TabControl1.Controls.Add(Me.tabOperators)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(824, 481)
        Me.TabControl1.TabIndex = 0
        '
        'tabDataTypes
        '
        Me.tabDataTypes.Controls.Add(Me.GroupBox1)
        Me.tabDataTypes.Controls.Add(Me.GroupBox2)
        Me.tabDataTypes.Location = New System.Drawing.Point(4, 22)
        Me.tabDataTypes.Name = "tabDataTypes"
        Me.tabDataTypes.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDataTypes.Size = New System.Drawing.Size(816, 455)
        Me.tabDataTypes.TabIndex = 0
        Me.tabDataTypes.Text = "Data Types & Type Conversion"
        Me.tabDataTypes.UseVisualStyleBackColor = True
        '
        'tabScope
        '
        Me.tabScope.Controls.Add(Me.GroupBox4)
        Me.tabScope.Controls.Add(Me.GroupBox3)
        Me.tabScope.Location = New System.Drawing.Point(4, 22)
        Me.tabScope.Name = "tabScope"
        Me.tabScope.Padding = New System.Windows.Forms.Padding(3)
        Me.tabScope.Size = New System.Drawing.Size(816, 455)
        Me.tabScope.TabIndex = 1
        Me.tabScope.Text = "Scope & Lifetime Playground"
        Me.tabScope.UseVisualStyleBackColor = True
        '
        'tabOperators
        '
        Me.tabOperators.Controls.Add(Me.GroupBox6)
        Me.tabOperators.Controls.Add(Me.GroupBox5)
        Me.tabOperators.Location = New System.Drawing.Point(4, 22)
        Me.tabOperators.Name = "tabOperators"
        Me.tabOperators.Size = New System.Drawing.Size(816, 455)
        Me.tabOperators.TabIndex = 2
        Me.tabOperators.Text = "Operators & Expressions"
        Me.tabOperators.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboTargetType)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnConvertType)
        Me.GroupBox1.Controls.Add(Me.txtRawInput)
        Me.GroupBox1.Controls.Add(Me.txtConversionOutput)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 425)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dynamic Type Casting Testbench"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Input Raw Text / Number:"
        '
        'txtRawInput
        '
        Me.txtRawInput.Location = New System.Drawing.Point(20, 55)
        Me.txtRawInput.Name = "txtRawInput"
        Me.txtRawInput.Size = New System.Drawing.Size(320, 20)
        Me.txtRawInput.TabIndex = 2
        Me.txtRawInput.Text = "1024"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select Target VB.NET Data Type:"
        '
        'btnConvertType
        '
        Me.btnConvertType.Location = New System.Drawing.Point(20, 165)
        Me.btnConvertType.Name = "btnConvertType"
        Me.btnConvertType.Size = New System.Drawing.Size(320, 32)
        Me.btnConvertType.TabIndex = 5
        Me.btnConvertType.Text = "Perform Safe Parse (TryParse)"
        Me.btnConvertType.UseVisualStyleBackColor = True
        '
        'txtConversionOutput
        '
        Me.txtConversionOutput.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.txtConversionOutput.Location = New System.Drawing.Point(20, 240)
        Me.txtConversionOutput.Multiline = True
        Me.txtConversionOutput.Name = "txtConversionOutput"
        Me.txtConversionOutput.ReadOnly = True
        Me.txtConversionOutput.Size = New System.Drawing.Size(320, 160)
        Me.txtConversionOutput.TabIndex = 6
        '
        'cboTargetType
        '
        Me.cboTargetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTargetType.FormattingEnabled = True
        Me.cboTargetType.Location = New System.Drawing.Point(20, 120)
        Me.cboTargetType.Name = "cboTargetType"
        Me.cboTargetType.Size = New System.Drawing.Size(320, 21)
        Me.cboTargetType.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Conversion Result & Type Diagnostics:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTypeTheory)
        Me.GroupBox2.Location = New System.Drawing.Point(410, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(395, 425)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Type Specifications & Memory Footprint"
        '
        'txtTypeTheory
        '
        Me.txtTypeTheory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTypeTheory.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtTypeTheory.Location = New System.Drawing.Point(3, 16)
        Me.txtTypeTheory.Multiline = True
        Me.txtTypeTheory.Name = "txtTypeTheory"
        Me.txtTypeTheory.ReadOnly = True
        Me.txtTypeTheory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTypeTheory.Size = New System.Drawing.Size(389, 406)
        Me.txtTypeTheory.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblStaticCount)
        Me.GroupBox3.Controls.Add(Me.lblClassCount)
        Me.GroupBox3.Controls.Add(Me.lblLocalCount)
        Me.GroupBox3.Controls.Add(Me.btnResetCounters)
        Me.GroupBox3.Controls.Add(Me.btnClassVar)
        Me.GroupBox3.Controls.Add(Me.btnStaticVar)
        Me.GroupBox3.Controls.Add(Me.btnLocalVar)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 15)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(370, 425)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Variable Lifetime Simulator"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Click buttons to observe state persistence:"
        '
        'btnLocalVar
        '
        Me.btnLocalVar.Location = New System.Drawing.Point(20, 60)
        Me.btnLocalVar.Name = "btnLocalVar"
        Me.btnLocalVar.Size = New System.Drawing.Size(320, 35)
        Me.btnLocalVar.TabIndex = 1
        Me.btnLocalVar.Text = "Test Procedure Local Variable (Dim)"
        Me.btnLocalVar.UseVisualStyleBackColor = True
        '
        'btnStaticVar
        '
        Me.btnStaticVar.Location = New System.Drawing.Point(20, 105)
        Me.btnStaticVar.Name = "btnStaticVar"
        Me.btnStaticVar.Size = New System.Drawing.Size(320, 35)
        Me.btnStaticVar.TabIndex = 2
        Me.btnStaticVar.Text = "Test Static Local Variable (Static)"
        Me.btnStaticVar.UseVisualStyleBackColor = True
        '
        'btnClassVar
        '
        Me.btnClassVar.Location = New System.Drawing.Point(20, 150)
        Me.btnClassVar.Name = "btnClassVar"
        Me.btnClassVar.Size = New System.Drawing.Size(320, 35)
        Me.btnClassVar.TabIndex = 3
        Me.btnClassVar.Text = "Test Form-Level Member Variable (Private)"
        Me.btnClassVar.UseVisualStyleBackColor = True
        '
        'btnResetCounters
        '
        Me.btnResetCounters.Location = New System.Drawing.Point(20, 195)
        Me.btnResetCounters.Name = "btnResetCounters"
        Me.btnResetCounters.Size = New System.Drawing.Size(320, 30)
        Me.btnResetCounters.TabIndex = 4
        Me.btnResetCounters.Text = "Reset All Counters"
        Me.btnResetCounters.UseVisualStyleBackColor = True
        '
        'lblLocalCount
        '
        Me.lblLocalCount.AutoSize = True
        Me.lblLocalCount.Location = New System.Drawing.Point(20, 240)
        Me.lblLocalCount.Name = "lblLocalCount"
        Me.lblLocalCount.Size = New System.Drawing.Size(97, 13)
        Me.lblLocalCount.TabIndex = 5
        Me.lblLocalCount.Text = "Procedure Local: 0"
        '
        'lblClassCount
        '
        Me.lblClassCount.AutoSize = True
        Me.lblClassCount.Location = New System.Drawing.Point(20, 300)
        Me.lblClassCount.Name = "lblClassCount"
        Me.lblClassCount.Size = New System.Drawing.Size(108, 13)
        Me.lblClassCount.TabIndex = 6
        Me.lblClassCount.Text = "Form Field Variable: 0"
        '
        'lblStaticCount
        '
        Me.lblStaticCount.AutoSize = True
        Me.lblStaticCount.Location = New System.Drawing.Point(20, 270)
        Me.lblStaticCount.Name = "lblStaticCount"
        Me.lblStaticCount.Size = New System.Drawing.Size(87, 13)
        Me.lblStaticCount.TabIndex = 7
        Me.lblStaticCount.Text = "Static Variable: 0"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtScopeTheory)
        Me.GroupBox4.Location = New System.Drawing.Point(410, 15)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(395, 425)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Scope & Lifetime Rules"
        '
        'txtScopeTheory
        '
        Me.txtScopeTheory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtScopeTheory.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtScopeTheory.Location = New System.Drawing.Point(3, 16)
        Me.txtScopeTheory.Multiline = True
        Me.txtScopeTheory.Name = "txtScopeTheory"
        Me.txtScopeTheory.ReadOnly = True
        Me.txtScopeTheory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtScopeTheory.Size = New System.Drawing.Size(389, 406)
        Me.txtScopeTheory.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblExpressionResult)
        Me.GroupBox5.Controls.Add(Me.btnCalculateExpression)
        Me.GroupBox5.Controls.Add(Me.cboOperator)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.txtOperandA)
        Me.GroupBox5.Controls.Add(Me.txtOperandB)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Location = New System.Drawing.Point(20, 15)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(370, 425)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "GroupBox5"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Operand A:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(76, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Label6"
        '
        'txtOperandB
        '
        Me.txtOperandB.Location = New System.Drawing.Point(190, 50)
        Me.txtOperandB.Name = "txtOperandB"
        Me.txtOperandB.Size = New System.Drawing.Size(150, 20)
        Me.txtOperandB.TabIndex = 2
        Me.txtOperandB.Text = "4"
        '
        'txtOperandA
        '
        Me.txtOperandA.Location = New System.Drawing.Point(20, 50)
        Me.txtOperandA.Name = "txtOperandA"
        Me.txtOperandA.Size = New System.Drawing.Size(140, 20)
        Me.txtOperandA.TabIndex = 3
        Me.txtOperandA.Text = "15"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Operator:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(190, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Operand B:"
        '
        'cboOperator
        '
        Me.cboOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOperator.FormattingEnabled = True
        Me.cboOperator.Location = New System.Drawing.Point(20, 110)
        Me.cboOperator.Name = "cboOperator"
        Me.cboOperator.Size = New System.Drawing.Size(320, 21)
        Me.cboOperator.TabIndex = 1
        '
        'btnCalculateExpression
        '
        Me.btnCalculateExpression.Location = New System.Drawing.Point(20, 155)
        Me.btnCalculateExpression.Name = "btnCalculateExpression"
        Me.btnCalculateExpression.Size = New System.Drawing.Size(320, 34)
        Me.btnCalculateExpression.TabIndex = 6
        Me.btnCalculateExpression.Text = "Evaluate Expression"
        Me.btnCalculateExpression.UseVisualStyleBackColor = True
        '
        'lblExpressionResult
        '
        Me.lblExpressionResult.AutoSize = True
        Me.lblExpressionResult.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblExpressionResult.Location = New System.Drawing.Point(20, 205)
        Me.lblExpressionResult.Name = "lblExpressionResult"
        Me.lblExpressionResult.Size = New System.Drawing.Size(99, 19)
        Me.lblExpressionResult.TabIndex = 7
        Me.lblExpressionResult.Text = "Result: Ready"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtOperatorTheory)
        Me.GroupBox6.Location = New System.Drawing.Point(410, 15)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(395, 425)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "VB.NET Operator Hierarchy"
        '
        'txtOperatorTheory
        '
        Me.txtOperatorTheory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOperatorTheory.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtOperatorTheory.Location = New System.Drawing.Point(3, 16)
        Me.txtOperatorTheory.Multiline = True
        Me.txtOperatorTheory.Name = "txtOperatorTheory"
        Me.txtOperatorTheory.ReadOnly = True
        Me.txtOperatorTheory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOperatorTheory.Size = New System.Drawing.Size(389, 406)
        Me.txtOperatorTheory.TabIndex = 0
        '
        'frmLesson5_DataHandling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 481)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmLesson5_DataHandling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lesson 5 - Variables, Constants & Data Handling"
        Me.TabControl1.ResumeLayout(False)
        Me.tabDataTypes.ResumeLayout(False)
        Me.tabScope.ResumeLayout(False)
        Me.tabOperators.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabDataTypes As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtRawInput As TextBox
    Friend WithEvents txtConversionOutput As TextBox
    Friend WithEvents btnConvertType As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tabScope As TabPage
    Friend WithEvents tabOperators As TabPage
    Friend WithEvents cboTargetType As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTypeTheory As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnClassVar As Button
    Friend WithEvents btnStaticVar As Button
    Friend WithEvents btnLocalVar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblStaticCount As Label
    Friend WithEvents lblClassCount As Label
    Friend WithEvents lblLocalCount As Label
    Friend WithEvents btnResetCounters As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtScopeTheory As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtOperandA As TextBox
    Friend WithEvents txtOperandB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cboOperator As ComboBox
    Friend WithEvents lblExpressionResult As Label
    Friend WithEvents btnCalculateExpression As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtOperatorTheory As TextBox
End Class
