Imports MySql.Data.MySqlClient
Imports System.IO

Public Class DocumentManagerFrm
#Region "Code"
    Private Sub LoadYear()
        Try
            strSQL = "SELECT DISTINCT YEAR(datetime_save) AS 'year' FROM cash_sale ORDER BY datetime_save DESC;"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read
                Me.cbbYear.Items.Add(Dr.Item("year"))
            End While
            Me.cbbYear.SelectedIndex = 0
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub GetDataTodg(ByVal datetime, Optional ByVal search = Nothing)
        Try
            Me.dgDM.Rows.Clear()
            Me.ListView1.Clear()
            Me.ListView1.Enabled = False
            strSQL = "SELECT * FROM cash_sale WHERE datetime_save LIKE '%" & datetime & "%' ORDER BY datetime_save DESC;"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dim r As Integer
            While Dr.Read
                With Me.dgDM
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = r + 1
                    .Rows(r).Cells(1).Value = Dr.Item("sale_id")
                    .Rows(r).Cells(2).Value = Dr.Item("fix_id")
                    .Rows(r).Cells(3).Value = Dr.Item("cash_id")
                    .Rows(r).Cells(4).Value = Dr.Item("customer_id")
                    .Rows(r).Cells(5).Value = Dr.Item("customer_name")
                    .Rows(r).Cells(6).Value = Dr.Item("total_all")
                    .Rows(r).Cells(7).Value = Dr.Item("datetime_save")
                    .Rows(r).Cells(8).Value = Dr.Item("cash_status")
                    .Rows(r).Cells(9).Value = Dr.Item("cash_detail")
                    .Rows(r).Cells(10).Value = Dr.Item("employee")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            strSQL = "SELECT * FROM sale WHERE datetime_save LIKE '%" & datetime & "%' ORDER BY datetime_save DESC;"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dim r As Integer
            While Dr.Read
                With Me.dgDM
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = r + 1
                    .Rows(r).Cells(1).Value = Dr.Item("sale_id")
                    .Rows(r).Cells(2).Value = Dr.Item("fix_id")
                    .Rows(r).Cells(3).Value = "-"
                    .Rows(r).Cells(4).Value = Dr.Item("customer_id")
                    .Rows(r).Cells(5).Value = Dr.Item("customer_name")
                    .Rows(r).Cells(6).Value = Dr.Item("total_all")
                    .Rows(r).Cells(7).Value = Dr.Item("datetime_save")
                    .Rows(r).Cells(8).Value = Dr.Item("cash_status")
                    .Rows(r).Cells(9).Value = "-"
                    .Rows(r).Cells(10).Value = Dr.Item("employee")
                End With
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Me.dgDM.ClearSelection()
    End Sub

    ''' <summary>
    ''' โหลดรูปลง listview  call LoadPictureList(code_pro)
    ''' </summary>
    ''' <param name="key_pic"></param>
    ''' <remarks></remarks>
    Friend Sub LoadPictureList(ByVal key_pic As String)
        ListView1.Clear()
        Dim imglist As New ImageList
        imglist.ColorDepth = ColorDepth.Depth32Bit
        ListView1.LargeImageList = imglist
        ListView1.LargeImageList.ImageSize = New System.Drawing.Size(150, 150)
        Try
            cmd = New MySqlCommand("SELECT pa_id,byte_pic,note_pic,datetime_save FROM " _
                                   & "picture_all WHERE key_pic='" & key_pic & "' AND del='no' ORDER BY datetime_save;", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                While Dr.Read
                    Dim img_buffer() As Byte
                    img_buffer = CType(Dr.Item("byte_pic"), Byte())
                    Dim img_stream As New MemoryStream(img_buffer, True)

                    img_stream.Write(img_buffer, 0, img_buffer.Length)
                    imglist.Images.Add(Dr.Item("pa_id").ToString(), New Bitmap(img_stream))
                    img_stream.Close()

                    Dim lsvparent As New ListViewItem
                    lsvparent.Text = Dr.Item("datetime_save").ToString()
                    lsvparent.ImageKey = Dr.Item("pa_id").ToString()
                    ListView1.Items.Add(lsvparent)
                    Me.lblSaleID.Text = key_pic
                End While
            Else
                Me.lblSaleID.Text = "ไม่พบเอกสาร"
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
#End Region

    Private Sub DocumentManagerFrm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Call LoadYear()
    End Sub

    Private Sub DocumentManagerFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub DocumentManagerFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Private Sub cbbYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbYear.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        GetDataTodg(Me.cbbYear.Text)
    End Sub

    Private Sub ListView1_MouseUp(sender As Object, e As MouseEventArgs) Handles ListView1.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If Me.ListView1.Enabled = True Then
                If Me.ListView1.SelectedItems.Count = 0 Then
                    Me.AddPicContextMenu.Show(Me.ListView1, e.Location)
                    Me.AddPicContextMenu.Show(Cursor.Position)
                Else
                    Me.DelPicContextMenu.Show(Me.ListView1, e.Location)
                    Me.DelPicContextMenu.Show(Cursor.Position)
                End If
            End If
        End If
    End Sub

    Private Sub dgDM_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgDM.CellMouseDoubleClick
        If Me.dgDM.Rows.Count <> 0 Then
            Me.ListView1.Enabled = True
            Call LoadPictureList(Me.dgDM.CurrentRow.Cells(1).Value)
        Else
            Me.ListView1.Enabled = False
        End If
    End Sub

    Private Sub AddPicToolStripMenu_Click(sender As Object, e As EventArgs) Handles AddPicToolStripMenu.Click
        CameraCaptureDocManFrm.ShowDialog(Me)
    End Sub

    Private Sub DelPicToolStripMenu_Click(sender As Object, e As EventArgs) Handles DelPicToolStripMenu.Click
        If MessageBox.Show(Me, "ต้องการลบ", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                strSQL = "UPDATE picture_all SET del='yes' WHERE pa_id='" & Me.ListView1.FocusedItem.ImageKey.ToString & "';"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                Call LoadPictureList(Me.dgDM.CurrentRow.Cells(1).Value)
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub

    Private Sub ZoomToolStripMenu_Click(sender As Object, e As EventArgs) Handles ZoomToolStripMenu.Click
        MainViewPictureFrm.GetPicture(ListView1.FocusedItem.ImageKey.ToString)
        MainViewPictureFrm.ShowDialog(Me)
    End Sub

    Private Sub PrintDocToolStripMenu_Click(sender As Object, e As EventArgs) Handles PrintDocToolStripMenu.Click
        DocManPrintA4Frm.paid = Me.ListView1.FocusedItem.ImageKey.ToString
        DocManPrintA4Frm.ShowDialog(Me)
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/finance/documentmanagerfrm")
        Catch ex As Exception

        End Try
    End Sub
End Class