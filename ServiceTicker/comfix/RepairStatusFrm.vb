Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.IO

Public Class RepairStatusFrm

#Region "Code"
    Dim comfigsend As Integer
    Friend Sub getStatusAll()
        Try
            cmd = New MySqlCommand("SELECT COUNT(status) FROM comfix WHERE status='1 รอซ่อม';", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Me.btnRSstatus1.Text = "รอซ่อม (" & Dr(0).ToString & ")"
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Try
            cmd = New MySqlCommand("SELECT COUNT(status) FROM comfix WHERE status='2 กำลังซ่อม';", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Me.btnRSstatus2.Text = "กำลังซ่อม (" & Dr(0).ToString & ")"
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            cmd = New MySqlCommand("SELECT COUNT(status) FROM comfix WHERE status='3 รออะไหล่/ส่งเคลม';", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Me.btnRSstatus3.Text = "รออะไหล่/ส่งเคลม (" & Dr(0).ToString & ")"
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            cmd = New MySqlCommand("SELECT COUNT(status) FROM comfix WHERE status='4 ซ่อมไม่ได้';", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Me.btnRSstatus4.Text = "ซ่อมไม่ได้ (" & Dr(0).ToString & ")"
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            cmd = New MySqlCommand("SELECT COUNT(status) FROM comfix WHERE status='5 ซ่อมเสร็จ';", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Me.btnRSstatus5.Text = "ซ่อมเสร็จ (" & Dr(0).ToString & ")"
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Try
            cmd = New MySqlCommand("SELECT COUNT(status) FROM comfix WHERE status='6 ยกเลิกซ่อม';", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Me.btnRSstatus6.Text = "ยกเลิกซ่อม (" & Dr(0).ToString & ")"
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Try
            cmd = New MySqlCommand("SELECT COUNT(status) FROM comfix WHERE status='7 คืนเครื่องแล้ว';", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Me.btnRSstatus7.Text = "คืนเครื่อง (" & Dr(0).ToString & ")"
            comfigsend = Dr.Item(0)
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub getdatacombobox_repair_status()
        Me.cbbRSstatus.Items.Clear()
        cmd = New MySqlCommand("SELECT status FROM repair_status;", ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbbRSstatus.Items.Add(Dr.GetString("status"))
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Private Sub getdatacombobox_fix_user()
        Me.cbbRSuser_repair.Items.Clear()
        cmd = New MySqlCommand("SELECT user_name FROM users;", ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbbRSuser_repair.Items.Add(Dr.GetString("user_name"))
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Private Sub getdatacombobox_varuntee()
        Me.cbbRSvaruntee.Items.Clear()
        cmd = New MySqlCommand("SELECT varuntee_status FROM varuntee;", ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbbRSvaruntee.Items.Add(Dr("varuntee_status"))
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Private Sub GetDataStorag()

        Me.cbbRSstorage.Items.Clear()
        cmd = New MySqlCommand("SELECT `s` FROM `shelf` ORDER BY `s` ASC;", ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Me.cbbRSstorage.Items.Add(Dr.GetString("s"))
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    ''' <summary>
    ''' โหลดข้อมูลงานซ่อมตามสถานะ (10=1 รอซ่อม), (20=2 กำลังซ่อม), (30=3 รออะไหล่/ส่งเคลม), (40=4 ซ่อมไม่ได้), (50=5 ซ่อมเสร็จ), (60=6 ยกเลิกซ่อม),
    '''  (70=7 คืนเครื่องแล้ว), (80=โหลดข้อมูลเพิ่มเติม)  strSelect As Integer
    ''' </summary>
    ''' <param name="strSelect">strSelect As Integer</param>
    ''' <remarks></remarks>
    Private Sub getdata_dgRSstatus1(ByVal strSelect As Integer)
        If strSelect = 10 Then
            Me.ListView1.Clear()
            Me.dgRSstatus1.Rows.Clear()
            strSQL = "SELECT `id`,fix_id,claims_id,date_save,customer_id,sn,symptom,managerdata,fixrepairnote,fixaccessory,fixnote,fixtprice," _
                     & "varuntee,date_get,fixuser,status,user_repair,note_repair,teltocus,datecom_repair,importune,storage " _
                     & "FROM comfix WHERE status='1 รอซ่อม';"
        ElseIf strSelect = 20 Then
            Me.ListView1.Clear()
            Me.dgRSstatus1.Rows.Clear()
            strSQL = "SELECT `id`,fix_id,claims_id,date_save,customer_id,sn,symptom,managerdata,fixrepairnote,fixaccessory,fixnote,fixtprice," _
                   & "varuntee,date_get,fixuser,status,user_repair,note_repair,teltocus,datecom_repair,importune,storage " _
                   & "FROM comfix WHERE status='2 กำลังซ่อม';"
        ElseIf strSelect = 30 Then
            Me.ListView1.Clear()
            Me.dgRSstatus1.Rows.Clear()
            strSQL = "SELECT `id`,fix_id,claims_id,date_save,customer_id,sn,symptom,managerdata,fixrepairnote,fixaccessory,fixnote,fixtprice," _
                   & "varuntee,date_get,fixuser,status,user_repair,note_repair,teltocus,datecom_repair,importune,storage " _
                   & "FROM comfix WHERE status='3 รออะไหล่/ส่งเคลม';"
        ElseIf strSelect = 40 Then
            Me.ListView1.Clear()
            Me.dgRSstatus1.Rows.Clear()
            strSQL = "SELECT `id`,fix_id,claims_id,date_save,customer_id,sn,symptom,managerdata,fixrepairnote,fixaccessory,fixnote,fixtprice," _
                   & "varuntee,date_get,fixuser,status,user_repair,note_repair,teltocus,datecom_repair,importune,storage " _
                   & "FROM comfix WHERE status='4 ซ่อมไม่ได้';"
        ElseIf strSelect = 50 Then
            Me.ListView1.Clear()
            Me.dgRSstatus1.Rows.Clear()
            strSQL = "SELECT `id`,fix_id,claims_id,date_save,customer_id,sn,symptom,managerdata,fixrepairnote,fixaccessory,fixnote,fixtprice," _
                   & "varuntee,date_get,fixuser,status,user_repair,note_repair,teltocus,datecom_repair,importune,storage " _
                   & "FROM comfix WHERE status='5 ซ่อมเสร็จ';"
        ElseIf strSelect = 60 Then
            Me.ListView1.Clear()
            Me.dgRSstatus1.Rows.Clear()
            strSQL = "SELECT `id`,fix_id,claims_id,date_save,customer_id,sn,symptom,managerdata,fixrepairnote,fixaccessory,fixnote,fixtprice," _
                   & "varuntee,date_get,fixuser,status,user_repair,note_repair,teltocus,datecom_repair,importune,storage " _
                   & "FROM comfix WHERE status='6 ยกเลิกซ่อม';"
        ElseIf strSelect = 70 Then
            Me.ListView1.Clear()
            Me.dgRSstatus1.Rows.Clear()
            strSQL = "SELECT `id`,fix_id,claims_id,date_save,customer_id,sn,symptom,managerdata,fixrepairnote,fixaccessory,fixnote,fixtprice," _
                   & "varuntee,date_get,fixuser,status,user_repair,note_repair,teltocus,datecom_repair,importune,storage " _
                   & "FROM comfix WHERE status='7 คืนเครื่องแล้ว' LIMIT " & Me.NumericUpDown1.Value & ";"
        ElseIf strSelect = 80 Then
            Me.ListView1.Clear()
            strSQL = "SELECT `id`,fix_id,claims_id,date_save,customer_id,sn,symptom,managerdata,fixrepairnote,fixaccessory,fixnote,fixtprice," _
                   & "varuntee,date_get,fixuser,status,user_repair,note_repair,teltocus,datecom_repair,importune,storage " _
                   & "FROM comfix WHERE status='7 คืนเครื่องแล้ว' AND `id` > '" & Me.dgRSstatus1.Rows(Me.dgRSstatus1.Rows.Count - 1).Cells(0).Tag & "' LIMIT " & Me.NumericUpDown1.Value & ";"
        End If
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Dim rs As Integer
                With Me.dgRSstatus1
                    rs = .RowCount
                    .Rows.Add()
                    .Rows(rs).Cells(0).Value = rs + 1
                    .Rows(rs).Cells(0).Tag = Dr.Item("id")
                    .Rows(rs).Cells(1).Value = Dr.Item("fix_id")
                    .Rows(rs).Cells(1).Tag = Dr.Item("claims_id")
                    .Rows(rs).Cells(2).Value = Dr.Item("date_save")
                    .Rows(rs).Cells(3).Value = Dr.Item("customer_id")
                    .Rows(rs).Cells(5).Value = Dr.Item("sn")
                    .Rows(rs).Cells(9).Value = Dr.Item("symptom")
                    .Rows(rs).Cells(10).Value = Dr.Item("managerdata")
                    .Rows(rs).Cells(11).Value = Dr.Item("fixrepairnote")
                    .Rows(rs).Cells(12).Value = Dr.Item("fixaccessory")
                    .Rows(rs).Cells(13).Value = Dr.Item("fixnote")
                    .Rows(rs).Cells(14).Value = Dr.Item("fixtprice")
                    .Rows(rs).Cells(15).Value = Dr.Item("date_get")
                    .Rows(rs).Cells(16).Value = Dr.Item("fixuser")
                    .Rows(rs).Cells(17).Value = Dr.Item("status")
                    .Rows(rs).Cells(18).Value = Dr.Item("user_repair")
                    .Rows(rs).Cells(19).Value = Dr.Item("note_repair")
                    .Rows(rs).Cells(20).Value = Dr.Item("teltocus")
                    .Rows(rs).Cells(21).Value = Dr.Item("datecom_repair")
                    .Rows(rs).Cells(22).Value = Dr.Item("importune")
                    .Rows(rs).Cells(23).Value = Dr.Item("storage")
                    .Rows(rs).Cells(24).Value = Dr.Item("varuntee")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        For ro As Integer = 0 To Me.dgRSstatus1.Rows.Count - 1
            Try
                cmd = New MySqlCommand("SELECT customer_name FROM customer WHERE customer_id='" & Me.dgRSstatus1.Rows(ro).Cells(3).Value & "';", ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                If Dr.HasRows Then
                    Dr.Read()
                    With Me.dgRSstatus1
                        .Rows(ro).Cells(4).Value = Dr.Item("customer_name")
                    End With
                Else
                    Me.dgRSstatus1.Rows(ro).Cells(4).Value = "##ไม่พบข้อมูล##"
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Try
                cmd = New MySqlCommand("SELECT p_type,p_name,model FROM `sn` WHERE Snum='" & Me.dgRSstatus1.Rows(ro).Cells(5).Value & "';", ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                If Dr.HasRows Then
                    Dr.Read()
                    With Me.dgRSstatus1
                        .Rows(ro).Cells(6).Value = Dr.GetString("p_type")
                        .Rows(ro).Cells(7).Value = Dr.GetString("p_name")
                        .Rows(ro).Cells(8).Value = Dr.GetString("model")
                    End With
                Else
                    Me.dgRSstatus1.Rows(ro).Cells(6).Value = "##ไม่พบข้อมูล##"
                    Me.dgRSstatus1.Rows(ro).Cells(7).Value = "##ไม่พบข้อมูล##"
                    Me.dgRSstatus1.Rows(ro).Cells(8).Value = "##ไม่พบข้อมูล##"
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next
        Call Imp()
    End Sub

    Private Sub Imp()
        If Me.dgRSstatus1.Rows.Count <> 0 Then
            Me.dgRSstatus1.ClearSelection()
            For i As Integer = 0 To dgRSstatus1.Rows.Count - 1
                If Me.dgRSstatus1.Rows(i).Cells(22).Value = "เร่งด่วน" Then
                    Me.dgRSstatus1.Rows(i).DefaultCellStyle.BackColor = Color.Salmon
                End If
            Next
        End If
    End Sub

    Private Sub startfrm()
        Call getStatusAll()
        Me.cbbRSstatus.Enabled = False
        Me.cbbRSuser_repair.Enabled = False
        Me.cbbRSteltocus.Enabled = False
        Me.btnRSPartsWithdrawal.Enabled = False
        Me.cbbRSvaruntee.Enabled = False
        Me.btnRSviewProduct.Enabled = False
        Me.btnRSsave.Enabled = False
        'Me.txtRSnote_repair.Enabled = False
        Me.cbbRSstorage.Enabled = False
        Me.btnRSsend_to_claims.Visible = False
        Me.btnSRsendRepair.Visible = False
        'Me.txtRSnote_repair.Text = "-"
        Me.cbbRSstatus.Text = Nothing
        Me.cbbRSuser_repair.Text = Nothing
        Me.cbbRSvaruntee.Text = Nothing
        Me.cbbRSteltocus.Text = Nothing
        Me.cbbRSstorage.Text = Nothing
        Me.txtRSfix_id.Clear()
        Me.txtRScus_id.Clear()
        Me.txtRScus_name.Clear()
        Me.txtRScus_tel.Clear()
        Me.txtSN.Clear()
        Me.dgRSstatus1.Refresh()
        Me.btnRSsend_to_claims.Enabled = False
        Me.lblRSsaleDetail.Text = "Sale Detail"
        Me.btnSRsendRepair.Visible = False
        Me.lblAddNoteRapair.Visible = False
        Me.ListView1.Clear()
        Me.ListView_note.Clear()
        Me.btnAddPic.Enabled = False
        Me.lblSendFix.Visible = False
        Me.NumericUpDown1.Visible = False
        Me.DelPicToolStripMenu.Enabled = True
        Me.btnForward.Visible = False
        Call Imp()
    End Sub

    ''' <summary>
    ''' โหลดข้อมูลตามสถานะปุ่มที่เปลี่ยนสีพื้นหลังเป็น  Color.BlueViolet
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub StartFrmByStatus()
        Call startfrm()
        If Me.btnRSstatus1.BackColor = Color.BlueViolet Then
            Call getdata_dgRSstatus1(10)
        ElseIf Me.btnRSstatus2.BackColor = Color.BlueViolet Then
            Call getdata_dgRSstatus1(20)
        ElseIf Me.btnRSstatus3.BackColor = Color.BlueViolet Then
            Call getdata_dgRSstatus1(30)
        ElseIf Me.btnRSstatus4.BackColor = Color.BlueViolet Then
            Call getdata_dgRSstatus1(40)
        ElseIf Me.btnRSstatus5.BackColor = Color.BlueViolet Then
            Call getdata_dgRSstatus1(50)
        ElseIf Me.btnRSstatus6.BackColor = Color.BlueViolet Then
            Call getdata_dgRSstatus1(60)
        End If
    End Sub

    Friend Sub loadCurrentStatus()
        Call startfrm()
        If Me.btnRSstatus1.BackColor = Color.BlueViolet Then
            Call getdata_dgRSstatus1(10)
        ElseIf Me.btnRSstatus2.BackColor = Color.BlueViolet Then
            Call getdata_dgRSstatus1(20)
        ElseIf Me.btnRSstatus3.BackColor = Color.BlueViolet Then
            Call getdata_dgRSstatus1(30)
        ElseIf Me.btnRSstatus4.BackColor = Color.BlueViolet Then
            Call getdata_dgRSstatus1(40)
        ElseIf Me.btnRSstatus5.BackColor = Color.BlueViolet Then
            Call getdata_dgRSstatus1(50)
        ElseIf Me.btnRSstatus6.BackColor = Color.BlueViolet Then
            Call getdata_dgRSstatus1(60)
        ElseIf Me.btnRSstatus7.BackColor = Color.BlueViolet Then
            Call getdata_dgRSstatus1(70)
        End If
    End Sub
    'Friend Sub reLoadFrm()
    '    Call startfrm()
    '    Me.Icon = MainFrm.Icon
    '    Call getdata_dgRSstatus1(10)
    '    Me.lblStatusText.Text = "กำลังอยู่ที่สถานะรอซ่อม"
    '    Me.btnRSstatus1.BackColor = Color.BlueViolet
    '    Me.btnRSstatus2.BackColor = Color.Azure
    '    Me.btnRSstatus3.BackColor = Color.Azure
    '    Me.btnRSstatus4.BackColor = Color.Azure
    '    Me.btnRSstatus5.BackColor = Color.Azure
    '    Me.btnRSstatus6.BackColor = Color.Azure
    '    Me.btnRSstatus7.BackColor = Color.Azure

    '    Me.btnRSstatus1.ForeColor = Color.White
    '    Me.btnRSstatus2.ForeColor = Color.Black
    '    Me.btnRSstatus3.ForeColor = Color.Black
    '    Me.btnRSstatus4.ForeColor = Color.Black
    '    Me.btnRSstatus5.ForeColor = Color.Black
    '    Me.btnRSstatus6.ForeColor = Color.Black
    '    Me.btnRSstatus7.ForeColor = Color.Black
    'End Sub

    Private Sub showmeUnderDataGrid()
        Try
            Me.txtRSfix_id.Text = Me.dgRSstatus1.CurrentRow.Cells(1).Value
            Me.txtRScus_id.Text = Me.dgRSstatus1.CurrentRow.Cells(3).Value
            Me.txtRScus_name.Text = Me.dgRSstatus1.CurrentRow.Cells(4).Value
            Me.txtSN.Text = Me.dgRSstatus1.CurrentRow.Cells(5).Value
            Me.cbbRSstatus.Text = Me.dgRSstatus1.CurrentRow.Cells(17).Value
            Me.cbbRSuser_repair.Text = Me.dgRSstatus1.CurrentRow.Cells(18).Value
            Me.cbbRSvaruntee.Text = Me.dgRSstatus1.CurrentRow.Cells(24).Value
            Me.cbbRSstorage.Text = Me.dgRSstatus1.CurrentRow.Cells(23).Value
            'Me.txtRSnote_repair.Text = Me.dgRSstatus1.CurrentRow.Cells(19).Value
            Me.cbbRSteltocus.Text = Me.dgRSstatus1.CurrentRow.Cells(20).Value
            Me.btnRSPartsWithdrawal.Enabled = True
        Catch ex As Exception

        End Try
    End Sub
    ''' <summary>
    ''' SUM ผลรวม ยอดค่าใช้จ่าย เบิก มัดจำ จำนวนบิลที่มี
    ''' </summary>
    ''' <remarks></remarks>
    Friend Sub get_sale_id()
        Dim sumTTA As Decimal
        Dim cusidff As Decimal
        Dim countpd As Decimal
        Dim countTTA As Decimal

        Dim fixid As String = Me.txtRSfix_id.Text

        cmd = New MySqlCommand("SELECT SUM(total_all) AS ttl FROM sale WHERE fix_id='" & fixid & "';", ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader
            Dr.Read()
            sumTTA = Dr.GetDecimal("ttl")
        Catch ex As Exception
            'MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            sumTTA = 0
        End Try


        cmd = New MySqlCommand("SELECT COUNT(fix_id) AS fid FROM sale WHERE fix_id='" & fixid & "';", ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader
            Dr.Read()
            countTTA = Dr.GetDecimal("fid")
            Dr.Close()
        Catch ex As Exception
            'MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            countTTA = 0
        End Try


        cmd = New MySqlCommand("SELECT SUM(total1) AS tt1 FROM pledge_sale WHERE customer_id='" & Me.txtRScus_id.Text & "';", ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader
            Dr.Read()
            cusidff = Dr.GetDecimal("tt1")
        Catch ex As Exception
            'MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            cusidff = 0
        End Try

        cmd = New MySqlCommand("SELECT COUNT(customer_id) AS cid FROM pledge_sale WHERE customer_id='" & Me.txtRScus_id.Text & "';", ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader
            Dr.Read()
            countpd = Dr.GetDecimal("cid")
        Catch ex As Exception
            'MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            countpd = 0
        End Try

        If Me.dgRSstatus1.CurrentRow.Cells.Item(17).Value = "7 คืนเครื่องแล้ว" Then
            Me.lblRSsaleDetail.Text = "คืนเครื่องแล้ว"
        Else
            Me.lblRSsaleDetail.Text = "พบรายการใบเบิกจำนวน " & countTTA & " ใบ " & vbNewLine & "รวมราคาทั้งหมด " & sumTTA.ToString("N2") & " บาท" & vbNewLine & _
                                        "พบใบมัดจำ/ลดหนี้ จำนวน " & countpd & " ใบ " & " รวมราคา " & cusidff.ToString("N2") & " บาท"
        End If
    End Sub
    ''' <summary>
    ''' โหลดข้อมูลรูปจากฐานข้อมูล SELECT pa_id,byte_pic,note_pic,datetime_save FROM picture_all WHERE key_pic=@key_pic"
    ''' </summary>
    ''' <param name="key_pic">WHERE key_pic=</param>
    ''' <remarks></remarks>
    Friend Sub LoadPictureList(ByVal key_pic As String)
        Me.ListView1.Clear()
        Dim imglist As New ImageList
        imglist.ColorDepth = ColorDepth.Depth32Bit
        ListView1.LargeImageList = imglist
        ListView1.LargeImageList.ImageSize = New System.Drawing.Size(80, 80)
        Try
            cmd = New MySqlCommand("SELECT pa_id,byte_pic,note_pic,datetime_save FROM picture_all " _
                                   & "WHERE key_pic='" & key_pic & "' AND del='no' ORDER BY datetime_save;", ConnectionDB)
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

    Private Sub claimss()
        If Me.dgRSstatus1.Rows.Count = 0 Then
            Me.lblRSclaims.Text = ""
        Else
            If Me.dgRSstatus1.CurrentRow.Cells(11).Value = "ส่งมาจากงานเคลม" Then
                Me.lblRSclaims.Text = "สินค้าจากงานเคลม"
                Timer1.Start()
            Else
                Me.lblRSclaims.Text = ""
            End If
        End If
    End Sub
    ''' <summary>
    ''' บันทึกผลที่ทำการเปลี่ยนแปลงในงานซ่อม
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub updateDataStatus_dgRSstatus1()
        If Me.cbbRSstatus.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาระบุสถานะ", "ตรวจสอบการกรอกข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.cbbRSstatus.Focus()
            Me.cbbRSstatus.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.cbbRSuser_repair.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาระบุช่างซ่อม", "ตรวจสอบการกรอกข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.cbbRSuser_repair.Focus()
            Me.cbbRSuser_repair.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.cbbRSteltocus.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาระบุการแจ้งลูกค้า", "ตรวจสอบการกรอกข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.cbbRSteltocus.Focus()
            Me.cbbRSteltocus.BackColor = Color.Salmon
            Exit Sub
        End If

        If Me.cbbRSvaruntee.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาระบุการรับประกัน", "ตรวจสอบการกรอกข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.cbbRSvaruntee.Focus()
            Me.cbbRSvaruntee.BackColor = Color.Salmon
            Exit Sub
        End If
        'If Me.txtRSnote_repair.Text = Nothing Then
        '    MessageBox.Show(Me, "กรุณาใส่รายละเอียดการซ่อม หากไม่มีให้ใส่ - ", "ตรวจสอบการกรอกข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Me.txtRSnote_repair.Focus()
        '    Me.txtRSnote_repair.BackColor = Color.Salmon
        '    Exit Sub
        'End If
        If Me.cbbRSstorage.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่สถานที่เก็บ หากไม่มีให้ใส่ - ", "ตรวจสอบการกรอกข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.cbbRSstorage.Focus()
            Me.cbbRSstorage.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.cbbRSstatus.Text = "2 กำลังซ่อม" And Me.cbbRSuser_repair.Text = "-" Then
            MessageBox.Show(Me, "กรุณาระบุชื่อผู้ที่ทำการซ่อม", "ตรวจสอบการกรอกข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        If Me.dgRSstatus1.SelectedCells.Item(17).Value = "7 คืนเครื่องแล้ว" Then
            MessageBox.Show(Me, "สถานะคืนเครื่องแล้ว ไม่สามารถบันทึกข้อมูลได้อีก นอกจากรับเข้าระบบใหม่", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim Csave As Object = MessageBox.Show(Me, "ต้องการบันทึก Yes=บันทึก, No=ยังไม่บันทึก, Cancel=ยกเลิกการแก้ไข", "ยืนยัน", _
                               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If Csave = Windows.Forms.DialogResult.Cancel Then
                Call startfrm()
                MessageBox.Show(Me, "การบันทึกข้อมูลถูกยกเลิก", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Csave = Windows.Forms.DialogResult.No Then
                Exit Sub
            ElseIf Csave = Windows.Forms.DialogResult.Yes Then
                If Me.dgRSstatus1.CurrentRow.Cells(13).Value = "ส่งมาจากงานเคลม" Then
                    Dim cl_id As String = Me.dgRSstatus1.CurrentRow.Cells(1).Tag
                    Try
                        strSQL = "UPDATE claims SET note='" & Me.ListView_note.Items(0).Text & "', datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "'" _
                            & "WHERE claims_id='" & cl_id & "';"
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try

                    strSQL = "UPDATE comfix SET status = '" & Me.cbbRSstatus.Text & "', user_repair='" & Me.cbbRSuser_repair.Text & "', " _
                        & "varuntee='" & Me.cbbRSvaruntee.Text & "', teltocus='" & Me.cbbRSteltocus.Text & "', storage='" & Me.cbbRSstorage.Text & "', " _
                        & "datecom_repair='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "' WHERE fix_id= '" & Me.txtRSfix_id.Text & "';"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Try
                        Dim saveCom As Integer
                        saveCom = cmd.ExecuteNonQuery()
                        If saveCom = 1 Then
                            cl_id = Nothing
                            Call startfrm()
                            MessageBox.Show(Me, "บันทึกข้อมูลเรียบร้อยแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show(Me, "บันทึกข้อมูลไม่ได้", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                Else

                    strSQL = "UPDATE comfix SET status = '" & Me.cbbRSstatus.Text & "', user_repair='" & Me.cbbRSuser_repair.Text & "', " _
                        & "varuntee='" & Me.cbbRSvaruntee.Text & "', teltocus='" & Me.cbbRSteltocus.Text & "', storage='" & Me.cbbRSstorage.Text & "', " _
                        & "datecom_repair='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "' WHERE fix_id= '" & Me.txtRSfix_id.Text & "';"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Try
                        Dim saveCom As Integer
                        saveCom = cmd.ExecuteNonQuery()
                        If saveCom <> 0 Then
                            Call StartFrmByStatus()
                            MessageBox.Show(Me, "บันทึกข้อมูลเรียบร้อยแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show(Me, "บันทึกข้อมูลไม่ได้", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                End If
            End If
        End If
    End Sub
    ''' <summary>
    ''' โหลดข้อมูล comfix_note SELECT note,datetime_save FROM comfix_note 
    ''' </summary>
    ''' <param name="fixid">เลขใบรับซ่อม</param>
    ''' <remarks></remarks>
    Friend Sub GetComfix_note(ByVal fixid)
        Me.ListView_note.Clear()
        Me.ListView_note.Columns.Add("รายละเอียดการซ่อม", 230)
        Me.ListView_note.Columns.Add("วันที่บันทึก", 140)
        Try
            cmd = New MySqlCommand("SELECT note,datetime_save FROM comfix_note WHERE key_note='" & fixid & "' ORDER BY datetime_save DESC;", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read
                Dim nt As String = Dr.Item("note")
                Dim lsvparent As New ListViewItem(nt)
                lsvparent.SubItems.Add(CDate(Dr.Item("datetime_save")).ToString("dd MMMM yyyy HH:mm"))
                ListView_note.Items.Add(lsvparent)
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
#End Region

    Private Sub RepairStatusFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub cbbRSvaruntee_DropDown(sender As Object, e As EventArgs) Handles cbbRSvaruntee.DropDown
        Call getdatacombobox_varuntee()
    End Sub

    Private Sub cbbRSstatus_DropDown(sender As Object, e As EventArgs) Handles cbbRSstatus.DropDown
        Call getdatacombobox_repair_status()
    End Sub

    Private Sub cbbRSstorage_DropDown(sender As Object, e As EventArgs) Handles cbbRSstorage.DropDown
        Call GetDataStorag()
    End Sub

    Private Sub cbbRSuser_repair_DropDown(sender As Object, e As EventArgs) Handles cbbRSuser_repair.DropDown
        Call getdatacombobox_fix_user()
    End Sub

    Private Sub RepairStatusfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'Call getStatusAll()
        Call startfrm()
        Call getdata_dgRSstatus1(10)
        Me.lblStatusText.Text = "กำลังอยู่ที่สถานะรอซ่อม"
        Me.btnRSstatus1.BackColor = Color.BlueViolet
        Me.btnRSstatus2.BackColor = Color.Azure
        Me.btnRSstatus3.BackColor = Color.Azure
        Me.btnRSstatus4.BackColor = Color.Azure
        Me.btnRSstatus5.BackColor = Color.Azure
        Me.btnRSstatus6.BackColor = Color.Azure
        Me.btnRSstatus7.BackColor = Color.Azure

        Me.btnRSstatus1.ForeColor = Color.White
        Me.btnRSstatus2.ForeColor = Color.Black
        Me.btnRSstatus3.ForeColor = Color.Black
        Me.btnRSstatus4.ForeColor = Color.Black
        Me.btnRSstatus5.ForeColor = Color.Black
        Me.btnRSstatus6.ForeColor = Color.Black
        Me.btnRSstatus7.ForeColor = Color.Black
    End Sub

    Private Sub btnRSstatus2_Click(sender As Object, e As EventArgs) Handles btnRSstatus2.Click
        Call startfrm()
        Call getdata_dgRSstatus1(20)
        Me.lblStatusText.Text = "กำลังอยู่ที่สถานะกำลังซ่อม"
        Me.btnRSstatus1.BackColor = Color.Azure
        Me.btnRSstatus2.BackColor = Color.BlueViolet
        Me.btnRSstatus3.BackColor = Color.Azure
        Me.btnRSstatus4.BackColor = Color.Azure
        Me.btnRSstatus5.BackColor = Color.Azure
        Me.btnRSstatus6.BackColor = Color.Azure
        Me.btnRSstatus7.BackColor = Color.Azure

        Me.btnRSstatus1.ForeColor = Color.Black
        Me.btnRSstatus2.ForeColor = Color.White
        Me.btnRSstatus3.ForeColor = Color.Black
        Me.btnRSstatus4.ForeColor = Color.Black
        Me.btnRSstatus5.ForeColor = Color.Black
        Me.btnRSstatus6.ForeColor = Color.Black
        Me.btnRSstatus7.ForeColor = Color.Black

        Call Imp()
    End Sub

    Private Sub btnRSstatus1_Click(sender As Object, e As EventArgs) Handles btnRSstatus1.Click
        Call startfrm()
        Call getdata_dgRSstatus1(10)
        Me.lblStatusText.Text = "กำลังอยู่ที่สถานะรอซ่อม"
        Me.btnRSstatus1.BackColor = Color.BlueViolet
        Me.btnRSstatus2.BackColor = Color.Azure
        Me.btnRSstatus3.BackColor = Color.Azure
        Me.btnRSstatus4.BackColor = Color.Azure
        Me.btnRSstatus5.BackColor = Color.Azure
        Me.btnRSstatus6.BackColor = Color.Azure
        Me.btnRSstatus7.BackColor = Color.Azure

        Me.btnRSstatus1.ForeColor = Color.White
        Me.btnRSstatus2.ForeColor = Color.Black
        Me.btnRSstatus3.ForeColor = Color.Black
        Me.btnRSstatus4.ForeColor = Color.Black
        Me.btnRSstatus5.ForeColor = Color.Black
        Me.btnRSstatus6.ForeColor = Color.Black
        Me.btnRSstatus7.ForeColor = Color.Black

    End Sub

    Private Sub btnRSstatus3_Click(sender As Object, e As EventArgs) Handles btnRSstatus3.Click
        Call startfrm()
        Call getdata_dgRSstatus1(30)
        Me.lblStatusText.Text = "กำลังอยู่ที่สถานะรออะไหล่/ส่งเคลม"
        Me.btnRSstatus1.BackColor = Color.Azure
        Me.btnRSstatus2.BackColor = Color.Azure
        Me.btnRSstatus3.BackColor = Color.BlueViolet
        Me.btnRSstatus4.BackColor = Color.Azure
        Me.btnRSstatus5.BackColor = Color.Azure
        Me.btnRSstatus6.BackColor = Color.Azure
        Me.btnRSstatus7.BackColor = Color.Azure

        Me.btnRSstatus1.ForeColor = Color.Black
        Me.btnRSstatus2.ForeColor = Color.Black
        Me.btnRSstatus3.ForeColor = Color.White
        Me.btnRSstatus4.ForeColor = Color.Black
        Me.btnRSstatus5.ForeColor = Color.Black
        Me.btnRSstatus6.ForeColor = Color.Black
        Me.btnRSstatus7.ForeColor = Color.Black

    End Sub

    Private Sub btnRSstatus4_Click(sender As Object, e As EventArgs) Handles btnRSstatus4.Click
        Call startfrm()
        Call getdata_dgRSstatus1(40)
        Me.lblStatusText.Text = "กำลังอยู่ที่สถานะซ่อมไม่ได้"
        Me.btnRSstatus1.BackColor = Color.Azure
        Me.btnRSstatus2.BackColor = Color.Azure
        Me.btnRSstatus3.BackColor = Color.Azure
        Me.btnRSstatus4.BackColor = Color.BlueViolet
        Me.btnRSstatus5.BackColor = Color.Azure
        Me.btnRSstatus6.BackColor = Color.Azure
        Me.btnRSstatus7.BackColor = Color.Azure

        Me.btnRSstatus1.ForeColor = Color.Black
        Me.btnRSstatus2.ForeColor = Color.Black
        Me.btnRSstatus3.ForeColor = Color.Black
        Me.btnRSstatus4.ForeColor = Color.White
        Me.btnRSstatus5.ForeColor = Color.Black
        Me.btnRSstatus6.ForeColor = Color.Black
        Me.btnRSstatus7.ForeColor = Color.Black

    End Sub

    Private Sub btnRSstatus5_Click(sender As Object, e As EventArgs) Handles btnRSstatus5.Click
        Call startfrm()
        Call getdata_dgRSstatus1(50)
        'Me.btnRSsend_to_claims.Enabled = True
        Me.lblStatusText.Text = "กำลังอยู่ที่สถานะซ่อมเสร็จ"
        Me.btnRSstatus1.BackColor = Color.Azure
        Me.btnRSstatus2.BackColor = Color.Azure
        Me.btnRSstatus3.BackColor = Color.Azure
        Me.btnRSstatus4.BackColor = Color.Azure
        Me.btnRSstatus5.BackColor = Color.BlueViolet
        Me.btnRSstatus6.BackColor = Color.Azure
        Me.btnRSstatus7.BackColor = Color.Azure

        Me.btnRSstatus1.ForeColor = Color.Black
        Me.btnRSstatus2.ForeColor = Color.Black
        Me.btnRSstatus3.ForeColor = Color.Black
        Me.btnRSstatus4.ForeColor = Color.Black
        Me.btnRSstatus5.ForeColor = Color.White
        Me.btnRSstatus6.ForeColor = Color.Black
        Me.btnRSstatus7.ForeColor = Color.Black

    End Sub

    Private Sub btnRSstatus6_Click(sender As Object, e As EventArgs) Handles btnRSstatus6.Click
        Call startfrm()
        Call getdata_dgRSstatus1(60)
        Me.lblStatusText.Text = "กำลังอยู่ที่สถานะยกเลิกซ่อม"
        Me.btnRSstatus1.BackColor = Color.Azure
        Me.btnRSstatus2.BackColor = Color.Azure
        Me.btnRSstatus3.BackColor = Color.Azure
        Me.btnRSstatus4.BackColor = Color.Azure
        Me.btnRSstatus5.BackColor = Color.Azure
        Me.btnRSstatus6.BackColor = Color.BlueViolet
        Me.btnRSstatus7.BackColor = Color.Azure

        Me.btnRSstatus1.ForeColor = Color.Black
        Me.btnRSstatus2.ForeColor = Color.Black
        Me.btnRSstatus3.ForeColor = Color.Black
        Me.btnRSstatus4.ForeColor = Color.Black
        Me.btnRSstatus5.ForeColor = Color.Black
        Me.btnRSstatus6.ForeColor = Color.White
        Me.btnRSstatus7.ForeColor = Color.Black

    End Sub

    Private Sub btnRSstatus7_Click(sender As Object, e As EventArgs) Handles btnRSstatus7.Click
        Call startfrm()
        Call getdata_dgRSstatus1(70)
        Me.lblStatusText.Text = "กำลังอยู่ที่สถานะคืนเครื่องแล้ว"
        Me.btnRSstatus1.BackColor = Color.Azure
        Me.btnRSstatus2.BackColor = Color.Azure
        Me.btnRSstatus3.BackColor = Color.Azure
        Me.btnRSstatus4.BackColor = Color.Azure
        Me.btnRSstatus5.BackColor = Color.Azure
        Me.btnRSstatus6.BackColor = Color.Azure
        Me.btnRSstatus7.BackColor = Color.BlueViolet

        Me.btnRSstatus1.ForeColor = Color.Black
        Me.btnRSstatus2.ForeColor = Color.Black
        Me.btnRSstatus3.ForeColor = Color.Black
        Me.btnRSstatus4.ForeColor = Color.Black
        Me.btnRSstatus5.ForeColor = Color.Black
        Me.btnRSstatus6.ForeColor = Color.Black
        Me.btnRSstatus7.ForeColor = Color.White

        Me.NumericUpDown1.Visible = True

        If Me.dgRSstatus1.Rows.Count < comfigsend Then
            Me.btnForward.Visible = True
        Else
            Me.btnForward.Visible = False
        End If

    End Sub

    Private Sub dgRSstatus1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRSstatus1.CellDoubleClick
        If Me.dgRSstatus1.Rows.Count <> 0 Then
            Call showmeUnderDataGrid()
            Me.cbbRSstatus.Enabled = True
            Me.cbbRSuser_repair.Enabled = True
            Me.cbbRSteltocus.Enabled = True
            Me.btnRSPartsWithdrawal.Enabled = True
            Me.cbbRSvaruntee.Enabled = True
            Me.btnRSsave.Enabled = True

            Me.btnRSviewProduct.Enabled = True
            Me.cbbRSstorage.Enabled = True

            If Me.btnRSstatus5.BackColor = Color.BlueViolet Or Me.btnRSstatus6.BackColor = Color.BlueViolet _
                Or Me.btnRSstatus4.BackColor = Color.BlueViolet Then
                'Me.btnSRsendRepair.Visible = True
                If Me.dgRSstatus1.CurrentRow.Cells(11).Value = "ส่งมาจากงานเคลม" Then
                    Me.btnRSsend_to_claims.Visible = True
                    Me.btnRSsend_to_claims.Enabled = True
                    Me.btnSRsendRepair.Visible = False
                Else
                    Me.btnSRsendRepair.Visible = True
                    Me.btnRSsend_to_claims.Enabled = True
                    Me.btnRSsend_to_claims.Visible = False
                End If
            End If
            Call get_sale_id()
            Call claimss()
            Call LoadPictureList(Me.txtRSfix_id.Text)
            Call GetComfix_note(Me.txtRSfix_id.Text)
            Me.btnAddPic.Enabled = True
            If Me.dgRSstatus1.CurrentRow.Cells(17).Value = "7 คืนเครื่องแล้ว" Then
                Me.lblAddNoteRapair.Visible = False
                Me.btnAddPic.Enabled = False
                Me.btnRSsave.Enabled = False
                Me.DelPicToolStripMenu.Enabled = False
            Else
                Me.lblAddNoteRapair.Visible = True
            End If

            If Me.dgRSstatus1.CurrentRow.Cells(17).Value = "3 รออะไหล่/ส่งเคลม" AndAlso Not Me.dgRSstatus1.CurrentRow.Cells(17).Value = "7 คืนเครื่องแล้ว" Then
                Me.lblSendFix.Visible = True
            Else
                Me.lblSendFix.Visible = False
            End If
        End If
    End Sub

    Private Sub txtRScus_id_TextChanged(sender As Object, e As EventArgs) Handles txtRScus_id.TextChanged
        cmd = New MySqlCommand("SELECT customer_tel FROM customer WHERE customer_id='" & Me.txtRScus_id.Text & "'", ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Me.txtRScus_tel.Text = Dr.GetString("customer_tel")
            Else
                Me.txtRScus_tel.Text = "##ไม่พบข้อมูล##"
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lblRSclaims.Text = Nothing
        Timer1.Stop()
    End Sub

    Private Sub cbbRSstatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbRSstatus.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbbRSteltocus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbRSteltocus.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbbRSuser_repair_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbRSuser_repair.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbbRSvaruntee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbRSvaruntee.KeyPress
        e.Handled = True
    End Sub

    Private Sub llblRSshelf_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblRSshelf.LinkClicked
        shelfFrm.ShowDialog(Me)
    End Sub

    Private Sub btnRSsave_Click(sender As Object, e As EventArgs) Handles btnRSsave.Click
        Call updateDataStatus_dgRSstatus1()
    End Sub

    Private Sub btnRSviewProduct_Click(sender As Object, e As EventArgs) Handles btnRSviewProduct.Click
        If Me.txtRSfix_id.Text <> String.Empty Then
            ViewProductRepairFrm.getDatatodgRPorderpro(Me.txtRSfix_id.Text)
            ViewProductRepairFrm.ShowDialog(Me)
        End If
    End Sub

    Private Sub btnRSPartsWithdrawal_Click(sender As Object, e As EventArgs) Handles btnRSPartsWithdrawal.Click
        If Me.dgRSstatus1.SelectedCells.Item(17).Value = "7 คืนเครื่องแล้ว" Then
            MessageBox.Show(Me, "สถานะ คืนเครื่องแล้ว ไม่สามารถเบิกอะไหล่ได้", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf Me.dgRSstatus1.SelectedCells.Item(17).Value = "4 ซ่อมไม่ได้" Then
            MessageBox.Show(Me, "สถานะ ซ่อมไม่ได้ ไม่สามารถเบิกอะไหล่ได้", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf Me.dgRSstatus1.SelectedCells.Item(17).Value = "5 ซ่อมเสร็จ" Then
            MessageBox.Show(Me, "สถานะ ซ่อมเสร็จ ไม่สามารถเบิกอะไหล่ได้", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf Me.dgRSstatus1.SelectedCells.Item(17).Value = "6 ยกเลิกซ่อม" Then
            MessageBox.Show(Me, "สถานะ ยกเลิกซ่อม ไม่สามารถเบิกอะไหล่ได้", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            For Each form In My.Application.OpenForms
                If (form.name = PartsWithdrawalFrm.Name) Then
                    If form.Visible Then
                        PartsWithdrawalFrm.WindowState = FormWindowState.Normal
                        PartsWithdrawalFrm.BringToFront()
                        Exit Sub
                    End If
                End If
            Next
            Call MainFrm.checkAccess("เบิกอะไหล่/ค่าซ่อม")
            If MainFrm.access = 1 Then
                MiniAllLoginFrm.ShowDialog(Me)
            ElseIf MainFrm.access = 0 Then
                PartsWithdrawalFrm.txtPWrepairID.Text = Me.txtRSfix_id.Text
                PartsWithdrawalFrm.txtPWcusID.Text = Me.txtRScus_id.Text
                PartsWithdrawalFrm.txtPWcusName.Text = Me.txtRScus_name.Text
                PartsWithdrawalFrm.txtPWcusTel.Text = Me.txtRScus_tel.Text
                PartsWithdrawalFrm.lblEmployee.Text = Me.lblEmployee.Text
                PartsWithdrawalFrm.ShowDialog(Me)
                Call get_sale_id()
            Else
                MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub dgRSstatus1_SelectionChanged(sender As Object, e As EventArgs) Handles dgRSstatus1.SelectionChanged
        'Me.cbbRSstatus.Enabled = False
        'Me.cbbRSuser_repair.Enabled = False
        'Me.cbbRSteltocus.Enabled = False
        'Me.btnRSPartsWithdrawal.Enabled = False
        'Me.cbbRSvaruntee.Enabled = False
        'Me.btnRSviewProduct.Enabled = False
        'Me.btnRSsave.Enabled = False
        ''Me.txtRSnote_repair.Enabled = False
        'Me.cbbRSstorage.Enabled = False
        ''Me.txtRSnote_repair.Text = "-"
        'Me.cbbRSstatus.Text = Nothing
        'Me.cbbRSuser_repair.Text = Nothing
        'Me.cbbRSvaruntee.Text = Nothing
        'Me.cbbRSteltocus.Text = Nothing
        'Me.cbbRSstorage.Text = Nothing
        'Me.txtRSfix_id.Clear()
        'Me.txtRScus_id.Clear()
        'Me.txtRScus_name.Clear()
        'Me.txtRScus_tel.Clear()
        'Me.dgRSstatus1.Refresh()
        'Me.btnRSsend_to_claims.Visible = False
        'Me.lblRSsaleDetail.Text = "Sale Detail"
        'Me.btnSRsendRepair.Visible = False
        'Me.ListView1.Clear()
        'Me.btnAddPic.Enabled = False
    End Sub

    Friend selectOpen As Integer

    Private Sub btnSRsendRepair_Click(sender As Object, e As EventArgs) Handles btnSRsendRepair.Click
        selectOpen = 123456789
        For Each form In My.Application.OpenForms
            If (form.name = SendRepairFrm.Name) Then
                If form.Visible Then
                    SendRepairFrm.Close()
                    SendRepairFrm.txtHideform.Text = Me.txtRSfix_id.Text
                    SendRepairFrm.cbbSRRcash_status.Enabled = True
                    SendRepairFrm.DateTimePickerSRR.Enabled = True
                    SendRepairFrm.ShowDialog(Me)
                    SendRepairFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
                    Exit Sub
                End If
            End If
        Next
        Call MainFrm.checkAccess("ส่งคืนงานซ่อม")
        If MainFrm.access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf MainFrm.access = 0 Then
            SendRepairFrm.txtHideform.Text = Me.txtRSfix_id.Text
            SendRepairFrm.cbbSRRcash_status.Enabled = True
            SendRepairFrm.DateTimePickerSRR.Enabled = True
            SendRepairFrm.ShowDialog(Me)
            SendRepairFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnRSsend_to_claims_Click(sender As Object, e As EventArgs) Handles btnRSsend_to_claims.Click
        If Me.dgRSstatus1.RowCount <> 0 Then
            If Me.dgRSstatus1.SelectedRows.Count <> 0 Then
                If Me.dgRSstatus1.CurrentRow.Cells(11).Value = "ส่งมาจากงานเคลม" Then
                    If MessageBox.Show(Me, "คุณแน่ใจว่าจะบันทึก", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Dim cl_id As String = String.Empty
                        Try
                            strSQL = "SELECT claims_id FROM comfix WHERE fix_id='" & Me.dgRSstatus1.CurrentRow.Cells(1).Value & "';"
                            cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Call open_connection()
                            Dr = cmd.ExecuteReader()
                            Dr.Read()
                            cl_id = Dr.Item("claims_id")
                        Catch ex As Exception
                            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                        End Try

                        Try
                            strSQL = "UPDATE claims SET status='ซ่อมเสร็จ',datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss",
                                                                                                    CultureInfo.CreateSpecificCulture("en-US")) & "'" _
                                 & "WHERE claims_id='" & cl_id & "';"
                            cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Call open_connection()
                            cmd.ExecuteNonQuery()
                        Catch ex As Exception
                            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                        End Try

                        Try
                            strSQL = "UPDATE comfix SET status='7 คืนเครื่องแล้ว',date_send='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss",
                                                                                                    CultureInfo.CreateSpecificCulture("en-US")) & "'" _
                                 & "WHERE claims_id='" & cl_id & "';"
                            cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Call open_connection()
                            cmd.ExecuteNonQuery()
                        Catch ex As Exception
                            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                        End Try
                        Call StartFrmByStatus()
                        MsgBox("ส่งข้อมูลไปที่งานเคลมเรียบร้อยแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
                    End If
                Else
                    MsgBox("งานซ่อมนี้ไม่ได้มาจากระบบเคลม", MsgBoxStyle.Information, "แจ้งเตือน")
                End If
            End If
        End If
    End Sub

    Private Sub btnAddPic_Click(sender As Object, e As EventArgs) Handles btnAddPic.Click
        CameraCaptureRepairStatusFrm.ShowDialog(Me)
    End Sub

    Private Sub ListView1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView1.KeyDown
        If e.KeyCode = (e.Shift And Keys.Delete) Then
            If ListView1.SelectedItems.Count > 0 Then
                If MessageBox.Show(Me, "ลบแบบถาวรไม่สามารถนำคืนรูปที่ลบได้อีก ต้องการจะทำต่อหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Try
                        cmd = New MySqlCommand("DELETE FROM picture_all WHERE pa_id='" & ListView1.FocusedItem.ImageKey.ToString & "';", ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                        While ListView1.SelectedItems.Count > 0
                            Dim lvi As ListViewItem = ListView1.SelectedItems(0)
                            ListView1.Items.Remove(lvi)
                        End While
                        ListView1.Refresh()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                End If
            End If
        End If

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

    Private Sub ListView1_MouseUp(sender As Object, e As MouseEventArgs) Handles ListView1.MouseUp
        If e.Button = MouseButtons.Right Then
            If Me.ListView1.Items.Count > 0 Then
                If ListView1.SelectedItems.Count > 0 Then
                    Me.DelPicContextMenu.Show(ListView1, e.Location)
                End If
            End If
        End If
    End Sub

    Private Sub DelPicToolStripMenu_Click(sender As Object, e As EventArgs) Handles DelPicToolStripMenu.Click
        Try
            cmd = New MySqlCommand("UPDATE picture_all SET del='yes' WHERE pa_id='" & ListView1.FocusedItem.ImageKey.ToString & "';", ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            While ListView1.SelectedItems.Count > 0
                Dim lvi As ListViewItem = ListView1.SelectedItems(0)
                ListView1.Items.Remove(lvi)
            End While
            ListView1.Refresh()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub lblAddNoteRapair_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblAddNoteRapair.LinkClicked
        AddRepairNoteFrm.ShowDialog(Me)
    End Sub

    Private Sub ListView_note_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView_note.MouseDoubleClick
        If e.Button = MouseButtons.Left Then
            If Me.ListView_note.Enabled = True Then
                If Me.dgRSstatus1.CurrentRow.Cells(17).Value = "7 คืนเครื่องแล้ว" Then
                    ViewComFixNoteFrm.TextBox1.Enabled = False
                    ViewComFixNoteFrm.Button1.Enabled = False
                End If
                Call ViewComFixNoteFrm.GetComfix_note(Me.txtRSfix_id.Text)
                ViewComFixNoteFrm.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub cbbRSstatus_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbRSstatus.SelectedValueChanged
        If Me.cbbRSstatus.Text = "3 รออะไหล่/ส่งเคลม" Then
            Me.lblSendFix.Visible = True
        Else
            Me.lblSendFix.Visible = False
        End If
    End Sub

    Private Sub lblSendFix_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblSendFix.LinkClicked
        RepairSendFrm.ShowDialog(Me)
    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        Call getdata_dgRSstatus1(80)
        If Me.dgRSstatus1.Rows.Count = comfigsend Then
            Me.btnForward.Visible = False
        End If
    End Sub

    Private Sub btnRSstatus1_MouseHover(sender As Object, e As EventArgs) Handles btnRSstatus1.MouseHover
        Me.ToolTip2.Show(Me.btnRSstatus1.Text & " รายการ", btnRSstatus1)
    End Sub

    Private Sub btnRSstatus2_MouseHover(sender As Object, e As EventArgs) Handles btnRSstatus2.MouseHover
        Me.ToolTip2.Show(Me.btnRSstatus2.Text & " รายการ", btnRSstatus2)
    End Sub

    Private Sub btnRSstatus3_MouseHover(sender As Object, e As EventArgs) Handles btnRSstatus3.MouseHover
        Me.ToolTip2.Show(Me.btnRSstatus3.Text & " รายการ", btnRSstatus3)
    End Sub

    Private Sub btnRSstatus4_MouseHover(sender As Object, e As EventArgs) Handles btnRSstatus4.MouseHover
        Me.ToolTip2.Show(Me.btnRSstatus4.Text & " รายการ", btnRSstatus4)
    End Sub

    Private Sub btnRSstatus5_MouseHover(sender As Object, e As EventArgs) Handles btnRSstatus5.MouseHover
        Me.ToolTip2.Show(Me.btnRSstatus5.Text & " รายการ", btnRSstatus5)
    End Sub

    Private Sub btnRSstatus6_MouseHover(sender As Object, e As EventArgs) Handles btnRSstatus6.MouseHover
        Me.ToolTip2.Show(Me.btnRSstatus6.Text & " รายการ", btnRSstatus6)
    End Sub

    Private Sub btnRSstatus7_MouseHover(sender As Object, e As EventArgs) Handles btnRSstatus7.MouseHover
        Me.ToolTip2.Show(Me.btnRSstatus7.Text & " รายการ", btnRSstatus7)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchRepairFrm.lblEmployee.Text = Me.lblEmployee.Text
        SearchRepairFrm.ShowDialog(Me)
    End Sub

    Private Sub btnHelp_Click_1(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/comfix/repairstatusfrm")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ExportToolStripMenu_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenu.Click
        Me.SaveFileDialog1.FileName = DateTime.Now.ToString("yyyyMMddHHmmssms", CultureInfo.CreateSpecificCulture("en-US"))
        Dim result As DialogResult = SaveFileDialog1.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            If SaveFileDialog1.FileName <> "" Then
                Try
                    cmd = New MySqlCommand("SELECT byte_pic FROM " _
                                    & "picture_all WHERE pa_id='" & Me.ListView1.FocusedItem.ImageKey.ToString & "' AND del='no';", ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    While Dr.Read
                        Dim img_buffer() As Byte = Dr.Item("byte_pic")
                        System.IO.File.WriteAllBytes(Me.SaveFileDialog1.FileName, img_buffer)
                    End While
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            End If
        End If
    End Sub

    Private Sub PrintToolStripMenu_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenu.Click
        DocManPrintA4Frm.paid = Me.ListView1.FocusedItem.ImageKey.ToString
        DocManPrintA4Frm.ShowDialog(Me)
    End Sub

    Private Sub RefreshToolStripMenu_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenu.Click
        Call LoadPictureList(Me.txtRSfix_id.Text)
    End Sub

    Private Sub ZoomToolStripMenu_Click(sender As Object, e As EventArgs) Handles ZoomToolStripMenu.Click
        If Me.ListView_note.Enabled = True Then
            If Me.dgRSstatus1.CurrentRow.Cells(17).Value = "7 คืนเครื่องแล้ว" Then
                ViewComFixNoteFrm.TextBox1.Enabled = False
                ViewComFixNoteFrm.Button1.Enabled = False
            End If
            Call ViewComFixNoteFrm.GetComfix_note(Me.txtRSfix_id.Text)
            ViewComFixNoteFrm.ShowDialog(Me)
        End If
    End Sub
End Class