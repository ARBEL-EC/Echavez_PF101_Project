Option Strict On

Friend NotInheritable Class ReviewQuestion
    Friend ReadOnly Property Topic As String
    Friend ReadOnly Property Prompt As String
    Friend ReadOnly Property Choices As IReadOnlyList(Of String)
    Friend ReadOnly Property CorrectChoice As Integer
    Friend ReadOnly Property Explanation As String

    Friend Sub New(topic As String, prompt As String, correctChoice As Integer, explanation As String, ParamArray choices As String())
        Me.Topic = topic
        Me.Prompt = prompt
        Me.Choices = Array.AsReadOnly(choices)
        Me.CorrectChoice = correctChoice
        Me.Explanation = explanation
    End Sub
End Class

Friend NotInheritable Class CourseReviewAttempt
    Private ReadOnly _questions As IReadOnlyList(Of ReviewQuestion)
    Private _position As Integer
    Private _answer As Integer?
    Private _score As Integer

    Friend Sub New(questions As ReviewQuestion())
        _questions = Array.AsReadOnly(questions)
    End Sub

    Friend ReadOnly Property Total As Integer
        Get
            Return _questions.Count
        End Get
    End Property

    Friend ReadOnly Property Answered As Integer
        Get
            Return _position + If(_answer.HasValue, 1, 0)
        End Get
    End Property

    Friend ReadOnly Property Score As Integer
        Get
            Return _score
        End Get
    End Property

    Friend ReadOnly Property Answer As Integer?
        Get
            Return _answer
        End Get
    End Property

    Friend ReadOnly Property CurrentQuestion As ReviewQuestion
        Get
            Return If(_position < Total, _questions(_position), Nothing)
        End Get
    End Property

    Friend Function Submit(choice As Integer) As Boolean
        Dim question As ReviewQuestion = CurrentQuestion
        If question Is Nothing OrElse _answer.HasValue OrElse choice < 0 OrElse choice >= question.Choices.Count Then Return False
        _answer = choice
        If choice = question.CorrectChoice Then _score += 1
        Return True
    End Function

    Friend Sub Advance()
        If Not _answer.HasValue Then Return
        _position += 1
        _answer = Nothing
    End Sub

    Friend Sub Retry()
        _position = 0
        _answer = Nothing
        _score = 0
    End Sub
End Class

Friend Module PracticeQuestions
    Friend Function Midterm() As ReviewQuestion()
        Return {
            New ReviewQuestion("Week 1 · Syllabus grading formula",
                "Class standing is 80 and the term exam score is 90. With class standing worth 60% and the exam worth 40%, what is the term grade?",
                1, "(80 × 0.60) + (90 × 0.40) = 84.", "80", "84", "85", "86"),
            New ReviewQuestion("Week 2 · Classes and instances",
                "Two Student objects are constructed from the same class. What lets each object hold a different name?",
                2, "An instance field or property belongs to each object. The class defines its structure once.",
                "A Shared property", "A Const field", "An instance property", "An Imports statement"),
            New ReviewQuestion("Week 2 · Inheritance and polymorphism",
                "A Shape variable refers to a Circle. Circle overrides the Overridable Describe method. Which implementation runs when Describe is called?",
                0, "Overridden methods are selected using the object's runtime type. The object is a Circle.",
                "Circle.Describe", "Only Shape.Describe", "Both implementations automatically", "Neither unless the variable is recast"),
            New ReviewQuestion("Week 2 · Encapsulation",
                "A score must always be from 0 to 100. Which design lets the class enforce this rule on every update?",
                3, "Keep the field private and validate through a property or method before changing it.",
                "A public field", "A label that says 0 to 100", "A Shared field", "A private field and a validating setter"),
            New ReviewQuestion("Week 3 · The Visual Studio IDE",
                "You want to see which forms and references belong to the active project. Which window should you open?",
                1, "Solution Explorer lists project items and references. The Toolbox lists available controls.",
                "Toolbox", "Solution Explorer", "Immediate Window", "Properties Window"),
            New ReviewQuestion("Week 4 · Form layout",
                "A button should remain the same distance from its parent's lower-right corner as the window resizes. Which setting fits?",
                2, "AnchorStyles.Bottom Or AnchorStyles.Right preserves the distances to those edges.",
                "Dock = Fill", "Anchor = Top Or Left", "Anchor = Bottom Or Right", "TabIndex = 0"),
            New ReviewQuestion("Week 4 · Events",
                "A total should recalculate when a user activates a button. Where does that action belong?",
                0, "A Click handler runs when the user activates the button.",
                "In the button's Click handler", "In the button's Text property", "In a Const declaration", "Only in the form's constructor"),
            New ReviewQuestion("Week 5 · Value types",
                "A receipt adds several amounts such as 19.95 and 8.10. Which numeric type is intended for exact base-ten amounts of this size?",
                3, "Decimal can represent these base-ten values exactly. Double and Single use binary floating point.",
                "Boolean", "Single", "Double", "Decimal"),
            New ReviewQuestion("Week 5 · Scope and lifetime",
                "A variable should be visible only inside one procedure and keep its value between calls. Which declaration fits?",
                1, "A Static local variable retains its value between calls while remaining local to the procedure.",
                "Dim inside the procedure", "Static inside the procedure", "Public field on the form", "Const inside the procedure"),
            New ReviewQuestion("Week 6 · Short-circuit conditions",
                "Why use AndAlso in count > 0 AndAlso total / count >= 50?",
                2, "When count > 0 is False, AndAlso skips the right operand, so division is skipped.",
                "It rounds the quotient", "It always evaluates both operands", "It skips division when the count is zero", "It replaces the division with a comparison"),
            New ReviewQuestion("Week 7 · Array bounds",
                "Dim seats(2, 3) As Boolean declares how many elements in total?",
                0, "VB array declarations use upper bounds. The dimensions contain 3 and 4 elements, so the total is 12.",
                "12", "6", "8", "24"),
            New ReviewQuestion("Week 8 · File dialogs",
                "An OpenFileDialog closes after the user presses Cancel. What should the form do?",
                3, "Only read the selected path after ShowDialog returns DialogResult.OK. Leave the current document intact on Cancel.",
                "Open the previous path", "Clear the document", "Save the current document", "Leave the current document as it is")
        }
    End Function

    Friend Function Finals() As ReviewQuestion()
        Return {
            New ReviewQuestion("Week 10 · Debugging",
                "A calculation compiles and runs but produces the wrong total. What helps you inspect how the accumulator changes?",
                2, "A breakpoint inside the loop lets you step through iterations and inspect the accumulator.",
                "Change the form title", "Remove all variables", "Set a breakpoint in the loop and use Watch", "Reinstall the database provider"),
            New ReviewQuestion("Week 10 · Structured error handling",
                "A file stream should close whether reading succeeds or raises a handled exception. Which block is designed for cleanup in Try/Catch?",
                0, "Finally executes when control leaves the Try block, including after a handled exception. A Using block is also suitable for a disposable stream.",
                "Finally", "Catch only", "ElseIf", "Select Case"),
            New ReviewQuestion("Week 11 · MDI",
                "A note form should open as a child of the MDI workspace. What property identifies that workspace on the child?",
                1, "Set the child's MdiParent to the form whose IsMdiContainer property is True.",
                "OwnerDraw", "MdiParent", "DialogResult", "AutoScroll"),
            New ReviewQuestion("Week 11 · Drawing",
                "A drawing vanishes after its window is covered and uncovered. Where should drawing code render the shape?",
                3, "Draw from the current state using PaintEventArgs.Graphics. Windows can repaint the shape when it invalidates the control.",
                "Only in Form.Load via CreateGraphics", "Only while the mouse moves", "In a label's Text setter", "In the control's Paint handler"),
            New ReviewQuestion("Week 12 · Printing",
                "A PrintPage handler has drawn page 1, and there is text left for page 2. Which setting requests another page?",
                2, "Set PrintPageEventArgs.HasMorePages to True while there is content left to print.",
                "PrintPreviewDialog.Visible = True", "DocumentName = ""Page 2""", "HasMorePages = True", "Cancel = True"),
            New ReviewQuestion("Week 12 · Strings",
                "You are forming a long report by appending one line per record in a loop. Which type can append to a mutable buffer?",
                0, "StringBuilder has a mutable character buffer. Use ToString when you need the final String.",
                "StringBuilder", "String", "Char", "Integer"),
            New ReviewQuestion("Week 13 · ADO.NET",
                "A SELECT command returns rows you want to process sequentially while the connection is open. Which object provides this?",
                1, "A DataReader lets you move through the result rows with Read while the connection is open.",
                "PrintDocument", "DataReader", "ComboBox", "FileDialog"),
            New ReviewQuestion("Week 13 · Parameters",
                "A learner's name includes an apostrophe. How should it be passed to an INSERT command?",
                3, "Bind the value through a command parameter. The DB receives it as data rather than part of the SQL statement.",
                "Remove the apostrophe", "Concatenate it into SQL without quotes", "Rename the column", "Use a typed SQL parameter"),
            New ReviewQuestion("Week 13 · CRUD",
                "One assessment score must change while the other rows remain intact. Which command matches the operation?",
                2, "UPDATE changes existing rows. A WHERE condition on the key scopes the change to the intended row.",
                "INSERT without a key", "DELETE without a filter", "UPDATE with a WHERE clause on the record key", "SELECT COUNT(*)"),
            New ReviewQuestion("Weeks 14–15 · Disconnected data",
                "A grid should allow browsing the rows after the database connection closes. What should the app do before closing?",
                0, "A DataTable or DataSet can keep a disconnected copy of the data. A DataReader needs an open connection.",
                "Load the result into a DataTable", "Keep only the connection string", "Keep calling Read on the closed reader", "Delete the table from the database"),
            New ReviewQuestion("Weeks 14–15 · DataRow states",
                "A previously accepted row is marked with Delete(). Which version can you still read before AcceptChanges?",
                1, "A Deleted row retains its Original values until the deletion is accepted. Its Current version is unavailable.",
                "Current only", "Original only", "Both Current and Proposed", "Only Proposed"),
            New ReviewQuestion("Weeks 14–15 · Data-driven application",
                "You change a cell in a disconnected DataTable and call AcceptChanges. What else is needed to persist it in SQLite?",
                3, "AcceptChanges updates in-memory row states. Execute a database update using the intended changes before accepting them.",
                "Nothing, the database has already changed", "Disable the grid", "Call AcceptChanges a second time", "Send the change using a database command")
        }
    End Function
End Module
