<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accessoryClaimsFrm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAccessoryClose = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgAccessory = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.accessory_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgAccessory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnAccessoryClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 232)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(207, 29)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "ดับเบิ๊ลคลิ๊กเพื่อเลือก"
        '
        'btnAccessoryClose
        '
        Me.btnAccessoryClose.Location = New System.Drawing.Point(129, 3)
        Me.btnAccessoryClose.Name = "btnAccessoryClose"
        Me.btnAccessoryClose.Size = New System.Drawing.Size(75, 23)
        Me.btnAccessoryClose.TabIndex = 20
        Me.btnAccessoryClose.Text = "ปิด"
        Me.btnAccessoryClose.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgAccessory)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(207, 232)
        Me.Panel2.TabIndex = 1
        '
        'dgAccessory
        '
        Me.dgAccessory.AllowUserToAddRows = False
        Me.dgAccessory.AllowUserToDeleteRows = False
        Me.dgAccessory.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgAccessory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAccessory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.accessory_name})
        Me.dgAccessory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgAccessory.Location = New System.Drawing.Point(0, 0)
        Me.dgAccessory.MultiSelect = False
        Me.dgAccessory.Name = "dgAccessory"
        Me.dgAccessory.ReadOnly = True
        Me.dgAccessory.RowHeadersVisible = False
        Me.dgAccessory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgAccessory.Size = New System.Drawing.Size(207, 232)
        Me.dgAccessory.TabIndex = 19
        '
        'no
        '
        Me.no.DataPropertyName = "no"
        Me.no.Frozen = True
        Me.no.HeaderText = "#"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.ToolTipText = "อันดับ"
        Me.no.Width = 30
        '
        'accessory_name
        '
        Me.accessory_name.DataPropertyName = "accessory_name"
        Me.accessory_name.HeaderText = "อุปกรณ์ที่นำมาด้วย"
        Me.accessory_name.Name = "accessory_name"
        Me.accessory_name.ReadOnly = True
        Me.accessory_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.accessory_name.ToolTipText = "อุปกรณ์ที่นำมาด้วย"
        Me.accessory_name.Width = 150
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'accessoryClaimsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(207, 261)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "accessoryClaimsFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "อุปกรณ์ที่นำมาด้วย"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgAccessory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAccessoryClose As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgAccessory As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents accessory_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
