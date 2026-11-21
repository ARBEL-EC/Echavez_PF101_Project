<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLesson8_Controls
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
        Me.components = New System.ComponentModel.Container()
        Me.openTextDialog = New System.Windows.Forms.OpenFileDialog()
        Me.components.Add(Me.openTextDialog)
        Me.saveTextDialog = New System.Windows.Forms.SaveFileDialog()
        Me.components.Add(Me.saveTextDialog)
        Me.fontPicker = New System.Windows.Forms.FontDialog()
        Me.components.Add(Me.fontPicker)
        Me.colorPicker = New System.Windows.Forms.ColorDialog()
        Me.components.Add(Me.colorPicker)
        Me.rootLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.headerLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.lblHeaderSubtitle = New System.Windows.Forms.Label()
        Me.tabsControls = New System.Windows.Forms.TabControl()
        Me.tabLessonNotes = New System.Windows.Forms.TabPage()
        Me.txtLessonNotes = New System.Windows.Forms.RichTextBox()
        Me.tabTextEditor = New System.Windows.Forms.TabPage()
        Me.editorLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.editorActions = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnOpenText = New System.Windows.Forms.Button()
        Me.btnSaveText = New System.Windows.Forms.Button()
        Me.btnChooseFont = New System.Windows.Forms.Button()
        Me.btnChooseColor = New System.Windows.Forms.Button()
        Me.btnCutText = New System.Windows.Forms.Button()
        Me.btnCopyText = New System.Windows.Forms.Button()
        Me.btnPasteText = New System.Windows.Forms.Button()
        Me.btnSelectAllText = New System.Windows.Forms.Button()
        Me.btnUndoText = New System.Windows.Forms.Button()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.btnFindText = New System.Windows.Forms.Button()
        Me.rtbEditor = New System.Windows.Forms.RichTextBox()
        Me.lblEditorStatus = New System.Windows.Forms.Label()
        Me.tabControlBrowser = New System.Windows.Forms.TabPage()
        Me.browserLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.tvControlCategories = New System.Windows.Forms.TreeView()
        Me.lvControlProperties = New System.Windows.Forms.ListView()
        Me.colPropertyName = New System.Windows.Forms.ColumnHeader()
        Me.colPropertyDetails = New System.Windows.Forms.ColumnHeader()
        Me.tabPptReference = New System.Windows.Forms.TabPage()
        Me.pptLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.lstPptTopics = New System.Windows.Forms.ListBox()
        Me.txtPptTranscript = New System.Windows.Forms.RichTextBox()
        Me.rootLayout.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.headerLayout.SuspendLayout()
        Me.tabsControls.SuspendLayout()
        Me.tabLessonNotes.SuspendLayout()
        Me.tabTextEditor.SuspendLayout()
        Me.editorLayout.SuspendLayout()
        Me.editorActions.SuspendLayout()
        Me.tabControlBrowser.SuspendLayout()
        Me.browserLayout.SuspendLayout()
        Me.tabPptReference.SuspendLayout()
        Me.pptLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'openTextDialog
        '
        Me.openTextDialog.Filter = "Text and Rich Text files|*.txt;*.rtf|Text files (*.txt)|*.txt|Rich Text files (*.rtf)|*.rtf|All files (*.*)|*.*"
        Me.openTextDialog.Title = "Open Text File"
        '
        'saveTextDialog
        '
        Me.saveTextDialog.DefaultExt = "txt"
        Me.saveTextDialog.Filter = "Text files (*.txt)|*.txt|Rich Text files (*.rtf)|*.rtf|All files (*.*)|*.*"
        Me.saveTextDialog.AddExtension = False
        Me.saveTextDialog.Title = "Save Text File"
        '
        'fontPicker
        '
        Me.fontPicker.ShowColor = False
        '
        'colorPicker
        '
        Me.colorPicker.FullOpen = True
        '
        'rootLayout
        '
        Me.rootLayout.ColumnCount = 1
        Me.rootLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.rootLayout.Controls.Add(Me.pnlHeader, 0, 0)
        Me.rootLayout.Controls.Add(Me.tabsControls, 0, 1)
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
        Me.lblHeaderTitle.Text = "WEEK 8  |  CONTROLS & DIALOGS"
        Me.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblHeaderTitle.Margin = New System.Windows.Forms.Padding(6)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.TabIndex = 0
        '
        'lblHeaderSubtitle
        '
        Me.lblHeaderSubtitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHeaderSubtitle.Text = "Edit and format text, work with standard dialogs, and explore Windows Forms controls."
        Me.lblHeaderSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblHeaderSubtitle.Margin = New System.Windows.Forms.Padding(6)
        Me.lblHeaderSubtitle.Name = "lblHeaderSubtitle"
        Me.lblHeaderSubtitle.TabIndex = 1
        '
        'tabsControls
        '
        Me.tabsControls.Controls.Add(Me.tabLessonNotes)
        Me.tabsControls.Controls.Add(Me.tabTextEditor)
        Me.tabsControls.Controls.Add(Me.tabControlBrowser)
        Me.tabsControls.Controls.Add(Me.tabPptReference)
        Me.tabsControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabsControls.Margin = New System.Windows.Forms.Padding(6)
        Me.tabsControls.Name = "tabsControls"
        Me.tabsControls.SelectedIndex = 0
        Me.tabsControls.TabIndex = 1
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
        'tabTextEditor
        '
        Me.tabTextEditor.Controls.Add(Me.editorLayout)
        Me.tabTextEditor.Padding = New System.Windows.Forms.Padding(6)
        Me.tabTextEditor.Text = "Text Editor & Dialogs"
        Me.tabTextEditor.Name = "tabTextEditor"
        Me.tabTextEditor.UseVisualStyleBackColor = True
        '
        'editorLayout
        '
        Me.editorLayout.ColumnCount = 1
        Me.editorLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.editorLayout.Controls.Add(Me.editorActions, 0, 0)
        Me.editorLayout.Controls.Add(Me.rtbEditor, 0, 1)
        Me.editorLayout.Controls.Add(Me.lblEditorStatus, 0, 2)
        Me.editorLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editorLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.editorLayout.Padding = New System.Windows.Forms.Padding(6)
        Me.editorLayout.RowCount = 3
        Me.editorLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.editorLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.editorLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.editorLayout.Name = "editorLayout"
        Me.editorLayout.TabIndex = 0
        '
        'editorActions
        '
        Me.editorActions.Controls.Add(Me.btnOpenText)
        Me.editorActions.Controls.Add(Me.btnSaveText)
        Me.editorActions.Controls.Add(Me.btnChooseFont)
        Me.editorActions.Controls.Add(Me.btnChooseColor)
        Me.editorActions.Controls.Add(Me.btnCutText)
        Me.editorActions.Controls.Add(Me.btnCopyText)
        Me.editorActions.Controls.Add(Me.btnPasteText)
        Me.editorActions.Controls.Add(Me.btnSelectAllText)
        Me.editorActions.Controls.Add(Me.btnUndoText)
        Me.editorActions.Controls.Add(Me.txtFind)
        Me.editorActions.Controls.Add(Me.btnFindText)
        Me.editorActions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editorActions.Margin = New System.Windows.Forms.Padding(0)
        Me.editorActions.WrapContents = True
        Me.editorActions.Name = "editorActions"
        Me.editorActions.TabIndex = 0
        '
        'btnOpenText
        '
        Me.btnOpenText.AutoSize = True
        Me.btnOpenText.MinimumSize = New System.Drawing.Size(72, 36)
        Me.btnOpenText.Height = 36
        Me.btnOpenText.Margin = New System.Windows.Forms.Padding(6)
        Me.btnOpenText.Text = "Open"
        Me.btnOpenText.UseVisualStyleBackColor = True
        Me.btnOpenText.Name = "btnOpenText"
        Me.btnOpenText.TabIndex = 0
        '
        'btnSaveText
        '
        Me.btnSaveText.AutoSize = True
        Me.btnSaveText.MinimumSize = New System.Drawing.Size(72, 36)
        Me.btnSaveText.Height = 36
        Me.btnSaveText.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSaveText.Text = "Save"
        Me.btnSaveText.UseVisualStyleBackColor = True
        Me.btnSaveText.Name = "btnSaveText"
        Me.btnSaveText.TabIndex = 1
        '
        'btnChooseFont
        '
        Me.btnChooseFont.AutoSize = True
        Me.btnChooseFont.MinimumSize = New System.Drawing.Size(72, 36)
        Me.btnChooseFont.Height = 36
        Me.btnChooseFont.Margin = New System.Windows.Forms.Padding(6)
        Me.btnChooseFont.Text = "Font"
        Me.btnChooseFont.UseVisualStyleBackColor = True
        Me.btnChooseFont.Name = "btnChooseFont"
        Me.btnChooseFont.TabIndex = 2
        '
        'btnChooseColor
        '
        Me.btnChooseColor.AutoSize = True
        Me.btnChooseColor.MinimumSize = New System.Drawing.Size(72, 36)
        Me.btnChooseColor.Height = 36
        Me.btnChooseColor.Margin = New System.Windows.Forms.Padding(6)
        Me.btnChooseColor.Text = "Color"
        Me.btnChooseColor.UseVisualStyleBackColor = True
        Me.btnChooseColor.Name = "btnChooseColor"
        Me.btnChooseColor.TabIndex = 3
        '
        'btnCutText
        '
        Me.btnCutText.AutoSize = True
        Me.btnCutText.MinimumSize = New System.Drawing.Size(72, 36)
        Me.btnCutText.Height = 36
        Me.btnCutText.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCutText.Text = "Cut"
        Me.btnCutText.UseVisualStyleBackColor = True
        Me.btnCutText.Name = "btnCutText"
        Me.btnCutText.TabIndex = 4
        '
        'btnCopyText
        '
        Me.btnCopyText.AutoSize = True
        Me.btnCopyText.MinimumSize = New System.Drawing.Size(72, 36)
        Me.btnCopyText.Height = 36
        Me.btnCopyText.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCopyText.Text = "Copy"
        Me.btnCopyText.UseVisualStyleBackColor = True
        Me.btnCopyText.Name = "btnCopyText"
        Me.btnCopyText.TabIndex = 5
        '
        'btnPasteText
        '
        Me.btnPasteText.AutoSize = True
        Me.btnPasteText.MinimumSize = New System.Drawing.Size(72, 36)
        Me.btnPasteText.Height = 36
        Me.btnPasteText.Margin = New System.Windows.Forms.Padding(6)
        Me.btnPasteText.Text = "Paste"
        Me.btnPasteText.UseVisualStyleBackColor = True
        Me.btnPasteText.Name = "btnPasteText"
        Me.btnPasteText.TabIndex = 6
        '
        'btnSelectAllText
        '
        Me.btnSelectAllText.AutoSize = True
        Me.btnSelectAllText.MinimumSize = New System.Drawing.Size(92, 36)
        Me.btnSelectAllText.Height = 36
        Me.btnSelectAllText.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSelectAllText.Text = "Select All"
        Me.btnSelectAllText.UseVisualStyleBackColor = True
        Me.btnSelectAllText.Name = "btnSelectAllText"
        Me.btnSelectAllText.TabIndex = 7
        '
        'btnUndoText
        '
        Me.btnUndoText.AutoSize = True
        Me.btnUndoText.MinimumSize = New System.Drawing.Size(72, 36)
        Me.btnUndoText.Height = 36
        Me.btnUndoText.Margin = New System.Windows.Forms.Padding(6)
        Me.btnUndoText.Text = "Undo"
        Me.btnUndoText.UseVisualStyleBackColor = True
        Me.btnUndoText.Name = "btnUndoText"
        Me.btnUndoText.TabIndex = 8
        '
        'txtFind
        '
        Me.txtFind.AccessibleName = "Text to find"
        Me.txtFind.Margin = New System.Windows.Forms.Padding(6)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(160, 25)
        Me.txtFind.TabIndex = 9
        '
        'btnFindText
        '
        Me.btnFindText.AutoSize = True
        Me.btnFindText.MinimumSize = New System.Drawing.Size(72, 36)
        Me.btnFindText.Height = 36
        Me.btnFindText.Margin = New System.Windows.Forms.Padding(6)
        Me.btnFindText.Text = "Find"
        Me.btnFindText.UseVisualStyleBackColor = True
        Me.btnFindText.Name = "btnFindText"
        Me.btnFindText.TabIndex = 10
        '
        'rtbEditor
        '
        Me.rtbEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbEditor.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Regular)
        Me.rtbEditor.Margin = New System.Windows.Forms.Padding(6)
        Me.rtbEditor.Name = "rtbEditor"
        Me.rtbEditor.TabIndex = 1
        Me.rtbEditor.Text = ""
        '
        'lblEditorStatus
        '
        Me.lblEditorStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEditorStatus.Text = "Ready. Open a text or RTF file, or begin typing."
        Me.lblEditorStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblEditorStatus.Margin = New System.Windows.Forms.Padding(6)
        Me.lblEditorStatus.Name = "lblEditorStatus"
        Me.lblEditorStatus.TabIndex = 2
        '
        'tabControlBrowser
        '
        Me.tabControlBrowser.Controls.Add(Me.browserLayout)
        Me.tabControlBrowser.Padding = New System.Windows.Forms.Padding(6)
        Me.tabControlBrowser.Text = "TreeView & ListView"
        Me.tabControlBrowser.Name = "tabControlBrowser"
        Me.tabControlBrowser.UseVisualStyleBackColor = True
        '
        'browserLayout
        '
        Me.browserLayout.ColumnCount = 2
        Me.browserLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.0!))
        Me.browserLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.0!))
        Me.browserLayout.Controls.Add(Me.tvControlCategories, 0, 0)
        Me.browserLayout.Controls.Add(Me.lvControlProperties, 1, 0)
        Me.browserLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.browserLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.browserLayout.Padding = New System.Windows.Forms.Padding(6)
        Me.browserLayout.RowCount = 1
        Me.browserLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.browserLayout.Name = "browserLayout"
        Me.browserLayout.TabIndex = 0
        '
        'tvControlCategories
        '
        Me.tvControlCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvControlCategories.HideSelection = False
        Me.tvControlCategories.Margin = New System.Windows.Forms.Padding(6)
        Me.tvControlCategories.Name = "tvControlCategories"
        Me.tvControlCategories.ShowNodeToolTips = True
        Me.tvControlCategories.TabIndex = 0
        '
        'lvControlProperties
        '
        Me.lvControlProperties.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colPropertyName, Me.colPropertyDetails})
        Me.lvControlProperties.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvControlProperties.FullRowSelect = True
        Me.lvControlProperties.GridLines = True
        Me.lvControlProperties.HideSelection = False
        Me.lvControlProperties.Margin = New System.Windows.Forms.Padding(6)
        Me.lvControlProperties.Name = "lvControlProperties"
        Me.lvControlProperties.UseCompatibleStateImageBehavior = False
        Me.lvControlProperties.View = System.Windows.Forms.View.Details
        Me.lvControlProperties.TabIndex = 1
        '
        'colPropertyName
        '
        Me.colPropertyName.Text = "Property"
        Me.colPropertyName.Width = 150
        '
        'colPropertyDetails
        '
        Me.colPropertyDetails.Text = "Details"
        Me.colPropertyDetails.Width = 520
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
        Me.pptLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.0!))
        Me.pptLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.0!))
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
        'frmLesson8_Controls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 740)
        Me.Controls.Add(Me.rootLayout)
        Me.MinimumSize = New System.Drawing.Size(900, 620)
        Me.Name = "frmLesson8_Controls"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PF101 - Week 8: Controls and Dialogs"
        Me.rootLayout.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.headerLayout.ResumeLayout(False)
        Me.tabsControls.ResumeLayout(False)
        Me.tabLessonNotes.ResumeLayout(False)
        Me.tabTextEditor.ResumeLayout(False)
        Me.editorLayout.ResumeLayout(False)
        Me.editorActions.ResumeLayout(False)
        Me.editorActions.PerformLayout()
        Me.tabControlBrowser.ResumeLayout(False)
        Me.browserLayout.ResumeLayout(False)
        Me.tabPptReference.ResumeLayout(False)
        Me.pptLayout.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents openTextDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents saveTextDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents fontPicker As System.Windows.Forms.FontDialog
    Friend WithEvents colorPicker As System.Windows.Forms.ColorDialog
    Friend WithEvents rootLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents headerLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblHeaderTitle As System.Windows.Forms.Label
    Friend WithEvents lblHeaderSubtitle As System.Windows.Forms.Label
    Friend WithEvents tabsControls As System.Windows.Forms.TabControl
    Friend WithEvents tabLessonNotes As System.Windows.Forms.TabPage
    Friend WithEvents txtLessonNotes As System.Windows.Forms.RichTextBox
    Friend WithEvents tabTextEditor As System.Windows.Forms.TabPage
    Friend WithEvents editorLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents editorActions As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnOpenText As System.Windows.Forms.Button
    Friend WithEvents btnSaveText As System.Windows.Forms.Button
    Friend WithEvents btnChooseFont As System.Windows.Forms.Button
    Friend WithEvents btnChooseColor As System.Windows.Forms.Button
    Friend WithEvents btnCutText As System.Windows.Forms.Button
    Friend WithEvents btnCopyText As System.Windows.Forms.Button
    Friend WithEvents btnPasteText As System.Windows.Forms.Button
    Friend WithEvents btnSelectAllText As System.Windows.Forms.Button
    Friend WithEvents btnUndoText As System.Windows.Forms.Button
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents btnFindText As System.Windows.Forms.Button
    Friend WithEvents rtbEditor As System.Windows.Forms.RichTextBox
    Friend WithEvents lblEditorStatus As System.Windows.Forms.Label
    Friend WithEvents tabControlBrowser As System.Windows.Forms.TabPage
    Friend WithEvents browserLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tvControlCategories As System.Windows.Forms.TreeView
    Friend WithEvents lvControlProperties As System.Windows.Forms.ListView
    Friend WithEvents colPropertyName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPropertyDetails As System.Windows.Forms.ColumnHeader
    Friend WithEvents tabPptReference As System.Windows.Forms.TabPage
    Friend WithEvents pptLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lstPptTopics As System.Windows.Forms.ListBox
    Friend WithEvents txtPptTranscript As System.Windows.Forms.RichTextBox
End Class
