Public Class BankAccount
    ' Private variable hides the internal data from direct outside manipulation
    Private balance As Decimal

    Public Sub New(initialDeposit As Decimal)
        If initialDeposit >= 0 Then
            balance = initialDeposit
        Else
            balance = 0
        End If
    End Sub

    ' Controlled methods to interact with private data
    Public Sub Deposit(amount As Decimal)
        If amount > 0 Then
            balance += amount
        End If
    End Sub

    Public Function Withdraw(amount As Decimal) As Boolean
        If amount > 0 AndAlso amount <= balance Then
            balance -= amount
            Return True
        End If
        Return False
    End Function

    Public Function GetBalance() As Decimal
        Return balance
    End Function
End Class