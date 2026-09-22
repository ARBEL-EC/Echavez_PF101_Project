Public Class frmLesson5_DataHandling

    ' Form-level variable (Class Scope: alive as long as this form window is open)
    Private classLevelCounter As Integer = 0

    Private Sub frmLesson5_DataHandling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeManager.ApplyTheme(Me)
        ' 1. Populate Target Data Types
        cboTargetType.Items.Clear()
        cboTargetType.Items.AddRange(New String() {
            "Integer (32-bit Whole Number)",
            "Double (64-bit Floating Point)",
            "Decimal (128-bit Currency/Financial)",
            "Boolean (True / False)",
            "Date (Date and Time)",
            "Char (Single Character)"
        })
        cboTargetType.SelectedIndex = 0

        ' 2. Populate Operators Dropdown
        cboOperator.Items.Clear()
        cboOperator.Items.AddRange(New String() {
            "+ (Addition)",
            "- (Subtraction)",
            "* (Multiplication)",
            "/ (Floating-point Division)",
            "\ (Integer Division - Truncates decimal)",
            "Mod (Modulus - Remainder of division)",
            "^ (Exponentiation - Power of)",
            "& (String Concatenation)"
        })
        cboOperator.SelectedIndex = 5 ' Default to Mod

        ' 3. Populate Reference Theory
        txtTypeTheory.Text =
            "WEEK 5: DATA TYPES & CONVERSION RULES" & vbCrLf &
            "=======================================================" & vbCrLf & vbCrLf &
            "1. PRIMITIVE DATA TYPES IN VB.NET:" & vbCrLf &
            "   • Integer (System.Int32): 4 bytes (-2,147,483,648 to 2,147,483,647)" & vbCrLf &
            "   • Long (System.Int64): 8 bytes (large integers)" & vbCrLf &
            "   • Single (System.Single): 4 bytes (standard precision floating-point)" & vbCrLf &
            "   • Double (System.Double): 8 bytes (high precision scientific math)" & vbCrLf &
            "   • Decimal (System.Decimal): 16 bytes (exact financial calculations)" & vbCrLf &
            "   • Boolean (System.Boolean): 1 or 2 bytes (True or False)" & vbCrLf &
            "   • Char (System.Char): 2 bytes (Unicode character)" & vbCrLf &
            "   • String (System.String): Text sequence of characters" & vbCrLf &
            "   • Date (System.DateTime): 8 bytes (1/1/0001 to 12/31/9999)" & vbCrLf & vbCrLf &
            "2. CONVERSION STRATEGIES:" & vbCrLf &
            "   • Type.TryParse(input, result): Safe parsing without crashing." & vbCrLf &
            "   • CInt(), CDbl(), CDec(), CStr(): Built-in VB conversion functions." & vbCrLf &
            "   • Convert.ToInt32(), Convert.ToDouble(): .NET System class."

        txtScopeTheory.Text =
            "VARIABLE SCOPE AND LIFETIME" & vbCrLf &
            "=======================================================" & vbCrLf & vbCrLf &
            "1. BLOCK SCOPE:" & vbCrLf &
            "   Variables declared inside an If...End If or For...Next block." & vbCrLf &
            "   They exist and are accessible only within that specific block." & vbCrLf & vbCrLf &
            "2. PROCEDURE SCOPE (LOCAL):" & vbCrLf &
            "   Declared with 'Dim' inside a Sub or Function." & vbCrLf &
            "   Re-initialized every time the procedure executes and destroyed on Exit/End Sub." & vbCrLf & vbCrLf &
            "3. STATIC LOCAL VARIABLES:" & vbCrLf &
            "   Declared with 'Static' inside a Sub or Function." & vbCrLf &
            "   Accessible only inside the procedure, BUT preserves its value across calls." & vbCrLf & vbCrLf &
            "4. MODULE / CLASS SCOPE (FIELDS):" & vbCrLf &
            "   Declared at the top of the Class with 'Private'." & vbCrLf &
            "   Accessible to any Sub or Function in the entire form class."

        txtOperatorTheory.Text =
            "VB.NET OPERATOR HIERARCHY & ARITHMETIC" & vbCrLf &
            "=======================================================" & vbCrLf & vbCrLf &
            "1. ARITHMETIC OPERATORS:" & vbCrLf &
            "   • ^  : Exponentiation (Highest precedence)" & vbCrLf &
            "   • * , / : Multiplication & Floating division" & vbCrLf &
            "   • \  : Integer division (e.g., 15 \ 4 = 3)" & vbCrLf &
            "   • Mod: Modulus / Remainder (e.g., 15 Mod 4 = 3)" & vbCrLf &
            "   • + , - : Addition & Subtraction" & vbCrLf & vbCrLf &
            "2. STRING CONCATENATION:" & vbCrLf &
            "   • & : Preferred string operator (forces string conversion)" & vbCrLf &
            "   • + : Ambiguous when mixing numeric strings and numbers" & vbCrLf & vbCrLf &
            "3. LOGICAL / SHORT-CIRCUIT OPERATORS:" & vbCrLf &
            "   • AndAlso: Evaluates second condition only if first is True" & vbCrLf &
            "   • OrElse : Evaluates second condition only if first is False"
    End Sub

    ' =========================================================
    ' TAB 1: TYPE CONVERSION ENGINE
    ' =========================================================
    Private Sub btnConvertType_Click(sender As Object, e As EventArgs) Handles btnConvertType.Click
        Dim input As String = txtRawInput.Text.Trim()
        Dim outText As String = "Input: """ & input & """" & vbCrLf & vbCrLf

        Select Case cboTargetType.SelectedIndex
            Case 0 ' Integer
                Dim result As Integer
                If Integer.TryParse(input, result) Then
                    outText &= "Status: SUCCESS" & vbCrLf &
                               "Converted Value: " & result.ToString() & vbCrLf &
                               ".NET Type: System.Int32" & vbCrLf &
                               "Allocated Size: 4 Bytes (32 bits)"
                Else
                    outText &= "Status: PARSE FAILED" & vbCrLf & "Reason: Input is not a valid 32-bit whole number."
                End If

            Case 1 ' Double
                Dim result As Double
                If Double.TryParse(input, result) Then
                    outText &= "Status: SUCCESS" & vbCrLf &
                               "Converted Value: " & result.ToString("G") & vbCrLf &
                               ".NET Type: System.Double" & vbCrLf &
                               "Allocated Size: 8 Bytes (64 bits)"
                Else
                    outText &= "Status: PARSE FAILED" & vbCrLf & "Reason: Input cannot be parsed as a floating-point number."
                End If

            Case 2 ' Decimal
                Dim result As Decimal
                If Decimal.TryParse(input, result) Then
                    outText &= "Status: SUCCESS" & vbCrLf &
                               "Converted Value: " & result.ToString("C2") & vbCrLf &
                               ".NET Type: System.Decimal" & vbCrLf &
                               "Allocated Size: 16 Bytes (128 bits)"
                Else
                    outText &= "Status: PARSE FAILED" & vbCrLf & "Reason: Input is not a valid decimal value."
                End If

            Case 3 ' Boolean
                Dim result As Boolean
                If Boolean.TryParse(input, result) Then
                    outText &= "Status: SUCCESS" & vbCrLf &
                               "Converted Value: " & result.ToString() & vbCrLf &
                               ".NET Type: System.Boolean" & vbCrLf &
                               "Note: Accepts 'True' or 'False' (case insensitive)."
                Else
                    outText &= "Status: PARSE FAILED" & vbCrLf & "Reason: Value must be 'True' or 'False'."
                End If

            Case 4 ' Date
                Dim result As DateTime
                If DateTime.TryParse(input, result) Then
                    outText &= "Status: SUCCESS" & vbCrLf &
                               "Converted Value: " & result.ToString("MMMM dd, yyyy hh:mm:ss tt") & vbCrLf &
                               ".NET Type: System.DateTime" & vbCrLf &
                               "Allocated Size: 8 Bytes"
                Else
                    outText &= "Status: PARSE FAILED" & vbCrLf & "Reason: Input is not recognized as a valid Date format."
                End If

            Case 5 ' Char
                Dim result As Char
                If Char.TryParse(input, result) Then
                    outText &= "Status: SUCCESS" & vbCrLf &
                               "Converted Value: '" & result & "'" & vbCrLf &
                               "ASCII Code: " & AscW(result).ToString() & vbCrLf &
                               ".NET Type: System.Char (2 Bytes)"
                Else
                    outText &= "Status: PARSE FAILED" & vbCrLf & "Reason: Value must be exactly one character long."
                End If
        End Select

        txtConversionOutput.Text = outText
    End Sub

    ' =========================================================
    ' TAB 2: SCOPE & LIFETIME TESTBENCH
    ' =========================================================
    Private Sub btnLocalVar_Click(sender As Object, e As EventArgs) Handles btnLocalVar.Click
        ' Dim local variable: recreated and reset to 0 every single click
        Dim localCounter As Integer = 0
        localCounter += 1
        lblLocalCount.Text = "Procedure Local (Dim): " & localCounter.ToString() & " (Always resets to 1!)"
    End Sub

    Private Sub btnStaticVar_Click(sender As Object, e As EventArgs) Handles btnStaticVar.Click
        ' Static local variable: retains its value between procedure calls
        Static staticCounter As Integer = 0
        staticCounter += 1
        lblStaticCount.Text = "Static Local Variable: " & staticCounter.ToString() & " (Remembers previous state)"
    End Sub

    Private Sub btnClassVar_Click(sender As Object, e As EventArgs) Handles btnClassVar.Click
        ' Class-level private variable: alive as long as this form is open
        classLevelCounter += 1
        lblClassCount.Text = "Form Field (Private): " & classLevelCounter.ToString() & " (Retained across all subs)"
    End Sub

    Private Sub btnResetCounters_Click(sender As Object, e As EventArgs) Handles btnResetCounters.Click
        classLevelCounter = 0
        lblLocalCount.Text = "Procedure Local (Dim): 0"
        lblStaticCount.Text = "Static Local Variable: 0"
        lblClassCount.Text = "Form Field (Private): 0"
        MessageBox.Show("Counters reset. Note: Static local variable will retain state until application restarts or resets via routine.", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' =========================================================
    ' TAB 3: OPERATOR EVALUATOR
    ' =========================================================
    Private Sub btnCalculateExpression_Click(sender As Object, e As EventArgs) Handles btnCalculateExpression.Click
        Dim a, b As Double

        If Not Double.TryParse(txtOperandA.Text, a) OrElse Not Double.TryParse(txtOperandB.Text, b) Then
            MessageBox.Show("Please enter valid numeric values for Operand A and Operand B.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Select Case cboOperator.SelectedIndex
            Case 0 ' +
                lblExpressionResult.Text = "Result: " & a.ToString() & " + " & b.ToString() & " = " & (a + b).ToString()
            Case 1 ' -
                lblExpressionResult.Text = "Result: " & a.ToString() & " - " & b.ToString() & " = " & (a - b).ToString()
            Case 2 ' *
                lblExpressionResult.Text = "Result: " & a.ToString() & " * " & b.ToString() & " = " & (a * b).ToString()
            Case 3 ' /
                If b = 0 Then
                    lblExpressionResult.Text = "Result: Division by zero is undefined."
                Else
                    lblExpressionResult.Text = "Result: " & a.ToString() & " / " & b.ToString() & " = " & (a / b).ToString("N4")
                End If
            Case 4 ' \ (Integer Division)
                If CInt(b) = 0 Then
                    lblExpressionResult.Text = "Result: Division by zero is undefined."
                Else
                    Dim intResult As Integer = CInt(a) \ CInt(b)
                    lblExpressionResult.Text = "Result (Integer Div \): " & CInt(a).ToString() & " \ " & CInt(b).ToString() & " = " & intResult.ToString()
                End If
            Case 5 ' Mod
                If CInt(b) = 0 Then
                    lblExpressionResult.Text = "Result: Division by zero is undefined."
                Else
                    Dim modResult As Integer = CInt(a) Mod CInt(b)
                    lblExpressionResult.Text = "Result (Modulus): " & CInt(a).ToString() & " Mod " & CInt(b).ToString() & " = " & modResult.ToString()
                End If
            Case 6 ' ^
                lblExpressionResult.Text = "Result: " & a.ToString() & " ^ " & b.ToString() & " = " & (a ^ b).ToString()
            Case 7 ' &
                lblExpressionResult.Text = "Result: """ & txtOperandA.Text & """ & """ & txtOperandB.Text & """ = """ & (txtOperandA.Text & txtOperandB.Text) & """"
        End Select
    End Sub

End Class