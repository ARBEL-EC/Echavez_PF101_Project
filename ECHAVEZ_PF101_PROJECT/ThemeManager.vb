' =====================================================================================
'  ThemeManager.vb  -  Runtime "Modern Elevated Slate" theme for Windows Forms (VB.NET)
'
'  Usage (first line of every Form's Load handler):
'      ThemeManager.ApplyTheme(Me)
'
'  - No *.Designer.vb changes needed; everything happens at runtime.
'  - Recursively styles nested containers (TabControl/TabPage/GroupBox/Panel/...).
'  - Turns on DoubleBuffered (via reflection) for forms and containers.
'  - Flat, modern MenuStrip / StatusStrip / ToolStrip / ContextMenuStrip renderer.
'  - Automatically strips and locks window borders for embedded child forms.
' =====================================================================================
Option Strict On
Option Explicit On
Option Infer On

Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Globalization
Imports System.Linq
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Module ThemeManager

#Region "Palette & settings"

    ' Elevated Slate / High-Contrast Palette
    Public ReadOnly ClrBackground As Color = ColorTranslator.FromHtml("#0F1117")   ' forms, main workspace background
    Public ReadOnly ClrSurface As Color = ColorTranslator.FromHtml("#1A1E26")      ' panels, cards, tabs, groupboxes
    Public ReadOnly ClrInput As Color = ColorTranslator.FromHtml("#262C3A")        ' TextBox / ListBox / ComboBox (high visibility)
    Public ReadOnly ClrBorder As Color = ColorTranslator.FromHtml("#3E485C")       ' Crisp border highlights
    Public ReadOnly ClrRowAlt As Color = ColorTranslator.FromHtml("#202531")       ' DataGridView alternate rows

    ' Text
    Public ReadOnly ClrText As Color = ColorTranslator.FromHtml("#F8FAFC")         ' Crisp primary white
    Public ReadOnly ClrTextMuted As Color = ColorTranslator.FromHtml("#94A3B8")    ' Secondary slate text
    Public ReadOnly ClrTextDisabled As Color = ColorTranslator.FromHtml("#64748B")

    ' Accents
    Public ReadOnly ClrAccent As Color = ColorTranslator.FromHtml("#2563EB")
    Public ReadOnly ClrAccentHover As Color = ColorTranslator.FromHtml("#3B82F6")
    Public ReadOnly ClrAccentPressed As Color = ColorTranslator.FromHtml("#1D4ED8")
    Public ReadOnly ClrDanger As Color = ColorTranslator.FromHtml("#DC2626")
    Public ReadOnly ClrDangerHover As Color = ColorTranslator.FromHtml("#EF4444")
    Public ReadOnly ClrDangerPressed As Color = ColorTranslator.FromHtml("#B91C1C")
    Public ReadOnly ClrLink As Color = ColorTranslator.FromHtml("#60A5FA")

    ''' <summary>Font family used for standard UI.</summary>
    Public Property FontFamilyName As String = "Segoe UI"
    ''' <summary>Base UI font size in points.</summary>
    Public Property BaseFontSize As Single = 9.5F
    ''' <summary>When True, Labels are bold (headers/labels), as per the design brief.</summary>
    Public Property BoldLabels As Boolean = True

    Public Enum ButtonKind
        Primary
        Secondary
        Danger
    End Enum

#End Region

#Region "Public API"

    Public Sub ApplyTheme(root As Control)
        If root Is Nothing Then Throw New ArgumentNullException(NameOf(root))
        If LicenseManager.UsageMode = LicenseUsageMode.Designtime Then Return
        If root.InvokeRequired Then
            root.Invoke(New Action(Sub() ApplyTheme(root)))
            Return
        End If
        StyleTree(root)
    End Sub

    Public Sub Exclude(ctrl As Control)
        If ctrl Is Nothing Then Return
        StateOf(ctrl).Excluded = True
    End Sub

    Public Sub SetButtonKind(button As Button, kind As ButtonKind)
        If button Is Nothing Then Throw New ArgumentNullException(NameOf(button))
        StateOf(button).Kind = kind
        ApplyButtonKind(button)
    End Sub

    Public Sub UseMonospace(ctrl As Control, Optional family As String = "Consolas")
        If ctrl Is Nothing Then Return
        ctrl.Font = GetFont(family, BaseFontSize, FontStyle.Regular)
    End Sub

#End Region

#Region "Per-control bookkeeping"

    Private NotInheritable Class ThemeState
        Public Excluded As Boolean
        Public Kind As ButtonKind = ButtonKind.Primary
        Public ReadOnly Hooks As New HashSet(Of String)()
        Public ComboSkin As ComboBoxSkin
    End Class

    Private ReadOnly _states As New ConditionalWeakTable(Of Control, ThemeState)()

    Private Function StateOf(c As Control) As ThemeState
        Return _states.GetValue(c, Function(k) New ThemeState())
    End Function

    Private Function IsExcluded(c As Control) As Boolean
        Dim st As ThemeState = Nothing
        Return _states.TryGetValue(c, st) AndAlso st.Excluded
    End Function

    Private Function TryHook(c As Control, key As String) As Boolean
        Return StateOf(c).Hooks.Add(key)
    End Function

#End Region

#Region "Tree traversal"

    Private Sub StyleTree(c As Control)
        If c Is Nothing OrElse c.IsDisposed OrElse IsExcluded(c) Then Return

        Try
            StyleControl(c)
        Catch ex As Exception
            Debug.WriteLine("ThemeManager: could not style " & c.GetType().Name & " '" & c.Name & "': " & ex.Message)
        End Try

        If ShouldRecurse(c) Then
            Dim kids As Control() = c.Controls.Cast(Of Control)().ToArray()
            If kids.Length > 0 Then
                c.SuspendLayout()
                Try
                    For Each kid As Control In kids
                        StyleTree(kid)
                    Next
                Finally
                    c.ResumeLayout(True)
                End Try
            End If
        End If

        HookContainer(c)
    End Sub

    Private Function ShouldRecurse(c As Control) As Boolean
        Return Not (TypeOf c Is UpDownBase OrElse
                    TypeOf c Is ComboBox OrElse
                    TypeOf c Is DataGridView OrElse
                    TypeOf c Is ListView OrElse
                    TypeOf c Is TreeView OrElse
                    TypeOf c Is TextBoxBase OrElse
                    TypeOf c Is DateTimePicker OrElse
                    TypeOf c Is PropertyGrid OrElse
                    TypeOf c Is WebBrowser OrElse
                    TypeOf c Is ToolStrip OrElse
                    TypeOf c Is ScrollBar)
    End Function

    Private Function IsContainerType(c As Control) As Boolean
        If TypeOf c Is ToolStrip Then Return False
        Return TypeOf c Is Panel OrElse
               TypeOf c Is GroupBox OrElse
               TypeOf c Is TabControl OrElse
               TypeOf c Is MdiClient OrElse
               TypeOf c Is ContainerControl
    End Function

    Private Sub HookContainer(c As Control)
        If Not IsContainerType(c) Then Return
        If TryHook(c, "container") Then AddHandler c.ControlAdded, AddressOf OnControlAdded
    End Sub

    Private Sub OnControlAdded(sender As Object, e As ControlEventArgs)
        StyleTree(e.Control)
    End Sub

#End Region

#Region "Control dispatch"

    Private Sub StyleControl(c As Control)
        Dim frm = TryCast(c, Form)
        If frm IsNot Nothing Then
            StyleForm(frm)
            StyleContextMenu(c)
            Return
        End If

        If TypeOf c Is ToolStrip Then
            StyleToolStrip(DirectCast(c, ToolStrip))
        ElseIf TypeOf c Is MdiClient Then
            StyleMdiClient(c)
        ElseIf TypeOf c Is TabControl Then
            ApplyFont(c, False)
            StyleTabControl(DirectCast(c, TabControl))
        ElseIf TypeOf c Is TabPage Then
            ApplyFont(c, False)
            Dim tp = DirectCast(c, TabPage)
            tp.UseVisualStyleBackColor = False
            tp.BackColor = ClrSurface
            tp.ForeColor = ClrText
            EnableDoubleBuffer(tp)
        ElseIf TypeOf c Is GroupBox Then
            StyleGroupBox(DirectCast(c, GroupBox))
        ElseIf TypeOf c Is SplitContainer Then
            ApplyFont(c, False)
            c.BackColor = ClrBackground
            c.ForeColor = ClrText
            EnableDoubleBuffer(c)
        ElseIf TypeOf c Is Panel Then
            ApplyFont(c, False)
            c.BackColor = ClrSurface
            c.ForeColor = ClrText
            Dim pnl = DirectCast(c, Panel)
            If pnl.BorderStyle = BorderStyle.Fixed3D Then pnl.BorderStyle = BorderStyle.FixedSingle
            EnableDoubleBuffer(c)
        ElseIf TypeOf c Is UserControl Then
            ApplyFont(c, False)
            c.BackColor = ClrSurface
            c.ForeColor = ClrText
            EnableDoubleBuffer(c)
        ElseIf TypeOf c Is CheckBox OrElse TypeOf c Is RadioButton Then
            StyleToggle(DirectCast(c, ButtonBase))
        ElseIf TypeOf c Is Button Then
            StyleButton(DirectCast(c, Button))
        ElseIf TypeOf c Is Label Then
            StyleLabel(DirectCast(c, Label))
        ElseIf TypeOf c Is TextBoxBase Then
            StyleTextBox(DirectCast(c, TextBoxBase))
        ElseIf TypeOf c Is ListBox Then
            StyleListBox(DirectCast(c, ListBox))
        ElseIf TypeOf c Is ComboBox Then
            StyleComboBox(DirectCast(c, ComboBox))
        ElseIf TypeOf c Is UpDownBase Then
            ApplyFont(c, False)
            Dim ud = DirectCast(c, UpDownBase)
            ud.BackColor = ClrInput
            ud.ForeColor = ClrText
            ud.BorderStyle = BorderStyle.FixedSingle
        ElseIf TypeOf c Is ProgressBar Then
            StyleProgressBar(DirectCast(c, ProgressBar))
        ElseIf TypeOf c Is TrackBar Then
            c.BackColor = ParentBack(c)
        ElseIf TypeOf c Is ListView Then
            StyleListView(DirectCast(c, ListView))
        ElseIf TypeOf c Is TreeView Then
            StyleTreeView(DirectCast(c, TreeView))
        ElseIf TypeOf c Is DataGridView Then
            StyleDataGridView(DirectCast(c, DataGridView))
        Else
            ApplyFont(c, False)
        End If

        StyleContextMenu(c)
    End Sub

    Private Sub StyleContextMenu(c As Control)
        Dim cms = c.ContextMenuStrip
        If cms IsNot Nothing Then StyleToolStrip(cms)
    End Sub

#End Region

#Region "Forms & MDI"

    Private Sub StyleForm(f As Form)
        f.BackColor = ClrBackground
        f.ForeColor = ClrText
        ApplyFont(f, False)
        EnableDoubleBuffer(f)

        ' --- EMBEDDED DASHBOARD CHILD FORM GUARD (Fixes Lesson 4 border) ---
        If Not f.TopLevel Then
            f.FormBorderStyle = FormBorderStyle.None
            f.ControlBox = False
            f.MaximizeBox = False
            f.MinimizeBox = False
            f.ShowIcon = False
            f.Text = String.Empty

            ' Intercept any runtime dropdowns/code attempting to restore Sizable border
            If TryHook(f, "embedded_border_lock") Then
                AddHandler f.Layout, Sub(sender As Object, e As LayoutEventArgs)
                                         Dim emb = TryCast(sender, Form)
                                         If emb IsNot Nothing AndAlso Not emb.TopLevel Then
                                             If emb.FormBorderStyle <> FormBorderStyle.None Then
                                                 emb.FormBorderStyle = FormBorderStyle.None
                                             End If
                                         End If
                                     End Sub
            End If
            Return
        End If

        ' Main Top-Level Form handling
        If f.MdiParent Is Nothing Then
            If TryHook(f, "chrome") Then AddHandler f.HandleCreated, AddressOf OnFormHandleCreated
            If f.IsHandleCreated Then EnableDarkTitleBar(f)
        End If
    End Sub

    Private Sub OnFormHandleCreated(sender As Object, e As EventArgs)
        EnableDarkTitleBar(DirectCast(sender, Form))
    End Sub

    Private Sub StyleMdiClient(c As Control)
        c.BackColor = ClrBackground
        If TryHook(c, "mdi") Then AddHandler c.HandleCreated, AddressOf OnMdiHandleCreated
        If c.IsHandleCreated Then RemoveClientEdge(c)
    End Sub

    Private Sub OnMdiHandleCreated(sender As Object, e As EventArgs)
        RemoveClientEdge(DirectCast(sender, Control))
    End Sub

#End Region

#Region "Simple controls"

    Private Sub StyleLabel(lbl As Label)
        ApplyFont(lbl, BoldLabels)
        lbl.UseCompatibleTextRendering = False
        If lbl.FlatStyle = FlatStyle.System Then lbl.FlatStyle = FlatStyle.Standard
        lbl.BackColor = Color.Transparent
        lbl.ForeColor = ReadableFore(lbl.ForeColor, ParentBack(lbl), ClrText)

        Dim ll = TryCast(lbl, LinkLabel)
        If ll IsNot Nothing Then
            ll.LinkColor = ClrLink
            ll.ActiveLinkColor = ColorTranslator.FromHtml("#93C5FD")
            ll.VisitedLinkColor = ColorTranslator.FromHtml("#A78BFA")
            ll.DisabledLinkColor = ClrTextDisabled
        End If
    End Sub

    Private Sub StyleToggle(b As ButtonBase)
        ApplyFont(b, False)
        b.UseCompatibleTextRendering = False
        If b.FlatStyle = FlatStyle.System Then b.FlatStyle = FlatStyle.Standard
        b.UseVisualStyleBackColor = False
        b.BackColor = Color.Transparent
        b.ForeColor = ReadableFore(b.ForeColor, ParentBack(b), ClrText)
        b.FlatAppearance.CheckedBackColor = ClrAccent
        b.FlatAppearance.BorderColor = ClrBorder
    End Sub

    Private Sub StyleButton(b As Button)
        ApplyFont(b, False)
        b.UseCompatibleTextRendering = False
        b.FlatStyle = FlatStyle.Flat
        b.UseVisualStyleBackColor = False
        If b.Cursor = Cursors.Default Then b.Cursor = Cursors.Hand
        If TryHook(b, "button") Then AddHandler b.EnabledChanged, AddressOf OnButtonEnabledChanged
        ApplyButtonKind(b)
    End Sub

    Private Sub OnButtonEnabledChanged(sender As Object, e As EventArgs)
        ApplyButtonKind(DirectCast(sender, Button))
    End Sub

    Private Sub ApplyButtonKind(b As Button)
        Dim back, hover, down, border As Color
        Dim fore As Color = ClrText
        Dim borderSize As Integer = 0

        Select Case StateOf(b).Kind
            Case ButtonKind.Secondary
                back = ClrInput : hover = ClrBorder : down = ClrSurface
                border = ClrBorder : borderSize = 1
            Case ButtonKind.Danger
                back = ClrDanger : hover = ClrDangerHover : down = ClrDangerPressed
                border = ClrDanger
            Case Else
                back = ClrAccent : hover = ClrAccentHover : down = ClrAccentPressed
                border = ClrAccent
        End Select

        If Not b.Enabled Then
            back = ClrInput : hover = ClrInput : down = ClrInput
            fore = ClrTextDisabled : borderSize = 0
        End If

        b.BackColor = back
        b.ForeColor = fore
        With b.FlatAppearance
            .BorderSize = borderSize
            .BorderColor = border
            .MouseOverBackColor = hover
            .MouseDownBackColor = down
        End With
    End Sub

    Private Sub StyleTextBox(tb As TextBoxBase)
        ApplyFont(tb, False)
        tb.BackColor = ClrInput
        Dim rtb = TryCast(tb, RichTextBox)
        If rtb Is Nothing OrElse rtb.TextLength = 0 OrElse rtb.ForeColor.IsSystemColor Then tb.ForeColor = ClrText
        tb.BorderStyle = BorderStyle.FixedSingle
        If tb.Multiline Then HookNativeTheme(tb)
    End Sub

    Private Sub StyleListBox(lb As ListBox)
        ApplyFont(lb, False)
        lb.BackColor = ClrInput
        lb.ForeColor = ClrText
        lb.BorderStyle = BorderStyle.FixedSingle
        HookNativeTheme(lb)
    End Sub

    Private Sub StyleComboBox(cb As ComboBox)
        ApplyFont(cb, False)
        cb.FlatStyle = FlatStyle.Flat
        cb.BackColor = ClrInput
        cb.ForeColor = ClrText
        If cb.DropDownStyle <> ComboBoxStyle.Simple AndAlso TryHook(cb, "combo") Then
            StateOf(cb).ComboSkin = New ComboBoxSkin(cb)
        End If
    End Sub

    Private Sub StyleListView(lv As ListView)
        ApplyFont(lv, False)
        lv.BackColor = ClrInput
        lv.ForeColor = ClrText
        lv.BorderStyle = BorderStyle.FixedSingle
        EnableDoubleBuffer(lv)
        HookNativeTheme(lv)
    End Sub

    Private Sub StyleTreeView(tv As TreeView)
        ApplyFont(tv, False)
        tv.BackColor = ClrInput
        tv.ForeColor = ClrText
        tv.LineColor = ClrTextMuted
        tv.BorderStyle = BorderStyle.FixedSingle
        EnableDoubleBuffer(tv)
        HookNativeTheme(tv)
    End Sub

    Private Sub StyleDataGridView(dgv As DataGridView)
        ApplyFont(dgv, False)
        EnableDoubleBuffer(dgv)
        dgv.EnableHeadersVisualStyles = False
        dgv.BackgroundColor = ClrBackground
        dgv.GridColor = ClrBorder
        dgv.BorderStyle = BorderStyle.None
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        With dgv.ColumnHeadersDefaultCellStyle
            .BackColor = ClrInput
            .ForeColor = ClrText
            .SelectionBackColor = ClrInput
            .SelectionForeColor = ClrText
            .Font = GetFont(FontFamilyName, BaseFontSize, FontStyle.Bold)
        End With
        With dgv.RowHeadersDefaultCellStyle
            .BackColor = ClrSurface
            .ForeColor = ClrText
            .SelectionBackColor = ClrSurface
            .SelectionForeColor = ClrText
        End With
        With dgv.DefaultCellStyle
            .BackColor = ClrSurface
            .ForeColor = ClrText
            .SelectionBackColor = ClrAccent
            .SelectionForeColor = ClrText
        End With
        With dgv.AlternatingRowsDefaultCellStyle
            .BackColor = ClrRowAlt
            .ForeColor = ClrText
            .SelectionBackColor = ClrAccent
            .SelectionForeColor = ClrText
        End With
    End Sub

#End Region

#Region "GroupBox (custom painted with visible border)"

    Private Sub StyleGroupBox(gb As GroupBox)
        ApplyFont(gb, False)
        gb.FlatStyle = FlatStyle.Standard
        gb.UseCompatibleTextRendering = False
        gb.BackColor = ClrSurface
        gb.ForeColor = ClrText
        EnableDoubleBuffer(gb)
        If TryHook(gb, "group") Then AddHandler gb.Paint, AddressOf GroupBox_Paint
        gb.Invalidate()
    End Sub

    Private Sub GroupBox_Paint(sender As Object, e As PaintEventArgs)
        Dim gb = DirectCast(sender, GroupBox)
        Dim g = e.Graphics
        g.Clear(gb.BackColor)

        Dim titleFont = GetFont(gb.Font.FontFamily.Name, gb.Font.SizeInPoints, gb.Font.Style Or FontStyle.Bold)
        Dim flags = TextFormatFlags.NoPadding Or TextFormatFlags.SingleLine Or TextFormatFlags.HidePrefix Or TextFormatFlags.Left
        Dim hasText = Not String.IsNullOrEmpty(gb.Text)
        Dim sz As Size = If(hasText,
                            TextRenderer.MeasureText(g, gb.Text, titleFont, New Size(Integer.MaxValue, Integer.MaxValue), flags),
                            Size.Empty)

        Dim topY As Integer = Math.Max(sz.Height, gb.Font.Height) \ 2
        Dim border As New Rectangle(0, topY, gb.Width - 1, gb.Height - topY - 1)

        g.SmoothingMode = SmoothingMode.AntiAlias
        Dim saved = g.Save()
        If hasText Then g.SetClip(New Rectangle(7, 0, sz.Width + 8, sz.Height), CombineMode.Exclude)
        Using path = RoundedRect(border, 4)
            Using p As New Pen(ClrBorder, 1.2F)
                g.DrawPath(p, path)
            End Using
        End Using
        g.Restore(saved)

        If hasText Then
            TextRenderer.DrawText(g, gb.Text, titleFont, New Point(11, 0),
                                  If(gb.Enabled, gb.ForeColor, ClrTextDisabled), gb.BackColor, flags)
        End If
    End Sub

#End Region

#Region "TabControl (owner-drawn, borderless)"

    Private Sub StyleTabControl(tc As TabControl)
        If tc.Alignment <> TabAlignment.Top Then Return

        If TryHook(tc, "tab") Then
            tc.DrawMode = TabDrawMode.OwnerDrawFixed
            tc.SizeMode = TabSizeMode.Fixed
            tc.Appearance = TabAppearance.Normal
            tc.ItemSize = MeasureTabs(tc)

            SetControlStyle(tc, ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or
                                ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw, True)

            AddHandler tc.Paint, AddressOf TabControl_Paint
            AddHandler tc.SelectedIndexChanged, AddressOf TabControl_Invalidate
            AddHandler tc.MouseMove, AddressOf TabControl_MouseMove
            AddHandler tc.MouseLeave, AddressOf TabControl_Invalidate
        End If
        tc.Invalidate()
    End Sub

    Private Function MeasureTabs(tc As TabControl) As Size
        Dim w As Integer = 0
        For Each page As TabPage In tc.TabPages
            w = Math.Max(w, TextRenderer.MeasureText(page.Text, tc.Font).Width)
        Next
        Return New Size(Math.Max(w + 40, 115), 34)
    End Function

    Private Sub TabControl_Invalidate(sender As Object, e As EventArgs)
        DirectCast(sender, Control).Invalidate()
    End Sub

    Private Sub TabControl_MouseMove(sender As Object, e As MouseEventArgs)
        Dim tc = DirectCast(sender, TabControl)
        tc.Invalidate(New Rectangle(0, 0, tc.Width, tc.ItemSize.Height + 4))
    End Sub

    Private Sub TabControl_Paint(sender As Object, e As PaintEventArgs)
        Dim tc = DirectCast(sender, TabControl)
        Dim g = e.Graphics
        g.Clear(ClrBackground)

        Dim stripBottom As Integer = If(tc.TabCount > 0, 0, tc.ItemSize.Height)
        For i As Integer = 0 To tc.TabCount - 1
            stripBottom = Math.Max(stripBottom, tc.GetTabRect(i).Bottom)
        Next

        ' Page area
        Dim pageRect As New Rectangle(0, stripBottom, tc.Width - 1, tc.Height - stripBottom - 1)
        Using b As New SolidBrush(ClrSurface)
            g.FillRectangle(b, pageRect)
        End Using
        Using p As New Pen(ClrBorder)
            g.DrawRectangle(p, pageRect)
        End Using

        ' Tabs
        Dim mouse As Point = tc.PointToClient(Control.MousePosition)
        Dim hotBack As Color = Blend(ClrBackground, ClrSurface, 0.6)
        Dim flags = TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter Or
                    TextFormatFlags.SingleLine Or TextFormatFlags.EndEllipsis Or TextFormatFlags.NoPrefix

        For i As Integer = 0 To tc.TabCount - 1
            Dim r As Rectangle = tc.GetTabRect(i)
            Dim isSel As Boolean = (i = tc.SelectedIndex)
            Dim isHot As Boolean = (Not isSel) AndAlso r.Contains(mouse)
            Dim back As Color = If(isSel, ClrSurface, If(isHot, hotBack, ClrBackground))
            Dim fore As Color = If(isSel OrElse isHot, ClrText, ClrTextMuted)

            Using b As New SolidBrush(back)
                g.FillRectangle(b, r)
            End Using

            If isSel Then
                Using accent As New SolidBrush(ClrAccent)
                    g.FillRectangle(accent, r.X, r.Y, r.Width, 2)
                End Using
                Using seam As New SolidBrush(ClrSurface)
                    g.FillRectangle(seam, r.X + 1, stripBottom, r.Width - 1, 1)
                End Using
            End If

            TextRenderer.DrawText(g, tc.TabPages(i).Text, tc.Font, r, fore, back, flags)
        Next
    End Sub

#End Region

#Region "ProgressBar (flat)"

    Private Sub StyleProgressBar(pb As ProgressBar)
        pb.BackColor = ClrInput
        pb.ForeColor = ClrAccent

        If pb.Style = ProgressBarStyle.Marquee Then
            HookNativeTheme(pb)
            Return
        End If

        If TryHook(pb, "progress") Then
            SetControlStyle(pb, ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or
                                ControlStyles.OptimizedDoubleBuffer, True)
            AddHandler pb.Paint, AddressOf ProgressBar_Paint
        End If
        pb.Invalidate()
    End Sub

    Private Sub ProgressBar_Paint(sender As Object, e As PaintEventArgs)
        Dim pb = DirectCast(sender, ProgressBar)
        Dim g = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.Clear(ParentBack(pb))

        Dim rc As New Rectangle(0, 0, pb.Width - 1, pb.Height - 1)
        If rc.Width < 2 OrElse rc.Height < 2 Then Return

        Using path = RoundedRect(rc, Math.Min(rc.Height \ 2, 6))
            Using track As New SolidBrush(ClrInput)
                g.FillPath(track, path)
            End Using

            Dim range As Integer = pb.Maximum - pb.Minimum
            If range > 0 AndAlso pb.Value > pb.Minimum Then
                Dim w As Integer = CInt(Math.Round(pb.Width * ((pb.Value - pb.Minimum) / CDbl(range))))
                Dim saved = g.Save()
                g.SetClip(path, CombineMode.Intersect)
                Using fill As New SolidBrush(ClrAccent)
                    g.FillRectangle(fill, 0, 0, w, pb.Height)
                End Using
                g.Restore(saved)
            End If
        End Using
    End Sub

#End Region

#Region "ToolStrip / MenuStrip / StatusStrip"

    Private ReadOnly _renderer As New ModernToolStripRenderer()

    Private Sub StyleToolStrip(ts As ToolStrip)
        ts.Renderer = _renderer
        ts.BackColor = ClrSurface
        ts.ForeColor = ClrText
        ApplyFont(ts, False)
        ts.GripStyle = ToolStripGripStyle.Hidden
        StyleToolStripItems(ts.Items)
    End Sub

    Private Sub StyleToolStripItems(items As ToolStripItemCollection)
        For Each item As ToolStripItem In items
            Dim host = TryCast(item, ToolStripControlHost)
            If host IsNot Nothing AndAlso host.Control IsNot Nothing Then StyleTree(host.Control)

            Dim ddi = TryCast(item, ToolStripDropDownItem)
            If ddi IsNot Nothing AndAlso ddi.HasDropDownItems Then
                Dim dd = ddi.DropDown
                dd.Renderer = _renderer
                dd.BackColor = ClrSurface
                dd.ForeColor = ClrText
                dd.Font = ResolveFont(dd.Font, False)
                StyleToolStripItems(ddi.DropDownItems)
            End If
        Next
    End Sub

    Public NotInheritable Class ModernToolStripRenderer
        Inherits ToolStripProfessionalRenderer

        Public Sub New()
            MyBase.New(New ModernColorTable())
            RoundedEdges = False
        End Sub

        Protected Overrides Sub OnRenderToolStripBackground(e As ToolStripRenderEventArgs)
            Using b As New SolidBrush(ClrSurface)
                e.Graphics.FillRectangle(b, e.AffectedBounds)
            End Using
        End Sub

        Protected Overrides Sub OnRenderToolStripBorder(e As ToolStripRenderEventArgs)
            Dim ts = e.ToolStrip
            Using p As New Pen(If(TypeOf ts Is ToolStripDropDown, ClrBorder, ClrInput))
                If TypeOf ts Is ToolStripDropDown Then
                    e.Graphics.DrawRectangle(p, 0, 0, ts.Width - 1, ts.Height - 1)
                ElseIf TypeOf ts Is StatusStrip Then
                    e.Graphics.DrawLine(p, 0, 0, ts.Width, 0)
                Else
                    e.Graphics.DrawLine(p, 0, ts.Height - 1, ts.Width, ts.Height - 1)
                End If
            End Using
        End Sub

        Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)
            Dim item = e.Item
            If Not item.Enabled Then Return
            If item.Selected OrElse item.Pressed Then
                Dim rc As New Rectangle(Point.Empty, item.Size)
                rc = If(item.IsOnDropDown, Rectangle.Inflate(rc, -3, -1), Rectangle.Inflate(rc, 0, -1))
                Dim g = e.Graphics
                Dim oldMode = g.SmoothingMode
                g.SmoothingMode = SmoothingMode.AntiAlias
                Using path = RoundedRect(rc, 4)
                    Using b As New SolidBrush(ClrInput)
                        g.FillPath(b, path)
                    End Using
                End Using
                g.SmoothingMode = oldMode
            End If
        End Sub

        Protected Overrides Sub OnRenderItemText(e As ToolStripItemTextRenderEventArgs)
            If Not e.Item.Enabled Then
                e.TextColor = ClrTextDisabled
            ElseIf e.Item.ForeColor.IsSystemColor Then
                e.TextColor = ClrText
            End If
            MyBase.OnRenderItemText(e)
        End Sub

        Protected Overrides Sub OnRenderArrow(e As ToolStripArrowRenderEventArgs)
            e.ArrowColor = If(e.Item.Enabled, ClrTextMuted, ClrTextDisabled)
            MyBase.OnRenderArrow(e)
        End Sub

        Protected Overrides Sub OnRenderSeparator(e As ToolStripSeparatorRenderEventArgs)
            Dim r As New Rectangle(Point.Empty, e.Item.Size)
            Using p As New Pen(ClrBorder)
                If e.Vertical Then
                    Dim x As Integer = r.Width \ 2
                    e.Graphics.DrawLine(p, x, 4, x, r.Height - 4)
                Else
                    Dim y As Integer = r.Height \ 2
                    e.Graphics.DrawLine(p, 6, y, r.Width - 6, y)
                End If
            End Using
        End Sub

        Protected Overrides Sub OnRenderImageMargin(e As ToolStripRenderEventArgs)
        End Sub

        Protected Overrides Sub OnRenderItemCheck(e As ToolStripItemImageRenderEventArgs)
            Dim r As Rectangle = e.ImageRectangle
            Dim g = e.Graphics
            Using b As New SolidBrush(ClrAccent)
                g.FillRectangle(b, r)
            End Using
            Dim oldMode = g.SmoothingMode
            g.SmoothingMode = SmoothingMode.AntiAlias
            Using p As New Pen(Color.White, 1.8F)
                g.DrawLines(p, New PointF() {
                    New PointF(r.Left + r.Width * 0.25F, r.Top + r.Height * 0.55F),
                    New PointF(r.Left + r.Width * 0.43F, r.Top + r.Height * 0.72F),
                    New PointF(r.Left + r.Width * 0.75F, r.Top + r.Height * 0.3F)})
            End Using
            g.SmoothingMode = oldMode
        End Sub
    End Class

    Public NotInheritable Class ModernColorTable
        Inherits ProfessionalColorTable

        Public Sub New()
            UseSystemColors = False
        End Sub

        Public Overrides ReadOnly Property MenuStripGradientBegin As Color
            Get
                Return ClrSurface
            End Get
        End Property

        Public Overrides ReadOnly Property MenuStripGradientEnd As Color
            Get
                Return ClrSurface
            End Get
        End Property

        Public Overrides ReadOnly Property StatusStripGradientBegin As Color
            Get
                Return ClrSurface
            End Get
        End Property

        Public Overrides ReadOnly Property StatusStripGradientEnd As Color
            Get
                Return ClrSurface
            End Get
        End Property

        Public Overrides ReadOnly Property ToolStripGradientBegin As Color
            Get
                Return ClrSurface
            End Get
        End Property

        Public Overrides ReadOnly Property ToolStripGradientMiddle As Color
            Get
                Return ClrSurface
            End Get
        End Property

        Public Overrides ReadOnly Property ToolStripGradientEnd As Color
            Get
                Return ClrSurface
            End Get
        End Property

        Public Overrides ReadOnly Property ToolStripBorder As Color
            Get
                Return ClrBorder
            End Get
        End Property

        Public Overrides ReadOnly Property ToolStripDropDownBackground As Color
            Get
                Return ClrSurface
            End Get
        End Property

        Public Overrides ReadOnly Property ToolStripContentPanelGradientBegin As Color
            Get
                Return ClrBackground
            End Get
        End Property

        Public Overrides ReadOnly Property ToolStripContentPanelGradientEnd As Color
            Get
                Return ClrBackground
            End Get
        End Property

        Public Overrides ReadOnly Property ToolStripPanelGradientBegin As Color
            Get
                Return ClrBackground
            End Get
        End Property

        Public Overrides ReadOnly Property ToolStripPanelGradientEnd As Color
            Get
                Return ClrBackground
            End Get
        End Property

        Public Overrides ReadOnly Property RaftingContainerGradientBegin As Color
            Get
                Return ClrBackground
            End Get
        End Property

        Public Overrides ReadOnly Property RaftingContainerGradientEnd As Color
            Get
                Return ClrBackground
            End Get
        End Property

        Public Overrides ReadOnly Property ImageMarginGradientBegin As Color
            Get
                Return ClrSurface
            End Get
        End Property

        Public Overrides ReadOnly Property ImageMarginGradientMiddle As Color
            Get
                Return ClrSurface
            End Get
        End Property

        Public Overrides ReadOnly Property ImageMarginGradientEnd As Color
            Get
                Return ClrSurface
            End Get
        End Property

        Public Overrides ReadOnly Property ImageMarginRevealedGradientBegin As Color
            Get
                Return ClrSurface
            End Get
        End Property

        Public Overrides ReadOnly Property ImageMarginRevealedGradientMiddle As Color
            Get
                Return ClrSurface
            End Get
        End Property

        Public Overrides ReadOnly Property ImageMarginRevealedGradientEnd As Color
            Get
                Return ClrSurface
            End Get
        End Property

        Public Overrides ReadOnly Property MenuBorder As Color
            Get
                Return ClrBorder
            End Get
        End Property

        Public Overrides ReadOnly Property MenuItemBorder As Color
            Get
                Return ClrBorder
            End Get
        End Property

        Public Overrides ReadOnly Property MenuItemSelected As Color
            Get
                Return ClrInput
            End Get
        End Property

        Public Overrides ReadOnly Property MenuItemSelectedGradientBegin As Color
            Get
                Return ClrInput
            End Get
        End Property

        Public Overrides ReadOnly Property MenuItemSelectedGradientEnd As Color
            Get
                Return ClrInput
            End Get
        End Property

        Public Overrides ReadOnly Property MenuItemPressedGradientBegin As Color
            Get
                Return ClrInput
            End Get
        End Property

        Public Overrides ReadOnly Property MenuItemPressedGradientMiddle As Color
            Get
                Return ClrInput
            End Get
        End Property

        Public Overrides ReadOnly Property MenuItemPressedGradientEnd As Color
            Get
                Return ClrInput
            End Get
        End Property

        Public Overrides ReadOnly Property ButtonSelectedBorder As Color
            Get
                Return ClrBorder
            End Get
        End Property

        Public Overrides ReadOnly Property ButtonSelectedGradientBegin As Color
            Get
                Return ClrInput
            End Get
        End Property

        Public Overrides ReadOnly Property ButtonSelectedGradientMiddle As Color
            Get
                Return ClrInput
            End Get
        End Property

        Public Overrides ReadOnly Property ButtonSelectedGradientEnd As Color
            Get
                Return ClrInput
            End Get
        End Property

        Public Overrides ReadOnly Property ButtonSelectedHighlight As Color
            Get
                Return ClrInput
            End Get
        End Property

        Public Overrides ReadOnly Property ButtonSelectedHighlightBorder As Color
            Get
                Return ClrBorder
            End Get
        End Property

        Public Overrides ReadOnly Property ButtonPressedBorder As Color
            Get
                Return ClrAccent
            End Get
        End Property

        Public Overrides ReadOnly Property ButtonPressedGradientBegin As Color
            Get
                Return ClrBorder
            End Get
        End Property

        Public Overrides ReadOnly Property ButtonPressedGradientMiddle As Color
            Get
                Return ClrBorder
            End Get
        End Property

        Public Overrides ReadOnly Property ButtonPressedGradientEnd As Color
            Get
                Return ClrBorder
            End Get
        End Property

        Public Overrides ReadOnly Property ButtonPressedHighlight As Color
            Get
                Return ClrBorder
            End Get
        End Property

        Public Overrides ReadOnly Property ButtonPressedHighlightBorder As Color
            Get
                Return ClrAccent
            End Get
        End Property

        Public Overrides ReadOnly Property ButtonCheckedGradientBegin As Color
            Get
                Return ClrInput
            End Get
        End Property

        Public Overrides ReadOnly Property ButtonCheckedGradientMiddle As Color
            Get
                Return ClrInput
            End Get
        End Property

        Public Overrides ReadOnly Property ButtonCheckedGradientEnd As Color
            Get
                Return ClrInput
            End Get
        End Property

        Public Overrides ReadOnly Property ButtonCheckedHighlight As Color
            Get
                Return ClrInput
            End Get
        End Property

        Public Overrides ReadOnly Property ButtonCheckedHighlightBorder As Color
            Get
                Return ClrAccent
            End Get
        End Property

        Public Overrides ReadOnly Property CheckBackground As Color
            Get
                Return ClrAccent
            End Get
        End Property

        Public Overrides ReadOnly Property CheckSelectedBackground As Color
            Get
                Return ClrAccentHover
            End Get
        End Property

        Public Overrides ReadOnly Property CheckPressedBackground As Color
            Get
                Return ClrAccentPressed
            End Get
        End Property

        Public Overrides ReadOnly Property SeparatorDark As Color
            Get
                Return ClrBorder
            End Get
        End Property

        Public Overrides ReadOnly Property SeparatorLight As Color
            Get
                Return ClrBorder
            End Get
        End Property

        Public Overrides ReadOnly Property GripDark As Color
            Get
                Return ClrTextDisabled
            End Get
        End Property

        Public Overrides ReadOnly Property GripLight As Color
            Get
                Return ClrSurface
            End Get
        End Property

        Public Overrides ReadOnly Property OverflowButtonGradientBegin As Color
            Get
                Return ClrSurface
            End Get
        End Property

        Public Overrides ReadOnly Property OverflowButtonGradientMiddle As Color
            Get
                Return ClrSurface
            End Get
        End Property

        Public Overrides ReadOnly Property OverflowButtonGradientEnd As Color
            Get
                Return ClrSurface
            End Get
        End Property

    End Class

#End Region

#Region "ComboBox skin (flat face + chevron)"

    Private NotInheritable Class ComboBoxSkin
        Inherits NativeWindow

        Private ReadOnly _combo As ComboBox

        Public Sub New(combo As ComboBox)
            _combo = combo
            AddHandler _combo.HandleCreated, AddressOf OnComboHandleCreated
            AddHandler _combo.HandleDestroyed, AddressOf OnComboHandleDestroyed
            If _combo.IsHandleCreated Then AssignHandle(_combo.Handle)
        End Sub

        Private Sub OnComboHandleCreated(sender As Object, e As EventArgs)
            If Handle <> IntPtr.Zero Then ReleaseHandle()
            AssignHandle(_combo.Handle)
        End Sub

        Private Sub OnComboHandleDestroyed(sender As Object, e As EventArgs)
            If Handle <> IntPtr.Zero Then ReleaseHandle()
        End Sub

        Protected Overrides Sub WndProc(ByRef m As Message)
            MyBase.WndProc(m)
            If m.Msg = WM_PAINT Then
                Try
                    PaintOverlay()
                Catch ex As Exception
                End Try
            End If
        End Sub

        Private Sub PaintOverlay()
            Dim cb = _combo
            If Not cb.IsHandleCreated OrElse cb.DropDownStyle = ComboBoxStyle.Simple Then Return
            Dim rc As Rectangle = cb.ClientRectangle
            If rc.Width < 24 OrElse rc.Height < 8 Then Return

            Dim isList As Boolean = (cb.DropDownStyle = ComboBoxStyle.DropDownList)
            Dim active As Boolean = cb.Focused OrElse cb.DroppedDown
            Dim btnW As Integer = SystemInformation.VerticalScrollBarWidth
            Dim btn As New Rectangle(rc.Right - btnW - 1, 1, btnW, rc.Height - 2)

            Using g As Graphics = Graphics.FromHwnd(cb.Handle)
                g.SmoothingMode = SmoothingMode.AntiAlias

                Using back As New SolidBrush(ClrInput)
                    g.FillRectangle(back, If(isList, rc, btn))
                End Using

                If isList Then
                    Dim textRect As New Rectangle(6, 1, Math.Max(0, btn.Left - 8), rc.Height - 2)
                    TextRenderer.DrawText(g, cb.Text, cb.Font, textRect,
                                          If(cb.Enabled, ClrText, ClrTextDisabled), ClrInput,
                                          TextFormatFlags.Left Or TextFormatFlags.VerticalCenter Or
                                          TextFormatFlags.SingleLine Or TextFormatFlags.EndEllipsis Or TextFormatFlags.NoPrefix)
                End If

                Dim cx As Integer = btn.Left + btn.Width \ 2
                Dim cy As Integer = rc.Height \ 2
                Using p As New Pen(If(cb.Enabled, ClrTextMuted, ClrTextDisabled), 1.6F)
                    g.DrawLines(p, New Point() {New Point(cx - 4, cy - 2), New Point(cx, cy + 2), New Point(cx + 4, cy - 2)})
                End Using

                Using p As New Pen(If(active AndAlso cb.Enabled, ClrAccent, ClrBorder))
                    g.DrawRectangle(p, 0, 0, rc.Width - 1, rc.Height - 1)
                End Using
            End Using
        End Sub
    End Class

#End Region

#Region "Fonts"

    Private ReadOnly _fontCache As New Dictionary(Of String, Font)()

    Friend Function GetFont(family As String, size As Single, style As FontStyle) As Font
        Dim key As String = family & "|" & size.ToString("0.##", CultureInfo.InvariantCulture) & "|" &
                            CInt(style).ToString(CultureInfo.InvariantCulture)
        Dim f As Font = Nothing
        If Not _fontCache.TryGetValue(key, f) Then
            f = New Font(family, size, style, GraphicsUnit.Point)
            _fontCache(key) = f
        End If
        Return f
    End Function

    Private Function IsMonospace(f As Font) As Boolean
        Dim n As String = f.FontFamily.Name
        For Each token As String In New String() {"Consolas", "Courier", "Lucida Console", "Cascadia", "Mono", "Fira Code", "JetBrains"}
            If n.IndexOf(token, StringComparison.OrdinalIgnoreCase) >= 0 Then Return True
        Next
        Return False
    End Function

    Private Function ResolveFont(current As Font, forceBold As Boolean) As Font
        If current Is Nothing Then
            Return GetFont(FontFamilyName, BaseFontSize, If(forceBold, FontStyle.Bold, FontStyle.Regular))
        End If
        If IsMonospace(current) Then Return current

        Dim size As Single = If(current.SizeInPoints > BaseFontSize + 1.0F, current.SizeInPoints, BaseFontSize)
        Dim style As FontStyle = current.Style
        If forceBold Then style = style Or FontStyle.Bold
        Return GetFont(FontFamilyName, size, style)
    End Function

    Private Sub ApplyFont(c As Control, bold As Boolean)
        c.Font = ResolveFont(c.Font, bold)
    End Sub

#End Region

#Region "Helpers"

    Private ReadOnly _doubleBufferedProp As PropertyInfo =
        GetType(Control).GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)

    Private ReadOnly _setStyleMethod As MethodInfo =
        GetType(Control).GetMethod("SetStyle", BindingFlags.Instance Or BindingFlags.NonPublic, Nothing,
                                   New Type() {GetType(ControlStyles), GetType(Boolean)}, Nothing)

    Private Sub EnableDoubleBuffer(c As Control)
        Try
            If _doubleBufferedProp IsNot Nothing Then _doubleBufferedProp.SetValue(c, True, Nothing)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SetControlStyle(c As Control, styles As ControlStyles, value As Boolean)
        Try
            If _setStyleMethod IsNot Nothing Then _setStyleMethod.Invoke(c, New Object() {styles, value})
        Catch ex As Exception
        End Try
    End Sub

    Private Function ParentBack(c As Control) As Color
        Dim p As Control = c.Parent
        Do While p IsNot Nothing
            If p.BackColor.A = 255 Then Return p.BackColor
            p = p.Parent
        Loop
        Return ClrSurface
    End Function

    Private Function ReadableFore(current As Color, back As Color, fallback As Color) As Color
        If current.IsEmpty OrElse current.IsSystemColor Then Return fallback
        If ContrastRatio(current, back) < 3.0 Then Return fallback
        Return current
    End Function

    Private Function ContrastRatio(a As Color, b As Color) As Double
        Dim l1 As Double = Luminance(a)
        Dim l2 As Double = Luminance(b)
        Return (Math.Max(l1, l2) + 0.05) / (Math.Min(l1, l2) + 0.05)
    End Function

    Private Function Luminance(c As Color) As Double
        Return 0.2126 * ToLinear(CInt(c.R) / 255.0) + 0.7152 * ToLinear(CInt(c.G) / 255.0) + 0.0722 * ToLinear(CInt(c.B) / 255.0)
    End Function

    Private Function ToLinear(v As Double) As Double
        Return If(v <= 0.03928, v / 12.92, Math.Pow((v + 0.055) / 1.055, 2.4))
    End Function

    Private Function Blend(a As Color, b As Color, t As Double) As Color
        Return Color.FromArgb(CInt(CInt(a.R) + (CInt(b.R) - CInt(a.R)) * t),
                              CInt(CInt(a.G) + (CInt(b.G) - CInt(a.G)) * t),
                              CInt(CInt(a.B) + (CInt(b.B) - CInt(a.B)) * t))
    End Function

    Friend Function RoundedRect(r As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        radius = Math.Min(radius, Math.Min(r.Width, r.Height) \ 2)
        If radius <= 0 Then
            path.AddRectangle(r)
            Return path
        End If
        Dim d As Integer = radius * 2
        path.AddArc(r.X, r.Y, d, d, 180, 90)
        path.AddArc(r.Right - d, r.Y, d, d, 270, 90)
        path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90)
        path.AddArc(r.X, r.Bottom - d, d, d, 90, 90)
        path.CloseFigure()
        Return path
    End Function

#End Region

#Region "Native interop"

    Private Const WM_PAINT As Integer = &HF
    Private Const GWL_EXSTYLE As Integer = -20
    Private Const WS_EX_CLIENTEDGE As Integer = &H200
    Private Const SWP_NOSIZE As UInteger = &H1UI
    Private Const SWP_NOMOVE As UInteger = &H2UI
    Private Const SWP_NOZORDER As UInteger = &H4UI
    Private Const SWP_NOACTIVATE As UInteger = &H10UI
    Private Const SWP_FRAMECHANGED As UInteger = &H20UI

    Private Declare Unicode Function GetWindowLong Lib "user32.dll" Alias "GetWindowLongW" (hWnd As IntPtr, nIndex As Integer) As Integer
    Private Declare Unicode Function SetWindowLong Lib "user32.dll" Alias "SetWindowLongW" (hWnd As IntPtr, nIndex As Integer, dwNewLong As Integer) As Integer
    Private Declare Function SetWindowPos Lib "user32.dll" (hWnd As IntPtr, hWndInsertAfter As IntPtr, x As Integer, y As Integer, cx As Integer, cy As Integer, uFlags As UInteger) As Boolean
    Private Declare Unicode Function SetWindowTheme Lib "uxtheme.dll" (hWnd As IntPtr, pszSubAppName As String, pszSubIdList As String) As Integer
    Private Declare Function DwmSetWindowAttribute Lib "dwmapi.dll" (hWnd As IntPtr, dwAttribute As Integer, ByRef pvAttribute As Integer, cbAttribute As Integer) As Integer

    Private Sub EnableDarkTitleBar(f As Form)
        Try
            Dim useDark As Integer = 1
            If DwmSetWindowAttribute(f.Handle, 20, useDark, 4) <> 0 Then
                DwmSetWindowAttribute(f.Handle, 19, useDark, 4)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub RemoveClientEdge(c As Control)
        Try
            Dim exStyle As Integer = GetWindowLong(c.Handle, GWL_EXSTYLE)
            If (exStyle And WS_EX_CLIENTEDGE) <> 0 Then
                SetWindowLong(c.Handle, GWL_EXSTYLE, exStyle And Not WS_EX_CLIENTEDGE)
                SetWindowPos(c.Handle, IntPtr.Zero, 0, 0, 0, 0,
                             SWP_NOMOVE Or SWP_NOSIZE Or SWP_NOZORDER Or SWP_NOACTIVATE Or SWP_FRAMECHANGED)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub HookNativeTheme(c As Control)
        If TryHook(c, "native") Then AddHandler c.HandleCreated, AddressOf OnNativeHandleCreated
        If c.IsHandleCreated Then ApplyNativeTheme(c)
    End Sub

    Private Sub OnNativeHandleCreated(sender As Object, e As EventArgs)
        ApplyNativeTheme(DirectCast(sender, Control))
    End Sub

    Private Sub ApplyNativeTheme(c As Control)
        Try
            If TypeOf c Is ProgressBar Then
                SetWindowTheme(c.Handle, "", "")
            Else
                SetWindowTheme(c.Handle, "DarkMode_Explorer", Nothing)
            End If
        Catch ex As Exception
        End Try
    End Sub

#End Region

End Module