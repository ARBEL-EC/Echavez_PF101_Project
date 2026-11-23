Option Strict On

Imports System.Data
Imports System.Globalization
Imports System.IO
Imports Microsoft.Data.Sqlite

Friend NotInheritable Class CatchGameLeaderboard
    Friend Const MaximumNameLength As Integer = 30
    Private ReadOnly _databasePath As String
    Private Shared ReadOnly LogLock As New Object()

    Friend Shared ReadOnly Property DefaultDatabasePath As String
        Get
            Return Path.Combine(Path.GetDirectoryName(StudentRecordsStore.DefaultDatabasePath), "CatchGameScores.sqlite3")
        End Get
    End Property

    Friend Sub New(databasePath As String)
        _databasePath = databasePath
    End Sub

    Private _lastDiagnosticPath As String

    Friend ReadOnly Property LastDiagnosticPath As String
        Get
            Return _lastDiagnosticPath
        End Get
    End Property

    Friend Sub SaveScore(player As String, difficulty As CatchGameDifficulty, score As Integer)
        player = If(player, String.Empty).Trim()
        If player.Length = 0 Then player = "Player"
        If player.Length > MaximumNameLength Then Throw New ArgumentException("The player name is too long.", NameOf(player))

        Dim stepName As String = "open database"
        Try
            Using connection As SqliteConnection = OpenConnection()
                stepName = "initialize or check schema"
                EnsureSchema(connection)
                stepName = "insert score"
                Using command As SqliteCommand = connection.CreateCommand()
                    command.CommandText = "INSERT INTO CatchGameScores (Player, Difficulty, Score, CompletedUtc) " &
                                          "VALUES ($player, $difficulty, $score, $completed)"
                    command.Parameters.Add("$player", SqliteType.Text).Value = player
                    command.Parameters.Add("$difficulty", SqliteType.Text).Value = difficulty.ToString()
                    command.Parameters.Add("$score", SqliteType.Integer).Value = score
                    command.Parameters.Add("$completed", SqliteType.Text).Value = DateTime.UtcNow.ToString("O", CultureInfo.InvariantCulture)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception When IsStorageError(ex)
            RecordFailure("Save score", stepName, ex)
            Throw
        End Try
    End Sub

    Friend Function ReadTopTen() As DataTable
        Dim stepName As String = "open database"
        Try
            Using connection As SqliteConnection = OpenConnection()
                stepName = "initialize or check schema"
                EnsureSchema(connection)
                stepName = "query scores"
                Using command As SqliteCommand = connection.CreateCommand()
                    command.CommandText =
                        "SELECT Player, Difficulty, Score, COALESCE(datetime(CompletedUtc, 'localtime'), 'Unknown') AS [Local time] " &
                        "FROM CatchGameScores ORDER BY Score DESC, Id ASC LIMIT 10"
                    Using reader As SqliteDataReader = command.ExecuteReader()
                        Dim scores As New DataTable()
                        scores.Load(reader)
                        Return scores
                    End Using
                End Using
            End Using
        Catch ex As Exception When IsStorageError(ex)
            RecordFailure("Read top ten", stepName, ex)
            Throw
        End Try
    End Function

    Friend Shared Function IsStorageError(ex As Exception) As Boolean
        Return TypeOf ex Is SqliteException OrElse TypeOf ex Is IOException OrElse TypeOf ex Is InvalidDataException OrElse
               TypeOf ex Is UnauthorizedAccessException OrElse TypeOf ex Is Security.SecurityException OrElse
               TypeOf ex Is TypeInitializationException OrElse TypeOf ex Is DllNotFoundException OrElse
               TypeOf ex Is BadImageFormatException OrElse TypeOf ex Is EntryPointNotFoundException
    End Function

    Private Function OpenConnection() As SqliteConnection
        If Not Path.IsPathRooted(_databasePath) Then Throw New IOException("Local AppData is unavailable.")
        Directory.CreateDirectory(Path.GetDirectoryName(_databasePath))
        Dim settings As New SqliteConnectionStringBuilder With {
            .DataSource = _databasePath,
            .Mode = SqliteOpenMode.ReadWriteCreate,
            .Pooling = False,
            .DefaultTimeout = 2
        }
        Dim connection As New SqliteConnection(settings.ToString())
        Try
            connection.Open()
            Return connection
        Catch
            connection.Dispose()
            Throw
        End Try
    End Function

    Private Shared Sub EnsureSchema(connection As SqliteConnection)
        Dim columns As HashSet(Of String) = ReadColumns(connection)
        If columns.Contains("Difficulty") AndAlso columns.Contains("CompletedUtc") Then
            CheckRequiredColumns(columns)
            Return
        End If

        ' Recheck under a write transaction so concurrent app instances cannot add the same column twice.
        Using transaction As SqliteTransaction = connection.BeginTransaction(),
              command As SqliteCommand = connection.CreateCommand()
            columns = ReadColumns(connection, transaction)
            command.Transaction = transaction
            If columns.Count = 0 Then
                command.CommandText =
                    "CREATE TABLE CatchGameScores (" &
                    "Id INTEGER PRIMARY KEY, Player TEXT NOT NULL, Difficulty TEXT NOT NULL, " &
                    "Score INTEGER NOT NULL CHECK (Score >= 0), CompletedUtc TEXT NOT NULL) STRICT"
                command.ExecuteNonQuery()
            Else
                CheckRequiredColumns(columns)
                If Not columns.Contains("Difficulty") Then
                    command.CommandText = "ALTER TABLE CatchGameScores ADD COLUMN Difficulty TEXT NOT NULL DEFAULT 'Unknown'"
                    command.ExecuteNonQuery()
                End If
                If Not columns.Contains("CompletedUtc") Then
                    command.CommandText = "ALTER TABLE CatchGameScores ADD COLUMN CompletedUtc TEXT"
                    command.ExecuteNonQuery()
                End If
            End If
            transaction.Commit()
        End Using
    End Sub

    Private Shared Function ReadColumns(connection As SqliteConnection,
                                        Optional transaction As SqliteTransaction = Nothing) As HashSet(Of String)
        Dim names As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)
        Using command As SqliteCommand = connection.CreateCommand()
            command.Transaction = transaction
            command.CommandText = "PRAGMA table_info(CatchGameScores)"
            Using reader As SqliteDataReader = command.ExecuteReader()
                While reader.Read()
                    names.Add(reader.GetString(1))
                End While
            End Using
        End Using
        Return names
    End Function

    Private Shared Sub CheckRequiredColumns(columns As HashSet(Of String))
        If Not columns.Contains("Id") OrElse Not columns.Contains("Player") OrElse Not columns.Contains("Score") Then
            Throw New InvalidDataException("The existing CatchGameScores table lacks Id, Player, or Score. It was left intact.")
        End If
    End Sub

    Private Sub RecordFailure(operation As String, stepName As String, ex As Exception)
        _lastDiagnosticPath = Nothing
        Dim baseDirectory As String = AppDomain.CurrentDomain.BaseDirectory
        Dim rid As String = If(Environment.Is64BitProcess, "win-x64", "win-x86")
        Dim libraryPath As String = Path.Combine(baseDirectory, "runtimes", rid, "native", "e_sqlite3.dll")
        Dim sqlite As SqliteException = TryCast(ex, SqliteException)
        Dim errorCode As String = If(sqlite Is Nothing, "", " SQLite code " & sqlite?.SqliteErrorCode.ToString() &
                                                           "/" & sqlite?.SqliteExtendedErrorCode.ToString())
        Dim report As String =
            DateTime.UtcNow.ToString("O", CultureInfo.InvariantCulture) & " " & operation & " · " & stepName & errorCode &
            Environment.NewLine & "Database: " & _databasePath &
            Environment.NewLine & "Process: " & rid & " · CLR " & Environment.Version.ToString() &
            Environment.NewLine & "Native library present: " & File.Exists(libraryPath).ToString() & " · " & libraryPath &
            Environment.NewLine & ex.ToString() & Environment.NewLine & Environment.NewLine
        Debug.WriteLine(report)

        SyncLock LogLock
            If Path.IsPathRooted(_databasePath) Then
                _lastDiagnosticPath = TryAppendDiagnostic(Function() Path.Combine(Path.GetDirectoryName(_databasePath), "LeaderboardDiagnostics.log"), report)
            End If
            If _lastDiagnosticPath Is Nothing Then
                _lastDiagnosticPath = TryAppendDiagnostic(Function() Path.Combine(Path.GetTempPath(), "PF101-LeaderboardDiagnostics.log"), report)
            End If
        End SyncLock
    End Sub

    Private Shared Function TryAppendDiagnostic(resolvePath As Func(Of String), report As String) As String
        Try
            Dim path As String = resolvePath()
            File.AppendAllText(path, report)
            Return path
        Catch ex As Exception When TypeOf ex Is IOException OrElse TypeOf ex Is UnauthorizedAccessException OrElse
                                   TypeOf ex Is Security.SecurityException OrElse TypeOf ex Is ArgumentException
            Debug.WriteLine(ex.ToString())
            Return Nothing
        End Try
    End Function
End Class
