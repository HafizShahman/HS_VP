Public Class RegisterUser


    Private Sub RegisterUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet1.tblUser' table. You can move, or remove it, as needed.
        Me.TblUserTableAdapter.Fill(Me.LibraryDataSet1.tblUser)

    End Sub

    Private Sub BTNSSAVE_Click(sender As Object, e As EventArgs) Handles BTNSSAVE.Click
        Me.TblUserTableAdapter.Insert(Name:=txtName.Text, PhoneNum:=txtPhoneNum.Text, Username:=txtUsername.Text, Password:=txtPassword.Text, Address:=txtAddress.Text)
        NewBook.ActiveForm.Close()
    End Sub

    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCEL.Click
        RegisterUser.ActiveForm.Close()
    End Sub
End Class