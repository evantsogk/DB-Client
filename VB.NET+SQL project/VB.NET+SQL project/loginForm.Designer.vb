<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cbDataSource = New System.Windows.Forms.ComboBox()
        Me.cbInitialCatalog = New System.Windows.Forms.ComboBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbAuthentication = New System.Windows.Forms.ComboBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DBFilename:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "User Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password:"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(100, 281)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(85, 29)
        Me.btnConnect.TabIndex = 8
        Me.btnConnect.Text = "Connnect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(215, 281)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 29)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cbDataSource
        '
        Me.cbDataSource.FormattingEnabled = True
        Me.cbDataSource.Items.AddRange(New Object() {"195.251.248.152,22", "(LocalDB)\MSSQLLocalDB"})
        Me.cbDataSource.Location = New System.Drawing.Point(131, 75)
        Me.cbDataSource.Name = "cbDataSource"
        Me.cbDataSource.Size = New System.Drawing.Size(245, 24)
        Me.cbDataSource.TabIndex = 10
        '
        'cbInitialCatalog
        '
        Me.cbInitialCatalog.FormattingEnabled = True
        Me.cbInitialCatalog.Location = New System.Drawing.Point(131, 121)
        Me.cbInitialCatalog.Name = "cbInitialCatalog"
        Me.cbInitialCatalog.Size = New System.Drawing.Size(245, 24)
        Me.cbInitialCatalog.TabIndex = 11
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(132, 227)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(245, 22)
        Me.txtPassword.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(15, 260)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(374, 10)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(132, 190)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(245, 22)
        Me.txtUserName.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(22, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 23)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Authentication:"
        '
        'cbAuthentication
        '
        Me.cbAuthentication.BackColor = System.Drawing.SystemColors.Window
        Me.cbAuthentication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAuthentication.FormattingEnabled = True
        Me.cbAuthentication.Items.AddRange(New Object() {"SQL Server", "Windows"})
        Me.cbAuthentication.Location = New System.Drawing.Point(131, 28)
        Me.cbAuthentication.Name = "cbAuthentication"
        Me.cbAuthentication.Size = New System.Drawing.Size(246, 24)
        Me.cbAuthentication.TabIndex = 17
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(215, 147)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 27)
        Me.btnBrowse.TabIndex = 18
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 324)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.cbAuthentication)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.cbInitialCatalog)
        Me.Controls.Add(Me.cbDataSource)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "loginForm"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connect to Database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnConnect As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents cbDataSource As ComboBox
    Friend WithEvents cbInitialCatalog As ComboBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbAuthentication As ComboBox
    Friend WithEvents btnBrowse As Button
End Class
