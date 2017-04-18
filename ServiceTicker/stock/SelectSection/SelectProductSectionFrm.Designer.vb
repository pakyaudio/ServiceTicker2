<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectProductSectionFrm
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
        Me.lblPSname = New System.Windows.Forms.Label()
        Me.txtPSName = New System.Windows.Forms.TextBox()
        Me.btnPSadd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPSname
        '
        Me.lblPSname.AutoSize = True
        Me.lblPSname.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblPSname.Location = New System.Drawing.Point(12, 7)
        Me.lblPSname.Name = "lblPSname"
        Me.lblPSname.Size = New System.Drawing.Size(83, 13)
        Me.lblPSname.TabIndex = 27
        Me.lblPSname.Text = "ชื่อประเภทสินค้า"
        '
        'txtPSName
        '
        Me.txtPSName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPSName.Location = New System.Drawing.Point(12, 23)
        Me.txtPSName.Name = "txtPSName"
        Me.txtPSName.Size = New System.Drawing.Size(240, 24)
        Me.txtPSName.TabIndex = 25
        '
        'btnPSadd
        '
        Me.btnPSadd.Enabled = False
        Me.btnPSadd.Location = New System.Drawing.Point(258, 23)
        Me.btnPSadd.Name = "btnPSadd"
        Me.btnPSadd.Size = New System.Drawing.Size(75, 23)
        Me.btnPSadd.TabIndex = 29
        Me.btnPSadd.Text = "บันทึก"
        Me.btnPSadd.UseVisualStyleBackColor = True
        '
        'SelectProductSectionFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 54)
        Me.Controls.Add(Me.btnPSadd)
        Me.Controls.Add(Me.lblPSname)
        Me.Controls.Add(Me.txtPSName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectProductSectionFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPSname As System.Windows.Forms.Label
    Friend WithEvents txtPSName As System.Windows.Forms.TextBox
    Friend WithEvents btnPSadd As System.Windows.Forms.Button
End Class
