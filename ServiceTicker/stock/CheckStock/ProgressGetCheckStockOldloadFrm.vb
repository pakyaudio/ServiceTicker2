Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class ProgressGetCheckStockOldloadFrm
    Private Sub GetChectStock1()
        If sg = 10 Then
            Try
                strSQL = "SELECT COUNT(code_pro) AS CCP FROM check_stock"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    Dr.Read()
                    CheckStockFrm.txtDontCheck.Text = Dr.Item("CCP")
                Else
                    CheckStockFrm.txtDontCheck.Text = "0"
                End If
            Catch ex As Exception
                CheckStockFrm.txtDontCheck.Text = "0"
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        ElseIf sg = 20 Then
            Try
                strSQL = "SELECT COUNT(serial_pro) AS CCP FROM check_stock_cache"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    Dr.Read()
                    CheckStockFrm.txtChecked.Text = Dr.Item("CCP")
                Else
                    CheckStockFrm.txtChecked.Text = "0"
                End If
            Catch ex As Exception
                CheckStockFrm.txtChecked.Text = "0"
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        ElseIf sg = 30 Then
            Try
                strSQL = "SELECT c_stock_id FROM check_stock LIMIT 1"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    Dr.Read()
                    CheckStockFrm.txtCSid.Text = Dr.Item("c_stock_id")
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        sg = sg + 1
        If sg = 10 Then
            ProgressBar1.Value = sg
            Me.TextBox1.Text = "นับจำนวน SN ที่ไม่ได้เช็คสต็อก"
            Timer1.Stop()
            Call GetChectStock1()
            Timer1.Start()
        ElseIf sg = 20 Then
            ProgressBar1.Value = sg
            Me.TextBox1.Text = "นับจำนวน SN ที่เช็คสต็อกแล้ว"
            Timer1.Stop()
            Call GetChectStock1()
            Timer1.Start()
        ElseIf sg = 30 Then
            ProgressBar1.Value = sg
            Me.TextBox1.Text = "โหลดหมายเลขเช็คสต็อก"
            Timer1.Stop()
            Call GetChectStock1()
            Timer1.Start()
        ElseIf sg = 40 Then
            ProgressBar1.Value = sg
            Me.TextBox1.Text = "เตรียมข้อมูลเสร็จเรียบร้อย"
            ProgressBar1.Value = 100
        ElseIf sg = 50 Then
            CheckStockFrm.btnloadOldDataCheckStock.Visible = False
            Timer1.Stop()
            Me.Close()
        End If
    End Sub

    Dim sg As Integer

    Private Sub ProgressGetCheckStockOldloadFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ProgressGetCheckStockFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Timer1.Stop()
            Me.Close()
        End If
    End Sub
    Private Sub ProgressGetCheckStockFrm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        sg = 0
        ProgressBar1.Value = 0
        Timer1.Start()
    End Sub
End Class