<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnProductA4ReportPrintFrm
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MySQLReport = New ServiceTicker.MySQLReport()
        Me.companyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.companyTableAdapter = New ServiceTicker.MySQLReportTableAdapters.companyTableAdapter()
        Me.ReturnProductDataSet = New ServiceTicker.ReturnProductDataSet()
        Me.returnproduct_barcodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.returnproduct_barcodeTableAdapter = New ServiceTicker.ReturnProductDataSetTableAdapters.returnproduct_barcodeTableAdapter()
        Me.returnproductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.returnproductTableAdapter = New ServiceTicker.ReturnProductDataSetTableAdapters.returnproductTableAdapter()
        CType(Me.MySQLReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.companyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReturnProductDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.returnproduct_barcodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.returnproductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "companyDataSet"
        ReportDataSource1.Value = Me.companyBindingSource
        ReportDataSource2.Name = "RPbcDataSet"
        ReportDataSource2.Value = Me.returnproduct_barcodeBindingSource
        ReportDataSource3.Name = "rpDataSet"
        ReportDataSource3.Value = Me.returnproductBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ServiceTicker.ReturnProductReportA4.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'MySQLReport
        '
        Me.MySQLReport.DataSetName = "MySQLReport"
        Me.MySQLReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'companyBindingSource
        '
        Me.companyBindingSource.DataMember = "company"
        Me.companyBindingSource.DataSource = Me.MySQLReport
        '
        'companyTableAdapter
        '
        Me.companyTableAdapter.ClearBeforeFill = True
        '
        'ReturnProductDataSet
        '
        Me.ReturnProductDataSet.DataSetName = "ReturnProductDataSet"
        Me.ReturnProductDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'returnproduct_barcodeBindingSource
        '
        Me.returnproduct_barcodeBindingSource.DataMember = "returnproduct_barcode"
        Me.returnproduct_barcodeBindingSource.DataSource = Me.ReturnProductDataSet
        '
        'returnproduct_barcodeTableAdapter
        '
        Me.returnproduct_barcodeTableAdapter.ClearBeforeFill = True
        '
        'returnproductBindingSource
        '
        Me.returnproductBindingSource.DataMember = "returnproduct"
        Me.returnproductBindingSource.DataSource = Me.ReturnProductDataSet
        '
        'returnproductTableAdapter
        '
        Me.returnproductTableAdapter.ClearBeforeFill = True
        '
        'ReturnProductA4ReportPrintFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReturnProductA4ReportPrintFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "พิมพ์ใบส่งคืนสินค้า ขนาด A4"
        CType(Me.MySQLReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.companyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReturnProductDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.returnproduct_barcodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.returnproductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents companyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MySQLReport As ServiceTicker.MySQLReport
    Friend WithEvents returnproduct_barcodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReturnProductDataSet As ServiceTicker.ReturnProductDataSet
    Friend WithEvents returnproductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents companyTableAdapter As ServiceTicker.MySQLReportTableAdapters.companyTableAdapter
    Friend WithEvents returnproduct_barcodeTableAdapter As ServiceTicker.ReturnProductDataSetTableAdapters.returnproduct_barcodeTableAdapter
    Friend WithEvents returnproductTableAdapter As ServiceTicker.ReturnProductDataSetTableAdapters.returnproductTableAdapter
End Class
