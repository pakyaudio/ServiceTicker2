<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VarunteeCheckSNFrm
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
        Me.lblVCnote = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtVCSNexprice = New System.Windows.Forms.TextBox()
        Me.txtVCSNemployee = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtVCSNvaruntee = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtVCSNdatetime_save = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtVCSNbar_code = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtVCSNname_pro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtVCSNcus_name = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtVCSNcus_id = New System.Windows.Forms.TextBox()
        Me.txtVCSNfix_id = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVCSNsalea_id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVCSNsn = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVCsearch = New System.Windows.Forms.Button()
        Me.txtVCSNsearch = New System.Windows.Forms.TextBox()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 189)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(542, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 0
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
        Me.btnHelp.AutoToolTip = True
        Me.btnHelp.Image = Global.ServiceTicker.My.Resources.Resources._109_AllAnnotations_Help_16x16_72
        Me.btnHelp.IsLink = True
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(16, 17)
        Me.btnHelp.ToolTipText = "Help"
        '
        'lblVCnote
        '
        Me.lblVCnote.AutoSize = True
        Me.lblVCnote.Location = New System.Drawing.Point(5, 170)
        Me.lblVCnote.Name = "lblVCnote"
        Me.lblVCnote.Size = New System.Drawing.Size(30, 13)
        Me.lblVCnote.TabIndex = 57
        Me.lblVCnote.Text = "Note"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(2, 129)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 13)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "หมดประกันวันที่ (ว/ด/ป)"
        '
        'txtVCSNexprice
        '
        Me.txtVCSNexprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVCSNexprice.Location = New System.Drawing.Point(5, 145)
        Me.txtVCSNexprice.Name = "txtVCSNexprice"
        Me.txtVCSNexprice.ReadOnly = True
        Me.txtVCSNexprice.Size = New System.Drawing.Size(531, 22)
        Me.txtVCSNexprice.TabIndex = 55
        '
        'txtVCSNemployee
        '
        Me.txtVCSNemployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVCSNemployee.Location = New System.Drawing.Point(386, 104)
        Me.txtVCSNemployee.Name = "txtVCSNemployee"
        Me.txtVCSNemployee.ReadOnly = True
        Me.txtVCSNemployee.Size = New System.Drawing.Size(150, 22)
        Me.txtVCSNemployee.TabIndex = 54
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(383, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "พนักงาน"
        '
        'txtVCSNvaruntee
        '
        Me.txtVCSNvaruntee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVCSNvaruntee.Location = New System.Drawing.Point(5, 104)
        Me.txtVCSNvaruntee.Name = "txtVCSNvaruntee"
        Me.txtVCSNvaruntee.ReadOnly = True
        Me.txtVCSNvaruntee.Size = New System.Drawing.Size(95, 22)
        Me.txtVCSNvaruntee.TabIndex = 50
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(2, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 13)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "ระยะเวลารับประกัน"
        '
        'txtVCSNdatetime_save
        '
        Me.txtVCSNdatetime_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVCSNdatetime_save.Location = New System.Drawing.Point(113, 104)
        Me.txtVCSNdatetime_save.Name = "txtVCSNdatetime_save"
        Me.txtVCSNdatetime_save.ReadOnly = True
        Me.txtVCSNdatetime_save.Size = New System.Drawing.Size(267, 22)
        Me.txtVCSNdatetime_save.TabIndex = 48
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(110, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "วันที่ขาย (ว/ด/ป)"
        '
        'txtVCSNbar_code
        '
        Me.txtVCSNbar_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVCSNbar_code.Location = New System.Drawing.Point(259, 63)
        Me.txtVCSNbar_code.Name = "txtVCSNbar_code"
        Me.txtVCSNbar_code.ReadOnly = True
        Me.txtVCSNbar_code.Size = New System.Drawing.Size(121, 22)
        Me.txtVCSNbar_code.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(259, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "รหัสสินค้า"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(386, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "ชื่อสินค้า"
        '
        'txtVCSNname_pro
        '
        Me.txtVCSNname_pro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVCSNname_pro.Location = New System.Drawing.Point(386, 63)
        Me.txtVCSNname_pro.Name = "txtVCSNname_pro"
        Me.txtVCSNname_pro.ReadOnly = True
        Me.txtVCSNname_pro.Size = New System.Drawing.Size(150, 22)
        Me.txtVCSNname_pro.TabIndex = 43
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(129, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "ชื่อลูกค้า"
        '
        'txtVCSNcus_name
        '
        Me.txtVCSNcus_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVCSNcus_name.Location = New System.Drawing.Point(132, 63)
        Me.txtVCSNcus_name.Name = "txtVCSNcus_name"
        Me.txtVCSNcus_name.ReadOnly = True
        Me.txtVCSNcus_name.Size = New System.Drawing.Size(121, 22)
        Me.txtVCSNcus_name.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "รหัสลูกค้า"
        '
        'txtVCSNcus_id
        '
        Me.txtVCSNcus_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVCSNcus_id.Location = New System.Drawing.Point(5, 63)
        Me.txtVCSNcus_id.Name = "txtVCSNcus_id"
        Me.txtVCSNcus_id.ReadOnly = True
        Me.txtVCSNcus_id.Size = New System.Drawing.Size(121, 22)
        Me.txtVCSNcus_id.TabIndex = 39
        '
        'txtVCSNfix_id
        '
        Me.txtVCSNfix_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVCSNfix_id.Location = New System.Drawing.Point(416, 22)
        Me.txtVCSNfix_id.Name = "txtVCSNfix_id"
        Me.txtVCSNfix_id.ReadOnly = True
        Me.txtVCSNfix_id.Size = New System.Drawing.Size(121, 22)
        Me.txtVCSNfix_id.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(416, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "เลขใบซ่อม"
        '
        'txtVCSNsalea_id
        '
        Me.txtVCSNsalea_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVCSNsalea_id.Location = New System.Drawing.Point(289, 22)
        Me.txtVCSNsalea_id.Name = "txtVCSNsalea_id"
        Me.txtVCSNsalea_id.ReadOnly = True
        Me.txtVCSNsalea_id.Size = New System.Drawing.Size(121, 22)
        Me.txtVCSNsalea_id.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(289, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "เลขใบขาย"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(159, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "SN"
        '
        'txtVCSNsn
        '
        Me.txtVCSNsn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVCSNsn.Location = New System.Drawing.Point(162, 22)
        Me.txtVCSNsn.Name = "txtVCSNsn"
        Me.txtVCSNsn.ReadOnly = True
        Me.txtVCSNsn.Size = New System.Drawing.Size(121, 22)
        Me.txtVCSNsn.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "ค้นหาจาก SN"
        '
        'btnVCsearch
        '
        Me.btnVCsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVCsearch.Image = Global.ServiceTicker.My.Resources.Resources.ZoomNeutral_16xlG
        Me.btnVCsearch.Location = New System.Drawing.Point(123, 20)
        Me.btnVCsearch.Name = "btnVCsearch"
        Me.btnVCsearch.Size = New System.Drawing.Size(33, 24)
        Me.btnVCsearch.TabIndex = 31
        Me.btnVCsearch.UseVisualStyleBackColor = True
        '
        'txtVCSNsearch
        '
        Me.txtVCSNsearch.BackColor = System.Drawing.SystemColors.Info
        Me.txtVCSNsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVCSNsearch.Location = New System.Drawing.Point(5, 22)
        Me.txtVCSNsearch.Name = "txtVCSNsearch"
        Me.txtVCSNsearch.Size = New System.Drawing.Size(112, 22)
        Me.txtVCSNsearch.TabIndex = 30
        '
        'VarunteeCheckSNFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 211)
        Me.Controls.Add(Me.lblVCnote)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtVCSNexprice)
        Me.Controls.Add(Me.txtVCSNemployee)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtVCSNvaruntee)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtVCSNdatetime_save)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtVCSNbar_code)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtVCSNname_pro)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtVCSNcus_name)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtVCSNcus_id)
        Me.Controls.Add(Me.txtVCSNfix_id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtVCSNsalea_id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtVCSNsn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnVCsearch)
        Me.Controls.Add(Me.txtVCSNsearch)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "VarunteeCheckSNFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เช็คประกันอุปกรณ์จาก SN สินค้า"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblVCnote As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtVCSNexprice As System.Windows.Forms.TextBox
    Friend WithEvents txtVCSNemployee As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtVCSNvaruntee As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtVCSNdatetime_save As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtVCSNbar_code As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtVCSNname_pro As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtVCSNcus_name As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtVCSNcus_id As System.Windows.Forms.TextBox
    Friend WithEvents txtVCSNfix_id As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtVCSNsalea_id As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtVCSNsn As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnVCsearch As System.Windows.Forms.Button
    Friend WithEvents txtVCSNsearch As System.Windows.Forms.TextBox
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
