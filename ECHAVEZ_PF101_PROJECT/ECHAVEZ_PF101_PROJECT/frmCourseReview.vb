Option Strict On

Public Class frmCourseReview
    Inherits Form

    Private ReadOnly _attempt As CourseReviewAttempt
    Private ReadOnly _progress As New ProgressBar With {.Dock = DockStyle.Fill, .Height = 16}
    Private ReadOnly _count As New Label With {.AutoSize = True}
    Private ReadOnly _question As New Label With {.AutoSize = True}
    Private ReadOnly _explanation As New Label With {.AutoSize = True, .Margin = New Padding(3, 12, 3, 8)}
    Private ReadOnly _answers As New FlowLayoutPanel With {
        .AutoSize = True, .FlowDirection = FlowDirection.TopDown, .WrapContents = False, .Dock = DockStyle.Fill
    }
    Private ReadOnly _choices(3) As RadioButton
    Private ReadOnly _checkButton As New Button With {.Text = "Check Answer", .AutoSize = True}
    Private ReadOnly _nextButton As New Button With {.Text = "Next Question", .AutoSize = True}

    Public Sub New()
        Me.New("Midterm Practice", New CourseReviewAttempt(PracticeQuestions.Midterm()))
    End Sub

    Friend Sub New(title As String, attempt As CourseReviewAttempt)
        _attempt = attempt
        AutoScaleMode = AutoScaleMode.Font
        Dim heading As New Label With {
            .Text = title, .AutoSize = True, .Font = ThemeManager.GetFont("Segoe UI", 17.0F, FontStyle.Bold)
        }
        Dim practiceNote As New Label With {.Text = "Practice questions only. Unofficial examination preparation.", .AutoSize = True}
        _progress.AccessibleName = "Quiz progress"
        _progress.Maximum = attempt.Total
        _question.Font = ThemeManager.GetFont("Segoe UI", 11.0F, FontStyle.Bold)

        For index As Integer = 0 To _choices.Length - 1
            Dim choice As New RadioButton With {.AutoSize = True, .Margin = New Padding(4, 5, 4, 5)}
            _choices(index) = choice
            _answers.Controls.Add(choice)
            AddHandler choice.CheckedChanged, AddressOf UpdateCheckButton
        Next

        Dim retryButton As New Button With {.Text = "Retry Practice", .AutoSize = True}
        Dim buttons As New FlowLayoutPanel With {.AutoSize = True, .Dock = DockStyle.Fill}
        buttons.Controls.AddRange(New Control() {_checkButton, _nextButton, retryButton})
        AddHandler _checkButton.Click, AddressOf CheckAnswer
        AddHandler _nextButton.Click,
            Sub(sender, args)
                _attempt.Advance()
                RenderQuestion()
            End Sub
        AddHandler retryButton.Click,
            Sub(sender, args)
                _attempt.Retry()
                RenderQuestion()
            End Sub

        Dim layout As New TableLayoutPanel With {.ColumnCount = 1, .Dock = DockStyle.Top, .AutoSize = True,
                                                  .AutoSizeMode = AutoSizeMode.GrowAndShrink, .Padding = New Padding(20)}
        layout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        For Each control As Control In New Control() {heading, practiceNote, _count, _progress, _question, _answers, _explanation, buttons}
            layout.Controls.Add(control)
        Next
        Dim viewport As New Panel With {.Dock = DockStyle.Fill, .AutoScroll = True}
        viewport.Controls.Add(layout)
        Controls.Add(viewport)
        AddHandler viewport.SizeChanged,
            Sub(sender, args)
                Dim wrapSize As New Size(Math.Max(120, viewport.ClientSize.Width - 65), 0)
                _question.MaximumSize = wrapSize
                _explanation.MaximumSize = wrapSize
                For Each choice As RadioButton In _choices
                    choice.MaximumSize = wrapSize
                Next
            End Sub
        RenderQuestion()
    End Sub

    Private Sub UpdateCheckButton(sender As Object, e As EventArgs)
        _checkButton.Enabled = _attempt.CurrentQuestion IsNot Nothing AndAlso Not _attempt.Answer.HasValue AndAlso
                               Array.Exists(_choices, Function(choice) choice IsNot Nothing AndAlso choice.Checked)
    End Sub

    Private Sub CheckAnswer(sender As Object, e As EventArgs)
        Dim chosenIndex As Integer = Array.FindIndex(_choices, Function(choice) choice.Checked)
        If _attempt.Submit(chosenIndex) Then RenderQuestion()
    End Sub

    Private Sub RenderQuestion()
        Dim question As ReviewQuestion = _attempt.CurrentQuestion
        Dim answer As Integer? = _attempt.Answer
        _progress.Value = _attempt.Answered
        _count.Text = _attempt.Answered.ToString() & " of " & _attempt.Total.ToString() &
                      " answered · " & _attempt.Score.ToString() & " correct"

        _answers.Visible = question IsNot Nothing
        _checkButton.Visible = question IsNot Nothing
        _nextButton.Visible = question IsNot Nothing
        If question Is Nothing Then
            _question.Text = "Practice complete"
            _explanation.Text = "Final score: " & _attempt.Score.ToString() & " / " & _attempt.Total.ToString() &
                                ". Choose Retry Practice to start over."
            Return
        End If

        Dim number As Integer = _attempt.Answered + If(answer.HasValue, 0, 1)
        _question.Text = number.ToString() & ". " & question.Prompt
        For index As Integer = 0 To _choices.Length - 1
            _choices(index).Text = question.Choices(index)
            _choices(index).Checked = answer.HasValue AndAlso index = answer.Value
            _choices(index).Enabled = Not answer.HasValue
        Next
        _nextButton.Enabled = answer.HasValue
        _nextButton.Text = If(number = _attempt.Total, "See Score", "Next Question")
        _explanation.Text = If(answer.HasValue,
            If(answer.GetValueOrDefault() = question.CorrectChoice, "Correct. ", "Correct answer: " & question.Choices(question.CorrectChoice) & ". ") &
            question.Explanation & vbCrLf & question.Topic, question.Topic)
        UpdateCheckButton(Nothing, EventArgs.Empty)
    End Sub
End Class
