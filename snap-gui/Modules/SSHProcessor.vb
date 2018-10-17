Imports Renci.SshNet

Public Class SSHProcessor

    Private session As SshClient

    Public Event Ecco(prompt As String)

    Public Property Hostname As String
    Public Property Port As Integer
    Public Property Username As String
    Public Property Password As String

    ' constructors
    Public Sub New()
        Me.Port = 22
        Me.Username = "root"
    End Sub
    Public Sub New(hostname As String, password As String)
        Me.Hostname = hostname
        Me.Port = 22
        Me.Username = "root"
        Me.Password = password
    End Sub
    Public Sub New(hostname As String, password As String, port As Integer, username As String)
        Me.Hostname = hostname
        Me.Port = port
        Me.Username = username
        Me.Password = password
    End Sub

    ' establish ssh connection
    Public Sub Connect()
        If session Is Nothing Then Exit Sub

        session = New SshClient(Hostname, Port, Username, Password)
        RaiseEvent Ecco("Connecting... ")
        Try
            session.Connect()
            RaiseEvent Ecco("Connected.")
        Catch ex As Exception
            RaiseEvent Ecco($"Failed: {ex.Message}")
        End Try
    End Sub

End Class
