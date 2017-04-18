Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Data.SQLite
Public Class CheckStoclBarcodeFrm
#Region "Code"
    Friend Sub sumTotalPro()
        Try
            Dim SMTTP As Integer = 0
            Dim cNumP As Integer = 0
            Dim mNUm As Integer = 0
            Dim fail As Integer = 0
            For sunTTP As Integer = 0 To Me.dgCSBC.Rows.Count - 1
                SMTTP += Me.dgCSBC.Rows(sunTTP).Cells(5).Value
                cNumP += Me.dgCSBC.Rows(sunTTP).Cells(6).Value
                Me.dgCSBC.Rows(sunTTP).Cells(7).Value = CInt(Me.dgCSBC.Rows(sunTTP).Cells(6).Value) - CInt(Me.dgCSBC.Rows(sunTTP).Cells(5).Value)
                fail += CInt(Me.dgCSBC.Rows(sunTTP).Cells(5).Value) - CInt(Me.dgCSBC.Rows(sunTTP).Cells(6).Value)
            Next
            Me.txtCSBCtotalPro.Text = SMTTP.ToString
            Me.txtCSBCcNumPro.Text = cNumP.ToString
            If fail < 0 Then
                Me.txtCSBCfail.Text = 0
            Else
                Me.txtCSBCfail.Text = fail.ToString
            End If
            Dim ftext As Integer = cNumP - SMTTP
            If ftext < 0 Then
                Me.txtCSBCfull.Text = 0
            Else
                Me.txtCSBCfull.Text = ftext.ToString
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            For noo As Integer = 0 To Me.dgCSBC.Rows.Count - 1
                Me.dgCSBC.Rows(noo).Cells(0).Value = noo + 1
            Next
            'Me.dgCSBC.Refresh()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Function CheckDataDontCheck() As Boolean
        Try
            strSQL = "SELECT csbc_id FROM check_stock_bc_id WHERE csbc_status='เตรียมสต็อกเสร็จสิ้น'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Function

    Private Sub LoadDataDontCheck()
        Try
            cmd = New MySqlCommand("SELECT csbc_id,datetime_last FROM check_stock_bc_id WHERE csbc_status='เตรียมสต็อกเสร็จสิ้น'", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Me.txtCSBCid.Text = Dr.Item("csbc_id")
            Me.Label6.Text = "บันทึกข้อมูลล่าสุดเมื่อ " & Dr.Item("datetime_last")
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            strSQL = "SELECT code_pro,bar_code,name_pro,price_buy,count_num,count FROM check_stock_bc WHERE csbc_id='" & Me.txtCSBCid.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim r As Integer
                With Me.dgCSBC
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(1).Value = Dr.Item("code_pro")
                    .Rows(r).Cells(2).Value = Dr.Item("bar_code")
                    .Rows(r).Cells(3).Value = Dr.Item("name_pro")
                    .Rows(r).Cells(4).Value = Dr.Item("price_buy")
                    .Rows(r).Cells(5).Value = Dr.Item("count_num")
                    .Rows(r).Cells(6).Value = Dr.Item("count")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            For noo As Integer = 0 To Me.dgCSBC.Rows.Count - 1
                Me.dgCSBC.Rows(noo).Cells(0).Value = noo + 1
            Next
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Call sumTotalPro()
    End Sub
    ''' <summary>
    ''' อัพเดทข้อมูลการเช็คสต็อกแล้วก็ลบ ข้อมูลออกทั้งหมด
    ''' </summary>
    ''' <param name="employeename">ชื่อผู้ที่ทำการเคลียร์ข้อมูล</param>
    ''' <remarks></remarks>
    Friend Sub clearStock(ByVal EmployeeName As String)
        Try
            strSQL = "INSERT INTO check_stock_bc_save(csbc_id,code_pro,bar_code,name_pro,price_buy,count_num,`count`,datetime_save)" _
        & "(SELECT csbc_id,code_pro,bar_code,name_pro,price_buy,count_num,`count`,datetime_save FROM check_stock_bc WHERE csbc_id='" & Me.txtCSBCid.Text & "');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            strSQL = "UPDATE check_stock_bc_id SET total_pro_bc='" & Me.txtCSBCtotalPro.Text & "',count_num='" & Me.txtCSBCcNumPro.Text & "'," _
                & "disappear='" & Me.txtCSBCfail.Text & "',over='" & Me.txtCSBCfull.Text & "',csbc_status='เคลียร์ข้อมูล'," _
                & "datetime_last='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "'," _
                & "employee='" & EmployeeName & "'" _
                & " WHERE csbc_id='" & Me.txtCSBCid.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'ลบข้อมูลเช็คสต็อกทั้งหมด
            strSQL = "DELETE FROM check_stock_bc"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            Me.dgCSBC.Rows.Clear()
            Call sumTotalPro()
            Me.Label6.Text = "บันทึกล่าสุด"
            Me.txtCSBCid.Clear()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        MessageBox.Show(Me, "เคลียร์ข้อมูลแล้ว", "เสร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub CheckComp()
        Try
            strSQL = "INSERT INTO check_stock_bc_save(csbc_id,code_pro,bar_code,name_pro,price_buy,count_num,`count`,datetime_save)" _
        & "(SELECT csbc_id,code_pro,bar_code,name_pro,price_buy,count_num,`count`,datetime_save FROM check_stock_bc WHERE csbc_id='" & Me.txtCSBCid.Text & "');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            strSQL = "UPDATE check_stock_bc_id SET total_pro_bc='" & Me.txtCSBCtotalPro.Text & "',count_num='" & Me.txtCSBCcNumPro.Text & "'," _
                & "disappear='" & Me.txtCSBCfail.Text & "',over='" & Me.txtCSBCfull.Text & "',csbc_status='เช็คสต็อกเสร็จแล้ว'," _
                & "datetime_last='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "'," _
                & "employee='" & Me.lblEmployee.Text & "'" _
                & " WHERE csbc_id='" & Me.txtCSBCid.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            'ลบข้อมูลเช็คสต็อกทั้งหมด
            strSQL = "DELETE FROM check_stock_bc"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            Me.dgCSBC.Rows.Clear()
            Call sumTotalPro()
            Me.Label6.Text = "บันทึกล่าสุด"
            Me.txtCSBCid.Clear()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub delrow()
        If MessageBox.Show("คุณแน่ใจว่าจะลบข้อมูลนี้", "ลบข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Try
                strSQL = "DELETE FROM check_stock_bc WHERE csbc_id='" & Me.txtCSBCid.Text & "' AND code_pro='" & Me.dgCSBC.CurrentRow.Cells(1).Value & "'" _
                    & "AND bar_code='" & Me.dgCSBC.CurrentRow.Cells(2).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                Dim a As Integer = Me.dgCSBC.SelectedRows.Count - 1
                Me.dgCSBC.Rows.Remove(Me.dgCSBC.SelectedRows(a))
                Call sumTotalPro()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub

    Private Sub UpdateDataCheckStock()
        For bc As Integer = 0 To Me.dgCSBC.Rows.Count - 1
            Try
                strSQL = "UPDATE check_stock_bc SET count_num='" & Me.dgCSBC.Rows(bc).Cells(5).Value & "'," _
                    & "count='" & Me.dgCSBC.Rows(bc).Cells(6).Value & "' " _
                    & "WHERE csbc_id='" & Me.txtCSBCid.Text & "' AND code_pro='" & Me.dgCSBC.Rows(bc).Cells(1).Value & "' AND " _
                    & "bar_code='" & Me.dgCSBC.Rows(bc).Cells(2).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next

        Try
            strSQL = "UPDATE check_stock_bc_id SET total_pro_bc='" & Me.txtCSBCtotalPro.Text & "'," _
                   & "count_num='" & Me.txtCSBCcNumPro.Text & "',disappear='" & Me.txtCSBCfail.Text & "',over='" & Me.txtCSBCfull.Text & "'," _
                   & "datetime_last='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & "' " _
                   & "WHERE csbc_id='" & Me.txtCSBCid.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        If Me.dgCSBC.Rows.Count <> 0 Then
            If CInt(Me.txtCSBCtotalPro.Text) = CInt(Me.txtCSBCcNumPro.Text) Then
                My.Computer.Audio.Play(My.Resources.BYEBYE, AudioPlayMode.Background)
                If MessageBox.Show(Me, "เช็คสต็อกเสร็จแล้ว โปรแกรมจะทำการเคลียร์ข้อมูลและบันทึกจำนวนการเช็คสต็อกไว้ในฐานข้อมูล" & vbNewLine & "หากต้องการพิมพ์รายงานให้เข้าไป รายงาน", "เสร็จ",
                                MessageBoxButtons.OK, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
                    Call CheckComp()
                End If
            End If
        End If
    End Sub
#End Region

    Private Sub btnCSBCsetStart_Click_1(sender As Object, e As EventArgs) Handles btnCSBCsetStart.Click
        If MessageBox.Show(Me, "ขั้นตอนการเตรียมข้อมูลอาจจะใช้เวลานานขึ้นอยู่กับจำนวนสินค้า", "อาจจะนานนะ",
                           MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
            ProgressGetCheckStockBarCodeFrm.ShowDialog(Me)
        End If
    End Sub

    Private Sub CheckStoclBarcodeFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.dgCSBC.Rows.Count <> 0 Then
            Call UpdateDataCheckStock()
        End If
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub CheckStoclBarcodeFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Private Sub CheckStoclBarcodeFrm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If CheckDataDontCheck() = True Then
            If MessageBox.Show(Me, "พบข้อมูลเช็คสต็อกยังไม่เสร็จ จะเช็คต่อหรือไม่", "เช็คยังไม่เสร็จ",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                Call LoadDataDontCheck()
            End If
        Else

        End If
    End Sub

    Private Sub btnClearStock_Click(sender As Object, e As EventArgs) Handles btnClearStock.Click
        If MessageBox.Show(Me, "แน่ใจว่าต้องการเคลียร์ข้อมูลเช็คสต็อก", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Call MainFrm.checkAccess("เคลียร์ข้อมูลตรวจสอบสต็อกบาร์โค๊ต")
            If MainFrm.access = 1 Then
                MiniAllLoginFrm.ShowDialog(Me)
            ElseIf MainFrm.access = 0 Then
                Call clearStock(Me.lblEmployee.Text)
            Else
                MessageBox.Show(Me, "ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub txtCSBCenterBC_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCSBCenterBC.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If Me.dgCSBC.Rows.Count = 0 Then
                MsgBox("กรุณาเตรียมข้อมูลก่อน", MsgBoxStyle.Information, "แจ้งเตือน")
            Else
                For bc As Integer = 0 To Me.dgCSBC.Rows.Count - 1
                    If Me.txtCSBCenterBC.Text.Trim = Me.dgCSBC.Rows(bc).Cells(2).Value Then
                        Me.dgCSBC.Rows(bc).Cells(6).Value = CDec(Me.dgCSBC.Rows(bc).Cells(6).Value) + 1
                        Me.txtCSBClastBC.Text = Me.dgCSBC.Rows(bc).Cells(3).Value
                        Call sumTotalPro()
                        Me.txtCSBCenterBC.Clear()
                        Me.txtCSBCenterBC.Focus()
                        Call UpdateDataCheckStock()
                        My.Computer.Audio.Play(My.Resources.TIMERTICK, AudioPlayMode.Background)
                        Exit Sub
                    End If
                Next
                Me.txtCSBCenterBC.Clear()
                Me.txtCSBCenterBC.Focus()
                Try
                    My.Computer.Audio.Play(My.Resources.NOOO, AudioPlayMode.Background)
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub dgCSBC_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgCSBC.CellMouseClick
        If Me.dgCSBC.Rows.Count <> 0 Then
            If e.Button = MouseButtons.Right Then
                Me.dgCSBC.Rows(e.RowIndex).Selected = True
                Me.dgCSBC.CurrentCell = Me.dgCSBC.Rows(e.RowIndex).Cells(0)
                Me.ContextMenuStrip1.Show(dgCSBC, e.Location)
                Me.ContextMenuStrip1.Show(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub dgCSBC_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgCSBC.CellValueChanged
        Call sumTotalPro()
    End Sub
    Friend scc As Integer
    Private Sub AddProToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddProToolStripMenuItem.Click
        scc = 100
        CheckStoclBarcodeEnterFrm.ShowDialog(Me)
        Call UpdateDataCheckStock()
    End Sub

    Private Sub DelProToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DelProToolStripMenuItem.Click
        scc = 200
        CheckStoclBarcodeEnterFrm.ShowDialog(Me)
        Call UpdateDataCheckStock()
    End Sub

    Private Sub DelRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DelRowToolStripMenuItem.Click
        Call delrow()
        Call UpdateDataCheckStock()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If Me.dgCSBC.Rows.Count = 0 Then
            MessageBox.Show(Me, "ไม่มีข้อมูลที่จะพิมพ์", "No Data", MessageBoxButtons.OK, MsgBoxStyle.Exclamation)
        Else
            If MessageBox.Show(Me, "ต้องการพิมพ์รายการนี้", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Try
                    strSQLite = "DELETE FROM check_stock_bc"
                    cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                    Call open_connectionSQLite()
                    cmdSQLite.ExecuteNonQuery()
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try

                For r As Integer = 0 To Me.dgCSBC.Rows.Count - 1
                    Try
                        strSQLite = "INSERT INTO check_stock_bc(`no`,code_pro,bar_code,name_pro,price_buy,count_num,count,over)" _
                         & "VALUES(@no,@code_pro,@bar_code,@name_pro,@price_buy,@count_num,@count,@over)"
                        cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                        cmdSQLite.Parameters.AddWithValue("@no", Me.dgCSBC.Rows(r).Cells(0).Value)
                        cmdSQLite.Parameters.AddWithValue("@code_pro", Me.dgCSBC.Rows(r).Cells(1).Value)
                        cmdSQLite.Parameters.AddWithValue("@bar_code", Me.dgCSBC.Rows(r).Cells(2).Value)
                        cmdSQLite.Parameters.AddWithValue("@name_pro", Me.dgCSBC.Rows(r).Cells(3).Value)
                        cmdSQLite.Parameters.AddWithValue("@price_buy", Me.dgCSBC.Rows(r).Cells(4).Value)
                        cmdSQLite.Parameters.AddWithValue("@count_num", Me.dgCSBC.Rows(r).Cells(5).Value)
                        cmdSQLite.Parameters.AddWithValue("@count", Me.dgCSBC.Rows(r).Cells(6).Value)
                        cmdSQLite.Parameters.AddWithValue("@over", Me.dgCSBC.Rows(r).Cells(7).Value)
                        Call open_connectionSQLite()
                        cmdSQLite.ExecuteNonQuery()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                Next
                If checkPrinter() = "A4" Then
                    CheckStockBarcodeA4PrintFrm.ShowDialog(Me)
                ElseIf checkPrinter() = "A5" Then
                    CheckStockBarcodeA5PrintFrm.ShowDialog(Me)
                End If
            End If
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/stock/checkstock/checkstoclbarcodefrm")
        Catch ex As Exception

        End Try
    End Sub
End Class