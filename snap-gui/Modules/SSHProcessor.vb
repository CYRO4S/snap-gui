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
    Public Function Connect() As Boolean
        session = New SshClient(Hostname, Port, Username, Password)
        RaiseEvent Ecco("Connecting... ")

        Try
            session.Connect()
        Catch ex As Exception
            RaiseEvent Ecco($"Failed: {ex.Message}")
            Return False
            Exit Function
        End Try

        RaiseEvent Ecco("Connected.")
        Return True
    End Function


    ' disconnect from remote computer
    Public Function Disconnect() As Boolean
        If session Is Nothing Then
            Return False
            Exit Function
        End If

        RaiseEvent Ecco("Disconnecting...")

        Try
            session.Disconnect()
        Catch ex As Exception
            RaiseEvent Ecco($"Failed: {ex.Message}")
            Return False
            Exit Function
        End Try

        RaiseEvent Ecco("Disconnected.")
        Return True
    End Function

    ' execute command and get return
    Public Async Function ExecuteAsync(command As String) As Task(Of String)
        If session Is Nothing Then
            Return Nothing
            Exit Function
        End If

        If session.IsConnected = False Then
            Return Nothing
            Exit Function
        End If

        Dim cmd As SshCommand = session.CreateCommand(command)
        Dim result As String
        Try
            result = Await Task.Run(AddressOf cmd.Execute)
        Catch ex As Exception
            result = ex.Message
        End Try

        Return result
    End Function

End Class
