Public Class frmPolymorphism

    Private Sub frmPolymorphism_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeManager.ApplyTheme(Me)
        ' Populate theory box from Week 2 slides 10-13
        txtTheory.Text = "WEEK 2 - POLYMORPHISM & INTERFACES" & vbCrLf &
                         "Polymorphism allows objects of different classes to be treated as instances of a common superclass." & vbCrLf & vbCrLf &
                         "' Dynamic Binding:" & vbCrLf &
                         "Dim a As Animal" & vbCrLf &
                         "a = New Dog()" & vbCrLf &
                         "a.Speak() ' Outputs: Dog barks" & vbCrLf & vbCrLf &
                         "a = New Cat()" & vbCrLf &
                         "a.Speak() ' Outputs: Cat meows" & vbCrLf & vbCrLf &
                         "' Interfaces define contracts that classes implement:" & vbCrLf &
                         "Public Interface IPrintable" & vbCrLf &
                         "    Function Print() As String" & vbCrLf &
                         "End Interface"

        ' Populate Dropdown items
        cboType.Items.Clear()
        cboType.Items.Add("Base Animal")
        cboType.Items.Add("Dog (Subclass)")
        cboType.Items.Add("Cat (Subclass)")
        cboType.SelectedIndex = 1 ' Default to Dog
    End Sub

    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        ' Polymorphic reference: Variable declared as base type 'Animal'
        Dim myAnimal As Animal

        Select Case cboType.SelectedIndex
            Case 0
                myAnimal = New Animal()
            Case 1
                myAnimal = New Dog()
            Case 2
                myAnimal = New Cat()
            Case Else
                myAnimal = New Animal()
        End Select

        ' The exact method executed depends on the actual instance type stored at runtime
        lblOutput.Text = "[Base Reference: Animal]" & vbCrLf &
                         "Runtime Type: " & myAnimal.GetType().Name & vbCrLf &
                         "Result: " & myAnimal.Speak()
        lblOutput.ForeColor = Color.DarkSlateBlue
    End Sub

    Private Sub btnPrintDoc_Click(sender As Object, e As EventArgs) Handles btnPrintDoc.Click
        ' Testing Interface implementation
        Dim printableItem As IPrintable = New Document("PF101 Midterm Project Syllabus")
        lblOutput.Text = "[Interface Contract: IPrintable]" & vbCrLf & printableItem.Print()
        lblOutput.ForeColor = Color.DarkGreen
    End Sub

    Private Sub lblOutput_Click(sender As Object, e As EventArgs) Handles lblOutput.Click

    End Sub

    Private Sub cboType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboType.SelectedIndexChanged

    End Sub
End Class