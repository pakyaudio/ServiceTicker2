Imports MySql.Data.MySqlClient
Imports System.Text

Public Class RepairHistoryFrm
    Dim search As Integer
    Friend Sub getDataComfix()
        Try
            'ค้นหาข้อมูล comfix
            Me.txtRHcustometDetail.Clear()
            Me.dgRHbycusID.Rows.Clear()
            strSQL = "SELECT fix_id,date_save,customer_id,sn,symptom,managerdata," _
                & "fixrepairnote,fixaccessory,varuntee,user_repair,teltocus,date_send,datecom_repair,importune FROM comfix " _
                & "WHERE customer_id='" & Me.txtRHsearchCusID.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                Dim r As Integer
                While Dr.Read
                    With Me.dgRHbycusID
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(0).Value = r + 1
                        .Rows(r).Cells(1).Value = Dr.Item("customer_id")
                        .Rows(r).Cells(2).Value = Dr.Item("fix_id")
                        .Rows(r).Cells(3).Value = Dr.Item("sn")
                        .Rows(r).Cells(4).Value = Dr.Item("symptom")
                        .Rows(r).Cells(5).Value = Dr.Item("fixrepairnote")
                        .Rows(r).Cells(6).Value = Dr.Item("managerdata")
                        .Rows(r).Cells(7).Value = Dr.Item("fixaccessory")
                        .Rows(r).Cells(8).Value = Dr.Item("varuntee")
                        .Rows(r).Cells(9).Value = Dr.Item("user_repair")
                        .Rows(r).Cells(10).Value = Dr.Item("date_save")
                        .Rows(r).Cells(11).Value = Dr.Item("datecom_repair")
                        .Rows(r).Cells(12).Value = Dr.Item("date_send")
                        .Rows(r).Cells(13).Value = Dr.Item("importune")
                    End With
                End While
            Else
                MessageBox.Show(Me, "ไม่พบข้อมูล", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'ค้นหาข้อมูล SN
            Me.dgRHbySN.Rows.Clear()
            For SSn As Integer = 0 To Me.dgRHbycusID.Rows.Count - 1
                strSQL = "SELECT Snum,p_type,p_name,model,color,startdate FROM sn WHERE Snum='" & Me.dgRHbycusID.Rows(SSn).Cells(3).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                Dim rSN As Integer = Me.dgRHbySN.Rows.Count
                With Me.dgRHbySN
                    rSN = .Rows.Add
                    .Rows(rSN).Cells(0).Value = rSN + 1
                    .Rows(rSN).Cells(1).Value = Dr.Item("Snum")
                    .Rows(rSN).Cells(2).Value = Dr.Item("p_type")
                    .Rows(rSN).Cells(3).Value = Dr.Item("p_name")
                    .Rows(rSN).Cells(4).Value = Dr.Item("model")
                    .Rows(rSN).Cells(5).Value = Dr.Item("color")
                    .Rows(rSN).Cells(6).Value = Dr.Item("startdate")
                End With
            Next
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'ค้นหาข้อมูล รายการอะไหล่ชำระเงิน
            Me.dgRHProPathCash.Rows.Clear()
            strSQL = "SELECT sale_id,code_pro,bar_code,name_pro,total_pro,unit,price_buy,datetime_save FROM cash_sale_barcode " _
                & "WHERE customer_id='" & Me.txtRHsearchCusID.Text & "' AND NOT(fix_id='" & "ขายสินค้า" & "')"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dim r As Integer
            While Dr.Read
                With Me.dgRHProPathCash
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = r + 1
                    .Rows(r).Cells(1).Value = Dr.Item("sale_id")
                    .Rows(r).Cells(2).Value = Dr.Item("code_pro")
                    .Rows(r).Cells(3).Value = Dr.Item("bar_code")
                    .Rows(r).Cells(4).Value = Dr.Item("name_pro")
                    .Rows(r).Cells(5).Value = Dr.Item("total_pro")
                    .Rows(r).Cells(6).Value = Dr.Item("unit")
                    .Rows(r).Cells(7).Value = Dr.Item("price_buy")
                    .Rows(r).Cells(8).Value = Dr.Item("datetime_save")

                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'ค้นหาข้อมูล รายการอะไหล่ยังไม่ชำระเงิน
            Me.dgRHproPathSales.Rows.Clear()
            strSQL = "SELECT sale_id,code_pro,bar_code,name_pro,total_pro,unit,price_buy,datetime_save FROM sale_barcode " _
                & "WHERE customer_id='" & Me.txtRHsearchCusID.Text & "' AND NOT(fix_id='" & "ขายสินค้า" & "')"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dim r As Integer
            While Dr.Read
                With Me.dgRHproPathSales
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = r + 1
                    .Rows(r).Cells(1).Value = Dr.Item("sale_id")
                    .Rows(r).Cells(2).Value = Dr.Item("code_pro")
                    .Rows(r).Cells(3).Value = Dr.Item("bar_code")
                    .Rows(r).Cells(4).Value = Dr.Item("name_pro")
                    .Rows(r).Cells(5).Value = Dr.Item("total_pro")
                    .Rows(r).Cells(6).Value = Dr.Item("unit")
                    .Rows(r).Cells(7).Value = Dr.Item("price_buy")
                    .Rows(r).Cells(8).Value = Dr.Item("datetime_save")

                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'ค้นหาข้อมูล รายการขายที่ชำระเงิน
            Me.dgRHsalePath.Rows.Clear()
            strSQL = "SELECT sale_id,code_pro,bar_code,name_pro,total_pro,unit,price_buy,datetime_save FROM cash_sale_barcode " _
                & "WHERE customer_id='" & Me.txtRHsearchCusID.Text & "' AND fix_id='" & "ขายสินค้า" & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dim r As Integer
            While Dr.Read
                With Me.dgRHsalePath
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = r + 1
                    .Rows(r).Cells(1).Value = Dr.Item("sale_id")
                    .Rows(r).Cells(2).Value = Dr.Item("code_pro")
                    .Rows(r).Cells(3).Value = Dr.Item("bar_code")
                    .Rows(r).Cells(4).Value = Dr.Item("name_pro")
                    .Rows(r).Cells(5).Value = Dr.Item("total_pro")
                    .Rows(r).Cells(6).Value = Dr.Item("unit")
                    .Rows(r).Cells(7).Value = Dr.Item("price_buy")
                    .Rows(r).Cells(8).Value = Dr.Item("datetime_save")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'ค้นหาข้อมูล รายการขายที่ยังไม่ชำระเงิน
            Me.gRHsaleSales.Rows.Clear()
            strSQL = "SELECT sale_id,code_pro,bar_code,name_pro,total_pro,unit,price_buy,datetime_save FROM sale_barcode " _
                & "WHERE customer_id='" & Me.txtRHsearchCusID.Text & "' AND fix_id='" & "ขายสินค้า" & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dim r As Integer
            While Dr.Read
                With Me.gRHsaleSales
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = r + 1
                    .Rows(r).Cells(1).Value = Dr.Item("sale_id")
                    .Rows(r).Cells(2).Value = Dr.Item("code_pro")
                    .Rows(r).Cells(3).Value = Dr.Item("bar_code")
                    .Rows(r).Cells(4).Value = Dr.Item("name_pro")
                    .Rows(r).Cells(5).Value = Dr.Item("total_pro")
                    .Rows(r).Cells(6).Value = Dr.Item("unit")
                    .Rows(r).Cells(7).Value = Dr.Item("price_buy")
                    .Rows(r).Cells(8).Value = Dr.Item("datetime_save")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        'คืนสินค้างานซ่อม-------------------------------------------------------------------------------------------------------------------------------
        Try
            'ค้นหาข้อมูล รายการคืนสินค้า
            Me.dgRHreturnPro.Rows.Clear()
            strSQL = "SELECT return_id,sale_id,total_all,total_barcode,total_sn,return_status,return_note,datetime_save,employee FROM returnproduct " _
                & "WHERE customer_id='" & Me.txtRHsearchCusID.Text & "' AND NOT(fix_id='" & "ขายสินค้า" & "')"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dim r As Integer
            While Dr.Read
                With Me.dgRHreturnPro
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = r + 1
                    .Rows(r).Cells(1).Value = Dr.Item("sale_id")
                    .Rows(r).Cells(2).Value = Dr.Item("return_id")
                    .Rows(r).Cells(6).Value = Dr.Item("total_barcode")
                    .Rows(r).Cells(7).Value = Dr.Item("total_sn")
                    .Rows(r).Cells(8).Value = Dr.Item("total_all")
                    .Rows(r).Cells(9).Value = Dr.Item("return_note")
                    .Rows(r).Cells(10).Value = Dr.Item("return_status")
                    .Rows(r).Cells(11).Value = Dr.Item("datetime_save")
                    .Rows(r).Cells(12).Value = Dr.Item("employee")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'ค้นหาข้อมูล ชื่อสินค้า รหัสสินค้า
            For cp As Integer = 0 To Me.dgRHreturnPro.Rows.Count - 1
                strSQL = "SELECT code_pro,name_pro FROM returnproduct_barcode " _
                    & "WHERE return_id='" & Me.dgRHreturnPro.Rows(cp).Cells(2).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader

                While Dr.Read
                    With Me.dgRHreturnPro
                        .Rows(cp).Cells(3).Value = Dr.Item("code_pro")
                        .Rows(cp).Cells(5).Value = Dr.Item("name_pro")
                    End With
                End While
            Next
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'ค้นหาข้อมูล บาร์โค๊ต
            For bc As Integer = 0 To Me.dgRHreturnPro.Rows.Count - 1
                strSQL = "SELECT bar_code FROM product " _
                    & "WHERE code_pro='" & Me.dgRHreturnPro.Rows(bc).Cells(3).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                While Dr.Read
                    With Me.dgRHreturnPro
                        .Rows(bc).Cells(4).Value = Dr.Item("bar_code")
                    End With
                End While
            Next
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        'คืนสินค้างานขาย-------------------------------------------------------------------------------------------------------------------------------
        Try
            'ค้นหาข้อมูล รายการคืนสินค้า
            Me.dgRHreturnProSale.Rows.Clear()
            strSQL = "SELECT return_id,sale_id,total_all,total_barcode,total_sn,return_status,return_note,datetime_save,employee FROM returnproduct " _
                & "WHERE customer_id='" & Me.txtRHsearchCusID.Text & "' AND fix_id='" & "ขายสินค้า" & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dim r As Integer
            While Dr.Read
                With Me.dgRHreturnProSale
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = r + 1
                    .Rows(r).Cells(1).Value = Dr.Item("sale_id")
                    .Rows(r).Cells(2).Value = Dr.Item("return_id")
                    .Rows(r).Cells(6).Value = Dr.Item("total_barcode")
                    .Rows(r).Cells(7).Value = Dr.Item("total_sn")
                    .Rows(r).Cells(8).Value = Dr.Item("total_all")
                    .Rows(r).Cells(9).Value = Dr.Item("return_note")
                    .Rows(r).Cells(10).Value = Dr.Item("return_status")
                    .Rows(r).Cells(11).Value = Dr.Item("datetime_save")
                    .Rows(r).Cells(12).Value = Dr.Item("employee")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'ค้นหาข้อมูล ชื่อสินค้า รหัสสินค้า
            For cp As Integer = 0 To Me.dgRHreturnProSale.Rows.Count - 1
                strSQL = "SELECT code_pro,name_pro FROM returnproduct_barcode " _
                    & "WHERE return_id='" & Me.dgRHreturnProSale.Rows(cp).Cells(2).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                While Dr.Read
                    With Me.dgRHreturnProSale
                        .Rows(cp).Cells(3).Value = Dr.Item("code_pro")
                        .Rows(cp).Cells(5).Value = Dr.Item("name_pro")
                    End With
                End While
            Next
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'ค้นหาข้อมูล บาร์โค๊ต
            For bc As Integer = 0 To Me.dgRHreturnProSale.Rows.Count - 1
                strSQL = "SELECT bar_code FROM product " _
                    & "WHERE code_pro='" & Me.dgRHreturnProSale.Rows(bc).Cells(3).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                While Dr.Read
                    With Me.dgRHreturnProSale
                        .Rows(bc).Cells(4).Value = Dr.Item("bar_code")
                    End With
                End While
            Next
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        'ดึงรายละเอียดทั้งหมด
        Try
            strSQL = "SELECT customer_id,customer_name,customer_address,customer_tel FROM customer " _
                   & "WHERE customer_id='" & Me.txtRHsearchCusID.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Me.txtRHcustometDetail.Text = Dr.Item("customer_id") & " ชื่อ " & Dr.Item("customer_name") & " ที่อยู่ " & Dr.Item("customer_address") & " โทรศัพท์ " & Dr.Item("customer_tel")
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

    End Sub

    Friend Sub sumDetail()
        Try
            'หาจำนวนครั้งที่มาซ่อม
            strSQL = "SELECT COUNT(customer_id) AS CID FROM comfix " _
                           & "WHERE customer_id='" & Me.txtRHsearchCusID.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Me.txtRHsumComfix.Text = Dr.Item("CID")
            Else
                Me.txtRHsumComfix.Text = "0"
            End If
        Catch ex As Exception
            Me.txtRHsumComfix.Text = "0"
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'หาจำนวนครั้ง SN
            Dim ColList As New List(Of String)
            Dim numDistinct As Integer = 0

            For Each MyRow As DataGridViewRow In dgRHbySN.Rows
                ColList.Add(MyRow.Cells(1).Value)
            Next

            numDistinct = ColList.Distinct.Count
            Me.txtRHsumSN.Text = numDistinct
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'บวกข้อมูล รายการอะไหล่ยังไม่ชำระเงิน
            strSQL = "SELECT SUM(price_buy) AS PB,SUM(total_pro) AS TP FROM sale_barcode " _
                & "WHERE customer_id='" & Me.txtRHsearchCusID.Text & "' AND NOT(fix_id='" & "ขายสินค้า" & "')"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Me.txtRHsalePro.Text = Dr.GetDecimal("TP")
                Me.txtRHsalePrice.Text = Dr.GetDecimal("PB").ToString("N2")
            Else
                Me.txtRHsalePro.Text = "0"
                Me.txtRHsalePrice.Text = "0"
            End If
        Catch ex As Exception
            Me.txtRHsalePro.Text = "0"
            Me.txtRHsalePrice.Text = "0"
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'บวกข้อมูล รายการอะไหล่ชำระเงินแล้ว
            strSQL = "SELECT SUM(price_buy) AS PB,SUM(total_pro) AS TP FROM cash_sale_barcode " _
                & "WHERE customer_id='" & Me.txtRHsearchCusID.Text & "' AND NOT(fix_id='" & "ขายสินค้า" & "')"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Me.txtRHcashtotlaPro.Text = Dr.GetDecimal("TP")
                Me.txtRHcashPrice_buy.Text = Dr.GetDecimal("PB").ToString("N2")
            Else
                Me.txtRHcashtotlaPro.Text = "0"
                Me.txtRHcashPrice_buy.Text = "0"
            End If
        Catch ex As Exception
            Me.txtRHcashtotlaPro.Text = "0"
            Me.txtRHcashPrice_buy.Text = "0"
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try



        Try
            'ค้นหาข้อมูล รายการขายที่ชำระเงิน
            strSQL = "SELECT SUM(price_buy) AS PB,SUM(total_pro) AS TP FROM cash_sale_barcode " _
                & "WHERE customer_id='" & Me.txtRHsearchCusID.Text & "' AND fix_id='" & "ขายสินค้า" & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Me.txtRHcashSaleSalePro.Text = Dr.GetDecimal("TP")
                Me.txtRHcashSaleSalePrice.Text = Dr.GetDecimal("PB").ToString("N2")
            Else
                Me.txtRHcashSaleSalePro.Text = "0"
                Me.txtRHcashSaleSalePrice.Text = "0"
            End If
        Catch ex As Exception
            Me.txtRHcashSaleSalePro.Text = "0"
            Me.txtRHcashSaleSalePrice.Text = "0"
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'ค้นหาข้อมูล รายการขายที่ยังไม่ชำระเงิน
            strSQL = "SELECT SUM(price_buy) AS PB,SUM(total_pro) AS TP FROM sale_barcode " _
                & "WHERE customer_id='" & Me.txtRHsearchCusID.Text & "' AND fix_id='" & "ขายสินค้า" & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Me.txtRHsaleSalePro.Text = Dr.GetDecimal("TP")
                Me.txtRHsaleSalePrice.Text = Dr.GetDecimal("PB").ToString("N2")
            Else
                Me.txtRHsaleSalePro.Text = "0"
                Me.txtRHsaleSalePrice.Text = "0"
            End If
        Catch ex As Exception
            Me.txtRHsaleSalePro.Text = "0"
            Me.txtRHsaleSalePrice.Text = "0"
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'ค้นหาข้อมูล คืนสินค้ารวม
            strSQL = "SELECT SUM(total_all) AS TA,SUM(total_barcode) AS TB,SUM(total_sn) AS TS FROM returnproduct " _
                & "WHERE customer_id='" & Me.txtRHsearchCusID.Text & "';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Dim TBPb, TBPsn As Decimal
            If Dr.HasRows Then
                TBPb = Dr.GetDecimal("TB")
                TBPsn = Dr.GetDecimal("TS")
                Me.txtRHreturnPro.Text = TBPb + TBPsn
                Me.txtRHreturnPrice.Text = Dr.GetDecimal("TA").ToString("N2")
            Else
                Me.txtRHreturnPrice.Text = "0"
                Me.txtRHreturnPro.Text = "0"
            End If
        Catch ex As Exception
            Me.txtRHreturnPrice.Text = "0"
            Me.txtRHreturnPro.Text = "0"
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        If Me.txtRHsaleSalePro.Text = "" Then
            Me.txtRHsaleSalePro.Text = 0
        End If
        If Me.txtRHsaleSalePrice.Text = "" Then
            Me.txtRHsaleSalePrice.Text = 0
        End If
        If Me.txtRHcashtotlaPro.Text = "" Then
            Me.txtRHcashtotlaPro.Text = 0
        End If
        If Me.txtRHcashPrice_buy.Text = "" Then
            Me.txtRHcashPrice_buy.Text = 0
        End If
        If Me.txtRHsaleSalePro.Text = "" Then
            Me.txtRHsaleSalePro.Text = 0
        End If
        If Me.txtRHsaleSalePrice.Text = "" Then
            Me.txtRHsaleSalePrice.Text = 0
        End If
        If Me.txtRHcashSaleSalePro.Text = "" Then
            Me.txtRHcashSaleSalePro.Text = 0
        End If
        If Me.txtRHcashSaleSalePrice.Text = "" Then
            Me.txtRHcashSaleSalePrice.Text = 0
        End If
        If Me.txtRHpathPro.Text = "" Then
            Me.txtRHpathPro.Text = 0
        End If
        If Me.txtRHsalpro.Text = "" Then
            Me.txtRHsalpro.Text = 0
        End If
        If Me.txtRHpathPrice.Text = "" Then
            Me.txtRHpathPrice.Text = 0
        End If
        If Me.txtRHsalePrice_buy.Text = "" Then
            Me.txtRHsalePrice_buy.Text = 0
        End If
        Try
            'รวมรายการอะไหล่ ราคาด้วย
            Me.txtRHpathPro.Text = CDec(Me.txtRHsalePro.Text) + CDec(Me.txtRHcashtotlaPro.Text)
            Me.txtRHpathPrice.Text = CDec(Me.txtRHsalePrice.Text) + CDec(Me.txtRHcashPrice_buy.Text)
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Try
            'รวมรายการขาย ราคาด้วย
            Me.txtRHsalpro.Text = CDec(Me.txtRHcashSaleSalePro.Text) + CDec(Me.txtRHsaleSalePro.Text)
            Me.txtRHsalePrice_buy.Text = CDec(Me.txtRHcashSaleSalePrice.Text) + CDec(Me.txtRHsaleSalePrice.Text)
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            Me.txtRHttPro.Text = CDec(Me.txtRHpathPro.Text) + CDec(Me.txtRHsalpro.Text)
            Me.txtRHttPrice.Text = CDec(Me.txtRHpathPrice.Text) + CDec(Me.txtRHsalePrice_buy.Text)
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Call TabCount()
    End Sub
    Friend Sub TabCount()
        Me.TabPage1.Text = "รายการอะไหล่(ชำระเงิน) (" & Me.dgRHProPathCash.RowCount & ")"
        Me.TabPage2.Text = "รายการอะไหล่(ยังไม่ชำระเงิน) (" & Me.dgRHproPathSales.RowCount & ")"
        Me.TabPage3.Text = "รายการขาย(ชำระเงิน) (" & Me.dgRHsalePath.RowCount & ")"
        Me.TabPage4.Text = "รายการขาย(ยังไม่ชำระเงิน) (" & Me.gRHsaleSales.RowCount & ")"
        Me.TabPage5.Text = "รายการคืนสินค้างานซ่อม (" & Me.dgRHreturnPro.RowCount & ")"
        Me.TabPage6.Text = "รายการคืนสินค้างานขาย (" & Me.dgRHreturnProSale.RowCount & ")"
    End Sub

    Private Sub RepairHistoryFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub RepairHistoryFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Private Sub txtRHsearchCusID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRHsearchCusID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtRHsearchCusID.Text = Nothing Then
                Me.txtRHsearchCusID.Focus()
                MsgBox("กรุณาใส่รหัสลูกค้า", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            Else
                Call getDataComfix()
                Call sumDetail()
                Me.txtRHsearchCusID.Clear()
                Call TabCount()
            End If
        End If
    End Sub

    Private Sub btnRHsearchCusid_Click(sender As Object, e As EventArgs) Handles btnRHsearchCusid.Click
        SearchCustomerRHFrm.ShowDialog(Me)
    End Sub
    Dim oldData As Object
    '--------------------------
    Private Sub dgRHbycusID_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRHbycusID.CellDoubleClick
        oldData = Me.dgRHbycusID.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub

    Private Sub dgRHbycusID_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgRHbycusID.CellEndEdit
        Me.dgRHbycusID.CurrentRow.Cells(e.ColumnIndex).Value = oldData
    End Sub
    '--------------------------
    '--------------------------
    Private Sub dgRHbySN_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRHbySN.CellDoubleClick
        oldData = Me.dgRHbySN.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub

    Private Sub dgRHbySN_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgRHbySN.CellEndEdit
        Me.dgRHbySN.CurrentRow.Cells(e.ColumnIndex).Value = oldData
    End Sub
    '--------------------------
    '--------------------------
    Private Sub dgRHProPathCash_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRHProPathCash.CellDoubleClick
        oldData = Me.dgRHProPathCash.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub

    Private Sub dgRHProPathCash_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgRHProPathCash.CellEndEdit
        Me.dgRHProPathCash.CurrentRow.Cells(e.ColumnIndex).Value = oldData
    End Sub
    '--------------------------
    '--------------------------
    Private Sub dgRHproPathSales_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRHproPathSales.CellDoubleClick
        oldData = Me.dgRHproPathSales.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub

    Private Sub dgRHproPathSales_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgRHproPathSales.CellEndEdit
        Me.dgRHproPathSales.CurrentRow.Cells(e.ColumnIndex).Value = oldData
    End Sub
    '--------------------------
    '--------------------------
    Private Sub dgRHsalePath_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRHsalePath.CellDoubleClick
        oldData = Me.dgRHsalePath.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub

    Private Sub dgRHsalePath_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgRHsalePath.CellEndEdit
        Me.dgRHsalePath.CurrentRow.Cells(e.ColumnIndex).Value = oldData
    End Sub
    '--------------------------
    '--------------------------
    Private Sub gRHsaleSales_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gRHsaleSales.CellDoubleClick
        oldData = Me.gRHsaleSales.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub

    Private Sub gRHsaleSales_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles gRHsaleSales.CellEndEdit
        Me.gRHsaleSales.CurrentRow.Cells(e.ColumnIndex).Value = oldData
    End Sub
    '--------------------------
    '--------------------------
    Private Sub dgRHreturnPro_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRHreturnPro.CellDoubleClick
        oldData = Me.dgRHreturnPro.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub

    Private Sub dgRHreturnPro_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgRHreturnPro.CellEndEdit
        Me.dgRHreturnPro.CurrentRow.Cells(e.ColumnIndex).Value = oldData
    End Sub
    '--------------------------
    '--------------------------
    Private Sub dgRHreturnProSale_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRHreturnProSale.CellDoubleClick
        oldData = Me.dgRHreturnProSale.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub

    Private Sub dgRHreturnProSale_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgRHreturnProSale.CellEndEdit
        Me.dgRHreturnProSale.CurrentRow.Cells(e.ColumnIndex).Value = oldData
    End Sub
    '--------------------------

    Private Sub btnHelp_Click_1(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/comfix/comfixreportmenu/repairhistoryfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class