<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckStockReportFrm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnCSRsearch = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgCSR = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.t_stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dontcheck = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.checked = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_last = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgCSR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.btnCSRsearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 26)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(623, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.TabStop = False
        Me.Button1.Text = "ดูรายการ SN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.Enabled = False
        Me.btnPrint.Image = Global.ServiceTicker.My.Resources.Resources.PrintStatusBar2_16x
        Me.btnPrint.Location = New System.Drawing.Point(718, 2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(63, 23)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.TabStop = False
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.CustomFormat = "MMMM-yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(3, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 0
        Me.DateTimePicker1.TabStop = False
        Me.DateTimePicker1.Value = New Date(2015, 1, 1, 0, 0, 0, 0)
        '
        'btnCSRsearch
        '
        Me.btnCSRsearch.Location = New System.Drawing.Point(209, 3)
        Me.btnCSRsearch.Name = "btnCSRsearch"
        Me.btnCSRsearch.Size = New System.Drawing.Size(61, 20)
        Me.btnCSRsearch.TabIndex = 1
        Me.btnCSRsearch.TabStop = False
        Me.btnCSRsearch.Text = "ค้นหา"
        Me.btnCSRsearch.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblEmployee
        '
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(30, 17)
        Me.lblEmployee.Text = "User"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgCSR)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 26)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 513)
        Me.Panel2.TabIndex = 2
        '
        'dgCSR
        '
        Me.dgCSR.AllowUserToAddRows = False
        Me.dgCSR.AllowUserToDeleteRows = False
        Me.dgCSR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgCSR.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCSR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCSR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.datetime_save, Me.t_stock, Me.dontcheck, Me.checked, Me.datetime_last})
        Me.dgCSR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCSR.Location = New System.Drawing.Point(0, 0)
        Me.dgCSR.Name = "dgCSR"
        Me.dgCSR.ReadOnly = True
        Me.dgCSR.RowHeadersVisible = False
        Me.dgCSR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCSR.Size = New System.Drawing.Size(784, 513)
        Me.dgCSR.TabIndex = 0
        '
        'no
        '
        Me.no.DataPropertyName = "no"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.no.DefaultCellStyle = DataGridViewCellStyle1
        Me.no.FillWeight = 30.0!
        Me.no.HeaderText = "#"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.ToolTipText = "ลำดับ"
        '
        'datetime_save
        '
        Me.datetime_save.DataPropertyName = "datetime_save"
        Me.datetime_save.HeaderText = "วันที่เตรียมสต็อก"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        Me.datetime_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.datetime_save.ToolTipText = "วันที่เตรียมสต็อก"
        '
        't_stock
        '
        Me.t_stock.DataPropertyName = "t_stock"
        Me.t_stock.HeaderText = "จำนวน SN ทั้งหมด"
        Me.t_stock.Name = "t_stock"
        Me.t_stock.ReadOnly = True
        Me.t_stock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.t_stock.ToolTipText = "จำนวน SN ทั้งหมด"
        '
        'dontcheck
        '
        Me.dontcheck.DataPropertyName = "dontcheck"
        Me.dontcheck.HeaderText = "ยังไม่ได้ตรวจสอบ"
        Me.dontcheck.Name = "dontcheck"
        Me.dontcheck.ReadOnly = True
        Me.dontcheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dontcheck.ToolTipText = "ยังไม่ได้ตรวจสอบ"
        '
        'checked
        '
        Me.checked.DataPropertyName = "checked"
        Me.checked.HeaderText = "ตรวจสอบแล้ว"
        Me.checked.Name = "checked"
        Me.checked.ReadOnly = True
        Me.checked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.checked.ToolTipText = "ตรวจสอบแล้ว"
        '
        'datetime_last
        '
        Me.datetime_last.DataPropertyName = "datetime_last"
        Me.datetime_last.HeaderText = "วันที่ตรวจสอบล่าสุด"
        Me.datetime_last.Name = "datetime_last"
        Me.datetime_last.ReadOnly = True
        Me.datetime_last.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.datetime_last.ToolTipText = "วันที่ตรวจสอบล่าสุด"
        '
        'btnHelp
        '
        Me.btnHelp.AutoToolTip = True
        Me.btnHelp.Image = Global.ServiceTicker.My.Resources.Resources._109_AllAnnotations_Help_16x16_72
        Me.btnHelp.IsLink = True
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(16, 17)
        Me.btnHelp.ToolTipText = "Help"
        '
        'CheckStockReportFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CheckStockReportFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายงานตรวจสอบสต็อก SN"
        Me.Panel1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgCSR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCSRsearch As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgCSR As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents t_stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dontcheck As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents checked As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_last As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
