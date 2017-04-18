<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductSectionFrm
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
        Me.lblPSid = New System.Windows.Forms.Label()
        Me.lblPSname = New System.Windows.Forms.Label()
        Me.txtPSid = New System.Windows.Forms.TextBox()
        Me.txtPSName = New System.Windows.Forms.TextBox()
        Me.btnPSadd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPSid
        '
        Me.lblPSid.AutoSize = True
        Me.lblPSid.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblPSid.Location = New System.Drawing.Point(3, 7)
        Me.lblPSid.Name = "lblPSid"
        Me.lblPSid.Size = New System.Drawing.Size(26, 13)
        Me.lblPSid.TabIndex = 28
        Me.lblPSid.Text = "รหัส"
        '
        'lblPSname
        '
        Me.lblPSname.AutoSize = True
        Me.lblPSname.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblPSname.Location = New System.Drawing.Point(199, 7)
        Me.lblPSname.Name = "lblPSname"
        Me.lblPSname.Size = New System.Drawing.Size(83, 13)
        Me.lblPSname.TabIndex = 27
        Me.lblPSname.Text = "ชื่อประเภทสินค้า"
        '
        'txtPSid
        '
        Me.txtPSid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPSid.Location = New System.Drawing.Point(6, 23)
        Me.txtPSid.Name = "txtPSid"
        Me.txtPSid.Size = New System.Drawing.Size(190, 24)
        Me.txtPSid.TabIndex = 26
        '
        'txtPSName
        '
        Me.txtPSName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPSName.Location = New System.Drawing.Point(202, 23)
        Me.txtPSName.Name = "txtPSName"
        Me.txtPSName.Size = New System.Drawing.Size(213, 24)
        Me.txtPSName.TabIndex = 25
        '
        'btnPSadd
        '
        Me.btnPSadd.Enabled = False
        Me.btnPSadd.Location = New System.Drawing.Point(421, 23)
        Me.btnPSadd.Name = "btnPSadd"
        Me.btnPSadd.Size = New System.Drawing.Size(75, 23)
        Me.btnPSadd.TabIndex = 29
        Me.btnPSadd.Text = "บันทึก"
        Me.btnPSadd.UseVisualStyleBackColor = True
        '
        'ProductSectionFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 54)
        Me.Controls.Add(Me.btnPSadd)
        Me.Controls.Add(Me.lblPSid)
        Me.Controls.Add(Me.lblPSname)
        Me.Controls.Add(Me.txtPSid)
        Me.Controls.Add(Me.txtPSName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProductSectionFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPSid As System.Windows.Forms.Label
    Friend WithEvents lblPSname As System.Windows.Forms.Label
    Friend WithEvents txtPSid As System.Windows.Forms.TextBox
    Friend WithEvents txtPSName As System.Windows.Forms.TextBox
    Friend WithEvents btnPSadd As System.Windows.Forms.Button
End Class
