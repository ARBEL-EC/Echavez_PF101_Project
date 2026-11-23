Option Strict On

Imports System.Drawing.Drawing2D

Friend Enum DrawingPracticeShape
    Rectangle
    Ellipse
    Triangle
End Enum

Friend NotInheritable Class DrawingPracticeCanvas
    Inherits Panel

    Private _shape As DrawingPracticeShape
    Private _fillColor As Color = Color.FromArgb(34, 197, 94)

    Friend Sub New()
        DoubleBuffered = True
        ResizeRedraw = True
        AccessibleName = "GDI+ shape preview"
        BackColor = ThemeManager.ClrBackground
    End Sub

    Friend ReadOnly Property FillColor As Color
        Get
            Return _fillColor
        End Get
    End Property

    Friend Sub SetPreview(shape As DrawingPracticeShape, fillColor As Color)
        _shape = shape
        _fillColor = fillColor
        AccessibleDescription = shape.ToString() & " with fill color " & fillColor.Name
        Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim padding As Single = LogicalToDeviceUnits(24)
        Dim availableWidth As Single = ClientSize.Width - 2 * padding
        Dim availableHeight As Single = ClientSize.Height - 2 * padding
        If availableWidth <= 0 OrElse availableHeight <= 0 Then Return

        Dim height As Single = Math.Min(availableHeight, availableWidth / 1.5F)
        Dim width As Single = height * 1.5F
        Dim bounds As New RectangleF((ClientSize.Width - width) / 2, (ClientSize.Height - height) / 2, width, height)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Using fill As New SolidBrush(_fillColor), outline As New Pen(ThemeManager.ClrText, LogicalToDeviceUnits(2))
            Select Case _shape
                Case DrawingPracticeShape.Rectangle
                    e.Graphics.FillRectangle(fill, bounds)
                    e.Graphics.DrawRectangle(outline, bounds.X, bounds.Y, bounds.Width, bounds.Height)
                Case DrawingPracticeShape.Ellipse
                    e.Graphics.FillEllipse(fill, bounds)
                    e.Graphics.DrawEllipse(outline, bounds)
                Case DrawingPracticeShape.Triangle
                    Dim vertices As PointF() = {
                        New PointF(bounds.Left + bounds.Width / 2, bounds.Top),
                        New PointF(bounds.Right, bounds.Bottom),
                        New PointF(bounds.Left, bounds.Bottom)
                    }
                    e.Graphics.FillPolygon(fill, vertices)
                    e.Graphics.DrawPolygon(outline, vertices)
            End Select
        End Using
    End Sub
End Class
