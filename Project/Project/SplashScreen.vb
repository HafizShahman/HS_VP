Public Class SplashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadingBar.Increment(1)
        If LoadingBar.Value = 100 Then
            Me.Hide()
            Timer1.Enabled = False
            Login.Show()
        End If
    End Sub
End Class
