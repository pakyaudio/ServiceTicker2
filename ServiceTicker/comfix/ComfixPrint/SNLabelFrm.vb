Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Text
Imports System.Threading

Public Class SNLabelFrm
    Private Sub rbCheck()
        If rbOneNum.Checked = True Then
            Me.NumericUpDown1.Enabled = True
            Me.txtOneNum.Clear()
            Me.txtOneNum.Enabled = True
        Else
            Me.txtOneNum.Clear()
            Me.txtOneNum.Enabled = False
        End If

        If rbCount.Checked = True Then
            Me.NumericUpDown1.Enabled = False
            Me.txtCountStart.Enabled = True
            Me.txtCountEnd.Enabled = True
        Else
            Me.NumericUpDown1.Enabled = True
            Me.txtCountStart.Enabled = False
            Me.txtCountEnd.Enabled = False
        End If

        If rbRanDom.Checked = True Then
            Me.NumericUpDown1.Enabled = True
            Me.cbbRandom.Enabled = True
            Me.NumericUpDown2.Enabled = True
        Else
            Me.cbbRandom.Enabled = False
            Me.NumericUpDown2.Enabled = False
        End If
    End Sub
    Dim snum As String = "123456789" & _
                            "123456789" & _
                            "123456789" & _
                            "123456789" & _
                            "123456789"

    Dim stext As String = "ABCDEFGHIJKLMNPQRSTUVWXYZ" & _
                            "ABCDEFGHIJKLMNPQRSTUVWXYZ" & _
                            "ABCDEFGHIJKLMNPQRSTUVWXYZ" & _
                            "ABCDEFGHIJKLMNPQRSTUVWXYZ" & _
                            "ABCDEFGHIJKLMNPQRSTUVWXYZ"
    Private Function snRnd(ByVal s As String, ByVal n As Integer)
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To n
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function

    Private Sub rbCount_CheckedChanged(sender As Object,
                                         e As EventArgs) Handles rbCount.CheckedChanged, rbOneNum.CheckedChanged, rbRanDom.CheckedChanged
        Call rbCheck()
    End Sub

    Private Sub cbbRandom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbRandom.KeyPress
        e.Handled = True
    End Sub

    Private Sub SNLabelFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub SNLabelFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
        Me.cbbRandom.Items.Clear()
        Me.cbbRandom.Items.Add("ตัวเลขและตัวอักษร")
        Me.cbbRandom.Items.Add("ตัวเลข")
        Me.cbbRandom.Items.Add("ตัวอักษร")
        Me.cbbRandom.SelectedIndex = 0
        Try
            dt = New DataTable
            dtAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT com_name FROM company;", ConnectionDB)
            Call open_connection()
            dtAdapter.Fill(dt)
            Me.TextBox1.Text = dt(0)("com_name")
            dt.Dispose()
        Catch ex As Exception

        End Try


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.SnLabelDataSet1.textLabel.Rows.Clear()
        Me.SnLabelDataSet1.textLabel.Rows.Add(Me.TextBox1.Text)
        'Dim tempnewid As Integer = Me.Sn_idTableAdapter1.ScalarQuery()
        Me.SnLabelDataSet1.snlable_id.Rows.Clear()
        If rbOneNum.Checked = True Then
            For r As Integer = 0 To Me.NumericUpDown1.Value - 1
                Dim newrowsss As snLabelDataSet.snlable_idRow
                newrowsss = SnLabelDataSet1.snlable_id.NewRow
                newrowsss.num_sn = Me.txtFrontNum.Text & Me.txtOneNum.Text
                Me.SnLabelDataSet1.snlable_id.Rows.Add(newrowsss)
            Next
        ElseIf rbCount.Checked = True Then
            If Me.txtCountStart.Text = Nothing And Me.txtCountEnd.Text = Nothing Then
                MessageBox.Show(Me, "กรุณาป้อนค่าตัวเลขเริ่มต้นและสิ้นสุดในช่องด้วย",
                                "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If CInt(Me.txtCountStart.Text) > CInt(Me.txtCountEnd.Text) Then
                MessageBox.Show(Me, "ตัวเลขในช่องเริ่มมีค่ามากกว่าช่องถึง" & vbNewLine & "กรุณาใส่ค่าช่องตัวเลขเริ่มต้น ให้มีค่าน้อยกว่าค่า สิ้นสุด",
                                "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Dim ccc As Integer = CInt(Me.txtCountEnd.Text) - CInt(Me.txtCountStart.Text)
                If ccc > 10000 Then
                    MessageBox.Show(Me, "สร้างป้ายแยะเกินไปแล้วแก ! ขนาดเกินหมื่น มันใช้เวลานานนะ",
                                  "สร้างทีล่ะนิด ทีละหน่อยนะ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                Dim num_start As Integer = Me.txtCountStart.Text
                    For r As Integer = CInt(Me.txtCountStart.Text) To CInt(Me.txtCountEnd.Text)
                        num_start = num_start + 1
                        Dim newrowsss As snLabelDataSet.snlable_idRow
                        newrowsss = SnLabelDataSet1.snlable_id.NewRow
                        newrowsss.num_sn = Me.txtFrontNum.Text & num_start
                        Me.SnLabelDataSet1.snlable_id.Rows.Add(newrowsss)
                    Next
                End If
            End If
        ElseIf rbRanDom.Checked = True Then
            For r As Integer = 0 To Me.NumericUpDown1.Value - 1
                Dim newrowsss As snLabelDataSet.snlable_idRow
                newrowsss = SnLabelDataSet1.snlable_id.NewRow
                Dim nr As String = String.Empty
                If Me.cbbRandom.Text = "ตัวเลขและตัวอักษร" Then
                    nr = snRnd(snum & stext, Me.NumericUpDown2.Value)
                ElseIf Me.cbbRandom.Text = "ตัวเลข" Then
                    nr = snRnd(snum, Me.NumericUpDown2.Value)
                ElseIf Me.cbbRandom.Text = "ตัวอักษร" Then
                    nr = snRnd(stext, Me.NumericUpDown2.Value)
                End If
                Threading.Thread.Sleep(100)
                newrowsss.num_sn = Me.txtFrontNum.Text & nr
                Me.SnLabelDataSet1.snlable_id.Rows.Add(newrowsss)
            Next
        End If

        Dim cry As ReportDocument = New ReportDocument
        If Me.cbLable.Checked = True Then
            cry.Load(rptPathA4 & "SNLabelA4Report.rpt")
        Else
            cry.Load(rptPathA4 & "SNNoLabelA4Report.rpt")
        End If
        cry.SetDataSource(Me.SnLabelDataSet1)
        CrystalReportViewer1.ReportSource = cry
        cry.Refresh()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not CrystalReportViewer1.ReportSource Is Nothing Then
            CrystalReportViewer1.PrintReport()
        Else
            MessageBox.Show(Me, "ยังไม่มีข้อมูลที่จะพิมพ์ โปรดกด 'แสดงตัวอย่าง'", "ไม่มีข้อมูล",
                                 MessageBoxButtons.OK, MessageBoxIcon.None)
        End If
    End Sub


    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/comfix/comfixprint/snlabelfrm")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCountStart_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCountStart.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 127 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtCountEnd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCountEnd.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 127 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub NumericUpDown1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NumericUpDown1.KeyPress
        e.Handled = True
    End Sub


    Private Sub NumericUpDown2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NumericUpDown2.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbLable_CheckedChanged(sender As Object, e As EventArgs) Handles cbLable.CheckedChanged
        If Me.cbLable.Checked = True Then
            Me.TextBox1.Enabled = True
        Else
            Me.TextBox1.Enabled = False
        End If
    End Sub

    Private Sub txtFrontNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFrontNum.KeyPress
        Dim ml As Integer = 10 - (Me.txtFrontNum.Text.Length + 1)
        Me.txtOneNum.MaxLength = ml
        Me.txtCountStart.MaxLength = ml
        Me.txtCountEnd.MaxLength = ml
        Me.NumericUpDown2.Maximum = ml
    End Sub
End Class
