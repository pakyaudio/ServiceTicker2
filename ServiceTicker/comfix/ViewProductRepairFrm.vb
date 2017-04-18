Imports MySql.Data.MySqlClient
Public Class ViewProductRepairFrm

    Private Sub ViewProductRepairFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ViewProductRepairFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    ''' <summary>
    '''  getDatatodgRPorderpro(ByVal fixid)
    ''' </summary>
    ''' <param name="fixid">Search fix_id MySQL DataBase</param>
    ''' <remarks></remarks>
    Friend Sub getDatatodgRPorderpro(ByVal fixid)
        Me.dgVPR.Rows.Clear()
        Try
            strSQL = "SELECT code_pro,bar_code,name_pro,total_pro,price_buy,unit " _
             & "FROM sale_barcode WHERE fix_id='" & fixid & "';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                While Dr.Read()
                    Dim r As Integer
                    With Me.dgVPR
                        r = .Rows.Count
                        .Rows.Add()
                        .Rows(r).Cells(0).Value = Dr.Item("code_pro")
                        .Rows(r).Cells(1).Value = Dr.Item("bar_code")
                        .Rows(r).Cells(2).Value = Dr.Item("name_pro")
                        .Rows(r).Cells(3).Value = Dr.Item("total_pro")
                        .Rows(r).Cells(4).Value = Dr.Item("price_buy")
                        .Rows(r).Cells(5).Value = Dr.Item("unit")
                        .Rows(r).Cells(6).Value = CDec(Me.dgVPR.Rows(r).Cells(4).Value) * CDec(Me.dgVPR.Rows(r).Cells(3).Value)
                    End With
                End While
                Me.Label1.Text = "รายการขายในสถานะยังไม่ได้ชำระเงิน"
            Else
                strSQL = "SELECT code_pro,bar_code,name_pro,total_pro,price_buy,unit " _
                    & "FROM cash_sale_barcode WHERE fix_id='" & fixid & "';"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    While Dr.Read()
                        Dim r As Integer
                        With Me.dgVPR
                            r = .Rows.Count
                            .Rows.Add()
                            .Rows(r).Cells(0).Value = Dr.Item("code_pro")
                            .Rows(r).Cells(1).Value = Dr.Item("bar_code")
                            .Rows(r).Cells(2).Value = Dr.Item("name_pro")
                            .Rows(r).Cells(3).Value = Dr.Item("total_pro")
                            .Rows(r).Cells(4).Value = Dr.Item("price_buy")
                            .Rows(r).Cells(5).Value = Dr.Item("unit")
                            .Rows(r).Cells(6).Value = CDec(Me.dgVPR.Rows(r).Cells(4).Value) * CDec(Me.dgVPR.Rows(r).Cells(3).Value)
                        End With
                    End While
                    Me.Label1.Text = "รายการขายในสถานะชำระเงินแล้ว"
                End If
            End If
            Call totalSumPrice_buy()
            Call countRows()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Private Sub totalSumPrice_buy()
        Try
            Dim oop As Decimal = 0
            For index As Integer = 0 To dgVPR.RowCount - 1
                oop += CDec(Me.dgVPR.Rows(index).Cells(6).Value)
            Next
            Me.txtVPRtotalProduct.Text = "รวม " & oop.ToString("N2") & " บาท"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub countRows()
        Try
            For index As Integer = 0 To dgVPR.RowCount
                Me.txtVPRlistCount.Text = "มี " & index.ToString & " รายการ"
            Next
        Catch ex As Exception

        End Try
    End Sub
End Class