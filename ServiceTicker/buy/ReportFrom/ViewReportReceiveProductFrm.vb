Imports MySql.Data.MySqlClient
Imports System.Data.SQLite
Imports System.IO

Public Class ViewReportReceiveProductFrm
    Dim oldData As Object
    Private Sub dgVSRP_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVSRP.CellDoubleClick
        Me.dgVSRP.ReadOnly = False
        oldData = Me.dgVSRP.CurrentRow.Cells(e.ColumnIndex).Value
    End Sub

    Private Sub dgVSRP_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgVSRP.CellEndEdit
        Me.dgVSRP.ReadOnly = True
        Me.dgVSRP.CurrentRow.Cells(e.ColumnIndex).Value = oldData
    End Sub

    ''' <summary>
    ''' โหลดรูปลง listview  call LoadPictureList(code_pro)
    ''' </summary>
    ''' <param name="key_pic"></param>
    ''' <remarks></remarks>
    Friend Sub LoadPictureList(ByVal key_pic As String, ByVal note_pic As String)
        ListView1.Clear()
        Dim imglist As New ImageList
        imglist.ColorDepth = ColorDepth.Depth32Bit
        ListView1.LargeImageList = imglist
        ListView1.LargeImageList.ImageSize = New System.Drawing.Size(200, 200)
        Try
            cmd = New MySqlCommand("SELECT pa_id,byte_pic,note_pic,datetime_save FROM " _
                                   & "picture_all WHERE key_pic='" & key_pic & "' AND note_pic='" & note_pic & "' AND " _
                                   & "del='no' ORDER BY datetime_save;", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read
                Dim img_buffer() As Byte
                img_buffer = CType(Dr.Item("byte_pic"), Byte())
                Dim img_stream As New MemoryStream(img_buffer, True)

                img_stream.Write(img_buffer, 0, img_buffer.Length)
                imglist.Images.Add(Dr.Item("pa_id").ToString(), New Bitmap(img_stream))
                img_stream.Close()

                Dim lsvparent As New ListViewItem
                lsvparent.Text = Dr.Item("note_pic").ToString()
                lsvparent.ImageKey = Dr.Item("pa_id").ToString()
                ListView1.Items.Add(lsvparent)
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub DelPic(ByVal pa_id)
        Try
            cmd = New MySqlCommand("UPDATE picture_all SET del='yes' WHERE pa_id='" & pa_id & "';", ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            Call LoadPictureList(ReceiveReportFrm.dgVR.CurrentRow.Cells(0).Value, ReceiveReportFrm.dgVR.CurrentRow.Cells(1).Value)
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Friend Sub getDataViewReceiveFrm(ByVal buyid As String)
        Me.dgVSRP.Rows.Clear()
        Try
            cmd = New MySqlCommand("SELECT code_pro,bar_code,name_pro,price_cost,count_num,total FROM buy_pro WHERE buy_id='" & buyid & "';", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While Dr.Read()
                With Me.dgVSRP
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.Item("code_pro")
                    .Rows(r).Cells(1).Value = Dr.Item("bar_code")
                    .Rows(r).Cells(2).Value = Dr.Item("name_pro")
                    .Rows(r).Cells(3).Value = Dr.Item("price_cost")
                    .Rows(r).Cells(4).Value = Dr.Item("count_num")
                    .Rows(r).Cells(5).Value = Dr.Item("total")
                End With
            End While
            Me.dgVSRP.ClearSelection()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            cmd = New MySqlCommand("SELECT sale_company_id,sale_company_name,datetime_save,employee FROM buy WHERE buy_id='" & buyid & "';", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            Me.txtVSRPbuy_id.Text = buyid
            Me.txtVSRPsale_company_id.Text = Dr.Item("sale_company_id")
            Me.txtVSRPsale_company_name.Text = Dr.Item("sale_company_name")
            Me.txtVSRPdatetim_save.Text = Dr.Item("datetime_save")
            Me.txtVSRPemployee.Text = Dr.Item("employee")
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        'sum price 
        Try
            Dim pb As Decimal
            For price As Integer = 0 To Me.dgVSRP.Rows.Count - 1
                pb += Me.dgVSRP.Rows(price).Cells(5).Value
            Next
            Me.txtVSRtotalBuy.Text = pb.ToString("N2")
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub ViewSelectReceiveProductFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub ViewSelectReceiveProductFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub
    Private Sub reportPrint()
        If Me.dgVSRP.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูลให้พิมพ์", MsgBoxStyle.Exclamation, "แจ้งเตือน")
        Else
            'แอดทำรีพอร์ต
            Try
                strSQLite = "DELETE FROM buy_pro_reword"
                cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                Call open_connectionSQLite()
                cmdSQLite.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            'loop save to database
            For rREPORT As Integer = 0 To Me.dgVSRP.RowCount - 1
                Try
                    strSQLite = "INSERT INTO buy_pro_reword(bar_code,name_pro,price_cost,unit,total_cost) " _
                    & "VALUES(@bar_code,@name_pro,@price_cost,@unit,@total_cost)"
                    cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                    With cmdSQLite
                        .Parameters.Add(New SQLiteParameter("@bar_code", Me.dgVSRP.Rows(rREPORT).Cells(1).Value))
                        .Parameters.Add(New SQLiteParameter("@name_pro", Me.dgVSRP.Rows(rREPORT).Cells(2).Value))
                        .Parameters.Add(New SQLiteParameter("@price_cost", Me.dgVSRP.Rows(rREPORT).Cells(3).Value))
                        .Parameters.Add(New SQLiteParameter("@unit", Me.dgVSRP.Rows(rREPORT).Cells(4).Value))
                        .Parameters.Add(New SQLiteParameter("@total_cost", Me.dgVSRP.Rows(rREPORT).Cells(5).Value))
                        Call open_connectionSQLite()
                        .ExecuteNonQuery()
                    End With
                Catch ex As Exception
                    MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                End Try
            Next
            If checkPrinter() = "A4" Then
                RebuyReportA4PrintFrm.ShowDialog(Me)
            ElseIf checkPrinter() = "A5" Then
                RebuyReportA5PrintFrm.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Call reportPrint()
    End Sub

    Private Sub txtVSRPbuy_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVSRPbuy_id.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtVSRPdatetim_save_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVSRPdatetim_save.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtVSRPemployee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVSRPemployee.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtVSRPsale_company_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVSRPsale_company_id.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtVSRPsale_company_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVSRPsale_company_name.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtVSRtotalBuy_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVSRtotalBuy.KeyPress
        e.Handled = True
    End Sub

    Private Sub ViewSelectReceiveProductFrm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Panel2.Location = New Point((Me.DisplayRectangle.Width - Panel2.Width) / 2, 5)
    End Sub

    Private Sub DelToolStripMenu_Click(sender As Object, e As EventArgs) Handles DelToolStripMenu.Click
        If MessageBox.Show(Me, "ต้องการจะลบ", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Call DelPic(Me.ListView1.FocusedItem.ImageKey.ToString)
        End If
    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Me.ListView1.SelectedItems.Count <> 0 Then
                ReceiveViewPicFrm.LoadPic(Me.ListView1.FocusedItem.ImageKey.ToString)
                ReceiveViewPicFrm.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub ListView1_MouseUp(sender As Object, e As MouseEventArgs) Handles ListView1.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If Me.ListView1.SelectedItems.Count <> 0 Then
                Me.EditPictureContextMenu.Show(Me.ListView1, e.Location)
                Me.EditPictureContextMenu.Show(Cursor.Position)
            Else
                Me.AddContextMenu.Show(Me.ListView1, e.Location)
                Me.AddContextMenu.Show(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub AddToolStripMenu_Click(sender As Object, e As EventArgs) Handles AddToolStripMenu.Click
        CameraCaptureAttactBillFrm.view1 = "View1"
        CameraCaptureAttactBillFrm.ShowDialog(Me)
    End Sub

    Private Sub ViewReportReceiveProductFrm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call LoadPictureList(ReceiveReportFrm.dgVR.CurrentRow.Cells(0).Value, ReceiveReportFrm.dgVR.CurrentRow.Cells(1).Value)
    End Sub

    Private Sub PrintToolStripMenu_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenu.Click
        DocManPrintA4Frm.paid = Me.ListView1.FocusedItem.ImageKey.ToString
        DocManPrintA4Frm.ShowDialog(Me)
    End Sub

    Private Sub ZoomToolStripMenu_Click(sender As Object, e As EventArgs) Handles ZoomToolStripMenu.Click
        ReceiveViewPicFrm.LoadPic(Me.ListView1.FocusedItem.ImageKey.ToString)
        ReceiveViewPicFrm.ShowDialog(Me)
    End Sub
End Class