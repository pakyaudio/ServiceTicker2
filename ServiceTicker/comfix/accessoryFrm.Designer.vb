<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accessoryFrm
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgAccessory = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.accessory_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAccessoryClose = New System.Windows.Forms.Button()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgAccessory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgAccessory)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnAccessoryClose)
        Me.SplitContainer1.Size = New System.Drawing.Size(225, 302)
        Me.SplitContainer1.SplitterDistance = 270
        Me.SplitContainer1.TabIndex = 0
        '
        'dgAccessory
        '
        Me.dgAccessory.AllowUserToAddRows = False
        Me.dgAccessory.AllowUserToDeleteRows = False
        Me.dgAccessory.AllowUserToOrderColumns = True
        Me.dgAccessory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgAccessory.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgAccessory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAccessory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.accessory_name})
        Me.dgAccessory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgAccessory.Location = New System.Drawing.Point(0, 0)
        Me.dgAccessory.Name = "dgAccessory"
        Me.dgAccessory.ReadOnly = True
        Me.dgAccessory.RowHeadersVisible = False
        Me.dgAccessory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgAccessory.Size = New System.Drawing.Size(225, 270)
        Me.dgAccessory.TabIndex = 19
        '
        'no
        '
        Me.no.DataPropertyName = "no"
        Me.no.FillWeight = 30.45685!
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.ToolTipText = "อันดับ"
        '
        'accessory_name
        '
        Me.accessory_name.DataPropertyName = "accessory_name"
        Me.accessory_name.FillWeight = 169.5432!
        Me.accessory_name.HeaderText = "อุปกรณ์ที่นำมาด้วย"
        Me.accessory_name.Name = "accessory_name"
        Me.accessory_name.ReadOnly = True
        Me.accessory_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.accessory_name.ToolTipText = "อุปกรณ์ที่นำมาด้วย"
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
        Me.btnAccessoryClose.Location = New System.Drawing.Point(147, 3)
        Me.btnAccessoryClose.Name = "btnAccessoryClose"
        Me.btnAccessoryClose.Size = New System.Drawing.Size(75, 23)
        Me.btnAccessoryClose.TabIndex = 20
        Me.btnAccessoryClose.Text = "ปิด"
        Me.btnAccessoryClose.UseVisualStyleBackColor = True
        '
        'accessoryFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(225, 302)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "accessoryFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "อุปกรณ์ที่นำมาด้วย"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgAccessory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgAccessory As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents accessory_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAccessoryClose As System.Windows.Forms.Button
End Class
