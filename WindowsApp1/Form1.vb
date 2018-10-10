Imports System.Data.Odbc
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub connBtn_Click(sender As Object, e As EventArgs) Handles connBtn.Click
        Dim DBConnect As OdbcConnection
        Try
            DBConnect = New OdbcConnection("DSN=training;MultipleActiveResultSets=True")
            DBConnect.Open()

            Dim readerLogin As Odbc.OdbcDataReader
            Dim commLogin As New Odbc.OdbcCommand
            commLogin.CommandType = CommandType.Text
            commLogin.Connection = DBConnect
            Dim connQuery As String
            connQuery = "SELECT * FROM mysql.user WHERE user='" & connName.Text & "' AND password=MD5('" & connPass.Text & "')"
            commLogin.CommandText = connQuery
            readerLogin = commLogin.ExecuteReader()

            If readerLogin.HasRows Then
                MsgBox("Connected")
            Else
                MsgBox("Connection Failed")
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)


        End Try

    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub
End Class
