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

    Private Async Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        conn = New SSHProcessor(txtHostname.Text, txtPassword.Text, txtPort.Text, txtUsername.Text)
        btnConnect.Enabled = False
        Dim result As Boolean = Await Task.Run(AddressOf conn.Connect)
        If result Then
            btnDisconnect.Enabled = True
        Else
            btnConnect.Enabled = True
        End If
    End Sub

    Private Sub EccoHandler(prompt As String) Handles conn.Ecco
        Me.Invoke(New Action(
            Sub()
                txtConnectionLog.AppendText(Log(prompt))
            End Sub))
    End Sub

    Private Async Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        btnDisconnect.Enabled = False
        Dim result As Boolean = Await Task.Run(AddressOf conn.Disconnect)
        If result Then
            btnConnect.Enabled = True
        Else
            btnDisconnect.Enabled = True
        End If
    End Sub
End Class
