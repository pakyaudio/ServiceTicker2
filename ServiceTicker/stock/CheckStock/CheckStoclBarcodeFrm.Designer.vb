<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckStoclBarcodeFrm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnClearStock = New System.Windows.Forms.Button()
        Me.txtCSBCid = New System.Windows.Forms.TextBox()
        Me.btnCSBCsetStart = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCSBCenterBC = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCSBCtotalPro = New System.Windows.Forms.TextBox()
        Me.txtCSBCcNumPro = New System.Windows.Forms.TextBox()
        Me.txtCSBCfail = New System.Windows.Forms.TextBox()
        Me.txtCSBCfull = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtCSBClastBC = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgCSBC = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bar_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.count_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.count = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sumL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddProToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelProToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgCSBC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btnClearStock)
        Me.Panel1.Controls.Add(Me.txtCSBCid)
        Me.Panel1.Controls.Add(Me.btnCSBCsetStart)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 50)
        Me.Panel1.TabIndex = 1
        '
        'btnPrint
        '
        Me.btnPrint.Image = Global.ServiceTicker.My.Resources.Resources.PrintStatusBar2_16x
        Me.btnPrint.Location = New System.Drawing.Point(412, 16)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(48, 31)
        Me.btnPrint.TabIndex = 21
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(463, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "บันทึกล่าสุด"
        '
        'btnClearStock
        '
        Me.btnClearStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClearStock.Location = New System.Drawing.Point(161, 3)
        Me.btnClearStock.Name = "btnClearStock"
        Me.btnClearStock.Size = New System.Drawing.Size(186, 44)
        Me.btnClearStock.TabIndex = 19
        Me.btnClearStock.Text = "เคลียร์ข้อมูลตรวจสอบสต็อก"
        Me.btnClearStock.UseVisualStyleBackColor = True
        '
        'txtCSBCid
        '
        Me.txtCSBCid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCSBCid.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCSBCid.Location = New System.Drawing.Point(466, 16)
        Me.txtCSBCid.Name = "txtCSBCid"
        Me.txtCSBCid.ReadOnly = True
        Me.txtCSBCid.Size = New System.Drawing.Size(315, 31)
        Me.txtCSBCid.TabIndex = 18
        Me.txtCSBCid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCSBCsetStart
        '
        Me.btnCSBCsetStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCSBCsetStart.Location = New System.Drawing.Point(3, 3)
        Me.btnCSBCsetStart.Name = "btnCSBCsetStart"
        Me.btnCSBCsetStart.Size = New System.Drawing.Size(152, 44)
        Me.btnCSBCsetStart.TabIndex = 17
        Me.btnCSBCsetStart.Text = "เตรียมข้อมูล"
        Me.btnCSBCsetStart.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtCSBCenterBC)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtCSBCtotalPro)
        Me.Panel2.Controls.Add(Me.txtCSBCcNumPro)
        Me.Panel2.Controls.Add(Me.txtCSBCfail)
        Me.Panel2.Controls.Add(Me.txtCSBCfull)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 473)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 66)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 18)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "ใส่รหัสบาร์โค๊ตสินค้าที่นี่"
        '
        'txtCSBCenterBC
        '
        Me.txtCSBCenterBC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCSBCenterBC.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCSBCenterBC.Location = New System.Drawing.Point(3, 25)
        Me.txtCSBCenterBC.Name = "txtCSBCenterBC"
        Me.txtCSBCenterBC.Size = New System.Drawing.Size(199, 38)
        Me.txtCSBCenterBC.TabIndex = 21
        Me.txtCSBCenterBC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(706, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 18)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "เกิน"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(582, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 18)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "หาย"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(438, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 18)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "นับได้"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(260, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "สินค้าทั้งหมด"
        '
        'txtCSBCtotalPro
        '
        Me.txtCSBCtotalPro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCSBCtotalPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCSBCtotalPro.Location = New System.Drawing.Point(223, 25)
        Me.txtCSBCtotalPro.Name = "txtCSBCtotalPro"
        Me.txtCSBCtotalPro.ReadOnly = True
        Me.txtCSBCtotalPro.Size = New System.Drawing.Size(150, 38)
        Me.txtCSBCtotalPro.TabIndex = 16
        Me.txtCSBCtotalPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCSBCcNumPro
        '
        Me.txtCSBCcNumPro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCSBCcNumPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCSBCcNumPro.Location = New System.Drawing.Point(379, 25)
        Me.txtCSBCcNumPro.Name = "txtCSBCcNumPro"
        Me.txtCSBCcNumPro.ReadOnly = True
        Me.txtCSBCcNumPro.Size = New System.Drawing.Size(150, 38)
        Me.txtCSBCcNumPro.TabIndex = 15
        Me.txtCSBCcNumPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCSBCfail
        '
        Me.txtCSBCfail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCSBCfail.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCSBCfail.Location = New System.Drawing.Point(535, 25)
        Me.txtCSBCfail.Name = "txtCSBCfail"
        Me.txtCSBCfail.ReadOnly = True
        Me.txtCSBCfail.Size = New System.Drawing.Size(120, 38)
        Me.txtCSBCfail.TabIndex = 14
        Me.txtCSBCfail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCSBCfull
        '
        Me.txtCSBCfull.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCSBCfull.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCSBCfull.Location = New System.Drawing.Point(661, 25)
        Me.txtCSBCfull.Name = "txtCSBCfull"
        Me.txtCSBCfull.ReadOnly = True
        Me.txtCSBCfull.Size = New System.Drawing.Size(120, 38)
        Me.txtCSBCfull.TabIndex = 13
        Me.txtCSBCfull.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtCSBClastBC)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 426)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(784, 47)
        Me.Panel3.TabIndex = 3
        '
        'txtCSBClastBC
        '
        Me.txtCSBClastBC.BackColor = System.Drawing.SystemColors.WindowText
        Me.txtCSBClastBC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCSBClastBC.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtCSBClastBC.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtCSBClastBC.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCSBClastBC.ForeColor = System.Drawing.SystemColors.Info
        Me.txtCSBClastBC.Location = New System.Drawing.Point(0, 5)
        Me.txtCSBClastBC.Name = "txtCSBClastBC"
        Me.txtCSBClastBC.ReadOnly = True
        Me.txtCSBClastBC.Size = New System.Drawing.Size(784, 42)
        Me.txtCSBClastBC.TabIndex = 4
        Me.txtCSBClastBC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dgCSBC)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 50)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(784, 376)
        Me.Panel4.TabIndex = 4
        '
        'dgCSBC
        '
        Me.dgCSBC.AllowUserToAddRows = False
        Me.dgCSBC.AllowUserToDeleteRows = False
        Me.dgCSBC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgCSBC.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCSBC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCSBC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.code_pro, Me.bar_code, Me.name_pro, Me.price_buy, Me.count_num, Me.count, Me.sumL})
        Me.dgCSBC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCSBC.Location = New System.Drawing.Point(0, 0)
        Me.dgCSBC.MultiSelect = False
        Me.dgCSBC.Name = "dgCSBC"
        Me.dgCSBC.ReadOnly = True
        Me.dgCSBC.RowHeadersVisible = False
        Me.dgCSBC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCSBC.Size = New System.Drawing.Size(784, 376)
        Me.dgCSBC.TabIndex = 2
        '
        'no
        '
        Me.no.FillWeight = 30.0!
        Me.no.HeaderText = "#"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        '
        'code_pro
        '
        Me.code_pro.HeaderText = "รหัสสินค้า"
        Me.code_pro.Name = "code_pro"
        Me.code_pro.ReadOnly = True
        Me.code_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'bar_code
        '
        Me.bar_code.HeaderText = "บาร์โค๊ต"
        Me.bar_code.Name = "bar_code"
        Me.bar_code.ReadOnly = True
        Me.bar_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'name_pro
        '
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'price_buy
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.price_buy.DefaultCellStyle = DataGridViewCellStyle1
        Me.price_buy.HeaderText = "ราคา"
        Me.price_buy.Name = "price_buy"
        Me.price_buy.ReadOnly = True
        Me.price_buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_buy.ToolTipText = "ราคาขายปกติ"
        '
        'count_num
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = "0"
        Me.count_num.DefaultCellStyle = DataGridViewCellStyle2
        Me.count_num.HeaderText = "สต็อก"
        Me.count_num.Name = "count_num"
        Me.count_num.ReadOnly = True
        Me.count_num.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.count_num.ToolTipText = "จำนวนที่มีในสต็อก"
        '
        'count
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.NullValue = "0"
        Me.count.DefaultCellStyle = DataGridViewCellStyle3
        Me.count.HeaderText = "นับได้"
        Me.count.Name = "count"
        Me.count.ReadOnly = True
        Me.count.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.count.ToolTipText = "จำนวนที่นับได้จริง"
        '
        'sumL
        '
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = "0"
        Me.sumL.DefaultCellStyle = DataGridViewCellStyle4
        Me.sumL.HeaderText = "ขาด/เกิน"
        Me.sumL.Name = "sumL"
        Me.sumL.ReadOnly = True
        Me.sumL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddProToolStripMenuItem, Me.DelProToolStripMenuItem, Me.DelRowToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(179, 70)
        '
        'AddProToolStripMenuItem
        '
        Me.AddProToolStripMenuItem.Name = "AddProToolStripMenuItem"
        Me.AddProToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.AddProToolStripMenuItem.Text = "เพิ่มจำนวนสินค้าที่นับได้"
        '
        'DelProToolStripMenuItem
        '
        Me.DelProToolStripMenuItem.Name = "DelProToolStripMenuItem"
        Me.DelProToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.DelProToolStripMenuItem.Text = "ลบจำนวนสินค้าที่นับได้"
        '
        'DelRowToolStripMenuItem
        '
        Me.DelRowToolStripMenuItem.Name = "DelRowToolStripMenuItem"
        Me.DelRowToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.DelRowToolStripMenuItem.Text = "ลบแถว"
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
        'CheckStoclBarcodeFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "CheckStoclBarcodeFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เช็คสต็อกสินค้าบาร์โค๊ต"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgCSBC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnClearStock As System.Windows.Forms.Button
    Friend WithEvents txtCSBCid As System.Windows.Forms.TextBox
    Friend WithEvents btnCSBCsetStart As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCSBCenterBC As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCSBCtotalPro As System.Windows.Forms.TextBox
    Friend WithEvents txtCSBCcNumPro As System.Windows.Forms.TextBox
    Friend WithEvents txtCSBCfail As System.Windows.Forms.TextBox
    Friend WithEvents txtCSBCfull As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtCSBClastBC As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents dgCSBC As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddProToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DelProToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DelRowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bar_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents count_num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents count As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sumL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
