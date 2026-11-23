Option Strict On

Imports System.Data

Friend NotInheritable Class DataRowPractice
    Friend ReadOnly Property Data As New DataSet("Practice")
    Friend ReadOnly Property Table As DataTable
    Private _nextSample As Integer

    Friend Sub New()
        Table = Data.Tables.Add("PracticeScores")
        Table.Columns.Add("Sample", GetType(String))
        Table.Columns.Add("Score", GetType(Integer))
        Reset()
    End Sub

    Friend Sub Reset()
        Table.Clear()
        Table.Rows.Add("Amber", 72)
        Table.Rows.Add("Cobalt", 81)
        Table.Rows.Add("Jade", 90)
        Data.AcceptChanges()
        _nextSample = 0
    End Sub

    Friend Function AddSample() As DataRow
        _nextSample += 1
        Return Table.Rows.Add("New sample " & _nextSample.ToString(), 65)
    End Function

    Friend Sub ChangeScore(row As DataRow, score As Integer)
        If CInt(row("Score")) <> score Then row("Score") = score
    End Sub
End Class
