Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Visible = False
        TextBox1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String
        str = " "

        If CheckBox1.Checked = True Then
            str &= CheckBox1.Text
            str &= " "
        End If

        If CheckBox2.Checked = True Then
            str &= CheckBox2.Text
            str &= " "
        End If

        If CheckBox3.Checked = True Then
            str &= CheckBox3.Text
            str &= " "
        End If

        If CheckBox4.Checked = True Then
            str &= TextBox1.Text
            str &= " "
        End If

        If str <> Nothing Then
            MsgBox(str + vbLf + " thank you")
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            Label1.Visible = True
            TextBox1.Visible = True
        End If

        If CheckBox4.Checked = False Then
            Label1.Visible = False
            TextBox1.Visible = False
        End If


    End Sub
End Class
