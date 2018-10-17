Module Logging

    Public Function Log(prompt As String) As String
        Return $"[{Date.Now}] {prompt}{vbCrLf}"
    End Function

End Module
