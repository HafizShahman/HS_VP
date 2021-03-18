Public Class Form1
    Private Sub btnMesej_Click(sender As Object, e As EventArgs) Handles btnMesej.Click
        MessageBox.Show("Terima Kasih " + txtNama.Text + " dari " + txtKelas.Text + " untuk komen " + txtKomen.Text, "Makluman", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
