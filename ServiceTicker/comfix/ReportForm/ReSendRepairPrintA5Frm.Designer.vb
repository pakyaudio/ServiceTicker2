<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReSendRepairPrintA5Frm
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
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.companyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MySQLReport = New ServiceTicker.MySQLReport()
        Me.comfixBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.snBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sale_barcodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cash_sale_barcodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResendComfixDataSet = New ServiceTicker.ResendComfixDataSet()
        Me.discountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.companyTableAdapter = New ServiceTicker.MySQLReportTableAdapters.companyTableAdapter()
        Me.comfixTableAdapter = New ServiceTicker.MySQLReportTableAdapters.comfixTableAdapter()
        Me.snTableAdapter = New ServiceTicker.MySQLReportTableAdapters.snTableAdapter()
        Me.sale_barcodeTableAdapter = New ServiceTicker.MySQLReportTableAdapters.sale_barcodeTableAdapter()
        Me.cash_sale_barcodeTableAdapter = New ServiceTicker.ResendComfixDataSetTableAdapters.cash_sale_barcodeTableAdapter()
        Me.discountTableAdapter = New ServiceTicker.ResendComfixDataSetTableAdapters.discountTableAdapter()
        CType(Me.companyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MySQLReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comfixBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.snBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sale_barcodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cash_sale_barcodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResendComfixDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.discountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'comfixBindingSource
        '
        Me.comfixBindingSource.DataMember = "comfix"
        Me.comfixBindingSource.DataSource = Me.MySQLReport
        '
        'snBindingSource
        '
        Me.snBindingSource.DataMember = "sn"
        Me.snBindingSource.DataSource = Me.MySQLReport
        '
        'sale_barcodeBindingSource
        '
        Me.sale_barcodeBindingSource.DataMember = "sale_barcode"
        Me.sale_barcodeBindingSource.DataSource = Me.MySQLReport
        '
        'cash_sale_barcodeBindingSource
        '
        Me.cash_sale_barcodeBindingSource.DataMember = "cash_sale_barcode"
        Me.cash_sale_barcodeBindingSource.DataSource = Me.ResendComfixDataSet
        '
        'ResendComfixDataSet
        '
        Me.ResendComfixDataSet.DataSetName = "ResendComfixDataSet"
        Me.ResendComfixDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'discountBindingSource
        '
        Me.discountBindingSource.DataMember = "discount"
        Me.discountBindingSource.DataSource = Me.ResendComfixDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "SendComfixCompanyDataSet"
        ReportDataSource1.Value = Me.companyBindingSource
        ReportDataSource2.Name = "SendComfixDataSet"
        ReportDataSource2.Value = Me.comfixBindingSource
        ReportDataSource3.Name = "SNDataSet"
        ReportDataSource3.Value = Me.snBindingSource
        ReportDataSource4.Name = "salebcDataSet"
        ReportDataSource4.Value = Me.sale_barcodeBindingSource
        ReportDataSource5.Name = "csbcDataSet"
        ReportDataSource5.Value = Me.cash_sale_barcodeBindingSource
        ReportDataSource6.Name = "disCDataSet"
        ReportDataSource6.Value = Me.discountBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ServiceTicker.ReSendRepairReportA5.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'companyTableAdapter
        '
        Me.companyTableAdapter.ClearBeforeFill = True
        '
        'comfixTableAdapter
        '
        Me.comfixTableAdapter.ClearBeforeFill = True
        '
        'snTableAdapter
        '
        Me.snTableAdapter.ClearBeforeFill = True
        '
        'sale_barcodeTableAdapter
        '
        Me.sale_barcodeTableAdapter.ClearBeforeFill = True
        '
        'cash_sale_barcodeTableAdapter
        '
        Me.cash_sale_barcodeTableAdapter.ClearBeforeFill = True
        '
        'discountTableAdapter
        '
        Me.discountTableAdapter.ClearBeforeFill = True
        '
        'ReSendRepairPrintA5Frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReSendRepairPrintA5Frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "พิมพ์ใบส่งคืนเครื่องซ่อม ขนาด A5"
        CType(Me.companyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MySQLReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comfixBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.snBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sale_barcodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cash_sale_barcodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResendComfixDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.discountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents companyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MySQLReport As ServiceTicker.MySQLReport
    Friend WithEvents comfixBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents snBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents sale_barcodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cash_sale_barcodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResendComfixDataSet As ServiceTicker.ResendComfixDataSet
    Friend WithEvents discountBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents companyTableAdapter As ServiceTicker.MySQLReportTableAdapters.companyTableAdapter
    Friend WithEvents comfixTableAdapter As ServiceTicker.MySQLReportTableAdapters.comfixTableAdapter
    Friend WithEvents snTableAdapter As ServiceTicker.MySQLReportTableAdapters.snTableAdapter
    Friend WithEvents sale_barcodeTableAdapter As ServiceTicker.MySQLReportTableAdapters.sale_barcodeTableAdapter
    Friend WithEvents cash_sale_barcodeTableAdapter As ServiceTicker.ResendComfixDataSetTableAdapters.cash_sale_barcodeTableAdapter
    Friend WithEvents discountTableAdapter As ServiceTicker.ResendComfixDataSetTableAdapters.discountTableAdapter
End Class
