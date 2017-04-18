Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class ClaimsComfixBackFrm

    Private Sub ClaimsComfixBackFrm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub ClaimsComfixBackFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Friend Sub getdataClaims(ByVal txtCCBsearchSN As String)
        Dim stus As String = String.Empty
        Dim csid As String = String.Empty
        Try
            strSQL = "SELECT customer_id,status FROM claims WHERE serial_pro='" & txtCCBsearchSN & "' AND status='ซ่อมเสร็จ'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            stus = Dr.GetString("status")
            csid = Dr.GetString("customer_id")
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        If stus = "ซ่อมเสร็จ" Then
            Try
                strSQL = "SELECT claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro," _
                    & "price_buy,type,unit,datetime_sale,tel_to_cus,employee_sale,symptom," _
                    & "accressory,note FROM claims WHERE serial_pro='" & txtCCBsearchSN & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                If Dr.HasRows Then
                    While (Dr.Read())
                        Me.txtCCBclaims_id.Text = Dr.GetString("claims_id")
                        Me.txtCCBsn.Text = Dr.GetString("serial_pro")
                        Me.txtCCBcus_id.Text = Dr.GetString("customer_id")
                        Me.txtCCBcode_pro.Text = Dr.GetString("code_pro")
                        Me.txtCCBbar_code.Text = Dr.GetString("bar_code")
                        Me.txtCCBname_pro.Text = Dr.GetString("name_pro")
                        Me.txtCCBprice_buy.Text = Dr.GetString("price_buy")
                        Me.txtCCBtype.Text = Dr.GetString("type")
                        Me.txtCCBunit.Text = Dr.GetString("unit")
                        Me.txtCCBdatetime_sale.Text = Dr.GetString("datetime_sale")
                        Me.txtCCBemployee_sale.Text = Dr.GetString("employee_sale")
                        Me.txtCCBsyptom.Text = Dr.GetString("symptom")
                        Me.txtCCBaccessory.Text = Dr.GetString("accressory")
                        Me.txtCCBnote.Text = Dr.GetString("note")
                        Me.cbbCCBtel_to_cus.Text = Dr.GetString("tel_to_cus")
                    End While
                End If

                strSQL = "SELECT customer_name,customer_tel FROM customer WHERE customer_id='" & Me.txtCCBcus_id.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                Me.txtCCBcus_name.Text = Dr.GetString("customer_name")
                Me.txtCCBcus_tel.Text = Dr.GetString("customer_tel")
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Dim c_id As String = String.Empty
            Try
                strSQL = "SELECT fix_id FROM comfix WHERE claims_id='" & Me.txtCCBclaims_id.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                c_id = Dr.GetString("fix_id")

                Dim summ As Integer
                strSQL = "SELECT SUM(total_all + 0) FROM sale WHERE fix_id='" & c_id & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                summ = Dr(0)
                Me.txtCCBprice_fix.Text = summ
            Catch ex As Exception
                Me.txtCCBprice_fix.Text = 0
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Else
            MsgBox("ไม่พบข้อมูลส่งกลับงานซ่อมของ SN ชิ้นนี้", MsgBoxStyle.Information, "แจ้งเตือน")
            Call ClearTextBoxes(Me)
        End If
    End Sub

    Private Sub btnCCBcancel_Click(sender As Object, e As EventArgs)
        Call ClearTextBoxes(Me)
    End Sub

    Private Sub txtCCBclaims_id_TextChanged(sender As Object, e As EventArgs) Handles txtCCBclaims_id.TextChanged
        Me.btnCCBsave.Enabled = True
    End Sub

    Private Sub btnCCBsave_Click(sender As Object, e As EventArgs) Handles btnCCBsave.Click
        If MessageBox.Show(Me, "คุณแน่ใจว่าจะบันทึกข้อมูลนี้", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If Me.txtCCBcus_id.Text = "สินค้าจากสต็อก" Then
                Try
                    'ส่งเข้าสต็อก
                    'insert into product_serial
                    strSQL = "INSERT INTO product_serial(code_pro,serial_pro,name_pro,date_in)" _
                           & "VALUES(@code_pro,@serial_pro,@name_pro,@date_in)"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    With cmd
                        .Parameters.AddWithValue("@code_pro", Me.txtCCBcode_pro.Text)
                        .Parameters.AddWithValue("@serial_pro", Me.txtCCBsn.Text)
                        .Parameters.AddWithValue("@name_pro", Me.txtCCBname_pro.Text)
                        .Parameters.AddWithValue("@date_in", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")))
                    End With
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try

                'sum count_num product
                Dim cp As String = String.Empty
                Dim scp As Integer = Nothing
                Try
                    strSQL = "SELECT count_num FROM product WHERE code_pro='" & Me.txtCCBcode_pro.Text & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader()
                    Dr.Read()
                    cp = Dr.GetString("count_num")
                    scp = CInt(cp) + 1
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try

                Try
                    'update count_num product
                    strSQL = "UPDATE product SET count_num='" & scp & "' WHERE code_pro='" & Me.txtCCBcode_pro.Text & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try

                Try
                    'update status claims
                    strSQL = "UPDATE claims SET `status`='ส่งคืนแล้ว' WHERE claims_id='" & Me.txtCCBclaims_id.Text & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try

                Try
                    'update claims send
                    strSQL = "UPDATE claims_send SET claims_send_status='ส่งคืนแล้ว' WHERE claims_id='" & Me.txtCCBclaims_id.Text & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
                Call ClearTextBoxes(Me)
                ClaimsStatusFrm.getdataClaims(100, "รอส่งคืน")
                MsgBox("บันทึกคืนสต็อกแล้ว", MsgBoxStyle.Information, "แจ้งให้ทราบ")
            Else
                Try
                    strSQL = "UPDATE claims SET status='" & "รอส่งคืน" & "',datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss",
                                    CultureInfo.CreateSpecificCulture("en-US")) & "',employee='" & Me.lblEmployee.Text & "'" _
                                    & ",tel_to_cus='" & Me.cbbCCBtel_to_cus.Text & "' WHERE claims_id='" & Me.txtCCBclaims_id.Text & "'"

                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
                Call ClearTextBoxes(Me)
                ClaimsStatusFrm.getdataClaims(100, "รอส่งคืน")
                MsgBox("บันทึกเข้าระบบเคลมแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
                Me.Close()
            End If
        End If
    End Sub
End Class