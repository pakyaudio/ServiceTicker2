Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class ProgressGetCheckStockBarCodeFrm
    Private Sub GetChectStock1()

        If sg = 10 Then

            CheckStoclBarcodeFrm.dgCSBC.Rows.Clear()
            Try
                strSQL = "SELECT Max(id) as ID FROM check_stock_bc_id"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                If Not Dr.HasRows Then
                    CheckStoclBarcodeFrm.txtCSBCid.Text = Now.ToString("yyMMddHHmm") & "00001"
                Else
                    Dim newID As Integer = CInt(Dr.Item("ID"))
                    newID += 1
                    CheckStoclBarcodeFrm.txtCSBCid.Text = "CKBC" & Now.ToString("yyMMddHHmm") & newID.ToString("00000")
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                strSQL = "SELECT code_pro,bar_code,name_pro,price_buy,count_num FROM product WHERE service_chart='0';"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                While Dr.Read()
                    Dim cn0 As Integer = Dr.GetDecimal("count_num")
                    Dim r As Integer
                    With CheckStoclBarcodeFrm.dgCSBC
                        If cn0 > 0 Then
                            r = .Rows.Count
                            .Rows.Add()
                            .Rows(r).Cells(1).Value = Dr.GetString("code_pro")
                            .Rows(r).Cells(2).Value = Dr.GetString("bar_code")
                            .Rows(r).Cells(3).Value = Dr.GetString("name_pro")
                            .Rows(r).Cells(4).Value = Dr.GetString("price_buy")
                            .Rows(r).Cells(5).Value = Dr.GetDecimal("count_num")
                            .Rows(r).Cells(6).Value = "0"
                        End If
                    End With
                End While
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        ElseIf sg = 20 Then
            Try
                For num As Integer = 0 To CheckStoclBarcodeFrm.dgCSBC.Rows.Count - 1
                    strSQL = "SELECT COUNT(code_pro) AS cp FROM product_serial WHERE code_pro='" & CheckStoclBarcodeFrm.dgCSBC.Rows(num).Cells(1).Value & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    Dr.Read()
                    Dim cu As Integer = Dr.Item("cp")
                    CheckStoclBarcodeFrm.dgCSBC.Rows(num).Cells(5).Value = CInt(CheckStoclBarcodeFrm.dgCSBC.Rows(num).Cells(5).Value) - cu
                Next
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        ElseIf sg = 30 Then
            Try
                'ลบบรรทัดที่เหลือ 0
                For iiii As Integer = CheckStoclBarcodeFrm.dgCSBC.Rows.Count - 1 To 0 Step -1
                    If CheckStoclBarcodeFrm.dgCSBC.Rows(iiii).Cells(5).Value = 0 Then
                        CheckStoclBarcodeFrm.dgCSBC.Rows.Remove(CheckStoclBarcodeFrm.dgCSBC.Rows(iiii))
                    End If
                Next iiii

            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        ElseIf sg = 40 Then
            Try
                For noo As Integer = 0 To CheckStoclBarcodeFrm.dgCSBC.Rows.Count - 1
                    CheckStoclBarcodeFrm.dgCSBC.Rows(noo).Cells(0).Value = noo + 1
                Next
                Call CheckStoclBarcodeFrm.sumTotalPro()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        ElseIf sg = 50 Then
            Try
                strSQL = "INSERT INTO check_stock_bc_id(csbc_id,total_pro_bc,count_num,disappear,over,csbc_status,datetime_save,datetime_last,employee)" _
                & "VALUES(@csbc_id,@total_pro_bc,@count_num,@disappear,@over,@csbc_status,@datetime_save,@datetime_last,@employee)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@csbc_id", CheckStoclBarcodeFrm.txtCSBCid.Text))
                    .Parameters.Add(New MySqlParameter("@total_pro_bc", CheckStoclBarcodeFrm.txtCSBCtotalPro.Text))
                    .Parameters.Add(New MySqlParameter("@count_num", CheckStoclBarcodeFrm.txtCSBCcNumPro.Text))
                    .Parameters.Add(New MySqlParameter("@disappear", CheckStoclBarcodeFrm.txtCSBCfail.Text))
                    .Parameters.Add(New MySqlParameter("@over", CheckStoclBarcodeFrm.txtCSBCfull.Text))
                    .Parameters.Add(New MySqlParameter("@csbc_status", "เตรียมสต็อกเสร็จสิ้น"))
                    .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss",
                                                                                               CultureInfo.CreateSpecificCulture("en-US"))))
                    .Parameters.Add(New MySqlParameter("@datetime_last", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss",
                                                                                               CultureInfo.CreateSpecificCulture("en-US"))))
                    .Parameters.Add(New MySqlParameter("@employee", CheckStoclBarcodeFrm.lblEmployee.Text))
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End With
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                For cbc As Integer = 0 To CheckStoclBarcodeFrm.dgCSBC.Rows.Count - 1
                    strSQL = "INSERT INTO check_stock_bc(csbc_id,code_pro,bar_code,name_pro,price_buy,count_num,count,datetime_save)" _
                  & "VALUES(@csbc_id,@code_pro,@bar_code,@name_pro,@price_buy,@count_num,@count,@datetime_save)"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    With cmd
                        .Parameters.Add(New MySqlParameter("@csbc_id", CheckStoclBarcodeFrm.txtCSBCid.Text))
                        .Parameters.Add(New MySqlParameter("@code_pro", CheckStoclBarcodeFrm.dgCSBC.Rows(cbc).Cells(1).Value))
                        .Parameters.Add(New MySqlParameter("@bar_code", CheckStoclBarcodeFrm.dgCSBC.Rows(cbc).Cells(2).Value))
                        .Parameters.Add(New MySqlParameter("@name_pro", CheckStoclBarcodeFrm.dgCSBC.Rows(cbc).Cells(3).Value))
                        .Parameters.Add(New MySqlParameter("@price_buy", CheckStoclBarcodeFrm.dgCSBC.Rows(cbc).Cells(4).Value))
                        .Parameters.Add(New MySqlParameter("@count_num", CheckStoclBarcodeFrm.dgCSBC.Rows(cbc).Cells(5).Value))
                        .Parameters.Add(New MySqlParameter("@count", CheckStoclBarcodeFrm.dgCSBC.Rows(cbc).Cells(6).Value))
                        .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss",
                                                                                                   CultureInfo.CreateSpecificCulture("en-US"))))
                        .Parameters.Add(New MySqlParameter("@datetime_last", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss",
                                                                                                   CultureInfo.CreateSpecificCulture("en-US"))))
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End With
                Next
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        sg = sg + 1
        If sg = 10 Then
            Me.TextBox1.Text = "โหลดข้อมูลสินค้า"
            ProgressBar1.Value = sg
            Timer1.Stop()
            Call GetChectStock1()
            Timer1.Start()
        ElseIf sg = 20 Then
            ProgressBar1.Value = sg
            Me.TextBox1.Text = "นับจำนวนบาร์โค๊ตสินค้า"
            Timer1.Stop()
            Call GetChectStock1()
            Timer1.Start()
        ElseIf sg = 30 Then
            ProgressBar1.Value = sg
            Me.TextBox1.Text = "ลบแถวที่ไม่มีสินค้าในสต็อก"
            Timer1.Stop()
            Call GetChectStock1()
            Timer1.Start()
        ElseIf sg = 40 Then
            ProgressBar1.Value = sg
            Me.TextBox1.Text = "นับจำนวนแถวรายการสินค้า"
            Timer1.Stop()
            Call GetChectStock1()
            Timer1.Start()
        ElseIf sg = 50 Then
            ProgressBar1.Value = sg
            Me.TextBox1.Text = "บันทึกข้อมูลการเตรียมสต็อก"
            Timer1.Stop()
            Call GetChectStock1()
            Timer1.Start()
        ElseIf sg = 60 Then
            ProgressBar1.Value = sg
            Me.TextBox1.Text = "เตรียมสต็อกเสร็จเรียบร้อย"
            ProgressBar1.Value = 100
        ElseIf sg = 70 Then
            Timer1.Stop()
            Me.Close()
            OnTopFrm()
        End If
    End Sub

    Dim sg As Integer

    Private Sub ProgressGetCheckStockFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ProgressGetCheckStockFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Timer1.Stop()
            Me.Close()
            OnTopFrm()
        End If
    End Sub
    Private Sub ProgressGetCheckStockFrm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        sg = 0
        ProgressBar1.Value = 0
        Timer1.Start()
    End Sub
End Class