<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLesson7_Arrays
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

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

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rootLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.headerLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.lblHeaderSubtitle = New System.Windows.Forms.Label()
        Me.tabsArrays = New System.Windows.Forms.TabControl()
        Me.tabLessonNotes = New System.Windows.Forms.TabPage()
        Me.txtLessonNotes = New System.Windows.Forms.RichTextBox()
        Me.tabMonths = New System.Windows.Forms.TabPage()
        Me.monthsLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.lstMonths = New System.Windows.Forms.ListBox()
        Me.monthActions = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnLoadMonths = New System.Windows.Forms.Button()
        Me.btnClearMonthDisplay = New System.Windows.Forms.Button()
        Me.lblMonthSelection = New System.Windows.Forms.Label()
        Me.tabArrayAnalysis = New System.Windows.Forms.TabPage()
        Me.analysisLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.analysisInputs = New System.Windows.Forms.TableLayoutPanel()
        Me.lblScoresInput = New System.Windows.Forms.Label()
        Me.txtScoresInput = New System.Windows.Forms.TextBox()
        Me.lblSearchScore = New System.Windows.Forms.Label()
        Me.txtSearchScore = New System.Windows.Forms.TextBox()
        Me.analysisActions = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnCalculateScores = New System.Windows.Forms.Button()
        Me.btnFindScore = New System.Windows.Forms.Button()
        Me.txtScoreResults = New System.Windows.Forms.TextBox()
        Me.tabMatrix = New System.Windows.Forms.TabPage()
        Me.matrixLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.matrixGrid = New System.Windows.Forms.DataGridView()
        Me.matrixActions = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnCalculateMatrixTotals = New System.Windows.Forms.Button()
        Me.btnResetMatrix = New System.Windows.Forms.Button()
        Me.txtMatrixResults = New System.Windows.Forms.TextBox()
        Me.tabPptReference = New System.Windows.Forms.TabPage()
        Me.pptLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.lstPptTopics = New System.Windows.Forms.ListBox()
        Me.txtPptTranscript = New System.Windows.Forms.RichTextBox()
        Me.rootLayout.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.headerLayout.SuspendLayout()
        Me.tabsArrays.SuspendLayout()
        Me.tabLessonNotes.SuspendLayout()
        Me.tabMonths.SuspendLayout()
        Me.monthsLayout.SuspendLayout()
        Me.monthActions.SuspendLayout()
        Me.tabArrayAnalysis.SuspendLayout()
        Me.analysisLayout.SuspendLayout()
        Me.analysisInputs.SuspendLayout()
        Me.analysisActions.SuspendLayout()
        Me.tabMatrix.SuspendLayout()
        Me.matrixLayout.SuspendLayout()
        CType(Me.matrixGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.matrixActions.SuspendLayout()
        Me.tabPptReference.SuspendLayout()
        Me.pptLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'rootLayout
        '
        Me.rootLayout.ColumnCount = 1
        Me.rootLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.rootLayout.Controls.Add(Me.pnlHeader, 0, 0)
        Me.rootLayout.Controls.Add(Me.tabsArrays, 0, 1)
        Me.rootLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rootLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.rootLayout.Padding = New System.Windows.Forms.Padding(12)
        Me.rootLayout.RowCount = 2
        Me.rootLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.rootLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.rootLayout.Name = "rootLayout"
        Me.rootLayout.TabIndex = 0
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.headerLayout)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.TabIndex = 0
        '
        'headerLayout
        '
        Me.headerLayout.ColumnCount = 1
        Me.headerLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.headerLayout.Controls.Add(Me.lblHeaderTitle, 0, 0)
        Me.headerLayout.Controls.Add(Me.lblHeaderSubtitle, 0, 1)
        Me.headerLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.headerLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.headerLayout.RowCount = 2
        Me.headerLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.headerLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.headerLayout.Name = "headerLayout"
        Me.headerLayout.TabIndex = 0
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderTitle.Text = "WEEK 7  |  ARRAYS LAB"
        Me.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblHeaderTitle.Margin = New System.Windows.Forms.Padding(6)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.TabIndex = 0
        '
        'lblHeaderSubtitle
        '
        Me.lblHeaderSubtitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHeaderSubtitle.Text = "Explore zero-based indexes, one-dimensional analysis, and two-dimensional matrices."
        Me.lblHeaderSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblHeaderSubtitle.Margin = New System.Windows.Forms.Padding(6)
        Me.lblHeaderSubtitle.Name = "lblHeaderSubtitle"
        Me.lblHeaderSubtitle.TabIndex = 1
        '
        'tabsArrays
        '
        Me.tabsArrays.Controls.Add(Me.tabLessonNotes)
        Me.tabsArrays.Controls.Add(Me.tabMonths)
        Me.tabsArrays.Controls.Add(Me.tabArrayAnalysis)
        Me.tabsArrays.Controls.Add(Me.tabMatrix)
        Me.tabsArrays.Controls.Add(Me.tabPptReference)
        Me.tabsArrays.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabsArrays.Margin = New System.Windows.Forms.Padding(6)
        Me.tabsArrays.Name = "tabsArrays"
        Me.tabsArrays.SelectedIndex = 0
        Me.tabsArrays.TabIndex = 1
        '
        'tabLessonNotes
        '
        Me.tabLessonNotes.Controls.Add(Me.txtLessonNotes)
        Me.tabLessonNotes.Padding = New System.Windows.Forms.Padding(6)
        Me.tabLessonNotes.Text = "Lesson Notes"
        Me.tabLessonNotes.Name = "tabLessonNotes"
        Me.tabLessonNotes.UseVisualStyleBackColor = True
        '
        'txtLessonNotes
        '
        Me.txtLessonNotes.BackColor = System.Drawing.Color.FromArgb(18, 19, 22)
        Me.txtLessonNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLessonNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLessonNotes.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular)
        Me.txtLessonNotes.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.txtLessonNotes.Margin = New System.Windows.Forms.Padding(6)
        Me.txtLessonNotes.Name = "txtLessonNotes"
        Me.txtLessonNotes.ReadOnly = True
        Me.txtLessonNotes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtLessonNotes.TabIndex = 0
        Me.txtLessonNotes.Text = ""
        '
        'tabMonths
        '
        Me.tabMonths.Controls.Add(Me.monthsLayout)
        Me.tabMonths.Padding = New System.Windows.Forms.Padding(6)
        Me.tabMonths.Text = "Months Lab"
        Me.tabMonths.Name = "tabMonths"
        Me.tabMonths.UseVisualStyleBackColor = True
        '
        'monthsLayout
        '
        Me.monthsLayout.ColumnCount = 2
        Me.monthsLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.0!))
        Me.monthsLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.0!))
        Me.monthsLayout.Controls.Add(Me.lstMonths, 0, 0)
        Me.monthsLayout.Controls.Add(Me.monthActions, 0, 1)
        Me.monthsLayout.Controls.Add(Me.lblMonthSelection, 1, 0)
        Me.monthsLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.monthsLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.monthsLayout.Padding = New System.Windows.Forms.Padding(6)
        Me.monthsLayout.RowCount = 2
        Me.monthsLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.monthsLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.monthsLayout.Name = "monthsLayout"
        Me.monthsLayout.TabIndex = 0
        '
        'lstMonths
        '
        Me.lstMonths.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstMonths.FormattingEnabled = True
        Me.lstMonths.IntegralHeight = False
        Me.lstMonths.ItemHeight = 20
        Me.lstMonths.Margin = New System.Windows.Forms.Padding(6)
        Me.lstMonths.Name = "lstMonths"
        Me.lstMonths.TabIndex = 0
        '
        'monthActions
        '
        Me.monthActions.Controls.Add(Me.btnLoadMonths)
        Me.monthActions.Controls.Add(Me.btnClearMonthDisplay)
        Me.monthActions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.monthActions.Margin = New System.Windows.Forms.Padding(0)
        Me.monthActions.Padding = New System.Windows.Forms.Padding(0)
        Me.monthActions.WrapContents = False
        Me.monthActions.Name = "monthActions"
        Me.monthActions.TabIndex = 1
        '
        'btnLoadMonths
        '
        Me.btnLoadMonths.AutoSize = True
        Me.btnLoadMonths.MinimumSize = New System.Drawing.Size(112, 36)
        Me.btnLoadMonths.Height = 36
        Me.btnLoadMonths.Margin = New System.Windows.Forms.Padding(6)
        Me.btnLoadMonths.Text = "Load Months"
        Me.btnLoadMonths.UseVisualStyleBackColor = True
        Me.btnLoadMonths.Name = "btnLoadMonths"
        Me.btnLoadMonths.TabIndex = 0
        '
        'btnClearMonthDisplay
        '
        Me.btnClearMonthDisplay.AutoSize = True
        Me.btnClearMonthDisplay.MinimumSize = New System.Drawing.Size(126, 36)
        Me.btnClearMonthDisplay.Height = 36
        Me.btnClearMonthDisplay.Margin = New System.Windows.Forms.Padding(6)
        Me.btnClearMonthDisplay.Text = "Clear Display"
        Me.btnClearMonthDisplay.UseVisualStyleBackColor = True
        Me.btnClearMonthDisplay.Name = "btnClearMonthDisplay"
        Me.btnClearMonthDisplay.TabIndex = 1
        '
        'lblMonthSelection
        '
        Me.lblMonthSelection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMonthSelection.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular)
        Me.lblMonthSelection.Text = "Select a month to display its zero-based index."
        Me.lblMonthSelection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMonthSelection.Margin = New System.Windows.Forms.Padding(12)
        Me.lblMonthSelection.Name = "lblMonthSelection"
        Me.lblMonthSelection.TabIndex = 2
        '
        'tabArrayAnalysis
        '
        Me.tabArrayAnalysis.Controls.Add(Me.analysisLayout)
        Me.tabArrayAnalysis.Padding = New System.Windows.Forms.Padding(6)
        Me.tabArrayAnalysis.Text = "1D Array Analysis"
        Me.tabArrayAnalysis.Name = "tabArrayAnalysis"
        Me.tabArrayAnalysis.UseVisualStyleBackColor = True
        '
        'analysisLayout
        '
        Me.analysisLayout.ColumnCount = 1
        Me.analysisLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.analysisLayout.Controls.Add(Me.analysisInputs, 0, 0)
        Me.analysisLayout.Controls.Add(Me.analysisActions, 0, 1)
        Me.analysisLayout.Controls.Add(Me.txtScoreResults, 0, 2)
        Me.analysisLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.analysisLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.analysisLayout.Padding = New System.Windows.Forms.Padding(6)
        Me.analysisLayout.RowCount = 3
        Me.analysisLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.analysisLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.analysisLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.analysisLayout.Name = "analysisLayout"
        Me.analysisLayout.TabIndex = 0
        '
        'analysisInputs
        '
        Me.analysisInputs.ColumnCount = 4
        Me.analysisInputs.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.analysisInputs.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.0!))
        Me.analysisInputs.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.analysisInputs.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.analysisInputs.Controls.Add(Me.lblScoresInput, 0, 0)
        Me.analysisInputs.Controls.Add(Me.txtScoresInput, 1, 0)
        Me.analysisInputs.Controls.Add(Me.lblSearchScore, 2, 0)
        Me.analysisInputs.Controls.Add(Me.txtSearchScore, 3, 0)
        Me.analysisInputs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.analysisInputs.Margin = New System.Windows.Forms.Padding(0)
        Me.analysisInputs.Name = "analysisInputs"
        Me.analysisInputs.RowCount = 1
        Me.analysisInputs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.analysisInputs.TabIndex = 0
        '
        'lblScoresInput
        '
        Me.lblScoresInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblScoresInput.Text = "Scores"
        Me.lblScoresInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblScoresInput.Margin = New System.Windows.Forms.Padding(6)
        Me.lblScoresInput.Name = "lblScoresInput"
        Me.lblScoresInput.TabIndex = 0
        '
        'txtScoresInput
        '
        Me.txtScoresInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtScoresInput.Margin = New System.Windows.Forms.Padding(6)
        Me.txtScoresInput.Name = "txtScoresInput"
        Me.txtScoresInput.TabIndex = 1
        '
        'lblSearchScore
        '
        Me.lblSearchScore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSearchScore.Text = "Find score"
        Me.lblSearchScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSearchScore.Margin = New System.Windows.Forms.Padding(6)
        Me.lblSearchScore.Name = "lblSearchScore"
        Me.lblSearchScore.TabIndex = 2
        '
        'txtSearchScore
        '
        Me.txtSearchScore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearchScore.Margin = New System.Windows.Forms.Padding(6)
        Me.txtSearchScore.Name = "txtSearchScore"
        Me.txtSearchScore.TabIndex = 3
        '
        'analysisActions
        '
        Me.analysisActions.Controls.Add(Me.btnCalculateScores)
        Me.analysisActions.Controls.Add(Me.btnFindScore)
        Me.analysisActions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.analysisActions.Margin = New System.Windows.Forms.Padding(0)
        Me.analysisActions.WrapContents = False
        Me.analysisActions.Name = "analysisActions"
        Me.analysisActions.TabIndex = 1
        '
        'btnCalculateScores
        '
        Me.btnCalculateScores.AutoSize = True
        Me.btnCalculateScores.MinimumSize = New System.Drawing.Size(170, 36)
        Me.btnCalculateScores.Height = 36
        Me.btnCalculateScores.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCalculateScores.Text = "Calculate Total & Average"
        Me.btnCalculateScores.UseVisualStyleBackColor = True
        Me.btnCalculateScores.Name = "btnCalculateScores"
        Me.btnCalculateScores.TabIndex = 0
        '
        'btnFindScore
        '
        Me.btnFindScore.AutoSize = True
        Me.btnFindScore.MinimumSize = New System.Drawing.Size(112, 36)
        Me.btnFindScore.Height = 36
        Me.btnFindScore.Margin = New System.Windows.Forms.Padding(6)
        Me.btnFindScore.Text = "Find Score"
        Me.btnFindScore.UseVisualStyleBackColor = True
        Me.btnFindScore.Name = "btnFindScore"
        Me.btnFindScore.TabIndex = 1
        '
        'txtScoreResults
        '
        Me.txtScoreResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtScoreResults.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Regular)
        Me.txtScoreResults.Margin = New System.Windows.Forms.Padding(6)
        Me.txtScoreResults.Multiline = True
        Me.txtScoreResults.ReadOnly = True
        Me.txtScoreResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtScoreResults.Name = "txtScoreResults"
        Me.txtScoreResults.TabIndex = 2
        '
        'tabMatrix
        '
        Me.tabMatrix.Controls.Add(Me.matrixLayout)
        Me.tabMatrix.Padding = New System.Windows.Forms.Padding(6)
        Me.tabMatrix.Text = "2D Matrix Grid"
        Me.tabMatrix.Name = "tabMatrix"
        Me.tabMatrix.UseVisualStyleBackColor = True
        '
        'matrixLayout
        '
        Me.matrixLayout.ColumnCount = 1
        Me.matrixLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.matrixLayout.Controls.Add(Me.matrixGrid, 0, 0)
        Me.matrixLayout.Controls.Add(Me.matrixActions, 0, 1)
        Me.matrixLayout.Controls.Add(Me.txtMatrixResults, 0, 2)
        Me.matrixLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.matrixLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.matrixLayout.Padding = New System.Windows.Forms.Padding(6)
        Me.matrixLayout.RowCount = 3
        Me.matrixLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.matrixLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.matrixLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.matrixLayout.Name = "matrixLayout"
        Me.matrixLayout.TabIndex = 0
        '
        'matrixGrid
        '
        Me.matrixGrid.AllowUserToAddRows = False
        Me.matrixGrid.AllowUserToDeleteRows = False
        Me.matrixGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.matrixGrid.Columns.Add("Column0", "Column 0")
        Me.matrixGrid.Columns.Add("Column1", "Column 1")
        Me.matrixGrid.Columns.Add("Column2", "Column 2")
        Me.matrixGrid.Columns.Add("Column3", "Column 3")
        Me.matrixGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.matrixGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.matrixGrid.Margin = New System.Windows.Forms.Padding(6)
        Me.matrixGrid.Name = "matrixGrid"
        Me.matrixGrid.RowHeadersWidth = 90
        Me.matrixGrid.TabIndex = 0
        '
        'matrixActions
        '
        Me.matrixActions.Controls.Add(Me.btnCalculateMatrixTotals)
        Me.matrixActions.Controls.Add(Me.btnResetMatrix)
        Me.matrixActions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.matrixActions.Margin = New System.Windows.Forms.Padding(0)
        Me.matrixActions.WrapContents = False
        Me.matrixActions.Name = "matrixActions"
        Me.matrixActions.TabIndex = 1
        '
        'btnCalculateMatrixTotals
        '
        Me.btnCalculateMatrixTotals.AutoSize = True
        Me.btnCalculateMatrixTotals.MinimumSize = New System.Drawing.Size(190, 36)
        Me.btnCalculateMatrixTotals.Height = 36
        Me.btnCalculateMatrixTotals.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCalculateMatrixTotals.Text = "Calculate Matrix Totals"
        Me.btnCalculateMatrixTotals.UseVisualStyleBackColor = True
        Me.btnCalculateMatrixTotals.Name = "btnCalculateMatrixTotals"
        Me.btnCalculateMatrixTotals.TabIndex = 0
        '
        'btnResetMatrix
        '
        Me.btnResetMatrix.AutoSize = True
        Me.btnResetMatrix.MinimumSize = New System.Drawing.Size(96, 36)
        Me.btnResetMatrix.Height = 36
        Me.btnResetMatrix.Margin = New System.Windows.Forms.Padding(6)
        Me.btnResetMatrix.Text = "Reset"
        Me.btnResetMatrix.UseVisualStyleBackColor = True
        Me.btnResetMatrix.Name = "btnResetMatrix"
        Me.btnResetMatrix.TabIndex = 1
        '
        'txtMatrixResults
        '
        Me.txtMatrixResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMatrixResults.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Regular)
        Me.txtMatrixResults.Margin = New System.Windows.Forms.Padding(6)
        Me.txtMatrixResults.Multiline = True
        Me.txtMatrixResults.ReadOnly = True
        Me.txtMatrixResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMatrixResults.Name = "txtMatrixResults"
        Me.txtMatrixResults.TabIndex = 2
        '
        'tabPptReference
        '
        Me.tabPptReference.Controls.Add(Me.pptLayout)
        Me.tabPptReference.Padding = New System.Windows.Forms.Padding(6)
        Me.tabPptReference.Text = "PPT Reference"
        Me.tabPptReference.Name = "tabPptReference"
        Me.tabPptReference.UseVisualStyleBackColor = True
        '
        'pptLayout
        '
        Me.pptLayout.ColumnCount = 2
        Me.pptLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.pptLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.0!))
        Me.pptLayout.Controls.Add(Me.lstPptTopics, 0, 0)
        Me.pptLayout.Controls.Add(Me.txtPptTranscript, 1, 0)
        Me.pptLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pptLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.pptLayout.Padding = New System.Windows.Forms.Padding(6)
        Me.pptLayout.RowCount = 1
        Me.pptLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pptLayout.Name = "pptLayout"
        Me.pptLayout.TabIndex = 0
        '
        'lstPptTopics
        '
        Me.lstPptTopics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstPptTopics.FormattingEnabled = True
        Me.lstPptTopics.IntegralHeight = False
        Me.lstPptTopics.ItemHeight = 24
        Me.lstPptTopics.Margin = New System.Windows.Forms.Padding(6)
        Me.lstPptTopics.Name = "lstPptTopics"
        Me.lstPptTopics.TabIndex = 0
        '
        'txtPptTranscript
        '
        Me.txtPptTranscript.BackColor = System.Drawing.Color.FromArgb(18, 19, 22)
        Me.txtPptTranscript.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPptTranscript.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPptTranscript.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Regular)
        Me.txtPptTranscript.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252)
        Me.txtPptTranscript.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPptTranscript.Name = "txtPptTranscript"
        Me.txtPptTranscript.ReadOnly = True
        Me.txtPptTranscript.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtPptTranscript.TabIndex = 1
        Me.txtPptTranscript.Text = ""
        '
        'frmLesson7_Arrays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 740)
        Me.Controls.Add(Me.rootLayout)
        Me.MinimumSize = New System.Drawing.Size(900, 620)
        Me.Name = "frmLesson7_Arrays"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PF101 - Week 7: Arrays"
        Me.rootLayout.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.headerLayout.ResumeLayout(False)
        Me.tabsArrays.ResumeLayout(False)
        Me.tabLessonNotes.ResumeLayout(False)
        Me.tabMonths.ResumeLayout(False)
        Me.monthsLayout.ResumeLayout(False)
        Me.monthActions.ResumeLayout(False)
        Me.monthActions.PerformLayout()
        Me.tabArrayAnalysis.ResumeLayout(False)
        Me.analysisLayout.ResumeLayout(False)
        Me.analysisLayout.PerformLayout()
        Me.analysisInputs.ResumeLayout(False)
        Me.analysisInputs.PerformLayout()
        Me.analysisActions.ResumeLayout(False)
        Me.analysisActions.PerformLayout()
        Me.tabMatrix.ResumeLayout(False)
        Me.matrixLayout.ResumeLayout(False)
        Me.matrixLayout.PerformLayout()
        CType(Me.matrixGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.matrixActions.ResumeLayout(False)
        Me.matrixActions.PerformLayout()
        Me.tabPptReference.ResumeLayout(False)
        Me.pptLayout.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents rootLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents headerLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblHeaderTitle As System.Windows.Forms.Label
    Friend WithEvents lblHeaderSubtitle As System.Windows.Forms.Label
    Friend WithEvents tabsArrays As System.Windows.Forms.TabControl
    Friend WithEvents tabLessonNotes As System.Windows.Forms.TabPage
    Friend WithEvents txtLessonNotes As System.Windows.Forms.RichTextBox
    Friend WithEvents tabMonths As System.Windows.Forms.TabPage
    Friend WithEvents monthsLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lstMonths As System.Windows.Forms.ListBox
    Friend WithEvents monthActions As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnLoadMonths As System.Windows.Forms.Button
    Friend WithEvents btnClearMonthDisplay As System.Windows.Forms.Button
    Friend WithEvents lblMonthSelection As System.Windows.Forms.Label
    Friend WithEvents tabArrayAnalysis As System.Windows.Forms.TabPage
    Friend WithEvents analysisLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents analysisInputs As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblScoresInput As System.Windows.Forms.Label
    Friend WithEvents txtScoresInput As System.Windows.Forms.TextBox
    Friend WithEvents lblSearchScore As System.Windows.Forms.Label
    Friend WithEvents txtSearchScore As System.Windows.Forms.TextBox
    Friend WithEvents analysisActions As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnCalculateScores As System.Windows.Forms.Button
    Friend WithEvents btnFindScore As System.Windows.Forms.Button
    Friend WithEvents txtScoreResults As System.Windows.Forms.TextBox
    Friend WithEvents tabMatrix As System.Windows.Forms.TabPage
    Friend WithEvents matrixLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents matrixGrid As System.Windows.Forms.DataGridView
    Friend WithEvents matrixActions As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnCalculateMatrixTotals As System.Windows.Forms.Button
    Friend WithEvents btnResetMatrix As System.Windows.Forms.Button
    Friend WithEvents txtMatrixResults As System.Windows.Forms.TextBox
    Friend WithEvents tabPptReference As System.Windows.Forms.TabPage
    Friend WithEvents pptLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lstPptTopics As System.Windows.Forms.ListBox
    Friend WithEvents txtPptTranscript As System.Windows.Forms.RichTextBox
End Class
