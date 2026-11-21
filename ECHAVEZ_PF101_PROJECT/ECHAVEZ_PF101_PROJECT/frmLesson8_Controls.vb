Imports System.Drawing.Printing

Public Class frmLesson8_Controls

    Friend Property OpenPrintingLab As Boolean

    Private Sub frmLesson8_Controls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeManager.ApplyTheme(Me)
        txtLessonNotes.BackColor = Color.FromArgb(18, 19, 22)
        txtLessonNotes.ForeColor = Color.FromArgb(248, 250, 252)
        txtLessonNotes.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
        txtLessonNotes.Text =
            "WEEK 8: CONTROLS, RICH TEXT, AND COMMON DIALOGS" & vbCrLf &
            "============================================================" & vbCrLf & vbCrLf &
            "1. WINDOWS COMMON DIALOGS" & vbCrLf &
            "Standard system dialogs give users familiar ways to choose files, fonts, and colors. " &
            "ShowDialog returns a DialogResult, commonly OK when the user confirms or Cancel when " &
            "the user dismisses the dialog." & vbCrLf & vbCrLf &
            "OpenFileDialog / SaveFileDialog" & vbCrLf &
            "Use these to select an existing file or destination path. Configure FileName, DefaultExt, " &
            "AddExtension, and Filter to guide file selection. A filter is a sequence of descriptions " &
            "and patterns, such as ""Text files (*.txt)|*.txt|Rich Text (*.rtf)|*.rtf"". Check the result " &
            "before using the selected path." & vbCrLf & vbCrLf &
            "FontDialog / ColorDialog" & vbCrLf &
            "These dialogs let users choose typeface attributes and RGB colors. Apply the selected " &
            "Font or Color to a control or to its current text selection only after DialogResult.OK." & vbCrLf & vbCrLf &
            "PrintDialog / PrintPreviewDialog" & vbCrLf &
            "Printing dialogs work with a PrintDocument. Handle its PrintPage event to draw each page, " &
            "advance through the content, and set HasMorePages when more pages remain. PrintPreviewDialog " &
            "previews the same PrintDocument output before printing. Both buttons print the editor as plain text." & vbCrLf & vbCrLf &
            "2. RICHTEXTBOX VS. STANDARD TEXTBOX" & vbCrLf &
            "TextBox handles plain Unicode characters and is suitable for ordinary single-line or " &
            "multiline input. RichTextBox supports Rich Text Format (RTF), font weight variations, " &
            "colors, bullet points, and undo/redo buffers. SelectionFont and SelectionColor can format " &
            "highlighted text while Font and ForeColor set the default appearance." & vbCrLf & vbCrLf &
            "3. HIERARCHICAL NAVIGATION (TREEVIEW)" & vbCrLf &
            "TreeView represents hierarchical data as parent and child TreeNodes. Add nodes through " &
            "Nodes.Add, read the active item from SelectedNode, and respond to user navigation with " &
            "AfterSelect. A node can itself contain child nodes, enabling categories and subcategories." & vbCrLf & vbCrLf &
            "4. MULTI-COLUMN REPORTING (LISTVIEW)" & vbCrLf &
            "ListView displays structured records. Set View to View.Details and define ColumnHeader " &
            "objects in its Columns collection. Each ListViewItem represents one row; its SubItems " &
            "hold values for the remaining columns. FullRowSelect and GridLines can make tabular " &
            "information easier to inspect."

        txtPptTranscript.BackColor = Color.FromArgb(18, 19, 22)
        txtPptTranscript.ForeColor = Color.FromArgb(248, 250, 252)
        txtPptTranscript.Font = New Font("Consolas", 10.0F, FontStyle.Regular)
        lstPptTopics.Items.Clear()
        lstPptTopics.Items.AddRange(New Object() { _
            "Slide 01: Dialog Box Architecture", _
            "Slide 02: Open/Save File Filters", _
            "Slide 03: RichTextBox Formatting", _
            "Slide 04: TreeView Node Hierarchies", _
            "Slide 05: ListView in Detail View" _
        })
        If lstPptTopics.Items.Count > 0 Then lstPptTopics.SelectedIndex = 0

        AddCourseworkControls()
        If OpenPrintingLab Then
            tabsControls.SelectedTab = tabTextEditor
            lblEditorStatus.Text = "Week 12. Enter text, then choose Print Preview or Print. For StringBuilder and Char, try Week 6."
        End If
        PopulateControlCategories()
        If tvControlCategories.Nodes.Count > 0 Then
            tvControlCategories.SelectedNode = tvControlCategories.Nodes(0)
            tvControlCategories.Nodes(0).Expand()
        End If
    End Sub

    Private Sub AddCourseworkControls()
        Dim previewButton As New Button With {.Name = "btnPrintPreview", .Text = "Print Preview", .AutoSize = True, .Height = 36, .Margin = New Padding(6)}
        Dim printButton As New Button With {.Name = "btnPrint", .Text = "Print", .AutoSize = True, .Height = 36, .Margin = New Padding(6)}
        AddHandler previewButton.Click, Sub(sender, args) PrintEditorText(preview:=True)
        AddHandler printButton.Click, Sub(sender, args) PrintEditorText(preview:=False)
        editorActions.AutoScroll = True
        editorActions.Controls.Add(previewButton)
        editorActions.Controls.Add(printButton)

        Dim viewPicker As New ComboBox With {.Name = "cboListViewMode", .Dock = DockStyle.Fill,
                                             .DropDownStyle = ComboBoxStyle.DropDownList, .AccessibleName = "ListView mode",
                                             .Margin = New Padding(6)}
        viewPicker.Items.AddRange(New Object() {"Details (properties and values)", "List (property names)"})
        AddHandler viewPicker.SelectedIndexChanged,
            Sub(sender, args)
                lvControlProperties.View = If(viewPicker.SelectedIndex = 0, View.Details, View.List)
                lvControlProperties_Resize(lvControlProperties, EventArgs.Empty)
            End Sub
        browserLayout.RowCount = 2
        browserLayout.RowStyles.Insert(0, New RowStyle(SizeType.AutoSize))
        browserLayout.SetRow(lvControlProperties, 1)
        browserLayout.SetRowSpan(tvControlCategories, 2)
        browserLayout.Controls.Add(viewPicker, 1, 0)
        viewPicker.SelectedIndex = 0
        ThemeManager.ApplyTheme(editorActions)
        ThemeManager.ApplyTheme(browserLayout)
    End Sub

    Private Sub PrintEditorText(preview As Boolean)
        Dim textToPrint As String = rtbEditor.Text
        If String.IsNullOrWhiteSpace(textToPrint) Then
            lblEditorStatus.Text = "Enter text before printing."
            Return
        End If

        Try
            Using document As New PrintDocument(),
                  printFont As New Font("Segoe UI", 10.0F),
                  format As StringFormat = StringFormat.GenericTypographic
                format.FormatFlags = format.FormatFlags Or StringFormatFlags.LineLimit
                document.DocumentName = "PF101 Editor Text"
                Dim offset As Integer = 0
                AddHandler document.BeginPrint, Sub(sender, args) offset = 0
                AddHandler document.PrintPage,
                    Sub(sender, args)
                        Dim remaining As String = textToPrint.Substring(offset)
                        Dim charactersFitted As Integer
                        Dim linesFitted As Integer
                        args.Graphics.MeasureString(remaining, printFont, args.MarginBounds.Size, format,
                                                    charactersFitted, linesFitted)
                        If charactersFitted = 0 Then Throw New InvalidOperationException("The printer margins leave no room for text.")

                        args.Graphics.DrawString(remaining.Substring(0, charactersFitted), printFont, Brushes.Black,
                                                 args.MarginBounds, format)
                        offset += charactersFitted
                        args.HasMorePages = offset < textToPrint.Length
                    End Sub

                If preview Then
                    Using previewDialog As New PrintPreviewDialog With {.Document = document, .Width = 900, .Height = 650}
                        previewDialog.ShowDialog(TopLevelControl)
                    End Using
                Else
                    Using printDialog As New PrintDialog With {.Document = document, .UseEXDialog = True}
                        If printDialog.ShowDialog(TopLevelControl) <> DialogResult.OK Then Return
                        document.Print()
                    End Using
                    lblEditorStatus.Text = "Sent plain text to the printer."
                End If
            End Using
        Catch ex As Exception When TypeOf ex Is InvalidPrinterException OrElse
                                   TypeOf ex Is ComponentModel.Win32Exception OrElse
                                   TypeOf ex Is InvalidOperationException OrElse
                                   TypeOf ex Is Runtime.InteropServices.ExternalException
            lblEditorStatus.Text = "Printing is unavailable."
            MessageBox.Show(Me, ex.Message, "Printing Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub lstPptTopics_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPptTopics.SelectedIndexChanged
        Select Case lstPptTopics.SelectedIndex
            Case 0
                txtPptTranscript.Text =
                    "SLIDE 01 | DIALOG BOX ARCHITECTURE" & vbCrLf &
                    "============================================================" & vbCrLf & vbCrLf &
                    "Common dialogs provide standard Windows interactions. Configure a dialog, call " &
                    "ShowDialog(owner), then use its selected values only when the returned DialogResult is OK." & vbCrLf & vbCrLf &
                    "PROPERTY / PURPOSE" & vbCrLf &
                    "Title       Caption shown in the dialog" & vbCrLf &
                    "FileName    Selected or requested path" & vbCrLf &
                    "Filter      File types offered to the user" & vbCrLf &
                    "DialogResult OK confirms; Cancel leaves the operation unchanged" & vbCrLf & vbCrLf &
                    "SAMPLE" & vbCrLf &
                    "If openDialog.ShowDialog(Me) = DialogResult.OK Then" & vbCrLf &
                    "    OpenSelectedFile(openDialog.FileName)" & vbCrLf &
                    "End If" & vbCrLf & vbCrLf &
                    "Keep dialog components in the form's components container so the designer " &
                    "can manage their lifetime."
            Case 1
                txtPptTranscript.Text =
                    "SLIDE 02 | OPEN/SAVE FILE FILTERS" & vbCrLf &
                    "============================================================" & vbCrLf & vbCrLf &
                    "A filter is a pipe-delimited pair of friendly description and file pattern. " &
                    "Separate multiple pairs with another pipe." & vbCrLf & vbCrLf &
                    "PROPERTY / PURPOSE" & vbCrLf &
                    "Filter       Available descriptions and extensions" & vbCrLf &
                    "DefaultExt   Default extension when a name has none" & vbCrLf &
                    "AddExtension Append the selected/default extension" & vbCrLf &
                    "FilterIndex  One-based index of the active filter" & vbCrLf & vbCrLf &
                    "SAMPLE" & vbCrLf &
                    "dialog.Filter = ""Text (*.txt)|*.txt|Rich Text (*.rtf)|*.rtf""" & vbCrLf &
                    "dialog.DefaultExt = ""txt""" & vbCrLf &
                    "dialog.AddExtension = True" & vbCrLf & vbCrLf &
                    "When loading or saving RichTextBox content, select RichTextBoxStreamType.RichText " &
                    "for .rtf and PlainText for .txt. Report file and permission errors clearly."
            Case 2
                txtPptTranscript.Text =
                    "SLIDE 03 | RICHTEXTBOX FORMATTING" & vbCrLf &
                    "============================================================" & vbCrLf & vbCrLf &
                    "RichTextBox supports styled text and RTF serialization, unlike a standard TextBox. " &
                    "Apply a chosen font or color to a selection, or change the control defaults when " &
                    "there is no selection." & vbCrLf & vbCrLf &
                    "PROPERTY / PURPOSE" & vbCrLf &
                    "SelectionFont    Font applied to selected text" & vbCrLf &
                    "SelectionColor   Foreground color of selected text" & vbCrLf &
                    "SelectedRtf      Rich Text Format for the selection" & vbCrLf &
                    "CanUndo / Undo   Check and reverse the latest edit" & vbCrLf & vbCrLf &
                    "SAMPLE" & vbCrLf &
                    "If editor.SelectionLength > 0 Then" & vbCrLf &
                    "    editor.SelectionFont = chosenFont" & vbCrLf &
                    "Else" & vbCrLf &
                    "    editor.Font = chosenFont" & vbCrLf &
                    "End If" & vbCrLf & vbCrLf &
                    "Clipboard actions operate on the current selection; SelectAll selects the whole document."
            Case 3
                txtPptTranscript.Text =
                    "SLIDE 04 | TREEVIEW NODE HIERARCHIES" & vbCrLf &
                    "============================================================" & vbCrLf & vbCrLf &
                    "TreeView models parent-child relationships. A category node may contain control nodes; " &
                    "the selected node identifies the item currently being inspected." & vbCrLf & vbCrLf &
                    "PROPERTY / EVENT" & vbCrLf &
                    "Nodes          Root-level TreeNode collection" & vbCrLf &
                    "TreeNode.Nodes Children beneath a node" & vbCrLf &
                    "SelectedNode   Currently selected TreeNode" & vbCrLf &
                    "AfterSelect    Raised when selection changes" & vbCrLf & vbCrLf &
                    "SAMPLE" & vbCrLf &
                    "Dim category As TreeNode = tree.Nodes.Add(""Input Controls"")" & vbCrLf &
                    "category.Nodes.Add(""TextBox"")" & vbCrLf &
                    "category.Nodes.Add(""RichTextBox"")" & vbCrLf &
                    "Add a selected-node handler to update related details in another control."
            Case 4
                txtPptTranscript.Text =
                    "SLIDE 05 | LISTVIEW IN DETAIL VIEW" & vbCrLf &
                    "============================================================" & vbCrLf & vbCrLf &
                    "View.Details presents each item as a row with one value per column. Define the " &
                    "ColumnHeaders first, then place remaining row values in the ListViewItem.SubItems collection." & vbCrLf & vbCrLf &
                    "PROPERTY / COLLECTION" & vbCrLf &
                    "View             Choose Details for tabular columns" & vbCrLf &
                    "Columns          Ordered ColumnHeader collection" & vbCrLf &
                    "Items            Collection of displayed rows" & vbCrLf &
                    "SubItems         Additional values within one row" & vbCrLf &
                    "FullRowSelect    Select the whole row" & vbCrLf & vbCrLf &
                    "SAMPLE" & vbCrLf &
                    "list.View = View.Details" & vbCrLf &
                    "list.Columns.Add(""Property"", 140)" & vbCrLf &
                    "list.Columns.Add(""Details"", 300)" & vbCrLf &
                    "list.Items.Add(New ListViewItem(New String() {""Text"", ""Caption""}))" & vbCrLf & vbCrLf &
                    "Resize detail columns with the available client width for a responsive inspector."
            Case Else
                txtPptTranscript.Clear()
        End Select
    End Sub

    Private Sub btnOpenText_Click(sender As Object, e As EventArgs) Handles btnOpenText.Click
        If openTextDialog.ShowDialog(Me) <> DialogResult.OK Then Return
        If Not ConfirmReplaceDocument() Then Return

        Try
            Dim fileType As RichTextBoxStreamType =
                If(String.Equals(IO.Path.GetExtension(openTextDialog.FileName), ".rtf", StringComparison.OrdinalIgnoreCase),
                   RichTextBoxStreamType.RichText, RichTextBoxStreamType.PlainText)
            ' Load into a separate control so a failed read cannot replace the current document.
            Using stagedEditor As New RichTextBox()
                stagedEditor.LoadFile(openTextDialog.FileName, fileType)
                If fileType = RichTextBoxStreamType.RichText Then
                    rtbEditor.Rtf = stagedEditor.Rtf
                Else
                    rtbEditor.Text = stagedEditor.Text
                End If
            End Using
            rtbEditor.ClearUndo()
            rtbEditor.Modified = False
            lblEditorStatus.Text = "Opened: " & IO.Path.GetFileName(openTextDialog.FileName)
        Catch ex As IO.IOException
            ShowFileError("The selected file could not be read.", ex)
        Catch ex As UnauthorizedAccessException
            ShowFileError("Access to the selected file was denied.", ex)
        Catch ex As ArgumentException
            ShowFileError("The selected file could not be opened as supported text.", ex)
        Catch ex As NotSupportedException
            ShowFileError("The selected file format is not supported.", ex)
        Catch ex As System.Security.SecurityException
            ShowFileError("The application does not have permission to open the selected file.", ex)
        Catch ex As System.Runtime.InteropServices.ExternalException
            ShowFileError("A Windows file operation error prevented the file from opening.", ex)
        End Try
    End Sub

    Private Function ConfirmReplaceDocument() As Boolean
        If Not rtbEditor.Modified Then Return True

        Select Case MessageBox.Show(Me, "Save your changes before opening another file?",
                                    "Unsaved Text", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
            Case DialogResult.Yes
                Return TrySaveEditor()
            Case DialogResult.No
                Return True
            Case Else
                Return False
        End Select
    End Function

    Private Sub btnSaveText_Click(sender As Object, e As EventArgs) Handles btnSaveText.Click
        TrySaveEditor()
    End Sub

    Private Function TrySaveEditor() As Boolean
        saveTextDialog.DefaultExt = If(saveTextDialog.FilterIndex = 2, "rtf", "txt")
        If saveTextDialog.ShowDialog(Me) <> DialogResult.OK Then Return False

        Try
            Dim fileName As String = saveTextDialog.FileName
            If String.IsNullOrEmpty(IO.Path.GetExtension(fileName)) Then
                fileName &= If(saveTextDialog.FilterIndex = 2, ".rtf", ".txt")
            End If
            Dim fileType As RichTextBoxStreamType =
                If(String.Equals(IO.Path.GetExtension(fileName), ".rtf", StringComparison.OrdinalIgnoreCase),
                   RichTextBoxStreamType.RichText, RichTextBoxStreamType.PlainText)
            rtbEditor.SaveFile(fileName, fileType)
            rtbEditor.Modified = False
            lblEditorStatus.Text = "Saved: " & IO.Path.GetFileName(fileName)
            Return True
        Catch ex As IO.IOException
            ShowFileError("The file could not be saved.", ex)
        Catch ex As UnauthorizedAccessException
            ShowFileError("Access to the selected save location was denied.", ex)
        Catch ex As ArgumentException
            ShowFileError("The selected save path is invalid.", ex)
        Catch ex As NotSupportedException
            ShowFileError("The selected file format is not supported.", ex)
        Catch ex As System.Security.SecurityException
            ShowFileError("The application does not have permission to save to this location.", ex)
        Catch ex As System.Runtime.InteropServices.ExternalException
            ShowFileError("A Windows file operation error prevented the file from being saved.", ex)
        End Try
        Return False
    End Function

    Private Sub ShowFileError(message As String, ex As Exception)
        Debug.WriteLine("PF101 editor file operation failed. " & ex.GetType().Name & " " & ex.Message)
        lblEditorStatus.Text = "File operation failed."
        MessageBox.Show(message & vbCrLf & ex.Message, "File Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub btnChooseFont_Click(sender As Object, e As EventArgs) Handles btnChooseFont.Click
        fontPicker.Font = rtbEditor.SelectionFont
        If fontPicker.Font Is Nothing Then fontPicker.Font = rtbEditor.Font

        If fontPicker.ShowDialog(Me) = DialogResult.OK Then
            If rtbEditor.SelectionLength > 0 Then
                rtbEditor.SelectionFont = fontPicker.Font
            Else
                rtbEditor.Font = fontPicker.Font
            End If
            rtbEditor.Focus()
            rtbEditor.Modified = True
            lblEditorStatus.Text = "Font applied."
        End If
    End Sub

    Private Sub btnChooseColor_Click(sender As Object, e As EventArgs) Handles btnChooseColor.Click
        colorPicker.Color = If(rtbEditor.SelectionColor.IsEmpty, rtbEditor.ForeColor, rtbEditor.SelectionColor)
        If colorPicker.ShowDialog(Me) = DialogResult.OK Then
            If rtbEditor.SelectionLength > 0 Then
                rtbEditor.SelectionColor = colorPicker.Color
            Else
                rtbEditor.ForeColor = colorPicker.Color
            End If
            rtbEditor.Focus()
            rtbEditor.Modified = True
            lblEditorStatus.Text = "Text color applied."
        End If
    End Sub

    Private Sub btnCutText_Click(sender As Object, e As EventArgs) Handles btnCutText.Click
        If rtbEditor.SelectionLength = 0 Then
            lblEditorStatus.Text = "Select text before cutting."
            Return
        End If
        rtbEditor.Cut()
        rtbEditor.Focus()
        lblEditorStatus.Text = "Selection cut."
    End Sub

    Private Sub btnCopyText_Click(sender As Object, e As EventArgs) Handles btnCopyText.Click
        If rtbEditor.SelectionLength = 0 Then
            lblEditorStatus.Text = "Select text before copying."
            Return
        End If
        rtbEditor.Copy()
        lblEditorStatus.Text = "Selection copied."
    End Sub

    Private Sub btnPasteText_Click(sender As Object, e As EventArgs) Handles btnPasteText.Click
        rtbEditor.Paste()
        rtbEditor.Focus()
        lblEditorStatus.Text = "Clipboard content pasted."
    End Sub

    Private Sub btnSelectAllText_Click(sender As Object, e As EventArgs) Handles btnSelectAllText.Click
        rtbEditor.SelectAll()
        rtbEditor.Focus()
        lblEditorStatus.Text = "All editor text selected."
    End Sub

    Private Sub btnUndoText_Click(sender As Object, e As EventArgs) Handles btnUndoText.Click
        If Not rtbEditor.CanUndo Then
            lblEditorStatus.Text = "There is no editor action to undo."
            Return
        End If

        rtbEditor.Undo()
        rtbEditor.Focus()
        lblEditorStatus.Text = "Last editor action undone."
    End Sub

    Private Sub btnFindText_Click(sender As Object, e As EventArgs) Handles btnFindText.Click
        Dim searchText As String = txtFind.Text.Trim()
        If String.IsNullOrEmpty(searchText) Then
            lblEditorStatus.Text = "Enter text in the Find box."
            txtFind.Focus()
            Return
        End If

        Dim startAt As Integer = Math.Min(rtbEditor.SelectionStart + rtbEditor.SelectionLength, rtbEditor.TextLength)
        Dim foundAt As Integer = -1
        If startAt < rtbEditor.TextLength Then
            foundAt = rtbEditor.Find(searchText, startAt, rtbEditor.TextLength, RichTextBoxFinds.None)
        End If
        If foundAt < 0 AndAlso startAt > 0 Then foundAt = rtbEditor.Find(searchText, 0, startAt, RichTextBoxFinds.None)

        If foundAt >= 0 Then
            rtbEditor.Select(foundAt, searchText.Length)
            rtbEditor.Focus()
            lblEditorStatus.Text = "Found """ & searchText & """ at character " & foundAt.ToString() & "."
        Else
            rtbEditor.SelectionLength = 0
            lblEditorStatus.Text = "Could not find """ & searchText & """."
            MessageBox.Show("No matching text was found.", "Find Text",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub PopulateControlCategories()
        Dim inputNode As TreeNode = tvControlCategories.Nodes.Add("Input Controls")
        inputNode.ToolTipText = "Controls used to collect or edit user input."
        AddControlNode(inputNode, "TextBox", "Accepts typed text; supports single-line or multiline entry.")
        AddControlNode(inputNode, "RichTextBox", "Edits formatted text with selection and formatting support.")
        AddControlNode(inputNode, "ComboBox", "Presents a drop-down list with optional typed input.")
        AddControlNode(inputNode, "NumericUpDown", "Restricts input to a configurable numeric range.")

        Dim displayNode As TreeNode = tvControlCategories.Nodes.Add("Display Controls")
        displayNode.ToolTipText = "Controls used to show information and collections."
        AddControlNode(displayNode, "Label", "Displays read-only text or a caption.")
        AddControlNode(displayNode, "ListBox", "Displays a selectable list of items.")
        AddControlNode(displayNode, "ListView", "Displays items in details, icon, or list views.")
        AddControlNode(displayNode, "TreeView", "Displays hierarchical items with expandable nodes.")

        Dim buttonsNode As TreeNode = tvControlCategories.Nodes.Add("Action Controls")
        buttonsNode.ToolTipText = "Controls used to trigger actions or choose options."
        AddControlNode(buttonsNode, "Button", "Runs an action in response to a click.")
        AddControlNode(buttonsNode, "CheckBox", "Represents an independent on/off choice.")
        AddControlNode(buttonsNode, "RadioButton", "Selects one option from a mutually exclusive group.")

        Dim containerNode As TreeNode = tvControlCategories.Nodes.Add("Containers & Layout")
        containerNode.ToolTipText = "Controls that contain and organize other controls."
        AddControlNode(containerNode, "Panel", "Groups controls in a scrollable or bordered region.")
        AddControlNode(containerNode, "GroupBox", "Groups related controls under a caption.")
        AddControlNode(containerNode, "TableLayoutPanel", "Arranges child controls in rows and columns.")
        AddControlNode(containerNode, "FlowLayoutPanel", "Arranges child controls sequentially and wraps them.")

        Dim dialogsNode As TreeNode = tvControlCategories.Nodes.Add("Common Dialogs")
        dialogsNode.ToolTipText = "Standard Windows dialogs for common user choices."
        AddControlNode(dialogsNode, "OpenFileDialog", "Prompts the user to select an existing file.")
        AddControlNode(dialogsNode, "SaveFileDialog", "Prompts the user for a file name and save location.")
        AddControlNode(dialogsNode, "FontDialog", "Lets the user choose a font and style.")
        AddControlNode(dialogsNode, "ColorDialog", "Lets the user choose a color.")
    End Sub

    Private Sub AddControlNode(parent As TreeNode, controlName As String, description As String)
        Dim item As TreeNode = parent.Nodes.Add(controlName)
        item.ToolTipText = description
    End Sub

    Private Sub tvControlCategories_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvControlCategories.AfterSelect
        lvControlProperties.Items.Clear()
        lvControlProperties.Items.Add(New ListViewItem(New String() {"Control", e.Node.Text}))
        lvControlProperties.Items.Add(New ListViewItem(New String() {"Type", If(e.Node.Parent Is Nothing, "Category", "Windows Forms control")}))
        lvControlProperties.Items.Add(New ListViewItem(New String() {"Parent", If(e.Node.Parent Is Nothing, "UI Control Categories", e.Node.Parent.Text)}))
        lvControlProperties.Items.Add(New ListViewItem(New String() {"Purpose", e.Node.ToolTipText}))
        lvControlProperties.Items.Add(New ListViewItem(New String() {"Common properties", GetCommonProperties(e.Node)}))
        lvControlProperties.Items(0).Selected = True
    End Sub

    Private Function GetCommonProperties(node As TreeNode) As String
        If node.Parent Is Nothing Then Return "Expand the category to inspect individual controls."

        Select Case node.Text
            Case "TextBox"
                Return "Text, Multiline, ReadOnly, MaxLength"
            Case "RichTextBox"
                Return "Text, SelectionFont, SelectionColor, ReadOnly"
            Case "ComboBox"
                Return "Items, SelectedIndex, SelectedItem, DropDownStyle"
            Case "NumericUpDown"
                Return "Value, Minimum, Maximum, DecimalPlaces"
            Case "Label"
                Return "Text, AutoSize, TextAlign, Image"
            Case "ListBox"
                Return "Items, SelectedIndex, SelectedItem, SelectionMode"
            Case "ListView"
                Return "Items, Columns, View, FullRowSelect"
            Case "TreeView"
                Return "Nodes, SelectedNode, CheckBoxes, ShowLines"
            Case "Button"
                Return "Text, Enabled, DialogResult, FlatStyle"
            Case "CheckBox"
                Return "Text, Checked, CheckState, AutoCheck"
            Case "RadioButton"
                Return "Text, Checked, AutoCheck, Appearance"
            Case "Panel", "GroupBox"
                Return "Controls, Dock, Padding, BorderStyle"
            Case "TableLayoutPanel"
                Return "Controls, RowCount, ColumnCount, CellPosition"
            Case "FlowLayoutPanel"
                Return "Controls, FlowDirection, WrapContents, AutoScroll"
            Case "OpenFileDialog", "SaveFileDialog"
                Return "FileName, Filter, InitialDirectory, Title"
            Case "FontDialog"
                Return "Font, Color, ShowColor, MinSize, MaxSize"
            Case "ColorDialog"
                Return "Color, FullOpen, AllowFullOpen, AnyColor"
            Case Else
                Return "Name, Text, Enabled, Visible, Dock"
        End Select
    End Function

    Private Sub lvControlProperties_Resize(sender As Object, e As EventArgs) Handles lvControlProperties.Resize
        If lvControlProperties.View = View.Details AndAlso lvControlProperties.Columns.Count = 2 Then
            lvControlProperties.Columns(1).Width = Math.Max(180, lvControlProperties.ClientSize.Width - lvControlProperties.Columns(0).Width - 8)
        End If
    End Sub

End Class
