Imports MySql.Data.MySqlClient
Imports BarcodeLib.Barcode
Imports System.Globalization

Public Class ClaimsImportProMiniCUSFrm
    Dim LinearEncoder As New BarcodeLib.Barcode

    Private Sub ClaimsImportProMiniCUSFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

   
    Private Sub ClaimsImportProMiniCUSFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = MainFrm.Icon
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.rbCIPreturnClaimsCus.Checked = True Then
            Dim claimsID As String = String.Empty
            Call ALLAutonumber("ver_claims", claimsID)
            'ส่งเคลมอีกรอบ
            Dim txtCFcode_pro As String = String.Empty
            Dim txtCFname_pro As String = String.Empty
            Dim txtCFbar_code As String = String.Empty
            Dim txtCFdatetime_sale As String = String.Empty
            Dim txtCFemployee_sale As String = String.Empty
            Dim txtCFprice_buy As Decimal = Nothing
            Dim txtCFprice_wholsale As Decimal = Nothing
            Dim txtCFprice_technician As Decimal = Nothing
            Dim txtCFprice_loyal As Decimal = Nothing
            Dim txtCFprice_members As Decimal = Nothing
            Dim txtCFunit As String = String.Empty
            Dim txtCFtype As String = String.Empty
            Try
                strSQL = "SELECT code_pro,bar_code,name_pro," _
                    & "price_buy,price_wholesale,price_technician,price_loyal,price_members,`type`," _
                    & "unit,datetime_sale,employee_sale FROM claims WHERE claims_id='" & Me.dgCIPcus.Rows(0).Cells(1).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                With Dr
                    txtCFcode_pro = .Item("code_pro")
                    txtCFname_pro = .Item("name_pro")
                    txtCFbar_code = .Item("bar_code")
                    txtCFprice_buy = .GetDecimal("price_buy")
                    txtCFprice_wholsale = .GetDecimal("price_wholesale")
                    txtCFprice_technician = .GetDecimal("price_technician")
                    txtCFprice_loyal = .GetDecimal("price_loyal")
                    txtCFprice_members = .GetDecimal("price_members")
                    txtCFunit = .Item("unit")
                    txtCFtype = .Item("type")
                    txtCFdatetime_sale = .Item("datetime_sale")
                    txtCFemployee_sale = .Item("employee_sale")
                End With
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Dim barcodeClaimsID As Image = Nothing
            Try
                barcodeClaimsID = LinearEncoder.Encode(BarcodeLib.TYPE.CODE128B, claimsID, Color.Black, Color.White)
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                'บันทึกข้อมูล
                strSQL = "INSERT INTO claims(claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,price_buy," _
                    & "price_wholesale,price_technician,price_loyal,price_members,type,unit,datetime_sale,employee_sale," _
                    & "symptom,accressory,note,status,employee,datetime_save,claims_id_pic) " _
                    & " VALUES(@claims_id,@customer_id,@serial_pro,@code_pro,@bar_code,@name_pro," _
                    & "@price_buy,@price_wholesale,@price_technician,@price_loyal,@price_members," _
                    & "@type,@unit,@datetime_sale,@employee_sale,@symptom,@accressory,@note,@status," _
                    & "@employee,@datetime_save,@claims_id_pic)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@claims_id", claimsID))
                    .Parameters.Add(New MySqlParameter("@customer_id", Me.dgCIPcus.Rows(0).Cells(2).Value))
                    .Parameters.Add(New MySqlParameter("@serial_pro", Me.dgCIPcus.Rows(0).Cells(5).Value))
                    .Parameters.Add(New MySqlParameter("@code_pro", Me.dgCIPcus.Rows(0).Cells(7).Value))
                    .Parameters.Add(New MySqlParameter("@bar_code", txtCFbar_code))
                    .Parameters.Add(New MySqlParameter("@name_pro", txtCFname_pro))
                    .Parameters.Add(New MySqlParameter("@price_buy", txtCFprice_buy))
                    .Parameters.Add(New MySqlParameter("@price_wholesale", txtCFprice_wholsale))
                    .Parameters.Add(New MySqlParameter("@price_technician", txtCFprice_technician))
                    .Parameters.Add(New MySqlParameter("@price_loyal", txtCFprice_loyal))
                    .Parameters.Add(New MySqlParameter("@price_members", txtCFprice_members))
                    .Parameters.Add(New MySqlParameter("@type", txtCFtype))
                    .Parameters.Add(New MySqlParameter("@unit", txtCFunit))
                    .Parameters.Add(New MySqlParameter("@datetime_sale", txtCFdatetime_sale))
                    .Parameters.Add(New MySqlParameter("@employee_sale", txtCFemployee_sale))
                    .Parameters.Add(New MySqlParameter("@symptom", Me.dgCIPcus.Rows(0).Cells(9).Value))
                    .Parameters.Add(New MySqlParameter("@accressory", Me.dgCIPcus.Rows(0).Cells(10).Value))
                    .Parameters.Add(New MySqlParameter("@note", "ส่งเคลมอีกรอบ"))
                    .Parameters.Add(New MySqlParameter("@status", "รับเข้าระบบ"))
                    .Parameters.Add(New MySqlParameter("@employee", ClaimsImportProFrm.lblEmployee.Text))
                    .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss",
                                                                                               CultureInfo.CreateSpecificCulture("en-US"))))
                    Using stream As New IO.MemoryStream
                        barcodeClaimsID.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
                        Dim arrImage() As Byte = stream.GetBuffer()
                        cmd.Parameters.AddWithValue("@claims_id_pic", arrImage)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using
                End With
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                'update status claims
                strSQL = "UPDATE claims SET " _
                     & "datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "'," _
                     & "`status`='ส่งคืนแล้ว' WHERE claims_id='" & Me.dgCIPcus.Rows(0).Cells(1).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                'update claims send
                strSQL = "UPDATE claims_send SET claims_send_status='ส่งคืนแล้ว'," _
                    & "datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss",
                                   CultureInfo.CreateSpecificCulture("en-US")) & "' WHERE claims_id='" & Me.dgCIPcus.Rows(0).Cells(1).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                'ย้ายข้อมูลงานเคลมที่ส่งคืนแล้ว
                strSQL = "INSERT INTO claims_copy(claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,price_buy,price_wholesale,price_technician,price_loyel,price_members,`type`,unit,datetime_sale,datetime_return,datetime_edit,claims_money,employee_claims_return,tel_to_cus,employee_sale,symptom,accressory,note,note2,`status`,employee,datetime_save,claims_id_pic)" _
                    & "SELECT * FROM claims WHERE claims_id='" & Me.dgCIPcus.Rows(0).Cells(1).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                strSQL = "DELETE FROM claims WHERE claims_id='" & Me.dgCIPcus.Rows(0).Cells(1).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                Call ClaimsImportProFrm.getDataClaims()
                MsgBox("บันทึกส่งเคลมอีกรอบแล้ว", MsgBoxStyle.Information, "แจ้งให้ทราบ")
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Me.Close()
        ElseIf Me.rbCIPreturnCus.Checked = True Then
            'รอส่งคืนลูกค้า
            Try
                'update status claims
                strSQL = "UPDATE claims SET serial_pro='" & Me.dgCIPcus.Rows(0).Cells(5).Value & "'," _
                 & "datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "'," _
                 & "`status`='รอส่งคืน' WHERE claims_id='" & Me.dgCIPcus.Rows(0).Cells(1).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception

            End Try

            Try
                'update claims send
                strSQL = "UPDATE claims_send SET claims_send_status='รอส่งคืน'," _
                    & "datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "' " _
                    & "WHERE claims_id='" & Me.dgCIPcus.Rows(0).Cells(1).Value & "'"

                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception

            End Try
            Call ClaimsImportProFrm.getDataClaims()
            MsgBox("บันทึกรอส่งคืนแล้ว", MsgBoxStyle.Information, "แจ้งให้ทราบ")
            Me.Close()
        End If
    End Sub
End Class