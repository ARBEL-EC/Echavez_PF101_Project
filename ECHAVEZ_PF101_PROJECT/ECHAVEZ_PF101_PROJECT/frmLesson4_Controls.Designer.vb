<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLesson4_Controls
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
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.rootLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.headerLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.lblHeaderSubtitle = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabFormProperties = New System.Windows.Forms.TabPage()
        Me.propertiesLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.propertyLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbOpacity = New System.Windows.Forms.TrackBar()
        Me.lblOpacityVal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboBorderStyle = New System.Windows.Forms.ComboBox()
        Me.chkTopMost = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtLayoutTheory = New System.Windows.Forms.TextBox()
        Me.tabBasicControls = New System.Windows.Forms.TabPage()
        Me.basicLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.suiteLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.chkEnable = New System.Windows.Forms.CheckBox()
        Me.rbSpeedNormal = New System.Windows.Forms.RadioButton()
        Me.rbSpeedFast = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpTarget = New System.Windows.Forms.DateTimePicker()
        Me.btnProgressStep = New System.Windows.Forms.Button()
        Me.progressLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.prgBar = New System.Windows.Forms.ProgressBar()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dialogLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.dialogActions = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnColorDialog = New System.Windows.Forms.Button()
        Me.btnFontDialog = New System.Windows.Forms.Button()
        Me.btnConfirmDialog = New System.Windows.Forms.Button()
        Me.lblDialogPreview = New System.Windows.Forms.Label()
        Me.lblDialogResultOutput = New System.Windows.Forms.Label()
        Me.tabRuntimeEvents = New System.Windows.Forms.TabPage()
        Me.runtimeLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.runtimeActions = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnCreateDynamic = New System.Windows.Forms.Button()
        Me.btnClearDynamic = New System.Windows.Forms.Button()
        Me.pnlDynamic = New System.Windows.Forms.FlowLayoutPanel()
        Me.rootLayout.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.headerLayout.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabFormProperties.SuspendLayout()
        Me.propertiesLayout.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.propertyLayout.SuspendLayout()
        CType(Me.tbOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.tabBasicControls.SuspendLayout()
        Me.basicLayout.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.suiteLayout.SuspendLayout()
        Me.progressLayout.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.dialogLayout.SuspendLayout()
        Me.dialogActions.SuspendLayout()
        Me.tabRuntimeEvents.SuspendLayout()
        Me.runtimeLayout.SuspendLayout()
        Me.runtimeActions.SuspendLayout()
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
        Me.lblHeaderTitle.Size = New System.Drawing.Size(283, 31)
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "Windows Forms Controls"
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
        Me.lblHeaderSubtitle.Size = New System.Drawing.Size(477, 17)
        Me.lblHeaderSubtitle.TabIndex = 1
        Me.lblHeaderSubtitle.Text = "Explore form properties, common controls, dialogs, and runtime event handling."
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabFormProperties)
        Me.TabControl1.Controls.Add(Me.tabBasicControls)
        Me.TabControl1.Controls.Add(Me.tabRuntimeEvents)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.TabControl1.Location = New System.Drawing.Point(19, 111)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1002, 570)
        Me.TabControl1.TabIndex = 1
        '
        'tabFormProperties
        '
        Me.tabFormProperties.Controls.Add(Me.propertiesLayout)
        Me.tabFormProperties.Location = New System.Drawing.Point(4, 26)
        Me.tabFormProperties.Name = "tabFormProperties"
        Me.tabFormProperties.Padding = New System.Windows.Forms.Padding(8)
        Me.tabFormProperties.Size = New System.Drawing.Size(994, 540)
        Me.tabFormProperties.TabIndex = 0
        Me.tabFormProperties.Text = "Form Features & Layout"
        Me.tabFormProperties.UseVisualStyleBackColor = True
        '
        'propertiesLayout
        '
        Me.propertiesLayout.ColumnCount = 2
        Me.propertiesLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.0!))
        Me.propertiesLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.0!))
        Me.propertiesLayout.Controls.Add(Me.GroupBox1, 0, 0)
        Me.propertiesLayout.Controls.Add(Me.GroupBox2, 1, 0)
        Me.propertiesLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.propertiesLayout.Location = New System.Drawing.Point(8, 8)
        Me.propertiesLayout.Name = "propertiesLayout"
        Me.propertiesLayout.Padding = New System.Windows.Forms.Padding(4)
        Me.propertiesLayout.RowCount = 1
        Me.propertiesLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.propertiesLayout.Size = New System.Drawing.Size(978, 524)
        Me.propertiesLayout.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.propertyLayout)
        Me.GroupBox1.Controls.Add(Me.chkTopMost)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(12, 12, 12, 52)
        Me.GroupBox1.Size = New System.Drawing.Size(395, 504)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Live Form Property Controller"
        '
        'propertyLayout
        '
        Me.propertyLayout.ColumnCount = 1
        Me.propertyLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.propertyLayout.Controls.Add(Me.Label1, 0, 0)
        Me.propertyLayout.Controls.Add(Me.tbOpacity, 0, 1)
        Me.propertyLayout.Controls.Add(Me.lblOpacityVal, 0, 2)
        Me.propertyLayout.Controls.Add(Me.Label2, 0, 3)
        Me.propertyLayout.Controls.Add(Me.cboBorderStyle, 0, 4)
        Me.propertyLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.propertyLayout.Location = New System.Drawing.Point(12, 29)
        Me.propertyLayout.Name = "propertyLayout"
        Me.propertyLayout.Padding = New System.Windows.Forms.Padding(6)
        Me.propertyLayout.RowCount = 5
        Me.propertyLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.propertyLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.propertyLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.propertyLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.propertyLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.propertyLayout.Size = New System.Drawing.Size(371, 402)
        Me.propertyLayout.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Window Opacity (Alpha):"
        '
        'tbOpacity
        '
        Me.tbOpacity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbOpacity.Location = New System.Drawing.Point(9, 43)
        Me.tbOpacity.Maximum = 100
        Me.tbOpacity.Minimum = 20
        Me.tbOpacity.Name = "tbOpacity"
        Me.tbOpacity.Size = New System.Drawing.Size(353, 58)
        Me.tbOpacity.TabIndex = 1
        Me.tbOpacity.TickFrequency = 10
        Me.tbOpacity.Value = 100
        '
        'lblOpacityVal
        '
        Me.lblOpacityVal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblOpacityVal.AutoSize = True
        Me.lblOpacityVal.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblOpacityVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblOpacityVal.Location = New System.Drawing.Point(12, 113)
        Me.lblOpacityVal.Margin = New System.Windows.Forms.Padding(6)
        Me.lblOpacityVal.Name = "lblOpacityVal"
        Me.lblOpacityVal.Size = New System.Drawing.Size(138, 17)
        Me.lblOpacityVal.TabIndex = 2
        Me.lblOpacityVal.Text = "Current Opacity: 100%"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 148)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Form Border Style:"
        '
        'cboBorderStyle
        '
        Me.cboBorderStyle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboBorderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.cboBorderStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBorderStyle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cboBorderStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cboBorderStyle.FormattingEnabled = True
        Me.cboBorderStyle.Location = New System.Drawing.Point(12, 274)
        Me.cboBorderStyle.Margin = New System.Windows.Forms.Padding(6)
        Me.cboBorderStyle.Name = "cboBorderStyle"
        Me.cboBorderStyle.Size = New System.Drawing.Size(347, 25)
        Me.cboBorderStyle.TabIndex = 4
        '
        'chkTopMost
        '
        Me.chkTopMost.AutoSize = True
        Me.chkTopMost.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.chkTopMost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkTopMost.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.chkTopMost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.chkTopMost.Location = New System.Drawing.Point(12, 431)
        Me.chkTopMost.Margin = New System.Windows.Forms.Padding(8)
        Me.chkTopMost.Name = "chkTopMost"
        Me.chkTopMost.Size = New System.Drawing.Size(371, 21)
        Me.chkTopMost.TabIndex = 5
        Me.chkTopMost.Text = "TopMost (Keep form above all windows)"
        Me.chkTopMost.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.txtLayoutTheory)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(417, 10)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBox2.Size = New System.Drawing.Size(551, 504)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Anchor vs. Dock Mechanics"
        '
        'txtLayoutTheory
        '
        Me.txtLayoutTheory.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.txtLayoutTheory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLayoutTheory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLayoutTheory.Font = New System.Drawing.Font("Consolas", 9.5!)
        Me.txtLayoutTheory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtLayoutTheory.Location = New System.Drawing.Point(12, 29)
        Me.txtLayoutTheory.Margin = New System.Windows.Forms.Padding(6)
        Me.txtLayoutTheory.Multiline = True
        Me.txtLayoutTheory.Name = "txtLayoutTheory"
        Me.txtLayoutTheory.ReadOnly = True
        Me.txtLayoutTheory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLayoutTheory.Size = New System.Drawing.Size(527, 463)
        Me.txtLayoutTheory.TabIndex = 0
        '
        'tabBasicControls
        '
        Me.tabBasicControls.Controls.Add(Me.basicLayout)
        Me.tabBasicControls.Location = New System.Drawing.Point(4, 26)
        Me.tabBasicControls.Name = "tabBasicControls"
        Me.tabBasicControls.Padding = New System.Windows.Forms.Padding(8)
        Me.tabBasicControls.Size = New System.Drawing.Size(192, 70)
        Me.tabBasicControls.TabIndex = 1
        Me.tabBasicControls.Text = "Basic Controls & Dialogs"
        Me.tabBasicControls.UseVisualStyleBackColor = True
        '
        'basicLayout
        '
        Me.basicLayout.ColumnCount = 2
        Me.basicLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.basicLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.basicLayout.Controls.Add(Me.GroupBox3, 0, 0)
        Me.basicLayout.Controls.Add(Me.GroupBox4, 1, 0)
        Me.basicLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.basicLayout.Location = New System.Drawing.Point(8, 8)
        Me.basicLayout.Name = "basicLayout"
        Me.basicLayout.Padding = New System.Windows.Forms.Padding(4)
        Me.basicLayout.RowCount = 1
        Me.basicLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.basicLayout.Size = New System.Drawing.Size(176, 54)
        Me.basicLayout.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.suiteLayout)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBox3.Size = New System.Drawing.Size(72, 34)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Control Suite Simulator"
        '
        'suiteLayout
        '
        Me.suiteLayout.ColumnCount = 1
        Me.suiteLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.suiteLayout.Controls.Add(Me.chkEnable, 0, 0)
        Me.suiteLayout.Controls.Add(Me.rbSpeedNormal, 0, 1)
        Me.suiteLayout.Controls.Add(Me.rbSpeedFast, 0, 2)
        Me.suiteLayout.Controls.Add(Me.Label3, 0, 3)
        Me.suiteLayout.Controls.Add(Me.dtpTarget, 0, 4)
        Me.suiteLayout.Controls.Add(Me.btnProgressStep, 0, 5)
        Me.suiteLayout.Controls.Add(Me.progressLayout, 0, 6)
        Me.suiteLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.suiteLayout.Location = New System.Drawing.Point(12, 29)
        Me.suiteLayout.Name = "suiteLayout"
        Me.suiteLayout.Padding = New System.Windows.Forms.Padding(6)
        Me.suiteLayout.RowCount = 8
        Me.suiteLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.suiteLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.suiteLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.suiteLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.suiteLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.suiteLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.suiteLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.suiteLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.suiteLayout.Size = New System.Drawing.Size(48, 0)
        Me.suiteLayout.TabIndex = 0
        '
        'chkEnable
        '
        Me.chkEnable.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkEnable.AutoSize = True
        Me.chkEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkEnable.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.chkEnable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.chkEnable.Location = New System.Drawing.Point(12, 13)
        Me.chkEnable.Margin = New System.Windows.Forms.Padding(6)
        Me.chkEnable.Name = "chkEnable"
        Me.chkEnable.Size = New System.Drawing.Size(24, 21)
        Me.chkEnable.TabIndex = 0
        Me.chkEnable.Text = "Enable Progress Simulator"
        Me.chkEnable.UseVisualStyleBackColor = True
        '
        'rbSpeedNormal
        '
        Me.rbSpeedNormal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rbSpeedNormal.AutoSize = True
        Me.rbSpeedNormal.Checked = True
        Me.rbSpeedNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbSpeedNormal.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.rbSpeedNormal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.rbSpeedNormal.Location = New System.Drawing.Point(12, 48)
        Me.rbSpeedNormal.Margin = New System.Windows.Forms.Padding(6)
        Me.rbSpeedNormal.MinimumSize = New System.Drawing.Size(260, 28)
        Me.rbSpeedNormal.Name = "rbSpeedNormal"
        Me.rbSpeedNormal.Padding = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.rbSpeedNormal.Size = New System.Drawing.Size(260, 28)
        Me.rbSpeedNormal.TabIndex = 1
        Me.rbSpeedNormal.TabStop = True
        Me.rbSpeedNormal.Text = "Normal Speed (Step +10)"
        Me.rbSpeedNormal.UseVisualStyleBackColor = True
        '
        'rbSpeedFast
        '
        Me.rbSpeedFast.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rbSpeedFast.AutoSize = True
        Me.rbSpeedFast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbSpeedFast.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.rbSpeedFast.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.rbSpeedFast.Location = New System.Drawing.Point(12, 80)
        Me.rbSpeedFast.Margin = New System.Windows.Forms.Padding(6)
        Me.rbSpeedFast.MinimumSize = New System.Drawing.Size(260, 28)
        Me.rbSpeedFast.Name = "rbSpeedFast"
        Me.rbSpeedFast.Padding = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.rbSpeedFast.Size = New System.Drawing.Size(260, 28)
        Me.rbSpeedFast.TabIndex = 2
        Me.rbSpeedFast.Text = "Turbo Speed (Step +25)"
        Me.rbSpeedFast.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 112)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Event Target Date:"
        '
        'dtpTarget
        '
        Me.dtpTarget.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpTarget.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTarget.Location = New System.Drawing.Point(12, 147)
        Me.dtpTarget.Margin = New System.Windows.Forms.Padding(6)
        Me.dtpTarget.Name = "dtpTarget"
        Me.dtpTarget.Size = New System.Drawing.Size(24, 24)
        Me.dtpTarget.TabIndex = 4
        '
        'btnProgressStep
        '
        Me.btnProgressStep.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProgressStep.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnProgressStep.FlatAppearance.BorderSize = 0
        Me.btnProgressStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProgressStep.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnProgressStep.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnProgressStep.Location = New System.Drawing.Point(12, 189)
        Me.btnProgressStep.Margin = New System.Windows.Forms.Padding(6)
        Me.btnProgressStep.Name = "btnProgressStep"
        Me.btnProgressStep.Size = New System.Drawing.Size(24, 36)
        Me.btnProgressStep.TabIndex = 5
        Me.btnProgressStep.Text = "Increment Progress Bar"
        Me.btnProgressStep.UseVisualStyleBackColor = False
        '
        'progressLayout
        '
        Me.progressLayout.ColumnCount = 2
        Me.progressLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.progressLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.progressLayout.Controls.Add(Me.lblProgress, 0, 0)
        Me.progressLayout.Controls.Add(Me.prgBar, 1, 0)
        Me.progressLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.progressLayout.Location = New System.Drawing.Point(6, 234)
        Me.progressLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.progressLayout.Name = "progressLayout"
        Me.progressLayout.RowCount = 1
        Me.progressLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.progressLayout.Size = New System.Drawing.Size(36, 44)
        Me.progressLayout.TabIndex = 8
        '
        'lblProgress
        '
        Me.lblProgress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProgress.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblProgress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblProgress.Location = New System.Drawing.Point(6, 6)
        Me.lblProgress.Margin = New System.Windows.Forms.Padding(6, 6, 2, 6)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(8, 32)
        Me.lblProgress.TabIndex = 7
        Me.lblProgress.Text = "Progress: 0%"
        '
        'prgBar
        '
        Me.prgBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.prgBar.Location = New System.Drawing.Point(20, 6)
        Me.prgBar.Margin = New System.Windows.Forms.Padding(4, 6, 6, 6)
        Me.prgBar.Name = "prgBar"
        Me.prgBar.Size = New System.Drawing.Size(10, 32)
        Me.prgBar.TabIndex = 6
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.dialogLayout)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(94, 10)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBox4.Size = New System.Drawing.Size(72, 34)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dialog Boxes Testbench"
        '
        'dialogLayout
        '
        Me.dialogLayout.ColumnCount = 1
        Me.dialogLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.dialogLayout.Controls.Add(Me.dialogActions, 0, 0)
        Me.dialogLayout.Controls.Add(Me.lblDialogPreview, 0, 1)
        Me.dialogLayout.Controls.Add(Me.lblDialogResultOutput, 0, 2)
        Me.dialogLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dialogLayout.Location = New System.Drawing.Point(12, 29)
        Me.dialogLayout.Name = "dialogLayout"
        Me.dialogLayout.Padding = New System.Windows.Forms.Padding(6)
        Me.dialogLayout.RowCount = 3
        Me.dialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.dialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.dialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.dialogLayout.Size = New System.Drawing.Size(48, 0)
        Me.dialogLayout.TabIndex = 0
        '
        'dialogActions
        '
        Me.dialogActions.Controls.Add(Me.btnColorDialog)
        Me.dialogActions.Controls.Add(Me.btnFontDialog)
        Me.dialogActions.Controls.Add(Me.btnConfirmDialog)
        Me.dialogActions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dialogActions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.dialogActions.Location = New System.Drawing.Point(6, 6)
        Me.dialogActions.Margin = New System.Windows.Forms.Padding(0)
        Me.dialogActions.Name = "dialogActions"
        Me.dialogActions.Padding = New System.Windows.Forms.Padding(2)
        Me.dialogActions.Size = New System.Drawing.Size(36, 160)
        Me.dialogActions.TabIndex = 0
        Me.dialogActions.WrapContents = False
        '
        'btnColorDialog
        '
        Me.btnColorDialog.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnColorDialog.FlatAppearance.BorderSize = 0
        Me.btnColorDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnColorDialog.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnColorDialog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnColorDialog.Location = New System.Drawing.Point(6, 6)
        Me.btnColorDialog.Margin = New System.Windows.Forms.Padding(4)
        Me.btnColorDialog.Name = "btnColorDialog"
        Me.btnColorDialog.Size = New System.Drawing.Size(310, 36)
        Me.btnColorDialog.TabIndex = 0
        Me.btnColorDialog.Text = "Choose Accent Color (ColorDialog)"
        Me.btnColorDialog.UseVisualStyleBackColor = False
        '
        'btnFontDialog
        '
        Me.btnFontDialog.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnFontDialog.FlatAppearance.BorderSize = 0
        Me.btnFontDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFontDialog.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnFontDialog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnFontDialog.Location = New System.Drawing.Point(6, 50)
        Me.btnFontDialog.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFontDialog.Name = "btnFontDialog"
        Me.btnFontDialog.Size = New System.Drawing.Size(310, 36)
        Me.btnFontDialog.TabIndex = 1
        Me.btnFontDialog.Text = "Select Banner Font (FontDialog)"
        Me.btnFontDialog.UseVisualStyleBackColor = False
        '
        'btnConfirmDialog
        '
        Me.btnConfirmDialog.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnConfirmDialog.FlatAppearance.BorderSize = 0
        Me.btnConfirmDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmDialog.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnConfirmDialog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnConfirmDialog.Location = New System.Drawing.Point(6, 94)
        Me.btnConfirmDialog.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfirmDialog.Name = "btnConfirmDialog"
        Me.btnConfirmDialog.Size = New System.Drawing.Size(310, 36)
        Me.btnConfirmDialog.TabIndex = 2
        Me.btnConfirmDialog.Text = "Reset Styles (DialogResult Demo)"
        Me.btnConfirmDialog.UseVisualStyleBackColor = False
        '
        'lblDialogPreview
        '
        Me.lblDialogPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblDialogPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDialogPreview.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblDialogPreview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblDialogPreview.Location = New System.Drawing.Point(12, 172)
        Me.lblDialogPreview.Margin = New System.Windows.Forms.Padding(6)
        Me.lblDialogPreview.Name = "lblDialogPreview"
        Me.lblDialogPreview.Size = New System.Drawing.Size(24, 1)
        Me.lblDialogPreview.TabIndex = 3
        Me.lblDialogPreview.Text = "Sample Preview Text"
        Me.lblDialogPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDialogResultOutput
        '
        Me.lblDialogResultOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDialogResultOutput.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblDialogResultOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblDialogResultOutput.Location = New System.Drawing.Point(12, -23)
        Me.lblDialogResultOutput.Margin = New System.Windows.Forms.Padding(6)
        Me.lblDialogResultOutput.Name = "lblDialogResultOutput"
        Me.lblDialogResultOutput.Size = New System.Drawing.Size(24, 24)
        Me.lblDialogResultOutput.TabIndex = 4
        Me.lblDialogResultOutput.Text = "DialogResult: Ready"
        Me.lblDialogResultOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tabRuntimeEvents
        '
        Me.tabRuntimeEvents.Controls.Add(Me.runtimeLayout)
        Me.tabRuntimeEvents.Location = New System.Drawing.Point(4, 26)
        Me.tabRuntimeEvents.Name = "tabRuntimeEvents"
        Me.tabRuntimeEvents.Padding = New System.Windows.Forms.Padding(8)
        Me.tabRuntimeEvents.Size = New System.Drawing.Size(192, 70)
        Me.tabRuntimeEvents.TabIndex = 2
        Me.tabRuntimeEvents.Text = "Runtime Event Handlers"
        Me.tabRuntimeEvents.UseVisualStyleBackColor = True
        '
        'runtimeLayout
        '
        Me.runtimeLayout.ColumnCount = 1
        Me.runtimeLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.runtimeLayout.Controls.Add(Me.Label5, 0, 0)
        Me.runtimeLayout.Controls.Add(Me.runtimeActions, 0, 1)
        Me.runtimeLayout.Controls.Add(Me.pnlDynamic, 0, 2)
        Me.runtimeLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.runtimeLayout.Location = New System.Drawing.Point(8, 8)
        Me.runtimeLayout.Name = "runtimeLayout"
        Me.runtimeLayout.Padding = New System.Windows.Forms.Padding(6)
        Me.runtimeLayout.RowCount = 3
        Me.runtimeLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.runtimeLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.runtimeLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.runtimeLayout.Size = New System.Drawing.Size(176, 54)
        Me.runtimeLayout.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 12)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Dynamically created controls - AddHandler event wiring"
        '
        'runtimeActions
        '
        Me.runtimeActions.Controls.Add(Me.btnCreateDynamic)
        Me.runtimeActions.Controls.Add(Me.btnClearDynamic)
        Me.runtimeActions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.runtimeActions.Location = New System.Drawing.Point(6, 42)
        Me.runtimeActions.Margin = New System.Windows.Forms.Padding(0)
        Me.runtimeActions.Name = "runtimeActions"
        Me.runtimeActions.Padding = New System.Windows.Forms.Padding(2)
        Me.runtimeActions.Size = New System.Drawing.Size(164, 54)
        Me.runtimeActions.TabIndex = 1
        '
        'btnCreateDynamic
        '
        Me.btnCreateDynamic.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnCreateDynamic.FlatAppearance.BorderSize = 0
        Me.btnCreateDynamic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateDynamic.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnCreateDynamic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnCreateDynamic.Location = New System.Drawing.Point(6, 6)
        Me.btnCreateDynamic.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreateDynamic.Name = "btnCreateDynamic"
        Me.btnCreateDynamic.Size = New System.Drawing.Size(260, 36)
        Me.btnCreateDynamic.TabIndex = 2
        Me.btnCreateDynamic.Text = "Generate Dynamic Button at Runtime"
        Me.btnCreateDynamic.UseVisualStyleBackColor = False
        '
        'btnClearDynamic
        '
        Me.btnClearDynamic.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnClearDynamic.FlatAppearance.BorderSize = 0
        Me.btnClearDynamic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearDynamic.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnClearDynamic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnClearDynamic.Location = New System.Drawing.Point(6, 50)
        Me.btnClearDynamic.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClearDynamic.Name = "btnClearDynamic"
        Me.btnClearDynamic.Size = New System.Drawing.Size(200, 36)
        Me.btnClearDynamic.TabIndex = 3
        Me.btnClearDynamic.Text = "Clear Dynamic Controls"
        Me.btnClearDynamic.UseVisualStyleBackColor = False
        '
        'pnlDynamic
        '
        Me.pnlDynamic.AutoScroll = True
        Me.pnlDynamic.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.pnlDynamic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDynamic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDynamic.Location = New System.Drawing.Point(12, 102)
        Me.pnlDynamic.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlDynamic.Name = "pnlDynamic"
        Me.pnlDynamic.Padding = New System.Windows.Forms.Padding(8)
        Me.pnlDynamic.Size = New System.Drawing.Size(152, 1)
        Me.pnlDynamic.TabIndex = 2
        '
        'frmLesson4_Controls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1040, 700)
        Me.Controls.Add(Me.rootLayout)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.MinimumSize = New System.Drawing.Size(820, 580)
        Me.Name = "frmLesson4_Controls"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planning Applications & Designing Interfaces"
        Me.rootLayout.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.headerLayout.ResumeLayout(False)
        Me.headerLayout.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabFormProperties.ResumeLayout(False)
        Me.propertiesLayout.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.propertyLayout.ResumeLayout(False)
        Me.propertyLayout.PerformLayout()
        CType(Me.tbOpacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tabBasicControls.ResumeLayout(False)
        Me.basicLayout.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.suiteLayout.ResumeLayout(False)
        Me.suiteLayout.PerformLayout()
        Me.progressLayout.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.dialogLayout.ResumeLayout(False)
        Me.dialogActions.ResumeLayout(False)
        Me.tabRuntimeEvents.ResumeLayout(False)
        Me.runtimeLayout.ResumeLayout(False)
        Me.runtimeLayout.PerformLayout()
        Me.runtimeActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabFormProperties As System.Windows.Forms.TabPage
    Friend WithEvents tabBasicControls As System.Windows.Forms.TabPage
    Friend WithEvents tabRuntimeEvents As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblOpacityVal As System.Windows.Forms.Label
    Friend WithEvents tbOpacity As System.Windows.Forms.TrackBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboBorderStyle As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkTopMost As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLayoutTheory As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpTarget As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbSpeedFast As System.Windows.Forms.RadioButton
    Friend WithEvents rbSpeedNormal As System.Windows.Forms.RadioButton
    Friend WithEvents chkEnable As System.Windows.Forms.CheckBox
    Friend WithEvents prgBar As System.Windows.Forms.ProgressBar
    Friend WithEvents btnProgressStep As System.Windows.Forms.Button
    Friend WithEvents lblProgress As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnConfirmDialog As System.Windows.Forms.Button
    Friend WithEvents btnFontDialog As System.Windows.Forms.Button
    Friend WithEvents btnColorDialog As System.Windows.Forms.Button
    Friend WithEvents lblDialogPreview As System.Windows.Forms.Label
    Friend WithEvents lblDialogResultOutput As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pnlDynamic As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnClearDynamic As System.Windows.Forms.Button
    Friend WithEvents btnCreateDynamic As System.Windows.Forms.Button
    Friend WithEvents rootLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents headerLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblHeaderTitle As System.Windows.Forms.Label
    Friend WithEvents lblHeaderSubtitle As System.Windows.Forms.Label
    Friend WithEvents propertiesLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents propertyLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents basicLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents suiteLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents progressLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dialogLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dialogActions As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents runtimeLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents runtimeActions As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
End Class
