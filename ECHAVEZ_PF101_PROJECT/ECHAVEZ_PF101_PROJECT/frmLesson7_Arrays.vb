Public Class frmLesson7_Arrays

    Private Sub frmLesson7_Arrays_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeManager.ApplyTheme(Me)
        txtLessonNotes.BackColor = Color.FromArgb(18, 19, 22)
        txtLessonNotes.ForeColor = Color.FromArgb(248, 250, 252)
        txtLessonNotes.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
        txtLessonNotes.Text =
            "WEEK 7: ARRAYS" & vbCrLf &
            "============================================================" & vbCrLf & vbCrLf &
            "1. WHAT IS AN ARRAY?" & vbCrLf &
            "An array stores a fixed number of values of the same data type under one name. " &
            "Each value is an element, and its position is identified by an integer index." & vbCrLf &
            "Use arrays when a program needs to process a related collection of values." & vbCrLf & vbCrLf &
            "2. DECLARING AND INITIALIZING ARRAYS" & vbCrLf &
            "Declare an array with a data type and either a size or an initializer." & vbCrLf &
            "Dim scores(4) As Integer    ' Five elements: indexes 0 through 4" & vbCrLf &
            "Dim days() As String = {""Mon"", ""Tue"", ""Wed""}" & vbCrLf &
            "The upper bound is the last valid index; the number of elements is upper bound + 1." & vbCrLf & vbCrLf &
            "3. ZERO-BASED BOUNDS AND SUBSCRIPTS" & vbCrLf &
            "VB.NET arrays are zero-based by default. In an array of length n, valid indexes " &
            "are 0 through n - 1. Use Length to get the element count and GetUpperBound(0) " &
            "to get the last valid index." & vbCrLf &
            "Always keep an index within the valid range to avoid IndexOutOfRangeException." & vbCrLf & vbCrLf &
            "4. TRAVERSING A ONE-DIMENSIONAL ARRAY" & vbCrLf &
            "A For loop is useful when the index is needed; For Each is concise when reading " &
            "every element in order." & vbCrLf &
            "For index As Integer = 0 To scores.Length - 1" & vbCrLf &
            "    Console.WriteLine(scores(index))" & vbCrLf &
            "Next" & vbCrLf &
            "For Each score As Integer In scores" & vbCrLf &
            "    Console.WriteLine(score)" & vbCrLf &
            "Next" & vbCrLf & vbCrLf &
            "5. SEARCHING, AGGREGATING, AND VALIDATING" & vbCrLf &
            "Accumulate a total by adding each element to a running sum; divide by the number " &
            "of elements to calculate an average. Search by comparing each element to a target. " &
            "Validate input before converting it, and do not divide when the array is empty." & vbCrLf &
            "For Decimal data, use Decimal.TryParse and format results with ""N2"" for two decimal places." & vbCrLf & vbCrLf &
            "6. TWO-DIMENSIONAL ARRAYS" & vbCrLf &
            "A two-dimensional array organizes values in rows and columns. It uses two indexes: " &
            "the first selects a row and the second selects a column." & vbCrLf &
            "Dim grid(2, 3) As Integer    ' 3 rows by 4 columns (indexes 0..2 and 0..3)" & vbCrLf &
            "For row As Integer = 0 To grid.GetUpperBound(0)" & vbCrLf &
            "    For column As Integer = 0 To grid.GetUpperBound(1)" & vbCrLf &
            "        Console.WriteLine(grid(row, column))" & vbCrLf &
            "    Next" & vbCrLf &
            "Next" & vbCrLf &
            "Nested loops can calculate row totals, column totals, and a grand total."

        lstPptTopics.Items.Clear()
        lstPptTopics.Items.AddRange(New Object() { _
            "Slide 01 Introduction to Arrays", _
            "Slide 02 Declaring & Initializing", _
            "Slide 03 Bounds & Subscripts", _
            "Slide 04 For Each Iteration", _
            "Slide 05 Two-Dimensional Grids"
        })
        If lstPptTopics.Items.Count > 0 Then lstPptTopics.SelectedIndex = 0

        InitializeMatrixGrid()
    End Sub

    Private Sub lstPptTopics_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPptTopics.SelectedIndexChanged
        Select Case lstPptTopics.SelectedIndex
            Case 0
                txtPptTranscript.Text =
                    "SLIDE 01 | INTRODUCTION TO ARRAYS" & vbCrLf &
                    "============================================================" & vbCrLf & vbCrLf &
                    "An array is a collection of values of one declared type, stored under a single variable name." & vbCrLf & vbCrLf &
                    "WHY ARRAYS?" & vbCrLf &
                    "- Keep related data together instead of declaring a separate variable for every value." & vbCrLf &
                    "- Access an element by its numeric index." & vbCrLf &
                    "- Traverse, search, sort, and calculate across a collection." & vbCrLf & vbCrLf &
                    "TAKEAWAY" & vbCrLf &
                    "An array has an element type, a length, and valid indexes. In VB.NET, the first index is 0."
            Case 1
                txtPptTranscript.Text =
                    "SLIDE 02 | DECLARING & INITIALIZING" & vbCrLf &
                    "============================================================" & vbCrLf & vbCrLf &
                    "Declare an array with the element type and allocate its storage, or use an initializer." & vbCrLf & vbCrLf &
                    "SAMPLE SYNTAX" & vbCrLf &
                    "Dim scores(4) As Integer" & vbCrLf &
                    "' 5 elements: indexes 0, 1, 2, 3, 4" & vbCrLf & vbCrLf &
                    "Dim colors() As String = {""Red"", ""Green"", ""Blue""}" & vbCrLf &
                    "' Length is 3; indexes are 0 through 2" & vbCrLf & vbCrLf &
                    "TAKEAWAY" & vbCrLf &
                    "The size in a VB.NET parenthesized declaration is an upper bound, not an element count."
            Case 2
                txtPptTranscript.Text =
                    "SLIDE 03 | BOUNDS & SUBSCRIPTS" & vbCrLf &
                    "============================================================" & vbCrLf & vbCrLf &
                    "A subscript is the index used to read or write one array element. With n elements, " &
                    "the valid indexes are 0 through n - 1." & vbCrLf & vbCrLf &
                    "SAMPLE SYNTAX" & vbCrLf &
                    "For index As Integer = 0 To scores.Length - 1" & vbCrLf &
                    "    Console.WriteLine(scores(index))" & vbCrLf &
                    "Next" & vbCrLf & vbCrLf &
                    "Use Length for the count and GetUpperBound(0) for the last index. An invalid index " &
                    "causes IndexOutOfRangeException."
            Case 3
                txtPptTranscript.Text =
                    "SLIDE 04 | FOR EACH ITERATION" & vbCrLf &
                    "============================================================" & vbCrLf & vbCrLf &
                    "For Each visits every array element in sequence without requiring the caller to manage an index." & vbCrLf & vbCrLf &
                    "SAMPLE SYNTAX" & vbCrLf &
                    "For Each score As Integer In scores" & vbCrLf &
                    "    Console.WriteLine(score)" & vbCrLf &
                    "Next" & vbCrLf & vbCrLf &
                    "Use For Each for straightforward reading and aggregation. Use For when the index is " &
                    "needed or elements must be updated by position."
            Case 4
                txtPptTranscript.Text =
                    "SLIDE 05 | TWO-DIMENSIONAL GRIDS" & vbCrLf &
                    "============================================================" & vbCrLf & vbCrLf &
                    "A two-dimensional array represents rows and columns. The first subscript chooses the row; " &
                    "the second chooses the column." & vbCrLf & vbCrLf &
                    "SAMPLE SYNTAX" & vbCrLf &
                    "Dim grid(2, 3) As Integer" & vbCrLf &
                    "For row As Integer = 0 To grid.GetUpperBound(0)" & vbCrLf &
                    "    For column As Integer = 0 To grid.GetUpperBound(1)" & vbCrLf &
                    "        Console.WriteLine(grid(row, column))" & vbCrLf &
                    "    Next" & vbCrLf &
                    "Next" & vbCrLf & vbCrLf &
                    "This declaration has 3 rows and 4 columns. Nested loops can accumulate row, column, " &
                    "and overall totals."
            Case Else
                txtPptTranscript.Clear()
        End Select
    End Sub

    Private Sub InitializeMatrixGrid()
        matrixGrid.Rows.Clear()
        For rowIndex As Integer = 0 To 2
            Dim row As Integer = matrixGrid.Rows.Add("0", "0", "0", "0")
            matrixGrid.Rows(row).HeaderCell.Value = "Row " & rowIndex.ToString()
        Next
    End Sub

    Private Sub btnLoadMonths_Click(sender As Object, e As EventArgs) Handles btnLoadMonths.Click
        Dim months As String() = {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        }

        lstMonths.Items.Clear()
        lstMonths.Items.AddRange(months)
        lstMonths.SelectedIndex = -1
        lblMonthSelection.Text = "Select a month to display its zero-based index."
    End Sub

    Private Sub btnClearMonthDisplay_Click(sender As Object, e As EventArgs) Handles btnClearMonthDisplay.Click
        lstMonths.SelectedIndex = -1
        lblMonthSelection.Text = String.Empty
    End Sub

    Private Sub lstMonths_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMonths.SelectedIndexChanged
        If lstMonths.SelectedIndex >= 0 Then
            lblMonthSelection.Text = "Month: " & lstMonths.SelectedItem.ToString() &
                                     "    |    Zero-based index: " & lstMonths.SelectedIndex.ToString()
        End If
    End Sub

    Private Function TryReadScores(ByRef scores As Decimal()) As Boolean
        Dim tokens As String() = txtScoresInput.Text.Split(
            New Char() {","c, ";"c, " "c, ControlChars.Tab, ControlChars.Cr, ControlChars.Lf},
            StringSplitOptions.RemoveEmptyEntries)

        If tokens.Length = 0 Then
            MessageBox.Show("Enter one or more scores separated by commas, spaces, or semicolons.",
                            "Scores Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        Dim parsedScores(tokens.Length - 1) As Decimal
        For index As Integer = 0 To tokens.Length - 1
            If Not Decimal.TryParse(tokens(index), parsedScores(index)) Then
                MessageBox.Show("Score '" & tokens(index) & "' is not a valid number. Correct the input and try again.",
                                "Invalid Score", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
        Next

        scores = parsedScores
        Return True
    End Function

    Private Sub btnCalculateScores_Click(sender As Object, e As EventArgs) Handles btnCalculateScores.Click
        Dim scores As Decimal() = Nothing
        If Not TryReadScores(scores) Then Return

        Dim total As Decimal = 0D
        For Each score As Decimal In scores
            total += score
        Next

        txtScoreResults.Text =
            "1D ARRAY ANALYSIS" & vbCrLf &
            "------------------------------" & vbCrLf &
            "Elements: " & scores.Length.ToString() & vbCrLf &
            "Total: " & total.ToString("N2") & vbCrLf &
            "Average: " & (total / scores.Length).ToString("N2")
    End Sub

    Private Sub btnFindScore_Click(sender As Object, e As EventArgs) Handles btnFindScore.Click
        Dim scores As Decimal() = Nothing
        If Not TryReadScores(scores) Then Return

        Dim target As Decimal
        If Not Decimal.TryParse(txtSearchScore.Text, target) Then
            MessageBox.Show("Enter a valid numeric value to search for.", "Invalid Search Value",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSearchScore.Focus()
            Return
        End If

        Dim indexes As New System.Text.StringBuilder()
        For index As Integer = 0 To scores.Length - 1
            If scores(index) = target Then
                If indexes.Length > 0 Then indexes.Append(", ")
                indexes.Append(index.ToString())
            End If
        Next

        If indexes.Length = 0 Then
            txtScoreResults.Text = "Value " & target.ToString("N2") & " was not found in the array."
        Else
            txtScoreResults.Text = "Value " & target.ToString("N2") &
                                  " found at zero-based index(es): " & indexes.ToString()
        End If
    End Sub

    Private Sub btnCalculateMatrixTotals_Click(sender As Object, e As EventArgs) Handles btnCalculateMatrixTotals.Click
        If matrixGrid.IsCurrentCellInEditMode Then matrixGrid.EndEdit()
        If matrixGrid.Columns.Count <> 4 OrElse matrixGrid.Rows.Count <> 3 Then
            MessageBox.Show("The matrix grid is not initialized. Close and reopen this lesson, then try again.",
                            "Matrix Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim rowTotals(2) As Decimal
        Dim columnTotals(3) As Decimal
        Dim grandTotal As Decimal = 0D

        For row As Integer = 0 To 2
            For column As Integer = 0 To 3
                Dim cellValue As Object = matrixGrid.Rows(row).Cells(column).Value
                Dim number As Decimal
                If cellValue Is Nothing OrElse Not Decimal.TryParse(Convert.ToString(cellValue), number) Then
                    MessageBox.Show("Enter a valid number in every matrix cell before calculating totals.",
                                    "Matrix Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    matrixGrid.CurrentCell = matrixGrid.Rows(row).Cells(column)
                    matrixGrid.BeginEdit(True)
                    Return
                End If

                rowTotals(row) += number
                columnTotals(column) += number
                grandTotal += number
            Next
        Next

        txtMatrixResults.Text =
            "MATRIX TOTALS" & vbCrLf &
            "Row totals:    " & rowTotals(0).ToString("N2") & " | " &
            rowTotals(1).ToString("N2") & " | " & rowTotals(2).ToString("N2") & vbCrLf &
            "Column totals: " & columnTotals(0).ToString("N2") & " | " &
            columnTotals(1).ToString("N2") & " | " & columnTotals(2).ToString("N2") &
            " | " & columnTotals(3).ToString("N2") & vbCrLf &
            "Overall total: " & grandTotal.ToString("N2")
    End Sub

    Private Sub btnResetMatrix_Click(sender As Object, e As EventArgs) Handles btnResetMatrix.Click
        If matrixGrid.IsCurrentCellInEditMode Then matrixGrid.CancelEdit()
        If matrixGrid.Columns.Count <> 4 OrElse matrixGrid.Rows.Count <> 3 Then
            InitializeMatrixGrid()
            txtMatrixResults.Clear()
            Return
        End If

        For Each row As DataGridViewRow In matrixGrid.Rows
            For Each cell As DataGridViewCell In row.Cells
                cell.Value = "0"
            Next
        Next
        txtMatrixResults.Clear()
    End Sub

End Class
