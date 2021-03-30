Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MsgResult = MessageBox.Show("You have click the text button", "Error", MessageBoxButtons.YesNoCancel)

        If MsgResult = MsgBoxResult.Yes Then
            MessageBox.Show("You Are done!")
        ElseIf MsgResult = MsgBoxResult.No Then
            MessageBox.Show("You Are not done!")
        ElseIf MsgResult = MsgBoxResult.Cancel Then
            MessageBox.Show("Are you Sure?!")
        End If
    End Sub
End Class
