Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Data.SQLite

Public Class ViewReceiveFrm

    Private Sub ViewReceiveFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ViewReceiveFrm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Panel1.Location = New Point((Me.DisplayRectangle.Width - Panel1.Width) / 2, 5)
    End Sub

    Private Sub ViewReceiveFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call EnableBtn()
    End Sub
    Private Sub startfrm()
        Call EnableBtn()
    End Sub
    Private Sub getDtatTocbbVRbuyCompany()
        Try
            Me.cbbVRbuyCompany.Items.Clear()
            cmd = New MySqlCommand("SELECT sale_company_name from sale_company ORDER BY sale_company_name ASC", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbbVRbuyCompany.Items.Add(Dr.Item("sale_company_name"))
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Private Sub getDataTocbbVRbuyCompany(ByVal Statustext As String, ByVal statusC As Integer)
        Try
            Me.dgVR.Rows.Clear()
            If Me.cbbVRbuyStatus.Text = "ทั้งหมด" Then
                strSQL = "SELECT buy_id,total,status,sale_company_id,sale_company_name,datetime_save,employee FROM buy"
            ElseIf statusC = 100 Then
                strSQL = "SELECT buy_id,`total`,`status`,sale_company_id,sale_company_name,datetime_save,employee " _
               & "FROM buy WHERE sale_company_name='" & Statustext & "'"
            ElseIf statusC = 200 Then
                strSQL = "SELECT buy_id,`total`,`status`,sale_company_id,sale_company_name,datetime_save,employee " _
              & "FROM buy WHERE status='" & "ยังไม่ได้รับสินค้า" & "' OR status='" & "สินค้ายังไม่ครบ" & "'"
            Else
                strSQL = "SELECT buy_id,total,status,sale_company_id,sale_company_name,datetime_save,employee FROM " _
                    & "buy WHERE status='" & Statustext & "'"
            End If
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While (Dr.Read())
                With Me.dgVR
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.Item("buy_id")
                    .Rows(r).Cells(1).Value = Dr.Item("sale_company_id")
                    .Rows(r).Cells(2).Value = Dr.Item("sale_company_name")
                    .Rows(r).Cells(3).Value = Dr.Item("datetime_save")
                    .Rows(r).Cells(4).Value = Dr.Item("employee")
                    .Rows(r).Cells(5).Value = Dr.GetDecimal("total")
                    .Rows(r).Cells(6).Value = Dr.Item("status")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub cbbVRbuyCompany_DropDown(sender As Object, e As EventArgs) Handles cbbVRbuyCompany.DropDown
        Call getDtatTocbbVRbuyCompany()
    End Sub

    Private Sub cbbVRbuyCompany_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbVRbuyCompany.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbbSRPbuyCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbVRbuyCompany.SelectedIndexChanged
        Me.cbbVRbuyStatus.Items.Clear()
        Call getDataTocbbVRbuyCompany(Me.cbbVRbuyCompany.Text, 100)
    End Sub

    Private Sub cbbVRbuyStatus_DropDown(sender As Object, e As EventArgs) Handles cbbVRbuyStatus.DropDown
        Me.cbbVRbuyStatus.Items.Clear()
        Me.cbbVRbuyStatus.Items.Add("ได้รับสินค้าแล้ว")
        Me.cbbVRbuyStatus.Items.Add("สินค้ายังไม่ครบ")
        Me.cbbVRbuyStatus.Items.Add("ยังไม่ได้รับสินค้า")
        Me.cbbVRbuyStatus.Items.Add("ยกเลิกรายการ")
        Me.cbbVRbuyStatus.Items.Add("ทั้งหมด")
    End Sub

    Private Sub cbbVRbuyStatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbVRbuyStatus.KeyPress
        e.Handled = True
    End Sub
    Private Sub cbbSRPbuyStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbVRbuyStatus.SelectedIndexChanged
        Me.cbbVRbuyCompany.Items.Clear()
        Call getDataTocbbVRbuyCompany(Me.cbbVRbuyStatus.Text, Nothing)
    End Sub

    Private Sub btnVRcancelBillbuy_Click(sender As Object, e As EventArgs) Handles btnVRcancelBillbuy.Click
        Try
            Dim i As Integer = dgVR.Rows.Count
            If i <= 0 Then
                MsgBox("กรุณาเลือกใบสั่งซื้อที่ต้องการยกเลิก", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            Else
                If Me.dgVR.SelectedCells.Item(6).Value = "ได้รับสินค้าแล้ว" Then
                    MsgBox("สถานะได้รับสินค้าแล้ว ไม่สามารถยกเลิกได้อีก", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                    Exit Sub
                ElseIf Me.dgVR.SelectedCells.Item(6).Value = "ยังไม่ได้รับสินค้า" Or
                    Me.dgVR.SelectedCells.Item(6).Value = "สินค้ายังไม่ครบ" Then
                    Try
                        If MessageBox.Show("ต้องการยกเลิกใบสั่งซื้อนี้", "ยืนยัน", MessageBoxButtons.YesNo, _
                                           MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            strSQL = "UPDATE buy SET `status`='ยกเลิกรายการ'," _
                             & "datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "' " _
                             & "WHERE buy_id='" & Me.dgVR.SelectedCells.Item(0).Value & "'"
                            cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Call open_connection()
                            cmd.ExecuteNonQuery()
                            MsgBox("ยกเลิกใบสั่งซื้อแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
                            Call getDataTocbbVRbuyCompany("ยังไม่ได้รับสินค้า", 200)
                        End If
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                    Exit Sub
                ElseIf Me.dgVR.SelectedCells.Item(6).Value = "ยกเลิกรายการ" Then
                    MsgBox("สินค้านี้ถูกยกเลิกไปแล้ว ไม่สามารถยกเลิกได้อีก", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub btnVRviewPro_Click(sender As Object, e As EventArgs) Handles btnVRPviewPro.Click
        If Me.dgVR.SelectedRows.Count <> 0 Then
            Call ViewSelectReceiveProductFrm.getDataViewReceiveFrm(Me.dgVR.CurrentRow.Cells(0).Value)
            ViewSelectReceiveProductFrm.ShowDialog(Me)
        End If
    End Sub
    Private Sub reportPrint()
        If Me.dgVR.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูลให้พิมพ์", MsgBoxStyle.Exclamation, "แจ้งเตือน")
        Else
            'แอดทำรีพอร์ต
            Me.Cursor = Cursors.WaitCursor
            MainFrm.lblMainStatus.Text = "ล้างข้อมูลรายงานเก่า"
            Try
                strSQLite = "DELETE FROM buy_pro_rewordall"
                MainFrm.lblMainStatus.Text = strSQLite
                cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                Call open_connectionSQLite()
                cmdSQLite.ExecuteNonQuery()
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                MainFrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
            'loop save to database
            For rREPORT As Integer = 0 To Me.dgVR.RowCount - 1
                Try
                    strSQLite = "insert into buy_pro_rewordall(buy_id,salecom_id,salecom_name,datetime,employee,price,`status`) " _
                    & "values(@buy_id,@salecom_id,@salecom_name,@datetime,@employee,@price,@status)"
                    MainFrm.lblMainStatus.Text = strSQLite
                    cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                    With cmdSQLite
                        .Parameters.Add(New SQLiteParameter("@buy_id", Me.dgVR.Rows(rREPORT).Cells(0).Value))
                        .Parameters.Add(New SQLiteParameter("@salecom_id", Me.dgVR.Rows(rREPORT).Cells(1).Value))
                        .Parameters.Add(New SQLiteParameter("@salecom_name", Me.dgVR.Rows(rREPORT).Cells(2).Value))
                        .Parameters.Add(New SQLiteParameter("@datetime", Me.dgVR.Rows(rREPORT).Cells(3).Value))
                        .Parameters.Add(New SQLiteParameter("@employee", Me.dgVR.Rows(rREPORT).Cells(4).Value))
                        .Parameters.Add(New SQLiteParameter("@price", Me.dgVR.Rows(rREPORT).Cells(5).Value))
                        .Parameters.Add(New SQLiteParameter("@status", Me.dgVR.Rows(rREPORT).Cells(6).Value))
                        Call open_connectionSQLite()
                        .ExecuteNonQuery()
                    End With
                    Me.Cursor = Cursors.Default
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    MainFrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    Return
                End Try
            Next
            If checkPrinter() = "A4" Then
                ReBuyAllReportA4PrintFrm.ShowDialog(Me)
            ElseIf checkPrinter() = "A5" Then
                ReBuyAllReportA5PrintFrm.ShowDialog(Me)
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call reportPrint()
    End Sub

    Dim oldData As Object

    Private Sub dgVR_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVR.CellClick
        If Me.dgVR.CurrentRow.Cells(6).Value = "ยกเลิกรายการ" Then
            Me.btnEditCancel.Enabled = True
        Else
            Me.btnEditCancel.Enabled = False
        End If
    End Sub

    Private Sub dgVR_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVR.CellDoubleClick
        Me.dgVR.ReadOnly = False
        oldData = Me.dgVR.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub

    Private Sub dgVR_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgVR.CellEndEdit
        Me.dgVR.ReadOnly = True
        Me.dgVR.CurrentRow.Cells(e.ColumnIndex).Value = oldData
    End Sub

    Private Sub EnableBtn()
        If Me.dgVR.Rows.Count <> 0 Then
            Me.btnVRPviewPro.Enabled = True
            Me.btnVRcancelBillbuy.Enabled = True
            Me.Button1.Enabled = True
            Me.btnEditCancel.Enabled = True
        ElseIf Me.dgVR.Rows.Count = 0 Then
            Me.btnVRPviewPro.Enabled = False
            Me.btnVRcancelBillbuy.Enabled = False
            Me.Button1.Enabled = False
            Me.btnEditCancel.Enabled = False
        End If
    End Sub
  
    Private Sub dgVR_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgVR.RowStateChanged
        Call EnableBtn()
    End Sub

    Private Sub btnEditCancel_Click(sender As Object, e As EventArgs) Handles btnEditCancel.Click
        Try
            Dim i As Integer = dgVR.Rows.Count
            If i <= 0 Then
                MsgBox("กรุณาเลือกใบสั่งซื้อที่ต้องการยกเลิก", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            Else
                If Me.dgVR.SelectedCells.Item(6).Value = "ได้รับสินค้าแล้ว" Then
                    MsgBox("สถานะได้รับสินค้าแล้ว ไม่สามารถยกเลิกได้อีก", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                    Exit Sub
                ElseIf Me.dgVR.SelectedCells.Item(6).Value = "ยกเลิกรายการ" Then
                    Try
                        If MessageBox.Show("เปลี่ยนสถานะใบสั่งซื้อนี้ เป็นยังไม่ได้รับสินค้า", "ยืนยัน", MessageBoxButtons.YesNo, _
                                           MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            strSQL = "UPDATE buy SET `status`='ยังไม่ได้รับสินค้า'," _
                             & "datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "' " _
                             & "WHERE buy_id='" & Me.dgVR.SelectedCells.Item(0).Value & "'"
                            cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Call open_connection()
                            cmd.ExecuteNonQuery()
                            MsgBox("แก้ไขสถานะยกเลิกเป็นยังไม่ได้รับสินค้าแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
                            Call getDataTocbbVRbuyCompany("ยังไม่ได้รับสินค้า", 200)
                        End If
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                    Exit Sub
                ElseIf Me.dgVR.SelectedCells.Item(6).Value = "ยกเลิกรายการ" Then
                    MsgBox("สินค้านี้ถูกยกเลิกไปแล้ว ไม่สามารถยกเลิกได้อีก", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/buymenu/viewreceivefrm")
        Catch ex As Exception

        End Try
    End Sub
End Class