Public Class frmClassesObjects
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtTheory.TextChanged

    End Sub

    Private Sub frmClassesObjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeManager.ApplyTheme(Me)
        ' Populates the slide code snippet into the theory box on load
        txtTheory.Text = "WEEK 2 - INTRODUCTION TO OOP" & vbCrLf &
                         "Classes describe the type of objects, while objects are usable instances of classes." & vbCrLf & vbCrLf &
                         "Public Class Person" & vbCrLf &
                         "    Public Name As String" & vbCrLf &
                         "    Public Age As Integer" & vbCrLf &
                         "End Class" & vbCrLf & vbCrLf &
                         "' Instantiation:" & vbCrLf &
                         "Dim p As New Person()" & vbCrLf &
                         "p.Name = txtName.Text" & vbCrLf &
                         "p.Age = CInt(txtAge.Text)"
    End Sub

    Private Sub btnInstantiate_Click(sender As Object, e As EventArgs) Handles btnInstantiate.Click
        Dim ageInput As Integer

        ' Input validation using slide rules
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Please enter a valid Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtName.Focus()
            Return
        End If

        If Integer.TryParse(txtAge.Text, ageInput) AndAlso ageInput >= 0 Then
            ' Instantiating the object from the Person class
            Dim p As New Person(txtName.Text.Trim(), ageInput)
            lblResult.Text = p.GetInfo()
            lblResult.ForeColor = Color.DarkGreen
        Else
            MessageBox.Show("Please enter a valid numeric age.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAge.Focus()
        End If
    End Sub

End Class