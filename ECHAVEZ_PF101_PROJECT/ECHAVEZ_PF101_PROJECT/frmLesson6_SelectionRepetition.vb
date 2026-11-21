Public Class frmLesson6_SelectionRepetition

    Private Const MaxLoopPasses As Integer = 1000

    Private Sub frmLesson6_SelectionRepetition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeManager.ApplyTheme(Me)
        ' 1. Setup Decision dropdowns
        cboDecisionMode.Items.Clear()
        cboDecisionMode.Items.Add("If...ElseIf Structure")
        cboDecisionMode.Items.Add("Select Case Structure")
        cboDecisionMode.SelectedIndex = 0

        ' 2. Setup Loop dropdowns
        cboLoopType.Items.Clear()
        cboLoopType.Items.Add("For...Next Loop")
        cboLoopType.Items.Add("For...Next (Negative Step)")
        cboLoopType.Items.Add("Do While...Loop (Pre-Test)")
        cboLoopType.Items.Add("Do...Loop Until (Post-Test)")
        cboLoopType.Items.Add("While...End While (Skip even values)")
        cboLoopType.SelectedIndex = 0

        ' 3. Populate Reference Theory
        txtDecisionTheory.Text =
            "WEEK 6: SELECTION STRUCTURES" & vbCrLf &
            "=======================================================" & vbCrLf & vbCrLf &
            "1. SINGLE & DUAL ALTERNATIVE:" & vbCrLf &
            "   • If...Then: Executes block only when condition evaluates True." & vbCrLf &
            "   • If...Then...Else: Chooses strictly between two branching paths." & vbCrLf & vbCrLf &
            "2. MULTIPLE ALTERNATIVE (If...ElseIf):" & vbCrLf &
            "   Evaluates sequential Boolean conditions. Once a matching condition" & vbCrLf &
            "   is found, its block runs and remaining conditions are skipped." & vbCrLf & vbCrLf &
            "3. SELECT CASE STRUCTURE:" & vbCrLf &
            "   Preferred over multiple ElseIf blocks for readability." & vbCrLf &
            "   Supports powerful matching expressions:" & vbCrLf &
            "   • Value lists: Case 1, 3, 5" & vbCrLf &
            "   • Range limits: Case 90 To 100" & vbCrLf &
            "   • Relational comparisons: Case Is >= 75" & vbCrLf &
            "   • Fallback default: Case Else" & vbCrLf & vbCrLf &
            "4. NESTED DECISIONS:" & vbCrLf &
            "   An If or Select block placed inside another branch to perform" & vbCrLf &
            "   secondary qualifications (e.g., the practice honors check)." & vbCrLf & vbCrLf &
            "5. SHORT-CIRCUIT LOGIC:" & vbCrLf &
            "   The grade input check uses OrElse. If parsing fails, the range check is skipped."

        txtLoopTheory.Text =
            "WEEK 6: REPETITION STRUCTURES (LOOPS)" & vbCrLf &
            "=======================================================" & vbCrLf & vbCrLf &
            "1. FOR...NEXT LOOP (Counter-Controlled):" & vbCrLf &
            "   Used when iteration bounds are known before execution." & vbCrLf &
            "   • Syntax: For counter = start To finish [Step increment]" & vbCrLf &
            "   • Negative Step counts backwards." & vbCrLf & vbCrLf &
            "2. DO WHILE...LOOP (Pre-Test vs Post-Test):" & vbCrLf &
            "   Continues looping as long as the condition remains True." & vbCrLf &
            "   • Pre-test: Checks at the entry. If initially False, body runs 0 times." & vbCrLf &
            "   • Post-test: Loop While at bottom guarantees body runs at least 1 time." & vbCrLf & vbCrLf &
            "3. DO UNTIL...LOOP:" & vbCrLf &
            "   Continues looping until the condition becomes True." & vbCrLf & vbCrLf &
            "4. LOOP CONTROL FLOW:" & vbCrLf &
            "   • Exit For / Exit Do: Immediately breaks out of the loop cycle." & vbCrLf &
            "   • Continue For / Continue Do: Skips remainder of current pass" & vbCrLf &
            "     and immediately proceeds to the next iteration." & vbCrLf &
            "   • Try While with Start 1, End 5, Step 1. Continue While skips 2 and 4." & vbCrLf &
            "The trace supports up to " & MaxLoopPasses.ToString() & " passes. Use a smaller range or a larger step."

        txtStringTheory.Text =
            "STRING & DATE PROCESSING IN LOOPS" & vbCrLf &
            "=======================================================" & vbCrLf & vbCrLf &
            "1. FOR EACH WITH STRINGS:" & vbCrLf &
            "   Strings in VB.NET are collections of Char objects." & vbCrLf &
            "   'For Each ch As Char In myString' walks through each character." & vbCrLf & vbCrLf &
            "2. CORE STRING METHODS:" & vbCrLf &
            "   • .Length: Total character count." & vbCrLf &
            "   • .ToUpper() / .ToLower(): Case standardization." & vbCrLf &
            "   • .Substring(start, length): Extract sub-sequences." & vbCrLf &
            "   • .IndexOf(char): Find position of target character." & vbCrLf & vbCrLf &
            "3. DATE ITERATIONS:" & vbCrLf &
            "   • DateTime.Today.AddDays(n): Advance a date by n days in a loop." & vbCrLf &
            "   • .ToString(""ddd, MMM dd, yyyy""): Format date tokens cleanly."
    End Sub

    ' =========================================================
    ' TAB 1: DECISION STRUCTURE EXECUTION
    ' =========================================================
    Private Sub btnEvaluateGrade_Click(sender As Object, e As EventArgs) Handles btnEvaluateGrade.Click
        Dim grade As Decimal
        If Not Decimal.TryParse(txtGradeInput.Text, grade) OrElse grade < 0 OrElse grade > 100 Then
            MessageBox.Show("Please enter a valid numeric grade between 0 and 100.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim qcuPoint As String = ""
        Dim remarks As String = ""
        Dim honors As String = "Not Qualified"

        If cboDecisionMode.SelectedIndex = 0 Then
            ' -----------------------------------------------------
            ' Demonstration: If...ElseIf...Else
            ' -----------------------------------------------------
            If grade >= 97D Then
                qcuPoint = "1.00" : remarks = "Excellent"
            ElseIf grade >= 94D Then
                qcuPoint = "1.25" : remarks = "Very Good"
            ElseIf grade >= 91D Then
                qcuPoint = "1.50" : remarks = "Very Good"
            ElseIf grade >= 88D Then
                qcuPoint = "1.75" : remarks = "Good"
            ElseIf grade >= 85D Then
                qcuPoint = "2.00" : remarks = "Good"
            ElseIf grade >= 82D Then
                qcuPoint = "2.25" : remarks = "Satisfactory"
            ElseIf grade >= 79D Then
                qcuPoint = "2.50" : remarks = "Satisfactory"
            ElseIf grade >= 76D Then
                qcuPoint = "2.75" : remarks = "Fair"
            ElseIf grade >= 75D Then
                qcuPoint = "3.00" : remarks = "Passed"
            Else
                qcuPoint = "5.00" : remarks = "Failed"
            End If
        Else
            ' -----------------------------------------------------
            ' Demonstration: Select Case with Descending Lower Bounds
            ' -----------------------------------------------------
            Select Case grade
                Case Is >= 97D : qcuPoint = "1.00" : remarks = "Excellent"
                Case Is >= 94D : qcuPoint = "1.25" : remarks = "Very Good"
                Case Is >= 91D : qcuPoint = "1.50" : remarks = "Very Good"
                Case Is >= 88D : qcuPoint = "1.75" : remarks = "Good"
                Case Is >= 85D : qcuPoint = "2.00" : remarks = "Good"
                Case Is >= 82D : qcuPoint = "2.25" : remarks = "Satisfactory"
                Case Is >= 79D : qcuPoint = "2.50" : remarks = "Satisfactory"
                Case Is >= 76D : qcuPoint = "2.75" : remarks = "Fair"
                Case Is >= 75D : qcuPoint = "3.00" : remarks = "Passed"
                Case Else : qcuPoint = "5.00" : remarks = "Failed"
            End Select
        End If

        ' Nested Decision: Honors Qualification
        If grade >= 90D Then
            If chkGoodMoral.Checked Then
                honors = "Dean's Lister Candidate"
            Else
                honors = "Disqualified (Disciplinary Record)"
            End If
        End If

        txtDecisionOutput.Text =
            "DECISION EVALUATION TRACE:" & vbCrLf &
            "--------------------------------------------------" & vbCrLf &
            "Engine: " & cboDecisionMode.SelectedItem.ToString() & vbCrLf &
            "Numerical Grade: " & grade.ToString("G29") & "%" & vbCrLf &
            "Practice Grade Point: " & qcuPoint & vbCrLf &
            "Academic Status: " & remarks & vbCrLf &
            "Example Honors Decision: " & honors & vbCrLf &
            "--------------------------------------------------" & vbCrLf &
            "Branch Executed: Case/Block for Grade " & grade.ToString("G29")
    End Sub

    ' =========================================================
    ' TAB 2: REPETITION STRUCTURE (LOOP RUNNER)
    ' =========================================================
    Private Sub btnExecuteLoop_Click(sender As Object, e As EventArgs) Handles btnExecuteLoop.Click
        lstLoopResults.Items.Clear()
        Dim startVal, endVal, stepVal As Integer

        If Not Integer.TryParse(txtLoopStart.Text, startVal) OrElse
           Not Integer.TryParse(txtLoopEnd.Text, endVal) OrElse
           Not Integer.TryParse(txtLoopStep.Text, stepVal) Then
            MessageBox.Show("Please enter valid integers for Start, End, and Step.", "Loop Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If stepVal = 0 Then
            MessageBox.Show("Step value cannot be zero (prevents infinite loop).", "Loop Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Widen before negating, subtracting bounds, or advancing the final counter.
        Dim first As Long = startVal
        Dim last As Long = endVal
        Dim stepSize As Long = stepVal
        Dim mode As Integer = cboLoopType.SelectedIndex
        If mode = 1 Then
            first = Math.Max(startVal, endVal)
            last = Math.Min(startVal, endVal)
            stepSize = -Math.Abs(stepSize)
        End If

        Dim passCount As Long = 0
        If IsWithinLoopBounds(first, last, stepSize) Then
            passCount = Math.Abs(last - first) \ Math.Abs(stepSize) + 1
        ElseIf mode = 3 Then
            passCount = 1 ' A post-test loop runs once even when the initial value is outside the range.
        End If
        If passCount > MaxLoopPasses Then
            lstLoopResults.Items.Add("This range exceeds " & MaxLoopPasses.ToString() &
                                     " passes. Choose a smaller range or a larger step.")
            Return
        End If

        Dim sum As Long = 0
        Dim count As Integer = 0
        Dim recordValue As Action(Of Long) =
            Sub(value As Long)
                count += 1
                sum += value
                lstLoopResults.Items.Add("Pass #" & count & ": value = " & value & " | Subtotal = " & sum)
            End Sub

        lstLoopResults.Items.Add("-- Executing " & cboLoopType.Text & " --")
        Select Case mode
            Case 0, 1
                For counter As Long = first To last Step stepSize
                    If ShouldExitLoop(counter, "Exit For") Then Exit For
                    recordValue(counter)
                Next

            Case 2
                Dim current As Long = first
                Do While IsWithinLoopBounds(current, last, stepSize)
                    If ShouldExitLoop(current, "Exit Do") Then Exit Do
                    recordValue(current)
                    current += stepSize
                Loop

            Case 3
                Dim current As Long = first
                Do
                    If ShouldExitLoop(current, "Exit Do") Then Exit Do
                    recordValue(current)
                    current += stepSize
                Loop Until Not IsWithinLoopBounds(current, last, stepSize)

            Case 4
                Dim current As Long = first
                While IsWithinLoopBounds(current, last, stepSize)
                    If ShouldExitLoop(current, "Exit While") Then Exit While
                    If current Mod 2 = 0 Then
                        lstLoopResults.Items.Add("Continue While skipped " & current)
                        current += stepSize
                        Continue While
                    End If
                    recordValue(current)
                    current += stepSize
                End While
        End Select

        lstLoopResults.Items.Add("-----------------------------------------")
        lstLoopResults.Items.Add("Values added: " & count & " | Grand Sum = " & sum)
    End Sub

    Private Shared Function IsWithinLoopBounds(value As Long, last As Long, stepSize As Long) As Boolean
        Return If(stepSize > 0, value <= last, value >= last)
    End Function

    Private Function ShouldExitLoop(value As Long, statement As String) As Boolean
        If Not chkUseBreak.Checked OrElse value <> 7 Then Return False
        lstLoopResults.Items.Add(statement & " triggered at value 7.")
        Return True
    End Function

    ' =========================================================
    ' TAB 3: STRING & DATE PROCESSING IN LOOPS
    ' =========================================================
    Private Sub btnAnalyzeString_Click(sender As Object, e As EventArgs) Handles btnAnalyzeString.Click
        Dim input As String = txtStringInput.Text
        If String.IsNullOrEmpty(input) Then
            MessageBox.Show("Please provide text to analyze.", "Input Empty", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim vowelsCount As Integer = 0
        Dim consonantsCount As Integer = 0
        Dim digitsCount As Integer = 0
        Dim whitespaceCount As Integer = 0

        ' For Each character loop
        For Each ch As Char In input
            If Char.IsLetter(ch) Then
                Select Case Char.ToUpper(ch)
                    Case "A"c, "E"c, "I"c, "O"c, "U"c
                        vowelsCount += 1
                    Case Else
                        consonantsCount += 1
                End Select
            ElseIf Char.IsDigit(ch) Then
                digitsCount += 1
            ElseIf Char.IsWhiteSpace(ch) Then
                whitespaceCount += 1
            End If
        Next

        ' Reverse text elements so an accent or surrogate pair stays with its character.
        Dim offsets As Integer() = Globalization.StringInfo.ParseCombiningCharacters(input)
        Dim reversedText As New System.Text.StringBuilder(input.Length)
        Dim nextOffset As Integer = input.Length
        For i As Integer = offsets.Length - 1 To 0 Step -1
            reversedText.Append(input, offsets(i), nextOffset - offsets(i))
            nextOffset = offsets(i)
        Next
        Dim reversed As String = reversedText.ToString()

        txtStringOutput.Text =
            "STRING ANALYSIS REPORT (For Each Loop):" & vbCrLf &
            "==================================================" & vbCrLf &
            "Input Text: """ & input & """" & vbCrLf &
            "Total Length: " & offsets.Length & " text elements" & vbCrLf &
            "Vowels: " & vowelsCount & vbCrLf &
            "Consonants: " & consonantsCount & vbCrLf &
            "Digits: " & digitsCount & vbCrLf &
            "Whitespaces: " & whitespaceCount & vbCrLf &
            "Reversed String: """ & reversed & """" & vbCrLf &
            "Is Palindrome?: " & (input.Replace(" ", "").Equals(reversed.Replace(" ", ""), StringComparison.OrdinalIgnoreCase)).ToString()
    End Sub

    Private Sub btnGenerateDates_Click(sender As Object, e As EventArgs) Handles btnGenerateDates.Click
        Dim days As Integer = CInt(nudDays.Value)
        Dim startDate As DateTime = DateTime.Today

        Dim sb As New System.Text.StringBuilder()
        sb.AppendLine("DATE SCHEDULER (Looping DateTime.AddDays):")
        sb.AppendLine("==================================================")
        sb.AppendLine("Starting Base Date: " & startDate.ToString("dddd, MMMM dd, yyyy"))
        sb.AppendLine("Local Time: " & DateTime.Now.ToString("T"))
        sb.AppendLine()

        For dayOffset As Integer = 1 To days
            Dim futureDate As DateTime = startDate.AddDays(dayOffset)
            Dim dayType As String = If(futureDate.DayOfWeek = DayOfWeek.Saturday OrElse futureDate.DayOfWeek = DayOfWeek.Sunday, "[WEEKEND]", "[CLASS DAY]")
            sb.AppendLine("Day +" & dayOffset.ToString("D2") & ": " & futureDate.ToString("ddd - MMM dd, yyyy") & " " & dayType)
        Next

        txtStringOutput.Text = sb.ToString()
    End Sub

End Class