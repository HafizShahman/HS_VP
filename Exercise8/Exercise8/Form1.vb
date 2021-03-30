Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name = InputBox("Please enter your name : ", "Name", "Nama saya : ")

        If name = "" Then
            Me.Close()
        Else
            MessageBox.Show("You Enter : " & name)
        End If
    End Sub
End Class