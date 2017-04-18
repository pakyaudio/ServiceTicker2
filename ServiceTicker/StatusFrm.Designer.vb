<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatusFrm
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
        Me.txtSatus = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtSatus
        '
        Me.txtSatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSatus.Location = New System.Drawing.Point(0, 0)
        Me.txtSatus.MaxLength = 327670000
        Me.txtSatus.Multiline = True
        Me.txtSatus.Name = "txtSatus"
        Me.txtSatus.ReadOnly = True
        Me.txtSatus.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtSatus.Size = New System.Drawing.Size(704, 261)
        Me.txtSatus.TabIndex = 0
        '
        'StatusFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 261)
        Me.Controls.Add(Me.txtSatus)
        Me.Name = "StatusFrm"
        Me.Text = "บันทึกข้อผิดพลาด"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSatus As System.Windows.Forms.TextBox
End Class
