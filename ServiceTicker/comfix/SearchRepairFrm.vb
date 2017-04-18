Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Globalization

Public Class SearchRepairFrm
    Private Sub cbbAdd()
        Me.cbbSRsearchAll.Items.Add("1 รอซ่อม")
        Me.cbbSRsearchAll.Items.Add("2 กำลังซ่อม")
        Me.cbbSRsearchAll.Items.Add("3 รออะไหล่/ส่งเคลม")
        Me.cbbSRsearchAll.Items.Add("4 ซ่อมไม่ได้")
        Me.cbbSRsearchAll.Items.Add("5 ซ่อมเสร็จ")
        Me.cbbSRsearchAll.Items.Add("6 ยกเลิกซ่อม")
        Me.cbbSRsearchAll.Items.Add("7 คืนเครื่องแล้ว")
    End Sub

    Private Sub SearchRepairFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub SearchRepairFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call cbbAdd()
        Call AddRows()
    End Sub

    Private Sub AddRows()
        For arows As Integer = 0 To 13
            Me.dgSRdetail.Rows.Add()
        Next
        With Me.dgSRdetail
            .Rows(0).Cells(0).Value = "รายละเอียดลูกค้า"
            .Rows(0).DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .Rows(1).Cells(0).Value = "รายละเอียดสินค้า"
            .Rows(1).DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .Rows(2).Cells(0).Value = "รายละเอียดการรับซ่อม"
            .Rows(2).DefaultCellStyle.WrapMode = DataGridViewTriState.True

            .Rows(3).Cells(0).Value = "รายละเอียดสินค้าที่เบิก"
            .Rows(3).Cells(0).Style.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

            .Rows(3).Cells(1).Value = "สถานะ"
            .Rows(3).Cells(1).Style.Alignment = DataGridViewContentAlignment.MiddleRight

            .Rows(4).Cells(0).Value = "รายการใบเบิกที่ยังไม่ได้ชำระเงินจำนวน"
            .Rows(4).Cells(1).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Rows(4).Cells(2).Value = "รายการ"

            .Rows(5).Cells(0).Value = "รวมราคายังไม่ได้ชำระทั้งหมด"
            .Rows(5).Cells(1).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Rows(5).Cells(2).Value = "บาท"

            .Rows(6).Cells(0).Value = "พบรายการที่ชำระเงินแล้ว"
            .Rows(6).Cells(1).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Rows(6).Cells(2).Value = "รายการ"

            .Rows(7).Cells(0).Value = "รวมราคาที่ชำระแล้วทั้งหมด"
            .Rows(7).Cells(1).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Rows(7).Cells(2).Value = "บาท"

            .Rows(8).Cells(0).Value = "พบใบมัดจำ/ลดหนี้ จำนวน"
            .Rows(8).Cells(1).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Rows(8).Cells(2).Value = "รายการ"

            .Rows(9).Cells(0).Value = "รวมใบมัดจำ/ลดหนี้ จำนวน"
            .Rows(9).Cells(1).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Rows(9).Cells(2).Value = "บาท"

            .Rows(10).Cells(0).Value = "รวมราคาที่ต้องชำระทั้งหมด"
            .Rows(10).Cells(1).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Rows(10).Cells(2).Value = "บาท"

            .Rows(11).Cells(0).Value = "รายละเอียดการคืนสินค้า"
            .Rows(11).Cells(0).Style.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

            .Rows(12).Cells(0).Value = "พบรายการคืนสินค้าจำนวน"
            .Rows(12).Cells(1).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Rows(12).Cells(2).Value = "รายการ"

            .Rows(13).Cells(0).Value = "รวมราคาคืนสินค้าทั้งหมด"
            .Rows(13).Cells(1).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Rows(13).Cells(2).Value = "บาท"


            .Rows(3).DefaultCellStyle.BackColor = Color.BurlyWood
            .Rows(3).Cells(0).Style.BackColor = Color.LightGreen
            .Rows(4).DefaultCellStyle.BackColor = Color.LightGreen
            .Rows(5).DefaultCellStyle.BackColor = Color.LightGreen
            .Rows(6).DefaultCellStyle.BackColor = Color.LightGreen
            .Rows(7).DefaultCellStyle.BackColor = Color.LightGreen
            .Rows(8).DefaultCellStyle.BackColor = Color.LightGreen
            .Rows(9).DefaultCellStyle.BackColor = Color.LightGreen
            .Rows(10).DefaultCellStyle.BackColor = Color.LightGreen
            .Rows(11).DefaultCellStyle.BackColor = Color.Gray
            .Rows(11).Cells(0).Style.BackColor = Color.Orange
            .Rows(12).DefaultCellStyle.BackColor = Color.Orange
            .Rows(13).DefaultCellStyle.BackColor = Color.Orange
        End With
        Call checkStatus()
    End Sub


    Private Sub dgSRshowComfix_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSRshowComfix.CellDoubleClick
        Me.dgSRdetail.Rows.Clear()
        Call AddRows()
        Me.dgSRdetail.Rows(0).Cells(1).Value = Me.dgSRshowComfix.CurrentRow.Cells(2).Value
        Me.dgSRdetail.Rows(1).Cells(1).Value = Me.dgSRshowComfix.CurrentRow.Cells(4).Value
        Me.dgSRdetail.Rows(2).Cells(1).Value = Me.dgSRshowComfix.CurrentRow.Cells(1).Value
        Me.dgSRdetail.Rows(3).Cells(2).Value = Me.dgSRshowComfix.CurrentRow.Cells(9).Value
        If Me.dgSRdetail.Rows(0).Cells(1).Value <> Nothing Then
            Call GetCustomerData(Me.dgSRdetail.Rows(0).Cells(1).Value)
        End If
        If Me.dgSRdetail.Rows(1).Cells(1).Value <> Nothing Then
            Call GetSNData(Me.dgSRdetail.Rows(1).Cells(1).Value)
        End If
        If Me.dgSRdetail.Rows(2).Cells(1).Value <> Nothing Then
            Call GetDataComfix(Me.dgSRdetail.Rows(2).Cells(1).Value)
        End If
        Call get_sale_id()
        Call get_returnProduct()
        Call checkStatus()
        Call GetComfix_note(Me.dgSRshowComfix.CurrentRow.Cells(1).Value)
        Call LoadPictureList(Me.dgSRshowComfix.CurrentRow.Cells(1).Value)
    End Sub

    Private Sub checkStatus()
        Try
            If Me.dgSRdetail.Rows(3).Cells(2).Value = "5 ซ่อมเสร็จ" Then
                Me.Button1.Enabled = True
            ElseIf Me.dgSRdetail.Rows(3).Cells(2).Value = "6 ยกเลิกซ่อม" Then
                Me.Button1.Enabled = True
            ElseIf Me.dgSRdetail.Rows(3).Cells(2).Value = "4 ซ่อมไม่ได้" Then
                Me.Button1.Enabled = True
            Else
                Me.Button1.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub get_sale_id()
        Dim sumTTA As Decimal
        Dim cusid As Decimal
        Dim countTTA As Decimal
        Dim fixid As String = Me.dgSRdetail.Rows(2).Cells(1).Value
        Dim countpd, countcashpd, sumcashTTA As Decimal
        'หาผลรวมทุกบิลของใบขายนี้
        Try
            strSQL = "SELECT COALESCE(SUM(replace(total_all, ',', '')),0) AS tta FROM sale WHERE fix_id='" & fixid & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            sumTTA = Dr.GetDecimal("tta")
            Dr.Close()
        Catch ex As Exception
            sumTTA = 0
        End Try

        Try
            strSQL = "SELECT COALESCE(SUM(replace(total1, ',', '')),0) AS tt1 FROM pledge_sale WHERE customer_id='" & Me.dgSRdetail.Rows(0).Cells(1).Value & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            cusid = Dr.GetDecimal("tt1")
            Dr.Close()
        Catch ex As Exception
            cusid = 0
        End Try

        Try
            strSQL = "SELECT COUNT(fix_id) AS FID FROM sale WHERE fix_id='" & fixid & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            countTTA = Dr.GetDecimal("FID")
            Dr.Close()
        Catch ex As Exception
            countTTA = 0
        End Try

        Try
            strSQL = "SELECT COUNT(customer_id) AS CID FROM pledge_sale WHERE customer_id='" & Me.dgSRdetail.Rows(0).Cells(1).Value & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            countpd = Dr.GetDecimal("CID")
            Dr.Close()
        Catch ex As Exception
            countpd = 0
        End Try

        Try
            strSQL = "SELECT COUNT(fix_id) AS fic FROM cash_sale WHERE fix_id='" & fixid & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            countcashpd = Dr.GetDecimal("fic")
            Dr.Close()
        Catch ex As Exception
            countcashpd = 0
        End Try

        Try
            strSQL = "SELECT COALESCE(SUM(replace(total_all, ',', '')),0) AS tal FROM cash_sale WHERE fix_id='" & fixid & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            sumcashTTA = Dr.GetDecimal("tal")
            Dr.Close()
        Catch ex As Exception
            sumcashTTA = 0
        End Try
        Dim sat As Decimal = sumTTA - cusid
        Me.dgSRdetail.Rows(4).Cells(1).Value = countTTA
        Me.dgSRdetail.Rows(5).Cells(1).Value = sumTTA
        Me.dgSRdetail.Rows(6).Cells(1).Value = countcashpd
        Me.dgSRdetail.Rows(7).Cells(1).Value = sumcashTTA
        Me.dgSRdetail.Rows(8).Cells(1).Value = countpd
        Me.dgSRdetail.Rows(9).Cells(1).Value = cusid
        Me.dgSRdetail.Rows(10).Cells(1).Value = sat

    End Sub

    Private Sub get_returnProduct()
        Dim sumTTA As Decimal
        Dim countTTA As Decimal

        'หาผลรวม ราคาสินค้าส่งคืนทั้งหมด
        strSQL = "SELECT COALESCE(SUM(replace(total_all, ',', '')),0) AS pb FROM returnproduct WHERE fix_id='" & Me.dgSRdetail.Rows(2).Cells(1).Value & "'"
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader
            Dr.Read()
            sumTTA = Dr.GetDecimal("pb")
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        'นับจำนวนแถวสินค้าส่งคืน
        strSQL = "SELECT COUNT(fix_id) AS fid FROM returnproduct_barcode WHERE fix_id='" & Me.dgSRdetail.Rows(2).Cells(1).Value & "'"
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader
            Dr.Read()
            countTTA = Dr.GetDecimal("fid")
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Me.dgSRdetail.Rows(12).Cells(1).Value = countTTA
        Me.dgSRdetail.Rows(13).Cells(1).Value = sumTTA
    End Sub

    Private Sub GetCustomerData(ByVal cusid As String)
        Try
            Using dt = New DataTable
                strSQL = "SELECT customer_name,customer_address,customer_zipcode,customer_tel,customer_tax," _
                    & "customer_section FROM customer WHERE customer_id='" & cusid & "'"
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Me.dgSRdetail.Rows(0).Cells(2).Value = "ชื่อ: " & dt.Rows(0).Item("customer_name") & ", " _
                    & "ที่อยู่: " & dt.Rows(0).Item("customer_address") & " รหัสไปรษณีย์: " & dt.Rows(0).Item("customer_zipcode") & ", " _
                    & Environment.NewLine _
                    & "เบอร์โทร: " & dt.Rows(0).Item("customer_tel") & ", หมายเลขผู้เสียภาษี: " & dt.Rows(0).Item("customer_tax") & " " _
                    & "สาขา: " & dt.Rows(0).Item("customer_section")
            End Using
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub GetSNData(ByVal SNid As String)
        Try
            Using dt = New DataTable
                strSQL = "SELECT p_type,p_name,`model`,color,startdate FROM `sn` WHERE Snum='" & SNid & "'"
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Dim startdate As Date = dt.Rows(0).Item("startdate")
                Me.dgSRdetail.Rows(1).Cells(2).Value = "ประเภท: " & dt.Rows(0).Item("p_type") & ", ยี่ห้อ: " & dt.Rows(0).Item("p_name") _
                    & Environment.NewLine & " รุ่น: " & dt.Rows(0).Item("model") & ", สีตัวเครื่อง: " & dt.Rows(0).Item("color") & ", วันที่บันทึกข้อมูล SN: " & startdate.ToString("dd MMMM yyyy HH:mm", CultureInfo.CreateSpecificCulture("th-TH"))
            End Using
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Dim frn As String
    Private Sub GetDataComfix(ByVal fixID As String)
        Try
            'รายละเอียดเกี่ยวกับใบรับงานซ่อม
            Using dt = New DataTable
                strSQL = "SELECT fixrepairnote,fixaccessory,fixnote,fixtprice,fixuser,status,user_repair,note_repair," _
                    & "date_save,date_get,teltocus,date_send FROM comfix WHERE fix_id='" & fixID & "'"
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Dim dsave As Date = dt.Rows(0).Item("date_save")
                Dim dget As Date = dt.Rows(0).Item("date_get")
                Dim dsend As Date = dt.Rows(0).Item("date_send")
                Me.dgSRdetail.Rows(2).Cells(2).Value = "(อาการเสียเพิ่มเติม: " & dt.Rows(0).Item("fixrepairnote") & "), " _
                    & "(อุปกรณ์ที่นำมาด้วย: " & dt.Rows(0).Item("fixaccessory") & "), " _
                    & "(อาการเสียเพิ่มเติม: " & dt.Rows(0).Item("fixnote") & "), " _
                    & "(ประเมินราคาซ่อม: " & dt.Rows(0).Item("fixtprice") & "), " _
                    & "(พนักงานผู้รับงาน: " & dt.Rows(0).Item("fixuser") & "), " _
                    & Environment.NewLine _
                    & "(ช่างซ่อม: " & dt.Rows(0).Item("user_repair") & "), " _
                    & "(รายละเอียดการซ่อม: " & dt.Rows(0).Item("note_repair") & "), " _
                    & "(วันที่รับงานซ่อม: " & dsave.ToString("dd MMMM yyyy HH:mm", CultureInfo.CreateSpecificCulture("th-TH")) & "), " _
                    & "(วันที่นัดรับงานซ่อม: " & dget.ToString("dd MMMM yyyy HH:mm", CultureInfo.CreateSpecificCulture("th-TH")) & "), " _
                    & "(การแจ้งลูกค้า: " & dt.Rows(0).Item("teltocus") & "), " _
                    & "(วันที่ส่งคืนงานซ่อม: " & dsend.ToString("dd MMMM yyyy HH:mm", CultureInfo.CreateSpecificCulture("th-TH")) & ")"

                frn = dt.Rows(0).Item("fixrepairnote")
            End Using
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Friend Sub searchDatacomfixBystatus(ByVal statuscomfix)
        Me.ListView1.Clear()
        Me.ListView2.Clear()
        Me.dgSRshowComfix.Rows.Clear()
        Call CountSN(statuscomfix)
        Me.dgSRdetail.Rows.Clear()
        Call AddRows()
        Try
            strSQL = "SELECT fix_id,customer_id,customer_name,sn,symptom,managerdata,date_save,date_get,status,note_repair,teltocus,id FROM " _
                & "comfix WHERE status='" & statuscomfix & "' ORDER BY `id` DESC LIMIT " & Me.NumericUpDown1.Value & ";"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dim r As Integer
            While Dr.Read()
                'Dim datesave As Date = Dr.Item("date_save")
                'Dim dget As Date = Dr.Item("date_get")
                With Me.dgSRshowComfix
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = r + 1
                    .Rows(r).Cells(1).Tag = Dr.Item("id")
                    .Rows(r).Cells(1).Value = Dr.Item("fix_id")
                    .Rows(r).Cells(2).Value = Dr.Item("customer_id")
                    .Rows(r).Cells(3).Value = Dr.Item("customer_name")
                    .Rows(r).Cells(4).Value = Dr.Item("sn")
                    .Rows(r).Cells(5).Value = Dr.Item("symptom")
                    .Rows(r).Cells(6).Value = Dr.Item("managerdata")
                    .Rows(r).Cells(7).Value = Dr.Item("date_save")
                    .Rows(r).Cells(8).Value = Dr.Item("date_get")
                    .Rows(r).Cells(9).Value = Dr.Item("status")
                    .Rows(r).Cells(10).Value = Dr.Item("note_repair")
                    .Rows(r).Cells(11).Value = Dr.Item("teltocus")
                End With
            End While
            r2 = Me.dgSRshowComfix.RowCount
            Label2.Text = r2.ToString("N0") & "/" & l2.ToString("N0")
            Me.dgSRshowComfix.Refresh()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    ''' <summary>
    ''' โหลดข้อมูล comfix_note SELECT note,datetime_save FROM comfix_note 
    ''' </summary>
    ''' <param name="fixid">เลขใบรับซ่อม</param>
    ''' <remarks></remarks>
    Friend Sub GetComfix_note(ByVal fixid)
        Me.ListView2.Clear()
        Me.ListView2.Columns.Add("รายละเอียดการซ่อม", 230)
        Me.ListView2.Columns.Add("วันที่บันทึก", 140)
        Try
            cmd = New MySqlCommand("SELECT note,datetime_save FROM comfix_note WHERE key_note='" & fixid & "' ORDER BY datetime_save DESC;", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read
                Dim nt As String = Dr.Item("note")
                Dim lsvparent As New ListViewItem(nt)
                lsvparent.SubItems.Add(CDate(Dr.Item("datetime_save")).ToString("dd MMMM yyyy HH:mm", CultureInfo.CreateSpecificCulture("th-TH")))
                ListView2.Items.Add(lsvparent)
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Friend l2 As Integer
    Friend r2 As Integer
    Friend Sub CountSN(ByVal keyword As Object)
        Try
            cmd = New MySqlCommand("SELECT COUNT(id) AS cid FROM comfix WHERE status='" & keyword & "';", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                Dr.Read()
                l2 = Dr.Item("cid")
                r2 = Me.dgSRshowComfix.Rows.Count
                Me.Label2.Text = r2.ToString("N0") & "/" & l2.ToString("N0")
            Else
                l2 = 0
            End If
        Catch ex As Exception
            l2 = 0
        End Try
    End Sub

    Private Sub codeproSelect2Next(ByVal statuscomfix)
        Try
            'Using dt = New DataTable
            strSQL = "SELECT fix_id,customer_id,customer_name,sn,symptom,managerdata,date_save,date_get,status,note_repair,teltocus,`id` FROM " _
                & "comfix WHERE status='" & statuscomfix & "' AND `id` > '" & Me.dgSRshowComfix.Rows(Me.dgSRshowComfix.RowCount - 1).Cells(1).Tag & "' " _
                & "LIMIT " & Me.NumericUpDown1.Value & ";"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dim r As Integer
            While Dr.Read()
                With Me.dgSRshowComfix
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = r + 1
                    .Rows(r).Cells(1).Tag = Dr.Item("id")
                    .Rows(r).Cells(1).Value = Dr.Item("fix_id")
                    .Rows(r).Cells(2).Value = Dr.Item("customer_id")
                    .Rows(r).Cells(3).Value = Dr.Item("customer_name")
                    .Rows(r).Cells(4).Value = Dr.Item("sn")
                    .Rows(r).Cells(5).Value = Dr.Item("symptom")
                    .Rows(r).Cells(6).Value = Dr.Item("managerdata")
                    .Rows(r).Cells(7).Value = Dr.Item("date_save")
                    .Rows(r).Cells(8).Value = Dr.Item("date_get")
                    .Rows(r).Cells(9).Value = Dr.Item("status")
                    .Rows(r).Cells(10).Value = Dr.Item("note_repair")
                    .Rows(r).Cells(11).Value = Dr.Item("teltocus")
                End With
            End While
            r2 = Me.dgSRshowComfix.RowCount
            Label2.Text = r2.ToString("N0") & "/" & l2.ToString("N0")
            Me.dgSRshowComfix.Refresh()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub searchDatacomfix(ByVal skeyword As String)
        Try
            Me.dgSRshowComfix.Rows.Clear()
        Catch ex As Exception

        End Try
        Me.dgSRdetail.Rows.Clear()
        Call AddRows()
        Dim strKeyWord As String = skeyword
        strSQL = "SELECT fix_id,customer_id,customer_name,`sn`,symptom,managerdata,date_save,date_get,`status`,note_repair,teltocus,`id` FROM comfix WHERE "
        If strKeyWord <> "" Then
            strSQL = strSQL & "fix_id LIKE '%" & strKeyWord & "%' " _
                & "OR customer_id LIKE '%" & strKeyWord & "%' " _
                & "OR customer_name LIKE '%" & strKeyWord & "%' " _
                & "OR `sn` LIKE '%" & strKeyWord & "%' " _
                & "OR symptom LIKE '%" & strKeyWord & "%' " _
                & "OR managerdata LIKE '%" & strKeyWord & "%' " _
                & "OR `status` LIKE '%" & strKeyWord & "%' " _
                & "OR note_repair LIKE '%" & strKeyWord & "%' " _
                & "OR teltocus LIKE '%" & strKeyWord & "%' ORDER BY `id` DESC"
        End If
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader
            Dim r As Integer
            While Dr.Read()
                With Me.dgSRshowComfix
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = r + 1
                    .Rows(r).Cells(1).Tag = Dr.Item("id")
                    .Rows(r).Cells(1).Value = Dr.Item("fix_id")
                    .Rows(r).Cells(2).Value = Dr.Item("customer_id")
                    .Rows(r).Cells(3).Value = Dr.Item("customer_name")
                    .Rows(r).Cells(4).Value = Dr.Item("sn")
                    .Rows(r).Cells(5).Value = Dr.Item("symptom")
                    .Rows(r).Cells(6).Value = Dr.Item("managerdata")
                    .Rows(r).Cells(7).Value = Dr.Item("date_save")
                    .Rows(r).Cells(8).Value = Dr.Item("date_get")
                    .Rows(r).Cells(9).Value = Dr.Item("status")
                    .Rows(r).Cells(10).Value = Dr.Item("note_repair")
                    .Rows(r).Cells(11).Value = Dr.Item("teltocus")
                End With
            End While
            Me.txtSRsearch.Clear()
        Catch ex As Exception
            Me.txtSRsearch.Clear()
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Friend Sub LoadPictureList(ByVal key_pic As String)
        Me.ListView1.Clear()
        Dim imglist As New ImageList
        imglist.ColorDepth = ColorDepth.Depth32Bit
        ListView1.LargeImageList = imglist
        ListView1.LargeImageList.ImageSize = New System.Drawing.Size(80, 80)
        Try
            cmd = New MySqlCommand("SELECT pa_id,byte_pic,note_pic,datetime_save FROM picture_all " _
                                   & "WHERE key_pic='" & key_pic & "' AND del='no' ORDER BY datetime_save ASC;", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read
                Dim img_buffer() As Byte
                img_buffer = CType(Dr.Item("byte_pic"), Byte())
                Dim img_stream As New MemoryStream(img_buffer, True)

                img_stream.Write(img_buffer, 0, img_buffer.Length)
                imglist.Images.Add(Dr.Item("pa_id").ToString(), New Bitmap(img_stream))
                img_stream.Close()

                Dim lsvparent As New ListViewItem
                lsvparent.Text = Dr.Item("datetime_save").ToString()
                lsvparent.ImageKey = Dr.Item("pa_id").ToString()
                ListView1.Items.Add(lsvparent)
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        Me.btnForward.Enabled = False
        Call codeproSelect2Next(Me.cbbSRsearchAll.Text)
        Me.btnForward.Enabled = True
    End Sub

    Private Sub Label2_TextChanged(sender As Object, e As EventArgs) Handles Label2.TextChanged
        If r2 <> l2 Then
            Me.btnForward.Enabled = True
        Else
            Me.btnForward.Enabled = False
        End If
    End Sub

    Private Sub cbbSRsearchAll_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbSRsearchAll.SelectedValueChanged
        Call searchDatacomfixBystatus(Me.cbbSRsearchAll.Text)
    End Sub

    Dim oldData As Object

    Private Sub dgSRdetail_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSRdetail.CellClick
        oldData = Me.dgSRdetail.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub
    Private Sub dgSRdetail_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSRdetail.CellDoubleClick
        oldData = Me.dgSRdetail.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub

    Private Sub dgSRdetail_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgSRdetail.CellEndEdit
        Me.dgSRdetail.CurrentRow.Cells(e.ColumnIndex).Value = oldData
    End Sub

    Private Sub dgSRdetail_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgSRdetail.CellMouseEnter
        If e.ColumnIndex = 1 And e.RowIndex = 4 Then
            Me.dgSRdetail.Rows(4).Cells(1).Style.BackColor = Color.Red
        ElseIf e.ColumnIndex = 1 And e.RowIndex = 6 Then
            Me.dgSRdetail.Rows(6).Cells(1).Style.BackColor = Color.Red
        ElseIf e.ColumnIndex = 1 And e.RowIndex = 12 Then
            Me.dgSRdetail.Rows(12).Cells(1).Style.BackColor = Color.Red
        End If
    End Sub

    Private Sub dgSRdetail_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgSRdetail.CellMouseLeave
        If e.ColumnIndex = 1 And e.RowIndex = 4 Then
            Me.dgSRdetail.Rows(4).Cells(1).Style.BackColor = Color.LightGreen
        ElseIf e.ColumnIndex = 1 And e.RowIndex = 6 Then
            Me.dgSRdetail.Rows(6).Cells(1).Style.BackColor = Color.LightGreen
        ElseIf e.ColumnIndex = 1 And e.RowIndex = 12 Then
            Me.dgSRdetail.Rows(12).Cells(1).Style.BackColor = Color.Orange
        End If
    End Sub


    Private Sub dgSRdetail_MouseDown(sender As Object, e As MouseEventArgs) Handles dgSRdetail.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim ht As DataGridView.HitTestInfo
            ht = Me.dgSRdetail.HitTest(e.X, e.Y)
            If ht.Type = DataGridViewHitTestType.Cell Then
                If ht.ColumnIndex = 1 And ht.RowIndex = 4 Then
                    If Me.dgSRdetail.Rows(4).Cells(1).Value <> 0 Or Nothing Then
                        Me.ContextMenuDetailSale.Enabled = True
                        Me.ContextMenuDetailSale.Show(dgSRdetail, e.Location)
                        Me.ContextMenuDetailSale.Show(Cursor.Position)
                    Else
                        Me.ContextMenuDetailSale.Enabled = False
                        Me.ContextMenuDetailSale.Show(dgSRdetail, e.Location)
                        Me.ContextMenuDetailSale.Show(Cursor.Position)
                    End If
                ElseIf ht.ColumnIndex = 1 And ht.RowIndex = 6 Then
                    If Me.dgSRdetail.Rows(6).Cells(1).Value <> 0 Or Nothing Then
                        Me.ContextMenuDetailCashSale.Enabled = True
                        Me.ContextMenuDetailCashSale.Show(dgSRdetail, e.Location)
                        Me.ContextMenuDetailCashSale.Show(Cursor.Position)
                    Else
                        Me.ContextMenuDetailCashSale.Enabled = False
                        Me.ContextMenuDetailCashSale.Show(dgSRdetail, e.Location)
                        Me.ContextMenuDetailCashSale.Show(Cursor.Position)
                    End If
                ElseIf ht.ColumnIndex = 1 And ht.RowIndex = 12 Then
                    If Me.dgSRdetail.Rows(12).Cells(1).Value <> 0 Or Nothing Then
                        Me.ContextMenuReturnProduct.Enabled = True
                        Me.ContextMenuReturnProduct.Show(dgSRdetail, e.Location)
                        Me.ContextMenuReturnProduct.Show(Cursor.Position)
                    Else
                        Me.ContextMenuReturnProduct.Enabled = False
                        Me.ContextMenuReturnProduct.Show(dgSRdetail, e.Location)
                        Me.ContextMenuReturnProduct.Show(Cursor.Position)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnSRsearch_Click(sender As Object, e As EventArgs) Handles btnSRsearch.Click
        If Me.txtSRsearch.Text <> Nothing Then
            Call searchDatacomfix(Me.txtSRsearch.Text)
        End If
    End Sub

    Private Sub txtSRsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSRsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If Me.txtSRsearch.Text <> Nothing Then
                Call searchDatacomfix(Me.txtSRsearch.Text)
            End If
        End If
    End Sub

    Private Sub ToolStripMenuSaleDetail_Click(sender As Object, e As EventArgs) Handles ToolStripMenuSaleDetail.Click
        ViewProductRepairFrm.getDatatodgRPorderpro(Me.dgSRdetail.Rows(2).Cells(1).Value)
        ViewProductRepairFrm.ShowDialog(Me)
    End Sub

    Private Sub ToolStripMenuDeatilCashSale_Click(sender As Object, e As EventArgs) Handles ToolStripMenuDeatilCashSale.Click
        ViewProductRepairFrm.getDatatodgRPorderpro(Me.dgSRdetail.Rows(2).Cells(1).Value)
        ViewProductRepairFrm.ShowDialog(Me)
    End Sub

    Private Sub ToolStripMenuReturnProduct_Click(sender As Object, e As EventArgs) Handles ToolStripMenuReturnProduct.Click
        ViewReturnProductRepairFrm.txtVPRfix_id.Text = Me.dgSRdetail.Rows(2).Cells(1).Value
        ViewReturnProductRepairFrm.ShowDialog(Me)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each form In My.Application.OpenForms
            If (form.name = SendRepairFrm.Name) Then
                If form.Visible Then
                    SendRepairFrm.Close()
                    SendRepairFrm.txtHideform.Text = Me.dgSRdetail.Rows(2).Cells(1).Value
                    SendRepairFrm.cbbSRRcash_status.Enabled = True
                    SendRepairFrm.DateTimePickerSRR.Enabled = True
                    SendRepairFrm.lblEmployee.Text = Me.lblEmployee.Text
                    SendRepairFrm.ShowDialog(Me)
                    Exit Sub
                End If
            End If
        Next
        SendRepairFrm.txtHideform.Text = Me.dgSRdetail.Rows(2).Cells(1).Value
        SendRepairFrm.cbbSRRcash_status.Enabled = True
        SendRepairFrm.DateTimePickerSRR.Enabled = True
        SendRepairFrm.lblEmployee.Text = Me.lblEmployee.Text
        SendRepairFrm.ShowDialog(Me)
    End Sub

    Private Sub NumericUpDown1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NumericUpDown1.KeyPress
        e.Handled = True
    End Sub

    Private Sub ListView1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.ListView1.Items.Count > 0 Then
                If ListView1.SelectedItems.Count > 0 Then
                    MainViewPictureFrm.GetPicture(ListView1.FocusedItem.ImageKey.ToString)
                    MainViewPictureFrm.ShowDialog(Me)
                End If
            End If
        End If
    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        If e.Button = MouseButtons.Left Then
            If Me.ListView1.Items.Count > 0 Then
                If ListView1.SelectedItems.Count > 0 Then
                    MainViewPictureFrm.GetPicture(ListView1.FocusedItem.ImageKey.ToString)
                    MainViewPictureFrm.ShowDialog(Me)
                End If
            End If
        End If
    End Sub

    Private Sub btnHelp_Click_1(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/comfix/searchrepairfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class