Imports System.Data.SqlClient
Public Class dbconnect
    Public dataSource As String
    Public initialCatalog As String
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim cn As New SqlConnection("Data Source=" & dataSource & ";Initial Catalog=" & initialCatalog &
                            ";User ID=" & txtUserName.Text & ";Password=" & txtPassword.Text)

        Try
            cn.Open()
            cn.Close()
            Form1.cn = cn
            Form1.cmd.Connection = cn
            Form1.Text = initialCatalog
        Catch ex As Exception
            MsgBox("Failed to connect to database!", vbExclamation + vbOKOnly, "Error")
        End Try
    End Sub
End Class

