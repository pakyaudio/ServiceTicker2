Module modWIA
    Friend msgStr As String
    Public Function _WiaErrCode(Optional ByVal exMessage As String = "") As String
        Dim msgStr As String = ""
        Dim errNumber As String = ""

        Dim posFound As Integer = InStr(exMessage, ":")

        If posFound <> 0 Then
            errNumber = Mid(exMessage, posFound + 2)
            msgStr = errNumber
        End If

        Return msgStr

    End Function
End Module
