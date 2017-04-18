Imports MySql.Data.MySqlClient
Public Class ViewReturnProductRepairFrm

    Private Sub ViewProductRepairFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ViewProductRepairFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        If Me.txtVPRfix_id.Text <> Nothing Then
            Call getDatatodgRPorderpro()
        End If
    End Sub

    Private Sub getDatatodgRPorderpro()
        Me.dgVPR.Rows.Clear()
        strSQL = "SELECT code_pro,name_pro,total,price_buy,unit FROM " _
            & "returnproduct_barcode WHERE fix_id='" & Me.txtVPRfix_id.Text & "'"
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim r As Integer
                With Me.dgVPR
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.GetString("code_pro")
                    .Rows(r).Cells(1).Value = Dr.GetString("name_pro")
                    .Rows(r).Cells(2).Value = Dr.GetDecimal("total")
                    .Rows(r).Cells(3).Value = Dr.GetDecimal("price_buy")
                    .Rows(r).Cells(4).Value = Dr.GetString("unit")
                    .Rows(r).Cells(5).Value = CDec(Me.dgVPR.Rows(r).Cells(3).Value) * CDec(Me.dgVPR.Rows(r).Cells(2).Value)
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        cmd = New MySqlCommand("SELECT customer_id,sale_id,datetime_save,customer_name,total_all,employee FROM " _
                               & "returnproduct WHERE fix_id='" & Me.txtVPRfix_id.Text & "'", ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader
            With Dr
                .Read()
                Me.txtVPRcustomer_id.Text = .Item("customer_id")
                Me.txtVPRsale_id.Text = .Item("sale_id")
                Me.txtVPRdatetime_save.Text = .Item("datetime_save")
                Me.txtVPRcustomer_name.Text = .Item("customer_name")
                Me.txtVPRtotal_all.Text = .Item("total_all")
                Me.txtVPRemployee.Text = .Item("employee")
            End With
            Dr.Close()
            Call totalSumPrice_buy()
            Call countRows()
        Catch ex As Exception
            MessageBox.Show(Me, "ไม่พบข้อมูลอะไหล่", "ไม่พบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            Me.Close()
        End Try
    End Sub
    Private Sub totalSumPrice_buy()
        'If dgRPorderPro.RowCount > 1 Then
        Dim oop As Decimal = 0
        For index As Integer = 0 To dgVPR.RowCount - 1
            oop += CDec(Me.dgVPR.Rows(index).Cells(5).Value)
        Next
        Me.txtVPRtotalProduct.Text = "รวม " & oop.ToString("N2") & " บาท"
        'End If
    End Sub
    Private Sub countRows()
        For index As Integer = 0 To dgVPR.RowCount
            Me.txtVPRlistCount.Text = "มี " & index.ToString & " รายการ"
        Next
    End Sub

End Class