Option Strict On

Imports System.Data
Imports System.Globalization
Imports System.IO
Imports Microsoft.Data.Sqlite

Friend NotInheritable Class CatchGameLeaderboard
    Friend Const MaximumNameLength As Integer = 30
    Private ReadOnly _databasePath As String

    Friend Shared ReadOnly Property DefaultDatabasePath As String
        Get
            Return Path.Combine(Path.GetDirectoryName(StudentRecordsStore.DefaultDatabasePath), "CatchGameScores.sqlite3")
        End Get
    End Property

    Friend Sub New(databasePath As String)
        _databasePath = databasePath
    End Sub

    Friend Sub SaveScore(player As String, difficulty As CatchGameDifficulty, score As Integer)
        player = player.Trim()
        If player.Length = 0 Then player = "Player"
        If player.Length > MaximumNameLength Then Throw New ArgumentException("The player name is too long.", NameOf(player))

        Using connection As SqliteConnection = OpenConnection(),
              command As SqliteCommand = connection.CreateCommand()
            command.CommandText = "INSERT INTO CatchGameScores (Player, Difficulty, Score, CompletedUtc) " &
                                  "VALUES ($player, $difficulty, $score, $completed)"
            command.Parameters.Add("$player", SqliteType.Text).Value = player
            command.Parameters.Add("$difficulty", SqliteType.Text).Value = difficulty.ToString()
            command.Parameters.Add("$score", SqliteType.Integer).Value = score
            command.Parameters.Add("$completed", SqliteType.Text).Value = DateTime.UtcNow.ToString("O", CultureInfo.InvariantCulture)
            command.ExecuteNonQuery()
        End Using
    End Sub

    Friend Function ReadTopTen() As DataTable
        Using connection As SqliteConnection = OpenConnection(),
              command As SqliteCommand = connection.CreateCommand()
            command.CommandText =
                "SELECT Player, Difficulty, Score, datetime(CompletedUtc, 'localtime') AS [Local time] " &
                "FROM CatchGameScores ORDER BY Score DESC, Id ASC LIMIT 10"
            Dim scores As New DataTable()
            Using reader As SqliteDataReader = command.ExecuteReader()
                scores.Load(reader)
            End Using
            Return scores
        End Using
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
            Using command As SqliteCommand = connection.CreateCommand()
                command.CommandText =
                    "CREATE TABLE IF NOT EXISTS CatchGameScores (" &
                    "Id INTEGER PRIMARY KEY, Player TEXT NOT NULL, Difficulty TEXT NOT NULL, " &
                    "Score INTEGER NOT NULL CHECK (Score >= 0), CompletedUtc TEXT NOT NULL) STRICT"
                command.ExecuteNonQuery()
            End Using
            Return connection
        Catch
            connection.Dispose()
            Throw
        End Try
    End Function
End Class
