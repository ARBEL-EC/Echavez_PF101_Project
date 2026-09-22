Public Class frmLesson6_SelectionRepetition

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
            "   secondary qualifications (e.g., Honor qualification checking)."

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
            "     and immediately proceeds to the next iteration."

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
            "   • DateTime.Now.AddDays(n): Increment date by n days in a loop." & vbCrLf &
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
            ' Demonstration: Select Case with Range & Relational
            ' -----------------------------------------------------
            Select Case grade
                Case 97D To 100D : qcuPoint = "1.00" : remarks = "Excellent"
                Case 94D To 96.99D : qcuPoint = "1.25" : remarks = "Very Good"
                Case 91D To 93.99D : qcuPoint = "1.50" : remarks = "Very Good"
                Case 88D To 90.99D : qcuPoint = "1.75" : remarks = "Good"
                Case 85D To 87.99D : qcuPoint = "2.00" : remarks = "Good"
                Case 82D To 84.99D : qcuPoint = "2.25" : remarks = "Satisfactory"
                Case 79D To 81.99D : qcuPoint = "2.50" : remarks = "Satisfactory"
                Case 76D To 78.99D : qcuPoint = "2.75" : remarks = "Fair"
                Case 75D To 75.99D : qcuPoint = "3.00" : remarks = "Passed"
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
            "Numerical Grade: " & grade.ToString("F2") & "%" & vbCrLf &
            "QCU Point Equivalent: " & qcuPoint & vbCrLf &
            "Academic Status: " & remarks & vbCrLf &
            "Honors Standing: " & honors & vbCrLf &
            "--------------------------------------------------" & vbCrLf &
            "Branch Executed: Case/Block for Grade " & grade.ToString("F1")
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

        Dim sum As Integer = 0
        Dim count As Integer = 0

        Select Case cboLoopType.SelectedIndex
            Case 0 ' For...Next Loop
                lstLoopResults.Items.Add("-- Executing For...Next Loop --")
                For i As Integer = startVal To endVal Step stepVal
                    If chkUseBreak.Checked AndAlso i = 7 Then
                        lstLoopResults.Items.Add(">> Exit For triggered at i = 7 <<")
                        Exit For
                    End If
                    sum += i
                    count += 1
                    lstLoopResults.Items.Add("Pass #" & count & ": i = " & i & " | Subtotal = " & sum)
                Next

            Case 1 ' For...Next (Negative Step count down)
                lstLoopResults.Items.Add("-- Executing Reverse For...Next Loop --")
                Dim actualStep As Integer = -Math.Abs(stepVal)
                For i As Integer = Math.Max(startVal, endVal) To Math.Min(startVal, endVal) Step actualStep
                    sum += i
                    count += 1
                    lstLoopResults.Items.Add("Countdown #" & count & ": value = " & i & " | Subtotal = " & sum)
                Next

            Case 2 ' Do While...Loop (Pre-Test)
                lstLoopResults.Items.Add("-- Executing Do While...Loop (Pre-Test) --")
                Dim curr As Integer = startVal
                Do While curr <= endVal
                    If chkUseBreak.Checked AndAlso curr = 7 Then
                        lstLoopResults.Items.Add(">> Exit Do triggered at curr = 7 <<")
                        Exit Do
                    End If
                    sum += curr
                    count += 1
                    lstLoopResults.Items.Add("Iteration #" & count & ": curr = " & curr & " | Subtotal = " & sum)
                    curr += stepVal
                Loop

            Case 3 ' Do...Loop Until (Post-Test)
                lstLoopResults.Items.Add("-- Executing Do...Loop Until (Post-Test) --")
                Dim curr As Integer = startVal
                Do
                    sum += curr
                    count += 1
                    lstLoopResults.Items.Add("Pass #" & count & ": curr = " & curr & " (Guaranteed >= 1 pass)")
                    curr += stepVal
                Loop Until curr > endVal
        End Select

        lstLoopResults.Items.Add("-----------------------------------------")
        lstLoopResults.Items.Add("Completed: " & count & " total iterations | Grand Sum = " & sum)
    End Sub

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

        ' Reverse string using a countdown loop
        Dim reversed As String = ""
        For i As Integer = input.Length - 1 To 0 Step -1
            reversed &= input(i)
        Next

        txtStringOutput.Text =
            "STRING ANALYSIS REPORT (For Each Loop):" & vbCrLf &
            "==================================================" & vbCrLf &
            "Input Text: """ & input & """" & vbCrLf &
            "Total Length: " & input.Length & " characters" & vbCrLf &
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
        sb.AppendLine()

        For dayOffset As Integer = 1 To days
            Dim futureDate As DateTime = startDate.AddDays(dayOffset)
            Dim dayType As String = If(futureDate.DayOfWeek = DayOfWeek.Saturday OrElse futureDate.DayOfWeek = DayOfWeek.Sunday, "[WEEKEND]", "[CLASS DAY]")
            sb.AppendLine("Day +" & dayOffset.ToString("D2") & ": " & futureDate.ToString("ddd - MMM dd, yyyy") & " " & dayType)
        Next

        txtStringOutput.Text = sb.ToString()
    End Sub

End Class