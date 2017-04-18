<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuditChartFrm
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Months = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgACnumber = New System.Windows.Forms.DataGridView()
        Me.mount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.profit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMonthPrint = New System.Windows.Forms.Button()
        Me.cbbACyears = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Years = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgACinYear = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.profit_all = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnYearsPrint = New System.Windows.Forms.Button()
        Me.lblLimit = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.btnACgetData = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Months.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgACnumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Years.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgACinYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblEmployee
        '
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(30, 17)
        Me.lblEmployee.Text = "User"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Months)
        Me.TabControl1.Controls.Add(Me.Years)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(784, 539)
        Me.TabControl1.TabIndex = 1
        '
        'Months
        '
        Me.Months.Controls.Add(Me.Panel2)
        Me.Months.Controls.Add(Me.Panel1)
        Me.Months.Location = New System.Drawing.Point(4, 22)
        Me.Months.Name = "Months"
        Me.Months.Padding = New System.Windows.Forms.Padding(3)
        Me.Months.Size = New System.Drawing.Size(776, 513)
        Me.Months.TabIndex = 0
        Me.Months.Text = "สถิติรายเดือน"
        Me.Months.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgACnumber)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(770, 478)
        Me.Panel2.TabIndex = 1
        '
        'dgACnumber
        '
        Me.dgACnumber.AllowUserToAddRows = False
        Me.dgACnumber.AllowUserToDeleteRows = False
        Me.dgACnumber.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgACnumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgACnumber.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.mount, Me.sale, Me.buy, Me.profit})
        Me.dgACnumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgACnumber.Location = New System.Drawing.Point(0, 0)
        Me.dgACnumber.Name = "dgACnumber"
        Me.dgACnumber.ReadOnly = True
        Me.dgACnumber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgACnumber.Size = New System.Drawing.Size(770, 478)
        Me.dgACnumber.TabIndex = 1
        '
        'mount
        '
        Me.mount.HeaderText = "เดือน"
        Me.mount.Name = "mount"
        Me.mount.ReadOnly = True
        Me.mount.Width = 150
        '
        'sale
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.sale.DefaultCellStyle = DataGridViewCellStyle1
        Me.sale.HeaderText = "ยอดขาย/ซ่อม"
        Me.sale.Name = "sale"
        Me.sale.ReadOnly = True
        Me.sale.Width = 150
        '
        'buy
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.buy.DefaultCellStyle = DataGridViewCellStyle2
        Me.buy.HeaderText = "ยอดจัดซื้อ"
        Me.buy.Name = "buy"
        Me.buy.ReadOnly = True
        Me.buy.Width = 150
        '
        'profit
        '
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.profit.DefaultCellStyle = DataGridViewCellStyle3
        Me.profit.HeaderText = "กำไร"
        Me.profit.Name = "profit"
        Me.profit.ReadOnly = True
        Me.profit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.profit.ToolTipText = "ยอดขาย ลบ ยอดจัดซื้อ"
        Me.profit.Width = 150
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnMonthPrint)
        Me.Panel1.Controls.Add(Me.cbbACyears)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(770, 29)
        Me.Panel1.TabIndex = 0
        '
        'btnMonthPrint
        '
        Me.btnMonthPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMonthPrint.BackgroundImage = Global.ServiceTicker.My.Resources.Resources.PrintStatusBar2_16x
        Me.btnMonthPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMonthPrint.Location = New System.Drawing.Point(714, 3)
        Me.btnMonthPrint.Name = "btnMonthPrint"
        Me.btnMonthPrint.Size = New System.Drawing.Size(53, 23)
        Me.btnMonthPrint.TabIndex = 4
        Me.btnMonthPrint.UseVisualStyleBackColor = True
        '
        'cbbACyears
        '
        Me.cbbACyears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbACyears.FormattingEnabled = True
        Me.cbbACyears.Location = New System.Drawing.Point(74, 3)
        Me.cbbACyears.Name = "cbbACyears"
        Me.cbbACyears.Size = New System.Drawing.Size(121, 21)
        Me.cbbACyears.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ปีดำเนินงาน"
        '
        'Years
        '
        Me.Years.Controls.Add(Me.Panel4)
        Me.Years.Controls.Add(Me.Panel3)
        Me.Years.Location = New System.Drawing.Point(4, 22)
        Me.Years.Name = "Years"
        Me.Years.Padding = New System.Windows.Forms.Padding(3)
        Me.Years.Size = New System.Drawing.Size(776, 513)
        Me.Years.TabIndex = 1
        Me.Years.Text = "สถิติรายปี"
        Me.Years.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dgACinYear)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 40)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(770, 470)
        Me.Panel4.TabIndex = 1
        '
        'dgACinYear
        '
        Me.dgACinYear.AllowUserToAddRows = False
        Me.dgACinYear.AllowUserToDeleteRows = False
        Me.dgACinYear.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgACinYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgACinYear.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.profit_all})
        Me.dgACinYear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgACinYear.Location = New System.Drawing.Point(0, 0)
        Me.dgACinYear.Name = "dgACinYear"
        Me.dgACinYear.ReadOnly = True
        Me.dgACinYear.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgACinYear.Size = New System.Drawing.Size(770, 470)
        Me.dgACinYear.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ปี"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn2.HeaderText = "ยอดขาย/ซ่อม"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn3.HeaderText = "ยอดจัดซื้อ"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'profit_all
        '
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0"
        Me.profit_all.DefaultCellStyle = DataGridViewCellStyle6
        Me.profit_all.HeaderText = "ยอดขายซ่อม - ยอดจัดซื้อ"
        Me.profit_all.Name = "profit_all"
        Me.profit_all.ReadOnly = True
        Me.profit_all.Width = 150
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnYearsPrint)
        Me.Panel3.Controls.Add(Me.lblLimit)
        Me.Panel3.Controls.Add(Me.NumericUpDown1)
        Me.Panel3.Controls.Add(Me.btnACgetData)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(770, 37)
        Me.Panel3.TabIndex = 0
        '
        'btnYearsPrint
        '
        Me.btnYearsPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnYearsPrint.BackgroundImage = Global.ServiceTicker.My.Resources.Resources.PrintStatusBar2_16x
        Me.btnYearsPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnYearsPrint.Location = New System.Drawing.Point(714, 8)
        Me.btnYearsPrint.Name = "btnYearsPrint"
        Me.btnYearsPrint.Size = New System.Drawing.Size(53, 23)
        Me.btnYearsPrint.TabIndex = 10
        Me.btnYearsPrint.UseVisualStyleBackColor = True
        '
        'lblLimit
        '
        Me.lblLimit.AutoSize = True
        Me.lblLimit.Location = New System.Drawing.Point(207, 13)
        Me.lblLimit.Name = "lblLimit"
        Me.lblLimit.Size = New System.Drawing.Size(28, 13)
        Me.lblLimit.TabIndex = 9
        Me.lblLimit.Text = "Limit"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(241, 11)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(46, 20)
        Me.NumericUpDown1.TabIndex = 8
        Me.NumericUpDown1.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'btnACgetData
        '
        Me.btnACgetData.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnACgetData.Location = New System.Drawing.Point(3, 3)
        Me.btnACgetData.Name = "btnACgetData"
        Me.btnACgetData.Size = New System.Drawing.Size(189, 30)
        Me.btnACgetData.TabIndex = 7
        Me.btnACgetData.Text = "รวมข้อมูล"
        Me.btnACgetData.UseVisualStyleBackColor = True
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
        'AuditChartFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "AuditChartFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "สถิติรายปี"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Months.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgACnumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Years.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgACinYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Months As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgACnumber As System.Windows.Forms.DataGridView
    Friend WithEvents mount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents profit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnMonthPrint As System.Windows.Forms.Button
    Friend WithEvents cbbACyears As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Years As System.Windows.Forms.TabPage
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents dgACinYear As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents profit_all As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnYearsPrint As System.Windows.Forms.Button
    Friend WithEvents lblLimit As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnACgetData As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
