Module Logging

    Public Function Log(prompt As String) As String
        Return $"[{Date.Now}] [INFO] {prompt}{vbCrLf}"
    End Function

End Module
