Imports System.Drawing

Public Class Form1
    Dim Draw As Boolean
    Dim DrawColor As Color = Color.Black
    Dim DrawSize As Integer = 6

    Dim bmp As Bitmap

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SET INITIAL BRUSH SIZE
        cbxSize.SelectedIndex = 2

        'POPULATE PICTURE BOX IMAGE PROPERTY
        bmp = New Bitmap(picboxDraw.Width, picboxDraw.Height)
        picboxDraw.Image = bmp
    End Sub

    Private Sub PaintBrush(X As Integer, Y As Integer)
        Using g As Graphics = Graphics.FromImage(picboxDraw.Image)
            g.FillRectangle(New SolidBrush(DrawColor), New Rectangle(X, Y, DrawSize, DrawSize))
        End Using

        picboxDraw.Refresh()
    End Sub

    Private Sub picboxDraw_MouseDown(sender As Object, e As MouseEventArgs) Handles picboxDraw.MouseDown
        Draw = True

        'FIRST PIXEL
        PaintBrush(e.X, e.Y)
    End Sub

    Private Sub picboxDraw_MouseMove(sender As Object, e As MouseEventArgs) Handles picboxDraw.MouseMove
        If Draw - True Then
            PaintBrush(e.X, e.Y)
        End If
    End Sub

    Private Sub picboxDraw_MouseUp(sender As Object, e As MouseEventArgs) Handles picboxDraw.MouseUp
        Draw = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        bmp = New Bitmap(picboxDraw.Width, picboxDraw.Height)
        picboxDraw.Image = bmp
    End Sub

    Private Sub cbxSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSize.SelectedIndexChanged
        DrawSize = cbxSize.SelectedItem
    End Sub

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            DrawColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        picboxDraw.DrawToBitmap(bmp, New Rectangle(0, 0, picboxDraw.Width, picboxDraw.Height))
        bmp.Save("Test1.png", Imaging.ImageFormat.Png)

        bmp = New Bitmap(picboxDraw.Width, picboxDraw.Height)
    End Sub
End Class
