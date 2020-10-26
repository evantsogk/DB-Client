Imports System.Data.SqlClient
'This form is used to connect to a database by inserting the necessary values
Public Class loginForm
    Public connected As Boolean = False
    Dim authentication As Integer

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If authentication <> 0 And authentication <> 1 Then
            cbAuthentication.SelectedIndex = 0
        Else
            cbAuthentication.SelectedIndex = authentication
        End If
    End Sub
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        'Uses the input values to create an SqlConnection
        Dim dataSource As String = cbDataSource.Text
        Dim initialCatalog As String = cbInitialCatalog.Text
        Dim userID As String = txtUserName.Text
        Dim password As String = txtPassword.Text

        Dim cn As New SqlConnection("Data Source=" & dataSource & ";Initial Catalog=" & initialCatalog &
                                    ";User ID=" & userID & ";Password=" & password)

        'Try-catch block to open the connection
        Try
            cn.Open()
            Form1.cn = cn
            Form1.cmd.Connection = cn
            connected = True
            Form1.Text = initialCatalog
            cn.Close()
            Close()
        Catch ex As Exception
            MsgBox("Failed to connect to database!", vbExclamation + vbOKOnly, "Error")
        End Try

    End Sub

    'exits program if not connected
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Form1.Close()
        Close()
    End Sub

    'exits program if not connected
    Private Sub loginForm_Form_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        If Not connected Then
            Form1.Close()
        End If
    End Sub

    Private Sub cbAuthentication_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAuthentication.SelectedIndexChanged
        authentication = cbAuthentication.SelectedIndex
        Form1.authentication = authentication
        If authentication = 1 Then
            txtUserName.Text = ""
            txtPassword.Text = ""
            txtUserName.Enabled = False
            txtPassword.Enabled = False
        Else
            txtUserName.Enabled = True
            txtPassword.Enabled = True
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        cbInitialCatalog.Items.Clear()
        Dim dataSource As String = cbDataSource.Text
        Dim userID As String = txtUserName.Text
        Dim password As String = txtPassword.Text

        If dataSource <> "" Then
            Dim cn As New SqlConnection("Data Source=" & dataSource & ";User ID=" & userID & ";Password=" & password)
            Try
                cn.Open()
                Dim databases As DataTable = cn.GetSchema("Databases")
                For Each row As DataRow In databases.Rows
                    cbInitialCatalog.Items.Add(row(0).ToString())
                Next
                cn.Close()
            Catch ex As Exception
                MsgBox("Failed to connect to server!", vbExclamation + vbOKOnly, "Error")
            End Try
        End If
    End Sub

End Class

