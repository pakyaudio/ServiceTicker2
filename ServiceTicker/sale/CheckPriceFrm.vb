Imports MySql.Data.MySqlClient
Imports System.IO

Public Class CheckPriceFrm
    Dim pcost As String

    Private Sub CheckPriceFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub CheckPriceFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    ''' <summary>
    ''' โหลดรูปลง listview  call LoadPictureList(code_pro)
    ''' </summary>
    ''' <param name="key_pic"></param>
    ''' <remarks></remarks>
    Private Sub LoadPictureList(ByVal key_pic As String)
        ListView1.Clear()
        Dim imglist As New ImageList
        imglist.ColorDepth = ColorDepth.Depth32Bit
        ListView1.LargeImageList = imglist
        ListView1.LargeImageList.ImageSize = New System.Drawing.Size(250, 250)
        Try
            cmd = New MySqlCommand("SELECT pa_id,byte_pic,note_pic,datetime_save FROM " _
                                   & "picture_all WHERE key_pic='" & key_pic & "' AND del='no' ORDER BY datetime_save LIMIT 2;", ConnectionDB)
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
                lsvparent.Text = Dr.Item("datetime_save").ToString()
                lsvparent.ImageKey = Dr.Item("pa_id").ToString()
                ListView1.Items.Add(lsvparent)
            End While
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Friend Sub getDataProPrice(ByVal bcsn As String)
        Try
            Dim code_pro As String = String.Empty
            Dim bar_code As String = String.Empty
            Dim typep As String = String.Empty
            Dim unit As String = String.Empty
            Dim varuntee As String = String.Empty
            Dim notepro As String = String.Empty
            Dim spec As String = String.Empty
            Me.rbSbuy.Checked = True
            strSQL = "SELECT * FROM product WHERE bar_code='" & bcsn & "';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows = True Then
                Dr.Read()
                Me.txtCPnamePro.Text = Dr.GetString("name_pro")
                If Me.rbSbuy.Checked = True Then
                    Me.txtPrice.Text = Dr.Item("price_buy")
                ElseIf Me.rbSwholesale.Checked = True Then
                    Me.txtPrice.Text = Dr.Item("price_wholesale")
                ElseIf Me.rbStechnician.Checked = True Then
                    Me.txtPrice.Text = Dr.Item("price_technician")
                ElseIf Me.rbSloyal.Checked = True Then
                    Me.txtPrice.Text = Dr.Item("price_loyal")
                ElseIf Me.rbSmembers.Checked = True Then
                    Me.txtPrice.Text = Dr.Item("price_members")
                End If
                code_pro = Dr.Item("code_pro")
                bar_code = Dr.Item("bar_code")
                typep = Dr.Item("type")
                unit = Dr.Item("unit")
                varuntee = Dr.Item("varuntee")
                notepro = Dr.Item("notepro")
                Me.RichTextBox1.Rtf = BytetoStringRTF(Dr.Item("spec"))
                pcost = code_pro
                Me.txtCPcount_num.Text = Dr.GetDecimal("count_num")
                Call LoadPictureList(code_pro)
                Me.txtSproDetail.Text = "รหัสสินค้า : " & code_pro & vbNewLine & _
                                        "บาร์โค๊ต : " & bar_code & vbNewLine & _
                                        "หน่วย : " & unit & vbNewLine & _
                                        "ประเภท : " & typep & vbNewLine & _
                                        "ประกัน : " & varuntee & vbNewLine & _
                                        "รายละเอียดสินค้า : " & notepro
            Else
                strSQL = "SELECT * FROM " _
                    & "product WHERE code_pro IN (SELECT code_pro FROM product_serial WHERE serial_pro='" & bcsn & "');"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows = True Then
                    Dr.Read()
                    Me.txtCPnamePro.Text = Dr.GetString("name_pro")
                    If Me.rbSbuy.Checked = True Then
                        Me.txtPrice.Text = Dr.Item("price_buy")
                    ElseIf Me.rbSwholesale.Checked = True Then
                        Me.txtPrice.Text = Dr.Item("price_wholesale")
                    ElseIf Me.rbStechnician.Checked = True Then
                        Me.txtPrice.Text = Dr.Item("price_technician")
                    ElseIf Me.rbSloyal.Checked = True Then
                        Me.txtPrice.Text = Dr.Item("price_loyal")
                    ElseIf Me.rbSmembers.Checked = True Then
                        Me.txtPrice.Text = Dr.Item("price_members")
                    End If
                    Me.txtCPcount_num.Text = Dr.GetDecimal("count_num")
                    code_pro = Dr.Item("code_pro")
                    bar_code = Dr.Item("bar_code")
                    typep = Dr.Item("type")
                    unit = Dr.Item("unit")
                    varuntee = Dr.Item("varuntee")
                    notepro = Dr.Item("notepro")
                    Me.RichTextBox1.Rtf = BytetoStringRTF(Dr.Item("spec"))
                    pcost = code_pro
                    Me.txtCPcount_num.Text = Dr.GetDecimal("count_num")
                    Call LoadPictureList(code_pro)
                    Me.txtSproDetail.Text = "รหัสสินค้า : " & code_pro & vbNewLine & _
                                            "บาร์โค๊ต : " & bar_code & vbNewLine & _
                                            "หน่วย : " & unit & vbNewLine & _
                                            "ประเภท : " & typep & vbNewLine & _
                                            "ประกัน : " & varuntee & vbNewLine & _
                                            "รายละเอียดสินค้า : " & notepro

                Else
                    pcost = Nothing
                    MessageBox.Show(Me, "ไม่พบข้อมูลสินค้า", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Me.txtCPsnANDbarcode.Clear()
    End Sub

    Private Sub txtCPsnANDbarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCPsnANDbarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If Me.txtCPsnANDbarcode.Text <> Nothing Then
                Call getDataProPrice(Me.txtCPsnANDbarcode.Text)
            End If
        End If
    End Sub

    Private Sub LinkLabel1_Click(sender As Object, e As EventArgs) Handles LinkLabel1.Click
        CheckPriceSearchProductFrm.ShowDialog(Me)
    End Sub

    Private Sub GetPriceBYRB(ByVal strSQLx As String, ByVal strSQLdr As String)
        Me.txtPrice.ForeColor = Color.Red
        If pcost <> Nothing Then
            Dim oldPrice As String = Me.txtPrice.Text
            Try
                cmd = New MySqlCommand(strSQLx, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                If Dr.HasRows Then
                    Me.txtPrice.Text = Dr.Item(strSQLdr)
                Else
                    Me.txtPrice.Text = oldPrice
                End If
            Catch ex As Exception
                Me.txtPrice.Text = oldPrice
            End Try
        End If
    End Sub

    Private Sub rbSbuy_CheckedChanged(sender As Object, e As EventArgs) Handles rbSbuy.CheckedChanged
        Call GetPriceBYRB("SELECT price_loyal FROM product WHERE code_pro='" & pcost & "'", "price_loyal")
    End Sub

    Private Sub rbSloyal_CheckedChanged(sender As Object, e As EventArgs) Handles rbSloyal.CheckedChanged
        Call GetPriceBYRB("SELECT price_loyal FROM product WHERE code_pro='" & pcost & "'", "price_loyal")
    End Sub

    Private Sub rbSmembers_CheckedChanged(sender As Object, e As EventArgs) Handles rbSmembers.CheckedChanged
        Call GetPriceBYRB("SELECT price_members FROM product WHERE code_pro='" & pcost & "'", "price_members")
    End Sub

    Private Sub rbStechnician_CheckedChanged(sender As Object, e As EventArgs) Handles rbStechnician.CheckedChanged
        Call GetPriceBYRB("SELECT price_technician FROM product WHERE code_pro='" & pcost & "'", "price_technician")
    End Sub

    Private Sub rbSwholesale_CheckedChanged(sender As Object, e As EventArgs) Handles rbSwholesale.CheckedChanged
        Call GetPriceBYRB("SELECT price_wholesale FROM product WHERE code_pro='" & pcost & "'", "price_wholesale")
    End Sub

    Private Sub rsScost_CheckedChanged(sender As Object, e As EventArgs) Handles rsScost.CheckedChanged
        Call GetPriceBYRB("SELECT price_cost FROM product WHERE code_pro='" & pcost & "'", "price_cost")
    End Sub

    Private Sub txtPrice_ForeColorChanged(sender As Object, e As EventArgs) Handles txtPrice.ForeColorChanged
        Me.Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.txtPrice.ForeColor = Color.Red Then
            Me.txtPrice.ForeColor = SystemColors.WindowText
            Me.Timer1.Stop()
        Else
            Me.txtPrice.ForeColor = Color.Red
        End If
    End Sub

    'Private m_PanStartPoint As New Point

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        e.Handled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.txtCPsnANDbarcode.Text <> Nothing Then
            Call getDataProPrice(Me.txtCPsnANDbarcode.Text)
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Process.Start("https://sites.google.com/site/pakyaudio/home/serviceticker/sales/checkpricefrm")
        Catch ex As Exception

        End Try
    End Sub
End Class