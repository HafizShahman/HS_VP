Imports System.Data.SqlClient
Module Connect_Database
    Public Conn As SqlConnection
    Public cmd As SqlCommand
    Public da As SqlDataAdapter
    Public dr As SqlDataReader
    Public dt As DataTable
    Public Sql As String
    Public Sub ConnecDatabase()
        Try
            Conn = New SqlConnection
            Conn.ConnectionString = "DATA SOURCE=(LOCAL);INITIAL CATALOG=Library;TRUSTED_CONNECTION=TRUE;INTEGRATED SECURITY=TRUE"
            Conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
