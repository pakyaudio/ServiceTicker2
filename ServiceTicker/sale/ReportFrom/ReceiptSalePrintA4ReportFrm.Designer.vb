<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceiptSalePrintA4ReportFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.cash_sale_barcodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleDataSet = New ServiceTicker.SaleDataSet()
        Me.companyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MySQLReport = New ServiceTicker.MySQLReport()
        Me.cash_saleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cash_sale_barcodeTableAdapter = New ServiceTicker.SaleDataSetTableAdapters.cash_sale_barcodeTableAdapter()
        Me.companyTableAdapter = New ServiceTicker.MySQLReportTableAdapters.companyTableAdapter()
        Me.cash_saleTableAdapter = New ServiceTicker.SaleDataSetTableAdapters.cash_saleTableAdapter()
        CType(Me.cash_sale_barcodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.companyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MySQLReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cash_saleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cash_sale_barcodeBindingSource
        '
        Me.cash_sale_barcodeBindingSource.DataMember = "cash_sale_barcode"
        Me.cash_sale_barcodeBindingSource.DataSource = Me.SaleDataSet
        '
        'SaleDataSet
        '
        Me.SaleDataSet.DataSetName = "SaleDataSet"
        Me.SaleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'companyBindingSource
        '
        Me.companyBindingSource.DataMember = "company"
        Me.companyBindingSource.DataSource = Me.MySQLReport
        '
        'MySQLReport
        '
        Me.MySQLReport.DataSetName = "MySQLReport"
        Me.MySQLReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cash_saleBindingSource
        '
        Me.cash_saleBindingSource.DataMember = "cash_sale"
        Me.cash_saleBindingSource.DataSource = Me.SaleDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "CashSaleDataSet"
        ReportDataSource1.Value = Me.cash_sale_barcodeBindingSource
        ReportDataSource2.Name = "CompanyDataSet"
        ReportDataSource2.Value = Me.companyBindingSource
        ReportDataSource3.Name = "CSDataSet"
        ReportDataSource3.Value = Me.cash_saleBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ServiceTicker.ReceiveSaleReportA4.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'cash_sale_barcodeTableAdapter
        '
        Me.cash_sale_barcodeTableAdapter.ClearBeforeFill = True
        '
        'companyTableAdapter
        '
        Me.companyTableAdapter.ClearBeforeFill = True
        '
        'cash_saleTableAdapter
        '
        Me.cash_saleTableAdapter.ClearBeforeFill = True
        '
        'ReceiptSalePrintA4ReportFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReceiptSalePrintA4ReportFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "พิมพ์ใบเสร็จรับเงิน ขนาด A4"
        CType(Me.cash_sale_barcodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.companyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MySQLReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cash_saleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cash_sale_barcodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SaleDataSet As ServiceTicker.SaleDataSet
    Friend WithEvents companyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MySQLReport As ServiceTicker.MySQLReport
    Friend WithEvents cash_saleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cash_sale_barcodeTableAdapter As ServiceTicker.SaleDataSetTableAdapters.cash_sale_barcodeTableAdapter
    Friend WithEvents companyTableAdapter As ServiceTicker.MySQLReportTableAdapters.companyTableAdapter
    Friend WithEvents cash_saleTableAdapter As ServiceTicker.SaleDataSetTableAdapters.cash_saleTableAdapter
End Class
