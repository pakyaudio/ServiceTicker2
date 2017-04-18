<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimsCompanyFrm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCCdel = New System.Windows.Forms.Button()
        Me.btnCCadd = New System.Windows.Forms.Button()
        Me.btnCCedit = New System.Windows.Forms.Button()
        Me.btnCCcancel = New System.Windows.Forms.Button()
        Me.lblCCwarninig = New System.Windows.Forms.Label()
        Me.btnCCtoclaimsSend = New System.Windows.Forms.Button()
        Me.btnCCsearch = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCCsearch = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCCcom_contect = New System.Windows.Forms.TextBox()
        Me.txtCCcom_address = New System.Windows.Forms.TextBox()
        Me.txtCCcom_name = New System.Windows.Forms.TextBox()
        Me.txtCCcom_id = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgCC = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.company_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.company_address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.company_contect = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgCC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCCdel)
        Me.Panel1.Controls.Add(Me.btnCCadd)
        Me.Panel1.Controls.Add(Me.btnCCedit)
        Me.Panel1.Controls.Add(Me.btnCCcancel)
        Me.Panel1.Controls.Add(Me.lblCCwarninig)
        Me.Panel1.Controls.Add(Me.btnCCtoclaimsSend)
        Me.Panel1.Controls.Add(Me.btnCCsearch)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtCCsearch)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtCCcom_contect)
        Me.Panel1.Controls.Add(Me.txtCCcom_address)
        Me.Panel1.Controls.Add(Me.txtCCcom_name)
        Me.Panel1.Controls.Add(Me.txtCCcom_id)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 305)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 134)
        Me.Panel1.TabIndex = 0
        '
        'btnCCdel
        '
        Me.btnCCdel.Location = New System.Drawing.Point(166, 107)
        Me.btnCCdel.Name = "btnCCdel"
        Me.btnCCdel.Size = New System.Drawing.Size(75, 23)
        Me.btnCCdel.TabIndex = 34
        Me.btnCCdel.Text = "ลบ"
        Me.btnCCdel.UseVisualStyleBackColor = True
        '
        'btnCCadd
        '
        Me.btnCCadd.Location = New System.Drawing.Point(4, 107)
        Me.btnCCadd.Name = "btnCCadd"
        Me.btnCCadd.Size = New System.Drawing.Size(75, 23)
        Me.btnCCadd.TabIndex = 32
        Me.btnCCadd.Text = "เพิ่ม"
        Me.btnCCadd.UseVisualStyleBackColor = True
        '
        'btnCCedit
        '
        Me.btnCCedit.Location = New System.Drawing.Point(85, 107)
        Me.btnCCedit.Name = "btnCCedit"
        Me.btnCCedit.Size = New System.Drawing.Size(75, 23)
        Me.btnCCedit.TabIndex = 33
        Me.btnCCedit.Text = "แก้ไข"
        Me.btnCCedit.UseVisualStyleBackColor = True
        '
        'btnCCcancel
        '
        Me.btnCCcancel.Location = New System.Drawing.Point(247, 107)
        Me.btnCCcancel.Name = "btnCCcancel"
        Me.btnCCcancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCCcancel.TabIndex = 35
        Me.btnCCcancel.Text = "ยกเลิก"
        Me.btnCCcancel.UseVisualStyleBackColor = True
        '
        'lblCCwarninig
        '
        Me.lblCCwarninig.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCCwarninig.AutoSize = True
        Me.lblCCwarninig.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCCwarninig.ForeColor = System.Drawing.Color.DarkRed
        Me.lblCCwarninig.Location = New System.Drawing.Point(465, 62)
        Me.lblCCwarninig.Name = "lblCCwarninig"
        Me.lblCCwarninig.Size = New System.Drawing.Size(215, 20)
        Me.lblCCwarninig.TabIndex = 31
        Me.lblCCwarninig.Text = "กรุณาเลือกบริษัทที่ต้องการส่งเคลม"
        Me.lblCCwarninig.Visible = False
        '
        'btnCCtoclaimsSend
        '
        Me.btnCCtoclaimsSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCCtoclaimsSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCCtoclaimsSend.Location = New System.Drawing.Point(428, 85)
        Me.btnCCtoclaimsSend.Name = "btnCCtoclaimsSend"
        Me.btnCCtoclaimsSend.Size = New System.Drawing.Size(253, 46)
        Me.btnCCtoclaimsSend.TabIndex = 30
        Me.btnCCtoclaimsSend.Text = "เลือกไปหน้าส่งเคลมไปบริษัทรับเคลม"
        Me.btnCCtoclaimsSend.UseVisualStyleBackColor = True
        '
        'btnCCsearch
        '
        Me.btnCCsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCCsearch.Location = New System.Drawing.Point(605, 17)
        Me.btnCCsearch.Name = "btnCCsearch"
        Me.btnCCsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnCCsearch.TabIndex = 20
        Me.btnCCsearch.Text = "ค้นหา"
        Me.btnCCsearch.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(427, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "ค้นหา เช่น ชื่อ, ที่อยู่"
        '
        'txtCCsearch
        '
        Me.txtCCsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCCsearch.Location = New System.Drawing.Point(427, 19)
        Me.txtCCsearch.Name = "txtCCsearch"
        Me.txtCCsearch.Size = New System.Drawing.Size(172, 20)
        Me.txtCCsearch.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "ติดต่อ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "ที่อยู่บริษัท"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "ชื่อบริษัท"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(176, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "ID"
        '
        'txtCCcom_contect
        '
        Me.txtCCcom_contect.Location = New System.Drawing.Point(63, 81)
        Me.txtCCcom_contect.Name = "txtCCcom_contect"
        Me.txtCCcom_contect.Size = New System.Drawing.Size(237, 20)
        Me.txtCCcom_contect.TabIndex = 24
        '
        'txtCCcom_address
        '
        Me.txtCCcom_address.Location = New System.Drawing.Point(63, 55)
        Me.txtCCcom_address.Name = "txtCCcom_address"
        Me.txtCCcom_address.Size = New System.Drawing.Size(237, 20)
        Me.txtCCcom_address.TabIndex = 23
        '
        'txtCCcom_name
        '
        Me.txtCCcom_name.Location = New System.Drawing.Point(63, 29)
        Me.txtCCcom_name.Name = "txtCCcom_name"
        Me.txtCCcom_name.Size = New System.Drawing.Size(237, 20)
        Me.txtCCcom_name.TabIndex = 22
        '
        'txtCCcom_id
        '
        Me.txtCCcom_id.Location = New System.Drawing.Point(200, 3)
        Me.txtCCcom_id.Name = "txtCCcom_id"
        Me.txtCCcom_id.ReadOnly = True
        Me.txtCCcom_id.Size = New System.Drawing.Size(100, 20)
        Me.txtCCcom_id.TabIndex = 21
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 439)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(684, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 1
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
        Me.Panel2.Controls.Add(Me.dgCC)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(684, 305)
        Me.Panel2.TabIndex = 2
        '
        'dgCC
        '
        Me.dgCC.AllowUserToAddRows = False
        Me.dgCC.AllowUserToDeleteRows = False
        Me.dgCC.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.company_name, Me.company_address, Me.company_contect})
        Me.dgCC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCC.Location = New System.Drawing.Point(0, 0)
        Me.dgCC.Name = "dgCC"
        Me.dgCC.ReadOnly = True
        Me.dgCC.RowHeadersVisible = False
        Me.dgCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCC.Size = New System.Drawing.Size(684, 305)
        Me.dgCC.TabIndex = 11
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'company_name
        '
        Me.company_name.HeaderText = "ชื่อบริษัท"
        Me.company_name.Name = "company_name"
        Me.company_name.ReadOnly = True
        Me.company_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.company_name.Width = 200
        '
        'company_address
        '
        Me.company_address.HeaderText = "ที่อยู่"
        Me.company_address.Name = "company_address"
        Me.company_address.ReadOnly = True
        Me.company_address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.company_address.Width = 150
        '
        'company_contect
        '
        Me.company_contect.HeaderText = "ติดต่อ"
        Me.company_contect.Name = "company_contect"
        Me.company_contect.ReadOnly = True
        Me.company_contect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.company_contect.Width = 150
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ClaimsCompanyFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ClaimsCompanyFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายชื่อบริษัทที่ส่งเคลมสินค้า"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgCC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCCdel As System.Windows.Forms.Button
    Friend WithEvents btnCCadd As System.Windows.Forms.Button
    Friend WithEvents btnCCedit As System.Windows.Forms.Button
    Friend WithEvents btnCCcancel As System.Windows.Forms.Button
    Friend WithEvents lblCCwarninig As System.Windows.Forms.Label
    Friend WithEvents btnCCtoclaimsSend As System.Windows.Forms.Button
    Friend WithEvents btnCCsearch As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCCsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCCcom_contect As System.Windows.Forms.TextBox
    Friend WithEvents txtCCcom_address As System.Windows.Forms.TextBox
    Friend WithEvents txtCCcom_name As System.Windows.Forms.TextBox
    Friend WithEvents txtCCcom_id As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgCC As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents company_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents company_address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents company_contect As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
