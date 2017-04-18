Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class VarunteeCheckFrm

    Private Sub VarunteeCheckFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub VarunteeCheckFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Private Sub searchData()
        Try
            If Me.txtVCsearch.Text <> Nothing Then
                Me.dgVC.Rows.Clear()
                Me.txtVCdetail.Clear()
                strSQL = "SELECT fix_id,customer_id,customer_name,sn,symptom,note_repair,fixaccessory,varuntee,fixuser,status,user_repair,datecom_repair FROM " _
                    & "comfix WHERE fix_id LIKE'%" & Me.txtVCsearch.Text & "%' OR sn LIKE'%" & Me.txtVCsearch.Text & "%' OR " _
                    & "customer_id LIKE'%" & Me.txtVCsearch.Text & "%' OR customer_name LIKE'%" & Me.txtVCsearch.Text & "%'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                While (Dr.Read())
                    Dim r As Integer
                    With Me.dgVC
                        r = .Rows.Count
                        .Rows.Add()
                        .Rows(r).Cells(0).Value = r + 1
                        .Rows(r).Cells(1).Value = Dr.Item("fix_id")
                        .Rows(r).Cells(2).Value = Dr.Item("customer_id")
                        .Rows(r).Cells(3).Value = Dr.Item("sn")
                        .Rows(r).Cells(4).Value = Dr.Item("symptom")
                        .Rows(r).Cells(5).Value = Dr.Item("note_repair")
                        .Rows(r).Cells(6).Value = Dr.Item("fixaccessory")
                        .Rows(r).Cells(7).Value = Dr.Item("varuntee")
                        .Rows(r).Cells(8).Value = Dr.Item("status")
                        .Rows(r).Cells(9).Value = Dr.Item("user_repair")
                        .Rows(r).Cells(10).Value = Dr.Item("datecom_repair")
                    End With
                End While
            End If
            Me.txtVCsearch.Clear()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Try
            For sum As Integer = 0 To Me.dgVC.Rows.Count - 1
                strSQL = "SELECT fix_id FROM sale_serial WHERE fix_id='" & Me.dgVC.Rows(sum).Cells(1).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                If Dr.HasRows Then
                    Me.dgVC.Rows(sum).Cells(11).Value = "มี"
                Else
                    strSQL = "SELECT fix_id FROM cash_sale_serial WHERE fix_id='" & Me.dgVC.Rows(sum).Cells(1).Value & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader()
                    Dr.Read()
                    If Dr.HasRows Then
                        Me.dgVC.Rows(sum).Cells(11).Value = "มี"
                    Else
                        Me.dgVC.Rows(sum).Cells(11).Value = "ไม่มี"
                    End If
                End If
            Next
        Catch ex As Exception

        End Try
        Me.dgVC.ClearSelection()
    End Sub

    Private Sub txtVCsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtVCsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call searchData()
        End If
    End Sub

    Private Sub btnVCsearch_Click(sender As Object, e As EventArgs) Handles btnVCsearch.Click
        Call searchData()
    End Sub
    Dim monthsEntered As String
    Dim newDate As Date

    Private Sub getdataClick()

        Try
            strSQL = "SELECT day FROM varuntee WHERE varuntee_status='" & Me.dgVC.CurrentRow.Cells(7).Value & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            monthsEntered = Dr.Item("day")
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Try
            Dim dateEntered As String = Me.dgVC.CurrentRow.Cells(10).Value

            Dim dateValue As Date = Date.Parse(dateEntered)
            Dim monthsValue As Integer = Integer.Parse(monthsEntered)

            ' Add the months to the date.
            newDate = DateAdd(DateInterval.Day, monthsValue, dateValue)
        Catch ex As Exception
            Me.txtVCdetail.Text = " # ไม่พบวันที่รับประกัน # "
            'MessageBox.Show(Me, "ไม่พบวันที่รับประกัน", "ไม่พบวันรับประกัน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            strSQL = "SELECT customer_name,symptom,managerdata,note_repair,date_save,date_get,date_send FROM " _
                    & "comfix WHERE fix_id='" & Me.dgVC.CurrentRow.Cells(1).Value & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            'Dim dateValue As Date = #6/1/2009 4:37:00 PM#
            'Dim DSend As Object = Dr.Item("date_send")
            Dim DSave As Date = Dr.Item("date_save")
            Dim DGetSent As Date = Dr.Item("date_get")
            Me.txtVCdetail.Text = "ชื่อลูกค้า " & Dr.Item("customer_name") & ", อาการเสีย " & Dr.Item("symptom") & ", การจัดการข้อมูล " & Dr.Item("managerdata") _
                & vbNewLine & "วันที่รับงาน " & DSave.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) & ", วันที่นัดรับงาน " _
                & DGetSent.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")) _
                & vbNewLine & " วันที่ส่งงาน " & Dr.Item("date_send") & ", บันทึกการซ่อม : " & Dr.Item("note_repair") _
                & vbNewLine & "หมดประกันวันที่(วัน/เดือน/ปี)  " & newDate.ToString("yyyy-MM-dd HH:mm:ss") & ""
        Catch ex As Exception
            Me.txtVCdetail.Text = " # ไม่พบวันที่รับประกัน # "
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    Dim oldData As Object

    Private Sub dgVC_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVC.CellDoubleClick
        oldData = Me.dgVC.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub

    Private Sub dgVC_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgVC.CellEndEdit
        Me.dgVC.CurrentRow.Cells(e.ColumnIndex).Value = oldData
    End Sub

    Private Sub dgVC_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgVC.CellMouseClick
        Call getdataClick()
    End Sub

    Private Sub btnCHCviewpro_Click(sender As Object, e As EventArgs) Handles btnCHCviewpro.Click

        VarunteeViewProductFrm.ShowDialog(Me)
    End Sub

    Private Sub dgVC_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVC.CellClick
        If Me.dgVC.CurrentRow.Cells(11).Value = "มี" Then
            Me.btnCHCviewpro.Enabled = True
        Else
            Me.btnCHCviewpro.Enabled = False
        End If
    End Sub

    Private Sub txtVCdetail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVCdetail.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/comfix/varunteecheckfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class