Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Printing
Public Class SendRepairPrintA4Frm
    Private Function getSn(ByVal snfid As String) As String
        Try
            cmd = New MySqlCommand("SELECT sn FROM comfix WHERE fix_id='" & snfid & "'", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            Return Dr.GetString("sn")
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    Private Sub SendRepairPrintA4Frm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub SendRepairPrintA4Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        If CashFrm.SRP = 1234 Then
            'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
            Me.companyTableAdapter.Fill(Me.MySQLReport.company)
            'TODO: This line of code loads data into the 'MySQLReport.comfix' table. You can move, or remove it, as needed.
            Me.comfixTableAdapter.ComfixFill(Me.MySQLReport.comfix, CashFrm.txtCashFixID.Text)
            'TODO: This line of code loads data into the 'MySQLReport.sn' table. You can move, or remove it, as needed.
            Me.snTableAdapter.SNFill(Me.MySQLReport.sn, getSn(CashFrm.txtCashFixID.Text))
            'TODO: This line of code loads data into the 'MySQLReport.sale_barcode' table. You can move, or remove it, as needed.
            Me.sale_barcodeTableAdapter.salebcFill(Me.MySQLReport.sale_barcode, CashFrm.txtCashFixID.Text)
            Dim mne As New MoneyExt()
            Dim thaitext As String
            Try
                thaitext = mne.NumberToThaiWord(CDbl(CashFrm.txtCashCash.Text))
            Catch ex As Exception
                thaitext = ""
            End Try

            Dim ttall As New ReportParameter("totalall", CashFrm.txtCashCash.Text)
            Dim tx As New ReportParameter("thaitext", thaitext)

            Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {ttall, tx})
            Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.ReportViewer1.RefreshReport()
            CashFrm.SRP = Nothing
        Else
            'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
            Me.companyTableAdapter.Fill(Me.MySQLReport.company)
            'TODO: This line of code loads data into the 'MySQLReport.comfix' table. You can move, or remove it, as needed.
            Me.comfixTableAdapter.ComfixFill(Me.MySQLReport.comfix, SendRepairFrm.txtHideform.Text)
            'TODO: This line of code loads data into the 'MySQLReport.sn' table. You can move, or remove it, as needed.
            Me.snTableAdapter.SNFill(Me.MySQLReport.sn, getSn(SendRepairFrm.txtHideform.Text))
            'TODO: This line of code loads data into the 'MySQLReport.sale_barcode' table. You can move, or remove it, as needed.
            Me.sale_barcodeTableAdapter.salebcFill(Me.MySQLReport.sale_barcode, SendRepairFrm.txtHideform.Text)
            Dim mne As New MoneyExt()
            Dim thaitext As String
            Try
                thaitext = mne.NumberToThaiWord(CDbl(SendRepairFrm.txtSRfixPrice.Text))
            Catch ex As Exception
                thaitext = ""
            End Try

            Dim ttall As New ReportParameter("totalall", SendRepairFrm.txtSRfixPrice.Text)
            Dim tx As New ReportParameter("thaitext", thaitext)

            Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {ttall, tx})
            Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub
End Class