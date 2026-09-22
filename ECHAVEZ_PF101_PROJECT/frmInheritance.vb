Public Class frmInheritance

    Private Sub frmInheritance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeManager.ApplyTheme(Me)
        txtTheory.Text = "WEEK 2 - INHERITANCE" & vbCrLf &
                         "A subclass (derived class) inherits properties and methods from a superclass (base class)." & vbCrLf &
                         "Promotes code reuse, extensibility, and hierarchical structure." & vbCrLf & vbCrLf &
                         "Public Class Animal" & vbCrLf &
                         "    Public Overridable Function Speak() As String" & vbCrLf &
                         "        Return ""Animal speaks""" & vbCrLf &
                         "    End Function" & vbCrLf &
                         "End Class" & vbCrLf & vbCrLf &
                         "Public Class Dog" & vbCrLf &
                         "    Inherits Animal" & vbCrLf &
                         "    Public Overrides Function Speak() As String" & vbCrLf &
                         "        Return ""Dog barks: Woof!""" & vbCrLf &
                         "    End Function" & vbCrLf &
                         "End Class"
    End Sub

    ' Helper to instantiate Dog using user input
    Private Function CreateDogInstance() As Dog
        Dim dogName As String = If(String.IsNullOrWhiteSpace(txtDogName.Text), "Buddy", txtDogName.Text.Trim())
        Dim breed As String = If(String.IsNullOrWhiteSpace(txtBreed.Text), "Unknown Breed", txtBreed.Text.Trim())
        Return New Dog(dogName, breed)
    End Function

    Private Sub btnCallEat_Click(sender As Object, e As EventArgs) Handles btnCallEat.Click
        Dim myDog As Dog = CreateDogInstance()
        ' Calling a method inherited directly from the Animal superclass
        lblOutput.Text = "[Base Class Method]" & vbCrLf & myDog.Eat()
        lblOutput.ForeColor = Color.DarkSlateBlue
    End Sub

    Private Sub btnCallSpeak_Click(sender As Object, e As EventArgs) Handles btnCallSpeak.Click
        Dim myDog As Dog = CreateDogInstance()
        ' Calling an overridden method defined in the Dog subclass
        lblOutput.Text = "[Overridden Method]" & vbCrLf & myDog.Speak()
        lblOutput.ForeColor = Color.DarkGreen
    End Sub

    Private Sub btnCallFetch_Click(sender As Object, e As EventArgs) Handles btnCallFetch.Click
        Dim myDog As Dog = CreateDogInstance()
        ' Calling a method unique only to the Dog subclass
        lblOutput.Text = "[Derived Unique Method]" & vbCrLf & myDog.Fetch()
        lblOutput.ForeColor = Color.DarkBlue
    End Sub

End Class