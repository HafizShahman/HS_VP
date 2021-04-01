Public Class LoginScreen

    Private Sub LoginScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SplashScreen.BarLong(70)
        Dim i As Integer = 0
        While i <= 70
            SplashScreen.ShowBar(i)
            i += 1
            Threading.Thread.Sleep(70)
        End While

    End Sub
End Class