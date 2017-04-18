Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class ReturnsProductFrm
    Private Sub ReturnsProductFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.dgRPsendProBarcode.Rows.Count <> 0 Then
            If MessageBox.Show(Me, "มีข้อมูลการคืนยังไม่ถูกบันทึกต้องการจะปิดหน้าต่างนี้หรือไม่" & vbNewLine & " YES=ใช่ ปิดเลย NO=ยังไม่ปิด" _
                               , "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                e.Cancel = False
                Me.Dispose()
                OnTopFrm()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub ReturnsProductFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            'Help
        End If
    End Sub

    Private Sub ReturnsProductFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call loadbill()
    End Sub

    Private Sub loadbill()
        Try
            cmd = New MySqlCommand("SELECT ver_PartsWithdrawal FROM ver_detail", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Me.lblRPSale_id.Text = "เลขที่บิลขาย รหัสขึ้นต้นด้วย " & Dr.Item("ver_PartsWithdrawal")
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
 
    Dim fixid As String
    Function SearchSaleID(ByVal saleID As String) As String
        cmd = New MySqlCommand("SELECT sale_id FROM sale WHERE sale_id='" & saleID & "'", ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Me.txtRPsaleShow_id.Text = saleID
                'fixid = Dr.Item("fix_id")
                Return "SALE"
            Else
                cmd = New MySqlCommand("SELECT sale_id FROM cash_sale WHERE sale_id='" & saleID & "'", ConnectionDB)
                Call open_connection()
                Try
                    Dr = cmd.ExecuteReader
                    Dr.Read()
                    If Dr.HasRows Then
                        Me.txtRPsaleShow_id.Text = saleID
                        'fixid = Dr.Item("fix_id")
                        Return "CASH SALE"
                    Else
                        Return "NO DATA"
                    End If
                Catch ex As Exception
                    Return "ERROR"
                End Try
            End If
        Catch ex As Exception
            Return "ERROR"
        End Try
    End Function

    Friend Sub SearchSaleIDbySN(ByVal sn As String)
        If Me.dgRPsendProBarcode.Rows.Count <> 0 Then
            If MessageBox.Show(Me, "ข้อมูลการคืนยังไม่ได้บันทึก ต้องการแทนที่ด้วยข้อมูลไหมหรือไม่" & vbNewLine & "YES=ใช่แทนที่เลย  NO=ไม่ให้ฉันบันทึกก่อนนะ", _
                 "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Call Clear_Form()
                Try
                    cmd = New MySqlCommand("SELECT sale_id FROM sale_serial WHERE serial_pro='" & sn & "'", ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    Dr.Read()
                    If Dr.HasRows Then
                        Me.txtRPsaleShow_id.Text = Dr.Item("sale_id")
                        Call getDatatodgRPproBarcode(Dr.Item("sale_id"))
                    Else

                        cmd = New MySqlCommand("SELECT sale_id FROM cash_sale_serial WHERE serial_pro='" & sn & "'", ConnectionDB)
                        Call open_connection()
                        Dr = cmd.ExecuteReader
                        Dr.Read()
                        If Dr.HasRows Then
                            Me.txtRPsaleShow_id.Text = Dr.Item("sale_id")
                            Call getDatatodgRPproBarcodeCash(Dr.Item("sale_id"))
                        Else
                            MessageBox.Show(Me, "ไม่พบข้อมูล SN นี้", "ไม่พบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                    End If
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            End If
        Else
            Try
                cmd = New MySqlCommand("SELECT sale_id FROM sale_serial WHERE serial_pro='" & sn & "'", ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                If Dr.HasRows Then
                    Me.txtRPsaleShow_id.Text = Dr.Item("sale_id")
                    Call getDatatodgRPproBarcode(Dr.Item("sale_id"))
                Else

                    cmd = New MySqlCommand("SELECT sale_id FROM cash_sale_serial WHERE serial_pro='" & sn & "'", ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    Dr.Read()
                    If Dr.HasRows Then
                        Me.txtRPsaleShow_id.Text = Dr.Item("sale_id")
                        Call getDatatodgRPproBarcodeCash(Dr.Item("sale_id"))
                    Else
                        MessageBox.Show(Me, "ไม่พบข้อมูล SN นี้", "ไม่พบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub

    Private Sub getDatatodgRPproBarcode(ByVal saleID As String)
        Try
            strSQL = "SELECT fix_id,customer_id,datetime_save,cash_status,employee FROM sale WHERE sale_id='" & saleID & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            fixid = Dr.Item("fix_id")
            Me.txtDatetime_save.Text = Dr.Item("datetime_save")
            Me.txtEmployee.Text = Dr.Item("employee")
            Me.txtCashDetail.Text = "ยังไม่ชำระเงิน"
            Me.lblRPproductStatus.Text = Dr.Item("cash_status")
            Call GetCustomer(Dr.Item("customer_id"))
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'หาข้อมูลจาก barcode
            Me.dgRPproBarcode.Rows.Clear()
            strSQL = "SELECT code_pro,name_pro,price_buy,total_pro,unit,discount FROM sale_barcode WHERE sale_id='" & saleID & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim r As Integer
                With Me.dgRPproBarcode
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.Item("code_pro")
                    .Rows(r).Cells(1).Value = Dr.Item("name_pro")
                    .Rows(r).Cells(2).Value = Dr.Item("price_buy")
                    .Rows(r).Cells(3).Value = Dr.Item("total_pro")
                    .Rows(r).Cells(4).Value = Dr.Item("unit")
                    .Rows(r).Cells(5).Value = Dr.Item("discount")
                End With
            End While
            Me.lblBarcode.Text = "รายการสินค้าในรายการขาย/เบิกอะไหล่ เลขที่ " & saleID
            Me.dgRPproBarcode.ClearSelection()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'อ่านข้อมูล SN
            Me.dgRPproSN.Rows.Clear()
            strSQL = "SELECT serial_pro,code_pro,name_pro FROM sale_serial WHERE sale_id='" & saleID & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim r As Integer
                With Me.dgRPproSN
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.Item("serial_pro")
                    .Rows(r).Cells(1).Value = Dr.Item("code_pro")
                    .Rows(r).Cells(2).Value = Dr.Item("name_pro")
                End With
            End While
            Me.lblSN.Text = "รายการ SN ในรายการขาย/เบิกอะไหล่ เลขที่ " & saleID

            Me.dgRPproSN.ClearSelection()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub getDatatodgRPproBarcodeCash(ByVal saleID As String)
        Try
            strSQL = "SELECT fix_id,customer_id,datetime_save,employee,cash_status,cash_detail FROM cash_sale WHERE sale_id='" & saleID & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            fixid = Dr.Item("fix_id")
            Me.txtDatetime_save.Text = Dr.Item("datetime_save")
            Me.txtEmployee.Text = Dr.Item("employee")
            Me.txtCashDetail.Text = Dr.Item("cash_detail")
            Me.lblRPproductStatus.Text = Dr.Item("cash_status")
            Call GetCustomer(Dr.Item("customer_id"))
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'หาข้อมูลจาก barcode
            Me.dgRPproBarcode.Rows.Clear()
            strSQL = "SELECT customer_id,code_pro,name_pro,price_buy,total_pro,unit,discount FROM cash_sale_barcode WHERE sale_id='" & saleID & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim r As Integer
                With Me.dgRPproBarcode
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.Item("code_pro")
                    .Rows(r).Cells(1).Value = Dr.Item("name_pro")
                    .Rows(r).Cells(2).Value = Dr.Item("price_buy")
                    .Rows(r).Cells(3).Value = Dr.Item("total_pro")
                    .Rows(r).Cells(4).Value = Dr.Item("unit")
                    .Rows(r).Cells(5).Value = Dr.Item("discount")
                End With
            End While
            Me.lblBarcode.Text = "รายการสินค้าในรายการขาย/เบิกอะไหล่ เลขที่ " & saleID
            Me.dgRPproBarcode.ClearSelection()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'อ่านข้อมูล SN
            Me.dgRPproSN.Rows.Clear()
            strSQL = "SELECT serial_pro,code_pro,name_pro FROM cash_sale_serial WHERE sale_id='" & saleID & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim r As Integer
                With Me.dgRPproSN
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.Item("serial_pro")
                    .Rows(r).Cells(1).Value = Dr.Item("code_pro")
                    .Rows(r).Cells(2).Value = Dr.Item("name_pro")
                End With
            End While
            Me.lblSN.Text = "รายการ SN ในรายการขาย/เบิกอะไหล่ เลขที่ " & saleID
            Me.dgRPproSN.ClearSelection()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub GetCustomer(ByVal cusid As String)
        cmd = New MySqlCommand("SELECT customer_id,customer_name,customer_address,customer_tel FROM customer WHERE customer_id='" & cusid & "'", ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Me.txtRPcustomerID.Text = Dr.Item("customer_id")
                Me.txtRPcustomerName.Text = Dr.GetString("customer_name")
                Me.txtRPcustomerAddress.Text = Dr.GetString("customer_address")
                Me.txtRPcustomerTel.Text = Dr.GetString("customer_tel")
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub SearchSale_id()
        If Me.dgRPsendProBarcode.Rows.Count <> 0 Then
            If MessageBox.Show(Me, "ข้อมูลการคืนยังไม่ได้บันทึก ต้องการแทนที่ด้วยข้อมูลใหม่หรือไม่" & vbNewLine & "YES=ใช่แทนที่เลย  NO=ไม่ให้ฉันบันทึกก่อนนะ", _
                 "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim txtold As Object = Me.txtRPsale_id.Text
                Call Clear_Form()
                Me.txtRPsale_id.Text = txtold
                If SearchSaleID(Me.txtRPsale_id.Text) = "SALE" Then
                    Call getDatatodgRPproBarcode(Me.txtRPsale_id.Text)
                ElseIf SearchSaleID(Me.txtRPsale_id.Text) = "CASH SALE" Then
                    Call getDatatodgRPproBarcodeCash(Me.txtRPsale_id.Text)
                Else
                    MessageBox.Show(Me, "ไม่พบข้อมูลงานขาย/ใบเบิกอะไหล่นี้", "ไม่พบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            If SearchSaleID(Me.txtRPsale_id.Text) = "SALE" Then
                Call getDatatodgRPproBarcode(Me.txtRPsale_id.Text)
            ElseIf SearchSaleID(Me.txtRPsale_id.Text) = "CASH SALE" Then
                Call getDatatodgRPproBarcodeCash(Me.txtRPsale_id.Text)
            Else
                MessageBox.Show(Me, "ไม่พบข้อมูลงานขาย/ใบเบิกอะไหล่นี้", "ไม่พบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Me.txtRPsale_id.Clear()
    End Sub

    Private Sub txtRPsale_id_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRPsale_id.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtRPsale_id.Text <> Nothing Then
                Call SearchSale_id()
            End If
        End If
    End Sub

    Private Sub txtRPsearchSN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRPsearchSN.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtRPsearchSN.Text <> Nothing Then
                Call SearchSaleIDbySN(Me.txtRPsearchSN.Text)
                Me.txtRPsearchSN.Clear()
            End If
        End If
    End Sub

    Private Sub dgRPproSN_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgRPproSN.RowStateChanged
        If Me.dgRPproSN.Rows.Count <> 0 Then
            Me.txtRPsnADD.Enabled = True
            Me.btnRPsnOK.Enabled = True
        Else
            Me.txtRPsnADD.Enabled = False
            Me.btnRPsnOK.Enabled = False
        End If
    End Sub

    Private Sub dgRPproBarcode_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgRPproBarcode.CellMouseClick
        If Me.dgRPproBarcode.Rows.Count <> 0 Then
            If e.Button = MouseButtons.Right Then
                Me.dgRPproBarcode.Rows(e.RowIndex).Selected = True
                Me.dgRPproBarcode.CurrentCell = dgRPproBarcode.Rows(e.RowIndex).Cells(0)
                Me.BarcodeContextMenu.Show(dgRPproBarcode, e.Location)
                Me.BarcodeContextMenu.Show(Cursor.Position)
                For r As Integer = 0 To Me.dgRPproSN.Rows.Count - 1
                    If Me.dgRPproBarcode.CurrentRow.Cells(0).Value = Me.dgRPproSN.Rows(r).Cells(1).Value Then
                        Me.BarcodeContextMenu.Enabled = False
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub BarcodeContextMenu_Click(sender As Object, e As EventArgs) Handles BarcodeContextMenu.Click
        For opq As Integer = 0 To Me.dgRPsendProBarcode.Rows.Count - 1
            If Me.dgRPproBarcode.SelectedCells.Item(0).Value = Me.dgRPsendProBarcode.Rows(opq).Cells(0).Value Then
                MiniReturnProductFrm.txtMRPnumPro.Text = CDec(Me.dgRPproBarcode.Rows(opq).Cells(3).Value) - CDec(Me.dgRPsendProBarcode.Rows(opq).Cells(3).Value)
                MiniReturnProductFrm.ShowDialog(Me)
                Call sumDG()
                Exit Sub
            End If
        Next
        MiniReturnProductFrm.txtMRPnumPro.Text = Me.dgRPproBarcode.SelectedCells.Item(3).Value
        MiniReturnProductFrm.ShowDialog(Me)
        Call sumDG()
    End Sub

    Friend Sub sumDG()
        Me.txtRPsumall.Text = 0
        Dim oop As Decimal = Nothing
        For iii As Integer = 0 To dgRPsendProBarcode.RowCount - 1
            Me.dgRPsendProBarcode.Rows(iii).Cells(7).Value = ((CDec(Me.dgRPsendProBarcode.Rows(iii).Cells(2).Value) * CDec(Me.dgRPsendProBarcode.Rows(iii).Cells(3).Value)) _
                - CDec(Me.dgRPsendProBarcode.Rows(iii).Cells(5).Value)) - CDec(Me.dgRPsendProBarcode.Rows(iii).Cells(6).Value)
            oop += CDec(Me.dgRPsendProBarcode.Rows(iii).Cells(7).Value)
            Me.txtRPsumall.Text = oop.ToString("N2")
        Next
    End Sub

    Private Sub getDataSN()
        If Me.txtRPsnADD.Text <> Nothing Then
            For g As Integer = 0 To dgRPsendProSN.Rows.Count - 1
                If Me.dgRPsendProSN.Rows(g).Cells(0).Value = Me.txtRPsnADD.Text Then
                    MessageBox.Show(Me, "มีข้อมูล '" & Me.txtRPsnADD.Text & "' อยู่ในตารางแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtRPsnADD.Clear()
                    Me.txtRPsnADD.Focus()
                    Exit Sub
                End If
            Next

            If Me.lblRPproductStatus.Text = "ยังไม่ชำระเงิน" Then
                Try
                    Dim r As Integer = 0
                    strSQL = "SELECT serial_pro,code_pro,name_pro FROM sale_serial WHERE " _
                     & "serial_pro='" & Me.txtRPsnADD.Text & "' and sale_id='" & Me.txtRPsaleShow_id.Text & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    If Dr.HasRows = 0 Then
                        MsgBox("ไม่พบข้อมูล '" & Me.txtRPsnADD.Text & "' ในบิลขายสินค้านี้", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                        Me.txtRPsnADD.Clear()
                        Me.txtRPsnADD.Focus()
                        Exit Sub
                    End If
                    While Dr.Read
                        With dgRPsendProSN
                            r = .RowCount
                            .Rows.Add()
                            .Rows(r).Cells(0).Value = Dr.Item(0)
                            .Rows(r).Cells(1).Value = Dr.Item(1)
                            .Rows(r).Cells(2).Value = Dr.Item(2)
                        End With
                    End While
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try

                Try
                    strSQL = "SELECT code_pro FROM sale_serial WHERE " _
                        & "serial_pro='" & Me.txtRPsnADD.Text & "' AND sale_id='" & Me.txtRPsaleShow_id.Text & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    Dim cp As String
                    Dr.Read()
                    cp = Dr.Item(0)
                    Dim dr1 As MySqlDataReader
                    Dim rr As Integer = 0
                    strSQL = "SELECT code_pro,name_pro,price_buy,unit FROM product WHERE code_pro='" & cp & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    dr1 = cmd.ExecuteReader
                    dr1.Read()
                    For cg As Integer = 0 To Me.dgRPsendProBarcode.Rows.Count - 1
                        If Me.dgRPsendProBarcode.Rows(cg).Cells(0).Value = cp Then
                            Me.dgRPsendProBarcode.Rows(cg).Cells(3).Value = CDec(Me.dgRPsendProBarcode.Rows(cg).Cells(3).Value) + CDec(1)

                            For dis As Integer = 0 To Me.dgRPproBarcode.Rows.Count - 1
                                If Me.dgRPsendProBarcode.Rows(cg).Cells(0).Value = Me.dgRPproBarcode.Rows(dis).Cells(0).Value Then
                                    Me.dgRPsendProBarcode.Rows(cg).Cells(5).Value = (CDec(Me.dgRPproBarcode.Rows(dis).Cells(5).Value) / CDec(Me.dgRPproBarcode.Rows(dis).Cells(3).Value)) _
                                                                                    * CDec(Me.dgRPsendProBarcode.Rows(cg).Cells(3).Value)
                                End If
                            Next

                            Me.dgRPsendProBarcode.Rows(cg).Cells(7).Value = ((CDec(Me.dgRPsendProBarcode.Rows(cg).Cells(3).Value) * CDec(Me.dgRPsendProBarcode.Rows(cg).Cells(2).Value)) _
                                                                         - CDec(Me.dgRPsendProBarcode.Rows(cg).Cells(5).Value)) - CDec(Me.dgRPsendProBarcode.Rows(cg).Cells(6).Value)
                            Me.txtRPsnADD.Clear()
                            Me.txtRPsnADD.Focus()
                            Call sumDG()
                            Exit Sub
                        End If
                    Next
                    With Me.dgRPsendProBarcode
                        rr = .RowCount
                        .Rows.Add()
                        .Rows(rr).Cells(0).Value = dr1.Item(0)
                        .Rows(rr).Cells(1).Value = dr1.Item(1)
                        .Rows(rr).Cells(2).Value = dr1.Item(2)
                        .Rows(rr).Cells(3).Value = "1"
                        .Rows(rr).Cells(4).Value = dr1.Item(3)
                        For dis As Integer = 0 To Me.dgRPproBarcode.Rows.Count - 1
                            If Me.dgRPsendProBarcode.Rows(rr).Cells(0).Value = Me.dgRPproBarcode.Rows(dis).Cells(0).Value Then
                                .Rows(rr).Cells(5).Value = CDec(Me.dgRPproBarcode.Rows(dis).Cells(5).Value) / CDec(Me.dgRPproBarcode.Rows(dis).Cells(3).Value)
                            End If
                        Next
                        .Rows(rr).Cells(7).Value = ((CDec(.Rows(rr).Cells(3).Value) * CDec(.Rows(rr).Cells(2).Value)) _
                                                    - CDec(.Rows(rr).Cells(5).Value)) - CDec(.Rows(rr).Cells(6).Value)
                        Call sumDG()
                    End With
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
                Me.txtRPsnADD.Clear()
            ElseIf Me.lblRPproductStatus.Text = "ชำระเงิน" Then
                Try
                    Dim r As Integer = 0
                    strSQL = "SELECT serial_pro,code_pro,name_pro FROM cash_sale_serial WHERE " _
                     & "serial_pro='" & Me.txtRPsnADD.Text & "' and sale_id='" & Me.txtRPsaleShow_id.Text & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    If Dr.HasRows = 0 Then
                        MsgBox("ไม่พบข้อมูล '" & Me.txtRPsnADD.Text & "' ในบิลขายสินค้านี้", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                        Me.txtRPsnADD.Clear()
                        Me.txtRPsnADD.Focus()
                        Exit Sub
                    End If
                    While Dr.Read
                        With dgRPsendProSN
                            r = .RowCount
                            .Rows.Add()
                            .Rows(r).Cells(0).Value = Dr.Item(0)
                            .Rows(r).Cells(1).Value = Dr.Item(1)
                            .Rows(r).Cells(2).Value = Dr.Item(2)
                        End With
                    End While
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try

                Try
                    strSQL = "SELECT code_pro FROM cash_sale_serial WHERE " _
                     & "serial_pro='" & Me.txtRPsnADD.Text & "' and sale_id='" & Me.txtRPsaleShow_id.Text & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    Dim cp As String
                    Dr.Read()
                    cp = Dr.Item(0)
                    Dim dr1 As MySqlDataReader
                    Dim rr As Integer = 0
                    strSQL = "SELECT code_pro,name_pro,price_buy,unit FROM product WHERE code_pro='" & cp & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    dr1 = cmd.ExecuteReader
                    dr1.Read()
                    For cg As Integer = 0 To Me.dgRPsendProBarcode.Rows.Count - 1
                        If Me.dgRPsendProBarcode.Rows(cg).Cells(0).Value = cp Then
                            Me.dgRPsendProBarcode.Rows(cg).Cells(3).Value = CDec(Me.dgRPsendProBarcode.Rows(cg).Cells(3).Value) + CDec(1)

                            For dis As Integer = 0 To Me.dgRPproBarcode.Rows.Count - 1
                                If Me.dgRPsendProBarcode.Rows(cg).Cells(0).Value = Me.dgRPproBarcode.Rows(dis).Cells(0).Value Then
                                    Me.dgRPsendProBarcode.Rows(cg).Cells(5).Value = (CDec(Me.dgRPproBarcode.Rows(dis).Cells(5).Value) / CDec(Me.dgRPproBarcode.Rows(dis).Cells(3).Value)) _
                                                                                    * CDec(Me.dgRPsendProBarcode.Rows(cg).Cells(3).Value)
                                End If
                            Next

                            Me.dgRPsendProBarcode.Rows(cg).Cells(7).Value = ((CDec(Me.dgRPsendProBarcode.Rows(cg).Cells(3).Value) * CDec(Me.dgRPsendProBarcode.Rows(cg).Cells(2).Value)) _
                                                                              - CDec(Me.dgRPsendProBarcode.Rows(cg).Cells(5).Value)) - CDec(Me.dgRPsendProBarcode.Rows(cg).Cells(6).Value)
                            Me.txtRPsnADD.Clear()
                            Me.txtRPsnADD.Focus()
                            Call sumDG()
                            Exit Sub
                        End If
                    Next
                    With Me.dgRPsendProBarcode
                        rr = .RowCount
                        .Rows.Add()
                        .Rows(rr).Cells(0).Value = dr1.Item(0)
                        .Rows(rr).Cells(1).Value = dr1.Item(1)
                        .Rows(rr).Cells(2).Value = dr1.Item(2)
                        .Rows(rr).Cells(3).Value = "1"
                        .Rows(rr).Cells(4).Value = dr1.Item(3)
                        For dis As Integer = 0 To Me.dgRPproBarcode.Rows.Count - 1
                            If Me.dgRPsendProBarcode.Rows(rr).Cells(0).Value = Me.dgRPproBarcode.Rows(dis).Cells(0).Value Then
                                .Rows(rr).Cells(5).Value = CDec(Me.dgRPproBarcode.Rows(dis).Cells(5).Value) / CDec(Me.dgRPproBarcode.Rows(dis).Cells(3).Value)
                            End If
                        Next
                        .Rows(rr).Cells(7).Value = ((CDec(.Rows(rr).Cells(3).Value) * CDec(.Rows(rr).Cells(2).Value)) _
                                                    - CDec(.Rows(rr).Cells(5).Value)) - CDec(.Rows(rr).Cells(6).Value)
                        Call sumDG()
                    End With
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
                Me.txtRPsnADD.Clear()
            End If
        End If
    End Sub

    Private Sub txtRPsnADD_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRPsnADD.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtRPsnADD.Text <> Nothing Then
                Call getDataSN()
                Me.txtRPsnADD.Clear()
            End If
        End If
    End Sub

    Private Sub dgRPsendProBarcode_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgRPsendProBarcode.CellMouseClick
        If Me.dgRPsendProBarcode.Rows.Count <> 0 Then
            If e.Button = MouseButtons.Right Then
                Me.dgRPsendProBarcode.Rows(e.RowIndex).Selected = True
                Me.dgRPsendProBarcode.CurrentCell = dgRPsendProBarcode.Rows(e.RowIndex).Cells(0)
                Me.SendBCContextMenu.Show(dgRPsendProBarcode, e.Location)
                Me.SendBCContextMenu.Show(Cursor.Position)
                Me.DeclineToolStripTextBox.Clear()
                Me.DeclineToolStripTextBox.Focus()
            End If
        End If
    End Sub

    Private Sub DeclineToolStripTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles DeclineToolStripTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.DeclineToolStripTextBox.Text = Nothing Then
                Me.dgRPsendProBarcode.CurrentRow.Cells(6).Value = 0
            Else
                Me.dgRPsendProBarcode.CurrentRow.Cells(6).Value = Me.DeclineToolStripTextBox.Text
            End If
            Me.SendBCContextMenu.Hide()
            Call sumDG()
        End If
    End Sub

    Private Sub DeclineToolStripTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DeclineToolStripTextBox.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 127 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub DelRowToolStripMenu_Click(sender As Object, e As EventArgs) Handles DelRowToolStripMenu.Click
        If Me.dgRPsendProBarcode.Rows.Count <> 0 Then
            For del As Integer = 0 To Me.dgRPsendProSN.Rows.Count - 1
                If Me.dgRPsendProSN.Rows(del).Cells(1).Value = Me.dgRPsendProBarcode.SelectedCells.Item(0).Value Then
                    MessageBox.Show(Me, "รายการที่จะลบนี้ มีรายการที่เป็น SN อยู่ กรุณาลบรายการในช่อง SN", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            Next
        End If
        If Me.dgRPsendProBarcode.Rows.Count <> 0 Then
            Me.dgRPsendProBarcode.Rows.Remove(Me.dgRPsendProBarcode.SelectedRows(0))
            Call sumDG()
        End If
    End Sub

    Private Sub dgRPsendProSN_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgRPsendProSN.CellMouseClick
        If Me.dgRPsendProSN.Rows.Count <> 0 Then
            If e.Button = MouseButtons.Right Then
                Me.dgRPsendProSN.Rows(e.RowIndex).Selected = True
                Me.dgRPsendProSN.CurrentCell = dgRPsendProSN.Rows(e.RowIndex).Cells(0)
                Me.SendSNContextMenu.Show(dgRPsendProSN, e.Location)
                Me.SendSNContextMenu.Show(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub SendSNContextMenu_Click(sender As Object, e As EventArgs) Handles SendSNContextMenu.Click
        If Me.dgRPsendProSN.Rows.Count <> 0 Then
            For del As Integer = 0 To Me.dgRPsendProBarcode.Rows.Count - 1
                If Me.dgRPsendProBarcode.Rows(del).Cells(0).Value = Me.dgRPsendProSN.SelectedCells.Item(1).Value Then
                    If CDec(Me.dgRPsendProBarcode.Rows(del).Cells(3).Value) > 1 Then
                        Me.dgRPsendProBarcode.Rows(del).Cells(3).Value = CDec(Me.dgRPsendProBarcode.Rows(del).Cells(3).Value) - 1
                        For dis As Integer = 0 To Me.dgRPproBarcode.Rows.Count - 1
                            If Me.dgRPsendProBarcode.Rows(del).Cells(0).Value = Me.dgRPproBarcode.Rows(dis).Cells(0).Value Then
                                Me.dgRPsendProBarcode.Rows(del).Cells(5).Value = (CDec(Me.dgRPproBarcode.Rows(dis).Cells(5).Value) / CDec(Me.dgRPproBarcode.Rows(dis).Cells(3).Value)) * CDec(Me.dgRPsendProBarcode.Rows(del).Cells(3).Value)
                            End If
                        Next
                        Call sumDG()
                    ElseIf CDec(Me.dgRPsendProBarcode.Rows(del).Cells(3).Value) = 1 Then
                        Me.dgRPsendProBarcode.Rows.RemoveAt(del)
                        Call sumDG()
                    End If
                End If
            Next
        End If
        If Me.dgRPsendProSN.Rows.Count <> 0 Then
            Me.dgRPsendProSN.Rows.Remove(Me.dgRPsendProSN.SelectedRows(0))
            Call sumDG()
        End If
    End Sub

    Private Sub dgRPsendProBarcode_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgRPsendProBarcode.RowStateChanged
        If Me.dgRPsendProBarcode.Rows.Count <> 0 Then
            Me.btnRPsave.Enabled = True
            Me.btnRPcancel.Text = "ยกเลิก"
        Else
            Me.btnRPsave.Enabled = False
            Me.btnRPcancel.Text = "ปิด"
        End If
    End Sub

    Private Sub Clear_Form()
        Me.txtRPsale_id.Clear()
        Me.txtRPsearchSN.Clear()
        Me.txtRPcustomerID.Clear()
        Me.txtRPcustomerName.Clear()
        Me.txtRPcustomerAddress.Clear()
        Me.txtRPcustomerTel.Clear()
        Me.txtRPsaleShow_id.Clear()
        Me.txtDatetime_save.Clear()
        Me.txtEmployee.Clear()
        Me.txtCashDetail.Clear()
        Me.txtRPsnADD.Clear()
        Me.txtRPreturnNote.Clear()
        Me.txtRPsumall.Clear()
        Me.lblRPproductStatus.Text = "......."
        Me.dgRPproBarcode.Rows.Clear()
        Me.dgRPproSN.Rows.Clear()
        Me.dgRPsendProBarcode.Rows.Clear()
        Me.dgRPsendProSN.Rows.Clear()
        Me.lblBarcode.Text = "รายการสินค้า"
        Me.lblSN.Text = "รายการสินค้า SN"

        Call loadbill()

    End Sub
    Private Sub btnRPcancel_Click(sender As Object, e As EventArgs) Handles btnRPcancel.Click
        If Me.btnRPcancel.Text = "ยกเลิก" Then
            If MessageBox.Show(Me, "มีข้อมูลการคืนยังไม่ถูกบันทึกต้องการจะยกเลิก " & vbNewLine & " YES=ใช่ NO=ไม่" _
                                , "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Call Clear_Form()
            End If
        ElseIf Me.btnRPcancel.Text = "ปิด" Then
            Me.Close()
        End If
    End Sub

    Private Sub btnRPsnOK_Click(sender As Object, e As EventArgs) Handles btnRPsnOK.Click
        If Me.txtRPsnADD.Text <> Nothing Then
            Call getDataSN()
            Me.txtRPsnADD.Clear()
        End If
    End Sub

    Private Sub btnSearchSale_id_Click(sender As Object, e As EventArgs) Handles btnSearchSale_id.Click
        If Me.txtRPsale_id.Text <> Nothing Then
            Call SearchSale_id()
        End If
    End Sub

    Private Sub btnSearchSN_Click(sender As Object, e As EventArgs) Handles btnSearchSN.Click
        If Me.txtRPsearchSN.Text <> Nothing Then
            Call SearchSaleIDbySN(Me.txtRPsearchSN.Text)
            Me.txtRPsearchSN.Clear()
        End If
    End Sub
    Friend txtRPID As String
    Private Sub changStatusClaims()
        If ClaimsStatusFrm.SendMoneyClaims = True Then
            Try
                strSQL = "UPDATE claims SET datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss",
                CultureInfo.CreateSpecificCulture("en-US")) & "',status='ส่งคืนแล้ว'," _
                & "employee='" & ClaimsStatusFrm.lblEmployee.Text & "' WHERE serial_pro='" & Me.dgRPsendProSN.Rows(0).Cells(0).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Call ClaimsStatusFrm.UpdateStatusClaims()
            For Each form In My.Application.OpenForms
                If (form.name = ClaimsStatusFrm.Name) Then
                    Call ClaimsStatusFrm.getdataClaims(100, "รอคืนเงิน")
                End If
            Next
            ClaimsStatusFrm.SendMoneyClaims = False
            Me.Close()
        End If
    End Sub

    Private Sub btnRPsave_Click(sender As Object, e As EventArgs) Handles btnRPsave.Click
        If Me.dgRPsendProBarcode.RowCount = 0 Then
            MsgBox("ยังไม่มีรายการสินค้าที่จะรับคืนกรุณาทำรายการสินค้าที่ต้องการคืนด้วย", MsgBoxStyle.Information, "แจ้งเตือน")
        Else
            If Me.txtRPreturnNote.Text = "" Then
                MsgBox("กรุณาระบุสาเหตุที่คืนสินค้า", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Me.lblRPreturnNote.BackColor = Color.Orange
                Me.txtRPreturnNote.BackColor = Color.Orange
                Me.txtRPreturnNote.Focus()
            Else
                Call ALLAutonumber("ver_returns", Me.txtRP_ID.Text)
                If Me.lblRPproductStatus.Text = "ยังไม่ชำระเงิน" Then
                    txtRPID = Me.txtRP_ID.Text
                    Call saveDataReturn()
                    Call saveANDdelDataSN()
                    Call saveANDdelDataBarcode()
                    MsgBox("คืนสินค้าเรียบร้อย", MsgBoxStyle.Information, "แจ้งเตือน")
                    If MessageBox.Show(Me, "ต้องการพิมพ์ใบส่งคืนสินค้าหรือไม่", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) _
                        = Windows.Forms.DialogResult.OK Then
                        If checkPrinter() = "A4" Then
                            ReturnProductA4ReportPrintFrm.ShowDialog(Me)
                        ElseIf checkPrinter() = "A5" Then
                            ReturnProductA5ReportPrintFrm.ShowDialog(Me)
                        End If
                    End If
                    Call Clear_Form()
                    Call changStatusClaims()
                ElseIf Me.lblRPproductStatus.Text = "ชำระเงิน" Then
                    txtRPID = Me.txtRP_ID.Text
                    Call saveDataReturn()
                    Call saveANDdelDataSNcash()
                    Call saveANDdelDataBarcodecash()
                    MsgBox("คืนสินค้าเรียบร้อย", MsgBoxStyle.Information, "แจ้งเตือน")
                    If MessageBox.Show(Me, "ต้องการพิมพ์ใบส่งคืนสินค้าหรือไม่", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) _
                        = Windows.Forms.DialogResult.OK Then
                        If checkPrinter() = "A4" Then
                            ReturnProductA4ReportPrintFrm.ShowDialog(Me)
                        ElseIf checkPrinter() = "A5" Then
                            ReturnProductA5ReportPrintFrm.ShowDialog(Me)
                        End If
                    End If
                    Call Clear_Form()
                    Call changStatusClaims()
                    Me.txtRP_ID.Text = Nothing
                End If
            End If
        End If
    End Sub

    Function ForDiscount() As Decimal
        If Me.dgRPsendProBarcode.Rows.Count <> 0 Then
            Dim dis As Decimal = 0
            Try
                For d As Integer = 0 To Me.dgRPsendProBarcode.Rows.Count - 1
                    dis += CDec(Me.dgRPsendProBarcode.Rows(d).Cells(5).Value)
                Next
                Return dis.ToString("N2")
            Catch ex As Exception
                Return 0
            End Try
        Else
            Return Nothing
        End If
    End Function

    Function ForDecline() As Decimal
        If Me.dgRPsendProBarcode.Rows.Count <> 0 Then
            Dim dis As Decimal = 0
            Try
                For d As Integer = 0 To Me.dgRPsendProBarcode.Rows.Count - 1
                    dis += CDec(Me.dgRPsendProBarcode.Rows(d).Cells(6).Value)
                Next
                Return dis.ToString("N2")
            Catch ex As Exception
                Return 0
            End Try
        Else
            Return Nothing
        End If
    End Function

    'บันทึกไอดีและรายละเอียดการคืน------------------------------------------------------------------------------------------------------------------------------
    Private Sub saveDataReturn()
        'Try
        '    'insert to returnproduct_id
        '    strSQL = "INSERT INTO returnproduct_id(return_id,datetime_save)" _
        '            & "VALUES(@return_id,@datetime_save)"
        '    cmd = New MySqlCommand(strSQL, ConnectionDB)
        '    With cmd
        '        .Parameters.Add(New MySqlParameter("@return_id", Me.txtRP_ID.Text))
        '        .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"))))
        '        Call open_connection()
        '        .ExecuteNonQuery()
        '    End With
        'Catch ex As Exception
        '    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        'End Try

        Try
            'insert to returnproduct  
            strSQL = "INSERT INTO returnproduct(return_id,sale_id,fix_id,customer_id,customer_name,total_all," _
                & "total_barcode,total_sn,return_status,return_note,datetime_save,employee,discount,decline)" _
                 & "VALUES(@return_id,@sale_id,@fix_id,@customer_id,@customer_name,@total_all," _
                 & "@total_barcode,@total_sn,@return_status,@return_note,@datetime_save,@employee,@discount,@decline)"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Dim TbarCode As Integer = Me.dgRPsendProBarcode.RowCount
            Dim Tsn As Integer = Me.dgRPsendProSN.RowCount
            With cmd
                .Parameters.Add(New MySqlParameter("@return_id", Me.txtRP_ID.Text))
                .Parameters.Add(New MySqlParameter("@sale_id", Me.txtRPsaleShow_id.Text))
                .Parameters.Add(New MySqlParameter("@fix_id", fixid))
                .Parameters.Add(New MySqlParameter("@customer_id", Me.txtRPcustomerID.Text))
                .Parameters.Add(New MySqlParameter("@customer_name", Me.txtRPcustomerName.Text))
                .Parameters.Add(New MySqlParameter("@total_all", Me.txtRPsumall.Text))
                .Parameters.Add(New MySqlParameter("@total_barcode", TbarCode))
                .Parameters.Add(New MySqlParameter("@total_sn", Tsn))
                .Parameters.Add(New MySqlParameter("@return_status", Me.lblRPproductStatus.Text))
                .Parameters.Add(New MySqlParameter("@return_note", Me.txtRPreturnNote.Text))
                .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"))))
                .Parameters.Add(New MySqlParameter("@employee", Me.lblemployee.Text))
                .Parameters.Add(New MySqlParameter("@discount", ForDiscount))
                .Parameters.Add(New MySqlParameter("@decline", ForDecline))
                Call open_connection()
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    'สินค้าที่เป็นเครดิต ยังไม่จ่ายเงิน *****************************************************************************************************************************

    Private Sub saveANDdelDataSN()
            'insert to product_serial
            For SNnum As Integer = 0 To Me.dgRPsendProSN.Rows.Count - 1
                Try
                    strSQL = "INSERT INTO product_serial(code_pro,serial_pro,name_pro,date_in)" _
                                & "VALUES(@code_pro,@serial_pro,@name_pro,@date_in)"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@code_pro", Me.dgRPsendProSN.Rows(SNnum).Cells(1).Value))
                    .Parameters.Add(New MySqlParameter("@serial_pro", Me.dgRPsendProSN.Rows(SNnum).Cells(0).Value))
                    .Parameters.Add(New MySqlParameter("@name_pro", Me.dgRPsendProSN.Rows(SNnum).Cells(2).Value))
                    .Parameters.Add(New MySqlParameter("@date_in", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", _
                                                                    CultureInfo.CreateSpecificCulture("en-US"))))
                    Call open_connection()
                    .ExecuteNonQuery()
                End With
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try

                Try
                    'insert to returnproduct_serial
                strSQL = "INSERT INTO returnproduct_serial(return_id,sale_id,fix_id,customer_id,customer_name," _
                    & "code_pro,name_pro,serial_pro,datetime_save,employee)" _
                           & "VALUES(@return_id,@sale_id,@fix_id,@customer_id,@customer_name," _
                           & "@code_pro,@name_pro,@serial_pro,@datetime_save,@employee)"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@return_id", Me.txtRP_ID.Text))
                    .Parameters.Add(New MySqlParameter("@sale_id", Me.txtRPsaleShow_id.Text))
                    .Parameters.Add(New MySqlParameter("@fix_id", fixid))
                    .Parameters.Add(New MySqlParameter("@customer_id", Me.txtRPcustomerID.Text))
                    .Parameters.Add(New MySqlParameter("@customer_name", Me.txtRPcustomerName.Text))
                    .Parameters.Add(New MySqlParameter("@code_pro", Me.dgRPsendProSN.Rows(SNnum).Cells(1).Value))
                    .Parameters.Add(New MySqlParameter("@name_pro", Me.dgRPsendProSN.Rows(SNnum).Cells(2).Value))
                    .Parameters.Add(New MySqlParameter("@serial_pro", Me.dgRPsendProSN.Rows(SNnum).Cells(0).Value))
                    .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", _
                                                                            CultureInfo.CreateSpecificCulture("en-US"))))
                    .Parameters.Add(New MySqlParameter("@employee", Me.lblemployee.Text))
                    '.Parameters.Add(New MySqlParameter("@discount", Me.dgRPsendProSN.Rows(SNnum).Cells(5).Value))
                    '.Parameters.Add(New MySqlParameter("@decline", Me.dgRPsendProSN.Rows(SNnum).Cells(6).Value))
                    Call open_connection()
                    .ExecuteNonQuery()
                End With
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try

                Try
                'อัพเดท sn
                    strSQL = "DELETE FROM sale_serial WHERE serial_pro='" & Me.dgRPsendProSN.Rows(SNnum).Cells(0).Value & "' AND " _
                        & "sale_id='" & Me.txtRPsaleShow_id.Text & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            Next
    End Sub

    Private Sub saveANDdelDataBarcode()
        For BCnum As Integer = 0 To Me.dgRPsendProBarcode.Rows.Count - 1
            Try
                'get count_num from product
                strSQL = "SELECT count_num FROM product WHERE code_pro='" & Me.dgRPsendProBarcode.Rows(BCnum).Cells(0).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                Dim cnt As Decimal = CDec(Dr.Item("count_num")) + CDec(Me.dgRPsendProBarcode.Rows(BCnum).Cells(3).Value)
                'update count_num from product
                strSQL = "UPDATE product SET count_num='" & cnt & "' WHERE code_pro='" & Me.dgRPsendProBarcode.Rows(BCnum).Cells(0).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                'insert to returnproduct_barcode
                strSQL = "INSERT INTO returnproduct_barcode(return_id,sale_id,fix_id,code_pro,name_pro,unit," _
                    & "price_buy,total,employee,datetime_save,discount,decline)" _
                    & "VALUES(@return_id,@sale_id,@fix_id,@code_pro,@name_pro,@unit," _
                    & "@price_buy,@total,@employee,@datetime_save,@discount,@decline)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.Add(New MySqlParameter("@return_id", Me.txtRP_ID.Text))
                cmd.Parameters.Add(New MySqlParameter("@sale_id", Me.txtRPsaleShow_id.Text))
                cmd.Parameters.Add(New MySqlParameter("@fix_id", fixid))
                cmd.Parameters.Add(New MySqlParameter("@code_pro", Me.dgRPsendProBarcode.Rows(BCnum).Cells(0).Value))
                cmd.Parameters.Add(New MySqlParameter("@name_pro", Me.dgRPsendProBarcode.Rows(BCnum).Cells(1).Value))
                cmd.Parameters.Add(New MySqlParameter("@unit", Me.dgRPsendProBarcode.Rows(BCnum).Cells(4).Value))
                cmd.Parameters.Add(New MySqlParameter("@price_buy", Me.dgRPsendProBarcode.Rows(BCnum).Cells(2).Value))
                cmd.Parameters.Add(New MySqlParameter("@total", Me.dgRPsendProBarcode.Rows(BCnum).Cells(3).Value))
                cmd.Parameters.Add(New MySqlParameter("@employee", Me.lblemployee.Text))
                cmd.Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", _
                                                                         CultureInfo.CreateSpecificCulture("en-US"))))
                Dim dc As Decimal = Me.dgRPsendProBarcode.Rows(BCnum).Cells(5).Value
                Dim dl As Decimal = Me.dgRPsendProBarcode.Rows(BCnum).Cells(6).Value
                cmd.Parameters.Add(New MySqlParameter("@discount", dc.ToString("N2")))
                cmd.Parameters.Add(New MySqlParameter("@decline", dl.ToString("N2")))
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                'update sale_barcode กรณีคืนทั้งหมด ก็ลบบาร์โค๊ตนั้นทิ้งไปเลย ถ้าคืนไม่หมดก็ ลบ สินค้าออก จากนั้นคำนวนในฐานข้อมูล sale ในตาราง total_all ใหม่
                strSQL = "SELECT total_pro,code_pro,discount FROM sale_barcode WHERE " _
                    & "code_pro='" & Me.dgRPsendProBarcode.Rows(BCnum).Cells(0).Value & "' AND sale_id='" & Me.txtRPsaleShow_id.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                Dim TA As Decimal = Dr.Item("total_pro")
                Dim bcta As String = Dr.Item("code_pro")
                Dim disC As Decimal = Dr.Item("discount")
                Dim TTA As Decimal = TA - CDec(Me.dgRPsendProBarcode.Rows(BCnum).Cells(3).Value)
                Dim SumdisC As Decimal = disC - CDec(Me.dgRPsendProBarcode.Rows(BCnum).Cells(5).Value)
                If TTA > 0 Then
                    Try
                        'update total_pro from sale_barcode
                        strSQL = "UPDATE sale_barcode SET total_pro='" & TTA & "',return_id='" & Me.txtRP_ID.Text & "'" _
                            & ",employee='" & LoginFrm.txtLoginUsername.Text & "',discount='" & SumdisC.ToString("N2") & "'" _
                            & "WHERE " _
                            & "code_pro='" & Me.dgRPsendProBarcode.Rows(BCnum).Cells(0).Value & "' AND sale_id='" & Me.txtRPsaleShow_id.Text & "'"
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                ElseIf TTA = 0 Then
                    Try
                        'del sale_barcode
                        strSQL = "DELETE FROM sale_barcode WHERE code_pro='" & bcta & "' AND sale_id='" & Me.txtRPsaleShow_id.Text & "'"
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next
      
        'get total_all       
        Dim aSale As Decimal = Nothing
        Try
            Dim Dr1 As MySqlDataReader
            strSQL = "SELECT total_all FROM sale WHERE sale_id='" & Me.txtRPsaleShow_id.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr1 = cmd.ExecuteReader
            Dr1.Read()
            Dim total_all As Decimal = Dr1.Item("total_all")
            Dim sx As Decimal = Nothing
            For ttall As Integer = 0 To Me.dgRPsendProBarcode.Rows.Count - 1
                sx = CDec(Me.dgRPsendProBarcode.Rows(ttall).Cells(2).Value) * CDec(Me.dgRPsendProBarcode.Rows(ttall).Cells(2).Value)
            Next
            aSale = total_all - sx
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        'update and del sale
        Try
            strSQL = "UPDATE sale SET total_all= '" & aSale.ToString("N2") & "',employee='" & Me.lblemployee.Text & "',return_id='" _
                & Me.txtRP_ID.Text & "',date_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", _
                CultureInfo.CreateSpecificCulture("en-US")) & "' WHERE sale_id='" & Me.txtRPsaleShow_id.Text & "' "
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        'นับจำนวน sn(cash_sale_serial) และบาร์โค๊ต(cash_sal_barcode) ว่ามีเหลือหรือไม่ ถ้าไม่มีลบ
        Dim cidBC As Decimal = Nothing
        Dim cidSN As Decimal = Nothing
        Try
            strSQL = "SELECT COUNT(sale_id) AS SIDBC FROM sale_barcode WHERE sale_id='" & Me.txtRPsaleShow_id.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            cidBC = Dr.GetDecimal("SIDBC")
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            strSQL = "SELECT COUNT(sale_id) AS SIDSN FROM sale_serial WHERE sale_id='" & Me.txtRPsaleShow_id.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            cidSN = Dr.GetDecimal("SIDSN")
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        If cidBC = 0 And cidSN = 0 Then
            Try
                strSQL = "DELETE FROM sale WHERE sale_id='" & Me.txtRPsaleShow_id.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub

    '  สิค้าที่เป็นเงินสด จ่ายเงินแล้ว *****************************************************************************************************************************
    Private Sub saveANDdelDataSNcash()
        'insert to product_serial
        For SNnum As Integer = 0 To Me.dgRPsendProSN.Rows.Count - 1
            Try
                strSQL = "INSERT INTO product_serial(code_pro,serial_pro,name_pro,date_in)" _
                            & "VALUES(@code_pro,@serial_pro,@name_pro,@date_in)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@code_pro", Me.dgRPsendProSN.Rows(SNnum).Cells(1).Value))
                    .Parameters.Add(New MySqlParameter("@serial_pro", Me.dgRPsendProSN.Rows(SNnum).Cells(0).Value))
                    .Parameters.Add(New MySqlParameter("@name_pro", Me.dgRPsendProSN.Rows(SNnum).Cells(2).Value))
                    .Parameters.Add(New MySqlParameter("@date_in", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", _
                                                                    CultureInfo.CreateSpecificCulture("en-US"))))
                    Call open_connection()
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                'insert to returnproduct_serial
                strSQL = "INSERT INTO returnproduct_serial(return_id,sale_id,fix_id,customer_id,customer_name," _
                    & "code_pro,name_pro,serial_pro,datetime_save,employee)" _
                           & "VALUES(@return_id,@sale_id,@fix_id,@customer_id,@customer_name," _
                           & "@code_pro,@name_pro,@serial_pro,@datetime_save,@employee)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@return_id", Me.txtRP_ID.Text))
                    .Parameters.Add(New MySqlParameter("@sale_id", Me.txtRPsaleShow_id.Text))
                    .Parameters.Add(New MySqlParameter("@fix_id", fixid))
                    .Parameters.Add(New MySqlParameter("@customer_id", Me.txtRPcustomerID.Text))
                    .Parameters.Add(New MySqlParameter("@customer_name", Me.txtRPcustomerName.Text))
                    .Parameters.Add(New MySqlParameter("@code_pro", Me.dgRPsendProSN.Rows(SNnum).Cells(1).Value))
                    .Parameters.Add(New MySqlParameter("@name_pro", Me.dgRPsendProSN.Rows(SNnum).Cells(2).Value))
                    .Parameters.Add(New MySqlParameter("@serial_pro", Me.dgRPsendProSN.Rows(SNnum).Cells(0).Value))
                    .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", _
                                                                            CultureInfo.CreateSpecificCulture("en-US"))))
                    .Parameters.Add(New MySqlParameter("@employee", Me.lblemployee.Text))
                    '.Parameters.Add(New MySqlParameter("@discount", Me.dgRPsendProSN.Rows(SNnum).Cells(5).Value))
                    '.Parameters.Add(New MySqlParameter("@decline", Me.dgRPsendProSN.Rows(SNnum).Cells(6).Value))
                    Call open_connection()
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                'ลบ sn
                strSQL = "DELETE FROM cash_sale_serial WHERE " _
                    & "serial_pro='" & Me.dgRPsendProSN.Rows(SNnum).Cells(0).Value & "' AND sale_id='" & Me.txtRPsaleShow_id.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next
    End Sub
    Private Sub saveANDdelDataBarcodecash()
            For BCnum As Integer = 0 To Me.dgRPsendProBarcode.Rows.Count - 1
            Try
                'get count_num from product
                strSQL = "SELECT count_num FROM product WHERE code_pro='" & Me.dgRPsendProBarcode.Rows(BCnum).Cells(0).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                Dim cn As Integer = Dr.Item("count_num")
                Dim cnt As Integer = cn + CInt(Me.dgRPsendProBarcode.Rows(BCnum).Cells(3).Value)
                'update count_num from product
                strSQL = "UPDATE product SET count_num='" & cnt & "' WHERE code_pro='" & Me.dgRPsendProBarcode.Rows(BCnum).Cells(0).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                'insert to returnproduct_barcode
                strSQL = "INSERT INTO returnproduct_barcode(return_id,sale_id,fix_id,code_pro,name_pro,unit," _
                    & "price_buy,total,employee,datetime_save,discount,decline)" _
                    & "VALUES(@return_id,@sale_id,@fix_id,@code_pro,@name_pro,@unit," _
                    & "@price_buy,@total,@employee,@datetime_save,@discount,@decline)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.Add(New MySqlParameter("@return_id", Me.txtRP_ID.Text))
                cmd.Parameters.Add(New MySqlParameter("@sale_id", Me.txtRPsaleShow_id.Text))
                cmd.Parameters.Add(New MySqlParameter("@fix_id", fixid))
                cmd.Parameters.Add(New MySqlParameter("@code_pro", Me.dgRPsendProBarcode.Rows(BCnum).Cells(0).Value))
                cmd.Parameters.Add(New MySqlParameter("@name_pro", Me.dgRPsendProBarcode.Rows(BCnum).Cells(1).Value))
                cmd.Parameters.Add(New MySqlParameter("@unit", Me.dgRPsendProBarcode.Rows(BCnum).Cells(4).Value))
                cmd.Parameters.Add(New MySqlParameter("@price_buy", Me.dgRPsendProBarcode.Rows(BCnum).Cells(2).Value))
                cmd.Parameters.Add(New MySqlParameter("@total", Me.dgRPsendProBarcode.Rows(BCnum).Cells(3).Value))
                cmd.Parameters.Add(New MySqlParameter("@employee", Me.lblemployee.Text))
                cmd.Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", _
                                                                         CultureInfo.CreateSpecificCulture("en-US"))))
                Dim dc As Decimal = Me.dgRPsendProBarcode.Rows(BCnum).Cells(5).Value
                Dim dl As Decimal = Me.dgRPsendProBarcode.Rows(BCnum).Cells(6).Value
                cmd.Parameters.Add(New MySqlParameter("@discount", dc.ToString("N2")))
                cmd.Parameters.Add(New MySqlParameter("@decline", dl.ToString("N2")))
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

                'update sale_barcode กรณีคืนทั้งหมด ก็ลบบาร์โค๊ตนั้นทิ้งไปเลย ถ้าคืนไม่หมดก็ ลบ สินค้าออก จากนั้นคำนวนในฐานข้อมูล sale ในตาราง total_all ใหม่
            Try
                strSQL = "SELECT total_pro,code_pro,discount FROM " _
                    & "cash_sale_barcode WHERE code_pro='" & Me.dgRPsendProBarcode.Rows(BCnum).Cells(0).Value & "' AND " _
                    & "sale_id='" & Me.txtRPsaleShow_id.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                Dim TA As Decimal = Dr.Item("total_pro")
                Dim bcta As String = Dr.Item("code_pro")
                Dim disC As Decimal = Dr.Item("discount")
                Dim TTA As Decimal = TA - CDec(Me.dgRPsendProBarcode.Rows(BCnum).Cells(3).Value)
                Dim SumdisC As Decimal = disC - CDec(Me.dgRPsendProBarcode.Rows(BCnum).Cells(5).Value)
                If TTA > 0 Then
                    Try
                        'update total_pro from sale_barcode
                        strSQL = "UPDATE cash_sale_barcode SET total_pro='" & TTA & "',return_id='" & Me.txtRP_ID.Text & "'" _
                            & ",employee='" & Me.lblemployee.Text & "',discount='" & SumdisC.ToString("N2") & "' WHERE " _
                            & "code_pro='" & Me.dgRPsendProBarcode.Rows(BCnum).Cells(0).Value & "' AND sale_id='" & Me.txtRPsaleShow_id.Text & "'"
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                ElseIf TTA = 0 Then
                    Try
                        'del sale_barcode
                        strSQL = "DELETE FROM cash_sale_barcode WHERE code_pro='" & bcta & "' AND sale_id='" & Me.txtRPsaleShow_id.Text & "'"
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next
    
        'get total_all *************************************  แก้ไข 20160110
        Dim a As Decimal = Nothing
        Try
            Dim Dr1 As MySqlDataReader
            strSQL = "SELECT total_all FROM cash_sale WHERE sale_id='" & Me.txtRPsaleShow_id.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr1 = cmd.ExecuteReader
            Dr1.Read()
            Dim total_all As Decimal = Dr1.Item("total_all")
            a = total_all - CDec(Me.txtRPsumall.Text)
            Dim sx As Decimal = Nothing
            For ttall As Integer = 0 To Me.dgRPsendProBarcode.Rows.Count - 1
                sx = CDec(Me.dgRPsendProBarcode.Rows(ttall).Cells(2).Value) * CDec(Me.dgRPsendProBarcode.Rows(ttall).Cells(2).Value)
            Next
            a = total_all - sx
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        'update and del sale
        Try
            strSQL = "UPDATE cash_sale SET total_all= '" & a.ToString("N2") & "',employee='" & Me.lblemployee.Text & "'," _
                & "return_id='" & Me.txtRP_ID.Text & "',date_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", _
                                            CultureInfo.CreateSpecificCulture("en-US")) & "' WHERE sale_id='" & Me.txtRPsaleShow_id.Text & "' "
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        'นับจำนวน sn(cash_sale_serial) และบาร์โค๊ต(cash_sal_barcode) ว่ามีเหลือหรือไม่ ถ้าไม่มีลบ
        Dim cidBC As Decimal = Nothing
        Dim cidSN As Decimal = Nothing
        Try
            strSQL = "SELECT COUNT(sale_id) AS SIDBC FROM cash_sale_barcode WHERE sale_id='" & Me.txtRPsaleShow_id.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            cidBC = Dr.GetDecimal("SIDBC")
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Try
            strSQL = "SELECT COUNT(sale_id) AS SIDSN FROM cash_sale_serial WHERE sale_id='" & Me.txtRPsaleShow_id.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            cidSN = Dr.GetDecimal("SIDSN")
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        If cidBC = 0 And cidSN = 0 Then
            Try
                strSQL = "DELETE FROM cash_sale WHERE sale_id='" & Me.txtRPsaleShow_id.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/sales/returnsproductfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class