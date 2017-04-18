Imports System.Globalization
Imports MySql.Data.MySqlClient
Imports BarcodeLib.Barcode

Public Class EditClaimsStatusFrm
    Dim LinearEncoder As New BarcodeLib.Barcode
    Private Sub getdata(ByVal claimsID As String)
        Try
            strSQL = "SELECT serial_pro,code_pro,bar_code,name_pro,price_buy," _
                    & "type,unit,symptom,accressory,status,employee FROM claims WHERE claims_id='" & claimsID & "';"
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                Me.txtECSsn.Text = Dr.Item("serial_pro")
                Me.txtECScode_pro.Text = Dr.Item("code_pro")
                Me.txtECSbar_code.Text = Dr.Item("bar_code")
                Me.txtECSname_pro.Text = Dr.Item("name_pro")
                Me.txtECSprice_buy.Text = Dr.Item("price_buy")
                Me.txtECStype.Text = Dr.Item("type")
                Me.txtECSunit.Text = Dr.Item("unit")
                Me.txtECSsymptom.Text = Dr.Item("symptom")
                Me.txtECSaccessory.Text = Dr.Item("accressory")
                Me.txtECSstatus.Text = Dr.Item("status")
                Me.txtECSemployee.Text = Dr.Item("employee")
            End Using
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub txtECSclaimsID_TextChanged(sender As Object, e As EventArgs) Handles txtECSclaimsID.TextChanged
        Call getdata(Me.txtECSclaimsID.Text)
    End Sub

    Dim lblAutoNumber As String
    Private Sub getautonumber()
        lblAutoNumber = String.Empty
        Call ALLAutonumber("ver_fixid", lblAutoNumber)
    End Sub

    Private Sub sendDataToComfix()
        Try
            'save data
            strSQL = "INSERT INTO comfix (fix_id,claims_id,date_save,customer_id,customer_name,sn,symptom,managerdata,fixrepairnote,fixaccessory,fixnote,fixtprice, " _
                & "varuntee,date_get,fixuser,status,user_repair,note_repair,teltocus,date_send,comfix_barcode)VALUES " _
                & "(@fix_id,@claims_id,@date_save,@customer_id,@customer_name,@sn,@symptom,@managerdata,@fixrepairnote,@fixaccessory,@fixnote,@fixtprice," _
                & "@varuntee,@date_get,@fixuser,@status,@user_repair,@note_repair,@teltocus,@date_send,@comfix_barcode)"
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.AddWithValue("@fix_id", lblAutoNumber)
                cmd.Parameters.AddWithValue("@claims_id", Me.txtECSclaimsID.Text)
                cmd.Parameters.AddWithValue("@date_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")))
                cmd.Parameters.AddWithValue("@customer_id", Me.txtECScus_id.Text)
                cmd.Parameters.AddWithValue("@customer_name", Me.txtECScus_name.Text)
                cmd.Parameters.AddWithValue("@sn", Me.txtECSsn.Text)
                cmd.Parameters.AddWithValue("@symptom", Me.txtECSsymptom.Text)
                cmd.Parameters.AddWithValue("@managerdata", "-")
                cmd.Parameters.AddWithValue("@fixrepairnote", "ส่งมาจากงานเคลม")
                cmd.Parameters.AddWithValue("@fixaccessory", Me.txtECSaccessory.Text)
                cmd.Parameters.AddWithValue("@fixnote", "-")
                cmd.Parameters.AddWithValue("@fixtprice", "-")
                cmd.Parameters.AddWithValue("@varuntee", "-")
                cmd.Parameters.AddWithValue("@date_get", "-")
                cmd.Parameters.AddWithValue("@fixuser", ClaimsStatusFrm.lblEmployee.Text)
                cmd.Parameters.AddWithValue("@status", "1 รอซ่อม")
                cmd.Parameters.AddWithValue("@user_repair", "-")
                cmd.Parameters.AddWithValue("@note_repair", "-")
                cmd.Parameters.AddWithValue("@teltocus", "-")
                'cmd.Parameters.AddWithValue("@sale_id", "-")
                cmd.Parameters.AddWithValue("@date_send", "-")
                Using stream As New IO.MemoryStream
                    picBarcode.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim arrImage() As Byte = stream.GetBuffer()
                    cmd.Parameters.AddWithValue("@comfix_barcode", arrImage)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            strSQL = "INSERT INTO comfix_id(fix_id,datetime_save)VALUES" _
                    & "(@fix_id,@datetime_save)"
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.AddWithValue("@fix_id", lblAutoNumber)
                cmd.Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")))
                Call open_connection()
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            strSQL = "UPDATE claims SET status='ส่งไปงานช่าง' WHERE claims_id='" & Me.txtECSclaimsID.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub addsn()
        Try
            strSQL = "select Snum from sn where Snum='" & Me.txtECSsn.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        If Not Dr.HasRows Then
            Try
                strSQL = "INSERT INTO sn (Snum,p_type,p_name,model,color,startdate)VALUES" _
                       & "(@Snum,@p_type,@p_name,@model,@color,@startdate)"
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    cmd.Parameters.AddWithValue("@Snum", Me.txtECSsn.Text)
                    cmd.Parameters.AddWithValue("@p_type", Me.txtECStype.Text)
                    cmd.Parameters.AddWithValue("@p_name", Me.txtECSname_pro.Text)
                    cmd.Parameters.AddWithValue("@model", "-")
                    cmd.Parameters.AddWithValue("@color", "-")
                    cmd.Parameters.AddWithValue("@startdate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")))
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        ElseIf Dr.HasRows Then
            Exit Sub
        End If
    End Sub

    Private Sub cbbECSclaimsStatus_DropDown(sender As Object, e As EventArgs) Handles cbbECSclaimsStatus.DropDown
        Me.cbbECSclaimsStatus.Items.Clear()
        If Me.txtECSstatus.Text = "รับเข้าระบบ" And Me.txtECScus_id.Text = "สินค้าจากสต็อก" Then
            Me.cbbECSclaimsStatus.Items.Add("ส่งซ่อม")
        ElseIf Me.txtECSstatus.Text = "รับเข้าระบบ" Then
            Me.cbbECSclaimsStatus.Items.Add("ส่งซ่อม")
            Me.cbbECSclaimsStatus.Items.Add("รอส่งคืน")
            Me.cbbECSclaimsStatus.Items.Add("รอคืนเงิน")
        End If
    End Sub

    Private Sub cbbECSclaimsStatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbECSclaimsStatus.KeyPress
        e.Handled = True
    End Sub

    Private Sub EditClaimsStatusFrm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub EditClaimsStatusFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Private Sub btnECScancel_Click(sender As Object, e As EventArgs) Handles btnECScancel.Click
        Me.Close()
    End Sub
    Private Sub btnECSsave_Click(sender As Object, e As EventArgs) Handles btnECSsave.Click
        If Me.cbbECSclaimsStatus.Text = "รอคืนเงิน" Then
            If Me.txtECSsendMoney.Text = Nothing Then
                Me.txtECSsendMoney.BackColor = Color.OrangeRed
                MsgBox("กรุณาระบุสาเหตุการคืนเงิน", MsgBoxStyle.Information, "แจ้งเตือน")
                Exit Sub
            Else
                If MessageBox.Show(Me, "คุณแน่ใจว่าต้องการจะเปลี่ยนสถานะสินค้าเคลมนี้เป็น รอคืนเงิน", "ยืนยัน", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question) = DialogResult.No Then
                    Me.Label14.Visible = False
                    Me.txtECSsendMoney.Visible = False
                    Me.cbbECSclaimsStatus.Items.Clear()
                    Exit Sub
                Else
                    Call sendmoney()
                    MsgBox("เปลี่ยนสถานะสินค้าเคลมนี้เป็น รอคืนเงิน เรียบร้อยแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
                    Call ClaimsStatusFrm.getdataClaims(100, "รอคืนเงิน")
                    Me.Label14.Visible = False
                    Me.txtECSsendMoney.Visible = False
                    Me.cbbECSclaimsStatus.Items.Clear()
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lblECSstatusSelect.BackColor = Color.OrangeRed
        Me.cbbECSclaimsStatus.BackColor = Color.OrangeRed
        If Me.lblECSstatusSelect.Visible = True Then
            Me.lblECSstatusSelect.Visible = False
        Else
            Me.lblECSstatusSelect.Visible = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.lblECSstatusSelect.BackColor = SystemColors.Control
        Me.cbbECSclaimsStatus.BackColor = SystemColors.Window
        Me.Timer1.Stop()
        Me.Timer2.Stop()
    End Sub
    Private Sub sendmoney()
        Try
            strSQL = "UPDATE claims SET status='รอคืนเงิน',datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss",
                        CultureInfo.CreateSpecificCulture("en-US")) & "', employee='" & ClaimsStatusFrm.lblEmployee.Text & "'," _
                        & "note='" & Me.txtECSsendMoney.Text & "' WHERE claims_id='" & Me.txtECSclaimsID.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Dim picBarcode As Image
    Private Sub cbbECSclaimsStatus_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbECSclaimsStatus.SelectedValueChanged
        If Me.cbbECSclaimsStatus.Text = "ส่งซ่อม" Then
            If MessageBox.Show(Me, "คุณแน่ใจว่าจะส่งข้อมูลนี้ไปงานช่าง เมื่อส่งข้อมูลไปแล้วสถานะจะไปปรากฎที่งานช่าง", "ยืนยัน",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Me.cbbECSclaimsStatus.Items.Clear()
                Exit Sub
            Else
                Call getautonumber()
                picBarcode = LinearEncoder.Encode(BarcodeLib.TYPE.CODE128B, lblAutoNumber, Color.Black, Color.White)
                Call addsn()
                Call sendDataToComfix()
                MsgBox("ส่งข้อมูลไปงานช่างเรียบร้อยแล้ว", MsgBoxStyle.Information, "ส่งข้อมูลเรียบร้อย")
                Call ClaimsStatusFrm.getdataClaims(100, "ส่งซ่อม")
                Me.cbbECSclaimsStatus.Items.Clear()
                Me.Close()
            End If
        ElseIf Me.cbbECSclaimsStatus.Text = "รอคืนเงิน" Then
            Me.Label14.Visible = True
            Me.txtECSsendMoney.Visible = True
        ElseIf Me.cbbECSclaimsStatus.Text = "รอส่งคืน" Then
            ReturnClaimsFrm.txtRCclaimsID.Text = Me.txtECSclaimsID.Text
            ReturnClaimsFrm.txtRCaccessory.Text = Me.txtECSaccessory.Text
            ReturnClaimsFrm.ShowDialog(Me)
        End If
        Call EnableControl()
    End Sub

    Private Sub EnableControl()
        If Me.cbbECSclaimsStatus.Text <> Nothing Then
            Me.btnECSsave.Enabled = True
            If Me.cbbECSclaimsStatus.Text = "รอคืนเงิน" Then
                Me.Label14.Visible = True
                Me.txtECSsendMoney.Visible = True
            Else
                Me.Label14.Visible = False
                Me.txtECSsendMoney.Visible = False
            End If
        Else
            Me.btnECSsave.Enabled = False
            Me.Label14.Visible = False
            Me.txtECSsendMoney.Visible = False
        End If
    End Sub

    Private Sub txtECSsendMoney_Click(sender As Object, e As EventArgs) Handles txtECSsendMoney.Click
        Me.txtECSsendMoney.BackColor = SystemColors.Window
    End Sub

    Private Sub cbbECSclaimsStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbECSclaimsStatus.SelectedIndexChanged
        Call EnableControl()
    End Sub
End Class