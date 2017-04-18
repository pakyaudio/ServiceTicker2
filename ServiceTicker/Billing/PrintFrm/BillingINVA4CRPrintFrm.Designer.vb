<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillingINVA4CRPrintFrm
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.BillingDataSet1 = New ServiceTicker.BillingDataSet()
        Me.TaxinvoiceTableAdapter1 = New ServiceTicker.BillingDataSetTableAdapters.taxinvoiceTableAdapter()
        Me.CompanyTableAdapter1 = New ServiceTicker.BillingDataSetTableAdapters.companyTableAdapter()
        CType(Me.BillingDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(784, 561)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'BillingDataSet1
        '
        Me.BillingDataSet1.DataSetName = "BillingDataSet"
        Me.BillingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TaxinvoiceTableAdapter1
        '
        Me.TaxinvoiceTableAdapter1.ClearBeforeFill = True
        '
        'CompanyTableAdapter1
        '
        Me.CompanyTableAdapter1.ClearBeforeFill = True
        '
        'BillingINVA4CRPrintFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "BillingINVA4CRPrintFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "พิมพ์เอกสาร ขนาด A4"
        CType(Me.BillingDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BillingDataSet1 As ServiceTicker.BillingDataSet
    Friend WithEvents TaxinvoiceTableAdapter1 As ServiceTicker.BillingDataSetTableAdapters.taxinvoiceTableAdapter
    Friend WithEvents CompanyTableAdapter1 As ServiceTicker.BillingDataSetTableAdapters.companyTableAdapter
End Class
