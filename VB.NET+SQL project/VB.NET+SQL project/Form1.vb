Imports System.Data.SqlClient
Public Class Form1
    Public cn As SqlConnection
    Public cmd As New SqlCommand
    Dim dr As SqlDataReader
    Public database As String
    Public authentication As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loginForm.ShowDialog()
    End Sub

    'Execute sql command
    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        cn.Open()
        listAnswers.Columns.Clear()
        listAnswers.Items.Clear()
        listAnswers.GridLines = True
        cmd.CommandText = txtSQLQuery.Text

        'Adds items that correspond to the query in the list
        Try
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                Dim col_num As Integer = dr.FieldCount 'number of columns in row
                listAnswers.View = View.Details 'in order to add columns

                'adds columns
                Dim i As Integer
                listAnswers.Columns.Add("")
                For i = 1 To col_num
                    listAnswers.Columns.Add(dr.GetName(i - 1))
                Next

                'adds items in columns
                Dim count As Integer = 0
                While (dr.Read())
                    count += 1
                    Dim item As New ListViewItem(count)
                    For i = 1 To col_num
                        item.SubItems.Add(dr(i - 1))
                    Next
                    listAnswers.Items.Add(item)
                End While

                'resizes columns
                For i = 0 To col_num
                    listAnswers.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize)
                Next
            End If
        Catch
            MsgBox("Error executing SQL query!", vbExclamation + vbOKOnly, "Error")
        End Try
        cn.Close()
    End Sub

    'Adds tables in database to a combobox
    Private Sub btnGetTables_Click(sender As Object, e As EventArgs) Handles btnGetTables.Click
        cn.Open()
        cbGetTables.Items.Clear()
        Dim query As String = "SELECT * FROM INFORMATION_SCHEMA.tables"
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(query, cn)
        Dim data As New DataSet()
        adapter.Fill(data)

        Dim tableName As String

        For Each table As DataTable In data.Tables
            For Each row As DataRow In table.Rows
                tableName = row(2).ToString()
                cbGetTables.Items.Add(tableName)
            Next
        Next
        cn.Close()
    End Sub

    'informs if the table exists or not in the database
    Private Sub btnTableExists_Click(sender As Object, e As EventArgs) Handles btnTableExists.Click
        Dim exists As Boolean = tableExists()

        'shows tick mark if it exists or X mark if it doesn't
        If exists Then
            lbTableExists.Text = "✓"
            lbTableExists.ForeColor = Color.Green
        Else
            lbTableExists.Text = "X"
            lbTableExists.ForeColor = Color.Red
        End If

        clearTableInformation()
    End Sub

    'checks if a table exists in the database
    Private Function tableExists() As Boolean
        cn.Open()
        tableExists = False

        Dim inputTable As String = txtTableName.Text
        If inputTable IsNot Nothing Then
            Dim query As String = "SELECT * FROM INFORMATION_SCHEMA.tables"
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(query, cn)
            Dim data As New DataSet()
            adapter.Fill(data)

            Dim tableName As String

            For Each table As DataTable In data.Tables
                For Each row As DataRow In table.Rows
                    tableName = row(2).ToString()
                    If String.Equals(inputTable, tableName) Then
                        tableExists = True
                        Exit For
                        Exit For
                    End If
                Next
            Next
        End If
        cn.Close()
    End Function

    'when typing in the textbox there will be no indication if the table exists or not
    Private Sub txtTableName_TextChanged(sender As Object, e As EventArgs) Handles txtTableName.TextChanged
        lbTableExists.Text = ""
    End Sub

    'updates table textbox with the selected table from tables combobox
    Private Sub cbGetTables_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGetTables.SelectedIndexChanged
        txtTableName.Text = (cbGetTables.SelectedItem).ToString()
        lbTableExists.Text = "✓"
        lbTableExists.ForeColor = Color.Green
        clearTableInformation()
    End Sub

    'Clears all table information
    Private Sub clearTableInformation()
        txtColumnName.Text = ""
        cbGetColumns.Items.Clear()
        cbGetPKeys.Items.Clear()
        cbGetFKeys.Items.Clear()
    End Sub

    'adds columns of table in column combobox
    Private Sub btnGetColumns_Click(sender As Object, e As EventArgs) Handles btnGetColumns.Click
        cbGetColumns.Items.Clear()
        Dim inputTable As String = txtTableName.Text

        If String.Equals(lbTableExists.Text, "✓") Or (String.Equals(lbTableExists.Text, "") And tableExists()) Then
            cn.Open()
            cmd.CommandText = $"SELECT * FROM {inputTable}"
            dr = cmd.ExecuteReader()

            For i = 1 To dr.FieldCount
                cbGetColumns.Items.Add(dr.GetName(i - 1))
            Next
            cn.Close()
        Else
            MsgBox($"Table '{inputTable}' does not exist!", vbExclamation + vbOKOnly, "Error")
        End If
    End Sub

    'checks if a column exists in the table
    Private Sub btnColumnExists_Click(sender As Object, e As EventArgs) Handles btnColumnExists.Click
        Dim exists As Boolean = False
        Dim inputTable As String = txtTableName.Text
        Dim inputColumn As String = txtColumnName.Text

        If String.Equals(lbTableExists.Text, "✓") Or (String.Equals(lbTableExists.Text, "") And tableExists()) Then
            cn.Open()
            cmd.CommandText = $"SELECT * FROM {inputTable}"
            dr = cmd.ExecuteReader()

            For i = 1 To dr.FieldCount
                If String.Equals(dr.GetName(i - 1), inputColumn) Then
                    exists = True
                    Exit For
                End If
            Next
            cn.Close()
            'shows tick mark if it exists or X mark if it doesn't
            If exists Then
                lbColumnExists.Text = "✓"
                lbColumnExists.ForeColor = Color.Green
            Else
                lbColumnExists.Text = "X"
                lbColumnExists.ForeColor = Color.Red
            End If
        Else
            MsgBox($"Table '{inputTable}' does not exist!", vbExclamation + vbOKOnly, "Error")
        End If
    End Sub

    'when typing in the textbox there will be no indication if the column exists or not
    Private Sub txtColumnName_TextChanged(sender As Object, e As EventArgs) Handles txtColumnName.TextChanged
        lbColumnExists.Text = ""
    End Sub

    'updates column textbox with the selected column from columns combobox
    Private Sub cbGetColumns_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGetColumns.SelectedIndexChanged
        txtColumnName.Text = (cbGetColumns.SelectedItem).ToString()
        lbColumnExists.Text = "✓"
        lbColumnExists.ForeColor = Color.Green
    End Sub

    'adds primary keys of table to combobox
    Private Sub btnGetPKeys_Click(sender As Object, e As EventArgs) Handles btnGetPKeys.Click
        cbGetPKeys.Items.Clear()
        Dim inputTable As String = txtTableName.Text

        If String.Equals(lbTableExists.Text, "✓") Or (String.Equals(lbTableExists.Text, "") And tableExists()) Then
            cn.Open()
            Dim query As String = $"SELECT * FROM {inputTable}"
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(query, cn)
            Dim data As New DataSet()
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey 'without this it can't find the primary keys
            adapter.Fill(data)

            Dim dt As DataTable = data.Tables(0)
            Dim columns() As DataColumn = dt.PrimaryKey
            Dim i As Integer
            For i = 0 To columns.Length - 1
                cbGetPKeys.Items.Add(columns(i).ColumnName)
            Next
            cn.Close()
        Else
            MsgBox($"Table '{inputTable}' does not exist!", vbExclamation + vbOKOnly, "Error")
        End If
    End Sub

    'adds foreign keys of table in combobox
    Private Sub btnGetFKeys_Click(sender As Object, e As EventArgs) Handles btnGetFKeys.Click
        cbGetFKeys.Items.Clear()
        Dim inputTable As String = txtTableName.Text

        If String.Equals(lbTableExists.Text, "✓") Or (String.Equals(lbTableExists.Text, "") And tableExists()) Then
            cn.Open()
            cmd.CommandText = $"SELECT
                                    rc.CONSTRAINT_NAME,         
                                    rcu.TABLE_NAME 'Referencing Table', 
                                    rcu.COLUMN_NAME 'Referencing Column',
                                    rcu1.TABLE_NAME 'Referenced Table',
                                    rcu1.COLUMN_NAME 'Referenced Column'
                                FROM
                                    INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS rc
                                INNER JOIN 
                                    INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE rcu 
                                    On rc.CONSTRAINT_CATALOG = rcu.CONSTRAINT_CATALOG 
                                    And rc.CONSTRAINT_NAME = rcu.CONSTRAINT_NAME
                                INNER Join 
                                    INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE rcu1 
                                    On rc.UNIQUE_CONSTRAINT_CATALOG = rcu1.CONSTRAINT_CATALOG 
                                    AND rc.UNIQUE_CONSTRAINT_NAME = rcu1.CONSTRAINT_NAME"

            dr = cmd.ExecuteReader()
            While (dr.Read())
                If String.Equals(dr.GetValue(1).ToString, inputTable) Then
                    cbGetFKeys.Items.Add(dr.GetValue(2).ToString & "(" & dr.GetValue(3) & ")")
                End If
            End While
            cn.Close()
        Else
            MsgBox($"Table '{inputTable}' does not exist!", vbExclamation + vbOKOnly, "Error")
        End If
    End Sub

    'clears grid
    Private Sub btnClearGrid_Click(sender As Object, e As EventArgs) Handles btnClearGrid.Click
        listAnswers.GridLines = False
    End Sub

    'adds existing databases on server to combobox
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        cbDBFilename.Items.Clear()
        cn.Open()
        Dim databases As DataTable = cn.GetSchema("Databases")
        For Each row As DataRow In databases.Rows
            cbDBFilename.Items.Add(row(0).ToString())
        Next
        cn.Close()
    End Sub

    'login form appears
    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        loginForm.ShowDialog()
        clearTableInformation()
        txtTableName.Text = ""
        cbGetTables.Items.Clear()
        cbDBFilename.Items.Clear()
    End Sub

    'connects to selected db
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        clearTableInformation()
        txtTableName.Text = ""
        cbGetTables.Items.Clear()
        If cbDBFilename.Text <> "" Then
            Dim dataSource As String = loginForm.cbDataSource.Text
            Dim initialCatalog As String = cbDBFilename.Text
            Dim userID As String = loginForm.txtUserName.Text
            Dim password As String = loginForm.txtPassword.Text

            If authentication = 1 Then
                cn = New SqlConnection("Data Source=" & dataSource & ";Initial Catalog=" & initialCatalog)
                Text = cbDBFilename.Text
                cmd.Connection = cn
            Else
                dbconnect.Text = "Connect to " & initialCatalog
                dbconnect.dataSource = dataSource
                dbconnect.initialCatalog = initialCatalog
                dbconnect.txtUserName.Text = userID
                dbconnect.txtPassword.Text = password
                dbconnect.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btnCreatDB_Click(sender As Object, e As EventArgs) Handles btnCreatDB.Click
        Dim command As New SqlCommand
        Dim dataSource As String = loginForm.cbDataSource.Text
        Dim userID As String = loginForm.txtUserName.Text
        Dim password As String = loginForm.txtPassword.Text
        Dim cn_master As SqlConnection

        If authentication = 1 Then
            cn_master = New SqlConnection("Data Source=" & dataSource & ";database=master")
            command.Connection = cn_master
        Else
            cn_master = New SqlConnection("Data Source=" & dataSource & ";database=master;User ID=" & userID & ";Password=" & password)
        End If

        Dim dbname As String = InputBox("Enter Database Name:", "Create Database", " ")
        If dbname <> "" Then
            command.CommandText = "CREATE DATABASE " & dbname
            Try
                cn_master.Open()
                command.ExecuteNonQuery()
                cn_master.Close()
                MsgBox("Database was created!")
            Catch
                MsgBox("Database cannot be created", MsgBoxStyle.Critical, "Warning")
            End Try
            Exit Sub
        Else
            Exit Sub
        End If
    End Sub
End Class

