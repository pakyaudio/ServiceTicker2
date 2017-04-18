Imports MySql.Data.MySqlClient
Imports System.Data.SQLite

Public Class AuditChartFrm

    Private Sub AuditChartFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub AuditChartFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call GetYears()
    End Sub
#Region "Code"
    Private Sub GetYears()
        Try
            Me.cbbACyears.Items.Clear()
            strSQL = "SELECT DISTINCT YEAR(datetime_save) AS ds FROM cash_sale ORDER BY datetime_save DESC"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read
                Me.cbbACyears.Items.Add(Dr.GetString("ds"))
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub cbbSelect()
        Me.dgACnumber.Rows.Clear()
        For mount As Integer = 0 To 12
            Me.dgACnumber.Rows.Add()
        Next
        With Me.dgACnumber
            .Rows(0).Cells(0).Value = "มกราคม"
            .Rows(1).Cells(0).Value = "กุมภาพันธ์"
            .Rows(2).Cells(0).Value = "มีนาคม"
            .Rows(3).Cells(0).Value = "เมษายน"
            .Rows(4).Cells(0).Value = "พฤษภาคม"
            .Rows(5).Cells(0).Value = "มิถุนายน"
            .Rows(6).Cells(0).Value = "กรกฏาคม"
            .Rows(7).Cells(0).Value = "สิงหาคม"
            .Rows(8).Cells(0).Value = "กันยายน"
            .Rows(9).Cells(0).Value = "ตุลาคม"
            .Rows(10).Cells(0).Value = "พฤจิกายน"
            .Rows(11).Cells(0).Value = "ธันวาคม"
            .Rows(12).Cells(0).Value = "รวม"
        End With


        Dim mmo As Date = Nothing
        For tt As Integer = 0 To Me.dgACnumber.Rows.Count - 1
            With Me.dgACnumber
                If .Rows(tt).Cells(0).Value = "มกราคม" Then
                    mmo = Me.cbbACyears.Text & "-" & "01"
                ElseIf .Rows(tt).Cells(0).Value = "กุมภาพันธ์" Then
                    mmo = Me.cbbACyears.Text & "-" & "02"
                ElseIf .Rows(tt).Cells(0).Value = "มีนาคม" Then
                    mmo = Me.cbbACyears.Text & "-" & "03"
                ElseIf .Rows(tt).Cells(0).Value = "เมษายน" Then
                    mmo = Me.cbbACyears.Text & "-" & "04"
                ElseIf .Rows(tt).Cells(0).Value = "พฤษภาคม" Then
                    mmo = Me.cbbACyears.Text & "-" & "05"
                ElseIf .Rows(tt).Cells(0).Value = "มิถุนายน" Then
                    mmo = Me.cbbACyears.Text & "-" & "06"
                ElseIf .Rows(tt).Cells(0).Value = "กรกฏาคม" Then
                    mmo = Me.cbbACyears.Text & "-" & "07"
                ElseIf .Rows(tt).Cells(0).Value = "สิงหาคม" Then
                    mmo = Me.cbbACyears.Text & "-" & "08"
                ElseIf .Rows(tt).Cells(0).Value = "กันยายน" Then
                    mmo = Me.cbbACyears.Text & "-" & "09"
                ElseIf .Rows(tt).Cells(0).Value = "ตุลาคม" Then
                    mmo = Me.cbbACyears.Text & "-" & "10"
                ElseIf .Rows(tt).Cells(0).Value = "พฤจิกายน" Then
                    mmo = Me.cbbACyears.Text & "-" & "11"
                ElseIf .Rows(tt).Cells(0).Value = "ธันวาคม" Then
                    mmo = Me.cbbACyears.Text & "-" & "12"
                End If
            End With
            Try
                strSQL = "SELECT COALESCE(SUM(replace(total_all, ',', '')),0) AS ttl FROM cash_sale WHERE " _
                     & "datetime_save LIKE '%" & mmo.ToString("yyyy-MM") & "%'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgACnumber
                    .Rows(tt).Cells(1).Value = Dr.GetDecimal("ttl")
                End With
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Try
                'หายอดจัดซื้อ
                strSQL = "SELECT COALESCE(SUM(CAST(REPLACE(`total`,',','') AS DECIMAL(20,2))),0) AS buybuy FROM buy WHERE " _
                    & "datetime_save LIKE '%" & mmo.ToString("yyyy-MM") & "%' AND status='" & "ได้รับสินค้าแล้ว" & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgACnumber
                    .Rows(tt).Cells(2).Value = Dr.GetDecimal("buybuy")
                End With
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            'หายอดรวม
            Try
                Dim sale As Decimal = 0
                Dim buy As Decimal = 0
                Dim allProfit As Decimal = 0
                For i As Integer = 0 To Me.dgACnumber.Rows.Count - 1
                    Me.dgACnumber.Rows(i).Cells(3).Value = CDec(Me.dgACnumber.Rows(i).Cells(1).Value) - CDec(Me.dgACnumber.Rows(i).Cells(2).Value)
                    sale += CDec(Me.dgACnumber.Rows(i).Cells(1).Value)
                    buy += CDec(Me.dgACnumber.Rows(i).Cells(2).Value)
                    allProfit += CDec(Me.dgACnumber.Rows(i).Cells(3).Value)
                Next
                Me.dgACnumber.Rows(12).Cells(1).Value = sale
                Me.dgACnumber.Rows(12).Cells(2).Value = buy
                Me.dgACnumber.Rows(12).Cells(3).Value = allProfit
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next
    End Sub

    Private Sub GetDataInYear()
        'หาปี
        Try
            Me.dgACinYear.Rows.Clear()
            strSQL = "SELECT DISTINCT YEAR(datetime_save) AS ds FROM cash_sale ORDER BY datetime_save DESC LIMIT " & Me.NumericUpDown1.Value & ""
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read
                Dim r As Integer
                With Me.dgACinYear
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.GetString("ds")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        'บวกจำนวนเงิน ตามปีที่หาได้

        For tt As Integer = 0 To Me.dgACinYear.Rows.Count - 1
            Try
                strSQL = "SELECT COALESCE(SUM(replace(total_all, ',', '')),0) AS ttl FROM cash_sale WHERE " _
                     & "datetime_save LIKE '%" & Me.dgACinYear.Rows(tt).Cells(0).Value & "%'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgACinYear
                    .Rows(tt).Cells(1).Value = Dr.GetDecimal("ttl")
                End With
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Try
                'หายอดจัดซื้อ
                strSQL = "SELECT COALESCE(SUM(CAST(REPLACE(`total`,',','') AS DECIMAL(20,2))),0) AS buybuy FROM buy WHERE " _
                    & "datetime_save LIKE '%" & Me.dgACinYear.Rows(tt).Cells(0).Value & "%' AND status='" & "ได้รับสินค้าแล้ว" & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgACinYear
                    .Rows(tt).Cells(2).Value = Dr.GetDecimal("buybuy")
                End With
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        Next
        'หายอดรวม
        Try
            Dim sale_y As Decimal = 0
            Dim buy_y As Decimal = 0
            Dim allProfit_y As Decimal = 0
            For i As Integer = 0 To Me.dgACinYear.Rows.Count - 1
                Me.dgACinYear.Rows(i).Cells(3).Value = CDec(Me.dgACinYear.Rows(i).Cells(1).Value) - CDec(Me.dgACinYear.Rows(i).Cells(2).Value)
                sale_y += CDec(Me.dgACinYear.Rows(i).Cells(1).Value)
                buy_y += CDec(Me.dgACinYear.Rows(i).Cells(2).Value)
                allProfit_y += CDec(Me.dgACinYear.Rows(i).Cells(3).Value)
            Next
            Me.dgACinYear.Rows(12).Cells(1).Value = sale_y
            Me.dgACinYear.Rows(12).Cells(2).Value = buy_y
            Me.dgACinYear.Rows(12).Cells(3).Value = allProfit_y
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
#End Region

    Private Sub cbbACyears_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbACyears.SelectedIndexChanged
        Call cbbSelect()
    End Sub
    Friend header, hhtext As String
    Private Sub btnMonthPrint_Click(sender As Object, e As EventArgs) Handles btnMonthPrint.Click
        If Me.dgACnumber.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูลในตาราง", MsgBoxStyle.Information, "ไม่มีข้อมูล")
        Else
            Me.Cursor = Cursors.WaitCursor
            Try
                strSQLite = "DELETE FROM satitis"
                cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                Call open_connectionSQLite()
                cmdSQLite.ExecuteNonQuery()
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Me.Cursor = Cursors.WaitCursor
            For r As Integer = 0 To Me.dgACnumber.Rows.Count - 1
                Try
                    strSQLite = "INSERT INTO satitis(m,sale_fix,buy,profit)" _
                     & "VALUES(@m,@sale_fix,@buy,@profit)"
                    cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                    cmdSQLite.Parameters.AddWithValue("@m", Me.dgACnumber.Rows(r).Cells(0).Value)
                    cmdSQLite.Parameters.AddWithValue("@sale_fix", Me.dgACnumber.Rows(r).Cells(1).Value)
                    cmdSQLite.Parameters.AddWithValue("@buy", Me.dgACnumber.Rows(r).Cells(2).Value)
                    cmdSQLite.Parameters.AddWithValue("@profit", Me.dgACnumber.Rows(r).Cells(3).Value)
                    Call open_connectionSQLite()
                    cmdSQLite.ExecuteNonQuery()
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            Next
            Me.Cursor = Cursors.Default

            header = Me.cbbACyears.Text
            hhtext = "เดือน"
            If checkPrinter() = "A4" Then
                AuditSatitisA4PrintFrm.ShowDialog(Me)
            ElseIf checkPrinter() = "A5" Then
                AuditSatitisA5PrintFrm.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub btnYearsPrint_Click(sender As Object, e As EventArgs) Handles btnYearsPrint.Click
        If Me.dgACinYear.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูลในตาราง", MsgBoxStyle.Information, "ไม่มีข้อมูล")
        Else
            Me.Cursor = Cursors.WaitCursor
            Try
                strSQLite = "DELETE FROM satitis"
                cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                Call open_connectionSQLite()
                cmdSQLite.ExecuteNonQuery()
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Me.Cursor = Cursors.WaitCursor
            For r As Integer = 0 To Me.dgACinYear.Rows.Count - 1
                Try
                    strSQLite = "INSERT INTO satitis(m,sale_fix,buy,profit)" _
                     & "VALUES(@m,@sale_fix,@buy,@profit)"
                    cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                    cmdSQLite.Parameters.AddWithValue("@m", Me.dgACinYear.Rows(r).Cells(0).Value)
                    cmdSQLite.Parameters.AddWithValue("@sale_fix", Me.dgACinYear.Rows(r).Cells(1).Value)
                    cmdSQLite.Parameters.AddWithValue("@buy", Me.dgACinYear.Rows(r).Cells(2).Value)
                    cmdSQLite.Parameters.AddWithValue("@profit", Me.dgACinYear.Rows(r).Cells(3).Value)
                    Call open_connectionSQLite()
                    cmdSQLite.ExecuteNonQuery()
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            Next
            Me.Cursor = Cursors.Default

            header = ""
            hhtext = "ปี"
            If checkPrinter() = "A4" Then
                AuditSatitisA4PrintFrm.ShowDialog(Me)
            ElseIf checkPrinter() = "A5" Then
                AuditSatitisA5PrintFrm.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub btnACgetData_Click(sender As Object, e As EventArgs) Handles btnACgetData.Click
        Call GetDataInYear()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/finance/financereport/auditchartfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class