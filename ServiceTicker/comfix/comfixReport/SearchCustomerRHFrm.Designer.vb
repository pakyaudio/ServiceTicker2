<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchCustomerRHFrm
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
        Me.btnsearchShowAll = New System.Windows.Forms.Button()
        Me.txtSearchCus = New System.Windows.Forms.TextBox()
        Me.btnsearchCusSearch = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSendtoSavedatafix = New System.Windows.Forms.Button()
        Me.txtSearchCusShowTel = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgSearchCustoSaveFix = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgSearchCustoSaveFix, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnsearchShowAll)
        Me.Panel1.Controls.Add(Me.txtSearchCus)
        Me.Panel1.Controls.Add(Me.btnsearchCusSearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(546, 31)
        Me.Panel1.TabIndex = 0
        '
        'btnsearchShowAll
        '
        Me.btnsearchShowAll.Location = New System.Drawing.Point(459, 3)
        Me.btnsearchShowAll.Name = "btnsearchShowAll"
        Me.btnsearchShowAll.Size = New System.Drawing.Size(75, 23)
        Me.btnsearchShowAll.TabIndex = 14
        Me.btnsearchShowAll.Text = "แสดงทั้งหมด"
        Me.btnsearchShowAll.UseVisualStyleBackColor = True
        '
        'txtSearchCus
        '
        Me.txtSearchCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSearchCus.Location = New System.Drawing.Point(12, 3)
        Me.txtSearchCus.Name = "txtSearchCus"
        Me.txtSearchCus.Size = New System.Drawing.Size(365, 22)
        Me.txtSearchCus.TabIndex = 13
        '
        'btnsearchCusSearch
        '
        Me.btnsearchCusSearch.Location = New System.Drawing.Point(383, 3)
        Me.btnsearchCusSearch.Name = "btnsearchCusSearch"
        Me.btnsearchCusSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearchCusSearch.TabIndex = 12
        Me.btnsearchCusSearch.Text = "ค้นหา"
        Me.btnsearchCusSearch.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnSendtoSavedatafix)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 501)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(546, 60)
        Me.Panel2.TabIndex = 1
        '
        'btnSendtoSavedatafix
        '
        Me.btnSendtoSavedatafix.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSendtoSavedatafix.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSendtoSavedatafix.ForeColor = System.Drawing.Color.Maroon
        Me.btnSendtoSavedatafix.Location = New System.Drawing.Point(0, 0)
        Me.btnSendtoSavedatafix.Name = "btnSendtoSavedatafix"
        Me.btnSendtoSavedatafix.Size = New System.Drawing.Size(546, 60)
        Me.btnSendtoSavedatafix.TabIndex = 12
        Me.btnSendtoSavedatafix.Text = "เลือกไปหน้าค้นหาประวัติงานซ่อม"
        Me.btnSendtoSavedatafix.UseVisualStyleBackColor = True
        '
        'txtSearchCusShowTel
        '
        Me.txtSearchCusShowTel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearchCusShowTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSearchCusShowTel.ForeColor = System.Drawing.Color.Red
        Me.txtSearchCusShowTel.Location = New System.Drawing.Point(0, 0)
        Me.txtSearchCusShowTel.Name = "txtSearchCusShowTel"
        Me.txtSearchCusShowTel.Size = New System.Drawing.Size(546, 31)
        Me.txtSearchCusShowTel.TabIndex = 11
        Me.txtSearchCusShowTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtSearchCusShowTel)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 466)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(546, 35)
        Me.Panel3.TabIndex = 12
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dgSearchCustoSaveFix)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 31)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(546, 435)
        Me.Panel4.TabIndex = 13
        '
        'dgSearchCustoSaveFix
        '
        Me.dgSearchCustoSaveFix.AllowUserToAddRows = False
        Me.dgSearchCustoSaveFix.AllowUserToDeleteRows = False
        Me.dgSearchCustoSaveFix.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgSearchCustoSaveFix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSearchCustoSaveFix.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSearchCustoSaveFix.Location = New System.Drawing.Point(0, 0)
        Me.dgSearchCustoSaveFix.MultiSelect = False
        Me.dgSearchCustoSaveFix.Name = "dgSearchCustoSaveFix"
        Me.dgSearchCustoSaveFix.ReadOnly = True
        Me.dgSearchCustoSaveFix.RowHeadersVisible = False
        Me.dgSearchCustoSaveFix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSearchCustoSaveFix.Size = New System.Drawing.Size(546, 435)
        Me.dgSearchCustoSaveFix.TabIndex = 9
        '
        'SearchCustomerRHFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 561)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SearchCustomerRHFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ค้นหาลูกค้า"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgSearchCustoSaveFix, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnsearchShowAll As System.Windows.Forms.Button
    Friend WithEvents txtSearchCus As System.Windows.Forms.TextBox
    Friend WithEvents btnsearchCusSearch As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSendtoSavedatafix As System.Windows.Forms.Button
    Friend WithEvents txtSearchCusShowTel As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents dgSearchCustoSaveFix As System.Windows.Forms.DataGridView
End Class
