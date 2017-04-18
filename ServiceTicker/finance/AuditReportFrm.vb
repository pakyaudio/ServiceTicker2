Imports MySql.Data.MySqlClient

Public Class AuditReportFrm
#Region "Code"
    Private Sub getDataaudit()
        Try
            'สร้างวันที่
            Me.dgAR.Rows.Clear()
            Dim d1 As DateTime = DateTimePicker1.Value
            Dim days1 As Integer = d1.Day
            Dim month1 As Integer = d1.Month
            Dim years1 As Integer = d1.Year
            Dim dt1 As String = years1 & "-" & month1 & "-" & days1
            Dim d2 As DateTime = DateTimePicker2.Value
            Dim days2 As Integer = d2.Day
            Dim month2 As Integer = d2.Month
            Dim years2 As Integer = d2.Year
            Dim dt2 As String = years2 & "-" & month2 & "-" & days2
            For Each Day As DateTime In DateRange(dt1, dt2)
                Dim r As Integer
                With Me.dgAR
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Day.ToString("yyyy-MM-dd")
                End With
            Next
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Try
            Me.Cursor = Cursors.WaitCursor
            'หายอดขาย
            For tt As Integer = 0 To Me.dgAR.Rows.Count - 1
                strSQL = "SELECT COALESCE(SUM(replace(total_all, ',', '')),0) AS ttl FROM cash_sale WHERE " _
                    & "datetime_save LIKE '%" & Me.dgAR.Rows(tt).Cells(0).Value & "%' AND fix_id='" & "ขายสินค้า" & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()

                If Dr.HasRows Then
                    With Me.dgAR
                        .Rows(tt).Cells(1).Value = Dr.GetDecimal(0)
                    End With
                End If
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            Me.Cursor = Cursors.WaitCursor
            'หายอดซ่อม
            For tt As Integer = 0 To Me.dgAR.Rows.Count - 1
                strSQL = "SELECT COALESCE(SUM(replace(total_all, ',', '')),0) AS ttl FROM cash_sale WHERE " _
                    & "datetime_save LIKE '%" & Me.dgAR.Rows(tt).Cells(0).Value & "%' AND NOT (fix_id='" & "ขายสินค้า" & "')"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgAR
                    .Rows(tt).Cells(2).Value = Dr.GetDecimal("ttl")
                End With
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Try
            'รวมยอดขาย ซ่อม
            Me.Cursor = Cursors.WaitCursor
            For SUMfs As Integer = 0 To Me.dgAR.Rows.Count - 1
                Me.dgAR.Rows(SUMfs).Cells(3).Value = CDec(Me.dgAR.Rows(SUMfs).Cells(1).Value) + CDec(Me.dgAR.Rows(SUMfs).Cells(2).Value)
            Next
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        '-----------------------------------------------------------------------------------------------------------------------------------'
        Try
            Me.Cursor = Cursors.WaitCursor
            'หายอดทุนขาย
            For tt As Integer = 0 To Me.dgAR.Rows.Count - 1
                strSQL = "SELECT COALESCE(SUM(CAST(price_cost AS DECIMAL(20,2)) * CAST(total_pro AS DECIMAL(20,2))),0) AS one FROM cash_sale_barcode WHERE " _
                    & "datetime_save LIKE '%" & Me.dgAR.Rows(tt).Cells(0).Value & "%' AND (fix_id='" & "ขายสินค้า" & "')"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgAR
                    .Rows(tt).Cells(4).Value = Dr.GetDecimal("one")
                End With
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Try
            Me.Cursor = Cursors.WaitCursor
            'หายอดทุนซ่อม
            For tt As Integer = 0 To Me.dgAR.Rows.Count - 1
                strSQL = "SELECT COALESCE(SUM(CAST(price_cost AS DECIMAL(20,2)) * CAST(total_pro AS DECIMAL(20,2))),0) AS one FROM cash_sale_barcode WHERE " _
                    & "datetime_save LIKE '%" & Me.dgAR.Rows(tt).Cells(0).Value & "%' AND NOT (fix_id='" & "ขายสินค้า" & "')"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgAR
                    .Rows(tt).Cells(5).Value = Dr.GetDecimal("one")
                End With
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Try
            'รวมยอดรวมขาย ซ่อม
            Me.Cursor = Cursors.WaitCursor
            For SUMfs As Integer = 0 To Me.dgAR.Rows.Count - 1
                Me.dgAR.Rows(SUMfs).Cells(6).Value = CDec(Me.dgAR.Rows(SUMfs).Cells(4).Value) + CDec(Me.dgAR.Rows(SUMfs).Cells(5).Value)
            Next
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        '-----------------------------------------------------------------------------------------------------------------------------------'
        Try
            Me.Cursor = Cursors.WaitCursor
            'หายอดส่วนลด
            For tt As Integer = 0 To Me.dgAR.Rows.Count - 1
                strSQL = "SELECT COALESCE(SUM(replace(discount, ',', '')),0) AS dc FROM discount WHERE " _
                    & "datetime_save LIKE '%" & Me.dgAR.Rows(tt).Cells(0).Value & "%'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgAR
                    .Rows(tt).Cells(7).Value = Dr.GetDecimal("dc")
                End With
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Try
            Me.Cursor = Cursors.WaitCursor
            'หายอดรายจ่าย
            For tt As Integer = 0 To Me.dgAR.Rows.Count - 1
                strSQL = "SELECT COALESCE(SUM(replace(money, ',', '')),0) AS dc FROM audit_outgoings WHERE " _
                    & "datetime LIKE '%" & Me.dgAR.Rows(tt).Cells(0).Value & "%'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgAR
                    .Rows(tt).Cells(8).Value = Dr.GetDecimal("dc")
                End With
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        '-----------------------------------------------------------------------------------------------------------------------------------'
        'หายอดจัดซื้อ
        Try
            Me.Cursor = Cursors.WaitCursor
            'หายอดจัดซื้อ
            For tt As Integer = 0 To Me.dgAR.Rows.Count - 1
                strSQL = "SELECT COALESCE(SUM(CAST(REPLACE(`total`,',','') AS DECIMAL(20,2))),0) AS buybuy FROM buy WHERE " _
                    & "datetime_save LIKE '%" & Me.dgAR.Rows(tt).Cells(0).Value & "%' AND status='" & "ได้รับสินค้าแล้ว" & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgAR
                    .Rows(tt).Cells(9).Value = Dr.GetDecimal("buybuy")
                End With
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        '-----------------------------------------------------------------------------------------------------------------------------------'
        Try
            'รวมตามตารางแนวตั้ง 
            Me.Cursor = Cursors.WaitCursor
            Dim txt1 As Decimal = 0
            Dim txt2 As Decimal = 0
            Dim txt3 As Decimal = 0
            Dim txt4 As Decimal = 0
            Dim txt5 As Decimal = 0
            Dim txt6 As Decimal = 0
            Dim txt7 As Decimal = 0
            Dim txt8 As Decimal = 0
            Dim txt9 As Decimal = 0
            For SUMfs As Integer = 0 To Me.dgAR.Rows.Count - 1
                txt1 += CDec(Me.dgAR.Rows(SUMfs).Cells(1).Value)
                txt2 += CDec(Me.dgAR.Rows(SUMfs).Cells(2).Value)
                txt3 += CDec(Me.dgAR.Rows(SUMfs).Cells(3).Value)
                txt4 += CDec(Me.dgAR.Rows(SUMfs).Cells(4).Value)
                txt5 += CDec(Me.dgAR.Rows(SUMfs).Cells(5).Value)
                txt6 += CDec(Me.dgAR.Rows(SUMfs).Cells(6).Value)
                txt7 += CDec(Me.dgAR.Rows(SUMfs).Cells(7).Value)
                txt8 += CDec(Me.dgAR.Rows(SUMfs).Cells(8).Value)
                txt9 += CDec(Me.dgAR.Rows(SUMfs).Cells(9).Value)
            Next
            Me.txt1.Text = txt1.ToString("N2")
            Me.txt2.Text = txt2.ToString("N2")
            Me.txt3.Text = txt3.ToString("N2")
            Me.txt4.Text = txt4.ToString("N2")
            Me.txt5.Text = txt5.ToString("N2")
            Me.txt6.Text = txt6.ToString("N2")
            Me.txt8.Text = txt7.ToString("N2")
            Me.txt9.Text = txt8.ToString("N2")
            Me.txtBuy.Text = txt9.ToString("N2")
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        '-----------------------------------------------------------------------------------------------------------------------------------'
        Me.Cursor = Cursors.Default
        MsgBox("รวบรวมข้อมูลเสร็จเรียบร้อย", MsgBoxStyle.Information, "แจ้งเพื่อทราบ")
    End Sub

    Function DateRange(Start As DateTime, Thru As DateTime) As IEnumerable(Of Date)
        Return Enumerable.Range(0, (Thru.Date - Start.Date).Days + 1).Select(Function(i) Start.AddDays(i))
    End Function
#End Region

    Private Sub AuditReportFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        DateTimePicker1.Value = Date.Now.AddDays(0)
        DateTimePicker2.Value = Date.Now.AddDays(0)
    End Sub

    Private Sub btnARshowData_Click(sender As Object, e As EventArgs) Handles btnARshowData.Click
        Dim dtt1 As DateTime = Convert.ToDateTime(DateTimePicker1.Value)
        Dim dtt2 As DateTime = Convert.ToDateTime(DateTimePicker2.Value)
        Dim ts As TimeSpan = dtt2.Subtract(dtt1)
        If Convert.ToInt32(ts.Days) > 300 Then
            If MessageBox.Show("คำเตือน การดึงข้อมูลจำนวนมากอาจใช้เวลานาน ต้องการทำต่อหรือไม่", "ต้องใช้เวลามาก", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Call getDataaudit()
            Else
                Exit Sub
            End If
        Else
            Call getDataaudit()
        End If
    End Sub

    Private Sub txt1_MouseHover(sender As Object, e As EventArgs) Handles txt1.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt1.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt1, thaitext)
    End Sub

    Private Sub txt2_MouseHover(sender As Object, e As EventArgs) Handles txt2.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt2.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt2, thaitext)
    End Sub

    Private Sub txt3_MouseHover(sender As Object, e As EventArgs) Handles txt3.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt3.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt3, thaitext)
    End Sub

    Private Sub txt4_MouseHover(sender As Object, e As EventArgs) Handles txt4.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt4.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt4, thaitext)
    End Sub

    Private Sub txt5_MouseHover(sender As Object, e As EventArgs) Handles txt5.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt5.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt5, thaitext)
    End Sub

    Private Sub txt6_MouseHover(sender As Object, e As EventArgs) Handles txt6.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt6.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt6, thaitext)
    End Sub

    Private Sub txt8_MouseHover(sender As Object, e As EventArgs) Handles txt8.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt8.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt8, thaitext)
    End Sub

    Private Sub txt9_MouseHover(sender As Object, e As EventArgs) Handles txt9.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt9.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt9, thaitext)
    End Sub

    Private Sub txtBuy_MouseHover(sender As Object, e As EventArgs) Handles txtBuy.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txtBuy.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txtBuy, thaitext)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            strSQLite = "DELETE FROM dataGridview;"
            cmdSQLite = New SQLite.SQLiteCommand(strSQLite, connSQLite)
            Call open_connectionSQLite()
            cmdSQLite.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            For r As Integer = 0 To Me.dgAR.Rows.Count - 1
                strSQLite = "INSERT INTO dataGridview(c1,c2,c3,c4,c5,c6,c7,c8,c9,c10)VALUES(@c1,@c2,@c3,@c4,@c5,@c6,@c7,@c8,@c9,@c10);"
                cmdSQLite = New SQLite.SQLiteCommand(strSQLite, connSQLite)
                Call open_connectionSQLite()
                cmdSQLite.Parameters.AddWithValue("@c1", Me.dgAR.Rows(r).Cells(0).Value)
                cmdSQLite.Parameters.AddWithValue("@c2", Me.dgAR.Rows(r).Cells(1).Value)
                cmdSQLite.Parameters.AddWithValue("@c3", Me.dgAR.Rows(r).Cells(2).Value)
                cmdSQLite.Parameters.AddWithValue("@c4", Me.dgAR.Rows(r).Cells(3).Value)
                cmdSQLite.Parameters.AddWithValue("@c5", Me.dgAR.Rows(r).Cells(4).Value)
                cmdSQLite.Parameters.AddWithValue("@c6", Me.dgAR.Rows(r).Cells(5).Value)
                cmdSQLite.Parameters.AddWithValue("@c7", Me.dgAR.Rows(r).Cells(6).Value)
                cmdSQLite.Parameters.AddWithValue("@c8", Me.dgAR.Rows(r).Cells(7).Value)
                cmdSQLite.Parameters.AddWithValue("@c9", Me.dgAR.Rows(r).Cells(8).Value)
                cmdSQLite.Parameters.AddWithValue("@c10", Me.dgAR.Rows(r).Cells(9).Value)
                cmdSQLite.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        If checkPrinter() = "A4" Then
            AuditReportA4PrintFrm.Show(Me)
        ElseIf checkPrinter() = "A5" Then
            AuditReportA5PrintFrm.Show(Me)
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/finance/financereport/auditreportfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class