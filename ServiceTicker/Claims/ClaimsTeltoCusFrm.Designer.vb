<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimsTeltoCusFrm
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
        Me.lblCTCclaims_id = New System.Windows.Forms.Label()
        Me.btnCTCsave = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblCTCteltocus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCTCclaims_id
        '
        Me.lblCTCclaims_id.AutoSize = True
        Me.lblCTCclaims_id.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblCTCclaims_id.Location = New System.Drawing.Point(11, 48)
        Me.lblCTCclaims_id.Name = "lblCTCclaims_id"
        Me.lblCTCclaims_id.Size = New System.Drawing.Size(47, 13)
        Me.lblCTCclaims_id.TabIndex = 11
        Me.lblCTCclaims_id.Text = "claims id"
        '
        'btnCTCsave
        '
        Me.btnCTCsave.Location = New System.Drawing.Point(195, 22)
        Me.btnCTCsave.Name = "btnCTCsave"
        Me.btnCTCsave.Size = New System.Drawing.Size(75, 23)
        Me.btnCTCsave.TabIndex = 10
        Me.btnCTCsave.Text = "บันทึก"
        Me.btnCTCsave.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ยังไม่ได้แจ้ง", "แจ้งแล้ว"})
        Me.ComboBox1.Location = New System.Drawing.Point(14, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(175, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'lblCTCteltocus
        '
        Me.lblCTCteltocus.AutoSize = True
        Me.lblCTCteltocus.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblCTCteltocus.Location = New System.Drawing.Point(11, 8)
        Me.lblCTCteltocus.Name = "lblCTCteltocus"
        Me.lblCTCteltocus.Size = New System.Drawing.Size(49, 13)
        Me.lblCTCteltocus.TabIndex = 8
        Me.lblCTCteltocus.Text = "เบอร์โทร"
        '
        'ClaimsTeltoCusFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.ClientSize = New System.Drawing.Size(281, 69)
        Me.Controls.Add(Me.lblCTCclaims_id)
        Me.Controls.Add(Me.btnCTCsave)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblCTCteltocus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ClaimsTeltoCusFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "แก้ไขการโทรแจ้งลูกค้า"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCTCclaims_id As System.Windows.Forms.Label
    Friend WithEvents btnCTCsave As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblCTCteltocus As System.Windows.Forms.Label
End Class
