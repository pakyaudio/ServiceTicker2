<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MiniReturnProductFrm
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
        Me.btnMRPcancel = New System.Windows.Forms.Button()
        Me.btnMRPok = New System.Windows.Forms.Button()
        Me.txtMRPnumpro1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMRPnumPro = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnMRPcancel
        '
        Me.btnMRPcancel.Location = New System.Drawing.Point(112, 136)
        Me.btnMRPcancel.Name = "btnMRPcancel"
        Me.btnMRPcancel.Size = New System.Drawing.Size(70, 23)
        Me.btnMRPcancel.TabIndex = 9
        Me.btnMRPcancel.TabStop = False
        Me.btnMRPcancel.Text = "ยกเลิก"
        Me.btnMRPcancel.UseVisualStyleBackColor = True
        '
        'btnMRPok
        '
        Me.btnMRPok.Location = New System.Drawing.Point(13, 137)
        Me.btnMRPok.Name = "btnMRPok"
        Me.btnMRPok.Size = New System.Drawing.Size(93, 23)
        Me.btnMRPok.TabIndex = 8
        Me.btnMRPok.TabStop = False
        Me.btnMRPok.Text = "ตกลง"
        Me.btnMRPok.UseVisualStyleBackColor = True
        '
        'txtMRPnumpro1
        '
        Me.txtMRPnumpro1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtMRPnumpro1.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtMRPnumpro1.Location = New System.Drawing.Point(12, 50)
        Me.txtMRPnumpro1.Name = "txtMRPnumpro1"
        Me.txtMRPnumpro1.Size = New System.Drawing.Size(170, 80)
        Me.txtMRPnumpro1.TabIndex = 0
        Me.txtMRPnumpro1.Text = "0"
        Me.txtMRPnumpro1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(48, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "จำนวนที่ต้องการคืน"
        '
        'txtMRPnumPro
        '
        Me.txtMRPnumPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtMRPnumPro.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtMRPnumPro.Location = New System.Drawing.Point(12, 9)
        Me.txtMRPnumPro.Name = "txtMRPnumPro"
        Me.txtMRPnumPro.Size = New System.Drawing.Size(170, 22)
        Me.txtMRPnumPro.TabIndex = 5
        Me.txtMRPnumPro.TabStop = False
        Me.txtMRPnumPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MiniReturnProductFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(194, 168)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnMRPcancel)
        Me.Controls.Add(Me.btnMRPok)
        Me.Controls.Add(Me.txtMRPnumpro1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMRPnumPro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MiniReturnProductFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบุจำนวนที่คืน"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMRPcancel As System.Windows.Forms.Button
    Friend WithEvents btnMRPok As System.Windows.Forms.Button
    Friend WithEvents txtMRPnumpro1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMRPnumPro As System.Windows.Forms.TextBox
End Class
