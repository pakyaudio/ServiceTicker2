Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class TaxInvoiceSearchIDFrm
    Dim selsctStrSQL As String
    Private Sub getDATA()
        If Me.cbbTISID.Text = "ชำระแล้ว" Then
            selsctStrSQL = 100
        ElseIf Me.cbbTISID.Text = "ยังไม่ได้ชำระเงิน" Then
            selsctStrSQL = 200
        End If
        Me.dgTISID.Rows.Clear()

        Try
            If selsctStrSQL = 100 Then
                strSQL = "SELECT sale_id,customer_id,fix_id,customer_name,code_pro,bar_code,name_pro,total_pro," _
                    & "price_buy,unit,datetime_save,discount FROM cash_sale_barcode WHERE datetime_save " _
                    & "BETWEEN '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd",
                    CultureInfo.CreateSpecificCulture("en-US")) & "' AND '" & Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd",
                    CultureInfo.CreateSpecificCulture("en-US")) & "';"
            ElseIf selsctStrSQL = 200 Then
                MsgBox("แจ้งเตือน หมายเลขบิลนี้ยังไม่ได้ชำระเงิน การออกใบเสร็จรับเงินสำหรับบิลนี้" & vbNewLine _
                       & "อาจมีผลตามกฎหมายที่เป็นหลักฐานว่าลูกค้าได้ชำระเงินแล้ว" & vbNewLine & "โปรดออกใบเสร็จรับเงินแก่ลูกค้าที่ไว้ใจได้เท่านั้น", MsgBoxStyle.Information, "แจ้งเตือน")
                strSQL = "SELECT sale_id,customer_id,fix_id,customer_name,code_pro,bar_code,name_pro,total_pro," _
                    & "price_buy,unit,datetime_save,discount FROM sale_barcode WHERE datetime_save " _
                    & "BETWEEN '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd",
                    CultureInfo.CreateSpecificCulture("en-US")) & "' AND '" & Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd",
                    CultureInfo.CreateSpecificCulture("en-US")) & "';"
            End If
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While Dr.Read()
                With Me.dgTISID
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.Item("sale_id")
                    .Rows(r).Cells(1).Value = Dr.Item("fix_id")
                    .Rows(r).Cells(2).Value = Dr.Item("customer_id")
                    .Rows(r).Cells(3).Value = Dr.Item("customer_name")
                    .Rows(r).Cells(4).Value = Dr.Item("code_pro")
                    .Rows(r).Cells(5).Value = Dr.Item("bar_code")
                    .Rows(r).Cells(6).Value = Dr.Item("name_pro")
                    .Rows(r).Cells(7).Value = Dr.Item("total_pro")
                    .Rows(r).Cells(8).Value = Dr.Item("unit")
                    .Rows(r).Cells(9).Value = Dr.GetDecimal("price_buy")
                    .Rows(r).Cells(10).Value = Dr.GetDecimal("discount")
                    .Rows(r).Cells(12).Value = Dr.Item("datetime_save")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            For x = 0 To dgTISID.RowCount - 1
                Me.dgTISID.Rows(x).Cells(10).Value = (CDec(dgTISID.Rows(x).Cells(9).Value) * CDec(dgTISID.Rows(x).Cells(7).Value)) - CDec(dgTISID.Rows(x).Cells(10).Value)
            Next
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        selsctStrSQL = Nothing
    End Sub

    Private Sub TaxInvoiceSearchIDFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub TaxInvoiceSearchIDFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        DateTimePicker1.Value = DateTime.Now.AddDays(-30)
        DateTimePicker2.Value = DateTime.Now.AddDays(1)
        Me.cbbTISID.Items.Add("ชำระแล้ว")
        Me.cbbTISID.Items.Add("ยังไม่ได้ชำระเงิน")
    End Sub

    Private Sub btnTISIDsearch_Click(sender As Object, e As EventArgs) Handles btnTISIDsearch.Click
        If Me.cbbTISID.Text = "" Then
            Exit Sub
        Else
            Call getDATA()
        End If

    End Sub

    Private Sub dgTISID_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgTISID.CellDoubleClick
        If Me.dgTISID.Rows.Count <> 0 Then
            If Me.cbbTISID.Text = "ชำระแล้ว" Then
                selsctStrSQL = 100
            ElseIf Me.cbbTISID.Text = "ยังไม่ได้ชำระเงิน" Then
                selsctStrSQL = 200
            End If

            Try
                If selsctStrSQL = 100 Then
                    strSQL = "SELECT sale_id,code_pro,name_pro,total_pro,unit,price_buy,discount FROM " _
                        & "cash_sale_barcode WHERE sale_id='" & Me.dgTISID.SelectedCells.Item(0).Value & "'"
                ElseIf selsctStrSQL = 200 Then
                    MsgBox("แจ้งเตือน หมายเลขบิลนี้ยังไม่ได้ชำระเงิน การออกใบเสร็จรับเงินสำหรับบิลนี้" & vbNewLine _
                           & "อาจมีผลตามกฎหมายที่เป็นหลักฐานว่าลูกค้าได้ชำระเงินแล้ว" & vbNewLine & "โปรดออกใบเสร็จรับเงินแก่ลูกค้าที่ไว้ใจได้เท่านั้น", MsgBoxStyle.Information, "แจ้งเตือน")
                    strSQL = "SELECT sale_id,code_pro,name_pro,total_pro,unit,price_buy,discount FROM sale_barcode WHERE sale_id='" & Me.dgTISID.SelectedCells.Item(0).Value & "'"
                End If
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dim r As Integer
                While Dr.Read()
                    With TaxInvoiceFrm.dgTI
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(1).Value = Dr.Item("code_pro")
                        .Rows(r).Cells(2).Value = Dr.Item("name_pro")
                        .Rows(r).Cells(3).Value = Dr.Item("total_pro")
                        .Rows(r).Cells(4).Value = Dr.Item("unit")
                        .Rows(r).Cells(5).Value = Dr.GetDecimal("price_buy")
                        .Rows(r).Cells(6).Value = Dr.GetDecimal("discount")
                        TaxInvoiceFrm.txtRefer.Text = Dr.Item("sale_id")
                    End With
                End While
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            TaxInvoiceFrm.sumALL()

            Try
                strSQL = "SELECT customer_tax,customer_section,customer_name,customer_address,customer_zipcode," _
                    & "customer_tel FROM customer WHERE customer_id='" & Me.dgTISID.SelectedCells.Item(2).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                If Dr.HasRows Then
                    TaxInvoiceFrm.txtTIcusid.Text = Me.dgTISID.SelectedCells.Item(2).Value
                    TaxInvoiceFrm.txtTIcusname.Text = Dr.Item("customer_name")
                    TaxInvoiceFrm.txtTIcusaddress.Text = Dr.Item("customer_address") & " " & Dr.Item("customer_zipcode")
                    TaxInvoiceFrm.txtTIcustel.Text = Dr.Item("customer_tel")
                    TaxInvoiceFrm.txtTItaxNumber.Text = Dr.Item("customer_tax")
                    TaxInvoiceFrm.txtTItaxSection.Text = Dr.Item("customer_section")
                    TaxInvoiceFrm.txtTIsearchBillID.Focus()
                End If
                Dr.Close()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Me.Close()
            selsctStrSQL = Nothing
        End If
    End Sub

    Private Sub cbbTISID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbTISID.KeyPress
        e.Handled = True
    End Sub
End Class