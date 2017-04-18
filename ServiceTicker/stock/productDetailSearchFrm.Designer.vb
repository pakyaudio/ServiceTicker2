<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productDetailSearchFrm
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
        Me.btnPDSsearchByUpdate = New System.Windows.Forms.Button()
        Me.btnPDSsearchByProME = New System.Windows.Forms.Button()
        Me.btnPDSsearchByProNoME = New System.Windows.Forms.Button()
        Me.btnPDSsearch = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnPDSsearchByUpdate)
        Me.Panel1.Controls.Add(Me.btnPDSsearchByProME)
        Me.Panel1.Controls.Add(Me.btnPDSsearchByProNoME)
        Me.Panel1.Controls.Add(Me.btnPDSsearch)
        Me.Panel1.Controls.Add(Me.txtsearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(497, 57)
        Me.Panel1.TabIndex = 0
        '
        'btnPDSsearchByUpdate
        '
        Me.btnPDSsearchByUpdate.Location = New System.Drawing.Point(335, 29)
        Me.btnPDSsearchByUpdate.Name = "btnPDSsearchByUpdate"
        Me.btnPDSsearchByUpdate.Size = New System.Drawing.Size(160, 23)
        Me.btnPDSsearchByUpdate.TabIndex = 4
        Me.btnPDSsearchByUpdate.Text = "แสดงสินค้าที่ปรับปรุงวันนี้"
        Me.btnPDSsearchByUpdate.UseVisualStyleBackColor = True
        '
        'btnPDSsearchByProME
        '
        Me.btnPDSsearchByProME.Location = New System.Drawing.Point(169, 29)
        Me.btnPDSsearchByProME.Name = "btnPDSsearchByProME"
        Me.btnPDSsearchByProME.Size = New System.Drawing.Size(160, 23)
        Me.btnPDSsearchByProME.TabIndex = 3
        Me.btnPDSsearchByProME.Text = "แสดงสินค้าที่มีในสต็อก"
        Me.btnPDSsearchByProME.UseVisualStyleBackColor = True
        '
        'btnPDSsearchByProNoME
        '
        Me.btnPDSsearchByProNoME.Location = New System.Drawing.Point(3, 29)
        Me.btnPDSsearchByProNoME.Name = "btnPDSsearchByProNoME"
        Me.btnPDSsearchByProNoME.Size = New System.Drawing.Size(160, 23)
        Me.btnPDSsearchByProNoME.TabIndex = 2
        Me.btnPDSsearchByProNoME.Text = "แสดงสินค้าที่หมด"
        Me.btnPDSsearchByProNoME.UseVisualStyleBackColor = True
        '
        'btnPDSsearch
        '
        Me.btnPDSsearch.Location = New System.Drawing.Point(420, 1)
        Me.btnPDSsearch.Name = "btnPDSsearch"
        Me.btnPDSsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnPDSsearch.TabIndex = 1
        Me.btnPDSsearch.Text = "ค้นหา"
        Me.btnPDSsearch.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(3, 3)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(411, 20)
        Me.txtsearch.TabIndex = 0
        '
        'productDetailSearchFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 57)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "productDetailSearchFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ค้นหาสินค้า"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPDSsearchByUpdate As System.Windows.Forms.Button
    Friend WithEvents btnPDSsearchByProME As System.Windows.Forms.Button
    Friend WithEvents btnPDSsearchByProNoME As System.Windows.Forms.Button
    Friend WithEvents btnPDSsearch As System.Windows.Forms.Button
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
End Class
