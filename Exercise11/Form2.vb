Public Class Form2
    Function TestByVal(ByVal N As Integer) As Integer
        N = 0
        MsgBox(N)
        Return N
    End Function
    Function TestByRef(ByRef N As Integer) As Integer
        N = 0
        Return N
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim K1 As Integer = 100
        TestByVal(K1)
        MsgBox(K1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim K2 As Integer = 100
        TestByRef(K2)
        MsgBox(K2)
    End Sub
End Class