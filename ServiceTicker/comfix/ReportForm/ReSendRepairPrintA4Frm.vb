Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Printing
Public Class ReSendRepairPrintA4Frm
    Private Function GetTTL(ByVal fixid As String) As Double
        Try
            cmd = New MySqlCommand("SELECT total_all FROM sale WHERE fix_id='" & fixid & "'", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Return Dr.Item("total_all")
            Else
                cmd = New MySqlCommand("SELECT total_all FROM cash_sale WHERE fix_id='" & fixid & "'", ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                If Dr.HasRows Then
                    Return Dr.Item("total_all")
                Else
                    Return 0
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function

    Private Sub ReSendRepairPrintA4Frm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ReSendRepairPrintA4Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        'TODO: This line of code loads data into the 'ResendComfixDataSet.cash_sale_barcode' table. You can move, or remove it, as needed.
        Me.cash_sale_barcodeTableAdapter.Fill(Me.ResendComfixDataSet.cash_sale_barcode, PrintSaveDatafixSendRepairFrm.dgPSDF.CurrentRow.Cells(1).Value)
        'TODO: This line of code loads data into the 'ResendComfixDataSet.discount' table. You can move, or remove it, as needed.
        Me.discountTableAdapter.Fill(Me.ResendComfixDataSet.discount, PrintSaveDatafixSendRepairFrm.dgPSDF.CurrentRow.Cells(1).Value)
        'TODO: This line of code loads data into the 'MySQLReport.company' table. You can move, or remove it, as needed.
        Me.companyTableAdapter.Fill(Me.MySQLReport.company)
        'TODO: This line of code loads data into the 'MySQLReport.comfix' table. You can move, or remove it, as needed.
        Me.comfixTableAdapter.ComfixFill(Me.MySQLReport.comfix, PrintSaveDatafixSendRepairFrm.dgPSDF.CurrentRow.Cells(1).Value)
        'TODO: This line of code loads data into the 'MySQLReport.sn' table. You can move, or remove it, as needed.
        Me.snTableAdapter.SNFill(Me.MySQLReport.sn, PrintSaveDatafixSendRepairFrm.dgPSDF.CurrentRow.Cells(7).Value)
        'TODO: This line of code loads data into the 'MySQLReport.sale_barcode' table. You can move, or remove it, as needed.
        Me.sale_barcodeTableAdapter.salebcFill(Me.MySQLReport.sale_barcode, PrintSaveDatafixSendRepairFrm.dgPSDF.CurrentRow.Cells(1).Value)


        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(GetTTL(PrintSaveDatafixSendRepairFrm.dgPSDF.CurrentRow.Cells(1).Value))
        Catch ex As Exception
            thaitext = ""
        End Try

        Dim ttall As New ReportParameter("totalall", GetTTL(PrintSaveDatafixSendRepairFrm.dgPSDF.CurrentRow.Cells(1).Value))
        Dim tx As New ReportParameter("thaitext", thaitext)

        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {ttall, tx})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
        CashFrm.SRP = Nothing

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class