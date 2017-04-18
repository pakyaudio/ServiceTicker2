Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class VarunteeCheckSNFrm

    Private Sub VarunteeCheckSNFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub
    Private Sub VarunteeCheckFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Friend Sub searchData()
        Try

            Dim cp As String
            If Me.txtVCSNsearch.Text <> Nothing Then
                strSQL = "SELECT sale_id,fix_id,customer_id,customer_name,name_pro,code_pro,bar_code,serial_pro,datetime_save,employee FROM " _
                    & "cash_sale_serial WHERE serial_pro='" & Me.txtVCSNsearch.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                If Dr.HasRows Then
                    Dim dsave As Date = Dr.GetString("datetime_save")
                    Me.txtVCSNsn.Text = Dr.GetString("serial_pro")
                    Me.txtVCSNsalea_id.Text = Dr.GetString("sale_id")
                    Me.txtVCSNfix_id.Text = Dr.GetString("fix_id")
                    Me.txtVCSNcus_id.Text = Dr.GetString("customer_id")
                    Me.txtVCSNcus_name.Text = Dr.GetString("customer_name")
                    Me.txtVCSNbar_code.Text = Dr.GetString("bar_code")
                    Me.txtVCSNname_pro.Text = Dr.GetString("name_pro")
                    cp = Dr.GetString("code_pro")
                    Me.txtVCSNdatetime_save.Text = dsave
                    Me.txtVCSNemployee.Text = Dr.GetString("employee")
                    strSQL = "SELECT varuntee FROM product WHERE code_pro='" & cp & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    Dr.Read()
                    If Dr.HasRows Then
                        Me.txtVCSNvaruntee.Text = Dr.GetString("varuntee")
                        Me.lblVCnote.Text = "ค้นข้อมูลมาจากรายการสินค้าที่ชำระเงินแล้ว"
                    End If
                Else
                    strSQL = "SELECT sale_id,fix_id,customer_id,customer_name,name_pro,code_pro,bar_code,serial_pro,datetime_save,employee FROM " _
                         & "sale_serial WHERE serial_pro='" & Me.txtVCSNsearch.Text & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    Dr.Read()
                    If Dr.HasRows Then
                        Dim dsave As Date = Dr.GetString("datetime_save")
                        Me.txtVCSNsn.Text = Dr.GetString("serial_pro")
                        Me.txtVCSNsalea_id.Text = Dr.GetString("sale_id")
                        Me.txtVCSNfix_id.Text = Dr.GetString("fix_id")
                        Me.txtVCSNcus_id.Text = Dr.GetString("customer_id")
                        Me.txtVCSNcus_name.Text = Dr.GetString("customer_name")
                        Me.txtVCSNbar_code.Text = Dr.GetString("bar_code")
                        Me.txtVCSNname_pro.Text = Dr.GetString("name_pro")
                        cp = Dr.GetString("code_pro")
                        Me.txtVCSNdatetime_save.Text = dsave
                        Me.txtVCSNemployee.Text = Dr.GetString("employee")
                        strSQL = "SELECT varuntee FROM product WHERE code_pro='" & cp & "'"
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        Dr = cmd.ExecuteReader
                        Dr.Read()
                        If Dr.HasRows Then
                            Me.txtVCSNvaruntee.Text = Dr.GetString("varuntee")
                            Me.lblVCnote.Text = "ค้นข้อมูลมาจากรายการสินค้าที่ยังไม่ชำระเงิน"
                        End If
                    End If
                End If
            End If
            strSQL = "SELECT day FROM varuntee WHERE varuntee_status='" & Me.txtVCSNvaruntee.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.Item("day") = "-" Then
                dateNum = 0
            Else
                dateNum = Dr.Item("day")
            End If
            Call checkExpri()
            cp = Nothing
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Me.txtVCSNsearch.Text = ""
    End Sub
    Dim dateNum As Integer
    Dim datevrt As String
    Dim msg, secondDate As Date
    Private Sub checkExpri()
        If Me.txtVCSNsn.Text = "" Then
            Exit Sub
        End If
        Dim dayPro As Date = Me.txtVCSNdatetime_save.Text
        Try
            msg = DateAdd(DateInterval.Day, dateNum, dayPro)
            Me.txtVCSNexprice.Text = msg
        Catch ex As Exception
            Me.txtVCSNexprice.Text = "N/A"
        End Try
        
        dayPro = Nothing
    End Sub
    Private Sub txtVCsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtVCSNsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call searchData()
        End If
    End Sub

    Private Sub btnVCsearch_Click(sender As Object, e As EventArgs) Handles btnVCsearch.Click
        Call searchData()
    End Sub

    Private Sub rbVCforIN_CheckedChanged(sender As Object, e As EventArgs)
        Call checkExpri()
    End Sub

    Private Sub rbVCforSale_CheckedChanged(sender As Object, e As EventArgs)
        Call checkExpri()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/sales/varunteechecksnfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class