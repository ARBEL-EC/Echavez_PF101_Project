Option Strict On

Imports System.Data

Friend NotInheritable Class DataRowPracticeView
    Inherits UserControl

    Private ReadOnly _practice As New DataRowPractice()
    Private ReadOnly _grid As New DataGridView With {
        .Dock = DockStyle.Fill, .ReadOnly = True, .AllowUserToAddRows = False, .AllowUserToDeleteRows = False,
        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill, .RowHeadersVisible = False,
        .SelectionMode = DataGridViewSelectionMode.FullRowSelect, .MultiSelect = False,
        .AccessibleName = "In-memory practice rows and their states"
    }
    Private ReadOnly _score As New NumericUpDown With {.Maximum = 100, .Width = 64, .AccessibleName = "New score"}
    Private ReadOnly _modifyButton As New Button With {.Text = "Apply Score", .AutoSize = True}
    Private ReadOnly _deleteButton As New Button With {.Text = "Delete Sample", .AutoSize = True}
    Private ReadOnly _stateNote As New Label With {.Dock = DockStyle.Fill, .AutoSize = True}
    Private _refreshing As Boolean

    Friend Sub New()
        AutoScaleMode = AutoScaleMode.Font
        Dim instruction As New Label With {
            .Text = "In-memory practice. Add a sample, change a baseline row, and delete a different baseline row.",
            .AutoSize = True, .Dock = DockStyle.Fill, .Margin = New Padding(3, 3, 3, 8)
        }
        _grid.Columns.Add("sample", "Sample")
        _grid.Columns.Add("state", "Row state")
        _grid.Columns.Add("original", "Original score")
        _grid.Columns.Add("current", "Current score")
        For Each column As DataGridViewColumn In _grid.Columns
            column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        Dim rowActions As New FlowLayoutPanel With {.AutoSize = True, .Dock = DockStyle.Fill}
        rowActions.Controls.Add(MakeButton("Add Sample", Sub() RefreshRows(_practice.AddSample())))
        rowActions.Controls.Add(New Label With {.Text = "New score", .AutoSize = True, .Margin = New Padding(10, 7, 3, 3)})
        rowActions.Controls.AddRange(New Control() {_score, _modifyButton, _deleteButton})
        AddHandler _modifyButton.Click,
            Sub(sender, args)
                Dim row As DataRow = SelectedRow()
                If row Is Nothing OrElse row.RowState = DataRowState.Deleted Then Return
                _practice.ChangeScore(row, CInt(_score.Value))
                RefreshRows(row)
            End Sub
        AddHandler _deleteButton.Click,
            Sub(sender, args)
                Dim row As DataRow = SelectedRow()
                If row Is Nothing OrElse row.RowState = DataRowState.Deleted Then Return
                row.Delete()
                RefreshRows(row)
            End Sub

        Dim dataActions As New FlowLayoutPanel With {.AutoSize = True, .Dock = DockStyle.Fill}
        dataActions.Controls.Add(MakeButton("Accept Changes",
            Sub()
                _practice.Data.AcceptChanges()
                RefreshRows()
            End Sub))
        dataActions.Controls.Add(MakeButton("Reject Changes",
            Sub()
                _practice.Data.RejectChanges()
                RefreshRows()
            End Sub))
        dataActions.Controls.Add(MakeButton("Reset Practice",
            Sub()
                _practice.Reset()
                RefreshRows()
            End Sub))

        Dim layout As New TableLayoutPanel With {.ColumnCount = 1, .RowCount = 5, .Dock = DockStyle.Fill, .Padding = New Padding(12)}
        layout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        layout.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        layout.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        layout.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        layout.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        layout.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        layout.Controls.Add(instruction, 0, 0)
        layout.Controls.Add(rowActions, 0, 1)
        layout.Controls.Add(_grid, 0, 2)
        layout.Controls.Add(_stateNote, 0, 3)
        layout.Controls.Add(dataActions, 0, 4)
        Controls.Add(layout)
        AddHandler _grid.SelectionChanged, AddressOf UpdateSelection
        AddHandler Disposed, Sub(sender, args) _practice.Data.Dispose()
        RefreshRows()
    End Sub

    Private Shared Function MakeButton(caption As String, action As Action) As Button
        Dim button As New Button With {.Text = caption, .AutoSize = True}
        AddHandler button.Click, Sub(sender, args) action()
        Return button
    End Function

    Private Function SelectedRow() As DataRow
        If _grid.SelectedRows.Count = 0 Then Return Nothing
        Return TryCast(_grid.SelectedRows(0).Tag, DataRow)
    End Function

    Private Sub RefreshRows(Optional preferred As DataRow = Nothing)
        _refreshing = True
        Try
            _grid.Rows.Clear()
            Dim selectedIndex As Integer = 0
            For Each row As DataRow In _practice.Table.Rows
                Dim version As DataRowVersion = If(row.RowState = DataRowState.Deleted, DataRowVersion.Original, DataRowVersion.Current)
                Dim original As String = If(row.HasVersion(DataRowVersion.Original), CInt(row("Score", DataRowVersion.Original)).ToString(), "—")
                Dim current As String = If(row.HasVersion(DataRowVersion.Current), CInt(row("Score", DataRowVersion.Current)).ToString(), "—")
                Dim index As Integer = _grid.Rows.Add(CStr(row("Sample", version)), row.RowState.ToString(), original, current)
                _grid.Rows(index).Tag = row
                If row Is preferred Then selectedIndex = index
            Next
            If _grid.Rows.Count > 0 Then _grid.CurrentCell = _grid.Rows(selectedIndex).Cells(0)
        Finally
            _refreshing = False
        End Try
        UpdateSelection(Nothing, EventArgs.Empty)
    End Sub

    Private Sub UpdateSelection(sender As Object, e As EventArgs)
        If _refreshing Then Return
        Dim row As DataRow = SelectedRow()
        Dim canEdit As Boolean = row IsNot Nothing AndAlso row.RowState <> DataRowState.Deleted
        _modifyButton.Enabled = canEdit
        _deleteButton.Enabled = canEdit
        _score.Enabled = canEdit
        If canEdit Then _score.Value = CDec(row("Score"))
        If row Is Nothing Then
            _stateNote.Text = "Add a sample or reset the practice table."
            Return
        End If

        Select Case row.RowState
            Case DataRowState.Added
                _stateNote.Text = "Added rows have a current value and no original value. Deleting one removes it from the table."
            Case DataRowState.Modified
                _stateNote.Text = "Modified rows retain both versions. Reject Changes restores the original score."
            Case DataRowState.Deleted
                _stateNote.Text = "Deleted rows keep the original version. Accept Changes removes them."
            Case DataRowState.Unchanged
                _stateNote.Text = "Unchanged rows have the same original and current values."
        End Select
    End Sub
End Class
