' Base Class (Superclass)
Public Class Animal
    Public Property Name As String

    ' Parameterless constructor for polymorphism
    Public Sub New()
        Me.Name = "Animal"
    End Sub

    ' Parameterized constructor for custom names
    Public Sub New(animalName As String)
        Me.Name = animalName
    End Sub

    Public Function Eat() As String
        Return Name & " is eating generic animal food."
    End Function

    Public Overridable Function Speak() As String
        Return Name & " makes a generic animal sound."
    End Function
End Class

' Derived Class 1: Dog
Public Class Dog
    Inherits Animal

    Public Property Breed As String

    ' Default constructor
    Public Sub New()
        MyBase.New("Dog")
        Me.Breed = "Canine"
    End Sub

    ' Parameterized constructor for inheritance testbench
    Public Sub New(dogName As String, dogBreed As String)
        MyBase.New(dogName)
        Me.Breed = dogBreed
    End Sub

    Public Overrides Function Speak() As String
        Return Name & " (" & Breed & ") barks: Woof! Woof!"
    End Function

    Public Function Fetch() As String
        Return Name & " is joyfully fetching the ball!"
    End Function
End Class

' Derived Class 2: Cat
Public Class Cat
    Inherits Animal

    Public Sub New()
        MyBase.New("Cat")
    End Sub

    Public Sub New(catName As String)
        MyBase.New(catName)
    End Sub

    Public Overrides Function Speak() As String
        Return Name & " meows: Meow! Meow!"
    End Function
End Class

' Interface Contract (Week 2 Slide 13)
Public Interface IPrintable
    Function Print() As String
End Interface

' Class Implementing Interface
Public Class Document
    Implements IPrintable

    Public Property Title As String

    Public Sub New(docTitle As String)
        Me.Title = docTitle
    End Sub

    Public Function Print() As String Implements IPrintable.Print
        Return "Printing Document: [" & Title & "] successfully to spooler."
    End Function
End Class