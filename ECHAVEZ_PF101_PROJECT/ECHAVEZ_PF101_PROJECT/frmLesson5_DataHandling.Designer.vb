<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLesson5_DataHandling
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabDataTypes = New System.Windows.Forms.TabPage()
        Me.dataLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.conversionLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRawInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboTargetType = New System.Windows.Forms.ComboBox()
        Me.btnConvertType = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtConversionOutput = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTypeTheory = New System.Windows.Forms.TextBox()
        Me.tabScope = New System.Windows.Forms.TabPage()
        Me.scopeLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.counterLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLocalVar = New System.Windows.Forms.Button()
        Me.btnStaticVar = New System.Windows.Forms.Button()
        Me.btnClassVar = New System.Windows.Forms.Button()
        Me.btnResetCounters = New System.Windows.Forms.Button()
        Me.lblLocalCount = New System.Windows.Forms.Label()
        Me.lblStaticCount = New System.Windows.Forms.Label()
        Me.lblClassCount = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtScopeTheory = New System.Windows.Forms.TextBox()
        Me.tabOperators = New System.Windows.Forms.TabPage()
        Me.operatorLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.expressionLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtOperandA = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtOperandB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboOperator = New System.Windows.Forms.ComboBox()
        Me.btnCalculateExpression = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.expressionOutputPanel = New System.Windows.Forms.Panel()
        Me.lblExpressionResult = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtOperatorTheory = New System.Windows.Forms.TextBox()
        Me.rootLayout.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.headerLayout.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabDataTypes.SuspendLayout()
        Me.dataLayout.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.conversionLayout.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tabScope.SuspendLayout()
        Me.scopeLayout.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.counterLayout.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.tabOperators.SuspendLayout()
        Me.operatorLayout.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.expressionLayout.SuspendLayout()
        Me.expressionOutputPanel.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'rootLayout
        '
        Me.rootLayout.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.rootLayout.ColumnCount = 1
        Me.rootLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.rootLayout.Controls.Add(Me.pnlHeader, 0, 0)
        Me.rootLayout.Controls.Add(Me.TabControl1, 0, 1)
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
        Me.lblHeaderTitle.Size = New System.Drawing.Size(278, 31)
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "Variables & Data Handling"
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
        Me.lblHeaderSubtitle.Size = New System.Drawing.Size(494, 17)
        Me.lblHeaderSubtitle.TabIndex = 1
        Me.lblHeaderSubtitle.Text = "Convert values safely, compare variable lifetimes, and evaluate VB.NET expression" &
    "s."
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabDataTypes)
        Me.TabControl1.Controls.Add(Me.tabScope)
        Me.TabControl1.Controls.Add(Me.tabOperators)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.TabControl1.Location = New System.Drawing.Point(19, 111)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1002, 570)
        Me.TabControl1.TabIndex = 1
        '
        'tabDataTypes
        '
        Me.tabDataTypes.Controls.Add(Me.dataLayout)
        Me.tabDataTypes.Location = New System.Drawing.Point(4, 26)
        Me.tabDataTypes.Name = "tabDataTypes"
        Me.tabDataTypes.Padding = New System.Windows.Forms.Padding(8)
        Me.tabDataTypes.Size = New System.Drawing.Size(994, 540)
        Me.tabDataTypes.TabIndex = 0
        Me.tabDataTypes.Text = "Data Types & Type Conversion"
        Me.tabDataTypes.UseVisualStyleBackColor = True
        '
        'dataLayout
        '
        Me.dataLayout.ColumnCount = 2
        Me.dataLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.0!))
        Me.dataLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.0!))
        Me.dataLayout.Controls.Add(Me.GroupBox1, 0, 0)
        Me.dataLayout.Controls.Add(Me.GroupBox2, 1, 0)
        Me.dataLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataLayout.Location = New System.Drawing.Point(8, 8)
        Me.dataLayout.Name = "dataLayout"
        Me.dataLayout.Padding = New System.Windows.Forms.Padding(4)
        Me.dataLayout.RowCount = 1
        Me.dataLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.dataLayout.Size = New System.Drawing.Size(978, 524)
        Me.dataLayout.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.conversionLayout)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBox1.Size = New System.Drawing.Size(414, 504)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dynamic Type Casting Testbench"
        '
        'conversionLayout
        '
        Me.conversionLayout.ColumnCount = 2
        Me.conversionLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.0!))
        Me.conversionLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.0!))
        Me.conversionLayout.Controls.Add(Me.Label1, 0, 0)
        Me.conversionLayout.Controls.Add(Me.txtRawInput, 1, 0)
        Me.conversionLayout.Controls.Add(Me.Label2, 0, 1)
        Me.conversionLayout.Controls.Add(Me.cboTargetType, 1, 1)
        Me.conversionLayout.Controls.Add(Me.btnConvertType, 0, 2)
        Me.conversionLayout.Controls.Add(Me.Label4, 0, 3)
        Me.conversionLayout.Controls.Add(Me.txtConversionOutput, 0, 4)
        Me.conversionLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.conversionLayout.Location = New System.Drawing.Point(12, 29)
        Me.conversionLayout.Name = "conversionLayout"
        Me.conversionLayout.Padding = New System.Windows.Forms.Padding(8)
        Me.conversionLayout.RowCount = 5
        Me.conversionLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.conversionLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.conversionLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.conversionLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.conversionLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.conversionLayout.Size = New System.Drawing.Size(390, 463)
        Me.conversionLayout.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(14, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input Raw Text / Number:"
        '
        'txtRawInput
        '
        Me.txtRawInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRawInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.txtRawInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRawInput.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtRawInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtRawInput.Location = New System.Drawing.Point(174, 23)
        Me.txtRawInput.Margin = New System.Windows.Forms.Padding(6)
        Me.txtRawInput.Name = "txtRawInput"
        Me.txtRawInput.Size = New System.Drawing.Size(202, 24)
        Me.txtRawInput.TabIndex = 1
        Me.txtRawInput.Text = "1024"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(14, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Target Data Type:"
        '
        'cboTargetType
        '
        Me.cboTargetType.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTargetType.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.cboTargetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTargetType.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cboTargetType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cboTargetType.FormattingEnabled = True
        Me.cboTargetType.Location = New System.Drawing.Point(174, 83)
        Me.cboTargetType.Margin = New System.Windows.Forms.Padding(6)
        Me.cboTargetType.Name = "cboTargetType"
        Me.cboTargetType.Size = New System.Drawing.Size(202, 25)
        Me.cboTargetType.TabIndex = 2
        '
        'btnConvertType
        '
        Me.btnConvertType.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.conversionLayout.SetColumnSpan(Me.btnConvertType, 2)
        Me.btnConvertType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnConvertType.FlatAppearance.BorderSize = 0
        Me.btnConvertType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConvertType.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnConvertType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnConvertType.Location = New System.Drawing.Point(14, 132)
        Me.btnConvertType.Margin = New System.Windows.Forms.Padding(6)
        Me.btnConvertType.Name = "btnConvertType"
        Me.btnConvertType.MinimumSize = New System.Drawing.Size(150, 36)
        Me.btnConvertType.Size = New System.Drawing.Size(300, 36)
        Me.btnConvertType.TabIndex = 3
        Me.btnConvertType.Text = "Perform Safe Parse (TryParse)"
        Me.btnConvertType.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.conversionLayout.SetColumnSpan(Me.Label4, 2)
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(14, 193)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(236, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Conversion Result & Type Diagnostics:"
        '
        'txtConversionOutput
        '
        Me.txtConversionOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.txtConversionOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.conversionLayout.SetColumnSpan(Me.txtConversionOutput, 2)
        Me.txtConversionOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtConversionOutput.Font = New System.Drawing.Font("Consolas", 9.5!)
        Me.txtConversionOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtConversionOutput.Location = New System.Drawing.Point(14, 228)
        Me.txtConversionOutput.Margin = New System.Windows.Forms.Padding(6)
        Me.txtConversionOutput.Multiline = True
        Me.txtConversionOutput.Name = "txtConversionOutput"
        Me.txtConversionOutput.ReadOnly = True
        Me.txtConversionOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConversionOutput.Size = New System.Drawing.Size(362, 221)
        Me.txtConversionOutput.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.txtTypeTheory)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(436, 10)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBox2.Size = New System.Drawing.Size(532, 504)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Types & Conversion Reference"
        '
        'txtTypeTheory
        '
        Me.txtTypeTheory.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.txtTypeTheory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTypeTheory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTypeTheory.Font = New System.Drawing.Font("Consolas", 9.5!)
        Me.txtTypeTheory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtTypeTheory.Location = New System.Drawing.Point(12, 29)
        Me.txtTypeTheory.Margin = New System.Windows.Forms.Padding(6)
        Me.txtTypeTheory.Multiline = True
        Me.txtTypeTheory.Name = "txtTypeTheory"
        Me.txtTypeTheory.ReadOnly = True
        Me.txtTypeTheory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTypeTheory.Size = New System.Drawing.Size(508, 463)
        Me.txtTypeTheory.TabIndex = 0
        '
        'tabScope
        '
        Me.tabScope.Controls.Add(Me.scopeLayout)
        Me.tabScope.Location = New System.Drawing.Point(4, 26)
        Me.tabScope.Name = "tabScope"
        Me.tabScope.Padding = New System.Windows.Forms.Padding(8)
        Me.tabScope.Size = New System.Drawing.Size(192, 70)
        Me.tabScope.TabIndex = 1
        Me.tabScope.Text = "Scope & Lifetime Playground"
        Me.tabScope.UseVisualStyleBackColor = True
        '
        'scopeLayout
        '
        Me.scopeLayout.ColumnCount = 2
        Me.scopeLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.0!))
        Me.scopeLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.0!))
        Me.scopeLayout.Controls.Add(Me.GroupBox3, 0, 0)
        Me.scopeLayout.Controls.Add(Me.GroupBox4, 1, 0)
        Me.scopeLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scopeLayout.Location = New System.Drawing.Point(8, 8)
        Me.scopeLayout.Name = "scopeLayout"
        Me.scopeLayout.Padding = New System.Windows.Forms.Padding(4)
        Me.scopeLayout.RowCount = 1
        Me.scopeLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.scopeLayout.Size = New System.Drawing.Size(176, 54)
        Me.scopeLayout.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.counterLayout)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBox3.Size = New System.Drawing.Size(61, 34)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Variable Lifetime Simulator"
        '
        'counterLayout
        '
        Me.counterLayout.ColumnCount = 1
        Me.counterLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.counterLayout.Controls.Add(Me.Label3, 0, 0)
        Me.counterLayout.Controls.Add(Me.btnLocalVar, 0, 1)
        Me.counterLayout.Controls.Add(Me.btnStaticVar, 0, 2)
        Me.counterLayout.Controls.Add(Me.btnClassVar, 0, 3)
        Me.counterLayout.Controls.Add(Me.btnResetCounters, 0, 4)
        Me.counterLayout.Controls.Add(Me.lblLocalCount, 0, 5)
        Me.counterLayout.Controls.Add(Me.lblStaticCount, 0, 6)
        Me.counterLayout.Controls.Add(Me.lblClassCount, 0, 7)
        Me.counterLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.counterLayout.Location = New System.Drawing.Point(12, 29)
        Me.counterLayout.Name = "counterLayout"
        Me.counterLayout.Padding = New System.Windows.Forms.Padding(6)
        Me.counterLayout.RowCount = 8
        Me.counterLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.counterLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.counterLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.counterLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.counterLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.counterLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.counterLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.counterLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.counterLayout.Size = New System.Drawing.Size(37, 0)
        Me.counterLayout.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 12)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 30)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Observe state persistence:"
        '
        'btnLocalVar
        '
        Me.btnLocalVar.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnLocalVar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLocalVar.FlatAppearance.BorderSize = 0
        Me.btnLocalVar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLocalVar.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnLocalVar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnLocalVar.Location = New System.Drawing.Point(12, 54)
        Me.btnLocalVar.Margin = New System.Windows.Forms.Padding(6)
        Me.btnLocalVar.Name = "btnLocalVar"
        Me.btnLocalVar.MinimumSize = New System.Drawing.Size(150, 36)
        Me.btnLocalVar.Size = New System.Drawing.Size(160, 36)
        Me.btnLocalVar.TabIndex = 1
        Me.btnLocalVar.Text = "Test Procedure Local Variable (Dim)"
        Me.btnLocalVar.UseVisualStyleBackColor = False
        '
        'btnStaticVar
        '
        Me.btnStaticVar.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnStaticVar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnStaticVar.FlatAppearance.BorderSize = 0
        Me.btnStaticVar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaticVar.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnStaticVar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnStaticVar.Location = New System.Drawing.Point(12, 104)
        Me.btnStaticVar.Margin = New System.Windows.Forms.Padding(6)
        Me.btnStaticVar.Name = "btnStaticVar"
        Me.btnStaticVar.MinimumSize = New System.Drawing.Size(150, 36)
        Me.btnStaticVar.Size = New System.Drawing.Size(160, 36)
        Me.btnStaticVar.TabIndex = 2
        Me.btnStaticVar.Text = "Test Static Local Variable (Static)"
        Me.btnStaticVar.UseVisualStyleBackColor = False
        '
        'btnClassVar
        '
        Me.btnClassVar.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnClassVar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClassVar.FlatAppearance.BorderSize = 0
        Me.btnClassVar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClassVar.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnClassVar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnClassVar.Location = New System.Drawing.Point(12, 154)
        Me.btnClassVar.Margin = New System.Windows.Forms.Padding(6)
        Me.btnClassVar.Name = "btnClassVar"
        Me.btnClassVar.MinimumSize = New System.Drawing.Size(150, 36)
        Me.btnClassVar.Size = New System.Drawing.Size(160, 36)
        Me.btnClassVar.TabIndex = 3
        Me.btnClassVar.Text = "Test Form-Level Member Variable (Private)"
        Me.btnClassVar.UseVisualStyleBackColor = False
        '
        'btnResetCounters
        '
        Me.btnResetCounters.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnResetCounters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnResetCounters.FlatAppearance.BorderSize = 0
        Me.btnResetCounters.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetCounters.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnResetCounters.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnResetCounters.Location = New System.Drawing.Point(12, 204)
        Me.btnResetCounters.Margin = New System.Windows.Forms.Padding(6)
        Me.btnResetCounters.Name = "btnResetCounters"
        Me.btnResetCounters.MinimumSize = New System.Drawing.Size(150, 36)
        Me.btnResetCounters.Size = New System.Drawing.Size(160, 36)
        Me.btnResetCounters.TabIndex = 4
        Me.btnResetCounters.Text = "Reset All Counters"
        Me.btnResetCounters.UseVisualStyleBackColor = False
        '
        'lblLocalCount
        '
        Me.lblLocalCount.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblLocalCount.AutoSize = True
        Me.lblLocalCount.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblLocalCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblLocalCount.Location = New System.Drawing.Point(12, 254)
        Me.lblLocalCount.Margin = New System.Windows.Forms.Padding(6)
        Me.lblLocalCount.Name = "lblLocalCount"
        Me.lblLocalCount.Size = New System.Drawing.Size(13, 22)
        Me.lblLocalCount.TabIndex = 5
        Me.lblLocalCount.Text = "Procedure Local: 0"
        '
        'lblStaticCount
        '
        Me.lblStaticCount.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblStaticCount.AutoSize = True
        Me.lblStaticCount.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblStaticCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblStaticCount.Location = New System.Drawing.Point(12, 288)
        Me.lblStaticCount.Margin = New System.Windows.Forms.Padding(6)
        Me.lblStaticCount.Name = "lblStaticCount"
        Me.lblStaticCount.Size = New System.Drawing.Size(13, 22)
        Me.lblStaticCount.TabIndex = 6
        Me.lblStaticCount.Text = "Static Variable: 0"
        '
        'lblClassCount
        '
        Me.lblClassCount.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblClassCount.AutoSize = True
        Me.lblClassCount.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblClassCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblClassCount.Location = New System.Drawing.Point(12, 322)
        Me.lblClassCount.Margin = New System.Windows.Forms.Padding(6)
        Me.lblClassCount.Name = "lblClassCount"
        Me.lblClassCount.Size = New System.Drawing.Size(13, 1)
        Me.lblClassCount.TabIndex = 7
        Me.lblClassCount.Text = "Form Field Variable: 0"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.txtScopeTheory)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(83, 10)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBox4.Size = New System.Drawing.Size(83, 34)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Scope & Lifetime Rules"
        '
        'txtScopeTheory
        '
        Me.txtScopeTheory.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.txtScopeTheory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtScopeTheory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtScopeTheory.Font = New System.Drawing.Font("Consolas", 9.5!)
        Me.txtScopeTheory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtScopeTheory.Location = New System.Drawing.Point(12, 29)
        Me.txtScopeTheory.Margin = New System.Windows.Forms.Padding(6)
        Me.txtScopeTheory.Multiline = True
        Me.txtScopeTheory.Name = "txtScopeTheory"
        Me.txtScopeTheory.ReadOnly = True
        Me.txtScopeTheory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtScopeTheory.Size = New System.Drawing.Size(59, 0)
        Me.txtScopeTheory.TabIndex = 0
        '
        'tabOperators
        '
        Me.tabOperators.Controls.Add(Me.operatorLayout)
        Me.tabOperators.Location = New System.Drawing.Point(4, 26)
        Me.tabOperators.Name = "tabOperators"
        Me.tabOperators.Padding = New System.Windows.Forms.Padding(8)
        Me.tabOperators.Size = New System.Drawing.Size(192, 70)
        Me.tabOperators.TabIndex = 2
        Me.tabOperators.Text = "Operators & Expressions"
        Me.tabOperators.UseVisualStyleBackColor = True
        '
        'operatorLayout
        '
        Me.operatorLayout.ColumnCount = 2
        Me.operatorLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.0!))
        Me.operatorLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.0!))
        Me.operatorLayout.Controls.Add(Me.GroupBox5, 0, 0)
        Me.operatorLayout.Controls.Add(Me.GroupBox6, 1, 0)
        Me.operatorLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.operatorLayout.Location = New System.Drawing.Point(8, 8)
        Me.operatorLayout.Name = "operatorLayout"
        Me.operatorLayout.Padding = New System.Windows.Forms.Padding(4)
        Me.operatorLayout.RowCount = 1
        Me.operatorLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.operatorLayout.Size = New System.Drawing.Size(176, 54)
        Me.operatorLayout.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.expressionLayout)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GroupBox5.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBox5.Size = New System.Drawing.Size(61, 34)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Expression Evaluator"
        '
        'expressionLayout
        '
        Me.expressionLayout.ColumnCount = 2
        Me.expressionLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.0!))
        Me.expressionLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.0!))
        Me.expressionLayout.Controls.Add(Me.Label5, 0, 0)
        Me.expressionLayout.Controls.Add(Me.txtOperandA, 1, 0)
        Me.expressionLayout.Controls.Add(Me.Label8, 0, 1)
        Me.expressionLayout.Controls.Add(Me.txtOperandB, 1, 1)
        Me.expressionLayout.Controls.Add(Me.Label7, 0, 2)
        Me.expressionLayout.Controls.Add(Me.cboOperator, 1, 2)
        Me.expressionLayout.Controls.Add(Me.btnCalculateExpression, 0, 3)
        Me.expressionLayout.Controls.Add(Me.Label6, 0, 4)
        Me.expressionLayout.Controls.Add(Me.expressionOutputPanel, 0, 5)
        Me.expressionLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.expressionLayout.Location = New System.Drawing.Point(12, 29)
        Me.expressionLayout.Name = "expressionLayout"
        Me.expressionLayout.Padding = New System.Windows.Forms.Padding(8)
        Me.expressionLayout.RowCount = 6
        Me.expressionLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.expressionLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.expressionLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.expressionLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.expressionLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.expressionLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.expressionLayout.Size = New System.Drawing.Size(37, 0)
        Me.expressionLayout.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(14, 25)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Operand A:"
        '
        'txtOperandA
        '
        Me.txtOperandA.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOperandA.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.txtOperandA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOperandA.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtOperandA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtOperandA.Location = New System.Drawing.Point(21, 22)
        Me.txtOperandA.Margin = New System.Windows.Forms.Padding(6)
        Me.txtOperandA.Name = "txtOperandA"
        Me.txtOperandA.Size = New System.Drawing.Size(2, 24)
        Me.txtOperandA.TabIndex = 1
        Me.txtOperandA.Text = "15"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(14, 77)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1, 17)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Operand B:"
        '
        'txtOperandB
        '
        Me.txtOperandB.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOperandB.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.txtOperandB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOperandB.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtOperandB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtOperandB.Location = New System.Drawing.Point(21, 74)
        Me.txtOperandB.Margin = New System.Windows.Forms.Padding(6)
        Me.txtOperandB.Name = "txtOperandB"
        Me.txtOperandB.Size = New System.Drawing.Size(2, 24)
        Me.txtOperandB.TabIndex = 2
        Me.txtOperandB.Text = "4"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(14, 131)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Operator:"
        '
        'cboOperator
        '
        Me.cboOperator.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboOperator.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.cboOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOperator.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cboOperator.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cboOperator.FormattingEnabled = True
        Me.cboOperator.Location = New System.Drawing.Point(21, 129)
        Me.cboOperator.Margin = New System.Windows.Forms.Padding(6)
        Me.cboOperator.Name = "cboOperator"
        Me.cboOperator.Size = New System.Drawing.Size(2, 25)
        Me.cboOperator.TabIndex = 3
        '
        'btnCalculateExpression
        '
        Me.btnCalculateExpression.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.expressionLayout.SetColumnSpan(Me.btnCalculateExpression, 2)
        Me.btnCalculateExpression.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCalculateExpression.FlatAppearance.BorderSize = 0
        Me.btnCalculateExpression.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculateExpression.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnCalculateExpression.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnCalculateExpression.Location = New System.Drawing.Point(14, 174)
        Me.btnCalculateExpression.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCalculateExpression.Name = "btnCalculateExpression"
        Me.btnCalculateExpression.MinimumSize = New System.Drawing.Size(150, 36)
        Me.btnCalculateExpression.Size = New System.Drawing.Size(160, 36)
        Me.btnCalculateExpression.TabIndex = 4
        Me.btnCalculateExpression.Text = "Evaluate Expression"
        Me.btnCalculateExpression.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.expressionLayout.SetColumnSpan(Me.Label6, 2)
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(14, 232)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(9, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Expression Result:"
        '
        'expressionOutputPanel
        '
        Me.expressionOutputPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.expressionOutputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.expressionLayout.SetColumnSpan(Me.expressionOutputPanel, 2)
        Me.expressionOutputPanel.Controls.Add(Me.lblExpressionResult)
        Me.expressionOutputPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.expressionOutputPanel.Location = New System.Drawing.Point(14, 268)
        Me.expressionOutputPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.expressionOutputPanel.Name = "expressionOutputPanel"
        Me.expressionOutputPanel.Padding = New System.Windows.Forms.Padding(10)
        Me.expressionOutputPanel.Size = New System.Drawing.Size(9, 1)
        Me.expressionOutputPanel.TabIndex = 6
        '
        'lblExpressionResult
        '
        Me.lblExpressionResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblExpressionResult.Font = New System.Drawing.Font("Consolas", 9.5!)
        Me.lblExpressionResult.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblExpressionResult.Location = New System.Drawing.Point(10, 10)
        Me.lblExpressionResult.Margin = New System.Windows.Forms.Padding(0)
        Me.lblExpressionResult.Name = "lblExpressionResult"
        Me.lblExpressionResult.Size = New System.Drawing.Size(0, 0)
        Me.lblExpressionResult.TabIndex = 0
        Me.lblExpressionResult.Text = "Result: Ready"
        Me.lblExpressionResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.GroupBox6.Controls.Add(Me.txtOperatorTheory)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GroupBox6.Location = New System.Drawing.Point(83, 10)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBox6.Size = New System.Drawing.Size(83, 34)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "VB.NET Operator Hierarchy"
        '
        'txtOperatorTheory
        '
        Me.txtOperatorTheory.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.txtOperatorTheory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOperatorTheory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOperatorTheory.Font = New System.Drawing.Font("Consolas", 9.5!)
        Me.txtOperatorTheory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtOperatorTheory.Location = New System.Drawing.Point(12, 29)
        Me.txtOperatorTheory.Margin = New System.Windows.Forms.Padding(6)
        Me.txtOperatorTheory.Multiline = True
        Me.txtOperatorTheory.Name = "txtOperatorTheory"
        Me.txtOperatorTheory.ReadOnly = True
        Me.txtOperatorTheory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOperatorTheory.Size = New System.Drawing.Size(59, 0)
        Me.txtOperatorTheory.TabIndex = 0
        '
        'frmLesson5_DataHandling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1040, 700)
        Me.Controls.Add(Me.rootLayout)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.MinimumSize = New System.Drawing.Size(820, 580)
        Me.Name = "frmLesson5_DataHandling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Variables, Constants & Data Handling"
        Me.rootLayout.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.headerLayout.ResumeLayout(False)
        Me.headerLayout.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabDataTypes.ResumeLayout(False)
        Me.dataLayout.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.conversionLayout.ResumeLayout(False)
        Me.conversionLayout.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tabScope.ResumeLayout(False)
        Me.scopeLayout.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.counterLayout.ResumeLayout(False)
        Me.counterLayout.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.tabOperators.ResumeLayout(False)
        Me.operatorLayout.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.expressionLayout.ResumeLayout(False)
        Me.expressionLayout.PerformLayout()
        Me.expressionOutputPanel.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabDataTypes As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRawInput As System.Windows.Forms.TextBox
    Friend WithEvents txtConversionOutput As System.Windows.Forms.TextBox
    Friend WithEvents btnConvertType As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tabScope As System.Windows.Forms.TabPage
    Friend WithEvents tabOperators As System.Windows.Forms.TabPage
    Friend WithEvents cboTargetType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTypeTheory As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClassVar As System.Windows.Forms.Button
    Friend WithEvents btnStaticVar As System.Windows.Forms.Button
    Friend WithEvents btnLocalVar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblStaticCount As System.Windows.Forms.Label
    Friend WithEvents lblClassCount As System.Windows.Forms.Label
    Friend WithEvents lblLocalCount As System.Windows.Forms.Label
    Friend WithEvents btnResetCounters As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtScopeTheory As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOperandA As System.Windows.Forms.TextBox
    Friend WithEvents txtOperandB As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboOperator As System.Windows.Forms.ComboBox
    Friend WithEvents lblExpressionResult As System.Windows.Forms.Label
    Friend WithEvents btnCalculateExpression As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOperatorTheory As System.Windows.Forms.TextBox
    Friend WithEvents rootLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents headerLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblHeaderTitle As System.Windows.Forms.Label
    Friend WithEvents lblHeaderSubtitle As System.Windows.Forms.Label
    Friend WithEvents dataLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents conversionLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents scopeLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents counterLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents operatorLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents expressionLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents expressionOutputPanel As System.Windows.Forms.Panel
End Class
