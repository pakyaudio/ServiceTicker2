Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class CheckStockFrm
#Region "Code"
    Private Sub AutoNumberNo()
        Try
            strSQL = "SELECT Max(id) as ID FROM check_stock_id"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Not Dr.HasRows Then
                Me.txtCSid.Text = Now.ToString("yyMMddHHmm") & "00001"
            Else
                Dr.Read()
                Dim newID As Integer = CInt(Dr.Item("ID"))
                newID += 1
                Me.txtCSid.Text = "CK" & Now.ToString("yyMMddHHmm") & newID.ToString("00000")
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Function CheckMeSN() As Boolean
        Try
            strSQL = "SELECT * FROM check_stock LIMIT 1"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub CheckMeSNload()
        ProgressGetCheckStockOldloadFrm.ShowDialog(Me)
    End Sub

    Private Sub CheckloadNow()
        Try
            strSQL = "SELECT COUNT(code_pro) AS CCP FROM check_stock"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                Dr.Read()
                Me.txtDontCheck.Text = Dr.Item("CCP")
            Else
                Me.txtDontCheck.Text = "0"
            End If
        Catch ex As Exception
            Me.txtDontCheck.Text = "0"
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            strSQL = "SELECT COUNT(serial_pro) AS CCP FROM check_stock_cache"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                Dr.Read()
                Me.txtChecked.Text = Dr.Item("CCP")
            Else
                Me.txtChecked.Text = "0"
            End If
        Catch ex As Exception
            Me.txtChecked.Text = "0"
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Friend Sub ClearStock()
        If MessageBox.Show("แน่ใจว่าต้องการเคลียร์ข้อมูลการตรวจสอบสต็อก", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Me.Button1.Enabled = False
            If CInt(Me.txtDontCheck.Text) <> CInt(Me.txtChecked.Text) Then
                Try
                    strSQL = "INSERT INTO check_stock_save(c_stock_id,code_pro,serial_pro,name_pro)" _
                        & "(SELECT c_stock_id,code_pro,serial_pro,name_pro FROM check_stock)"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            End If

            Try
                strSQL = "DELETE FROM check_stock"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                Me.txtDontCheck.Text = "0"
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                strSQL = "DELETE FROM check_stock_cache"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                Me.txtChecked.Text = "0"
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Me.txtCSid.Clear()
            MessageBox.Show("เคลียร์ข้อมูลการตรวจสอบสต็อกแล้ว", "เคลียร์ข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Button1.Enabled = True
            Me.btnloadOldDataCheckStock.Visible = False
        End If
    End Sub

    Private Sub CheckStockComp()
        Try
            strSQL = "UPDATE check_stock_id SET dontcheck='" & Me.txtDontCheck.Text & "',checked='" & Me.txtChecked.Text & "'," & _
                "datetime_last='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "'" & _
                " WHERE c_stock_id='" & Me.txtCSid.Text & "';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            strSQL = "DELETE FROM check_stock"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            Me.txtDontCheck.Text = "0"
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            strSQL = "DELETE FROM check_stock_cache"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            Me.txtChecked.Text = "0"
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Me.txtCSid.Clear()
    End Sub
#End Region

    Private Sub CenterPanel()
        Me.Panel2.Location = New Point((Me.SplitContainer1.Panel1.Width - Panel2.Width) / 2, 5)
        Me.Panel4.Location = New Point((Me.SplitContainer1.Panel2.Width - Panel4.Width) / 2, 5)
    End Sub

    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer1.SplitterMoved
        Call CenterPanel()
    End Sub

    Private Sub SplitContainer1_Resize(sender As Object, e As EventArgs) Handles SplitContainer1.Resize
        Call CenterPanel()
    End Sub

    Private Sub btnCSgetdata_Click(sender As Object, e As EventArgs) Handles btnCSgetdata.Click
        If CheckMeSN() = True Then
            MessageBox.Show("พบรายการ SN ที่ยังไม่ถูกเช็คสต็อกคงเหลืออยู่ ไม่สามารถเตรียมข้อมูลใหม่ได้ " & vbNewLine & "หากต้องการเตรียมข้อมูลใหม่ให้ทำการเคลียร์ข้อมูลตรวจสอบสต็อกก่อน", "มีข้อมูล",
                             MessageBoxButtons.OK , MessageBoxIcon.Exclamation)
        Else
            If MessageBox.Show("การเตรียมข้อมูลอาจจะใช้เวลานานขึ้นอยู่กับปริมาณสินค้า" & vbNewLine & "ต้องการจะทำการเตรียมข้อมูลหรือไม่", "ยืนยัน",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Call AutoNumberNo()
                ProgressGetCheckStockFrm.ShowDialog(Me)
                My.Computer.Audio.Play(My.Resources.HELLO, AudioPlayMode.Background)
            End If

        End If
    End Sub

    Private Sub txtCSSSNnow_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCSSSNnow.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If Me.txtCSSSNnow.Text <> Nothing Then
                    Try
                        strSQL = "SELECT serial_pro FROM check_stock WHERE serial_pro='" & Me.txtCSSSNnow.Text & "';"
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        Dr = cmd.ExecuteReader
                        If Dr.HasRows Then
                            Dr.Read()
                            Dim cutSN As Integer = Nothing
                            Dim inSN As Integer = Nothing
                            Try
                                strSQL = "INSERT INTO check_stock_cache(c_stock_id,code_pro,serial_pro,name_pro)" _
                                    & "SELECT c_stock_id,code_pro,serial_pro,name_pro FROM check_stock WHERE serial_pro='" & Me.txtCSSSNnow.Text & "';"
                                cmd = New MySqlCommand(strSQL, ConnectionDB)
                                Call open_connection()
                                inSN = cmd.ExecuteNonQuery()
                            Catch ex As Exception
                                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                            End Try

                            Try
                                strSQL = "DELETE FROM check_stock WHERE serial_pro='" & Me.txtCSSSNnow.Text & "';"
                                cmd = New MySqlCommand(strSQL, ConnectionDB)
                                Call open_connection()
                                cutSN = cmd.ExecuteNonQuery()
                            Catch ex As Exception
                                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                            End Try
                            If inSN = 1 And cutSN = 1 Then
                                Me.txtDontCheck.Text = CInt(Me.txtDontCheck.Text) - 1
                                Me.txtChecked.Text = CInt(Me.txtChecked.Text) + 1
                                Me.txtCSsnLast.Text = Me.txtCSSSNnow.Text
                            End If

                        Try
                            strSQL = "UPDATE check_stock_id SET dontcheck='" & Me.txtDontCheck.Text & "',checked='" & Me.txtChecked.Text & "'," & _
                                "datetime_last='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "'" & _
                                " WHERE c_stock_id='" & Me.txtCSid.Text & "';"
                            cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Call open_connection()
                            cmd.ExecuteNonQuery()
                        Catch ex As Exception
                            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                        End Try

                        My.Computer.Audio.Play(My.Resources.TIMERTICK, AudioPlayMode.Background)

                        Else
                            My.Computer.Audio.Play(My.Resources.NOOO, AudioPlayMode.Background)
                        End If
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                If CInt(Me.txtDontCheck.Text) = 0 Then
                    My.Computer.Audio.Play(My.Resources.BYEBYE, AudioPlayMode.Background)
                    MessageBox.Show(Me, "เช็คสต็อกเสร็จแล้ว โปรแกรมจะทำการเคลียร์ข้อมูลและบันทึกจำนวนการเช็คสต็อกไว้ในฐานข้อมูล" & vbNewLine & "หากต้องการพิมพ์รายงานให้เข้าไป รายงาน", "เสร็จ",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call CheckStockComp()
                End If
                Me.txtCSSSNnow.Clear()
            End If
        End If
    End Sub

    Private Sub CheckStockFrm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub CheckStockFrm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.txtCSid.Clear()
        If CheckMeSN() = True Then
            If MessageBox.Show("พบรายการ SN ที่ยังไม่ถูกเช็คสต็อกคงเหลืออยู่" & vbNewLine & "ต้องการเช็คสต็อกต่อหรือไม่", "มีข้อมูล",
                             MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                Call CheckMeSNload()
            Else
                If CheckMeSN() = True Then
                    Me.btnloadOldDataCheckStock.Visible = True
                Else
                    Me.btnloadOldDataCheckStock.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub CheckStockFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Private Sub CheckStockFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.txtCSid.Text <> Nothing Then
            Try
                strSQL = "UPDATE check_stock_id SET dontcheck='" & Me.txtDontCheck.Text & "',checked='" & Me.txtChecked.Text & "'," & _
                    "datetime_last='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "'" & _
                    " WHERE c_stock_id='" & Me.txtCSid.Text & "';"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call MainFrm.checkAccess("เคลียร์ข้อมูลการตรวจสอบสต็อก")
        If MainFrm.access = 1 Then
            MiniAllLoginFrm.ShowDialog(Me)
        ElseIf MainFrm.access = 0 Then
            Call ClearStock()
        Else
            MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        
    End Sub

    Private Sub btnloadOldDataCheckStock_Click(sender As Object, e As EventArgs) Handles btnloadOldDataCheckStock.Click
        Call CheckMeSNload()
    End Sub

    Private Sub btnShowDontCheckSN_Click(sender As Object, e As EventArgs) Handles btnShowDontCheckSN.Click
        ViewCheckStockSNDontFrm.ShowDialog(Me)
    End Sub

    Private Sub btnShowCheckedSN_Click(sender As Object, e As EventArgs) Handles btnShowCheckedSN.Click
        ViewCheckStockSNCheckedFrm.ShowDialog(Me)
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/stock/checkstock/checkstockfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class