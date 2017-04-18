Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Data.SQLite
Public Class ReceiveReportFrm

    Private Sub ReceiveReportFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub ViewReceiveFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        DateTimePicker1.Value = DateTime.Now.AddDays(-30)
        DateTimePicker2.Value = DateTime.Now.AddDays(1)
        Call getDtatTocbbVRbuyCompany()
    End Sub

    Private Sub getDtatTocbbVRbuyCompany()
        Try
            Me.cbbVRbuyCompany.Items.Clear()
            cmd = New MySqlCommand("SELECT sale_company_name from sale_company ORDER BY sale_company_name;", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Me.cbbVRbuyCompany.Items.Add("ทั้งหมด")
            While (Dr.Read())
                Me.cbbVRbuyCompany.Items.Add(Dr.Item("sale_company_name"))
            End While
            Me.cbbVRbuyCompany.SelectedIndex = 0
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub getData(ByVal Selectstrsql As Integer)
        Try
            Me.dgVR.Rows.Clear()
            If Selectstrsql = 100 Then
                strSQL = "SELECT receive_id,buy_id,bill_buy_id,receive_status,total,status,sale_company_id,sale_company_name,datetime_save,employee FROM " _
                    & "receive WHERE datetime_save BETWEEN '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd",
                        CultureInfo.CreateSpecificCulture("en-US")) & "' AND '" &
                        Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")) & "';"
            ElseIf Selectstrsql = 200 Then
                strSQL = "SELECT receive_id,buy_id,bill_buy_id,receive_status,total,status,sale_company_id,sale_company_name,datetime_save,employee FROM " _
                    & "receive WHERE sale_company_name='" & Me.cbbVRbuyCompany.Text & "' AND datetime_save BETWEEN '" &
                    Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")) & "' AND '" &
                    Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")) & "';"
            End If
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Dim r As Integer
                With Me.dgVR
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.GetString("buy_id")
                    .Rows(r).Cells(1).Value = Dr.GetString("receive_id")
                    .Rows(r).Cells(2).Value = Dr.GetString("bill_buy_id")
                    .Rows(r).Cells(3).Value = Dr.GetString("sale_company_id")
                    .Rows(r).Cells(4).Value = Dr.GetString("sale_company_name")
                    .Rows(r).Cells(5).Value = Dr.GetString("datetime_save")
                    .Rows(r).Cells(6).Value = Dr.GetString("employee")
                    .Rows(r).Cells(7).Value = Dr.GetDecimal("total")
                    .Rows(r).Cells(8).Value = Dr.GetString("status")
                End With
            End While
            'นับจำนวนแถว
            Me.txtRRRsum.Text = ""
            Dim no As Integer = Me.dgVR.RowCount
            Me.txtRRRrow.Text = "จำนวน " & no & " รายการ"
            If no = 0 Then
                Me.txtRRRsum.Text = "รวม 0 บาท"
            Else
                For sum As Integer = 0 To Me.dgVR.Rows.Count - 1
                    Dim ss As Decimal
                    ss += Me.dgVR.Rows(sum).Cells(7).Value
                    Me.txtRRRsum.Text = "รวม " & ss.ToString("N2") & " บาท"
                Next
            End If
            Selectstrsql = Nothing
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub btnVRviewPro_Click(sender As Object, e As EventArgs) Handles btnVRPviewPro.Click
        Dim dgspEmpty As Integer = Me.dgVR.Rows.Count
        If dgspEmpty = 0 Then
            MsgBox("ไม่มีข้อมูล กรุณาเลือกตารางที่ต้องการดูรายการสินค้า", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            Exit Sub
        Else
            ViewSelectReceiveProductFrm.btnPrint.Visible = False
            Call ViewReportReceiveProductFrm.getDataViewReceiveFrm(Me.dgVR.CurrentRow.Cells(0).Value)
            ViewReportReceiveProductFrm.ShowDialog(Me)
        End If
    End Sub

    Private Sub btnRPshowAll_Click(sender As Object, e As EventArgs) Handles btnRPshowAll.Click
        If Me.cbbVRbuyCompany.Text = "ทั้งหมด" Then
            Call getData(100)
        Else
            Call getData(200)
        End If
    End Sub

    Private Sub cbbVRbuyCompany_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbVRbuyCompany.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbbVRbuyCompany_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbVRbuyCompany.SelectedValueChanged
        Call getData(200)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If Me.dgVR.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูลที่จะพิมพ์", MsgBoxStyle.Exclamation, "No Data")
        Else
            Try
                strSQLite = "DELETE FROM receivereport"
                cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                Call open_connectionSQLite()
                cmdSQLite.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try


            For r As Integer = 0 To Me.dgVR.Rows.Count - 1
                Try
                    strSQLite = "INSERT INTO receivereport(buy_id,buy_id_in,buy_bill_id,com_id,com_name,datetime_buy,employee,price,`status`)" _
                     & "VALUES(@buy_id,@buy_id_in,@buy_bill_id,@com_id,@com_name,@datetime_buy,@employee,@price,@status)"
                    cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                    cmdSQLite.Parameters.AddWithValue("@buy_id", Me.dgVR.Rows(r).Cells(0).Value)
                    cmdSQLite.Parameters.AddWithValue("@buy_id_in", Me.dgVR.Rows(r).Cells(1).Value)
                    cmdSQLite.Parameters.AddWithValue("@buy_bill_id", Me.dgVR.Rows(r).Cells(2).Value)
                    cmdSQLite.Parameters.AddWithValue("@com_id", Me.dgVR.Rows(r).Cells(3).Value)
                    cmdSQLite.Parameters.AddWithValue("@com_name", Me.dgVR.Rows(r).Cells(4).Value)
                    cmdSQLite.Parameters.AddWithValue("@datetime_buy", Me.dgVR.Rows(r).Cells(5).Value)
                    cmdSQLite.Parameters.AddWithValue("@employee", Me.dgVR.Rows(r).Cells(6).Value)
                    cmdSQLite.Parameters.AddWithValue("@price", Me.dgVR.Rows(r).Cells(7).Value)
                    cmdSQLite.Parameters.AddWithValue("@status", Me.dgVR.Rows(r).Cells(8).Value)
                    Call open_connectionSQLite()
                    cmdSQLite.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            Next
            If checkPrinter() = "A4" Then
                ReceviceReportA4PrintFrm.ShowDialog(Me)
            ElseIf checkPrinter() = "A5" Then
                ReceviceReportA5PrintFrm.ShowDialog(Me)
            End If
        End If
    End Sub
    Dim oldData As Object
    Private Sub dgVR_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVR.CellDoubleClick
        Me.dgVR.ReadOnly = False
        oldData = Me.dgVR.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub

    Private Sub dgVR_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgVR.CellEndEdit
        Me.dgVR.ReadOnly = True
        Me.dgVR.CurrentRow.Cells(e.ColumnIndex).Value = oldData
    End Sub

    Private Sub dgVR_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgVR.RowStateChanged
        If Me.dgVR.Rows.Count = 0 Then
            Me.btnPrint.Enabled = False
            Me.btnVRPviewPro.Enabled = False
        Else
            Me.btnPrint.Enabled = True
            Me.btnVRPviewPro.Enabled = True
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/buymenu/buyreport/receivereportfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class