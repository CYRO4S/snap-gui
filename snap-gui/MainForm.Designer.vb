<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.pageConnection = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHostname = New System.Windows.Forms.TextBox()
        Me.btnClearLog = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtConnectionLog = New System.Windows.Forms.TextBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnSaveLog = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.pageConnection.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.pageConnection)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(863, 500)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'pageConnection
        '
        Me.pageConnection.Controls.Add(Me.btnSaveLog)
        Me.pageConnection.Controls.Add(Me.btnConnect)
        Me.pageConnection.Controls.Add(Me.chkShowPassword)
        Me.pageConnection.Controls.Add(Me.btnDisconnect)
        Me.pageConnection.Controls.Add(Me.txtConnectionLog)
        Me.pageConnection.Controls.Add(Me.Label5)
        Me.pageConnection.Controls.Add(Me.Label4)
        Me.pageConnection.Controls.Add(Me.Label3)
        Me.pageConnection.Controls.Add(Me.Label2)
        Me.pageConnection.Controls.Add(Me.btnClearLog)
        Me.pageConnection.Controls.Add(Me.txtPassword)
        Me.pageConnection.Controls.Add(Me.txtUsername)
        Me.pageConnection.Controls.Add(Me.txtPort)
        Me.pageConnection.Controls.Add(Me.txtHostname)
        Me.pageConnection.Controls.Add(Me.Label1)
        Me.pageConnection.Font = New System.Drawing.Font("Product Sans", 9.0!)
        Me.pageConnection.Location = New System.Drawing.Point(4, 28)
        Me.pageConnection.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pageConnection.Name = "pageConnection"
        Me.pageConnection.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pageConnection.Size = New System.Drawing.Size(855, 468)
        Me.pageConnection.TabIndex = 0
        Me.pageConnection.Text = "Connection"
        Me.pageConnection.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Size = New System.Drawing.Size(855, 468)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Host"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 28)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(855, 468)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Snap Store"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Product Sans", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(25, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Setup SSH Connection"
        '
        'txtHostname
        '
        Me.txtHostname.Font = New System.Drawing.Font("Product Sans", 12.0!)
        Me.txtHostname.Location = New System.Drawing.Point(134, 86)
        Me.txtHostname.Name = "txtHostname"
        Me.txtHostname.Size = New System.Drawing.Size(257, 32)
        Me.txtHostname.TabIndex = 1
        '
        'btnClearLog
        '
        Me.btnClearLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClearLog.Location = New System.Drawing.Point(185, 406)
        Me.btnClearLog.Name = "btnClearLog"
        Me.btnClearLog.Size = New System.Drawing.Size(100, 40)
        Me.btnClearLog.TabIndex = 8
        Me.btnClearLog.Text = "Clear Log"
        Me.btnClearLog.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Product Sans", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(26, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hostname"
        '
        'txtConnectionLog
        '
        Me.txtConnectionLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConnectionLog.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.txtConnectionLog.Location = New System.Drawing.Point(409, 86)
        Me.txtConnectionLog.Multiline = True
        Me.txtConnectionLog.Name = "txtConnectionLog"
        Me.txtConnectionLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConnectionLog.Size = New System.Drawing.Size(422, 360)
        Me.txtConnectionLog.TabIndex = 4
        '
        'txtPort
        '
        Me.txtPort.Font = New System.Drawing.Font("Product Sans", 12.0!)
        Me.txtPort.Location = New System.Drawing.Point(134, 124)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(257, 32)
        Me.txtPort.TabIndex = 2
        Me.txtPort.Text = "22"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Product Sans", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(26, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "SSH Port"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Product Sans", 12.0!)
        Me.txtUsername.Location = New System.Drawing.Point(134, 162)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(257, 32)
        Me.txtUsername.TabIndex = 3
        Me.txtUsername.Text = "root"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Product Sans", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(26, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Username"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Product Sans", 12.0!)
        Me.txtPassword.Location = New System.Drawing.Point(134, 200)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(257, 32)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Product Sans", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(26, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Password"
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDisconnect.Enabled = False
        Me.btnDisconnect.Location = New System.Drawing.Point(79, 406)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(100, 40)
        Me.btnDisconnect.TabIndex = 7
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Location = New System.Drawing.Point(134, 238)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(133, 23)
        Me.chkShowPassword.TabIndex = 5
        Me.chkShowPassword.Text = "Show password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(134, 267)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(148, 40)
        Me.btnConnect.TabIndex = 6
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnSaveLog
        '
        Me.btnSaveLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSaveLog.Location = New System.Drawing.Point(291, 406)
        Me.btnSaveLog.Name = "btnSaveLog"
        Me.btnSaveLog.Size = New System.Drawing.Size(100, 40)
        Me.btnSaveLog.TabIndex = 9
        Me.btnSaveLog.Text = "Save Log"
        Me.btnSaveLog.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 500)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Product Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Snap Remote"
        Me.TabControl1.ResumeLayout(False)
        Me.pageConnection.ResumeLayout(False)
        Me.pageConnection.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents pageConnection As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClearLog As Button
    Friend WithEvents txtHostname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents btnDisconnect As Button
    Friend WithEvents txtConnectionLog As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents btnSaveLog As Button
End Class
