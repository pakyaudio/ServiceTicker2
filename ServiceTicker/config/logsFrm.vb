Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class logsFrm
    Private Sub getM()
        Try
            Me.cbbMonth.Items.Clear()
            cmd = New MySqlCommand("SELECT DISTINCT MONTH(date_in) AS mm FROM applogs ORDER BY mm ASC", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Me.cbbMonth.Items.Add("")
            While Dr.Read()
                If Dr.GetString("mm") = "1" Then
                    Me.cbbMonth.Items.Add("มกราคม")
                ElseIf Dr.GetString("mm") = "2" Then
                    Me.cbbMonth.Items.Add("กุมภาพันธ์")
                ElseIf Dr.GetString("mm") = "3" Then
                    Me.cbbMonth.Items.Add("มีนาคม")
                ElseIf Dr.GetString("mm") = "4" Then
                    Me.cbbMonth.Items.Add("เมษายน")
                ElseIf Dr.GetString("mm") = "5" Then
                    Me.cbbMonth.Items.Add("พฤษภาคม")
                ElseIf Dr.GetString("mm") = "6" Then
                    Me.cbbMonth.Items.Add("มิถุนายน")
                ElseIf Dr.GetString("mm") = "7" Then
                    Me.cbbMonth.Items.Add("กรกฎาคม")
                ElseIf Dr.GetString("mm") = "8" Then
                    Me.cbbMonth.Items.Add("สิงหาคม")
                ElseIf Dr.GetString("mm") = "9" Then
                    Me.cbbMonth.Items.Add("กันยายน")
                ElseIf Dr.GetString("mm") = "10" Then
                    Me.cbbMonth.Items.Add("ตุลาคม")
                ElseIf Dr.GetString("mm") = "11" Then
                    Me.cbbMonth.Items.Add("พฤษจิกายน")
                ElseIf Dr.GetString("mm") = "12" Then
                    Me.cbbMonth.Items.Add("ธันวาคม")
                End If
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub getY()
        Try
            cmd = New MySqlCommand("SELECT DISTINCT YEAR(date_in) AS yy FROM applogs ORDER BY yy DESC", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader

            While Dr.Read()
                Me.cbbYear.Items.Add(Dr.Item("yy"))
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub logsFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub logsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Call getM()
        Call getY()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If Me.cbbYear.Text = Nothing Then
            MessageBox.Show(Me, "กรุณาเลือกปี", "เลือกปี", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try
            Me.dgLOGSdata.Rows.Clear()
            Dim monthtonum As String = Nothing
            If Me.cbbMonth.Text = "มกราคม" Then
                monthtonum = "-01"
            ElseIf Me.cbbMonth.Text = "กุมภาพันธ์" Then
                monthtonum = "-02"
            ElseIf Me.cbbMonth.Text = "มีนาคม" Then
                monthtonum = "-03"
            ElseIf Me.cbbMonth.Text = "เมษายน" Then
                monthtonum = "-04"
            ElseIf Me.cbbMonth.Text = "พฤษภาคม" Then
                monthtonum = "-05"
            ElseIf Me.cbbMonth.Text = "มิถุนายน" Then
                monthtonum = "-06"
            ElseIf Me.cbbMonth.Text = "กรกฎาคม" Then
                monthtonum = "-07"
            ElseIf Me.cbbMonth.Text = "สิงหาคม" Then
                monthtonum = "-08"
            ElseIf Me.cbbMonth.Text = "กันยายน" Then
                monthtonum = "-09"
            ElseIf Me.cbbMonth.Text = "ตุลาคม" Then
                monthtonum = "-10"
            ElseIf Me.cbbMonth.Text = "พฤษจิกายน" Then
                monthtonum = "-11"
            ElseIf Me.cbbMonth.Text = "ธันวาคม" Then
                monthtonum = "-12"
            ElseIf Me.cbbMonth.Text = "" Then
                monthtonum = ""
            End If
            cmd = New MySqlCommand("SELECT * FROM applogs WHERE " _
                                   & "date_in LIKE '%" & Me.cbbYear.Text & monthtonum & "%' ORDER BY date_in DESC", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim r As Integer
                With Me.dgLOGSdata
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.GetString("user_id")
                    .Rows(r).Cells(1).Value = Dr.GetString("user_name")
                    .Rows(r).Cells(2).Value = Dr.GetString("user_usernamelogin")
                    .Rows(r).Cells(3).Value = Dr.GetString("note")
                    .Rows(r).Cells(4).Value = Dr.Item("date_in")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub cbbMonth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbMonth.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbbMonth_DropDown(sender As Object, e As EventArgs) Handles cbbMonth.DropDown
        Call getM()
    End Sub

    Private Sub cbbYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbYear.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbbYear_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbYear.SelectedValueChanged
        Me.cbbMonth.Items.Clear()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/config/logsfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class