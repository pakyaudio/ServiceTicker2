Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports System.Globalization
Imports System.Data.SQLite

Public Class ReportUserRepairFrm

    Private Sub ReportUserRepairFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub ReportUserRepairFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        DateTimePicker1.Value = DateTime.Now.AddDays(-30)
        DateTimePicker2.Value = DateTime.Now.AddDays(1)
    End Sub

    Private Sub cbbRURselectUser_Click(sender As Object, e As EventArgs) Handles cbbRURselectUser.Click
        Me.cbbRURselectUser.Items.Clear()
        Me.cbbRURselectUser.Items.Add("รวมทั้งหมด")
        Try
            cmd = New MySqlCommand("SELECT user_name FROM users ORDER BY user_name ASC", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Me.cbbRURselectUser.Items.Add(Dr("user_name"))
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Dim selectSTRSQL As Integer
    Private Sub searchDatadgReportuserrepair()
        Try
            Me.dgRUR.Rows.Clear()
            Me.txtRURtotalCost.Clear()
            Me.txtRURtotalBuy.Clear()
            Me.txtRURtotalProfit.Clear()
            If cbbRURselectUser.Text = "รวมทั้งหมด" Then
                strSQL = "SELECT fix_id,customer_name,code_pro,name_pro,total_pro,price_cost,price_buy,datetime_save FROM cash_sale_barcode WHERE fix_id IN (SELECT fix_id FROM comfix WHERE date_send between '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")) & "' and '" & Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")) & "' ORDER BY date_send ASC)"
            Else
                strSQL = "SELECT fix_id,customer_name,code_pro,name_pro,total_pro,price_cost,price_buy,datetime_save FROM cash_sale_barcode WHERE fix_id IN (SELECT fix_id FROM comfix WHERE user_repair='" & Me.cbbRURselectUser.Text & "' AND date_send BETWEEN '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")) & "' AND '" & Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")) & "' ORDER BY date_send ASC)"
            End If
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While (Dr.Read())
                With Me.dgRUR
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = r + 1
                    .Rows(r).Cells(1).Value = Dr.Item("fix_id")
                    .Rows(r).Cells(2).Value = Dr.Item("customer_name")
                    .Rows(r).Cells(3).Value = Dr.Item("code_pro")
                    .Rows(r).Cells(4).Value = Dr.Item("name_pro")
                    .Rows(r).Cells(5).Value = Dr.GetDecimal("total_pro")
                    .Rows(r).Cells(6).Value = Dr.GetDecimal("price_cost")
                    .Rows(r).Cells(7).Value = Dr.GetDecimal("price_buy")
                    .Rows(r).Cells(11).Value = Dr.Item("datetime_save")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        'ส่วนลด
        For DC As Integer = 0 To Me.dgRUR.Rows.Count - 1
            strSQL = "SELECT discount_detail FROM discount WHERE fix_id='" & Me.dgRUR.Rows(DC).Cells(1).Value & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Try
                Dr = cmd.ExecuteReader()
                Dr.Read()
                If Dr.HasRows Then
                    Me.dgRUR.Rows(DC).Cells(8).Value = Dr.Item("discount_detail")
                    'กรองเฉพาะเอาตัวหนังสือออกเอาเฉพาะตัวเลข
                    Dim test As String = Me.dgRUR.Rows(DC).Cells(8).Value
                    Dim match As Match = Regex.Match(test, "\d+")
                    If match.Success Then
                        Dim result As Decimal = match.Value
                        Me.dgRUR.Rows(DC).Cells(8).Value = result
                    End If
                Else
                    Me.dgRUR.Rows(DC).Cells(8).Value = 0
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next

        Try
            ''นับจำนวนชิ้น
            Dim ss2, ss, ss1, sss1 As Decimal
            For sumn As Integer = 0 To Me.dgRUR.Rows.Count - 1
                ss2 += Me.dgRUR.Rows(sumn).Cells(5).Value
                Me.dgRUR.Rows(sumn).Cells(9).Value = CDec(Me.dgRUR.Rows(sumn).Cells(6).Value) * CDec(Me.dgRUR.Rows(sumn).Cells(5).Value)
                Me.dgRUR.Rows(sumn).Cells(10).Value = CDec(Me.dgRUR.Rows(sumn).Cells(7).Value) * CDec(Me.dgRUR.Rows(sumn).Cells(5).Value)
                ss += CDec(Me.dgRUR.Rows(sumn).Cells(9).Value)
                ss1 += CDec(Me.dgRUR.Rows(sumn).Cells(10).Value)
                sss1 = CDec(Me.dgRUR.Rows(sumn).Cells(8).Value)
                Me.txtRURtotalCost.Text = ss.ToString("N2")
                Me.txtRURtotalBuy.Text = ss1.ToString("N2")
                Me.txtRURdiscount.Text = sss1.ToString("N2")
                Me.txtRURtotalProfit.Text = (CDec(Me.txtRURtotalBuy.Text) - CDec(Me.txtRURtotalCost.Text)) - CDec(Me.txtRURdiscount.Text)
            Next
            Dim no As Integer = Me.dgRUR.RowCount
            Me.txtRURrows.Text = "จำนวน " & no & " รายการ" & ", " & ss2.ToString & " ชิ้น"
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub btnRURsearch_Click(sender As Object, e As EventArgs) Handles btnRURsearch.Click
        Call searchDatadgReportuserrepair()
    End Sub

    Private Sub lblRURprofit_Click(sender As Object, e As EventArgs) Handles lblRURprofit.Click
        PercenFrm.Show(Me)
    End Sub

    Private Sub btnRUprint_Click(sender As Object, e As EventArgs) Handles btnRUprint.Click
        If Me.dgRUR.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูลที่จะพิมพ์", MsgBoxStyle.Exclamation, "No Data")
        Else
            Me.Cursor = Cursors.WaitCursor
            Try
                strSQLite = "DELETE FROM `ReportUserRepair`"
                cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                Call open_connectionSQLite()
                cmdSQLite.ExecuteNonQuery()
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Me.Cursor = Cursors.WaitCursor
            For r As Integer = 0 To Me.dgRUR.Rows.Count - 1
                Try
                    strSQLite = "INSERT INTO ReportUserRepair(`no`,fix_id,cus_name,code_pro,name_pro,total,price_cost,price_buy,discount,total_cost,total_buy,datetime_save)" _
                    & "VALUES(@no,@fix_id,@cus_name,@code_pro,@name_pro,@total,@price_cost,@price_buy,@discount,@total_cost,@total_buy,@datetime_save)"
                    cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                    cmdSQLite.Parameters.AddWithValue("@no", Me.dgRUR.Rows(r).Cells(0).Value)
                    cmdSQLite.Parameters.AddWithValue("@fix_id", Me.dgRUR.Rows(r).Cells(1).Value)
                    cmdSQLite.Parameters.AddWithValue("@cus_name", Me.dgRUR.Rows(r).Cells(2).Value)
                    cmdSQLite.Parameters.AddWithValue("@code_pro", Me.dgRUR.Rows(r).Cells(3).Value)
                    cmdSQLite.Parameters.AddWithValue("@name_pro", Me.dgRUR.Rows(r).Cells(4).Value)
                    cmdSQLite.Parameters.AddWithValue("@total", Me.dgRUR.Rows(r).Cells(5).Value)
                    cmdSQLite.Parameters.AddWithValue("@price_cost", Me.dgRUR.Rows(r).Cells(6).Value)
                    cmdSQLite.Parameters.AddWithValue("@price_buy", Me.dgRUR.Rows(r).Cells(7).Value)
                    cmdSQLite.Parameters.AddWithValue("@discount", Me.dgRUR.Rows(r).Cells(8).Value)
                    cmdSQLite.Parameters.AddWithValue("@total_cost", Me.dgRUR.Rows(r).Cells(9).Value)
                    cmdSQLite.Parameters.AddWithValue("@total_buy", Me.dgRUR.Rows(r).Cells(10).Value)
                    cmdSQLite.Parameters.AddWithValue("@datetime_save", Me.dgRUR.Rows(r).Cells(11).Value)
                    Call open_connectionSQLite()
                    cmdSQLite.ExecuteNonQuery()
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            Next
            Me.Cursor = Cursors.Default
            If checkPrinter() = "A4" Then
                ReportUserRepairA4PrintFrm.ShowDialog(Me)
            ElseIf checkPrinter() = "A5" Then
                ReportUserRepairA5PrintFrm.ShowDialog(Me)
            End If
        End If

    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/comfix/comfixreportmenu/reportuserrepairfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class