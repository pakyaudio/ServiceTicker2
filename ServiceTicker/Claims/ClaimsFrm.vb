Imports MySql.Data.MySqlClient
Imports BarcodeLib.Barcode
Imports System.Globalization
Imports System.Data.SQLite

Public Class ClaimsFrm
    Dim LinearEncoder As New BarcodeLib.Barcode
    Private Sub ClaimsFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.dgClaims.RowCount > 0 Then
            If MessageBox.Show(Me, "มีข้อมูงานเคลมที่ยังไม่ได้ถูกบันทึก หากปิดหน้าต่างนี้ไปข้อมูลงานเคลมที่ยังไม่บันทึกจะถูกลบออก", "แจ้งเตือน", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                e.Cancel = False
                For num As Integer = 0 To Me.dgClaims.RowCount - 1
                    Try
                        strSQLite = "DELETE FROM claims_cache WHERE claims_id='" & Me.dgClaims.Rows(num).Cells(1).Value & "'"
                        cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                        Call open_connectionSQLite()
                        cmdSQLite.ExecuteNonQuery()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                Next
                Me.Dispose()
                OnTopFrm()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub loadErrorSave()
        strSQLite = "SELECT * FROM claims_cache"
        cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
        Call open_connectionSQLite()
        Try
            DrSQLite = cmdSQLite.ExecuteReader
            If DrSQLite.HasRows Then
                If MessageBox.Show(Me, "พบข้อมูลงานเคลมยังไม่ได้บันทึก" & vbNewLine & "ต้องการจะทำต่อหรือไม่", "ข้อมูลยังไม่ได้บันทึก", MessageBoxButtons.YesNo, _
                                   MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    DrSQLite.Read()
                    Me.txtCFcustomer_id.Text = DrSQLite.Item("customer_id")
                    Try
                        cmd = New MySqlCommand("SELECT customer_name FROM customer WHERE customer_id='" & Me.txtCFcustomer_id.Text & "'", ConnectionDB)
                        Call open_connection()
                        Dr = cmd.ExecuteReader()
                        Dr.Read()
                        Me.txtCFcustomer_name.Text = Dr.Item("customer_name")
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                    Call loadDataCache()
                Else
                    Try
                        cmdSQLite = New SQLiteCommand("DELETE FROM claims_cache", connSQLite)
                        Call open_connectionSQLite()
                        cmdSQLite.ExecuteNonQuery()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                End If

            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub ClaimsFrm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Panel5.Location = New Point((Me.DisplayRectangle.Width - Panel5.Width) / 2, 5)
        Me.Panel2.Location = New Point((Me.DisplayRectangle.Width - Panel2.Width) / 2, 5)

        Me.Panel4.Location = New Point((Me.DisplayRectangle.Width - Panel4.Width) / 2, 5)
        Me.Panel8.Location = New Point((Me.DisplayRectangle.Width - Panel8.Width) / 2, 5)
    End Sub

    'Private Sub AutoNumberNo()
    '    'Dim nid As String = String.Empty
    '    'Try
    '    '    cmd = New MySqlCommand("SELECT ver_claims FROM ver_detail", ConnectionDB)
    '    '    Call open_connection()
    '    '    Dr = cmd.ExecuteReader
    '    '    Dr.Read()
    '    '    nid = Dr.Item("ver_claims")
    '    'Catch ex As Exception
    '    '    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
    '    'End Try
    '    'Me.txtCFclaims_id.Text = nid & Now.ToString("yyMMddHHmmss")
    '    Call ALLAutonumber("ver_claims", Me.txtCFclaims_id.Text)
    'End Sub

    Private Sub startFrm()
        If Me.dgClaims.RowCount > 0 Then
            Me.btnCchangCustomer.Enabled = False
            Me.txtCFsearchSN.ReadOnly = False
            Me.btnCFsearchSN.Enabled = True
            Me.txtCFserial_pro.Clear()
            Me.txtCFcode_pro.Clear()
            Me.txtCFbar_code.Clear()
            Me.txtCFname_pro.Clear()
            Me.txtCFprice_buy.Clear()
            Me.txtCFprice_wholsale.Clear()
            Me.txtCFprice_technician.Clear()
            Me.txtCFprice_loyal.Clear()
            Me.txtCFprice_members.Clear()
            Me.txtCFtype.Clear()
            Me.txtCFunit.Clear()
            Me.txtCFdatetime_sale.Clear()
            Me.txtCFemployee_sale.Clear()
            Me.txtCFsyptom.Clear()
            Me.txtCFaccessory.Clear()
            Me.txtCFnote.Clear()
            Me.txtCFstatus.Clear()
           

            Me.txtCFserial_pro.ReadOnly = True
            Me.txtCFcode_pro.ReadOnly = True
            Me.txtCFname_pro.ReadOnly = True
            Me.txtCFprice_buy.ReadOnly = True
            Me.txtCFunit.ReadOnly = True


            Me.lblCFdate.Text = "วันที่-----(ปี/เดือน/วัน เวลา)"
            If Me.txtCFserial_pro.Text <> Nothing Then
                Me.txtCFsyptom.Enabled = True
                Me.txtCFaccessory.Enabled = True
                Me.txtCFnote.Enabled = True
                Me.btnCFsave.Enabled = True
                Me.btnCFcancel.Enabled = True
            ElseIf Me.txtCFserial_pro.Text = Nothing Then
                Me.txtCFsyptom.Enabled = False
                Me.txtCFaccessory.Enabled = False
                Me.txtCFnote.Enabled = False
                Me.btnCFsave.Enabled = False
                Me.btnCFcancel.Enabled = False
            End If
        Else
            Me.btnCchangCustomer.Enabled = True
            Me.txtCFsearchSN.ReadOnly = False
            Me.btnCFsearchSN.Enabled = True
            Me.txtCFcustomer_id.Clear()
            Me.txtCFcustomer_name.Clear()
            Me.txtCFserial_pro.Clear()
            Me.txtCFcode_pro.Clear()
            Me.txtCFbar_code.Clear()
            Me.txtCFname_pro.Clear()
            Me.txtCFprice_buy.Clear()
            Me.txtCFprice_wholsale.Clear()
            Me.txtCFprice_technician.Clear()
            Me.txtCFprice_loyal.Clear()
            Me.txtCFprice_members.Clear()
            Me.txtCFtype.Clear()
            Me.txtCFunit.Clear()
            Me.txtCFdatetime_sale.Clear()
            Me.txtCFemployee_sale.Clear()
            Me.txtCFsyptom.Clear()
            Me.txtCFaccessory.Clear()
            Me.txtCFnote.Clear()
            Me.txtCFstatus.Clear()
           


            Me.txtCFserial_pro.ReadOnly = True
            Me.txtCFcode_pro.ReadOnly = True
            Me.txtCFname_pro.ReadOnly = True
            Me.txtCFprice_buy.ReadOnly = True
            Me.txtCFunit.ReadOnly = True

            Me.lblCFdate.Text = "วันที่-----(ปี/เดือน/วัน เวลา)"
            If Me.txtCFserial_pro.Text <> Nothing Then
                Me.txtCFsyptom.Enabled = True
                Me.txtCFaccessory.Enabled = True
                Me.txtCFnote.Enabled = True
                Me.btnCFsave.Enabled = True
                Me.btnCFcancel.Enabled = True
            ElseIf Me.txtCFserial_pro.Text = Nothing Then
                Me.txtCFsyptom.Enabled = False
                Me.txtCFaccessory.Enabled = False
                Me.txtCFnote.Enabled = False
                Me.btnCFsave.Enabled = False
                Me.btnCFcancel.Enabled = False
            End If
        End If
    End Sub

    Dim has As String
    Private Sub chkAddressSN()
        Try
            'ค้นหา sn 
            strSQL = "SELECT serial_pro FROM cash_sale_serial WHERE serial_pro='" & Me.txtCFsearchSN.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            If Dr.HasRows Then
                has = 100
            Else
                strSQL = "SELECT serial_pro FROM sale_serial WHERE serial_pro='" & Me.txtCFsearchSN.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                If Dr.HasRows Then
                    has = 200
                Else
                    has = 300
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub getdataSN()
        Call chkAddressSN()
        Try
            'ดึงข้อมูล
            If has = 100 Then
                strSQL = "SELECT customer_id,customer_name,code_pro,bar_code,name_pro,serial_pro,datetime_save,employee FROM cash_sale_serial WHERE serial_pro='" & Me.txtCFsearchSN.Text & "'"
                Me.lblCFdate.Text = "วันที่ขายสินค้า(ปี/เดือน/วัน เวลา)"
            ElseIf has = 200 Then
                strSQL = "SELECT customer_id,customer_name,code_pro,bar_code,name_pro,serial_pro,datetime_save,employee FROM sale_serial WHERE serial_pro='" & Me.txtCFsearchSN.Text & "'"
                Me.lblCFdate.Text = "วันที่ขายสินค้า(ปี/เดือน/วัน เวลา)"
            ElseIf has = 300 Then
                strSQL = "SELECT code_pro,name_pro,serial_pro,date_in FROM product_serial WHERE serial_pro='" & Me.txtCFsearchSN.Text & "'"
                Me.lblCFdate.Text = "วันที่นำเข้าระบบ(ปี/เดือน/วัน เวลา)"
            End If
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            If has = 300 Then
                Dr.Read()
                With Dr
                    Me.txtCFserial_pro.Text = .Item("serial_pro")
                    Me.txtCFcode_pro.Text = .Item("code_pro")
                    Me.txtCFname_pro.Text = .Item("name_pro")
                    Me.txtCFbar_code.Text = "-"
                    Me.txtCFdatetime_sale.Text = .Item("date_in")
                    Me.txtCFemployee_sale.Text = "-"
                    Me.txtCFcustomer_id.Text = "สินค้าจากสต็อก"
                    Me.txtCFcustomer_name.Text = "-"
                End With
            Else
                Dr.Read()
                With Dr
                    Me.txtCFcustomer_id.Text = .Item("customer_id")
                    Me.txtCFcustomer_name.Text = .Item("customer_name")
                    Me.txtCFserial_pro.Text = .Item("serial_pro")
                    Me.txtCFcode_pro.Text = .Item("code_pro")
                    Me.txtCFbar_code.Text = .Item("bar_code")
                    Me.txtCFname_pro.Text = .Item("name_pro")
                    Me.txtCFdatetime_sale.Text = .Item("datetime_save")
                    Me.txtCFemployee_sale.Text = .Item("employee")
                End With
            End If

            strSQL = "SELECT bar_code,price_buy,price_wholesale,price_technician,price_loyal,price_members,unit,type FROM product WHERE code_pro='" & Me.txtCFcode_pro.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            With Dr
                If has = 300 Then
                    Me.txtCFbar_code.Text = .Item("bar_code")
                End If
                Me.txtCFprice_buy.Text = .Item("price_buy")
                Me.txtCFprice_wholsale.Text = .Item("price_wholesale")
                Me.txtCFprice_technician.Text = .Item("price_technician")
                Me.txtCFprice_loyal.Text = .Item("price_loyal")
                Me.txtCFprice_members.Text = .Item("price_members")
                Me.txtCFunit.Text = .Item("unit")
                Me.txtCFtype.Text = .Item("type")
            End With

            If has = 100 Then
                Me.txtCFstatus.Text = "ชำระเงินแล้ว"
            ElseIf has = 200 Then
                Me.txtCFstatus.Text = "ยังไม่ชำระเงิน"
            ElseIf has = 300 Then
                Me.txtCFstatus.Text = "สินค้าจากสต็อกสินค้า"
            End If
            Me.txtCFsearchSN.Clear()
            Me.txtCFsearchSN.Focus()
        Catch ex As Exception
            MsgBox("ไม่พบข้อมูล", MsgBoxStyle.Exclamation, "No Data")
            Me.txtCFsearchSN.Clear()
            Me.txtCFsearchSN.Focus()
        End Try
        has = Nothing
    End Sub

    Dim cp As String
    Dim scp As Integer
    Private Sub saveAllData()
        If Me.dgClaims.RowCount = 0 Then
            MsgBox("ยังไม่มีข้อมูลงานเคลม", MsgBoxStyle.Information, "แจ้งเตือน")
        Else
            If MessageBox.Show(Me, "คุณแน่ใจว่าจะบันทึกข้อมูลนี้", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                For num As Integer = 0 To Me.dgClaims.RowCount - 1
                    strSQLite = "SELECT * FROM claims_cache WHERE claims_id='" & Me.dgClaims.Rows(num).Cells(1).Value & "';"
                    cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                    Call open_connectionSQLite()
                    Try
                        DrSQLite = cmdSQLite.ExecuteReader
                        DrSQLite.Read()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try

                    strSQL = "INSERT INTO claims(claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,price_buy," _
                        & "price_wholesale,price_technician,price_loyal,price_members,`type`,unit,datetime_sale," _
                        & "datetime_return,datetime_edit,claims_money,employee_claims_return,tel_to_cus,employee_sale," _
                        & "symptom,accressory,note,note2,`status`,employee,datetime_save,claims_id_pic)" _
                        & "VALUES(@claims_id,@customer_id,@serial_pro,@code_pro,@bar_code,@name_pro,@price_buy," _
                        & "@price_wholesale,@price_technician,@price_loyal,@price_members,@type,@unit," _
                        & "@datetime_sale,@datetime_return,@datetime_edit,@claims_money,@employee_claims_return," _
                        & "@tel_to_cus,@employee_sale,@symptom,@accressory,@note,@note2,@status,@employee,@datetime_save," _
                        & "@claims_id_pic)"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    With cmd
                        .Parameters.Add(New MySqlParameter("@claims_id", DrSQLite.Item("claims_id")))
                        .Parameters.Add(New MySqlParameter("@customer_id", DrSQLite.Item("customer_id")))
                        .Parameters.Add(New MySqlParameter("@serial_pro", DrSQLite.Item("serial_pro")))
                        .Parameters.Add(New MySqlParameter("@code_pro", DrSQLite.Item("code_pro")))
                        .Parameters.Add(New MySqlParameter("@bar_code", DrSQLite.Item("bar_code")))
                        .Parameters.Add(New MySqlParameter("@name_pro", DrSQLite.Item("name_pro")))
                        .Parameters.Add(New MySqlParameter("@price_buy", DrSQLite.Item("price_buy")))
                        .Parameters.Add(New MySqlParameter("@price_wholesale", DrSQLite.Item("price_wholesale")))
                        .Parameters.Add(New MySqlParameter("@price_technician", DrSQLite.Item("price_technician")))
                        .Parameters.Add(New MySqlParameter("@price_loyal", DrSQLite.Item("price_loyal")))
                        .Parameters.Add(New MySqlParameter("@price_members", DrSQLite.Item("price_members")))
                        .Parameters.Add(New MySqlParameter("@type", DrSQLite.Item("type")))
                        .Parameters.Add(New MySqlParameter("@unit", DrSQLite.Item("unit")))
                        .Parameters.Add(New MySqlParameter("@datetime_sale", DrSQLite.Item("datetime_sale")))
                        .Parameters.Add(New MySqlParameter("@datetime_return", DrSQLite.Item("datetime_return")))
                        .Parameters.Add(New MySqlParameter("@datetime_edit", DrSQLite.Item("datetime_edit")))
                        .Parameters.Add(New MySqlParameter("@claims_money", DrSQLite.Item("claims_money")))
                        .Parameters.Add(New MySqlParameter("@employee_claims_return", DrSQLite.Item("employee_claims_return")))
                        .Parameters.Add(New MySqlParameter("@tel_to_cus", DrSQLite.Item("tel_to_cus")))
                        .Parameters.Add(New MySqlParameter("@employee_sale", DrSQLite.Item("employee_sale")))
                        .Parameters.Add(New MySqlParameter("@symptom", DrSQLite.Item("symptom")))
                        .Parameters.Add(New MySqlParameter("@accressory", DrSQLite.Item("accressory")))
                        .Parameters.Add(New MySqlParameter("@note", DrSQLite.Item("note")))
                        .Parameters.Add(New MySqlParameter("@note2", DrSQLite.Item("note2")))
                        .Parameters.Add(New MySqlParameter("@status", DrSQLite.Item("status")))
                        .Parameters.Add(New MySqlParameter("@employee", DrSQLite.Item("employee")))
                        .Parameters.Add(New MySqlParameter("@datetime_save", DrSQLite.Item("datetime_save")))
                        .Parameters.Add(New MySqlParameter("@claims_id_pic", DrSQLite.Item("claims_id_pic")))
                    End With
                    Call open_connection()
                    Try
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try

                    If Me.dgClaims.Rows(num).Cells(2).Value = "สินค้าจากสต็อก" Then
                        Try
                            'ลบ SN จาก product_serial จะได้เอามาขายไม่ได้
                            'ค้นหา sn
                            strSQL = "DELETE FROM product_serial WHERE serial_pro='" & Me.dgClaims.Rows(num).Cells(3).Value & "'"
                            cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Call open_connection()
                            cmd.ExecuteNonQuery()
                        Catch ex As Exception
                            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                        End Try


                        Try
                            strSQL = "SELECT count_num FROM product WHERE code_pro='" & Me.dgClaims.Rows(num).Cells(4).Value & "'"
                            cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Call open_connection()
                            Dr = cmd.ExecuteReader()
                            Dr.Read()
                            cp = Dr.GetString("count_num")
                            scp = CInt(cp) - 1
                            'update count_num product
                            strSQL = "UPDATE product SET count_num='" & scp & "' WHERE code_pro='" & Me.dgClaims.Rows(num).Cells(4).Value & "'"
                            cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Call open_connection()
                            cmd.ExecuteNonQuery()
                            cp = Nothing
                            scp = Nothing
                        Catch ex As Exception
                            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                        End Try
                    End If
                Next

                If MessageBox.Show(Me, "ต้องการจะพิมพ์ใบรับเคลมหรือไม่", "พิมพ์", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    Try
                        If checkPrinter() = "A4" Then
                            ClaimsReportA4PrintFrm.ShowDialog(Me)
                        ElseIf checkPrinter() = "A5" Then
                            ClaimsReportA5PrintFrm.ShowDialog(Me)
                        End If
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                End If

                Try
                    strSQLite = "DELETE FROM claims_cache"
                    cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                    Call open_connectionSQLite()
                    cmdSQLite.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try

                Me.dgClaims.Rows.Clear()
                Me.btnCchangCustomer.Enabled = True
                Me.txtCFsearchSN.ReadOnly = False
                Me.btnCFsearchSN.Enabled = True
                Me.txtCFcustomer_id.Clear()
                Me.txtCFcustomer_name.Clear()
                Me.txtCFserial_pro.Clear()
                Me.txtCFcode_pro.Clear()
                Me.txtCFbar_code.Clear()
                Me.txtCFname_pro.Clear()
                Me.txtCFprice_buy.Clear()
                Me.txtCFtype.Clear()
                Me.txtCFunit.Clear()
                Me.txtCFdatetime_sale.Clear()
                Me.txtCFemployee_sale.Clear()
                Me.txtCFsyptom.Clear()
                Me.txtCFaccessory.Clear()
                Me.txtCFnote.Clear()
                Me.txtCFstatus.Clear()
                Me.txtCFsyptom.BackColor = SystemColors.Window
                Me.txtCFaccessory.BackColor = SystemColors.Window
                Me.txtCFnote.BackColor = SystemColors.Window
                Me.txtCFserial_pro.ReadOnly = True
                Me.txtCFcode_pro.ReadOnly = True
                Me.txtCFname_pro.ReadOnly = True
                Me.txtCFprice_buy.ReadOnly = True
                Me.txtCFunit.ReadOnly = True
                MsgBox("บันทึกข้อมูลแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
            End If
            End If
    End Sub

    Private Sub txtCFsearchSN_Click(sender As Object, e As EventArgs) Handles txtCFsearchSN.Click
        If desposit = 100 Then
        Else
            Me.txtCFsearchSN.BackColor = SystemColors.Window
        End If

    End Sub

    Private Sub txtCFsearchSN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCFsearchSN.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getdataSN()
        End If
    End Sub

    Private Sub ClaimsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon

        Call startFrm()

        Try
            Dim cmd As New MySqlCommand("SELECT DISTINCT symptom,accressory,note FROM claims ORDER BY datetime_save DESC LIMIT 1000", ConnectionDB)
            Call open_connection()
            Using ds As New DataSet
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(ds, "symptom")
                Dim col As New AutoCompleteStringCollection
                Dim i As Integer
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    col.Add(ds.Tables(0).Rows(i)("symptom").ToString())
                Next
                Me.txtCFsyptom.AutoCompleteCustomSource = col
                Me.txtCFsyptom.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                Me.txtCFsyptom.AutoCompleteSource = AutoCompleteSource.CustomSource
            End Using

            Call open_connection()
            Using ds As New DataSet
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(ds, "accressory")
                Dim col As New AutoCompleteStringCollection
                Dim i As Integer
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    col.Add(ds.Tables(0).Rows(i)("accressory").ToString())
                Next
                Me.txtCFaccessory.AutoCompleteCustomSource = col
                Me.txtCFaccessory.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                Me.txtCFaccessory.AutoCompleteSource = AutoCompleteSource.CustomSource
            End Using

            Call open_connection()
            Using ds As New DataSet
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(ds, "note")
                Dim col As New AutoCompleteStringCollection
                Dim i As Integer
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    col.Add(ds.Tables(0).Rows(i)("note").ToString())
                Next
                Me.txtCFnote.AutoCompleteCustomSource = col
                Me.txtCFnote.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                Me.txtCFnote.AutoCompleteSource = AutoCompleteSource.CustomSource
            End Using
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Call loadErrorSave()
    End Sub

    Dim claims_autonum As String
    Private Sub btnCFsave_Click(sender As Object, e As EventArgs) Handles btnCFsave.Click
        If Me.txtCFcustomer_id.Text = "0" Then
            MessageBox.Show(Me, "ไม่สามารถใช้ชื่อ ลูกค้าเงินสด ในการเคลมได้", "เปลี่ยนชื่อลูกค้า", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Call ALLAutonumber("ver_claims", claims_autonum)
            Try
                strSQL = "SELECT serial_pro FROM claims WHERE serial_pro='" & Me.txtCFserial_pro.Text & "' AND NOT status='" & "ส่งคืนแล้ว" & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                If Dr.HasRows Then
                    MsgBox("SN " & Me.txtCFserial_pro.Text & " มีในระบบเคลมแล้ว กรุณาตรวจสอบ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                    Exit Sub
                Else
                    strSQL = "SELECT serial_pro FROM claims_cache WHERE serial_pro='" & Me.txtCFserial_pro.Text & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader()
                    If Dr.HasRows Then
                        MsgBox("SN " & Me.txtCFserial_pro.Text & " มีในระบบเคลมแล้ว กรุณาตรวจสอบ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                        Exit Sub
                    Else
                        If Me.txtCFcustomer_id.Text = "" Then
                            Me.txtCFcustomer_name.BackColor = Color.OrangeRed
                            Me.txtCFcustomer_id.BackColor = Color.OrangeRed
                            Exit Sub
                        End If
                        If Me.txtCFserial_pro.Text = "" Then
                            Me.txtCFsearchSN.Focus()
                            Me.txtCFsearchSN.BackColor = Color.OrangeRed
                            Exit Sub
                        End If
                        If Me.txtCFname_pro.Text = "" Then
                            Me.txtCFname_pro.Focus()
                            Me.txtCFname_pro.BackColor = Color.OrangeRed
                            Exit Sub
                        End If
                        If Me.txtCFprice_buy.Text = "" Then
                            Me.txtCFprice_buy.Focus()
                            Me.txtCFprice_buy.BackColor = Color.OrangeRed
                            Exit Sub
                        End If
                        If Me.txtCFunit.Text = "" Then
                            Me.txtCFunit.Focus()
                            Me.txtCFunit.BackColor = Color.OrangeRed
                            Exit Sub
                        End If
                        If Me.txtCFsyptom.Text = "" Then
                            Me.txtCFsyptom.Focus()
                            Me.txtCFsyptom.BackColor = Color.OrangeRed
                            Exit Sub
                        ElseIf Me.txtCFaccessory.Text = "" Then
                            Me.txtCFaccessory.Focus()
                            Me.txtCFaccessory.BackColor = Color.OrangeRed
                            Exit Sub
                        ElseIf Me.txtCFnote.Text = "" Then
                            Me.txtCFnote.Focus()
                            Me.txtCFnote.BackColor = Color.OrangeRed
                            Exit Sub
                        End If

                        If MessageBox.Show("คุณแน่ใจว่าจะบันทึกข้อมูลนี้", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            strSQLite = "INSERT INTO claims_cache(claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,price_buy,price_wholesale," _
                                & "price_technician,price_loyal,price_members,type,unit,datetime_sale,employee_sale,symptom,accressory,note,status," _
                                & "employee,datetime_save,claims_id_pic) " _
                                        & " VALUES(@claims_id,@customer_id,@serial_pro,@code_pro,@bar_code,@name_pro,@price_buy,@price_wholesale," _
                                        & "@price_technician,@price_loyal,@price_members,@type,@unit,@datetime_sale,@employee_sale,@symptom," _
                                        & "@accressory,@note,@status,@employee,@datetime_save,@claims_id_pic)"
                            cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                            With cmdSQLite
                                .Parameters.Add(New SQLiteParameter("@claims_id", claims_autonum))
                                .Parameters.Add(New SQLiteParameter("@customer_id", Me.txtCFcustomer_id.Text))
                                .Parameters.Add(New SQLiteParameter("@serial_pro", Me.txtCFserial_pro.Text))
                                .Parameters.Add(New SQLiteParameter("@code_pro", Me.txtCFcode_pro.Text))
                                .Parameters.Add(New SQLiteParameter("@bar_code", Me.txtCFbar_code.Text))
                                .Parameters.Add(New SQLiteParameter("@name_pro", Me.txtCFname_pro.Text))
                                .Parameters.Add(New SQLiteParameter("@price_buy", Me.txtCFprice_buy.Text))
                                .Parameters.Add(New SQLiteParameter("@price_wholesale", Me.txtCFprice_wholsale.Text))
                                .Parameters.Add(New SQLiteParameter("@price_technician", Me.txtCFprice_technician.Text))
                                .Parameters.Add(New SQLiteParameter("@price_loyal", Me.txtCFprice_loyal.Text))
                                .Parameters.Add(New SQLiteParameter("@price_members", Me.txtCFprice_members.Text))
                                .Parameters.Add(New SQLiteParameter("@type", Me.txtCFtype.Text))
                                .Parameters.Add(New SQLiteParameter("@unit", Me.txtCFunit.Text))
                                .Parameters.Add(New SQLiteParameter("@datetime_sale", Me.txtCFdatetime_sale.Text))
                                .Parameters.Add(New SQLiteParameter("@employee_sale", Me.txtCFemployee_sale.Text))
                                .Parameters.Add(New SQLiteParameter("@symptom", Me.txtCFsyptom.Text))
                                .Parameters.Add(New SQLiteParameter("@accressory", Me.txtCFaccessory.Text))
                                .Parameters.Add(New SQLiteParameter("@note", Me.txtCFnote.Text))
                                .Parameters.Add(New SQLiteParameter("@status", "รับเข้าระบบ"))
                                .Parameters.Add(New SQLiteParameter("@employee", Me.lblEmployee.Text))
                                .Parameters.Add(New SQLiteParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss",
                                                                                                            CultureInfo.CreateSpecificCulture("en-US"))))

                                cmdSQLite.Parameters.AddWithValue("@claims_id_pic", Nothing)
                                Call open_connectionSQLite()
                                cmdSQLite.ExecuteNonQuery()

                            End With
                            Call loadDataCache()
                        End If
                    End If
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Call startFrm()
            desposit = Nothing
            Me.txtCFsearchSN.Focus()
        End If
    End Sub

    Private Sub loadDataCache()
        Try
            Me.dgClaims.Rows.Clear()
            strSQLite = "SELECT claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,price_buy,price_wholesale,price_technician," _
                & "price_loyal,price_members,type,unit,symptom,accressory,employee,datetime_save FROM claims_cache"
            cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
            Call open_connectionSQLite()
            DrSQLite = cmdSQLite.ExecuteReader
            Dim r As Integer
            While (DrSQLite.Read())
                With Me.dgClaims
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = r + 1
                    .Rows(r).Cells(1).Value = DrSQLite.Item("claims_id")
                    .Rows(r).Cells(2).Value = DrSQLite.Item("customer_id")
                    .Rows(r).Cells(3).Value = DrSQLite.Item("serial_pro")
                    .Rows(r).Cells(4).Value = DrSQLite.Item("code_pro")
                    .Rows(r).Cells(5).Value = DrSQLite.Item("bar_code")
                    .Rows(r).Cells(6).Value = DrSQLite.Item("name_pro")
                    .Rows(r).Cells(7).Value = DrSQLite.Item("price_buy")
                    .Rows(r).Cells(8).Value = DrSQLite.Item("price_wholesale")
                    .Rows(r).Cells(9).Value = DrSQLite.Item("price_technician")
                    .Rows(r).Cells(10).Value = DrSQLite.Item("price_loyal")
                    .Rows(r).Cells(11).Value = DrSQLite.Item("price_members")
                    .Rows(r).Cells(12).Value = DrSQLite.Item("type")
                    .Rows(r).Cells(13).Value = DrSQLite.Item("unit")
                    .Rows(r).Cells(14).Value = DrSQLite.Item("symptom")
                    .Rows(r).Cells(15).Value = DrSQLite.Item("accressory")
                    .Rows(r).Cells(16).Value = DrSQLite.Item("employee")
                    .Rows(r).Cells(17).Value = DrSQLite.Item("datetime_save")
                End With
            End While
            Me.dgClaims.ClearSelection()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Private Sub txtCFsyptom_Click(sender As Object, e As EventArgs) Handles txtCFsyptom.Click
        Me.txtCFsyptom.BackColor = SystemColors.Window
    End Sub

    Private Sub txtCFaccessory_Click(sender As Object, e As EventArgs) Handles txtCFaccessory.Click
        Me.txtCFaccessory.BackColor = SystemColors.Window
    End Sub

    Private Sub txtCFnote_Click(sender As Object, e As EventArgs) Handles txtCFnote.Click
        Me.txtCFnote.BackColor = SystemColors.Window
    End Sub

    Private Sub btnCFsearchSN_Click_1(sender As Object, e As EventArgs) Handles btnCFsearchSN.Click
        Call getdataSN()
    End Sub

    Private Sub btnCchangCustomer_Click_1(sender As Object, e As EventArgs) Handles btnCchangCustomer.Click
        Me.txtCFcustomer_name.BackColor = SystemColors.Control
        Me.txtCFcustomer_id.BackColor = SystemColors.Control
        If Me.txtCFserial_pro.Text = "" Then
            If desposit = 100 Then
                MsgBox("ใส่ SN สินค้าก่อน", MsgBoxStyle.Information, "แจ้งเตือน")
            Else
                Exit Sub
            End If
        Else
            If Me.txtCFcustomer_id.Text = "สินค้าจากสต็อก" Then
                MessageBox.Show(Me, "สินค้าจากสต็อกเปลี่ยนเป็นชื่ออื่นไม่ได้", "ห้ามเปลี่ยน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                SearchCustomerFrm.btnSendtoSavedatafix.Text = "เลือกไปหน้าเคลมสินค้า"
                SearchCustomerFrm.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub btnCFloadaccessory_Click_1(sender As Object, e As EventArgs) Handles btnCFloadaccessory.Click
        accessoryClaimsFrm.ShowDialog(Me)
    End Sub

    Private Sub btnCFcancel_Click_1(sender As Object, e As EventArgs) Handles btnCFcancel.Click
        Call startFrm()
    End Sub
    Dim desposit As Integer
    Private Sub btnCdepositClaims_Click(sender As Object, e As EventArgs) Handles btnCdepositClaims.Click
        desposit = 100
        Me.txtCFsearchSN.ReadOnly = True
        Me.btnCFsearchSN.Enabled = False
        Me.txtCFserial_pro.ReadOnly = False
        Me.txtCFcode_pro.ReadOnly = False
        Me.txtCFbar_code.Text = "ฝากเคลม"
        Me.txtCFname_pro.ReadOnly = False
        Me.txtCFprice_buy.ReadOnly = False
        Me.txtCFtype.Text = "-"
        Me.txtCFunit.ReadOnly = False
        Me.txtCFdatetime_sale.Text = "-"
        Me.txtCFemployee_sale.Text = "-"
        Me.txtCFsyptom.Enabled = True
        Me.txtCFaccessory.Enabled = True
        Me.txtCFnote.Enabled = True
        Me.btnCFsave.Enabled = True
        Me.btnCFcancel.Enabled = True
    End Sub

    Private Sub btnClaimsAll_Click(sender As Object, e As EventArgs) Handles btnClaimsAll.Click
        Call saveAllData()
    End Sub

    Private Sub txtCFname_pro_Click(sender As Object, e As EventArgs)
        If desposit = 100 Then
            Me.txtCFname_pro.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub txtCFprice_buy_Click(sender As Object, e As EventArgs)
        If desposit = 100 Then
            Me.txtCFprice_buy.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub txtCFunit_Click(sender As Object, e As EventArgs)
        If desposit = 100 Then
            Me.txtCFunit.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub btnCRefresh_Click(sender As Object, e As EventArgs) Handles btnCRefresh.Click
        Call loadDataCache()
    End Sub
    Dim oldData As Object
    Private Sub dgClaims_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgClaims.CellDoubleClick
        Me.dgClaims.ReadOnly = False
        oldData = Me.dgClaims.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub

    Private Sub dgClaims_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgClaims.CellEndEdit
        Me.dgClaims.CurrentRow.Cells(e.ColumnIndex).Value = oldData
        Me.dgClaims.ReadOnly = True
    End Sub

    Private Sub dgClaims_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgClaims.CellMouseClick
        If dgClaims.RowCount <> 0 Then
            If e.Button = MouseButtons.Right Then
                Me.dgClaims.Rows(e.RowIndex).Selected = True
                Me.dgClaims.CurrentCell = Me.dgClaims.Rows(e.RowIndex).Cells(0)
                Me.DelDgContextMenu.Show(Me.dgClaims, e.Location)
                Me.DelDgContextMenu.Show(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub dgClaims_KeyDown(sender As Object, e As KeyEventArgs) Handles dgClaims.KeyDown
        If e.KeyCode = Keys.Delete Then
            If MessageBox.Show(Me, "คุณแน่ใจว่าจะลบข้อมูลนี้", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                strSQLite = "DELETE FROM claims_cache WHERE claims_id='" & Me.dgClaims.SelectedCells.Item(1).Value & "'"
                cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                Call open_connectionSQLite()
                cmdSQLite.ExecuteNonQuery()
                Dim a As Integer = Me.dgClaims.SelectedRows.Count - 1
                Me.dgClaims.Rows.Remove(Me.dgClaims.SelectedRows(a))
                Me.dgClaims.Refresh()
            End If
        End If
    End Sub

    Private Sub dgClaims_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgClaims.RowStateChanged
        If Me.dgClaims.Rows.Count = 0 Then
            Me.btnClaimsAll.Enabled = False
        Else
            Me.btnClaimsAll.Enabled = True
        End If
    End Sub

    Private Sub txtCFserial_pro_TextChanged(sender As Object, e As EventArgs) Handles txtCFserial_pro.TextChanged
        If Me.txtCFserial_pro.Text <> Nothing Then
            Me.txtCFsyptom.Enabled = True
            Me.txtCFaccessory.Enabled = True
            Me.txtCFnote.Enabled = True
            Me.btnCFsave.Enabled = True
            Me.btnCFcancel.Enabled = True
            If Me.txtCFaccessory.Enabled = True Then
                Me.btnCFloadaccessory.Enabled = True
            End If
        ElseIf Me.txtCFserial_pro.Text = Nothing Then
            Me.txtCFsyptom.Enabled = False
            Me.txtCFaccessory.Enabled = False
            Me.txtCFnote.Enabled = False
            Me.btnCFsave.Enabled = False
            Me.btnCFcancel.Enabled = False
            If Me.txtCFaccessory.Enabled = False Then
                Me.btnCFloadaccessory.Enabled = False
            End If
        End If
    End Sub

    Private Sub txtCFcustomer_id_TextChanged(sender As Object, e As EventArgs) Handles txtCFcustomer_id.TextChanged
        If Me.txtCFcustomer_id.Text = "สินค้าจากสต็อก" Then
            Me.btnCdepositClaims.Enabled = False
        Else
            Me.btnCdepositClaims.Enabled = True
        End If
    End Sub


    Private Sub DelToolStripMenu_Click(sender As Object, e As EventArgs) Handles DelToolStripMenu.Click
        If MessageBox.Show(Me, "คุณแน่ใจว่าจะลบข้อมูลนี้", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            strSQLite = "DELETE FROM claims_cache WHERE claims_id='" & Me.dgClaims.SelectedCells.Item(1).Value & "'"
            cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
            Call open_connectionSQLite()
            cmdSQLite.ExecuteNonQuery()
            Dim a As Integer = Me.dgClaims.SelectedRows.Count - 1
            Me.dgClaims.Rows.Remove(Me.dgClaims.SelectedRows(a))
            Me.dgClaims.Refresh()
        End If
    End Sub

    Private Sub ClearToolStripMenu_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenu.Click
        If MessageBox.Show(Me, "คุณแน่ใจว่าจะลบข้อมูลทั้งหมด", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                cmdSQLite = New SQLiteCommand("DELETE FROM claims_cache", connSQLite)
                Call open_connectionSQLite()
                cmdSQLite.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Call startFrm()
            Call loadDataCache()
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/claims/claimsfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class