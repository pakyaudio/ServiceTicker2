<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DocmanEditFrm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEx = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cbbNumTotal = New System.Windows.Forms.ComboBox()
        Me.txtdat = New System.Windows.Forms.TextBox()
        Me.cbbFormat = New System.Windows.Forms.ComboBox()
        Me.txtNameDoc = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.cbby_reset = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbby_reset)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtEx)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.cbbNumTotal)
        Me.Panel1.Controls.Add(Me.txtdat)
        Me.Panel1.Controls.Add(Me.cbbFormat)
        Me.Panel1.Controls.Add(Me.txtNameDoc)
        Me.Panel1.Controls.Add(Me.txtFname)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 66)
        Me.Panel1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(394, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "ตัวอย่าง"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(432, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "จำนวนเลขอัตโนมัติ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(305, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "รูปแบบ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "ชื่อเอกสาร"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "รหัสนำหน้า"
        '
        'txtEx
        '
        Me.txtEx.Location = New System.Drawing.Point(52, 42)
        Me.txtEx.Name = "txtEx"
        Me.txtEx.Size = New System.Drawing.Size(336, 20)
        Me.txtEx.TabIndex = 7
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(672, 14)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cbbNumTotal
        '
        Me.cbbNumTotal.FormattingEnabled = True
        Me.cbbNumTotal.Location = New System.Drawing.Point(418, 16)
        Me.cbbNumTotal.Name = "cbbNumTotal"
        Me.cbbNumTotal.Size = New System.Drawing.Size(121, 21)
        Me.cbbNumTotal.TabIndex = 5
        '
        'txtdat
        '
        Me.txtdat.Location = New System.Drawing.Point(394, 16)
        Me.txtdat.MaxLength = 4
        Me.txtdat.Name = "txtdat"
        Me.txtdat.Size = New System.Drawing.Size(18, 20)
        Me.txtdat.TabIndex = 4
        Me.txtdat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbbFormat
        '
        Me.cbbFormat.FormattingEnabled = True
        Me.cbbFormat.Location = New System.Drawing.Point(267, 16)
        Me.cbbFormat.Name = "cbbFormat"
        Me.cbbFormat.Size = New System.Drawing.Size(121, 21)
        Me.cbbFormat.TabIndex = 3
        '
        'txtNameDoc
        '
        Me.txtNameDoc.Location = New System.Drawing.Point(6, 16)
        Me.txtNameDoc.Name = "txtNameDoc"
        Me.txtNameDoc.ReadOnly = True
        Me.txtNameDoc.Size = New System.Drawing.Size(173, 20)
        Me.txtNameDoc.TabIndex = 2
        '
        'txtFname
        '
        Me.txtFname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFname.Location = New System.Drawing.Point(185, 16)
        Me.txtFname.MaxLength = 5
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(76, 20)
        Me.txtFname.TabIndex = 1
        Me.txtFname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbby_reset
        '
        Me.cbby_reset.FormattingEnabled = True
        Me.cbby_reset.Location = New System.Drawing.Point(545, 16)
        Me.cbby_reset.Name = "cbby_reset"
        Me.cbby_reset.Size = New System.Drawing.Size(121, 21)
        Me.cbby_reset.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(556, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "รีเซ็ตเลขบิลเมื่อสิ้นปี"
        '
        'DocmanEditFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 66)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DocmanEditFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "แก้ไขรหัสเอกสาร"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEx As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cbbNumTotal As System.Windows.Forms.ComboBox
    Friend WithEvents txtdat As System.Windows.Forms.TextBox
    Friend WithEvents cbbFormat As System.Windows.Forms.ComboBox
    Friend WithEvents txtNameDoc As System.Windows.Forms.TextBox
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbby_reset As System.Windows.Forms.ComboBox
End Class
