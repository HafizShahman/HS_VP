Public Class Form1
    Private Sub btnMoto_Click(sender As Object, e As EventArgs) Handles btnMoto.Click
        lblMesej.Visible = True
        PictureBox1.Visible = False
        lblMesej.Text = "Simple easy learning"
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        lblMesej.Visible = False
        PictureBox1.Visible = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMesej.Visible = False
        PictureBox1.Visible = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
