Public Class MainForm

    Private WithEvents conn As SSHProcessor

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    Private Sub btnClearLog_Click(sender As Object, e As EventArgs) Handles btnClearLog.Click
        txtConnectionLog.Clear()
    End Sub

    Private Sub btnSaveLog_Click(sender As Object, e As EventArgs) Handles btnSaveLog.Click
        Dim sfd As New SaveFileDialog With {
            .Filter = "Text File|*.txt",
            .Title = "Save Connection Log",
            .AddExtension = True,
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        }
        If sfd.ShowDialog = DialogResult.OK Then
            Using sw As New IO.StreamWriter(sfd.FileName, True, System.Text.Encoding.UTF8)
                sw.Write(txtConnectionLog.Text)
                sw.Close()
            End Using
        End If
    End Sub

    Private Sub EccoHandler(prompt As String) Handles conn.Ecco
        Me.Invoke(New Action(
            Sub()
                txtConnectionLog.AppendText(Log(prompt))
            End Sub))
    End Sub

    Private Async Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        conn = New SSHProcessor(txtHostname.Text, txtPassword.Text, txtPort.Text, txtUsername.Text)
        btnConnect.Enabled = False

        Dim result As Boolean = Await Task.Run(AddressOf conn.Connect)

        If result Then
            btnDisconnect.Enabled = True
            GetSystemInfo()
            GetInstalledSnaps()
        Else
            btnConnect.Enabled = True
        End If
    End Sub

    Private Async Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        lstInstalled.Clear()

        btnDisconnect.Enabled = False
        Dim result As Boolean = Await Task.Run(AddressOf conn.Disconnect)
        If result Then
            btnConnect.Enabled = True
        Else
            btnDisconnect.Enabled = True
        End If
    End Sub

    Public Async Sub GetSystemInfo()
        txtConnectionLog.AppendText(Log("Strat gathering system information..."))

        snap_version.Text = Await conn.ExecuteAsync("snap --version | grep ""snapd"" | grep -oE ""[0-9].*""")
        snap_series.Text = Await conn.ExecuteAsync("snap --version | grep ""series"" | grep -oE ""[0-9]*""")
        snap_account.Text = Await conn.ExecuteAsync("snap whoami")

        linux_distribution.Text = Await conn.ExecuteAsync("lsb_release -si")
        linux_verision.Text = Await conn.ExecuteAsync("lsb_release -sr")
        linux_kernel.Text = Await conn.ExecuteAsync("uname -r")
        linux_architecture.Text = Await conn.ExecuteAsync("uname -m")
        linux_hostname.Text = Await conn.ExecuteAsync("uname -n")

        cpu.Text = Await conn.ExecuteAsync("echo $( awk -F: '/model name/ {name=$2} END {print name}' /proc/cpuinfo | sed 's/^[\t]*//;s/[ \t]*$//' )")
        cpu_cores.Text = Await conn.ExecuteAsync("echo $( awk -F: '/model name/ {core++} END {print core}' /proc/cpuinfo )")
        cpu_frequency.Text = Await conn.ExecuteAsync("echo $( awk -F: '/cpu MHz/ {freq=$2} END {print freq}' /proc/cpuinfo | sed 's/^[ \t]*//;s/[ \r]*$//' )")

        Dim total_ram As Integer = CInt(Await conn.ExecuteAsync("cat /proc/meminfo | grep ""MemTotal"" | grep -o ""[0-9]*"""))
        ram_total.Text = CStr(CInt(total_ram / 1024)) & " MB"

        Dim free_ram As Integer = CInt(Await conn.ExecuteAsync("cat /proc/meminfo | grep ""MemFree"" | grep -o ""[0-9]*"""))
        ram_free.Text = CStr(CInt(free_ram / 1024)) & " MB"
        txtConnectionLog.AppendText(Log("Done gathering system information."))
    End Sub

    Public Async Sub GetInstalledSnaps()
        txtConnectionLog.AppendText(Log("Strat gathering installed snaps..."))
        Dim list_text As String = Await conn.ExecuteAsync("snap list")

        ' snap is not installed
        If list_text.Length = 0 Then
            txtConnectionLog.AppendText(Log("No snaps installed."))
            Exit Sub
        End If

        ' add all snaps into list
        Dim items As New List(Of String)
        For Each s As String In list_text.Split(vbLf)
            If s.Length = 0 Then Exit For

            Do
                If InStr(1, s, "  ") > 0 Then
                    s = Replace(s, "  ", " ")
                Else
                    Exit Do
                End If
            Loop

            items.Add(s)
        Next
        items.RemoveAt(0)

        For Each i As String In items
            Dim info() As String = i.Split(" ")

            Dim item As New ListViewItem(info(0))
            item.SubItems.Add(info(1))
            item.SubItems.Add(info(2))
            item.SubItems.Add(info(3))
            item.SubItems.Add(info(4).Replace("✓", ""))

            lstInstalled.Items.Add(item)

        Next

        txtConnectionLog.AppendText(Log("Done gathering installed snaps."))
    End Sub

End Class
