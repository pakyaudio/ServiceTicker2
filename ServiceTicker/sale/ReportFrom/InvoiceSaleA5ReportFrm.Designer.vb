<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoiceSaleA5ReportFrm
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
        Me.companyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MySQLReport = New ServiceTicker.MySQLReport()
        Me.sale_barcodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleDataSet = New ServiceTicker.SaleDataSet()
        Me.saleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.companyTableAdapter = New ServiceTicker.MySQLReportTableAdapters.companyTableAdapter()
        Me.sale_barcodeTableAdapter = New ServiceTicker.SaleDataSetTableAdapters.sale_barcodeTableAdapter()
        Me.saleTableAdapter = New ServiceTicker.SaleDataSetTableAdapters.saleTableAdapter()
        CType(Me.companyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MySQLReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sale_barcodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.saleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'sale_barcodeBindingSource
        '
        Me.sale_barcodeBindingSource.DataMember = "sale_barcode"
        Me.sale_barcodeBindingSource.DataSource = Me.SaleDataSet
        '
        'SaleDataSet
        '
        Me.SaleDataSet.DataSetName = "SaleDataSet"
        Me.SaleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'saleBindingSource
        '
        Me.saleBindingSource.DataMember = "sale"
        Me.saleBindingSource.DataSource = Me.SaleDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "companyDataSet"
        ReportDataSource1.Value = Me.companyBindingSource
        ReportDataSource2.Name = "SaleBarcodeDataSet"
        ReportDataSource2.Value = Me.sale_barcodeBindingSource
        ReportDataSource3.Name = "sDataSet"
        ReportDataSource3.Value = Me.saleBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ServiceTicker.InvoiceSaleReportA5.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'companyTableAdapter
        '
        Me.companyTableAdapter.ClearBeforeFill = True
        '
        'sale_barcodeTableAdapter
        '
        Me.sale_barcodeTableAdapter.ClearBeforeFill = True
        '
        'saleTableAdapter
        '
        Me.saleTableAdapter.ClearBeforeFill = True
        '
        'InvoiceSaleA5ReportFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "InvoiceSaleA5ReportFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "พิมพ์ใบส่งของ ขนาด A5"
        CType(Me.companyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MySQLReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sale_barcodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.saleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents companyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MySQLReport As ServiceTicker.MySQLReport
    Friend WithEvents sale_barcodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SaleDataSet As ServiceTicker.SaleDataSet
    Friend WithEvents saleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents companyTableAdapter As ServiceTicker.MySQLReportTableAdapters.companyTableAdapter
    Friend WithEvents sale_barcodeTableAdapter As ServiceTicker.SaleDataSetTableAdapters.sale_barcodeTableAdapter
    Friend WithEvents saleTableAdapter As ServiceTicker.SaleDataSetTableAdapters.saleTableAdapter
End Class
