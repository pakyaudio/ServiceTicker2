Imports MySql.Data.MySqlClient

Public Class PrintSaveDatafixSendRepairFrm
    Private Sub GetDataComfix(ByVal sf As Integer, ByVal searchtxt As String)
        Try
            Me.dgPSDF.Rows.Clear()
            If sf = 100 Then
                strSQL = "SELECT fix_id,date_save,date_get,customer_id,customer_name,`sn`,symptom,managerdata,fixaccessory,fixrepairnote,fixuser,fixnote,`status` FROM " _
                & "comfix WHERE customer_name LIKE '%" & searchtxt & "%' or `sn` LIKE '%" & searchtxt & "%' or symptom LIKE '%" & searchtxt & "%'" _
                & " or fixrepairnote LIKE '%" & searchtxt & "%' or fixuser LIKE '%" & searchtxt & "%'" _
                & " ORDER BY `id` DESC"
            Else
                strSQL = "SELECT fix_id,date_save,date_get,customer_id,customer_name,sn,symptom,managerdata,fixaccessory,fixrepairnote,fixuser,fixnote,`status` FROM " _
               & "comfix ORDER BY `id` DESC LIMIT " & NumericUpDown1.Value.ToString & ""
            End If
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dim r As Integer
            While (Dr.Read())
                With Me.dgPSDF
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = r + 1
                    .Rows(r).Cells(1).Value = Dr.GetString("fix_id")
                    .Rows(r).Cells(2).Value = Dr.GetString("date_save")
                    .Rows(r).Cells(3).Value = Dr.GetString("date_get")
                    .Rows(r).Cells(4).Value = Dr.GetString("customer_id")
                    .Rows(r).Cells(5).Value = Dr.GetString("customer_name")
                    .Rows(r).Cells(7).Value = Dr.GetString("sn")
                    .Rows(r).Cells(12).Value = Dr.GetString("symptom")
                    .Rows(r).Cells(13).Value = Dr.GetString("managerdata")
                    .Rows(r).Cells(14).Value = Dr.GetString("fixrepairnote")
                    .Rows(r).Cells(15).Value = Dr.GetString("fixaccessory")
                    .Rows(r).Cells(16).Value = Dr.GetString("fixuser")
                    .Rows(r).Cells(17).Value = Dr.GetString("fixnote")
                    .Rows(r).Cells(18).Value = Dr.GetString("status")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Try
            For sum As Integer = 0 To Me.dgPSDF.Rows.Count - 1
                strSQL = "SELECT p_type,p_name,model,color FROM sn WHERE Snum='" & Me.dgPSDF.Rows(sum).Cells(7).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                If Dr.HasRows Then
                    Dim r As Integer
                    With Me.dgPSDF
                        r = .RowCount
                        .Rows(sum).Cells(8).Value = Dr.GetString("p_type")
                        .Rows(sum).Cells(9).Value = Dr.GetString("p_name")
                        .Rows(sum).Cells(10).Value = Dr.GetString("model")
                        .Rows(sum).Cells(11).Value = Dr.GetString("color")
                    End With
                Else
                    With Me.dgPSDF
                        Dim r As Integer
                        r = .RowCount
                        .Rows(sum).Cells(8).Value = "##ไม่พบข้อมูล##"
                        .Rows(sum).Cells(9).Value = "##ไม่พบข้อมูล##"
                        .Rows(sum).Cells(10).Value = "##ไม่พบข้อมูล##"
                        .Rows(sum).Cells(11).Value = "##ไม่พบข้อมูล##"
                    End With
                End If
            Next
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        Try
            For sum As Integer = 0 To Me.dgPSDF.Rows.Count - 1
                strSQL = "SELECT customer_tel FROM customer WHERE customer_id='" & Me.dgPSDF.Rows(sum).Cells(4).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                Dim r As Integer
                With Me.dgPSDF
                    r = .RowCount
                    .Rows(sum).Cells(6).Value = Dr.GetString("customer_tel")
                End With
            Next
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        If sf = 100 Then
            Me.txtSearch.Text = Nothing
        End If
        sf = Nothing
    End Sub
    Friend fixid, spt, fixacc As String
    Private Sub SelectPrint()
        If Me.dgPSDF.SelectedRows.Count = 0 Then
            MainFrm.lblMainStatus.Text = "กรุณาเลือกข้อมูลที่ต้องการจะพิมพ์ก่อน"
            Exit Sub
        ElseIf Me.dgPSDF.CurrentRow.Cells(18).Value = "7 คืนเครื่องแล้ว" Then
            With Me.dgPSDF.CurrentRow
                fixid = .Cells(1).Value
                spt = .Cells(12).Value
                fixacc = .Cells(15).Value
            End With
            If checkPrinter() = "A4" Then
                ReSendRepairPrintA4Frm.ShowDialog(Me)
            ElseIf checkPrinter() = "A5" Then
                ReSendRepairPrintA5Frm.ShowDialog(Me)
            End If
        Else
            With Me.dgPSDF.CurrentRow
                fixid = .Cells(1).Value
                spt = .Cells(12).Value
                fixacc = .Cells(15).Value
            End With
            If checkPrinter() = "A4" Then
                ReSavedatafixPrintA4Frm.ShowDialog(Me)
            ElseIf checkPrinter() = "A5" Then
                ReSavedatafixPrintA5Frm.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub PrintSaveDatafixSendRepairFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub PrintSaveDatafixSendRepairFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call GetDataComfix(0, Nothing)
    End Sub

    Private Sub btnPSDFrefresh_Click(sender As Object, e As EventArgs) Handles btnPSDFrefresh.Click
        Call GetDataComfix(0, Nothing)
    End Sub

    Private Sub btnPSDFprint_Click(sender As Object, e As EventArgs) Handles btnPSDFprint.Click
        Call SelectPrint()
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GetDataComfix(100, Me.txtSearch.Text)
        End If
    End Sub

    Dim oldData As Object
    Private Sub dgPSDF_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPSDF.CellDoubleClick
        oldData = Me.dgPSDF.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub

    Private Sub dgPSDF_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgPSDF.CellEndEdit
        Me.dgPSDF.CurrentRow.Cells(e.ColumnIndex).Value = oldData
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/comfix/comfixprint/printsavedatafixsendrepairfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class