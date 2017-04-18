<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimsCoverPrintA4Frm
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
        Me.claimsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClaimsCoverDataSet = New ServiceTicker.ClaimsCoverDataSet()
        Me.claimsTableAdapter = New ServiceTicker.ClaimsCoverDataSetTableAdapters.claimsTableAdapter()
        Me.customerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.customerTableAdapter = New ServiceTicker.ClaimsCoverDataSetTableAdapters.customerTableAdapter()
        CType(Me.MySQLReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.companyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.claimsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClaimsCoverDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.customerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "CCoverDataSet"
        ReportDataSource1.Value = Me.claimsBindingSource
        ReportDataSource2.Name = "CpanyDataSet"
        ReportDataSource2.Value = Me.companyBindingSource
        ReportDataSource3.Name = "CtomerDataSet"
        ReportDataSource3.Value = Me.customerBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ServiceTicker.ClaimsCoverA4Report.rdlc"
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
        'claimsBindingSource
        '
        Me.claimsBindingSource.DataMember = "claims"
        Me.claimsBindingSource.DataSource = Me.ClaimsCoverDataSet
        '
        'ClaimsCoverDataSet
        '
        Me.ClaimsCoverDataSet.DataSetName = "ClaimsCoverDataSet"
        Me.ClaimsCoverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'claimsTableAdapter
        '
        Me.claimsTableAdapter.ClearBeforeFill = True
        '
        'customerBindingSource
        '
        Me.customerBindingSource.DataMember = "customer"
        Me.customerBindingSource.DataSource = Me.ClaimsCoverDataSet
        '
        'customerTableAdapter
        '
        Me.customerTableAdapter.ClearBeforeFill = True
        '
        'ClaimsCoverPrintA4Frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ClaimsCoverPrintA4Frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "พิมพ์ใบปะหน้าสินค้าเคลม ขนาด A4"
        CType(Me.MySQLReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.companyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.claimsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClaimsCoverDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.customerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents claimsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClaimsCoverDataSet As ServiceTicker.ClaimsCoverDataSet
    Friend WithEvents companyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MySQLReport As ServiceTicker.MySQLReport
    Friend WithEvents claimsTableAdapter As ServiceTicker.ClaimsCoverDataSetTableAdapters.claimsTableAdapter
    Friend WithEvents companyTableAdapter As ServiceTicker.MySQLReportTableAdapters.companyTableAdapter
    Friend WithEvents customerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents customerTableAdapter As ServiceTicker.ClaimsCoverDataSetTableAdapters.customerTableAdapter
End Class
