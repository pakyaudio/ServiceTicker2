<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimsSendSendReportA5PrintFrm
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
        Me.companyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MySQLReport = New ServiceTicker.MySQLReport()
        Me.claims_send_s_reportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STdata = New ServiceTicker.STdata()
        Me.claims_send_reportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.claims_send_reportTableAdapter = New ServiceTicker.STdataTableAdapters.claims_send_reportTableAdapter()
        Me.companyTableAdapter = New ServiceTicker.MySQLReportTableAdapters.companyTableAdapter()
        Me.claims_send_s_reportTableAdapter = New ServiceTicker.STdataTableAdapters.claims_send_s_reportTableAdapter()
        CType(Me.companyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MySQLReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.claims_send_s_reportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.claims_send_reportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'claims_send_s_reportBindingSource
        '
        Me.claims_send_s_reportBindingSource.DataMember = "claims_send_s_report"
        Me.claims_send_s_reportBindingSource.DataSource = Me.STdata
        '
        'STdata
        '
        Me.STdata.DataSetName = "STdata"
        Me.STdata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'claims_send_reportBindingSource
        '
        Me.claims_send_reportBindingSource.DataMember = "claims_send_report"
        Me.claims_send_reportBindingSource.DataSource = Me.STdata
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "companyDataSet"
        ReportDataSource1.Value = Me.companyBindingSource
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.claims_send_s_reportBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ServiceTicker.ClaimsSendSendReportA5.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'claims_send_reportTableAdapter
        '
        Me.claims_send_reportTableAdapter.ClearBeforeFill = True
        '
        'companyTableAdapter
        '
        Me.companyTableAdapter.ClearBeforeFill = True
        '
        'claims_send_s_reportTableAdapter
        '
        Me.claims_send_s_reportTableAdapter.ClearBeforeFill = True
        '
        'ClaimsSendSendReportA5PrintFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ClaimsSendSendReportA5PrintFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "พิมพ์ใบส่งเคลม ขนาด A5"
        CType(Me.companyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MySQLReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.claims_send_s_reportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STdata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.claims_send_reportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents claims_send_reportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents STdata As ServiceTicker.STdata
    Friend WithEvents companyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MySQLReport As ServiceTicker.MySQLReport
    Friend WithEvents claims_send_reportTableAdapter As ServiceTicker.STdataTableAdapters.claims_send_reportTableAdapter
    Friend WithEvents companyTableAdapter As ServiceTicker.MySQLReportTableAdapters.companyTableAdapter
    Friend WithEvents claims_send_s_reportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents claims_send_s_reportTableAdapter As ServiceTicker.STdataTableAdapters.claims_send_s_reportTableAdapter
End Class
