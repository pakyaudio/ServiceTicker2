Imports CrystalDecisions.CrystalReports.Engine
Imports System.Globalization

Public Class BillingINVSaleA4CRPrintFrm

    Private Sub BillingINVSaleA4CRPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CompanyTableAdapter1.Fill(Me.BillingDataSet1.company)
        Me.TaxinvoiceTableAdapter1.Fill(Me.BillingDataSet1.taxinvoice, TaxInvoiceFrm.txtTIbillID.Text)

        Dim cry As ReportDocument = New ReportDocument

        cry.Load(rptPathA4 & "BillingINVSaleA4CrystalReport.rpt")
        Dim paramFields As New CrystalDecisions.Shared.ParameterFields()

        Dim paramField As New CrystalDecisions.Shared.ParameterField()
        Dim discreteVal As New CrystalDecisions.Shared.ParameterDiscreteValue()

        Dim paramField2 As New CrystalDecisions.Shared.ParameterField()
        Dim discreteVal2 As New CrystalDecisions.Shared.ParameterDiscreteValue()

        Dim paramField3 As New CrystalDecisions.Shared.ParameterField()
        Dim discreteVal3 As New CrystalDecisions.Shared.ParameterDiscreteValue()

        Dim paramField4 As New CrystalDecisions.Shared.ParameterField()
        Dim discreteVal4 As New CrystalDecisions.Shared.ParameterDiscreteValue()

        Dim paramField5 As New CrystalDecisions.Shared.ParameterField()
        Dim discreteVal5 As New CrystalDecisions.Shared.ParameterDiscreteValue()

        Dim paramField6 As New CrystalDecisions.Shared.ParameterField()
        Dim discreteVal6 As New CrystalDecisions.Shared.ParameterDiscreteValue()

        'Dim paramField7 As New CrystalDecisions.Shared.ParameterField()
        'Dim discreteVal7 As New CrystalDecisions.Shared.ParameterDiscreteValue()

        Dim paramField8 As New CrystalDecisions.Shared.ParameterField()
        Dim discreteVal8 As New CrystalDecisions.Shared.ParameterDiscreteValue()

        'Dim paramField9 As New CrystalDecisions.Shared.ParameterField()
        'Dim discreteVal9 As New CrystalDecisions.Shared.ParameterDiscreteValue()

        Dim paramField10 As New CrystalDecisions.Shared.ParameterField()
        Dim discreteVal10 As New CrystalDecisions.Shared.ParameterDiscreteValue()

        Dim paramField11 As New CrystalDecisions.Shared.ParameterField()
        Dim discreteVal11 As New CrystalDecisions.Shared.ParameterDiscreteValue()

        Dim paramField12 As New CrystalDecisions.Shared.ParameterField()
        Dim discreteVal12 As New CrystalDecisions.Shared.ParameterDiscreteValue()

        Dim paramField13 As New CrystalDecisions.Shared.ParameterField()
        Dim discreteVal13 As New CrystalDecisions.Shared.ParameterDiscreteValue()

        Dim paramField14 As New CrystalDecisions.Shared.ParameterField()
        Dim discreteVal14 As New CrystalDecisions.Shared.ParameterDiscreteValue()

        Dim paramField15 As New CrystalDecisions.Shared.ParameterField()
        Dim discreteVal15 As New CrystalDecisions.Shared.ParameterDiscreteValue()

        Dim paramField16 As New CrystalDecisions.Shared.ParameterField()
        Dim discreteVal16 As New CrystalDecisions.Shared.ParameterDiscreteValue()

        Dim paramField17 As New CrystalDecisions.Shared.ParameterField()
        Dim discreteVal17 As New CrystalDecisions.Shared.ParameterDiscreteValue()
        Try
            paramField.ParameterFieldName = "thaitext"
            Dim str As String = "ตัวอักษร --- " & TaxInvoiceFrm.txtTItahitext.Text & " ---"
            discreteVal.Value = str
            paramField.CurrentValues.Add(discreteVal)
            paramFields.Add(paramField)
        Catch ex As Exception

        End Try

        Try
            paramField2.ParameterFieldName = "taxNum"
            Dim str1 As String = TaxInvoiceFrm.txtTItaxpercen.Text & " %"
            discreteVal2.Value = str1
            paramField2.CurrentValues.Add(discreteVal2)
            paramFields.Add(paramField2)
        Catch ex As Exception

        End Try

        Try
            paramField3.ParameterFieldName = "billing_name"
            Dim str3 As String = TaxInvoiceFrm.BillHeader
            discreteVal3.Value = str3
            paramField3.CurrentValues.Add(discreteVal3)
            paramFields.Add(paramField3)
        Catch ex As Exception

        End Try

        Try
            paramField4.ParameterFieldName = "Billing_id"
            Dim str4 As String = TaxInvoiceFrm.txtTIbillID.Text
            discreteVal4.Value = str4
            paramField4.CurrentValues.Add(discreteVal4)
            paramFields.Add(paramField4)
        Catch ex As Exception

        End Try

        Try
            paramField5.ParameterFieldName = "billing_date"
            Dim str5 As String
            If TaxInvoiceFrm.cbTI.Checked = True Then
                str5 = Convert.ToDateTime(TaxInvoiceFrm.DateTimePicker1.Value).ToString("d MMMM yyyy",
                                CultureInfo.CreateSpecificCulture("th-TH"))
            Else
                str5 = ""
            End If
            discreteVal5.Value = str5
            paramField5.CurrentValues.Add(discreteVal5)
            paramFields.Add(paramField5)
        Catch ex As Exception

        End Try

        Try
            paramField6.ParameterFieldName = "date_send"
            Dim str6 As String
            If TaxInvoiceFrm.cbDateSend.Checked = True Then
                str6 = Convert.ToDateTime(TaxInvoiceFrm.DateTimePicker2.Value).ToString("d MMMM yyyy",
                            CultureInfo.CreateSpecificCulture("th-TH"))
            Else
                str6 = "-"
            End If
            discreteVal6.Value = str6
            paramField6.CurrentValues.Add(discreteVal6)
            paramFields.Add(paramField6)
        Catch ex As Exception

        End Try

        'Try
        '    paramField7.ParameterFieldName = "date_cadit"
        '    Dim str7 As String = TaxInvoiceFrm.cbbDateCadit.Text
        '    discreteVal7.Value = str7
        '    paramField7.CurrentValues.Add(discreteVal7)
        '    paramFields.Add(paramField7)
        'Catch ex As Exception

        'End Try

        Try
            paramField8.ParameterFieldName = "refer"
            Dim str8 As String = TaxInvoiceFrm.txtRefer.Text
            discreteVal8.Value = str8
            paramField8.CurrentValues.Add(discreteVal8)
            paramFields.Add(paramField8)
        Catch ex As Exception

        End Try

        'Try
        '    paramField9.ParameterFieldName = "date_exp"
        '    Dim str9 As String = Convert.ToDateTime(TaxInvoiceFrm.DateTimePicker2.Value.AddDays(CInt(TaxInvoiceFrm.cbbExDay.Text))).ToString("d MMMM yyyy",
        '                    CultureInfo.CreateSpecificCulture("th-TH"))
        '    discreteVal9.Value = str9
        '    paramField9.CurrentValues.Add(discreteVal9)
        '    paramFields.Add(paramField9)
        'Catch ex As Exception

        'End Try

        Try
            paramField10.ParameterFieldName = "note"
            Dim str10 As String = TaxInvoiceFrm.txtTInote.Text
            discreteVal10.Value = str10
            paramField10.CurrentValues.Add(discreteVal10)
            paramFields.Add(paramField10)
        Catch ex As Exception

        End Try

        Try
            paramField11.ParameterFieldName = "totalall"
            Dim str11 As String = TaxInvoiceFrm.txtTItotalPro.Text
            discreteVal11.Value = str11
            paramField11.CurrentValues.Add(discreteVal11)
            paramFields.Add(paramField11)
        Catch ex As Exception

        End Try

        Try
            paramField12.ParameterFieldName = "discount"
            Dim str12 As String = TaxInvoiceFrm.txtTIdiscount1.Text
            discreteVal12.Value = str12
            paramField12.CurrentValues.Add(discreteVal12)
            paramFields.Add(paramField12)
        Catch ex As Exception

        End Try

        Try
            paramField13.ParameterFieldName = "totalAfterDiscount"
            Dim str13 As String = TaxInvoiceFrm.txtTItotal.Text
            discreteVal13.Value = str13
            paramField13.CurrentValues.Add(discreteVal13)
            paramFields.Add(paramField13)
        Catch ex As Exception

        End Try

        Try
            paramField14.ParameterFieldName = "tax"
            Dim str14 As String = TaxInvoiceFrm.txtTItotalTax.Text
            discreteVal14.Value = str14
            paramField14.CurrentValues.Add(discreteVal14)
            paramFields.Add(paramField14)
        Catch ex As Exception

        End Try

        Try
            paramField15.ParameterFieldName = "totalNet"
            Dim str15 As String = TaxInvoiceFrm.txtTItotalAll.Text
            discreteVal15.Value = str15
            paramField15.CurrentValues.Add(discreteVal15)
            paramFields.Add(paramField15)
        Catch ex As Exception

        End Try

        Call TaxInvoiceFrm.selbill()

        Try
            paramField16.ParameterFieldName = "ssp"
            Dim str16 As String = TaxInvoiceFrm.ssp
            discreteVal16.Value = str16
            paramField16.CurrentValues.Add(discreteVal16)
            paramFields.Add(paramField16)
        Catch ex As Exception

        End Try

        Try
            paramField17.ParameterFieldName = "srp"
            Dim str17 As String = TaxInvoiceFrm.srp
            discreteVal17.Value = str17
            paramField17.CurrentValues.Add(discreteVal17)
            paramFields.Add(paramField17)
        Catch ex As Exception

        End Try

        CrystalReportViewer1.ParameterFieldInfo = paramFields

        cry.SetDataSource(Me.BillingDataSet1)
        CrystalReportViewer1.ReportSource = cry
        cry.Refresh()
    End Sub
End Class