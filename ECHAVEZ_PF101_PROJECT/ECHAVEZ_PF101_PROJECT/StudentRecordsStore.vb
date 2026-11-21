Option Strict On

Imports System.Data
Imports System.IO
Imports Microsoft.Data.Sqlite

Friend NotInheritable Class StudentPerformanceRecord
    Friend Const MaximumTextLength As Integer = 120

    Friend ReadOnly Property StudentName As String
    Friend ReadOnly Property Assessment As String
    Friend ReadOnly Property Score As Decimal

    Friend Sub New(studentName As String, assessment As String, score As Decimal)
        Me.StudentName = studentName.Trim()
        Me.Assessment = assessment.Trim()
        Me.Score = score

        If Me.StudentName.Length = 0 OrElse Me.StudentName.Length > MaximumTextLength OrElse
           Me.Assessment.Length = 0 OrElse Me.Assessment.Length > MaximumTextLength Then
            Throw New ArgumentException("Enter a student name and an assessment of 1 to 120 characters each.")
        End If
        If score < 0D OrElse score > 100D OrElse Decimal.Round(score, 2) <> score Then
            Throw New ArgumentException("Enter a score from 0 to 100 with up to two decimal places.")
        End If
    End Sub
End Class

Friend NotInheritable Class StudentRecordsStore
    Friend Const TableName As String = "StudentPerformance"
    Private ReadOnly _databasePath As String
    Private _initialized As Boolean

    Friend Shared ReadOnly Property DefaultDatabasePath As String
        Get
            Return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                                "Echavez_PF101_Project", "StudentPerformance.sqlite3")
        End Get
    End Property

    Friend Sub New(databasePath As String)
        _databasePath = databasePath
    End Sub

    Private Function OpenConnection() As SqliteConnection
        If Not Path.IsPathRooted(_databasePath) Then
            Throw New IOException("The per-user application data directory is unavailable.")
        End If

        If Not _initialized Then Directory.CreateDirectory(Path.GetDirectoryName(_databasePath))
        Dim settings As New SqliteConnectionStringBuilder With {
            .DataSource = _databasePath,
            .Mode = If(_initialized, SqliteOpenMode.ReadWrite, SqliteOpenMode.ReadWriteCreate),
            .Pooling = False,
            .DefaultTimeout = 2
        }
        Dim connection As New SqliteConnection(settings.ToString())
        Try
            connection.Open()
            If Not _initialized Then
                Using command As SqliteCommand = connection.CreateCommand()
                    command.CommandText =
                        "CREATE TABLE IF NOT EXISTS StudentPerformance (" &
                        "Id INTEGER PRIMARY KEY AUTOINCREMENT, " &
                        "StudentName TEXT NOT NULL CHECK (length(trim(StudentName)) BETWEEN 1 AND 120), " &
                        "Assessment TEXT NOT NULL CHECK (length(trim(Assessment)) BETWEEN 1 AND 120), " &
                        "ScoreHundredths INTEGER NOT NULL CHECK (ScoreHundredths BETWEEN 0 AND 10000), " &
                        "Revision INTEGER NOT NULL DEFAULT 0) STRICT"
                    command.ExecuteNonQuery()
                End Using
                _initialized = True
            End If
            Return connection
        Catch
            connection.Dispose()
            Throw
        End Try
    End Function

    Friend Function ReadRecords(studentName As String) As DataSet
        Using connection As SqliteConnection = OpenConnection(),
              command As SqliteCommand = connection.CreateCommand()
            ' This managed comparison keeps literal substring searches case-insensitive for Unicode names.
            connection.CreateFunction(Of String, String, Boolean)(
                "matches_name",
                Function(name, query) name.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0,
                isDeterministic:=True)
            command.CommandText =
                "SELECT Id, StudentName, Assessment, ScoreHundredths / 100.0 AS Score, Revision " &
                "FROM StudentPerformance WHERE matches_name(StudentName, $name) " &
                "ORDER BY StudentName COLLATE NOCASE, Id"
            command.Parameters.Add("$name", SqliteType.Text).Value = studentName.Trim()

            Dim snapshot As New DataSet("StudentPerformanceRecords")
            Using reader As SqliteDataReader = command.ExecuteReader()
                snapshot.Tables.Add(TableName).Load(reader)
            End Using
            Return snapshot
        End Using
    End Function

    Friend Sub AddRecord(record As StudentPerformanceRecord)
        WriteRecord("INSERT INTO StudentPerformance (StudentName, Assessment, ScoreHundredths) " &
                    "VALUES ($name, $assessment, $score)", record)
    End Sub

    Friend Function UpdateRecord(id As Long, revision As Long, record As StudentPerformanceRecord) As Boolean
        Return WriteRecord("UPDATE StudentPerformance SET StudentName = $name, Assessment = $assessment, " &
                           "ScoreHundredths = $score, Revision = Revision + 1 WHERE Id = $id AND Revision = $revision",
                           record, id, revision) = 1
    End Function

    Friend Function DeleteRecord(id As Long, revision As Long) As Boolean
        Return WriteRecord("DELETE FROM StudentPerformance WHERE Id = $id AND Revision = $revision",
                           Nothing, id, revision) = 1
    End Function

    Private Function WriteRecord(sql As String, record As StudentPerformanceRecord,
                                 Optional id As Long? = Nothing, Optional revision As Long = 0) As Integer
        Using connection As SqliteConnection = OpenConnection(),
              command As SqliteCommand = connection.CreateCommand()
            command.CommandText = sql
            If record IsNot Nothing Then
                command.Parameters.Add("$name", SqliteType.Text).Value = record.StudentName
                command.Parameters.Add("$assessment", SqliteType.Text).Value = record.Assessment
                command.Parameters.Add("$score", SqliteType.Integer).Value = CInt(record.Score * 100D)
            End If
            If id.HasValue Then
                command.Parameters.Add("$id", SqliteType.Integer).Value = id.Value
                command.Parameters.Add("$revision", SqliteType.Integer).Value = revision
            End If
            Return command.ExecuteNonQuery()
        End Using
    End Function
End Class
