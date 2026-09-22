Public Class Person
    Public Property Name As String
    Public Property Age As Integer

    Public Sub New(personName As String, personAge As Integer)
        Me.Name = personName
        Me.Age = personAge
    End Sub

    Public Function GetInfo() As String
        Return "Instance created in RAM -> Name: " & Name & " | Age: " & Age.ToString()
    End Function
End Class