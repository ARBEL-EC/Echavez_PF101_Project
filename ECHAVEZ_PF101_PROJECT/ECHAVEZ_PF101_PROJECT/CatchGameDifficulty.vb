Option Strict On

Friend Enum CatchGameDifficulty
    Easy
    Normal
    Hard
End Enum

Friend Module CatchGamePace
    Private Const LevelDurationMilliseconds As Long = 20000
    Private Const MaximumLevel As Integer = 8

    Friend Function LevelAt(activeMilliseconds As Long) As Integer
        Return CInt(Math.Min(MaximumLevel, 1 + activeMilliseconds \ LevelDurationMilliseconds))
    End Function

    Friend Function SpawnInterval(difficulty As CatchGameDifficulty, level As Integer) As Integer
        Dim initialInterval As Integer = 1100 - 200 * CInt(difficulty)
        Return Math.Max(300, initialInterval - (level - 1) * 75)
    End Function

    Friend Function MinimumFallSpeed(difficulty As CatchGameDifficulty, level As Integer) As Integer
        Return 2 + CInt(difficulty) + (level - 1) \ 2
    End Function
End Module
