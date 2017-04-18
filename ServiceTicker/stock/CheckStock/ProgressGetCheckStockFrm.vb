Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class ProgressGetCheckStockFrm
    Private Sub GetChectStock1()
        If sg = 10 Then
            Try
                strSQL = "INSERT INTO check_stock(code_pro,serial_pro,name_pro)" _
                           & "SELECT code_pro,serial_pro,name_pro FROM product_serial"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        ElseIf sg = 20 Then
            Try
                strSQL = "UPDATE check_stock SET c_stock_id='" & CheckStockFrm.txtCSid.Text & "'"
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        ElseIf sg = 30 Then
            Try
                strSQL = "SELECT COUNT(code_pro) AS CCP FROM check_stock"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    Dr.Read()
                    CheckStockFrm.txtDontCheck.Text = Dr.Item("CCP")
                    CheckStockFrm.txtChecked.Text = "0"
                Else
                    CheckStockFrm.txtDontCheck.Text = "0"
                    CheckStockFrm.txtChecked.Text = "0"
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        ElseIf sg = 40 Then
            Try
                strSQL = "INSERT INTO check_stock_id(c_stock_id,datetime_save,t_stock)VALUES(@c_stock_id,@datetime_save,@t_stock)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@c_stock_id", CheckStockFrm.txtCSid.Text))
                    .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"))))
                    .Parameters.Add(New MySqlParameter("@t_stock", CheckStockFrm.txtDontCheck.Text))
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End With
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        sg = sg + 1
        If sg = 10 Then
            ProgressBar1.Value = sg
            Me.TextBox1.Text = "โหลดข้อมูล SN"
            Timer1.Stop()
            Call GetChectStock1()
            Timer1.Start()
        ElseIf sg = 20 Then
            ProgressBar1.Value = sg
            Me.TextBox1.Text = "นับจำนวน SN"
            Timer1.Stop()
            Call GetChectStock1()
            Timer1.Start()
        ElseIf sg = 30 Then
            ProgressBar1.Value = sg
            Me.TextBox1.Text = "อัพเดทหมายเลขเช็คสต็อก"
            Timer1.Stop()
            Call GetChectStock1()
            Timer1.Start()
        ElseIf sg = 40 Then
            ProgressBar1.Value = sg
            Me.TextBox1.Text = "บันทึกรายการเตรียมสต็อก"
            Timer1.Stop()
            Call GetChectStock1()
            Timer1.Start()
        ElseIf sg = 50 Then
            ProgressBar1.Value = sg
            Me.TextBox1.Text = "เตรียมสต็อกเสร็จเรียบร้อย"
            ProgressBar1.Value = 100
        ElseIf sg = 60 Then
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