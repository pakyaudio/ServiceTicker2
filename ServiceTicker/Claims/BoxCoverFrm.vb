Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class BoxCoverFrm

    Private Sub BoxCoverFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub BoxCoverFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Me.cbbPaper.Items.Add("A4")
        Me.cbbPaper.Items.Add("A5")
        Me.cbbPaper.SelectedIndex = 1
        Try
            Using dt = New DataTable
                strSQL = "SELECT com_name,com_address,com_tel FROM company"
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)

                Me.txtYourName.Text = dt(0)("com_name")
                Me.txtYourAddress.Text = dt(0)("com_address")
                Me.txtYourTel.Text = dt(0)("com_tel")
            End Using
        Catch ex As Exception

        End Try

        Call ReloadReport()
    End Sub

    Private Sub ReloadReport()
        Me.ReportViewer1.Reset()
        If cbbPaper.Text = "A4" Then
            Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ServiceTicker.BoxCoverReportA4.rdlc"
        ElseIf cbbPaper.Text = "A5" Then
            Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ServiceTicker.BoxCoverReportA5.rdlc"
        End If

        Dim comname As New ReportParameter("com_name", Me.txtYourName.Text)
        Dim comaddress As New ReportParameter("com_address", Me.txtYourAddress.Text)
        Dim comtel As New ReportParameter("com_tel", Me.txtYourTel.Text)

        Dim company_name As New ReportParameter("company_name", Me.txtCScom_name.Text)
        Dim company_address As New ReportParameter("company_address", Me.txtCScom_address.Text)
        Dim company_address1 As New ReportParameter("company_address1", Me.txtCScom_addressAOM.Text)
        Dim company_address2 As New ReportParameter("company_address2", Me.txtCScom_addressJJ.Text)
        Dim company_zipcode As New ReportParameter("company_zipcode", Me.txtCScom_addressZip.Text)
        Dim company_tel As New ReportParameter("company_tel", Me.txtCScom_contect.Text)
        Dim nt As New ReportParameter("note", Me.txtNote.Text)
        Dim wn As New ReportParameter("warning", Me.txtBCwarning.Text)
        Dr.Close()
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {comname, comaddress, comtel, wn, _
                                                                          company_name, company_address, _
                                                                          company_address1, company_address2, _
                                                                          company_zipcode, company_tel, nt})
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BoxCoverCompanyFrm.lblEmployee.Text = Me.lblEmployee.Text
        BoxCoverCompanyFrm.ShowDialog(Me)
    End Sub

    Private Sub RefreshReport_Click(sender As Object, e As EventArgs) Handles RefreshReport.Click
        Call ReloadReport()
    End Sub

    Private Sub RefreshReport1_Click(sender As Object, e As EventArgs) Handles RefreshReport1.Click
        Call ReloadReport()
    End Sub

    Private Sub cbbPaper_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbPaper.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/claims/claimsprint/boxcoverfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class