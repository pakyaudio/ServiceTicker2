<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buy_ProReportA4PrintFrm
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BuyDataSet = New ServiceTicker.BuyDataSet()
        Me.buy_proBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.buy_proTableAdapter = New ServiceTicker.BuyDataSetTableAdapters.buy_proTableAdapter()
        Me.MySQLReport = New ServiceTicker.MySQLReport()
        Me.companyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.companyTableAdapter = New ServiceTicker.MySQLReportTableAdapters.companyTableAdapter()
        CType(Me.BuyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buy_proBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MySQLReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.companyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "buyproDataSet"
        ReportDataSource1.Value = Me.buy_proBindingSource
        ReportDataSource2.Name = "CompanyDataSet"
        ReportDataSource2.Value = Me.companyBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ServiceTicker.Buy_ProReportA4.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'BuyDataSet
        '
        Me.BuyDataSet.DataSetName = "BuyDataSet"
        Me.BuyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'buy_proBindingSource
        '
        Me.buy_proBindingSource.DataMember = "buy_pro"
        Me.buy_proBindingSource.DataSource = Me.BuyDataSet
        '
        'buy_proTableAdapter
        '
        Me.buy_proTableAdapter.ClearBeforeFill = True
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
        'Buy_ProReportA4PrintFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Buy_ProReportA4PrintFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "พิมพ์ใบสั่งซื้อสินค้า ขนาด A4"
        CType(Me.BuyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buy_proBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MySQLReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.companyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents buy_proBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyDataSet As ServiceTicker.BuyDataSet
    Friend WithEvents companyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MySQLReport As ServiceTicker.MySQLReport
    Friend WithEvents buy_proTableAdapter As ServiceTicker.BuyDataSetTableAdapters.buy_proTableAdapter
    Friend WithEvents companyTableAdapter As ServiceTicker.MySQLReportTableAdapters.companyTableAdapter
End Class
