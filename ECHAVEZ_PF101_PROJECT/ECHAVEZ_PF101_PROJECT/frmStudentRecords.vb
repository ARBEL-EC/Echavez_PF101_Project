Option Strict On

Imports System.Data
Imports System.Globalization
Imports System.IO
Imports Microsoft.Data.Sqlite

Public Class frmStudentRecords
    Inherits Form

    Private ReadOnly _store As New StudentRecordsStore(StudentRecordsStore.DefaultDatabasePath)
    Private ReadOnly _tabs As New TabControl With {.Dock = DockStyle.Fill}
    Private ReadOnly _nameInput As New TextBox With {.MaxLength = StudentPerformanceRecord.MaximumTextLength, .AccessibleName = "Student name"}
    Private ReadOnly _assessmentInput As New TextBox With {.MaxLength = StudentPerformanceRecord.MaximumTextLength, .AccessibleName = "Assessment"}
    Private ReadOnly _scoreInput As New TextBox With {.MaxLength = 12, .AccessibleName = "Score out of 100"}
    Private ReadOnly _searchInput As New TextBox With {.Width = 240, .MaxLength = 120, .AccessibleName = "Search by student name"}
    Private ReadOnly _status As New Label With {.AutoSize = True, .Dock = DockStyle.Fill}
    Private ReadOnly _snapshotStatus As New Label With {.AutoSize = True, .Dock = DockStyle.Top, .Padding = New Padding(4)}
    Private ReadOnly _saveButton As New Button With {.Text = "Add Record", .AutoSize = True}
    Private ReadOnly _deleteButton As New Button With {.Text = "Delete Record", .AutoSize = True, .Enabled = False}
    Private ReadOnly _grid As New DataGridView With {
        .Dock = DockStyle.Fill, .ReadOnly = True, .AllowUserToAddRows = False, .AllowUserToDeleteRows = False,
        .AutoGenerateColumns = False, .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
        .SelectionMode = DataGridViewSelectionMode.FullRowSelect, .MultiSelect = False, .RowHeadersVisible = False,
        .AccessibleName = "Student performance records"
    }
    Private _selectedRecord As DataRowView
    Private _rebinding As Boolean
    Private _searchTerm As String = String.Empty

    Friend Property StartWeek As Integer = 13

    Public Sub New()
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.Font = ThemeManager.GetFont("Segoe UI", 9.5F, FontStyle.Regular)
        Me.Controls.Add(_tabs)
        BuildRecordsTab()
        AddReadingTab("Week 14 - DataSets",
            "A DataReader streams rows while the SQLite connection is open. DataTable.Load reads those rows into the StudentPerformance table in a DataSet." &
            vbCrLf & vbCrLf &
            "The grid is bound to that disconnected table. The StudentPerformanceRecord class validates each new or edited record. " &
            "Parameterized INSERT, UPDATE, and DELETE commands write to SQLite, then the app reads a fresh snapshot." &
            vbCrLf & vbCrLf &
            "Add a record, search by name, and compare the row count here. Reopen the app to verify the data came from disk.", _snapshotStatus)
        AddReadingTab("Week 15 - Offline deployment",
            "Build the Release ZIP with Package-Release.ps1 on the development machine. Extract the entire archive on a Windows computer with the .NET Framework runtime." &
            vbCrLf & vbCrLf &
            "Open Student Performance Records. The first visit creates the table and database in your Windows profile. Add a record, close the app, " &
            "and reopen it to confirm persistence. Run the same exercise offline to verify that the packaged SQLite libraries and local file are sufficient." &
            vbCrLf & vbCrLf & "Database file" & vbCrLf & StudentRecordsStore.DefaultDatabasePath)
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        If DesignMode Then Return
        _tabs.SelectedIndex = Math.Max(0, Math.Min(2, StartWeek - 13))
        ThemeManager.ApplyTheme(Me)
        RefreshRecords()
    End Sub

    Private Sub BuildRecordsTab()
        Dim tab As New TabPage("Week 13 - Student Records")
        Dim layout As New TableLayoutPanel With {.Dock = DockStyle.Fill, .Padding = New Padding(12), .ColumnCount = 1, .RowCount = 6}
        layout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100))
        For index As Integer = 0 To 3
            layout.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        Next
        layout.RowStyles.Add(New RowStyle(SizeType.Percent, 100))
        layout.RowStyles.Add(New RowStyle(SizeType.AutoSize))

        Dim heading As New Label With {.Text = "Student Performance Records", .AutoSize = True,
                                      .Font = ThemeManager.GetFont("Segoe UI", 17.0F, FontStyle.Bold)}
        layout.Controls.Add(heading, 0, 0)

        Dim fields As New TableLayoutPanel With {.AutoSize = True, .Dock = DockStyle.Fill, .ColumnCount = 3, .RowCount = 2}
        fields.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45))
        fields.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40))
        fields.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15))
        Dim fieldLabels As String() = {"Student name", "Assessment", "Score / 100"}
        Dim inputs As TextBox() = {_nameInput, _assessmentInput, _scoreInput}
        For index As Integer = 0 To inputs.Length - 1
            fields.Controls.Add(New Label With {.Text = fieldLabels(index), .AutoSize = True}, index, 0)
            inputs(index).Dock = DockStyle.Fill
            fields.Controls.Add(inputs(index), index, 1)
        Next
        layout.Controls.Add(fields, 0, 1)

        Dim clearButton As New Button With {.Text = "Clear Selection", .AutoSize = True}
        Dim recordActions As New FlowLayoutPanel With {.AutoSize = True, .Dock = DockStyle.Fill}
        recordActions.Controls.AddRange(New Control() {_saveButton, _deleteButton, clearButton})
        layout.Controls.Add(recordActions, 0, 2)
        AddHandler _saveButton.Click, AddressOf SaveRecord
        AddHandler _deleteButton.Click, AddressOf DeleteRecord
        AddHandler clearButton.Click, Sub(sender, args) ResetEditor()

        Dim searchButton As New Button With {.Text = "Search", .AutoSize = True}
        Dim showAllButton As New Button With {.Text = "Show All / Refresh", .AutoSize = True}
        Dim searchActions As New FlowLayoutPanel With {.AutoSize = True, .Dock = DockStyle.Fill}
        searchActions.Controls.AddRange(New Control() {
            New Label With {.Text = "Student name", .AutoSize = True, .Margin = New Padding(3, 9, 3, 3)},
            _searchInput, searchButton, showAllButton
        })
        layout.Controls.Add(searchActions, 0, 3)
        AddHandler searchButton.Click,
            Sub(sender, args)
                _searchTerm = _searchInput.Text.Trim()
                RefreshRecords()
            End Sub
        AddHandler showAllButton.Click,
            Sub(sender, args)
                _searchInput.Clear()
                _searchTerm = String.Empty
                RefreshRecords()
            End Sub

        _grid.Columns.AddRange(
            New DataGridViewTextBoxColumn With {.DataPropertyName = "StudentName", .HeaderText = "Student name", .FillWeight = 44},
            New DataGridViewTextBoxColumn With {.DataPropertyName = "Assessment", .HeaderText = "Assessment", .FillWeight = 40},
            New DataGridViewTextBoxColumn With {.DataPropertyName = "Score", .HeaderText = "Score", .FillWeight = 16,
                                               .DefaultCellStyle = New DataGridViewCellStyle With {.Format = "0.00"}}
        )
        AddHandler _grid.SelectionChanged, AddressOf SelectRecord
        layout.Controls.Add(_grid, 0, 4)
        layout.Controls.Add(_status, 0, 5)
        tab.Controls.Add(layout)
        _tabs.TabPages.Add(tab)
    End Sub

    Private Sub AddReadingTab(title As String, content As String, Optional status As Label = Nothing)
        Dim tab As New TabPage(title) With {.Padding = New Padding(12)}
        tab.Controls.Add(New TextBox With {
            .Text = content, .Dock = DockStyle.Fill, .Multiline = True, .ReadOnly = True, .ScrollBars = ScrollBars.Vertical
        })
        If status IsNot Nothing Then tab.Controls.Add(status)
        _tabs.TabPages.Add(tab)
    End Sub

    Private Sub RefreshRecords(Optional message As String = "")
        Dim loaded As Boolean = RunDatabaseOperation(
            Sub()
                Dim snapshot As DataSet = _store.ReadRecords(_searchTerm)
                Dim records As DataTable = snapshot.Tables(StudentRecordsStore.TableName)
                _rebinding = True
                Try
                    _grid.DataSource = records
                    ResetEditor()
                Finally
                    _rebinding = False
                End Try
                _snapshotStatus.Text = "Current snapshot   " & snapshot.Tables.Count.ToString() &
                                       " table, " & records.Rows.Count.ToString() & " matching rows."
                _status.Text = If(message.Length = 0, "", message & " ") &
                               "SQLite connected. " & records.Rows.Count.ToString() & " matching records."
            End Sub, If(message.Length = 0, "", message & " Refresh failed. "))
        If Not loaded Then _snapshotStatus.Text = _status.Text
    End Sub

    Private Sub SelectRecord(sender As Object, e As EventArgs)
        If _rebinding OrElse _grid.SelectedRows.Count = 0 Then Return
        _selectedRecord = TryCast(_grid.SelectedRows(0).DataBoundItem, DataRowView)
        If _selectedRecord Is Nothing Then Return
        _nameInput.Text = CStr(_selectedRecord("StudentName"))
        _assessmentInput.Text = CStr(_selectedRecord("Assessment"))
        _scoreInput.Text = Convert.ToDouble(_selectedRecord("Score"), CultureInfo.InvariantCulture).ToString("0.00")
        _saveButton.Text = "Save Changes"
        _deleteButton.Enabled = True
    End Sub

    Private Sub ResetEditor()
        _selectedRecord = Nothing
        _grid.ClearSelection()
        _nameInput.Clear()
        _assessmentInput.Clear()
        _scoreInput.Clear()
        _saveButton.Text = "Add Record"
        _deleteButton.Enabled = False
    End Sub

    Private Sub SaveRecord(sender As Object, e As EventArgs)
        Dim score As Decimal
        If Not Decimal.TryParse(_scoreInput.Text.Trim(), NumberStyles.AllowLeadingSign Or NumberStyles.AllowDecimalPoint,
                                CultureInfo.CurrentCulture, score) Then
            _status.Text = "Enter a score from 0 to 100 with up to two decimal places."
            _scoreInput.Focus()
            Return
        End If
        Dim record As StudentPerformanceRecord
        Try
            record = New StudentPerformanceRecord(_nameInput.Text, _assessmentInput.Text, score)
        Catch ex As ArgumentException
            _status.Text = ex.Message
            Return
        End Try

        Dim message As String = ""
        If RunDatabaseOperation(
            Sub()
                If _selectedRecord Is Nothing Then
                    _store.AddRecord(record)
                    message = "Record added."
                ElseIf _store.UpdateRecord(CLng(_selectedRecord("Id")), CLng(_selectedRecord("Revision")), record) Then
                    message = "Record updated."
                Else
                    message = "The selected record changed elsewhere. Select the latest version and try again."
                End If
            End Sub) Then
            ResetEditor()
            RefreshRecords(message)
        End If
    End Sub

    Private Sub DeleteRecord(sender As Object, e As EventArgs)
        If _selectedRecord Is Nothing Then Return
        Dim recordName As String = CStr(_selectedRecord("StudentName"))
        Dim assessment As String = CStr(_selectedRecord("Assessment"))
        If MessageBox.Show(Me, "Delete the saved record for " & recordName & " (" & assessment & ")?",
                           "Delete Student Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                           MessageBoxDefaultButton.Button2) <> DialogResult.Yes Then Return

        Dim message As String = ""
        If RunDatabaseOperation(
            Sub()
                message = If(_store.DeleteRecord(CLng(_selectedRecord("Id")), CLng(_selectedRecord("Revision"))),
                             "Record deleted.", "The selected record changed elsewhere. Select the latest version and try again.")
            End Sub) Then
            ResetEditor()
            RefreshRecords(message)
        End If
    End Sub

    Private Function RunDatabaseOperation(operation As Action, Optional prefix As String = "") As Boolean
        Try
            operation()
            Return True
        Catch ex As SqliteException
            Debug.WriteLine("PF101 database error: " & ex.Message)
            Select Case ex.SqliteErrorCode
                Case 5, 6
                    _status.Text = prefix & "The student database is busy. Try again."
                Case 8, 10, 13, 14
                    _status.Text = prefix & "SQLite could not access the student database. Check Local AppData permissions and available disk space."
                Case Else
                    _status.Text = prefix & "The student database could not be read or updated. If the problem persists, check or restore the database file."
            End Select
        Catch ex As Exception When TypeOf ex Is DllNotFoundException OrElse TypeOf ex Is BadImageFormatException OrElse
                                   TypeOf ex Is TypeInitializationException OrElse TypeOf ex Is FileNotFoundException OrElse
                                   TypeOf ex Is EntryPointNotFoundException
            Debug.WriteLine(ex.ToString())
            _status.Text = prefix & "SQLite could not start. Extract the complete Release ZIP and verify that it includes both native libraries."
        Catch ex As Exception When TypeOf ex Is IOException OrElse TypeOf ex Is UnauthorizedAccessException OrElse
                                   TypeOf ex Is Security.SecurityException
            Debug.WriteLine(ex.ToString())
            _status.Text = prefix & "Could not access the database folder. Verify that you can write to your Local AppData."
        End Try
        Return False
    End Function
End Class
