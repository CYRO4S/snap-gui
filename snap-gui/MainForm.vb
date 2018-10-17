Public Class MainForm
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
End Class
