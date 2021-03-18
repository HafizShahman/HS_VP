Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.Location = New Point(200, 100)
        Label1.Text = "You have just move the table"
    End Sub

    Private Sub Label1_DoubleClick(sender As Object, e As EventArgs) Handles Label1.DoubleClick
        Label1.Text = "New Label"
    End Sub
End Class
