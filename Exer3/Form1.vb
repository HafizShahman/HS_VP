Public Class Form1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim PhoneArray(3, 3) As String


        PhoneArray(0, 0) = "shahman"
        PhoneArray(0, 1) = "nik"
        PhoneArray(0, 2) = "fakhrul"
        PhoneArray(1, 0) = "amira"
        PhoneArray(1, 1) = "iman"
        PhoneArray(1, 2) = "natasha"
        PhoneArray(2, 0) = "nazmi"
        PhoneArray(2, 1) = "fatihah"
        PhoneArray(2, 2) = "amir"

        Dim msg As String

        For i = 0 To 2
            For ii = 0 To 2
                msg = msg & PhoneArray(i, ii) & vbTab
            Next ii
            msg = msg & vbCrLf
        Next i

        MsgBox(msg)

    End Sub
End Class
