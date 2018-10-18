<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.pageConnection = New System.Windows.Forms.TabPage()
        Me.btnSaveLog = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.txtConnectionLog = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClearLog = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.txtHostname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pageInformation = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ram_free = New System.Windows.Forms.Label()
        Me.ram_total = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cpu_frequency = New System.Windows.Forms.Label()
        Me.cpu_cores = New System.Windows.Forms.Label()
        Me.cpu = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.linux_hostname = New System.Windows.Forms.Label()
        Me.linux_architecture = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.linux_kernel = New System.Windows.Forms.Label()
        Me.linux_verision = New System.Windows.Forms.Label()
        Me.linux_distribution = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.snap_account = New System.Windows.Forms.Label()
        Me.snap_series = New System.Windows.Forms.Label()
        Me.snap_version = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pageInstalled = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.pageConnection.SuspendLayout()
        Me.pageInformation.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.pageConnection)
        Me.TabControl1.Controls.Add(Me.pageInformation)
        Me.TabControl1.Controls.Add(Me.pageInstalled)
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
        Me.pageConnection.Location = New System.Drawing.Point(4, 25)
        Me.pageConnection.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pageConnection.Name = "pageConnection"
        Me.pageConnection.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pageConnection.Size = New System.Drawing.Size(855, 471)
        Me.pageConnection.TabIndex = 0
        Me.pageConnection.Text = "Connection"
        Me.pageConnection.UseVisualStyleBackColor = True
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
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(134, 267)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(148, 40)
        Me.btnConnect.TabIndex = 6
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Location = New System.Drawing.Point(134, 238)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(110, 20)
        Me.chkShowPassword.TabIndex = 5
        Me.chkShowPassword.Text = "Show password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
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
        Me.txtConnectionLog.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Product Sans", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(26, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Product Sans", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(26, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Product Sans", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(26, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "SSH Port"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Product Sans", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(26, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hostname"
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
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Product Sans", 12.0!)
        Me.txtPassword.Location = New System.Drawing.Point(134, 200)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(257, 27)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Product Sans", 12.0!)
        Me.txtUsername.Location = New System.Drawing.Point(134, 162)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(257, 27)
        Me.txtUsername.TabIndex = 3
        Me.txtUsername.Text = "root"
        '
        'txtPort
        '
        Me.txtPort.Font = New System.Drawing.Font("Product Sans", 12.0!)
        Me.txtPort.Location = New System.Drawing.Point(134, 124)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(257, 27)
        Me.txtPort.TabIndex = 2
        Me.txtPort.Text = "22"
        '
        'txtHostname
        '
        Me.txtHostname.Font = New System.Drawing.Font("Product Sans", 12.0!)
        Me.txtHostname.Location = New System.Drawing.Point(134, 86)
        Me.txtHostname.Name = "txtHostname"
        Me.txtHostname.Size = New System.Drawing.Size(257, 27)
        Me.txtHostname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Product Sans", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(25, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Setup SSH Connection"
        '
        'pageInformation
        '
        Me.pageInformation.Controls.Add(Me.GroupBox3)
        Me.pageInformation.Controls.Add(Me.GroupBox2)
        Me.pageInformation.Controls.Add(Me.GroupBox1)
        Me.pageInformation.Controls.Add(Me.Label6)
        Me.pageInformation.Location = New System.Drawing.Point(4, 25)
        Me.pageInformation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pageInformation.Name = "pageInformation"
        Me.pageInformation.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pageInformation.Size = New System.Drawing.Size(855, 471)
        Me.pageInformation.TabIndex = 1
        Me.pageInformation.Text = "Information"
        Me.pageInformation.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ram_free)
        Me.GroupBox3.Controls.Add(Me.ram_total)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.cpu_frequency)
        Me.GroupBox3.Controls.Add(Me.cpu_cores)
        Me.GroupBox3.Controls.Add(Me.cpu)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Location = New System.Drawing.Point(363, 90)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(457, 301)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Hardware"
        '
        'ram_free
        '
        Me.ram_free.AutoSize = True
        Me.ram_free.Font = New System.Drawing.Font("Product Sans", 10.0!)
        Me.ram_free.Location = New System.Drawing.Point(122, 144)
        Me.ram_free.Name = "ram_free"
        Me.ram_free.Size = New System.Drawing.Size(66, 18)
        Me.ram_free.TabIndex = 12
        Me.ram_free.Text = "Loading..."
        '
        'ram_total
        '
        Me.ram_total.AutoSize = True
        Me.ram_total.Font = New System.Drawing.Font("Product Sans", 10.0!)
        Me.ram_total.Location = New System.Drawing.Point(122, 114)
        Me.ram_total.Name = "ram_total"
        Me.ram_total.Size = New System.Drawing.Size(66, 18)
        Me.ram_total.TabIndex = 11
        Me.ram_total.Text = "Loading..."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Product Sans", 10.0!)
        Me.Label17.Location = New System.Drawing.Point(12, 144)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 18)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "RAM Free"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Product Sans", 10.0!)
        Me.Label18.Location = New System.Drawing.Point(12, 114)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 18)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "RAM Total"
        '
        'cpu_frequency
        '
        Me.cpu_frequency.AutoSize = True
        Me.cpu_frequency.Font = New System.Drawing.Font("Product Sans", 10.0!)
        Me.cpu_frequency.Location = New System.Drawing.Point(122, 84)
        Me.cpu_frequency.Name = "cpu_frequency"
        Me.cpu_frequency.Size = New System.Drawing.Size(66, 18)
        Me.cpu_frequency.TabIndex = 8
        Me.cpu_frequency.Text = "Loading..."
        '
        'cpu_cores
        '
        Me.cpu_cores.AutoSize = True
        Me.cpu_cores.Font = New System.Drawing.Font("Product Sans", 10.0!)
        Me.cpu_cores.Location = New System.Drawing.Point(122, 54)
        Me.cpu_cores.Name = "cpu_cores"
        Me.cpu_cores.Size = New System.Drawing.Size(66, 18)
        Me.cpu_cores.TabIndex = 7
        Me.cpu_cores.Text = "Loading..."
        '
        'cpu
        '
        Me.cpu.AutoSize = True
        Me.cpu.Font = New System.Drawing.Font("Product Sans", 10.0!)
        Me.cpu.Location = New System.Drawing.Point(122, 24)
        Me.cpu.Name = "cpu"
        Me.cpu.Size = New System.Drawing.Size(66, 18)
        Me.cpu.TabIndex = 6
        Me.cpu.Text = "Loading..."
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Product Sans", 10.0!)
        Me.Label22.Location = New System.Drawing.Point(12, 84)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(104, 18)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "CPU Frequency"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Product Sans", 10.0!)
        Me.Label23.Location = New System.Drawing.Point(12, 54)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(75, 18)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "CPU Cores"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Product Sans", 10.0!)
        Me.Label24.Location = New System.Drawing.Point(12, 24)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(35, 18)
        Me.Label24.TabIndex = 3
        Me.Label24.Text = "CPU"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.linux_hostname)
        Me.GroupBox2.Controls.Add(Me.linux_architecture)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.linux_kernel)
        Me.GroupBox2.Controls.Add(Me.linux_verision)
        Me.GroupBox2.Controls.Add(Me.linux_distribution)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 213)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 178)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Linux"
        '
        'linux_hostname
        '
        Me.linux_hostname.AutoSize = True
        Me.linux_hostname.Font = New System.Drawing.Font("Product Sans", 10.0!)
        Me.linux_hostname.Location = New System.Drawing.Point(122, 144)
        Me.linux_hostname.Name = "linux_hostname"
        Me.linux_hostname.Size = New System.Drawing.Size(66, 18)
        Me.linux_hostname.TabIndex = 12
        Me.linux_hostname.Text = "Loading..."
        '
        'linux_architecture
        '
        Me.linux_architecture.AutoSize = True
        Me.linux_architecture.Font = New System.Drawing.Font("Product Sans", 10.0!)
        Me.linux_architecture.Location = New System.Drawing.Point(122, 114)
        Me.linux_architecture.Name = "linux_architecture"
        Me.linux_architecture.Size = New System.Drawing.Size(66, 18)
        Me.linux_architecture.TabIndex = 11
        Me.linux_architecture.Text = "Loading..."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Product Sans", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(12, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Hostname"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Product Sans", 10.0!)
        Me.Label16.Location = New System.Drawing.Point(12, 114)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 18)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Architecture"
        '
        'linux_kernel
        '
        Me.linux_kernel.AutoSize = True
        Me.linux_kernel.Font = New System.Drawing.Font("Product Sans", 10.0!)
        Me.linux_kernel.Location = New System.Drawing.Point(122, 84)
        Me.linux_kernel.Name = "linux_kernel"
        Me.linux_kernel.Size = New System.Drawing.Size(66, 18)
        Me.linux_kernel.TabIndex = 8
        Me.linux_kernel.Text = "Loading..."
        '
        'linux_verision
        '
        Me.linux_verision.AutoSize = True
        Me.linux_verision.Font = New System.Drawing.Font("Product Sans", 10.0!)
        Me.linux_verision.Location = New System.Drawing.Point(122, 54)
        Me.linux_verision.Name = "linux_verision"
        Me.linux_verision.Size = New System.Drawing.Size(66, 18)
        Me.linux_verision.TabIndex = 7
        Me.linux_verision.Text = "Loading..."
        '
        'linux_distribution
        '
        Me.linux_distribution.AutoSize = True
        Me.linux_distribution.Font = New System.Drawing.Font("Product Sans", 10.0!)
        Me.linux_distribution.Location = New System.Drawing.Point(122, 24)
        Me.linux_distribution.Name = "linux_distribution"
        Me.linux_distribution.Size = New System.Drawing.Size(66, 18)
        Me.linux_distribution.TabIndex = 6
        Me.linux_distribution.Text = "Loading..."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Product Sans", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(12, 84)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 18)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Kernel"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Product Sans", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(12, 54)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 18)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Version"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Product Sans", 10.0!)
        Me.Label15.Location = New System.Drawing.Point(12, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 18)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Distribution"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.snap_account)
        Me.GroupBox1.Controls.Add(Me.snap_series)
        Me.GroupBox1.Controls.Add(Me.snap_version)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 117)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Snap"
        '
        'snap_account
        '
        Me.snap_account.AutoSize = True
        Me.snap_account.Font = New System.Drawing.Font("Product Sans", 10.0!)
        Me.snap_account.Location = New System.Drawing.Point(122, 84)
        Me.snap_account.Name = "snap_account"
        Me.snap_account.Size = New System.Drawing.Size(66, 18)
        Me.snap_account.TabIndex = 8
        Me.snap_account.Text = "Loading..."
        '
        'snap_series
        '
        Me.snap_series.AutoSize = True
        Me.snap_series.Font = New System.Drawing.Font("Product Sans", 10.0!)
        Me.snap_series.Location = New System.Drawing.Point(122, 54)
        Me.snap_series.Name = "snap_series"
        Me.snap_series.Size = New System.Drawing.Size(66, 18)
        Me.snap_series.TabIndex = 7
        Me.snap_series.Text = "Loading..."
        '
        'snap_version
        '
        Me.snap_version.AutoSize = True
        Me.snap_version.Font = New System.Drawing.Font("Product Sans", 10.0!)
        Me.snap_version.Location = New System.Drawing.Point(122, 24)
        Me.snap_version.Name = "snap_version"
        Me.snap_version.Size = New System.Drawing.Size(66, 18)
        Me.snap_version.TabIndex = 6
        Me.snap_version.Text = "Loading..."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Product Sans", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(12, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 18)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Account"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Product Sans", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(12, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 18)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Series"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Product Sans", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(12, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 18)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Version"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Product Sans", 16.0!)
        Me.Label6.Location = New System.Drawing.Point(25, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 28)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "System Information"
        '
        'pageInstalled
        '
        Me.pageInstalled.Location = New System.Drawing.Point(4, 25)
        Me.pageInstalled.Name = "pageInstalled"
        Me.pageInstalled.Size = New System.Drawing.Size(855, 471)
        Me.pageInstalled.TabIndex = 2
        Me.pageInstalled.Text = "Installed"
        Me.pageInstalled.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
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
        Me.pageInformation.ResumeLayout(False)
        Me.pageInformation.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents pageConnection As TabPage
    Friend WithEvents pageInformation As TabPage
    Friend WithEvents pageInstalled As TabPage
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
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents snap_account As Label
    Friend WithEvents snap_series As Label
    Friend WithEvents snap_version As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents linux_kernel As Label
    Friend WithEvents linux_verision As Label
    Friend WithEvents linux_distribution As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents linux_hostname As Label
    Friend WithEvents linux_architecture As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ram_free As Label
    Friend WithEvents ram_total As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents cpu_frequency As Label
    Friend WithEvents cpu_cores As Label
    Friend WithEvents cpu As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
End Class
