Imports System.Data.SqlClient


Public Class Login
    Sub LoginSystem()
        If txtUsername.Text = "" Then
            MsgBox("Username is Required!", MsgBoxStyle.Critical)
            txtUsername.Focus()
        ElseIf txtPassword.Text = "" Then
            MsgBox("Password is Required!", MsgBoxStyle.Critical)
            txtPassword.Focus()
        Else
            Try
                ConnecDatabase()
                Sql = "Select * From tblUser Where Username = @Username And Password = @Password;"
                cmd = New SqlCommand
                With cmd
                    .Connection = Conn
                    .CommandText = Sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Username", txtUsername.Text)
                    .Parameters.AddWithValue("@Password", txtPassword.Text)
                    .ExecuteNonQuery()
                End With
                da = New SqlDataAdapter
                dt = New DataTable
                da.SelectCommand = cmd
                da.Fill(dt)
            Catch ex As SqlException
                MsgBox(ex.Message)
            Finally
                Conn.Close()
                da.Dispose()
                If dt.Rows.Count > 0 Then
                    Dim Username, Password As String
                    Username = dt.Rows(0).Item("Username")
                    Password = dt.Rows(0).Item("Password")
                    If txtUsername.Text = Username And txtPassword.Text = Password Then
                        MsgBox("Welcome " & txtUsername.Text)
                        txtUsername.Text = ""
                        txtPassword.Text = ""
                        Me.Dispose()
                        BookList.ShowDialog()
                    ElseIf txtUsername.Text <> Username Then
                        MsgBox("Username Doesn't Match!", MsgBoxStyle.Exclamation)
                        txtUsername.Text = ""
                        txtUsername.Focus()
                    ElseIf txtPassword.Text <> Password Then
                        MsgBox("Password Doesn't Match!", MsgBoxStyle.Exclamation)
                        txtPassword.Text = ""
                        txtPassword.Focus()
                    Else
                        MsgBox("Username or Password is Invalid!", MsgBoxStyle.Exclamation)
                        txtPassword.Text = ""
                        txtPassword.Focus()
                        txtUsername.Text = ""
                        txtPassword.Text = ""
                    End If
                End If
            End Try
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        LoginSystem()
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = 13 Then
            LoginSystem()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        RegisterUser.ShowDialog()
    End Sub
End Class