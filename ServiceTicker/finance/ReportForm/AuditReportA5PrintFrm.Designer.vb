<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuditReportA5PrintFrm
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
        Me.dataGridviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuditReportDataSet = New ServiceTicker.AuditReportDataSet()
        Me.companyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MySQLReport = New ServiceTicker.MySQLReport()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dataGridviewTableAdapter = New ServiceTicker.AuditReportDataSetTableAdapters.dataGridviewTableAdapter()
        Me.companyTableAdapter = New ServiceTicker.MySQLReportTableAdapters.companyTableAdapter()
        CType(Me.dataGridviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuditReportDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.companyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MySQLReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridviewBindingSource
        '
        Me.dataGridviewBindingSource.DataMember = "dataGridview"
        Me.dataGridviewBindingSource.DataSource = Me.AuditReportDataSet
        '
        'AuditReportDataSet
        '
        Me.AuditReportDataSet.DataSetName = "AuditReportDataSet"
        Me.AuditReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "auditDataSet"
        ReportDataSource1.Value = Me.dataGridviewBindingSource
        ReportDataSource2.Name = "cpDataSet"
        ReportDataSource2.Value = Me.companyBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ServiceTicker.AuditReportA5Report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'dataGridviewTableAdapter
        '
        Me.dataGridviewTableAdapter.ClearBeforeFill = True
        '
        'companyTableAdapter
        '
        Me.companyTableAdapter.ClearBeforeFill = True
        '
        'AuditReportA5PrintFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "AuditReportA5PrintFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "พิมพ์รายงานรายรับ/รายจ่าย ขนาด A5"
        CType(Me.dataGridviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuditReportDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.companyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MySQLReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dataGridviewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AuditReportDataSet As ServiceTicker.AuditReportDataSet
    Friend WithEvents dataGridviewTableAdapter As ServiceTicker.AuditReportDataSetTableAdapters.dataGridviewTableAdapter
    Friend WithEvents companyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MySQLReport As ServiceTicker.MySQLReport
    Friend WithEvents companyTableAdapter As ServiceTicker.MySQLReportTableAdapters.companyTableAdapter
End Class
