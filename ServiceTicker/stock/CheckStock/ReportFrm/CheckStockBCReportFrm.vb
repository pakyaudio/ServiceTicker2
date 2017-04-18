Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class CheckStockBCReportFrm

    Private Sub CheckStockBCReportFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub CheckStockBCReportFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        DateTimePicker1.Value = DateTime.Now.AddDays(0)
    End Sub

    Private Sub searchCheckStock()
        Try
            Me.dgCSR.Rows.Clear()
            strSQL = "SELECT csbc_id,datetime_save,total_pro_bc,count_num,disappear,over,csbc_status,datetime_last,employee " _
                    & "FROM check_stock_bc_id WHERE datetime_save LIKE '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM", CultureInfo.CreateSpecificCulture("en-EN")) & "%'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows = True Then
                Dim r As Integer
                With Me.dgCSR
                    While Dr.Read
                        r = .Rows.Count
                        .Rows.Add()
                        .Rows(r).Cells(0).Value = r + 1
                        .Rows(r).Cells(1).Tag = Dr.Item("csbc_id")
                        .Rows(r).Cells(1).Value = Dr.Item("datetime_save")
                        .Rows(r).Cells(2).Value = Dr.Item("total_pro_bc")
                        .Rows(r).Cells(3).Value = Dr.Item("count_num")
                        .Rows(r).Cells(4).Value = Dr.Item("disappear")
                        .Rows(r).Cells(5).Value = Dr.Item("over")
                        .Rows(r).Cells(6).Value = Dr.Item("csbc_status")
                        .Rows(r).Cells(7).Value = Dr.Item("datetime_last")
                        .Rows(r).Cells(8).Value = Dr.Item("employee")
                    End While
                End With
            End If

        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub btnCSRsearch_Click(sender As Object, e As EventArgs) Handles btnCSRsearch.Click
        Call searchCheckStock()
    End Sub

    Private Sub DateTimePicker1_FormatChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.FormatChanged
        DateTimePicker1.CustomFormat = "MMMM yyyy"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.dgCSR.Rows.Count <> 0 Then
            Call ViewCheckStockBarcodeFrm.GetDataCheckStockBarcode(Me.dgCSR.CurrentRow.Cells(1).Tag)
            ViewCheckStockBarcodeFrm.ShowDialog(Me)
        End If
    End Sub

    Private Sub dgCSR_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgCSR.RowStateChanged
        If Me.dgCSR.SelectedRows.Count <> 0 Then
            Me.Button1.Enabled = True
        Else
            Me.Button1.Enabled = False
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/stock/stockreport/checkstockbcreportfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class