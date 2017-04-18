<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnClaimsFrm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRCclaimsID = New System.Windows.Forms.TextBox()
        Me.lblRCtel_to_cus = New System.Windows.Forms.Label()
        Me.cbbRCtel_to_cus = New System.Windows.Forms.ComboBox()
        Me.btnRCtelCUS = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRCnote = New System.Windows.Forms.TextBox()
        Me.lblRCtel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRCclaims_money = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRCaccessory = New System.Windows.Forms.TextBox()
        Me.btnRCsave = New System.Windows.Forms.Button()
        Me.btnRCcencel = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 130)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnRCsave)
        Me.Panel1.Controls.Add(Me.btnRCcencel)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtRCaccessory)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtRCclaims_money)
        Me.Panel1.Controls.Add(Me.lblRCtel)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtRCnote)
        Me.Panel1.Controls.Add(Me.btnRCtelCUS)
        Me.Panel1.Controls.Add(Me.lblRCtel_to_cus)
        Me.Panel1.Controls.Add(Me.cbbRCtel_to_cus)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtRCclaimsID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 130)
        Me.Panel1.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(198, 22)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(195, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "วันที่ส่งกลับ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "รหัสงานเคลม"
        '
        'txtRCclaimsID
        '
        Me.txtRCclaimsID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRCclaimsID.Location = New System.Drawing.Point(12, 20)
        Me.txtRCclaimsID.Name = "txtRCclaimsID"
        Me.txtRCclaimsID.ReadOnly = True
        Me.txtRCclaimsID.Size = New System.Drawing.Size(177, 22)
        Me.txtRCclaimsID.TabIndex = 4
        '
        'lblRCtel_to_cus
        '
        Me.lblRCtel_to_cus.AutoSize = True
        Me.lblRCtel_to_cus.Location = New System.Drawing.Point(404, 5)
        Me.lblRCtel_to_cus.Name = "lblRCtel_to_cus"
        Me.lblRCtel_to_cus.Size = New System.Drawing.Size(69, 13)
        Me.lblRCtel_to_cus.TabIndex = 15
        Me.lblRCtel_to_cus.Text = "การแจ้งลูกค้า"
        '
        'cbbRCtel_to_cus
        '
        Me.cbbRCtel_to_cus.FormattingEnabled = True
        Me.cbbRCtel_to_cus.Location = New System.Drawing.Point(404, 21)
        Me.cbbRCtel_to_cus.Name = "cbbRCtel_to_cus"
        Me.cbbRCtel_to_cus.Size = New System.Drawing.Size(248, 21)
        Me.cbbRCtel_to_cus.TabIndex = 14
        '
        'btnRCtelCUS
        '
        Me.btnRCtelCUS.Location = New System.Drawing.Point(658, 19)
        Me.btnRCtelCUS.Name = "btnRCtelCUS"
        Me.btnRCtelCUS.Size = New System.Drawing.Size(122, 24)
        Me.btnRCtelCUS.TabIndex = 16
        Me.btnRCtelCUS.Text = "ดูเบอร์โทรศัพท์ลูกค้า"
        Me.btnRCtelCUS.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(258, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "การซ่อมแซมแก้ไขจากทางบริษัท(ถ้ามี หากไม่มีให้ - ไว้)"
        '
        'txtRCnote
        '
        Me.txtRCnote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRCnote.Location = New System.Drawing.Point(11, 61)
        Me.txtRCnote.Name = "txtRCnote"
        Me.txtRCnote.Size = New System.Drawing.Size(769, 22)
        Me.txtRCnote.TabIndex = 17
        '
        'lblRCtel
        '
        Me.lblRCtel.AutoSize = True
        Me.lblRCtel.Location = New System.Drawing.Point(404, 45)
        Me.lblRCtel.Name = "lblRCtel"
        Me.lblRCtel.Size = New System.Drawing.Size(36, 13)
        Me.lblRCtel.TabIndex = 19
        Me.lblRCtel.Text = "TEL : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "ค่าใช้จ่ายในการเคลม (ถ้ามี)"
        '
        'txtRCclaims_money
        '
        Me.txtRCclaims_money.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRCclaims_money.Location = New System.Drawing.Point(12, 102)
        Me.txtRCclaims_money.Name = "txtRCclaims_money"
        Me.txtRCclaims_money.Size = New System.Drawing.Size(132, 22)
        Me.txtRCclaims_money.TabIndex = 20
        Me.txtRCclaims_money.Text = "0"
        Me.txtRCclaims_money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(150, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(329, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "อุปกรณ์ที่นำมาด้วย (กรุณาเช็คอุปกรณ์ที่ลูกค้านำติดมาด้วยให้ครบถ้วน)"
        '
        'txtRCaccessory
        '
        Me.txtRCaccessory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRCaccessory.Location = New System.Drawing.Point(150, 102)
        Me.txtRCaccessory.Name = "txtRCaccessory"
        Me.txtRCaccessory.ReadOnly = True
        Me.txtRCaccessory.Size = New System.Drawing.Size(403, 22)
        Me.txtRCaccessory.TabIndex = 22
        '
        'btnRCsave
        '
        Me.btnRCsave.Location = New System.Drawing.Point(559, 101)
        Me.btnRCsave.Name = "btnRCsave"
        Me.btnRCsave.Size = New System.Drawing.Size(141, 23)
        Me.btnRCsave.TabIndex = 25
        Me.btnRCsave.Text = "บันทึกส่งกลับงานเคลม"
        Me.btnRCsave.UseVisualStyleBackColor = True
        '
        'btnRCcencel
        '
        Me.btnRCcencel.Location = New System.Drawing.Point(706, 101)
        Me.btnRCcencel.Name = "btnRCcencel"
        Me.btnRCcencel.Size = New System.Drawing.Size(75, 23)
        Me.btnRCcencel.TabIndex = 24
        Me.btnRCcencel.Text = "ยกเลิก"
        Me.btnRCcencel.UseVisualStyleBackColor = True
        '
        'ReturnClaimsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 152)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReturnClaimsFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ส่งกลับงานเคลม"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblEmployee As ToolStripStatusLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRCsave As Button
    Friend WithEvents btnRCcencel As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRCaccessory As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRCclaims_money As TextBox
    Friend WithEvents lblRCtel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRCnote As TextBox
    Friend WithEvents btnRCtelCUS As Button
    Friend WithEvents lblRCtel_to_cus As Label
    Friend WithEvents cbbRCtel_to_cus As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRCclaimsID As TextBox
End Class
