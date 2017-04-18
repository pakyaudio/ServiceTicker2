<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckPriceFrm
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
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCPsnANDbarcode = New System.Windows.Forms.TextBox()
        Me.txtCPnamePro = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblemployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbStechnician = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbSwholesale = New System.Windows.Forms.RadioButton()
        Me.rbSloyal = New System.Windows.Forms.RadioButton()
        Me.rbSbuy = New System.Windows.Forms.RadioButton()
        Me.rbSmembers = New System.Windows.Forms.RadioButton()
        Me.txtCPcount_num = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rsScost = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.txtSproDetail = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(184, 5)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(34, 13)
        Me.LinkLabel1.TabIndex = 17
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "ค้นหา"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "SN หรือ บาร์โค๊ต"
        '
        'txtCPsnANDbarcode
        '
        Me.txtCPsnANDbarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCPsnANDbarcode.Location = New System.Drawing.Point(12, 21)
        Me.txtCPsnANDbarcode.Name = "txtCPsnANDbarcode"
        Me.txtCPsnANDbarcode.Size = New System.Drawing.Size(206, 29)
        Me.txtCPsnANDbarcode.TabIndex = 15
        '
        'txtCPnamePro
        '
        Me.txtCPnamePro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCPnamePro.Location = New System.Drawing.Point(12, 69)
        Me.txtCPnamePro.Name = "txtCPnamePro"
        Me.txtCPnamePro.ReadOnly = True
        Me.txtCPnamePro.Size = New System.Drawing.Size(560, 29)
        Me.txtCPnamePro.TabIndex = 18
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblemployee, Me.btnHelp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 439)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(584, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 20
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblemployee
        '
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(30, 17)
        Me.lblemployee.Text = "User"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "ชื่อสินค้า"
        '
        'rbStechnician
        '
        Me.rbStechnician.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbStechnician.AutoSize = True
        Me.rbStechnician.Location = New System.Drawing.Point(361, 51)
        Me.rbStechnician.Name = "rbStechnician"
        Me.rbStechnician.Size = New System.Drawing.Size(42, 17)
        Me.rbStechnician.TabIndex = 157
        Me.rbStechnician.Text = "ช่าง"
        Me.rbStechnician.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(188, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 154
        Me.Label1.Text = "ระดับราคา"
        '
        'rbSwholesale
        '
        Me.rbSwholesale.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbSwholesale.AutoSize = True
        Me.rbSwholesale.Location = New System.Drawing.Point(301, 51)
        Me.rbSwholesale.Name = "rbSwholesale"
        Me.rbSwholesale.Size = New System.Drawing.Size(54, 17)
        Me.rbSwholesale.TabIndex = 156
        Me.rbSwholesale.Text = "ขายส่ง"
        Me.rbSwholesale.UseVisualStyleBackColor = True
        '
        'rbSloyal
        '
        Me.rbSloyal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbSloyal.AutoSize = True
        Me.rbSloyal.Location = New System.Drawing.Point(409, 51)
        Me.rbSloyal.Name = "rbSloyal"
        Me.rbSloyal.Size = New System.Drawing.Size(54, 17)
        Me.rbSloyal.TabIndex = 158
        Me.rbSloyal.Text = "ประจำ"
        Me.rbSloyal.UseVisualStyleBackColor = True
        '
        'rbSbuy
        '
        Me.rbSbuy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbSbuy.AutoSize = True
        Me.rbSbuy.Checked = True
        Me.rbSbuy.Location = New System.Drawing.Point(249, 51)
        Me.rbSbuy.Name = "rbSbuy"
        Me.rbSbuy.Size = New System.Drawing.Size(46, 17)
        Me.rbSbuy.TabIndex = 155
        Me.rbSbuy.TabStop = True
        Me.rbSbuy.Text = "ปกติ"
        Me.rbSbuy.UseVisualStyleBackColor = True
        '
        'rbSmembers
        '
        Me.rbSmembers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbSmembers.AutoSize = True
        Me.rbSmembers.Location = New System.Drawing.Point(469, 51)
        Me.rbSmembers.Name = "rbSmembers"
        Me.rbSmembers.Size = New System.Drawing.Size(57, 17)
        Me.rbSmembers.TabIndex = 159
        Me.rbSmembers.Text = "สมาชิก"
        Me.rbSmembers.UseVisualStyleBackColor = True
        '
        'txtCPcount_num
        '
        Me.txtCPcount_num.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCPcount_num.Location = New System.Drawing.Point(277, 21)
        Me.txtCPcount_num.Name = "txtCPcount_num"
        Me.txtCPcount_num.ReadOnly = True
        Me.txtCPcount_num.Size = New System.Drawing.Size(296, 29)
        Me.txtCPcount_num.TabIndex = 160
        Me.txtCPcount_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(407, 5)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 161
        Me.Label11.Text = "คงเหลือ"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(102, 104)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(470, 38)
        Me.txtPrice.TabIndex = 164
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 39)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "ราคา"
        '
        'rsScost
        '
        Me.rsScost.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rsScost.AutoSize = True
        Me.rsScost.Location = New System.Drawing.Point(532, 51)
        Me.rsScost.Name = "rsScost"
        Me.rsScost.Size = New System.Drawing.Size(40, 17)
        Me.rsScost.TabIndex = 166
        Me.rsScost.Text = "ทุน"
        Me.rsScost.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(224, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 28)
        Me.Button1.TabIndex = 168
        Me.Button1.Text = "ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.ListView1)
        Me.Panel1.Location = New System.Drawing.Point(0, 148)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(290, 288)
        Me.Panel1.TabIndex = 167
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(290, 288)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'txtSproDetail
        '
        Me.txtSproDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSproDetail.Location = New System.Drawing.Point(296, 148)
        Me.txtSproDetail.Multiline = True
        Me.txtSproDetail.Name = "txtSproDetail"
        Me.txtSproDetail.ReadOnly = True
        Me.txtSproDetail.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtSproDetail.Size = New System.Drawing.Size(277, 140)
        Me.txtSproDetail.TabIndex = 162
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(296, 307)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(277, 129)
        Me.RichTextBox1.TabIndex = 169
        Me.RichTextBox1.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(296, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 170
        Me.Label5.Text = "Specification"
        '
        'CheckPriceFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.rsScost)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtSproDetail)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtCPcount_num)
        Me.Controls.Add(Me.rbStechnician)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbSwholesale)
        Me.Controls.Add(Me.rbSloyal)
        Me.Controls.Add(Me.rbSbuy)
        Me.Controls.Add(Me.rbSmembers)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtCPnamePro)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCPsnANDbarcode)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CheckPriceFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ตรวจสอบราคาสินค้า"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCPsnANDbarcode As System.Windows.Forms.TextBox
    Friend WithEvents txtCPnamePro As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblemployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbStechnician As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbSwholesale As System.Windows.Forms.RadioButton
    Friend WithEvents rbSloyal As System.Windows.Forms.RadioButton
    Friend WithEvents rbSbuy As System.Windows.Forms.RadioButton
    Friend WithEvents rbSmembers As System.Windows.Forms.RadioButton
    Friend WithEvents txtCPcount_num As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rsScost As System.Windows.Forms.RadioButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents txtSproDetail As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
