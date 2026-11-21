Public Class frmLesson4_Controls

    Private dynamicCounter As Integer = 0
    Private testWindow As Form = Nothing

    Private Sub frmLesson4_Controls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeManager.ApplyTheme(Me)

        ' 1. Populate BorderStyle Dropdown
        cboBorderStyle.Items.Clear()
        cboBorderStyle.Items.AddRange(New Object() {
            "Sizable (Default)",
            "FixedSingle",
            "Fixed3D",
            "FixedDialog",
            "FixedToolWindow",
            "None"
        })
        cboBorderStyle.SelectedIndex = 0

        ' 2. Populate Layout Theory Text
        txtLayoutTheory.Text =
            "WEEK 4 - PLANNING APPLICATIONS & DESIGNING INTERFACES" & vbCrLf &
            "=======================================================" & vbCrLf & vbCrLf &
            "1. WINDOWS FORM PROPERTIES:" & vbCrLf &
            "   • FormBorderStyle: Controls border frame appearance and window resizability." & vbCrLf &
            "   • Opacity: Sets form transparency level (10% to 100%)." & vbCrLf &
            "   • StartPosition: Determines screen positioning upon launch (CenterScreen, Manual)." & vbCrLf &
            "   • WindowState: Maximized, Minimized, or Normal." & vbCrLf &
            "   • TopMost: Forces window to float permanently above other windows." & vbCrLf & vbCrLf &
            "2. ANCHOR VS. DOCK:" & vbCrLf &
            "   • Anchor: Maintains fixed distances between control edges and parent form edges." & vbCrLf &
            "     When the user resizes the window, anchored controls stretch or move proportionally." & vbCrLf &
            "   • Dock: Snaps the control to flush against one border (Top, Bottom, Left, Right)" & vbCrLf &
            "     or expands it to occupy all remaining client area (Fill)." & vbCrLf & vbCrLf &
            "3. COMMON DIALOG CONTROLS:" & vbCrLf &
            "   • ColorDialog: Standard Windows color selection palette." & vbCrLf &
            "   • FontDialog: Typography, font style, and point size selector." & vbCrLf &
            "   • MessageBox: Displays modal prompts returning DialogResult (Yes, No, Cancel)." & vbCrLf & vbCrLf &
            "4. RUNTIME EVENT HANDLERS:" & vbCrLf &
            "   • AddHandler object.Event, AddressOf MethodName: Attaches events dynamically." & vbCrLf &
            "   • RemoveHandler object.Event, AddressOf MethodName: Detaches events to prevent memory leaks."

        ' Make the separate test window available from a visible layout row.
        CreateTestWindowButton()
    End Sub

    ' =========================================================
    ' INTERACTIVE LIVE TEST WINDOW CONTROLLER
    ' =========================================================
    Private Function GetOrCreateTestWindow() As Form
        If testWindow Is Nothing OrElse testWindow.IsDisposed Then
            testWindow = New Form()
            testWindow.Text = "PF101 - Live Form Properties Testbench"
            testWindow.Size = New Size(380, 250)
            testWindow.StartPosition = FormStartPosition.CenterScreen
            testWindow.BackColor = ColorTranslator.FromHtml("#1A1E26")
            testWindow.ForeColor = ColorTranslator.FromHtml("#F8FAFC")

            Dim lblMsg As New Label()
            lblMsg.Text = "Live Form Testbench" & vbCrLf & vbCrLf &
                          "Change the Border Style, Opacity, or TopMost" & vbCrLf &
                          "in Lesson 4 to see me transform live!"
            lblMsg.Dock = DockStyle.Fill
            lblMsg.TextAlign = ContentAlignment.MiddleCenter
            lblMsg.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
            testWindow.Controls.Add(lblMsg)

            testWindow.FormBorderStyle = SelectedBorderStyle()
            testWindow.Opacity = Math.Max(0.1, tbOpacity.Value / 100.0)
            testWindow.TopMost = chkTopMost.Checked
            testWindow.Show(TopLevelControl)
        End If
        Return testWindow
    End Function

    Private Sub CreateTestWindowButton()
        Dim btnOpen As New Button With {
            .Name = "btnOpenTestWindow",
            .Text = "Open Live Test Window",
            .AutoSize = True,
            .MinimumSize = New Size(190, 34),
            .Anchor = AnchorStyles.Left,
            .Margin = New Padding(6),
            .TabIndex = 5,
            .Cursor = Cursors.Hand
        }

        AddHandler btnOpen.Click, Sub(s, e)
                                      Dim tw = GetOrCreateTestWindow()
                                      tw.BringToFront()
                                  End Sub

        propertyLayout.RowCount += 1
        propertyLayout.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        propertyLayout.Controls.Add(btnOpen, 0, propertyLayout.RowCount - 1)
        ThemeManager.ApplyTheme(btnOpen)
    End Sub

    ' Opacity manipulation (10% to 100%)
    Private Sub tbOpacity_Scroll(sender As Object, e As EventArgs) Handles tbOpacity.Scroll
        Dim alpha As Double = Math.Max(0.1, tbOpacity.Value / 100.0)
        lblOpacityVal.Text = "Current Opacity: " & tbOpacity.Value.ToString() & "%"

        Dim tw = GetOrCreateTestWindow()
        tw.Opacity = alpha
    End Sub

    ' Border style manipulation
    Private Sub cboBorderStyle_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboBorderStyle.SelectionChangeCommitted
        Dim tw = GetOrCreateTestWindow()

        tw.FormBorderStyle = SelectedBorderStyle()
    End Sub

    Private Function SelectedBorderStyle() As FormBorderStyle
        Select Case cboBorderStyle.SelectedIndex
            Case 1 : Return FormBorderStyle.FixedSingle
            Case 2 : Return FormBorderStyle.Fixed3D
            Case 3 : Return FormBorderStyle.FixedDialog
            Case 4 : Return FormBorderStyle.FixedToolWindow
            Case 5 : Return FormBorderStyle.None
            Case Else : Return FormBorderStyle.Sizable
        End Select
    End Function

    ' TopMost manipulation
    Private Sub chkTopMost_CheckedChanged(sender As Object, e As EventArgs) Handles chkTopMost.CheckedChanged
        Dim tw = GetOrCreateTestWindow()
        tw.TopMost = chkTopMost.Checked
    End Sub

    ' =========================================================
    ' TAB 2: BASIC CONTROLS & COMMON DIALOGS
    ' =========================================================
    Private Sub btnProgressStep_Click(sender As Object, e As EventArgs) Handles btnProgressStep.Click
        If Not chkEnable.Checked Then
            MessageBox.Show("Please check 'Enable Progress Simulator' first.", "Control Disabled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim increment As Integer = If(rbSpeedFast.Checked, 25, 10)
        If prgBar.Value + increment <= prgBar.Maximum Then
            prgBar.Value += increment
        Else
            prgBar.Value = prgBar.Maximum
        End If

        lblProgress.Text = "Progress: " & prgBar.Value.ToString() & "% (Target: " & dtpTarget.Value.ToShortDateString() & ")"
        If prgBar.Value = 100 Then
            MessageBox.Show("Progress Complete!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnColorDialog_Click(sender As Object, e As EventArgs) Handles btnColorDialog.Click
        Using cd As New ColorDialog()
            If cd.ShowDialog() = DialogResult.OK Then
                lblDialogPreview.ForeColor = cd.Color
                lblDialogPreview.Text = "Fore Color: " & cd.Color.Name
            End If
        End Using
    End Sub

    Private Sub btnFontDialog_Click(sender As Object, e As EventArgs) Handles btnFontDialog.Click
        Using fd As New FontDialog()
            If fd.ShowDialog() = DialogResult.OK Then
                lblDialogPreview.Font = fd.Font
            End If
        End Using
    End Sub

    Private Sub btnConfirmDialog_Click(sender As Object, e As EventArgs) Handles btnConfirmDialog.Click
        Dim result As DialogResult = MessageBox.Show(
            Me,
            "Reset the preview text to its default font and color?",
            "Reset Preview Styles",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question)

        Select Case result
            Case DialogResult.Yes
                lblDialogPreview.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
                lblDialogPreview.ForeColor = Color.White
                lblDialogResultOutput.Text = "DialogResult: Yes - Preview styles reset to defaults."
            Case DialogResult.No
                lblDialogResultOutput.Text = "DialogResult: No - Preview styles were not changed."
            Case DialogResult.Cancel
                lblDialogResultOutput.Text = "DialogResult: Cancel - No action was taken."
        End Select
    End Sub

    ' =========================================================
    ' TAB 3: RUNTIME DYNAMIC CONTROL CREATION & ADDHANDLER
    ' =========================================================
    Private Sub btnCreateDynamic_Click(sender As Object, e As EventArgs) Handles btnCreateDynamic.Click
        dynamicCounter += 1
        Dim dynBtn As New Button()
        dynBtn.Name = "btnDyn_" & dynamicCounter.ToString()
        dynBtn.Text = "Dynamic Button #" & dynamicCounter.ToString()
        dynBtn.Size = New Size(170, 35)

        ThemeManager.ApplyTheme(dynBtn)
        AddHandler dynBtn.Click, AddressOf DynamicButton_Click

        pnlDynamic.Controls.Add(dynBtn)
    End Sub

    Private Sub DynamicButton_Click(sender As Object, e As EventArgs)
        Dim clickedBtn As Button = DirectCast(sender, Button)
        MessageBox.Show("Runtime Event Triggered by: " & clickedBtn.Text & vbCrLf &
                        "Control Name: " & clickedBtn.Name, "AddHandler Event", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnClearDynamic_Click(sender As Object, e As EventArgs) Handles btnClearDynamic.Click
        For Each ctrl As Control In pnlDynamic.Controls
            If TypeOf ctrl Is Button Then
                RemoveHandler ctrl.Click, AddressOf DynamicButton_Click
            End If
        Next
        pnlDynamic.Controls.Clear()
        dynamicCounter = 0
    End Sub

    Private Sub txtLayoutTheory_TextChanged(sender As Object, e As EventArgs) Handles txtLayoutTheory.TextChanged
    End Sub

    ' Automatically clean up test window if lesson is switched
    Protected Overrides Sub OnHandleDestroyed(e As EventArgs)
        If testWindow IsNot Nothing AndAlso Not testWindow.IsDisposed Then
            testWindow.Close()
            testWindow.Dispose()
            testWindow = Nothing
        End If
        MyBase.OnHandleDestroyed(e)
    End Sub

End Class