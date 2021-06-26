Public Class NewBook
    Public position As Integer = 0
    Public LastRow As Integer = 0

    Private Sub NewBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet.tblBook' table. You can move, or remove it, as needed.
        Me.TblBookTableAdapter.Fill(Me.LibraryDataSet.tblBook)

    End Sub

    Private Sub BTNSSAVE_Click(sender As Object, e As EventArgs) Handles BTNSSAVE.Click
        Me.TblBookTableAdapter.Insert(BookID:=txtBookID.Text, BookTitle:=txtBookTitle.Text, Author:=txtAuthor.Text, Genre:=txtGerne.Text, Year:=txtYear.Text)
        Me.Dispose()
        BookList.ShowDialog()

    End Sub

    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCEL.Click
        Me.Dispose()
        BookList.ShowDialog()
    End Sub
End Class