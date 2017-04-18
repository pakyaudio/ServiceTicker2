<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockFrm
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
        Me.txtSsearchPro = New System.Windows.Forms.TextBox()
        Me.btnSshowallpro = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtScount_num = New System.Windows.Forms.TextBox()
        Me.txtScost = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtScountProduct = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSprofit = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgStock = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSsearchPro
        '
        Me.txtSsearchPro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSsearchPro.Location = New System.Drawing.Point(309, 5)
        Me.txtSsearchPro.Name = "txtSsearchPro"
        Me.txtSsearchPro.Size = New System.Drawing.Size(151, 20)
        Me.txtSsearchPro.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.txtSsearchPro, "ใส่ชื่อสินค้า กด enter เพื่อค้นหา")
        '
        'btnSshowallpro
        '
        Me.btnSshowallpro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSshowallpro.Location = New System.Drawing.Point(466, 3)
        Me.btnSshowallpro.Name = "btnSshowallpro"
        Me.btnSshowallpro.Size = New System.Drawing.Size(59, 23)
        Me.btnSshowallpro.TabIndex = 13
        Me.btnSshowallpro.Text = "ค้นหา"
        Me.ToolTip1.SetToolTip(Me.btnSshowallpro, "ค้นหาสินค้า")
        Me.btnSshowallpro.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtScount_num)
        Me.Panel2.Controls.Add(Me.txtScost)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtScountProduct)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtSprofit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 500)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 61)
        Me.Panel2.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.DarkRed
        Me.Label9.Location = New System.Drawing.Point(620, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "ดับเบิ้ลคลิ๊กเพื่อเพิ่มรายการสินค้า"
        '
        'txtScount_num
        '
        Me.txtScount_num.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtScount_num.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtScount_num.Location = New System.Drawing.Point(327, 3)
        Me.txtScount_num.Name = "txtScount_num"
        Me.txtScount_num.ReadOnly = True
        Me.txtScount_num.Size = New System.Drawing.Size(139, 26)
        Me.txtScount_num.TabIndex = 25
        Me.txtScount_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtScount_num, "จำนวนสินค้าคงเหลือในตารางด้านบน")
        '
        'txtScost
        '
        Me.txtScost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtScost.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtScost.Location = New System.Drawing.Point(315, 29)
        Me.txtScost.Name = "txtScost"
        Me.txtScost.ReadOnly = True
        Me.txtScost.Size = New System.Drawing.Size(151, 26)
        Me.txtScost.TabIndex = 24
        Me.txtScost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtScost, "จำนวนต้นทุนของสินค้าในตารางด้านบน")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label8.Location = New System.Drawing.Point(240, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "ต้นทุนคงเหลือ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Location = New System.Drawing.Point(240, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 16)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "ยอดขายคงเหลือ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Location = New System.Drawing.Point(3, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "จำนวนรายการ"
        '
        'txtScountProduct
        '
        Me.txtScountProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtScountProduct.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtScountProduct.Location = New System.Drawing.Point(83, 3)
        Me.txtScountProduct.Name = "txtScountProduct"
        Me.txtScountProduct.ReadOnly = True
        Me.txtScountProduct.Size = New System.Drawing.Size(151, 26)
        Me.txtScountProduct.TabIndex = 20
        Me.txtScountProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtScountProduct, "จำนวนรายการสินค้าในตารางด้านบน")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(12, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "กำไรคงเหลือ"
        '
        'txtSprofit
        '
        Me.txtSprofit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSprofit.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtSprofit.Location = New System.Drawing.Point(83, 29)
        Me.txtSprofit.Name = "txtSprofit"
        Me.txtSprofit.ReadOnly = True
        Me.txtSprofit.Size = New System.Drawing.Size(151, 26)
        Me.txtSprofit.TabIndex = 18
        Me.txtSprofit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtSprofit, "จำนวนกำไร(ต้นทุน-ราคาขาย)=กำไร")
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.SplitContainer1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(784, 500)
        Me.Panel3.TabIndex = 2
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgStock)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(784, 500)
        Me.SplitContainer1.SplitterDistance = 252
        Me.SplitContainer1.TabIndex = 0
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(252, 500)
        Me.TreeView1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtSsearchPro)
        Me.Panel1.Controls.Add(Me.btnSshowallpro)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(528, 30)
        Me.Panel1.TabIndex = 6
        '
        'dgStock
        '
        Me.dgStock.AllowUserToAddRows = False
        Me.dgStock.AllowUserToDeleteRows = False
        Me.dgStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgStock.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgStock.Location = New System.Drawing.Point(0, 30)
        Me.dgStock.Name = "dgStock"
        Me.dgStock.ReadOnly = True
        Me.dgStock.RowHeadersVisible = False
        Me.dgStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgStock.Size = New System.Drawing.Size(528, 470)
        Me.dgStock.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.dgStock, "ดับเบิ้ลคลิ๊กเพื่อเลือกข้อมูล")
        '
        'StockFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "StockFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "สต็อกสินค้า"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSshowallpro As System.Windows.Forms.Button
    Friend WithEvents txtSsearchPro As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtScount_num As System.Windows.Forms.TextBox
    Friend WithEvents txtScost As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtScountProduct As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSprofit As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgStock As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
