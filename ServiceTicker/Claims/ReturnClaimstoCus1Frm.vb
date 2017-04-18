Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class ReturnClaimstoCus1Frm
    Friend Sub getdataClaims(ByVal cid As String)
        Try
            strSQL = "SELECT claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,price_buy," _
                & "type,unit,datetime_sale,datetime_edit,symptom,accressory,note,datetime_save " _
                & "FROM claims WHERE claims_id='" & cid & "'"
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                Me.txtRCTC1claims_id.Text = Dr.GetString("claims_id")
                Me.txtRCTC1cus_id.Text = Dr.GetString("customer_id")
                Me.txtRCTC1serial_pro.Text = Dr.GetString("serial_pro")
                Me.txtRCTC1code_pro.Text = Dr.GetString("code_pro")
                Me.txtRCTC1bar_code.Text = Dr.GetString("bar_code")
                Me.txtRCTC1name_pro.Text = Dr.GetString("name_pro")
                Me.txtRCTC1price_buy.Text = Dr.GetString("price_buy")
                Me.txtRCTC1type.Text = Dr.GetString("type")
                Me.txtRCTC1unit.Text = Dr.GetString("unit")
                Me.txtRCTC1datetime_sale.Text = Dr.GetString("datetime_sale")
                Me.txtRCTC1datetime_save.Text = Dr.GetString("datetime_save")
                Me.txtRCTC1datetime_edit.Text = Dr.GetString("datetime_edit")
                Me.txtRCTC1symptom.Text = Dr.GetString("symptom")
                Me.txtRCTCaccessory.Text = Dr.GetString("accressory")
                Me.txtRCTC1fix.Text = Dr.GetString("note")
            End Using
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            strSQL = "SELECT customer_name,customer_tel FROM customer WHERE customer_id='" & Me.txtRCTC1cus_id.Text & "'"
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                Me.txtRCTC1cus_name.Text = Dr.GetString("customer_name")
                Me.txtRCTC1cus_tel.Text = Dr.GetString("customer_tel")
            End Using
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Private Sub updateClaimsReturn()
        If MessageBox.Show("ต้องการบันทึกคืนสินค้าเคลม", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                strSQL = "UPDATE claims SET datetime_return=@dtrt,employee_claims_return=@emcr," _
                    & "status=@sta WHERE claims_id='" & Me.txtRCTC1claims_id.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.AddWithValue("@dtrt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")))
                    .Parameters.AddWithValue("@emcr", Me.lblEmployee.Text)
                    .Parameters.AddWithValue("@sta", "ส่งคืนแล้ว")
                    Call open_connection()
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                strSQL = "INSERT INTO claims_copy(claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro," _
                    & "price_buy,price_wholesale,price_technician,price_loyel,price_members,`type`,unit," _
                    & "datetime_sale,datetime_return,datetime_edit,claims_money,employee_claims_return," _
                    & "tel_to_cus,employee_sale,symptom,accressory,note,note2,`status`,employee,datetime_save,claims_id_pic)" _
                    & "SELECT * FROM claims WHERE claims_id='" & Me.txtRCTC1claims_id.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                strSQL = "DELETE FROM claims WHERE claims_id='" & Me.txtRCTC1claims_id.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Call ReturnClaimsToCusFrm.getdataClaims(100, Nothing)
            Call ClaimsStatusFrm.getdataClaims(100, "รอส่งคืน")
            If MessageBox.Show(Me, "บันทึกส่งคืนแล้ว" & vbNewLine & "ต้องการจะพิมพ์ใบส่งคืนสินค้าเคลมหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If checkPrinter() = "A4" Then
                    ReturnClaimsToCusReportPrintFrmA4.ShowDialog(Me)
                ElseIf checkPrinter() = "A5" Then
                    ReturnClaimsToCusReportPrintFrmA5.ShowDialog(Me)
                End If
            End If
            Me.Close()
        End If
    End Sub

    Private Sub ReturnClaimstoCus1Frm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ReturnClaimstoCus1Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
    End Sub

    Private Sub btnRCTC1save_Click(sender As Object, e As EventArgs) Handles btnRCTC1save.Click
        Call updateClaimsReturn()
    End Sub
End Class