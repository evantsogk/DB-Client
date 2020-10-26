<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtSQLQuery = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listAnswers = New System.Windows.Forms.ListView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbDBFilename = New System.Windows.Forms.ComboBox()
        Me.cbGetFKeys = New System.Windows.Forms.ComboBox()
        Me.cbGetPKeys = New System.Windows.Forms.ComboBox()
        Me.cbGetColumns = New System.Windows.Forms.ComboBox()
        Me.cbGetTables = New System.Windows.Forms.ComboBox()
        Me.lbColumnExists = New System.Windows.Forms.Label()
        Me.txtColumnName = New System.Windows.Forms.TextBox()
        Me.lbTableExists = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTableName = New System.Windows.Forms.TextBox()
        Me.btnGetFKeys = New System.Windows.Forms.Button()
        Me.btnGetPKeys = New System.Windows.Forms.Button()
        Me.btnGetColumns = New System.Windows.Forms.Button()
        Me.btnGetTables = New System.Windows.Forms.Button()
        Me.btnColumnExists = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTableExists = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnCreatDB = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.btnClearGrid = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSQLQuery
        '
        Me.txtSQLQuery.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtSQLQuery.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtSQLQuery.ForeColor = System.Drawing.Color.White
        Me.txtSQLQuery.Location = New System.Drawing.Point(12, 446)
        Me.txtSQLQuery.Name = "txtSQLQuery"
        Me.txtSQLQuery.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtSQLQuery.Size = New System.Drawing.Size(700, 165)
        Me.txtSQLQuery.TabIndex = 2
        Me.txtSQLQuery.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 425)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "SQL Command"
        '
        'listAnswers
        '
        Me.listAnswers.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.listAnswers.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.listAnswers.ForeColor = System.Drawing.Color.White
        Me.listAnswers.FullRowSelect = True
        Me.listAnswers.GridLines = True
        Me.listAnswers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.listAnswers.HideSelection = False
        Me.listAnswers.Location = New System.Drawing.Point(12, 12)
        Me.listAnswers.Name = "listAnswers"
        Me.listAnswers.Size = New System.Drawing.Size(700, 350)
        Me.listAnswers.TabIndex = 5
        Me.listAnswers.UseCompatibleStateImageBehavior = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 407)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(700, 5)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(732, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(383, 638)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbDBFilename)
        Me.GroupBox3.Controls.Add(Me.cbGetFKeys)
        Me.GroupBox3.Controls.Add(Me.cbGetPKeys)
        Me.GroupBox3.Controls.Add(Me.cbGetColumns)
        Me.GroupBox3.Controls.Add(Me.cbGetTables)
        Me.GroupBox3.Controls.Add(Me.lbColumnExists)
        Me.GroupBox3.Controls.Add(Me.txtColumnName)
        Me.GroupBox3.Controls.Add(Me.lbTableExists)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtTableName)
        Me.GroupBox3.Controls.Add(Me.btnGetFKeys)
        Me.GroupBox3.Controls.Add(Me.btnGetPKeys)
        Me.GroupBox3.Controls.Add(Me.btnGetColumns)
        Me.GroupBox3.Controls.Add(Me.btnGetTables)
        Me.GroupBox3.Controls.Add(Me.btnColumnExists)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.btnTableExists)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.btnCreatDB)
        Me.GroupBox3.Controls.Add(Me.btnBrowse)
        Me.GroupBox3.Controls.Add(Me.btnConnect)
        Me.GroupBox3.Controls.Add(Me.btnDisconnect)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(0, -8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(383, 646)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'cbDBFilename
        '
        Me.cbDBFilename.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.cbDBFilename.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbDBFilename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDBFilename.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbDBFilename.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.cbDBFilename.ForeColor = System.Drawing.Color.White
        Me.cbDBFilename.FormattingEnabled = True
        Me.cbDBFilename.Location = New System.Drawing.Point(9, 46)
        Me.cbDBFilename.Name = "cbDBFilename"
        Me.cbDBFilename.Size = New System.Drawing.Size(236, 27)
        Me.cbDBFilename.TabIndex = 33
        '
        'cbGetFKeys
        '
        Me.cbGetFKeys.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.cbGetFKeys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGetFKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbGetFKeys.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.cbGetFKeys.ForeColor = System.Drawing.Color.White
        Me.cbGetFKeys.FormattingEnabled = True
        Me.cbGetFKeys.Location = New System.Drawing.Point(140, 507)
        Me.cbGetFKeys.Name = "cbGetFKeys"
        Me.cbGetFKeys.Size = New System.Drawing.Size(215, 27)
        Me.cbGetFKeys.TabIndex = 32
        '
        'cbGetPKeys
        '
        Me.cbGetPKeys.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.cbGetPKeys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGetPKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbGetPKeys.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.cbGetPKeys.ForeColor = System.Drawing.Color.White
        Me.cbGetPKeys.FormattingEnabled = True
        Me.cbGetPKeys.Location = New System.Drawing.Point(140, 444)
        Me.cbGetPKeys.Name = "cbGetPKeys"
        Me.cbGetPKeys.Size = New System.Drawing.Size(215, 27)
        Me.cbGetPKeys.TabIndex = 31
        '
        'cbGetColumns
        '
        Me.cbGetColumns.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.cbGetColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGetColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbGetColumns.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.cbGetColumns.ForeColor = System.Drawing.Color.White
        Me.cbGetColumns.FormattingEnabled = True
        Me.cbGetColumns.Location = New System.Drawing.Point(140, 383)
        Me.cbGetColumns.Name = "cbGetColumns"
        Me.cbGetColumns.Size = New System.Drawing.Size(215, 27)
        Me.cbGetColumns.TabIndex = 30
        '
        'cbGetTables
        '
        Me.cbGetTables.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.cbGetTables.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbGetTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGetTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbGetTables.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.cbGetTables.ForeColor = System.Drawing.Color.White
        Me.cbGetTables.FormattingEnabled = True
        Me.cbGetTables.Location = New System.Drawing.Point(140, 318)
        Me.cbGetTables.Name = "cbGetTables"
        Me.cbGetTables.Size = New System.Drawing.Size(215, 27)
        Me.cbGetTables.TabIndex = 29
        '
        'lbColumnExists
        '
        Me.lbColumnExists.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbColumnExists.ForeColor = System.Drawing.Color.White
        Me.lbColumnExists.Location = New System.Drawing.Point(358, 256)
        Me.lbColumnExists.Name = "lbColumnExists"
        Me.lbColumnExists.Size = New System.Drawing.Size(16, 23)
        Me.lbColumnExists.TabIndex = 28
        '
        'txtColumnName
        '
        Me.txtColumnName.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtColumnName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtColumnName.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtColumnName.ForeColor = System.Drawing.Color.White
        Me.txtColumnName.Location = New System.Drawing.Point(140, 256)
        Me.txtColumnName.Name = "txtColumnName"
        Me.txtColumnName.Size = New System.Drawing.Size(215, 26)
        Me.txtColumnName.TabIndex = 27
        '
        'lbTableExists
        '
        Me.lbTableExists.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbTableExists.ForeColor = System.Drawing.Color.White
        Me.lbTableExists.Location = New System.Drawing.Point(358, 197)
        Me.lbTableExists.Name = "lbTableExists"
        Me.lbTableExists.Size = New System.Drawing.Size(16, 23)
        Me.lbTableExists.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(324, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 18)
        Me.Label5.TabIndex = 25
        '
        'txtTableName
        '
        Me.txtTableName.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtTableName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTableName.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtTableName.ForeColor = System.Drawing.Color.White
        Me.txtTableName.Location = New System.Drawing.Point(140, 197)
        Me.txtTableName.Name = "txtTableName"
        Me.txtTableName.Size = New System.Drawing.Size(215, 26)
        Me.txtTableName.TabIndex = 24
        '
        'btnGetFKeys
        '
        Me.btnGetFKeys.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnGetFKeys.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGetFKeys.Location = New System.Drawing.Point(22, 507)
        Me.btnGetFKeys.Name = "btnGetFKeys"
        Me.btnGetFKeys.Size = New System.Drawing.Size(112, 27)
        Me.btnGetFKeys.TabIndex = 22
        Me.btnGetFKeys.Text = "GetFKeys"
        Me.btnGetFKeys.UseVisualStyleBackColor = False
        '
        'btnGetPKeys
        '
        Me.btnGetPKeys.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnGetPKeys.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGetPKeys.Location = New System.Drawing.Point(22, 444)
        Me.btnGetPKeys.Name = "btnGetPKeys"
        Me.btnGetPKeys.Size = New System.Drawing.Size(112, 27)
        Me.btnGetPKeys.TabIndex = 21
        Me.btnGetPKeys.Text = "GetPKeys"
        Me.btnGetPKeys.UseVisualStyleBackColor = False
        '
        'btnGetColumns
        '
        Me.btnGetColumns.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnGetColumns.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGetColumns.Location = New System.Drawing.Point(22, 383)
        Me.btnGetColumns.Name = "btnGetColumns"
        Me.btnGetColumns.Size = New System.Drawing.Size(112, 27)
        Me.btnGetColumns.TabIndex = 20
        Me.btnGetColumns.Text = "GetColumns"
        Me.btnGetColumns.UseVisualStyleBackColor = False
        '
        'btnGetTables
        '
        Me.btnGetTables.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnGetTables.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGetTables.Location = New System.Drawing.Point(22, 318)
        Me.btnGetTables.Name = "btnGetTables"
        Me.btnGetTables.Size = New System.Drawing.Size(112, 27)
        Me.btnGetTables.TabIndex = 19
        Me.btnGetTables.Text = "GetTables"
        Me.btnGetTables.UseVisualStyleBackColor = False
        '
        'btnColumnExists
        '
        Me.btnColumnExists.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnColumnExists.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnColumnExists.Location = New System.Drawing.Point(22, 256)
        Me.btnColumnExists.Name = "btnColumnExists"
        Me.btnColumnExists.Size = New System.Drawing.Size(112, 27)
        Me.btnColumnExists.TabIndex = 18
        Me.btnColumnExists.Text = "ColumnExists"
        Me.btnColumnExists.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(137, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 18)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Column Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(137, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 18)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Table Name:"
        '
        'btnTableExists
        '
        Me.btnTableExists.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnTableExists.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTableExists.Location = New System.Drawing.Point(22, 197)
        Me.btnTableExists.Name = "btnTableExists"
        Me.btnTableExists.Size = New System.Drawing.Size(112, 27)
        Me.btnTableExists.TabIndex = 15
        Me.btnTableExists.Text = "TableExists"
        Me.btnTableExists.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(9, 124)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(365, 5)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        '
        'btnCreatDB
        '
        Me.btnCreatDB.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnCreatDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCreatDB.Location = New System.Drawing.Point(262, 79)
        Me.btnCreatDB.Name = "btnCreatDB"
        Me.btnCreatDB.Size = New System.Drawing.Size(112, 27)
        Me.btnCreatDB.TabIndex = 13
        Me.btnCreatDB.Text = "Create DB"
        Me.btnCreatDB.UseVisualStyleBackColor = False
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBrowse.Location = New System.Drawing.Point(262, 46)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(112, 27)
        Me.btnBrowse.TabIndex = 12
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'btnConnect
        '
        Me.btnConnect.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConnect.Location = New System.Drawing.Point(133, 79)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(112, 27)
        Me.btnConnect.TabIndex = 11
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = False
        '
        'btnDisconnect
        '
        Me.btnDisconnect.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDisconnect.Location = New System.Drawing.Point(9, 79)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(112, 27)
        Me.btnDisconnect.TabIndex = 10
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "DB Filename:"
        '
        'btnExecute
        '
        Me.btnExecute.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExecute.Location = New System.Drawing.Point(317, 617)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(90, 28)
        Me.btnExecute.TabIndex = 10
        Me.btnExecute.Text = "Execute"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'btnClearGrid
        '
        Me.btnClearGrid.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClearGrid.Location = New System.Drawing.Point(317, 368)
        Me.btnClearGrid.Name = "btnClearGrid"
        Me.btnClearGrid.Size = New System.Drawing.Size(90, 28)
        Me.btnClearGrid.TabIndex = 11
        Me.btnClearGrid.Text = "Clear Grid"
        Me.btnClearGrid.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1126, 662)
        Me.Controls.Add(Me.btnClearGrid)
        Me.Controls.Add(Me.btnExecute)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.listAnswers)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSQLQuery)
        Me.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSQLQuery As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents listAnswers As ListView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDisconnect As Button
    Friend WithEvents btnConnect As Button
    Friend WithEvents btnExecute As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnCreatDB As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnTableExists As Button
    Friend WithEvents btnGetFKeys As Button
    Friend WithEvents btnGetPKeys As Button
    Friend WithEvents btnGetColumns As Button
    Friend WithEvents btnGetTables As Button
    Friend WithEvents btnColumnExists As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClearGrid As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTableName As TextBox
    Friend WithEvents lbTableExists As Label
    Friend WithEvents lbColumnExists As Label
    Friend WithEvents txtColumnName As TextBox
    Friend WithEvents cbGetFKeys As ComboBox
    Friend WithEvents cbGetPKeys As ComboBox
    Friend WithEvents cbGetColumns As ComboBox
    Friend WithEvents cbGetTables As ComboBox
    Friend WithEvents cbDBFilename As ComboBox
End Class
