Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Data.SQLite
Imports System.IO

Public Class SaveDataFixFrm
    Dim LinearEncoder As New BarcodeLib.Barcode

    Private Sub SaveDataFixFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.dgSDFlistComfix.RowCount <> 0 Then
            If MessageBox.Show(Me, "มีข้อมูลยังไม่ได้ถูกบันทึก ต้องการจะปิดหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                e.Cancel = False
                Try
                    cmdSQLite = New SQLiteCommand("DELETE FROM comfix_cache", connSQLite)
                    Call open_connectionSQLite()
                    cmdSQLite.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try

                For imgc As Integer = 0 To Me.dgSDFlistComfix.Rows.Count - 1
                    Try
                        cmd = New MySqlCommand("DELETE FROM picture_all WHERE key_pic='" & Me.dgSDFlistComfix.Rows(imgc).Cells(2).Value & "' " & _
                                               "AND note_pic='" & Me.dgSDFlistComfix.Rows(imgc).Cells(3).Value & "';", ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                Next

                If Me.ListView1.Items.Count <> 0 Then
                    For imgc As Integer = 0 To Me.ListView1.Items.Count - 1
                        Try
                            cmd = New MySqlCommand("DELETE FROM picture_all WHERE pa_id='" & Me.ListView1.Items(imgc).ImageKey.ToString & "';", ConnectionDB)
                            Call open_connection()
                            cmd.ExecuteNonQuery()
                        Catch ex As Exception
                            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                        End Try
                    Next
                End If
            Else
                e.Cancel = True
            End If
        End If
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub loadTempComfix()
        cmdSQLite = New SQLiteCommand("SELECT * FROM comfix_cache", connSQLite)
        Call open_connectionSQLite()
        Try
            DrSQLite = cmdSQLite.ExecuteReader()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Dim r As Integer
        While DrSQLite.Read()
            With Me.dgSDFlistComfix
                r = .RowCount
                .Rows.Add()
                .Rows(r).Cells(0).Value = r + 1
                .Rows(r).Cells(1).Value = DrSQLite.Item("customer_id")
                .Rows(r).Cells(2).Value = DrSQLite.Item("fix_id")
                .Rows(r).Cells(3).Value = DrSQLite.Item("sn")

                .Rows(r).Cells(8).Value = DrSQLite.Item("symptom")
                .Rows(r).Cells(9).Value = DrSQLite.Item("managerdata")
                .Rows(r).Cells(10).Value = DrSQLite.Item("fixaccessory")
            End With
        End While
        For GetSN As Integer = 0 To Me.dgSDFlistComfix.Rows.Count - 1
            cmd = New MySqlCommand("SELECT p_type,p_name,model,color FROM" _
                                   & "`sn` WHERE Snum='" & Me.dgSDFlistComfix.Rows(GetSN).Cells(3).Value & "'", ConnectionDB)
            Call open_connection()
            Try
                Dr = cmd.ExecuteReader()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            While Dr.Read()
                With Me.dgSDFlistComfix
                    .Rows(r).Cells(4).Value = Dr.GetString("p_type")
                    .Rows(r).Cells(5).Value = Dr.GetString("p_name")
                    .Rows(r).Cells(6).Value = Dr.GetString("model")
                    .Rows(r).Cells(7).Value = Dr.GetString("color")
                End With
            End While
        Next
        Me.txtSDFCusID.Text = Me.dgSDFlistComfix.Rows(0).Cells(1).Value
        Call getDataCustomertoTextBox(Me.txtSDFCusID.Text)
        Me.txtSDFfixSN.Focus()
    End Sub

    Private Sub SaveDataFixFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call startfrm()
        Me.btnSDFsaveAll.Enabled = False
        If checkSQLiteDruplicateDB("SELECT * FROM comfix_cache") = True Then
            If MessageBox.Show(Me, "พบข้อมูลรับงานซ่อมยังไม่ได้บันทึก ต้องการจะทำต่อหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Call loadTempComfix()

            Else
                Try
                    cmdSQLite = New SQLiteCommand("DELETE FROM comfix_cache", connSQLite)
                    Call open_connectionSQLite()
                    cmdSQLite.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            End If
        End If
    End Sub

    'Private Sub AutoNumberNo()
    '    Call ALLAutonumber("ver_fixid", Me.lblAutoNumber.Text)
    'End Sub

    Friend Sub startfrm()
        Me.DateTimePickerSDFadd.Value = DateTime.Now.AddDays(0)
        Me.DateTimePickerfixsendcom.Value = DateTime.Now.AddDays(1)
        Me.txtSDFCusID.Clear()
        Me.txtSDFcusname.Clear()
        Me.txtSDFcusaddress.Clear()
        Me.txtSDFcusTel.Clear()
        Me.txtSDFcuszipcode.Clear()
        Me.txtSDFfixrepairNote.Text = "-"
        Me.txtSDFfixnote.Text = "-"
        Me.txtSDFfixTprice.Text = "-"
        Me.cbbSDFrepairData.Items.Clear()
        Me.cbbSDFRepairType.Items.Clear()
        Me.cbbSDFtype.Items.Clear()
        Me.cbbSDFname.Items.Clear()
        Me.cbbSDFmodel.Items.Clear()
        Me.cbbSDFcolor.Items.Clear()
        If Me.cbSDFGimportune.CheckState = CheckState.Checked Then
            Me.cbSDFGimportune.CheckState = CheckState.Unchecked
        End If
        Me.lblAutoNumber.Text = Nothing
        Me.ListView1.Clear()
        Me.ListView1.Enabled = False
        Me.btnTakePicture.Enabled = False
    End Sub

    Private Sub getsncomfix(ByVal SSN)
        Try
            Using dt = New DataTable
                Using dtAdapter = New MySqlDataAdapter("SELECT customer_id,sn FROM comfix WHERE sn='" & SSN & "';", ConnectionDB)
                    Call open_connection()
                    dtAdapter.Fill(dt)
                        Me.txtSDFCusID.Text = dt(0)("customer_id")
                        Me.txtSDFfixSN.Text = dt(0)("sn")
                End Using
            End Using
            'loda customer
            Call getDataCustomertoTextBox(Me.txtSDFCusID.Text)
            ''load sn
            Call getDataSNtoTextBox(Me.txtSDFfixSN.Text)
        Catch ex As Exception
            MessageBox.Show(Me, "ไม่พบข้อมูล SN", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Me.txtSDFsearchSN.Clear()
    End Sub

    Private Sub getDataCustomertoTextBox(ByVal cusid As String)
        If Me.txtSDFCusID.Text = "0" Then
            MsgBox("ใช้ชื่อลูกค้าเงินสดในงานรับซ่อมไม่ได้", MsgBoxStyle.Information, "แจ้งเตือน")
            Me.txtSDFCusID.Clear()
            Me.txtSDFCusID.Focus()
        Else
            Me.txtSDFCusID.Clear()
            Try
                Using dt = New DataTable
                    Using dtAdapter = New MySqlDataAdapter("SELECT customer_id,customer_name,customer_address,customer_zipcode,customer_tel " _
                                                 & "FROM customer WHERE customer_id='" & cusid & "';", ConnectionDB)
                        Call open_connection()
                        dtAdapter.Fill(dt)
                        Me.txtSDFCusID.Text = dt(0)("customer_id")
                        Me.txtSDFcusname.Text = dt(0)("customer_name")
                        Me.txtSDFcusaddress.Text = dt(0)("customer_address")
                        Me.txtSDFcuszipcode.Text = dt(0)("customer_zipcode")
                        Me.txtSDFcusTel.Text = dt(0)("customer_tel")
                    End Using
                End Using
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub

    Friend Sub getDataSNtoTextBox(ByVal FixSN As String)
        Try
            Using dt = New DataTable
                Using dtAdapter = New MySqlDataAdapter("SELECT Snum,p_type,p_name,model,color FROM sn WHERE Snum='" & FixSN & "';", ConnectionDB)
                    Call open_connection()
                    dtAdapter.Fill(dt)
                    Me.txtSDFfixSN.Text = dt(0)("Snum")
                    Me.cbbSDFtype.Text = dt(0)("p_type")
                    Me.cbbSDFname.Text = dt(0)("p_name")
                    Me.cbbSDFmodel.Text = dt(0)("model")
                    Me.cbbSDFcolor.Text = dt(0)("color")
                    'Else
                    'Me.lblSDFcheckSN.Text = "ไม่พบ SN นี้ในระบบ"
                    'Me.txtSDFfixSN.Focus()
                    'End If
                End Using
            End Using
        Catch ex As Exception
            Me.lblSDFcheckSN.Text = "ไม่พบ SN นี้ในระบบ"
            'MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Friend Sub LoadPictureList(ByVal key_pic As String)
        ListView1.Clear()
        Dim imglist As New ImageList
        imglist.ColorDepth = ColorDepth.Depth32Bit
        ListView1.LargeImageList = imglist
        ListView1.LargeImageList.ImageSize = New System.Drawing.Size(80, 80)
        Try
            cmd = New MySqlCommand("SELECT pa_id,byte_pic,note_pic,datetime_save FROM " _
                                   & "picture_all WHERE key_pic='" & key_pic & "' AND del='no' ORDER BY datetime_save ASC;", ConnectionDB)
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

    Private Sub btnSDFsearchSN_Click(sender As Object, e As EventArgs) Handles btnSDFsearchSN.Click
        If Me.txtSDFsearchSN.Text <> Nothing Then
            Call getsncomfix(Me.txtSDFsearchSN.Text)
        End If
    End Sub

    Private Sub txtSDFsearchSN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSDFsearchSN.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtSDFsearchSN.Text <> Nothing Then
                Call getsncomfix(Me.txtSDFsearchSN.Text)
            End If
        End If
    End Sub

    Friend sCustomerSDFF As Integer = Nothing
    Private Sub btnSDFSearcdcusID_Click(sender As Object, e As EventArgs) Handles btnSDFSearcdcusID.Click
        sCustomerSDFF = 100
        SearchCustomerFrm.btnSendtoSavedatafix.Text = "เลือกไปหน้ารับงานซ่อม"
        SearchCustomerFrm.ShowDialog(Me)
    End Sub

    Dim keySN As String
    Dim snid As String
    Private Sub btnSDFsearcdSN_Click(sender As Object, e As EventArgs) Handles btnSDFsearcdSN.Click
        Try
            Call ALLAutonumber("ver_sn", snid)
            Me.txtSDFfixSN.Text = snid
            Me.cbbSDFtype.Items.Clear()
            Me.cbbSDFname.Items.Clear()
            Me.cbbSDFmodel.Items.Clear()
            Me.cbbSDFcolor.Items.Clear()
            keySN = "10"
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub txtSDFCusID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSDFCusID.KeyDown
        If Me.txtSDFCusID.Text <> Nothing Then
            If e.KeyCode = Keys.Enter Then
                Call getDataCustomertoTextBox(Me.txtSDFCusID.Text)
                Me.txtSDFfixSN.Focus()
            End If
        End If
    End Sub

    Private Sub txtSDFfixSN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSDFfixSN.KeyDown
        If Me.txtSDFfixSN.Text <> Nothing Then
            If e.KeyCode = Keys.Enter Then
                Call getDataSNtoTextBox(Me.txtSDFfixSN.Text)
            End If
        End If
    End Sub

    Private Sub cbbSDFtype_DropDown(sender As Object, e As EventArgs) Handles cbbSDFtype.DropDown
        Try
            Me.cbbSDFtype.Items.Clear()
            cmd = New MySqlCommand("SELECT p_type FROM product_type ORDER BY p_type ASC", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbbSDFtype.Items.Add(Dr.GetString("p_type"))
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub cbbSDFname_DropDown(sender As Object, e As EventArgs) Handles cbbSDFname.DropDown
        Try
            Me.cbbSDFname.Items.Clear()
            cmd = New MySqlCommand("SELECT p_name FROM product_name ORDER BY p_name ASC", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbbSDFname.Items.Add(Dr.GetString("p_name"))
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub cbbSDFmodel_DropDown(sender As Object, e As EventArgs) Handles cbbSDFmodel.DropDown
        Try
            Me.cbbSDFmodel.Items.Clear()
            cmd = New MySqlCommand("SELECT p_model FROM product_model WHERE p_name='" & Me.cbbSDFname.Text & "' ORDER BY p_model ASC", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbbSDFmodel.Items.Add(Dr.GetString("p_model"))
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub cbbSDFcolor_DropDown(sender As Object, e As EventArgs) Handles cbbSDFcolor.DropDown
        Try
            Me.cbbSDFcolor.Items.Clear()
            cmd = New MySqlCommand("SELECT color FROM product_color ORDER BY color ASC", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbbSDFcolor.Items.Add(Dr.GetString("color"))
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub cbbSDFRepairType_DropDown(sender As Object, e As EventArgs) Handles cbbSDFRepairType.DropDown
        Try
            Me.cbbSDFRepairType.Items.Clear()
            cmd = New MySqlCommand("SELECT fix_name FROM fix_com ORDER BY fix_name ASC", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbbSDFRepairType.Items.Add(Dr("fix_name"))
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub cbbSDFrepairData_DropDown(sender As Object, e As EventArgs) Handles cbbSDFrepairData.DropDown
        Try
            Me.cbbSDFrepairData.Items.Clear()
            cmd = New MySqlCommand("SELECT mdata FROM managerdata ORDER BY mdata;", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbbSDFrepairData.Items.Add(Dr("mdata"))
            End While
            Dr.Close()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub btnSDFaccressory_Click(sender As Object, e As EventArgs) Handles btnSDFaccressory.Click
        accessoryFrm.ShowDialog(Me)
    End Sub

    Private Sub btnSDFfixsave_Click(sender As Object, e As EventArgs) Handles btnSDFfixsave.Click
        If Me.txtSDFCusID.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่รหัสลูกค้า", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtSDFCusID.Focus()
            Me.txtSDFCusID.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.txtSDFcusname.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่ชื่อ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtSDFcusname.Focus()
            Me.txtSDFcusname.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.txtSDFcusaddress.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่ที่อยู่", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtSDFcusaddress.Focus()
            Me.txtSDFcusaddress.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.txtSDFcuszipcode.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่รหัสไปรษณีย์", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtSDFcuszipcode.Focus()
            Me.txtSDFcuszipcode.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.txtSDFcusTel.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่เบอร์โทร", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtSDFcusTel.Focus()
            Me.txtSDFcusTel.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.txtSDFfixSN.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่ SN", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtSDFfixSN.Focus()
            Me.txtSDFfixSN.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.cbbSDFtype.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่ประเภท", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.cbbSDFtype.Focus()
            Me.cbbSDFtype.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.cbbSDFname.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่ยี่ห้อ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.cbbSDFname.Focus()
            Me.cbbSDFname.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.cbbSDFmodel.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่รุ่น", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.cbbSDFmodel.Focus()
            Me.cbbSDFmodel.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.cbbSDFcolor.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่สี", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.cbbSDFcolor.Focus()
            Me.cbbSDFcolor.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.cbbSDFRepairType.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาเลือกอาการเสีย", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.cbbSDFRepairType.Focus()
            Me.cbbSDFRepairType.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.cbbSDFrepairData.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาเลือกการจัดการข้อมูล", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.cbbSDFrepairData.Focus()
            Me.cbbSDFrepairData.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.txtSDFfixrepairNote.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่อาการเสียเพิ่มเติม หากไม่มีให้ -", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtSDFfixrepairNote.Focus()
            Me.txtSDFfixrepairNote.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.txtSDFfixaccessory.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่อุปกรณ์ที่นำมา หากไม่มีให้ -", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtSDFfixaccessory.Focus()
            Me.txtSDFfixaccessory.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.txtSDFfixnote.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่หมายเหตุ หากไม่มีให้ -", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtSDFfixnote.Focus()
            Me.txtSDFfixnote.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.txtSDFfixTprice.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาใส่ประเมินค่าซ่อม หากไม่มีให้ -", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtSDFfixTprice.Focus()
            Me.txtSDFfixTprice.BackColor = Color.Salmon
            Timer1.Start()
        Else
            If MessageBox.Show(Me, "ต้องการเพิ่มข้อมูล", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            Else
                Try
                    Dim impp As String
                    If Me.cbSDFGimportune.Checked Then
                        impp = "เร่งด่วน"
                    Else
                        impp = "ธรรมดา"
                    End If
                    strSQLite = "INSERT INTO comfix_cache(fix_id,date_save,customer_id,customer_name,sn,symptom,managerdata,fixrepairnote,fixaccessory,fixnote,fixtprice, " _
                          & "varuntee,date_get,fixuser,status,user_repair,note_repair,teltocus,date_send,importune)VALUES " _
                          & "(@fix_id,@date_save,@customer_id,@customer_name,@sn,@symptom,@managerdata,@fixrepairnote,@fixaccessory,@fixnote,@fixtprice," _
                          & "@varuntee,@date_get,@fixuser,@status,@user_repair,@note_repair,@teltocus,@date_send,@importune)"
                    cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                    With cmdSQLite
                        .Parameters.AddWithValue("@fix_id", Me.lblAutoNumber.Text)
                        .Parameters.AddWithValue("@date_save", GetLocalServerDateTime)
                        .Parameters.AddWithValue("@customer_id", Me.txtSDFCusID.Text)
                        .Parameters.AddWithValue("@customer_name", Me.txtSDFcusname.Text)
                        .Parameters.AddWithValue("@sn", Me.txtSDFfixSN.Text)
                        .Parameters.AddWithValue("@symptom", Me.cbbSDFRepairType.Text)
                        .Parameters.AddWithValue("@managerdata", Me.cbbSDFrepairData.Text)
                        .Parameters.AddWithValue("@fixrepairnote", Me.txtSDFfixrepairNote.Text)
                        .Parameters.AddWithValue("@fixaccessory", Me.txtSDFfixaccessory.Text)
                        .Parameters.AddWithValue("@fixnote", Me.txtSDFfixnote.Text)
                        .Parameters.AddWithValue("@fixtprice", Me.txtSDFfixTprice.Text)
                        .Parameters.AddWithValue("@varuntee", "-")
                        .Parameters.AddWithValue("@date_get", Me.DateTimePickerfixsendcom.Text)
                        .Parameters.AddWithValue("@fixuser", Me.lblEmployee.Text)
                        .Parameters.AddWithValue("@status", "1 รอซ่อม")
                        .Parameters.AddWithValue("@user_repair", "-")
                        .Parameters.AddWithValue("@note_repair", "-")
                        .Parameters.AddWithValue("@teltocus", "-")
                        'cmd.Parameters.AddWithValue("@sale_id", "-")
                        .Parameters.AddWithValue("@date_send", "-")
                        .Parameters.AddWithValue("@importune", impp)

                        Call open_connectionSQLite()
                        .ExecuteNonQuery()
                    End With
                    impp = Nothing
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try

                'บันทึก sn_id แบบอัตโนมัติ
                If keySN = "10" Then
                    '    Dim MAXid As Integer = Nothing
                    '    Try
                    '        strSQL = "SELECT `id`,datetime_save FROM sn_id ORDER BY datetime_save DESC LIMIT 1;"
                    '        cmd = New MySqlCommand(strSQL, ConnectionDB)
                    '        Call open_connection()
                    '        Dr = cmd.ExecuteReader
                    '        If Dr.HasRows Then
                    '            Dr.Read()
                    '                MAXid = Dr.Item("ID")
                    '        End If
                    '    Catch ex As Exception
                    '        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    '    End Try
                    '    Try
                    '        strSQL = "INSERT INTO sn_id(`id`,sn_id,datetime_save)VALUES" _
                    '           & "(@id,@sn_id,@datetime_save)"
                    '        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    '            cmd.Parameters.AddWithValue("@id", MAXid)
                    '            cmd.Parameters.AddWithValue("@sn_id", Me.txtSDFfixSN.Text)
                    '            cmd.Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")))
                    '            Call open_connection()
                    '            cmd.ExecuteNonQuery()
                    '        End Using
                    '        keySN = Nothing
                    '    Catch ex As Exception
                    '        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    '    End Try
                End If


                Try
                    Dim r As Integer
                    With Me.dgSDFlistComfix
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(0).Value = r + 1
                        .Rows(r).Cells(1).Value = Me.txtSDFCusID.Text
                        .Rows(r).Cells(2).Value = Me.lblAutoNumber.Text
                        .Rows(r).Cells(3).Value = Me.txtSDFfixSN.Text
                        .Rows(r).Cells(4).Value = Me.cbbSDFtype.Text
                        .Rows(r).Cells(5).Value = Me.cbbSDFname.Text
                        .Rows(r).Cells(6).Value = Me.cbbSDFmodel.Text
                        .Rows(r).Cells(7).Value = Me.cbbSDFcolor.Text
                        .Rows(r).Cells(8).Value = Me.cbbSDFRepairType.Text
                        .Rows(r).Cells(9).Value = Me.cbbSDFrepairData.Text
                        .Rows(r).Cells(10).Value = Me.txtSDFfixaccessory.Text

                    End With
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
                'บันทึก SN
                If checkMySQLDruplicateDB("SELECT Snum FROM sn WHERE Snum='" & Me.txtSDFfixSN.Text & "'") = False Then
                    Try
                        strSQL = "INSERT INTO sn (Snum,p_type,p_name,model,color,startdate)VALUES" _
                              & "(@Snum,@p_type,@p_name,@model,@color,@startdate)"
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        cmd.Parameters.AddWithValue("@Snum", Me.txtSDFfixSN.Text)
                        cmd.Parameters.AddWithValue("@p_type", Me.cbbSDFtype.Text)
                        cmd.Parameters.AddWithValue("@p_name", Me.cbbSDFname.Text)
                        cmd.Parameters.AddWithValue("@model", Me.cbbSDFmodel.Text)
                        cmd.Parameters.AddWithValue("@color", Me.cbbSDFcolor.Text)
                        cmd.Parameters.AddWithValue("@startdate", GetLocalServerDateTime)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                End If
                'บันทึกประเภท
                If checkMySQLDruplicateDB("SELECT p_type FROM product_type WHERE p_type='" & Me.cbbSDFtype.Text & "'") = False Then
                    Try
                        cmd = New MySqlCommand("INSERT INTO product_type (p_type)VALUES" _
                         & "(@p_type)", ConnectionDB)
                        cmd.Parameters.AddWithValue("@p_type", Me.cbbSDFtype.Text)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                End If
                'บันทึกยี่ห้อ
                If checkMySQLDruplicateDB("SELECT p_name FROM product_name WHERE p_name='" & Me.cbbSDFname.Text & "'") = False Then
                    Try
                        cmd = New MySqlCommand("INSERT INTO product_name (p_name)VALUES" _
                         & "(@p_name)", ConnectionDB)
                        cmd.Parameters.AddWithValue("@p_name", Me.cbbSDFname.Text)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                End If
                'บันทึกรุ่น
                If checkMySQLDruplicateDB("SELECT p_name,p_model FROM product_model WHERE " _
                   & "p_name='" & Me.cbbSDFname.Text & "' AND p_model='" & Me.cbbSDFmodel.Text & "'") = False Then
                    Try
                        cmd = New MySqlCommand("INSERT INTO product_model (p_name,p_model)VALUES" _
                           & "(@p_name,@p_model)", ConnectionDB)
                        cmd.Parameters.AddWithValue("@p_name", Me.cbbSDFname.Text)
                        cmd.Parameters.AddWithValue("@p_model", Me.cbbSDFmodel.Text)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                End If
                'บันทึกสี
                If checkMySQLDruplicateDB("SELECT color FROM product_color WHERE color='" & Me.cbbSDFcolor.Text & "'") = False Then
                    Try
                        cmd = New MySqlCommand("INSERT INTO product_color (color)VALUES" _
                           & "(@color)", ConnectionDB)
                        cmd.Parameters.AddWithValue("@color", Me.cbbSDFcolor.Text)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                End If
                'บันทึกอาการเสีย
                If checkMySQLDruplicateDB("SELECT fix_name FROM fix_com WHERE fix_name='" & Me.cbbSDFRepairType.Text & "'") = False Then
                    Try
                        cmd = New MySqlCommand("INSERT INTO fix_com (fix_name)VALUES" _
                           & "(@fix_name)", ConnectionDB)
                        cmd.Parameters.AddWithValue("@fix_name", Me.cbbSDFRepairType.Text)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                End If
                'บันทึกการจัดการข้อมูล
                If checkMySQLDruplicateDB("SELECT mdata FROM managerdata WHERE mdata='" & Me.cbbSDFrepairData.Text & "'") = False Then
                    Try
                        cmd = New MySqlCommand("INSERT INTO managerdata (mdata)VALUES" _
                           & "(@mdata)", ConnectionDB)
                        cmd.Parameters.AddWithValue("@mdata", Me.cbbSDFrepairData.Text)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                End If

                DateTimePickerSDFadd.Value = DateTime.Now.AddDays(0)
                DateTimePickerfixsendcom.Value = DateTime.Now.AddDays(1)
                Me.cbbSDFrepairData.Text = Nothing
                Me.cbbSDFRepairType.Text = Nothing
                Me.txtSDFfixSN.Clear()
                Me.txtSDFfixaccessory.Clear()
                Me.cbbSDFtype.Text = Nothing
                Me.cbbSDFname.Text = Nothing
                Me.cbbSDFmodel.Text = Nothing
                Me.cbbSDFcolor.Text = Nothing
                Me.txtSDFfixrepairNote.Text = "-"
                Me.txtSDFfixnote.Text = "-"
                Me.txtSDFfixTprice.Text = "-"
                If Me.cbSDFGimportune.CheckState = CheckState.Checked Then
                    Me.cbSDFGimportune.CheckState = CheckState.Unchecked
                End If
                Me.ListView1.Clear()
                Me.lblAutoNumber.Text = Nothing
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.txtSDFCusID.BackColor = Color.LemonChiffon
        Me.txtSDFfixSN.BackColor = Color.LemonChiffon
        Me.cbbSDFtype.BackColor = Color.LemonChiffon
        Me.cbbSDFname.BackColor = Color.LemonChiffon
        Me.cbbSDFmodel.BackColor = Color.LemonChiffon
        Me.cbbSDFcolor.BackColor = Color.LemonChiffon
        Me.cbbSDFRepairType.BackColor = Color.LemonChiffon
        Me.cbbSDFrepairData.BackColor = Color.LemonChiffon
        Me.txtSDFfixrepairNote.BackColor = Color.LemonChiffon
        Me.txtSDFfixTprice.BackColor = Color.LemonChiffon
        Me.txtSDFfixaccessory.BackColor = Color.LemonChiffon
        Me.txtSDFfixnote.BackColor = Color.LemonChiffon
        Timer1.Stop()
    End Sub

    Private Sub dgSDFlistComfix_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgSDFlistComfix.CellMouseClick
        If dgSDFlistComfix.RowCount <> 0 Then
            If e.Button = MouseButtons.Right Then
                Me.dgSDFlistComfix.Rows(e.RowIndex).Selected = True
                Me.dgSDFlistComfix.CurrentCell = Me.dgSDFlistComfix.Rows(e.RowIndex).Cells(0)
                Me.DelComfixContextMenu.Show(Me.dgSDFlistComfix, e.Location)
                Me.DelComfixContextMenu.Show(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub btnTakePicture_Click(sender As Object, e As EventArgs) Handles btnTakePicture.Click
        CameraCaptureSDFFrm.ShowDialog(Me)
    End Sub

    Private Sub DeleteComfixList_Click(sender As Object, e As EventArgs) Handles DeleteComfixList.Click
        If MessageBox.Show("ต้องการลบข้อมูลนี้", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                cmdSQLite = New SQLiteCommand("DELETE FROM comfix_cache WHERE " _
                & "fix_id='" & Me.dgSDFlistComfix.SelectedCells.Item(2).Value & "'", connSQLite)
                Call open_connectionSQLite()
                saveMess = cmdSQLite.ExecuteNonQuery
                If saveMess = 1 Then
                    Dim a As Integer = Me.dgSDFlistComfix.SelectedRows.Count - 1
                    Me.dgSDFlistComfix.Rows.Remove(Me.dgSDFlistComfix.SelectedRows(a))
                    Me.dgSDFlistComfix.Refresh()
                Else
                    MessageBox.Show(Me, "ลบข้อมูลไม่สำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub

    Friend Sub saveDatalistFixcom()
        For RRow As Integer = 0 To Me.dgSDFlistComfix.RowCount - 1
            cmdSQLite = New SQLiteCommand("SELECT * FROM comfix_cache WHERE fix_id='" & Me.dgSDFlistComfix.Rows(RRow).Cells(2).Value & "';", connSQLite)
            Call open_connectionSQLite()
            Try
                DrSQLite = cmdSQLite.ExecuteReader()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            With DrSQLite
                While .Read()
                    cmd = New MySqlCommand("INSERT INTO comfix(fix_id,claims_id,date_save,customer_id,customer_name,sn," _
                                           & "symptom,managerdata,fixrepairnote,fixaccessory,fixnote,fixtprice,varuntee," _
                                           & "date_get,fixuser,`status`,user_repair,note_repair,teltocus,date_send," _
                                           & "datecom_repair,importune,comfix_barcode)" _
                                           & "VALUES(@fix_id,@claims_id,@date_save,@customer_id,@customer_name,@sn," _
                                           & "@symptom,@managerdata,@fixrepairnote,@fixaccessory,@fixnote,@fixtprice,@varuntee," _
                                           & "@date_get,@fixuser,@status,@user_repair,@note_repair,@teltocus,@date_send," _
                                           & "@datecom_repair,@importune,@comfix_barcode)", ConnectionDB)
                    With cmd
                        .Parameters.AddWithValue("@fix_id", DrSQLite.Item("fix_id"))
                        .Parameters.AddWithValue("@claims_id", DrSQLite.Item("claims_id"))
                        .Parameters.AddWithValue("@date_save", DrSQLite.Item("date_save"))
                        .Parameters.AddWithValue("@customer_id", DrSQLite.Item("customer_id"))
                        .Parameters.AddWithValue("@customer_name", DrSQLite.Item("customer_name"))
                        .Parameters.AddWithValue("@sn", DrSQLite.Item("sn"))
                        .Parameters.AddWithValue("@symptom", DrSQLite.Item("symptom"))
                        .Parameters.AddWithValue("@managerdata", DrSQLite.Item("managerdata"))
                        .Parameters.AddWithValue("@fixrepairnote", DrSQLite.Item("fixrepairnote"))
                        .Parameters.AddWithValue("@fixaccessory", DrSQLite.Item("fixaccessory"))
                        .Parameters.AddWithValue("@fixnote", DrSQLite.Item("fixnote"))
                        .Parameters.AddWithValue("@fixtprice", DrSQLite.Item("fixtprice"))
                        .Parameters.AddWithValue("@varuntee", DrSQLite.Item("varuntee"))
                        .Parameters.AddWithValue("@date_get", DrSQLite.Item("date_get"))
                        .Parameters.AddWithValue("@fixuser", DrSQLite.Item("fixuser"))
                        .Parameters.AddWithValue("@status", DrSQLite.Item("status"))
                        .Parameters.AddWithValue("@user_repair", DrSQLite.Item("user_repair"))
                        .Parameters.AddWithValue("@note_repair", DrSQLite.Item("note_repair"))
                        .Parameters.AddWithValue("@teltocus", DrSQLite.Item("teltocus"))
                        .Parameters.AddWithValue("@date_send", DrSQLite.Item("date_send"))
                        .Parameters.AddWithValue("@datecom_repair", DrSQLite.Item("datecom_repair"))
                        .Parameters.AddWithValue("@importune", DrSQLite.Item("importune"))
                        .Parameters.AddWithValue("@comfix_barcode", DrSQLite.Item("comfix_barcode"))
                    End With
                    Call open_connection()
                    Try
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                End While
            End With

            'Delete
            Try
                cmdSQLite = New SQLiteCommand("DELETE FROM comfix_cache WHERE fix_id='" & Me.dgSDFlistComfix.Rows(RRow).Cells(2).Value & "';", connSQLite)
                Call open_connectionSQLite()
                cmdSQLite.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next

        If MessageBox.Show(Me, "ต้องการจะพิมพ์ใบรับซ่อมหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                cmdSQLite = New SQLiteCommand("DELETE FROM comfix_savedatafixreport", connSQLite)
                Call open_connectionSQLite()
                cmdSQLite.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            For r As Integer = 0 To Me.dgSDFlistComfix.Rows.Count - 1
                cmdSQLite = New SQLiteCommand("INSERT INTO comfix_savedatafixreport(no,txtSDFCusID,lblAutoNumber,txtSDFfixSN,cbbSDFtype," _
                                              & "cbbSDFname,cbbSDFmodel,cbbSDFcolor,cbbSDFRepairType,cbbSDFrepairData," _
                                              & "txtSDFfixaccessory)" _
                                              & "VALUES(@no,@txtSDFCusID,@lblAutoNumber,@txtSDFfixSN,@cbbSDFtype," _
                                              & "@cbbSDFname,@cbbSDFmodel,@cbbSDFcolor,@cbbSDFRepairType,@cbbSDFrepairData," _
                                              & "@txtSDFfixaccessory)", connSQLite)
                With cmdSQLite
                    .Parameters.AddWithValue("@no", Me.dgSDFlistComfix.Rows(r).Cells(0).Value)
                    .Parameters.AddWithValue("@txtSDFCusID", Me.dgSDFlistComfix.Rows(r).Cells(1).Value)
                    .Parameters.AddWithValue("@lblAutoNumber", Me.dgSDFlistComfix.Rows(r).Cells(2).Value)
                    .Parameters.AddWithValue("@txtSDFfixSN", Me.dgSDFlistComfix.Rows(r).Cells(3).Value)
                    .Parameters.AddWithValue("@cbbSDFtype", Me.dgSDFlistComfix.Rows(r).Cells(4).Value)
                    .Parameters.AddWithValue("@cbbSDFname", Me.dgSDFlistComfix.Rows(r).Cells(5).Value)
                    .Parameters.AddWithValue("@cbbSDFmodel", Me.dgSDFlistComfix.Rows(r).Cells(6).Value)
                    .Parameters.AddWithValue("@cbbSDFcolor", Me.dgSDFlistComfix.Rows(r).Cells(7).Value)
                    .Parameters.AddWithValue("@cbbSDFRepairType", Me.dgSDFlistComfix.Rows(r).Cells(8).Value)
                    .Parameters.AddWithValue("@cbbSDFrepairData", Me.dgSDFlistComfix.Rows(r).Cells(9).Value)
                    .Parameters.AddWithValue("@txtSDFfixaccessory", Me.dgSDFlistComfix.Rows(r).Cells(10).Value)
                End With
                Call open_connectionSQLite()
                Try
                    cmdSQLite.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            Next
            If Me.dgSDFlistComfix.Rows.Count = 1 Then
                If checkPrinter() = "A5" Then
                    SaveDataFix1jobPrintA5Frm.ShowDialog(Me)
                ElseIf checkPrinter() = "A4" Then
                    SaveDataFix1jobPrintA4Frm.ShowDialog(Me)
                End If
            Else
                If checkPrinter() = "A5" Then
                    SaveDataFixPrintA5Frm.ShowDialog(Me)
                ElseIf checkPrinter() = "A4" Then
                    SaveDataFixPrintA4Frm.ShowDialog(Me)
                End If
            End If
           
            Call clearDataCacheComfix()
            Me.dgSDFlistComfix.Rows.Clear()
            Call startfrm()
        Else
            Call clearDataCacheComfix()
            Me.dgSDFlistComfix.Rows.Clear()
            Call startfrm()
        End If

        Try
            For Each form In My.Application.OpenForms
                If (form.name = RepairStatusFrm.Name) Then
                    If form.Visible Then
                        RepairStatusFrm.loadCurrentStatus()
                        Exit For
                    End If
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub clearDataCacheComfix()
        For r As Integer = 0 To Me.dgSDFlistComfix.Rows.Count - 1
            cmdSQLite = New SQLiteCommand("DELETE FROM comfix_cache WHERE '" & Me.dgSDFlistComfix.Rows(r).Cells(2).Value & "'", connSQLite)
            Call open_connectionSQLite()
            Try
                cmdSQLite.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next
    End Sub

    Private Sub btnSDFsaveAll_Click(sender As Object, e As EventArgs) Handles btnSDFsaveAll.Click
        If Me.dgSDFlistComfix.RowCount = 0 Then
            MessageBox.Show(Me, "ไม่มีข้อมูลจะบันทึก", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MessageBox.Show(Me, "ต้องการบันทึกทั้งหมด", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Call saveDatalistFixcom()
            End If
        End If
    End Sub

    Private Sub dgSDFlistComfix_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgSDFlistComfix.RowStateChanged
        If Me.dgSDFlistComfix.RowCount = 0 Then
            Me.btnSDFsaveAll.Enabled = False
            Me.txtSDFsearchSN.Enabled = True
            Me.btnSDFsearchSN.Enabled = True
            Me.txtSDFCusID.Enabled = True
            Me.btnSDFSearcdcusID.Enabled = True
            'Me.btnSDFcusadd.Enabled = True
        Else
            Me.btnSDFsaveAll.Enabled = True
            Me.txtSDFsearchSN.Enabled = False
            Me.btnSDFsearchSN.Enabled = False
            Me.txtSDFCusID.Enabled = False
            Me.btnSDFSearcdcusID.Enabled = False
            'Me.btnSDFcusadd.Enabled = False
        End If
    End Sub

    Private Sub druSN(ByVal txtSN As String)
        Try
            cmd = New MySqlCommand("SELECT Snum FROM sn WHERE Snum='" & txtSN & "'", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            If Dr.HasRows Then
                Me.lblSDFcheckSN.Text = "พบ SN นี้ในระบบ กด Enter เพื่อดึงข้อมูลเครื่องได้เลย"
            Else
                Me.lblSDFcheckSN.Text = "ไม่พบ SN นี้ในระบบ"
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        If Me.txtSDFfixSN.Text = String.Empty Then
            Me.ListView1.Enabled = False
            Me.btnTakePicture.Enabled = False
        Else
            Me.ListView1.Enabled = True
            Me.btnTakePicture.Enabled = True
        End If
    End Sub

    Private Sub txtSDFfixSN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSDFfixSN.KeyPress
        Call druSN(Me.txtSDFfixSN.Text)
    End Sub

    Friend comfixConfigMenu As Integer
    Private Sub ProductTypeLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ProductTypeLinkLabel.LinkClicked
        comfixConfigMenu = 50000
        For Each form In My.Application.OpenForms
            If (form.name = ProductFrm.Name) Then
                If form.Visible Then
                    ProductFrm.WindowState = FormWindowState.Normal
                    ProductFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call MainFrm.checkAccess("ข้อมูลประเภทสินค้า")
        If MainFrm.access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf MainFrm.access = 0 Then
            ProductFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
            ProductFrm.ShowDialog(Me)
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        comfixConfigMenu = Nothing
    End Sub

    Private Sub ProductNameLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ProductNameLinkLabel.LinkClicked
        comfixConfigMenu = 50000
        For Each form In My.Application.OpenForms
            If (form.name = ProductNameFrm.Name) Then
                If form.Visible Then
                    ProductNameFrm.WindowState = FormWindowState.Normal
                    ProductNameFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call MainFrm.checkAccess("ข้อมูลยี่ห้อสินค้า")
        If MainFrm.access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf MainFrm.access = 0 Then
            ProductNameFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
            ProductNameFrm.ShowDialog(Me)
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        comfixConfigMenu = Nothing
    End Sub

    Private Sub ProductModelLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ProductModelLinkLabel.LinkClicked
        comfixConfigMenu = 50000
        For Each form In My.Application.OpenForms
            If (form.name = ProductModelFrm.Name) Then
                If form.Visible Then
                    ProductModelFrm.WindowState = FormWindowState.Normal
                    ProductModelFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call MainFrm.checkAccess("ข้อมูลรุ่นสินค้า")
        If MainFrm.access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf MainFrm.access = 0 Then
            ProductModelFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
            ProductModelFrm.ShowDialog(Me)
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        comfixConfigMenu = Nothing
    End Sub

    Private Sub ProductColorLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ProductColorLinkLabel.LinkClicked
        comfixConfigMenu = 50000
        For Each form In My.Application.OpenForms
            If (form.name = ProductColorFrm.Name) Then
                If form.Visible Then
                    ProductColorFrm.WindowState = FormWindowState.Normal
                    ProductColorFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call MainFrm.checkAccess("ข้อมูลสีตัวสินค้า")
        If MainFrm.access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf MainFrm.access = 0 Then
            ProductColorFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
            ProductColorFrm.ShowDialog(Me)
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        comfixConfigMenu = Nothing
    End Sub

    Private Sub FixComLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles FixComLinkLabel.LinkClicked
        comfixConfigMenu = 50000
        For Each form In My.Application.OpenForms
            If (form.name = FixcomFrm.Name) Then
                If form.Visible Then
                    FixcomFrm.WindowState = FormWindowState.Normal
                    FixcomFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call MainFrm.checkAccess("ข้อมูลอาการเสีย")
        If MainFrm.access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf MainFrm.access = 0 Then
            FixcomFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
            FixcomFrm.ShowDialog(Me)
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        comfixConfigMenu = Nothing
    End Sub

    Private Sub ManagerDataLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ManagerDataLinkLabel.LinkClicked
        comfixConfigMenu = 50000
        For Each form In My.Application.OpenForms
            If (form.name = ManagerdataFrm.Name) Then
                If form.Visible Then
                    ManagerdataFrm.WindowState = FormWindowState.Normal
                    ManagerdataFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call MainFrm.checkAccess("ข้อมูลการจัดการข้อมูล")
        If MainFrm.access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf MainFrm.access = 0 Then
            ManagerdataFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
            ManagerdataFrm.ShowDialog(Me)
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        comfixConfigMenu = Nothing
    End Sub

    Private Sub AccessoryLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AccessoryLinkLabel.LinkClicked
        comfixConfigMenu = 50000
        For Each form In My.Application.OpenForms
            If (form.name = AccessoryEditFrm.Name) Then
                If form.Visible Then
                    AccessoryEditFrm.WindowState = FormWindowState.Normal
                    AccessoryEditFrm.BringToFront()
                    Exit Sub
                End If
            End If
        Next
        Call MainFrm.checkAccess("ข้อมูลอุปกรณ์ที่นำมาด้วย")
        If MainFrm.access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf MainFrm.access = 0 Then
            AccessoryEditFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
            AccessoryEditFrm.ShowDialog(Me)
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        comfixConfigMenu = Nothing
    End Sub

    Private Sub FixHitoryBySNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FixHitoryBySNToolStripMenuItem.Click
        FixHitoryBySNFrm.ShowDialog(Me)
    End Sub

    Private Sub txtSDFfixSN_TextChanged(sender As Object, e As EventArgs) Handles txtSDFfixSN.TextChanged
        Call druSN(Me.txtSDFfixSN.Text)
        Call MainFrm.SearchComfixBySN(Me.txtSDFfixSN.Text)
    End Sub

    Private Sub ListView1_EnabledChanged(sender As Object, e As EventArgs) Handles ListView1.EnabledChanged
        If Me.ListView1.Enabled = True Then
            If Me.lblAutoNumber.Text = Nothing Then
                Call ALLAutonumber("ver_fixid", Me.lblAutoNumber.Text)
            End If
        End If
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

    Private Sub txtSDFCusID_TextChanged(sender As Object, e As EventArgs) Handles txtSDFCusID.TextChanged
        If Me.txtSDFCusID.Text <> Nothing Then
            Call MainFrm.SearchSaleByCusID(Me.txtSDFCusID.Text)
        End If
    End Sub

    Private Sub btnHelp_Click_1(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/comfix/savedatafixfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class