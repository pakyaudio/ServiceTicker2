Public Class MoneyExt
    Public Function NumberToThaiWord(ByVal InputNumber As Double) As String
        If InputNumber = 0 Then
            NumberToThaiWord = "ศูนย์บาทถ้วน"
            Return NumberToThaiWord
        End If

        Dim NewInputNumber As String
        NewInputNumber = InputNumber.ToString("###0.00")

        If CDbl(NewInputNumber) >= 10000000000000 Then
            NumberToThaiWord = ""
            Return NumberToThaiWord
        End If

        Dim tmpNumber(2) As String
        Dim FirstNumber As String
        Dim LastNumber As String

        tmpNumber = NewInputNumber.Split(CChar("."))
        FirstNumber = tmpNumber(0)
        LastNumber = tmpNumber(1)

        Dim nLength As Integer = 0
        nLength = CInt(FirstNumber.Length)

        Dim i As Integer
        Dim CNumber As Integer = 0
        Dim CNumberBak As Integer = 0
        Dim strNumber As String = ""
        Dim strPosition As String = ""
        Dim FinalWord As String = ""
        Dim CountPos As Integer = 0

        For i = nLength To 1 Step -1
            CNumberBak = CNumber
            CNumber = CInt(FirstNumber.Substring(CountPos, 1))

            If CNumber = 0 AndAlso i = 7 Then
                strPosition = "ล้าน"
            ElseIf CNumber = 0 Then
                strPosition = ""
            Else
                strPosition = PositionToText(i)
            End If

            If CNumber = 2 AndAlso strPosition = "สิบ" Then
                strNumber = "ยี่"
            ElseIf CNumber = 1 AndAlso strPosition = "สิบ" Then
                strNumber = ""
            ElseIf CNumber = 1 AndAlso strPosition = "ล้าน" AndAlso nLength >= 8 Then
                If CNumberBak = 0 Then
                    strNumber = "หนึ่ง"
                Else
                    strNumber = "เอ็ด"
                End If
            ElseIf CNumber = 1 AndAlso strPosition = "" AndAlso nLength > 1 Then
                strNumber = "เอ็ด"
            Else
                strNumber = NumberToText(CNumber)
            End If
            CountPos = CountPos + 1
            FinalWord = FinalWord & strNumber & strPosition
        Next
        CountPos = 0
        CNumberBak = 0
        nLength = CInt(LastNumber.Length)
        Dim Stang As String = ""
        Dim FinalStang As String = ""
        If CDbl(LastNumber) > 0.0 Then
            For i = nLength To 1 Step -1
                CNumberBak = CNumber
                CNumber = CInt(LastNumber.Substring(CountPos, 1))
                If CNumber = 1 AndAlso i = 2 Then
                    strPosition = "สิบ"
                ElseIf CNumber = 0 Then
                    strPosition = ""
                Else
                    strPosition = PositionToText(i)
                End If
                If CNumber = 2 AndAlso strPosition = "สิบ" Then
                    Stang = "ยี่"
                ElseIf CNumber = 1 AndAlso i = 2 Then
                    Stang = ""
                ElseIf CNumber = 1 AndAlso strPosition = "" AndAlso nLength > 1 Then
                    If CNumberBak = 0 Then
                        Stang = "หนึ่ง"
                    Else
                        Stang = "เอ็ด"
                    End If
                Else
                    Stang = NumberToText(CNumber)
                End If
                CountPos = CountPos + 1
                FinalStang = FinalStang & Stang & strPosition
            Next
            FinalStang = FinalStang & "สตางค์"
        Else
            FinalStang = ""
        End If
        Dim SubUnit As String
        If FinalStang = "" Then
            SubUnit = "บาทถ้วน"
        Else
            If CDbl(FirstNumber) <> 0 Then
                SubUnit = "บาท"
            Else
                SubUnit = ""
            End If
        End If
        NumberToThaiWord = FinalWord & SubUnit & FinalStang
    End Function

    Private Function NumberToText(ByVal CurrentNum As Integer) As String
        Dim _nText As String = ""

        Select Case CurrentNum
            Case 0
                _nText = ""
            Case 1
                _nText = "หนึ่ง"
            Case 2
                _nText = "สอง"
            Case 3
                _nText = "สาม"
            Case 4
                _nText = "สี่"
            Case 5
                _nText = "ห้า"
            Case 6
                _nText = "หก"
            Case 7
                _nText = "เจ็ด"
            Case 8
                _nText = "แปด"
            Case 9
                _nText = "เก้า"
        End Select

        NumberToText = _nText
    End Function

    Private Function PositionToText(ByVal CurrentPos As Integer) As String
        Dim _nPos As String = ""

        Select Case CurrentPos
            Case 0
                _nPos = ""
            Case 1
                _nPos = ""
            Case 2
                _nPos = "สิบ"
            Case 3
                _nPos = "ร้อย"
            Case 4
                _nPos = "พัน"
            Case 5
                _nPos = "หมื่น"
            Case 6
                _nPos = "แสน"
            Case 7
                _nPos = "ล้าน"
            Case 8
                _nPos = "สิบ"
            Case 9
                _nPos = "ร้อย"
            Case 10
                _nPos = "พัน"
            Case 11
                _nPos = "หมื่น"
            Case 12
                _nPos = "แสน"
            Case 13
                _nPos = "ล้าน"
        End Select

        PositionToText = _nPos
    End Function
End Class
