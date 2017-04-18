<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderFrm
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnORselectPro = New System.Windows.Forms.Button()
        Me.btnORokBarcode = New System.Windows.Forms.Button()
        Me.txtORbarcodePro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblORbarcodePro = New System.Windows.Forms.Label()
        Me.lblORid = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtORcompanyTel = New System.Windows.Forms.TextBox()
        Me.cbbORcompanySelect = New System.Windows.Forms.ComboBox()
        Me.txtORcompanyAddress = New System.Windows.Forms.TextBox()
        Me.txtORcompanyID = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblORsummoney = New System.Windows.Forms.Label()
        Me.txtORsumMoney = New System.Windows.Forms.TextBox()
        Me.btnORdel = New System.Windows.Forms.Button()
        Me.btnORsave = New System.Windows.Forms.Button()
        Me.dgOR = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgOR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(720, 22)
        Me.StatusStrip1.TabIndex = 50
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblEmployee
        '
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(30, 17)
        Me.lblEmployee.Text = "User"
        '
        'btnHelp
        '
        Me.btnHelp.Image = Global.ServiceTicker.My.Resources.Resources._109_AllAnnotations_Help_16x16_72
        Me.btnHelp.IsLink = True
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(16, 17)
        Me.btnHelp.ToolTipText = "Help"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnORselectPro)
        Me.Panel1.Controls.Add(Me.btnORokBarcode)
        Me.Panel1.Controls.Add(Me.txtORbarcodePro)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblORbarcodePro)
        Me.Panel1.Controls.Add(Me.lblORid)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtORcompanyTel)
        Me.Panel1.Controls.Add(Me.cbbORcompanySelect)
        Me.Panel1.Controls.Add(Me.txtORcompanyAddress)
        Me.Panel1.Controls.Add(Me.txtORcompanyID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(720, 108)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Location = New System.Drawing.Point(347, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "<<add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(462, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 18)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "เลขที่ใบสั่งซื้อ"
        '
        'btnORselectPro
        '
        Me.btnORselectPro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnORselectPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnORselectPro.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnORselectPro.Location = New System.Drawing.Point(464, 27)
        Me.btnORselectPro.Name = "btnORselectPro"
        Me.btnORselectPro.Size = New System.Drawing.Size(250, 40)
        Me.btnORselectPro.TabIndex = 3
        Me.btnORselectPro.Text = "เลือกสินค้าจากสต็อก"
        Me.btnORselectPro.UseVisualStyleBackColor = True
        '
        'btnORokBarcode
        '
        Me.btnORokBarcode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnORokBarcode.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnORokBarcode.Location = New System.Drawing.Point(684, 77)
        Me.btnORokBarcode.Name = "btnORokBarcode"
        Me.btnORokBarcode.Size = New System.Drawing.Size(33, 23)
        Me.btnORokBarcode.TabIndex = 5
        Me.btnORokBarcode.Text = "OK"
        Me.btnORokBarcode.UseVisualStyleBackColor = True
        '
        'txtORbarcodePro
        '
        Me.txtORbarcodePro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtORbarcodePro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtORbarcodePro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtORbarcodePro.ForeColor = System.Drawing.Color.Red
        Me.txtORbarcodePro.Location = New System.Drawing.Point(452, 78)
        Me.txtORbarcodePro.Name = "txtORbarcodePro"
        Me.txtORbarcodePro.Size = New System.Drawing.Size(226, 22)
        Me.txtORbarcodePro.TabIndex = 4
        Me.txtORbarcodePro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Location = New System.Drawing.Point(34, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "ที่อยู่"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(162, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "เลือกชื่อบริษัท"
        '
        'lblORbarcodePro
        '
        Me.lblORbarcodePro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblORbarcodePro.AutoSize = True
        Me.lblORbarcodePro.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblORbarcodePro.Location = New System.Drawing.Point(376, 82)
        Me.lblORbarcodePro.Name = "lblORbarcodePro"
        Me.lblORbarcodePro.Size = New System.Drawing.Size(70, 13)
        Me.lblORbarcodePro.TabIndex = 29
        Me.lblORbarcodePro.Text = "บาร์โค๊ตสินค้า"
        '
        'lblORid
        '
        Me.lblORid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblORid.AutoSize = True
        Me.lblORid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblORid.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblORid.Location = New System.Drawing.Point(550, 7)
        Me.lblORid.Name = "lblORid"
        Me.lblORid.Size = New System.Drawing.Size(0, 18)
        Me.lblORid.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(12, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "เบอร์โทร"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(7, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "รหัสบริษัท"
        '
        'txtORcompanyTel
        '
        Me.txtORcompanyTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtORcompanyTel.Location = New System.Drawing.Point(67, 78)
        Me.txtORcompanyTel.Name = "txtORcompanyTel"
        Me.txtORcompanyTel.ReadOnly = True
        Me.txtORcompanyTel.Size = New System.Drawing.Size(274, 22)
        Me.txtORcompanyTel.TabIndex = 25
        Me.txtORcompanyTel.TabStop = False
        '
        'cbbORcompanySelect
        '
        Me.cbbORcompanySelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbbORcompanySelect.FormattingEnabled = True
        Me.cbbORcompanySelect.Location = New System.Drawing.Point(153, 21)
        Me.cbbORcompanySelect.Name = "cbbORcompanySelect"
        Me.cbbORcompanySelect.Size = New System.Drawing.Size(188, 23)
        Me.cbbORcompanySelect.TabIndex = 1
        '
        'txtORcompanyAddress
        '
        Me.txtORcompanyAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtORcompanyAddress.Location = New System.Drawing.Point(67, 50)
        Me.txtORcompanyAddress.Name = "txtORcompanyAddress"
        Me.txtORcompanyAddress.ReadOnly = True
        Me.txtORcompanyAddress.Size = New System.Drawing.Size(274, 22)
        Me.txtORcompanyAddress.TabIndex = 23
        Me.txtORcompanyAddress.TabStop = False
        '
        'txtORcompanyID
        '
        Me.txtORcompanyID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtORcompanyID.Location = New System.Drawing.Point(67, 22)
        Me.txtORcompanyID.Name = "txtORcompanyID"
        Me.txtORcompanyID.Size = New System.Drawing.Size(80, 22)
        Me.txtORcompanyID.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblORsummoney)
        Me.Panel2.Controls.Add(Me.txtORsumMoney)
        Me.Panel2.Controls.Add(Me.btnORdel)
        Me.Panel2.Controls.Add(Me.btnORsave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 500)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(720, 39)
        Me.Panel2.TabIndex = 2
        '
        'lblORsummoney
        '
        Me.lblORsummoney.AutoSize = True
        Me.lblORsummoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblORsummoney.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblORsummoney.Location = New System.Drawing.Point(145, 11)
        Me.lblORsummoney.Name = "lblORsummoney"
        Me.lblORsummoney.Size = New System.Drawing.Size(43, 16)
        Me.lblORsummoney.TabIndex = 22
        Me.lblORsummoney.Text = "รวมเงิน"
        '
        'txtORsumMoney
        '
        Me.txtORsumMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtORsumMoney.Location = New System.Drawing.Point(3, 5)
        Me.txtORsumMoney.Name = "txtORsumMoney"
        Me.txtORsumMoney.ReadOnly = True
        Me.txtORsumMoney.Size = New System.Drawing.Size(136, 26)
        Me.txtORsumMoney.TabIndex = 21
        Me.txtORsumMoney.TabStop = False
        Me.txtORsumMoney.Text = "0"
        Me.txtORsumMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnORdel
        '
        Me.btnORdel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnORdel.Enabled = False
        Me.btnORdel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnORdel.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnORdel.Location = New System.Drawing.Point(548, 3)
        Me.btnORdel.Name = "btnORdel"
        Me.btnORdel.Size = New System.Drawing.Size(49, 31)
        Me.btnORdel.TabIndex = 0
        Me.btnORdel.Text = "ลบ"
        Me.btnORdel.UseVisualStyleBackColor = True
        '
        'btnORsave
        '
        Me.btnORsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnORsave.Enabled = False
        Me.btnORsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnORsave.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnORsave.Location = New System.Drawing.Point(603, 3)
        Me.btnORsave.Name = "btnORsave"
        Me.btnORsave.Size = New System.Drawing.Size(114, 31)
        Me.btnORsave.TabIndex = 1
        Me.btnORsave.Text = "บันทึก"
        Me.btnORsave.UseVisualStyleBackColor = True
        '
        'dgOR
        '
        Me.dgOR.AllowUserToAddRows = False
        Me.dgOR.AllowUserToDeleteRows = False
        Me.dgOR.AllowUserToOrderColumns = True
        Me.dgOR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgOR.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgOR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgOR.Location = New System.Drawing.Point(0, 108)
        Me.dgOR.Name = "dgOR"
        Me.dgOR.RowHeadersVisible = False
        Me.dgOR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgOR.Size = New System.Drawing.Size(720, 392)
        Me.dgOR.TabIndex = 1
        '
        'OrderFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 561)
        Me.Controls.Add(Me.dgOR)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.MinimumSize = New System.Drawing.Size(736, 600)
        Me.Name = "OrderFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "สั่งซื้อสินค้า"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgOR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnORselectPro As System.Windows.Forms.Button
    Friend WithEvents btnORokBarcode As System.Windows.Forms.Button
    Friend WithEvents txtORbarcodePro As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblORbarcodePro As System.Windows.Forms.Label
    Friend WithEvents lblORid As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtORcompanyTel As System.Windows.Forms.TextBox
    Friend WithEvents cbbORcompanySelect As System.Windows.Forms.ComboBox
    Friend WithEvents txtORcompanyAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtORcompanyID As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblORsummoney As System.Windows.Forms.Label
    Friend WithEvents txtORsumMoney As System.Windows.Forms.TextBox
    Friend WithEvents btnORdel As System.Windows.Forms.Button
    Friend WithEvents btnORsave As System.Windows.Forms.Button
    Friend WithEvents dgOR As System.Windows.Forms.DataGridView
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
