Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class AuditFrm
    Private Sub SUMmoney()
        Try
            Dim t1, t2, t5, t10, t20, t50, t100, t500, t1000 As Integer
            Call day()
            t1 = CInt(Me.nudAD1.Text) * CInt(1)
            t2 = CInt(Me.nudAD2.Text) * CInt(2)
            t5 = CInt(Me.nudAD5.Text) * CInt(5)
            t10 = CInt(Me.nudAD10.Text) * CInt(10)
            t20 = CInt(Me.nudAD20.Text) * CInt(20)
            t50 = CInt(Me.nudAD50.Text) * CInt(50)
            t100 = CInt(Me.nudAD100.Text) * CInt(100)
            t500 = CInt(Me.nudAD500.Text) * CInt(500)
            t1000 = CInt(Me.nudAD1000.Text) * CInt(1000)
            Me.txtADtotalAll.Text = t1 + t2 + t5 + t10 + t20 + t50 + t100 + t500 + t1000
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub day()
        Try
            Dim today As Date
            Dim answer As Date
            today = Now.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US"))
            answer = today.AddDays(-1)
            strSQL = "SELECT totalAll FROM audit WHERE datetime='" & answer.ToString("yyyy-MM-dd") & "';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Dim ttD As Integer
            ttD = Dr.Item("totalAll")
            Me.txtADlastFd.Text = CInt(Me.txtADtotalAll.Text) - ttD
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Private Sub SumDeliver()
        Try
            If Me.txtADdeliverEvening.Text = "" Then
                Me.txtADdeliverEvening.Text = 0
            ElseIf Me.txtADdeliverMorning.Text = "" Then
                Me.txtADdeliverMorning.Text = 0
            ElseIf Me.txtADdeliverNoon.Text = "" Then
                Me.txtADdeliverNoon.Text = 0
            End If
            Me.txtADtotalDeliver.Text = CDec(Me.txtADdeliverMorning.Text) + CDec(Me.txtADdeliverNoon.Text) + CDec(Me.txtADdeliverEvening.Text)
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Private Sub getDataaudit_outgoings()
        Try
            Me.dgAD.Rows.Clear()
            strSQL = "SELECT namewiden,list,money,note FROM audit_outgoings WHERE datetime='" & Now.ToString("yyyy-MM-dd",
                                                                                        CultureInfo.CreateSpecificCulture("en-US")) & "';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim r As Integer
                With Me.dgAD
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = r + 1
                    .Rows(r).Cells(1).Value = Dr.GetString("namewiden")
                    .Rows(r).Cells(2).Value = Dr.GetString("list")
                    .Rows(r).Cells(3).Value = Dr.GetString("money")
                    .Rows(r).Cells(4).Value = Dr.GetString("note")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Private Sub SaveDataaudit_outgoings()
        If Me.txtADnamewiden.Text = "" Or Me.txtADlist.Text = "" Or Me.txtADmoney.Text = "" Or Me.txtADnote.Text = "" Then
            MsgBox("หากไม่มีข้อมูลช่องใดให้ขีด - ไว้")
        Else
            If MessageBox.Show("คุณแน่ใจว่าจะบันทึกข้อมูลนี้", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                               MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Try
                    strSQL = "INSERT INTO audit_outgoings(datetime,namewiden,list,money,note)VALUES(@datetime,@namewiden,@list,@money,@note);"
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        cmd.Parameters.AddWithValue("@datetime", Now.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")))
                        cmd.Parameters.AddWithValue("@namewiden", Me.txtADnamewiden.Text)
                        cmd.Parameters.AddWithValue("@list", Me.txtADlist.Text)
                        cmd.Parameters.AddWithValue("@money", Me.txtADmoney.Text)
                        cmd.Parameters.AddWithValue("@note", Me.txtADnote.Text)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using

                    MsgBox("บันทึกข้อมูลแล้ว")
                    Me.txtADnamewiden.Clear()
                    Me.txtADlist.Clear()
                    Me.txtADmoney.Clear()
                    Me.txtADnote.Clear()
                    Call getDataaudit_outgoings()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            End If
        End If
    End Sub

    Private Sub DelDataaudit_outgoings()
        If MessageBox.Show("คุณแน่ใจว่าจะลบข้อมูลนี้", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                strSQL = "DELETE FROM audit_outgoings WHERE datetime='" & Now.ToString("yyyy-MM-dd",
                    CultureInfo.CreateSpecificCulture("en-US")) & "' AND namewiden='" & Me.dgAD.SelectedCells.Item(1).Value & "' AND " _
                & "list='" & Me.dgAD.SelectedCells.Item(2).Value & "' AND money='" & Me.dgAD.SelectedCells.Item(3).Value & "' AND " _
                & "note='" & Me.dgAD.SelectedCells.Item(4).Value & "' LIMIT 1;"
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
                Call getDataaudit_outgoings()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub

    Private Sub getDataAudit()
        Try
            dt = New DataTable
            strSQL = "SELECT money1,money2,money5,money10,money20,money50,money100,money500,money1000,totalAll," _
                & "deliverMorning,deliverNoon,deliverEvening,totalDeliver FROM audit WHERE datetime='" & Now.ToString("yyyy-MM-dd",
                                                                                    CultureInfo.CreateSpecificCulture("en-US")) & "' LIMIT 1;"
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            Call open_connection()
            dtAdapter.Fill(dt)
            Me.nudAD1.Text = dt.Rows(0).Item("money1")
            Me.nudAD2.Text = dt.Rows(0).Item("money2")
            Me.nudAD5.Text = dt.Rows(0).Item("money5")
            Me.nudAD10.Text = dt.Rows(0).Item("money10")
            Me.nudAD20.Text = dt.Rows(0).Item("money20")
            Me.nudAD50.Text = dt.Rows(0).Item("money50")
            Me.nudAD100.Text = dt.Rows(0).Item("money100")
            Me.nudAD500.Text = dt.Rows(0).Item("money500")
            Me.nudAD1000.Text = dt.Rows(0).Item("money1000")
            Me.txtADtotalAll.Text = dt.Rows(0).Item("totalAll")
            Me.txtADdeliverMorning.Text = dt.Rows(0).Item("deliverMorning")
            Me.txtADdeliverNoon.Text = dt.Rows(0).Item("deliverNoon")
            Me.txtADdeliverEvening.Text = dt.Rows(0).Item("deliverEvening")
            Me.txtADtotalDeliver.Text = dt.Rows(0).Item("totalDeliver")
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Private Sub SaveAll()
        Try
            If MessageBox.Show("คุณแน่ใจว่าจะบันทึกข้อมูลนี้" & vbNewLine & "ข้อมูลนี้สามารถแก้ไขและบันทึกได้จนกว่าจะเลยเวลาเที่ยงคืน" & vbNewLine & "หากเลยเที่ยงคืนจะไม่สามารถแก้ไขได้อีก", _
                               "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                strSQL = "SELECT datetime FROM audit WHERE datetime='" & Now.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")) & "';"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                If Not Dr.HasRows Then
                    strSQL = "INSERT INTO audit(datetime,money1,money2,money5,money10,money20,money50,money100,money500,money1000," _
                        & "totalAll,`check`,transfer,cash,charges,deliverMorning,deliverNoon,deliverEvening,totalDeliver,difference)" _
                         & "VALUES(@datetime,@money1,@money2,@money5,@money10,@money20,@money50,@money100,@money500,@money1000,@totalAll," _
                         & "@check,@transfer,@cash,@charges,@deliverMorning,@deliverNoon,@deliverEvening,@totalDeliver,@difference);"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    cmd.Parameters.AddWithValue("@datetime", Now.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")))
                    cmd.Parameters.AddWithValue("@money1", Me.nudAD1.Text)
                    cmd.Parameters.AddWithValue("@money2", Me.nudAD2.Text)
                    cmd.Parameters.AddWithValue("@money5", Me.nudAD5.Text)
                    cmd.Parameters.AddWithValue("@money10", Me.nudAD10.Text)
                    cmd.Parameters.AddWithValue("@money20", Me.nudAD20.Text)
                    cmd.Parameters.AddWithValue("@money50", Me.nudAD50.Text)
                    cmd.Parameters.AddWithValue("@money100", Me.nudAD100.Text)
                    cmd.Parameters.AddWithValue("@money500", Me.nudAD500.Text)
                    cmd.Parameters.AddWithValue("@money1000", Me.nudAD1000.Text)
                    cmd.Parameters.AddWithValue("@totalAll", Me.txtADtotalAll.Text)
                    cmd.Parameters.AddWithValue("@check", "0")
                    cmd.Parameters.AddWithValue("@transfer", "0")
                    cmd.Parameters.AddWithValue("@cash", "0")
                    cmd.Parameters.AddWithValue("@charges", "0")
                    cmd.Parameters.AddWithValue("@deliverMorning", Me.txtADdeliverMorning.Text)
                    cmd.Parameters.AddWithValue("@deliverNoon", Me.txtADdeliverNoon.Text)
                    cmd.Parameters.AddWithValue("@deliverEvening", Me.txtADdeliverEvening.Text)
                    cmd.Parameters.AddWithValue("@totalDeliver", Me.txtADtotalDeliver.Text)
                    cmd.Parameters.AddWithValue("@difference", "0")
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                Else
                    strSQL = "UPDATE audit SET money1='" & Me.nudAD1.Text & "',money2='" & Me.nudAD2.Text & "'," _
                        & "money5='" & Me.nudAD5.Text & "',money10='" & Me.nudAD10.Text & "',money20='" & Me.nudAD20.Text & "'," _
                        & "money50='" & Me.nudAD50.Text & "',money100='" & Me.nudAD100.Text & "',money500='" & Me.nudAD500.Text & "'," _
                        & "money1000='" & Me.nudAD1000.Text & "',totalAll='" & Me.txtADtotalAll.Text & "',`check`='0',transfer='0'," _
                        & "cash='0',charges='0',deliverMorning='" & Me.txtADdeliverMorning.Text & "',deliverNoon='" & Me.txtADdeliverNoon.Text & "'," _
                        & "deliverEvening='" & Me.txtADdeliverEvening.Text & "',totalDeliver='" & Me.txtADtotalDeliver.Text & "'," _
                        & "difference='0' WHERE datetime='" & Now.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")) & "';"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End If
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    'Dim x As Date
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lblADtime.Text = Format(Now, "dd-MM-yyyy hh:mm:ss")

        'x = Now.ToString("hh:mm:ss", CultureInfo.CreateSpecificCulture("th-TH"))
        'If x < "17:00:00" Then
        '    Exit Sub
        'Else
        '    MsgBox("ทำงานแว้ว")
        'End If
    End Sub

    Private Sub AuditFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Me.Icon = Mainfrm.Icon
        Call getDataaudit_outgoings()
        Call getDataAudit()
        Call day()
    End Sub

    Private Sub txtADdeliverMorning_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtADdeliverMorning.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                Mainfrm.lblMainStatus.Text = "ตัวเลขเท่านั้น"
        End Select
    End Sub

    Private Sub txtADdeliverNoon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtADdeliverNoon.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                Mainfrm.lblMainStatus.Text = "ตัวเลขเท่านั้น"
        End Select
    End Sub

    Private Sub txtADdeliverEvening_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtADdeliverEvening.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                Mainfrm.lblMainStatus.Text = "ตัวเลขเท่านั้น"
        End Select
    End Sub
    Private Sub nudAD1_Click(sender As Object, e As EventArgs) Handles nudAD1.Click
        Call SUMmoney()
    End Sub

    Private Sub nudAD2_Click(sender As Object, e As EventArgs) Handles nudAD2.Click
        Call SUMmoney()
    End Sub

    Private Sub nudAD5_Click(sender As Object, e As EventArgs) Handles nudAD5.Click
        Call SUMmoney()
    End Sub

    Private Sub nudAD50_Click(sender As Object, e As EventArgs) Handles nudAD50.Click
        Call SUMmoney()
    End Sub

    Private Sub nudAD20_Click(sender As Object, e As EventArgs) Handles nudAD20.Click
        Call SUMmoney()
    End Sub

    Private Sub nudAD100_Click(sender As Object, e As EventArgs) Handles nudAD100.Click
        Call SUMmoney()
    End Sub

    Private Sub nudAD500_Click(sender As Object, e As EventArgs) Handles nudAD500.Click
        Call SUMmoney()
    End Sub

    Private Sub nudAD1000_Click(sender As Object, e As EventArgs) Handles nudAD1000.Click
        Call SUMmoney()
    End Sub
    Private Sub txtADdeliverEvening_TextChanged(sender As Object, e As EventArgs) Handles txtADdeliverEvening.TextChanged
        Call SumDeliver()
    End Sub

    Private Sub txtADdeliverMorning_TextChanged(sender As Object, e As EventArgs) Handles txtADdeliverMorning.TextChanged
        Call SumDeliver()
    End Sub

    Private Sub txtADdeliverNoon_TextChanged(sender As Object, e As EventArgs) Handles txtADdeliverNoon.TextChanged
        Call SumDeliver()
    End Sub

    Private Sub nudAD1_ValueChanged(sender As Object, e As EventArgs) Handles nudAD1.ValueChanged
        Call SUMmoney()
    End Sub

    Private Sub nudAD2_ValueChanged(sender As Object, e As EventArgs) Handles nudAD2.ValueChanged
        Call SUMmoney()
    End Sub

    Private Sub nudAD5_ValueChanged(sender As Object, e As EventArgs) Handles nudAD5.ValueChanged
        Call SUMmoney()
    End Sub

    Private Sub nudAD10_ValueChanged(sender As Object, e As EventArgs) Handles nudAD10.ValueChanged
        Call SUMmoney()
    End Sub

    Private Sub nudAD20_ValueChanged(sender As Object, e As EventArgs) Handles nudAD20.ValueChanged
        Call SUMmoney()
    End Sub

    Private Sub nudAD50_ValueChanged(sender As Object, e As EventArgs) Handles nudAD50.ValueChanged
        Call SUMmoney()
    End Sub

    Private Sub nudAD100_ValueChanged(sender As Object, e As EventArgs) Handles nudAD100.ValueChanged
        Call SUMmoney()
    End Sub

    Private Sub nudAD500_ValueChanged(sender As Object, e As EventArgs) Handles nudAD500.ValueChanged
        Call SUMmoney()
    End Sub

    Private Sub nudAD1000_ValueChanged(sender As Object, e As EventArgs) Handles nudAD1000.ValueChanged
        Call SUMmoney()
    End Sub

    Private Sub btnADsave_Click(sender As Object, e As EventArgs) Handles btnADsave.Click
        Call SaveDataaudit_outgoings()
    End Sub

    Private Sub txtADmoney_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtADmoney.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                Mainfrm.lblMainStatus.Text = "ตัวเลขเท่านั้น"
                Me.txtADmoney.SelectAll()
                Me.txtADmoney.Focus()
        End Select
    End Sub

    Private Sub lblADrefresh_Click(sender As Object, e As EventArgs) Handles lblADrefresh.Click
        Call getDataaudit_outgoings()
    End Sub

    Private Sub lblADdel_Click(sender As Object, e As EventArgs) Handles lblADdel.Click
        Call DelDataaudit_outgoings()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call SUMmoney()
        Call SaveAll()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/finance/auditfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class