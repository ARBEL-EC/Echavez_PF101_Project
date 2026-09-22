Public Class frmOrientations

    Private Sub frmOrientations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeManager.ApplyTheme(Me)
        ' Find the TabControl container on the form automatically
        Dim tc As TabControl = Me.Controls.OfType(Of TabControl)().FirstOrDefault()

        If tc IsNot Nothing Then
            ' =========================================================
            ' 1. TAB 1: Vision, Mission & Values
            ' =========================================================
            If tc.TabPages.Count > 0 Then
                Dim tabVision As TabPage = tc.TabPages(0)
                tabVision.Text = "Vision, Mission & Values"

                Dim tbVision As New TextBox()
                tbVision.Multiline = True
                tbVision.ReadOnly = True
                tbVision.Dock = DockStyle.Fill
                tbVision.ScrollBars = ScrollBars.Vertical
                tbVision.Font = New Font("Segoe UI", 10)
                tbVision.Text = "QUEZON CITY UNIVERSITY (QCU)" & vbCrLf &
                                "San Bartolome | San Francisco | Batasan Hills" & vbCrLf &
                                "College of Computer Studies - Information Technology Department" & vbCrLf & vbCrLf &
                                "=======================================================" & vbCrLf &
                                "UNIVERSITY VISION:" & vbCrLf &
                                "To be recognized as the #1 local university of employable graduates." & vbCrLf & vbCrLf &
                                "UNIVERSITY MISSION:" & vbCrLf &
                                "To provide a comprehensive education that enhances the lives of QCU students for nation building and as world citizens." & vbCrLf & vbCrLf &
                                "CORE VALUES (RISE):" & vbCrLf &
                                "  • R - Resiliency" & vbCrLf &
                                "  • I - Innovativeness" & vbCrLf &
                                "  • S - Stewardship" & vbCrLf &
                                "  • E - Equity" & vbCrLf & vbCrLf &
                                "ORGANIZATIONAL VALUES (JOY):" & vbCrLf &
                                "  • Jointness of undertaking" & vbCrLf &
                                "  • Organizational adaptability" & vbCrLf &
                                "  • Yoke of Efficiency and Effectiveness"

                tabVision.Controls.Clear()
                tabVision.Controls.Add(tbVision)
            End If

            ' =========================================================
            ' 2. TAB 2: Grading System Calculator
            ' =========================================================
            If tc.TabPages.Count > 1 Then
                tc.TabPages(1).Text = "Grading System Calculator"
            End If

            ' =========================================================
            ' 3. TAB 3: Policies & Attendance
            ' =========================================================
            Dim tabPolicies As TabPage
            If tc.TabPages.Count >= 3 Then
                tabPolicies = tc.TabPages(2)
            Else
                ' If the 3rd tab page was removed, auto-create and attach it
                tabPolicies = New TabPage("Policies & Attendance")
                tc.TabPages.Add(tabPolicies)
            End If

            tabPolicies.Text = "Policies & Attendance"

            Dim tbPolicy As New TextBox()
            tbPolicy.Multiline = True
            tbPolicy.ReadOnly = True
            tbPolicy.Dock = DockStyle.Fill
            tbPolicy.ScrollBars = ScrollBars.Vertical
            tbPolicy.Font = New Font("Segoe UI", 10)
            tbPolicy.Text = "COURSE POLICIES & STANDARDS (PF101):" & vbCrLf &
                            "=======================================================" & vbCrLf &
                            "1. ATTENDANCE POLICY:" & vbCrLf &
                            "   Students are required to attend all classes starting with the first meeting." & vbCrLf &
                            "   A student who has been absent for more than 20 percent of the hours of recitation, " & vbCrLf &
                            "   lectures, or scheduled work shall be automatically dropped from the roll." & vbCrLf & vbCrLf &
                            "2. LANGUAGE OF INSTRUCTION:" & vbCrLf &
                            "   The language of instruction is English." & vbCrLf & vbCrLf &
                            "3. ACADEMIC INTEGRITY:" & vbCrLf &
                            "   Any submitted work must be the student's own work. Plagiarism or cheating results in " & vbCrLf &
                            "   penalties ranging from failing the assignment to failing the class." & vbCrLf & vbCrLf &
                            "4. CLASSROOM PROTOCOL:" & vbCrLf &
                            "   • Profile picture must be the student's own photo." & vbCrLf &
                            "   • Naming convention: (Lastname, Firstname MI.)." & vbCrLf &
                            "   • Attitude over knowledge: Observe respect, discipline, and proper attire."

            tabPolicies.Controls.Clear()
            tabPolicies.Controls.Add(tbPolicy)
        End If
    End Sub

    Private Sub btnCalculateTerm_Click(sender As Object, e As EventArgs) Handles btnCalculateTerm.Click
        Dim classStanding, examScore As Decimal

        If Decimal.TryParse(txtClassStanding.Text, classStanding) AndAlso Decimal.TryParse(txtExam.Text, examScore) Then
            If classStanding >= 0 AndAlso classStanding <= 100 AndAlso examScore >= 0 AndAlso examScore <= 100 Then
                ' QCU Grading Formula: Term Grade = (Class Standing * 60%) + (Exam * 40%)
                Dim termGrade As Decimal = (classStanding * 0.6D) + (examScore * 0.4D)
                lblTermResult.Text = "Term Grade: " & termGrade.ToString("N2") & "%"
                lblTermResult.ForeColor = If(termGrade >= 75D, Color.DarkGreen, Color.Red)
            Else
                MessageBox.Show("Please enter valid scores between 0 and 100.", "Range Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Please enter numeric scores for Class Standing and Exam.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnCalculateFinal_Click(sender As Object, e As EventArgs) Handles btnCalculateFinal.Click
        Dim mtg, ftg As Decimal

        If Decimal.TryParse(txtMTG.Text, mtg) AndAlso Decimal.TryParse(txtFTG.Text, ftg) Then
            ' QCU Grading Formula: Final Grade = (MTG + FTG) / 2
            Dim finalGrade As Decimal = (mtg + ftg) / 2D
            Dim status As String = If(finalGrade >= 75D, "PASSED", "FAILED")

            lblFinalResult.Text = "Final Grade: " & finalGrade.ToString("N2") & "% (" & status & ")"
            lblFinalResult.ForeColor = If(finalGrade >= 75D, Color.DarkGreen, Color.Red)
        Else
            MessageBox.Show("Please enter numeric values for both MTG and FTG.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class