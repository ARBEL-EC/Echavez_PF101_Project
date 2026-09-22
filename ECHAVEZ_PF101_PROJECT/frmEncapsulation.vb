Public Class frmEncapsulation

    ' Module-level instance of BankAccount
    Private myAccount As New BankAccount(0)

    Private Sub frmEncapsulation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeManager.ApplyTheme(Me)
        txtTheory.Text = "WEEK 2 - ENCAPSULATION" & vbCrLf &
                         "Bundles data and methods into a single class." & vbCrLf &
                         "Protects data integrity by restricting direct access." & vbCrLf & vbCrLf &
                         "Public Class BankAccount" & vbCrLf &
                         "    Private balance As Decimal" & vbCrLf & vbCrLf &
                         "    Public Sub Deposit(amount As Decimal)" & vbCrLf &
                         "        If amount > 0 Then balance += amount" & vbCrLf &
                         "    End Sub" & vbCrLf & vbCrLf &
                         "    Public Function GetBalance() As Decimal" & vbCrLf &
                         "        Return balance" & vbCrLf &
                         "    End Function" & vbCrLf &
                         "End Class"
    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        Dim amt As Decimal
        If Decimal.TryParse(txtAmount.Text, amt) AndAlso amt > 0 Then
            myAccount.Deposit(amt)
            lblStatus.Text = "Status: Successfully deposited PHP " & amt.ToString("N2")
            lblStatus.ForeColor = Color.DarkGreen
            UpdateBalanceDisplay()
            txtAmount.Clear()
        Else
            MessageBox.Show("Please enter a valid positive deposit amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        Dim amt As Decimal
        If Decimal.TryParse(txtAmount.Text, amt) AndAlso amt > 0 Then
            If myAccount.Withdraw(amt) Then
                lblStatus.Text = "Status: Successfully withdrew PHP " & amt.ToString("N2")
                lblStatus.ForeColor = Color.DarkGreen
                UpdateBalanceDisplay()
                txtAmount.Clear()
            Else
                lblStatus.Text = "Status: Insufficient balance for this withdrawal!"
                lblStatus.ForeColor = Color.Red
            End If
        Else
            MessageBox.Show("Please enter a valid positive withdrawal amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnCheckBalance_Click(sender As Object, e As EventArgs) Handles btnCheckBalance.Click
        UpdateBalanceDisplay()
        lblStatus.Text = "Status: Balance refreshed."
        lblStatus.ForeColor = Color.Navy
    End Sub

    Private Sub UpdateBalanceDisplay()
        lblBalance.Text = "Current Balance: PHP " & myAccount.GetBalance().ToString("N2")
    End Sub

End Class