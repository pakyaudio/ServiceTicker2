Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Globalization
Imports System.IO

Public Class ProductDetailEditFrm
#Region "Code"
    Private Sub GetProductType()
        Me.cbbPDproUnit.DataSource = Nothing
        Try
            cmd = New MySqlCommand("SELECT ID,unit_p FROM `unit` " _
                                   & "ORDER BY unit_p ASC", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                dt = New DataTable
                Me.cbbPDproUnit.DisplayMember = "Name"
                Me.cbbPDproUnit.ValueMember = "ID"

                dt.Columns.Add("Name", GetType(String))
                dt.Columns.Add("ID", GetType(String))
                While Dr.Read()
                    dt.Rows.Add(Dr.Item("unit_p"), Dr.Item("ID"))
                End While
                Me.cbbPDproUnit.DataSource = dt
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub GetProductVaruntee()
        Me.cbPDvaruntee.DataSource = Nothing
        Try
            cmd = New MySqlCommand("SELECT varuntee_status,day FROM varuntee " _
                                   & "ORDER BY ID ASC", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                dt = New DataTable
                Me.cbPDvaruntee.DisplayMember = "Name"
                Me.cbPDvaruntee.ValueMember = "ID"

                dt.Columns.Add("Name", GetType(String))
                dt.Columns.Add("ID", GetType(String))
                While Dr.Read()
                    dt.Rows.Add(Dr.Item("varuntee_status"), Dr.Item("day"))
                End While
                Me.cbPDvaruntee.DataSource = dt
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub GetSaleFor()
        Me.cbbPDsalefor.DataSource = Nothing
        Try
            cmd = New MySqlCommand("SELECT sale_company_id,sale_company_name FROM sale_company " _
                                   & "ORDER BY sale_company_name ASC", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                dt = New DataTable
                Me.cbbPDsalefor.DisplayMember = "Name"
                Me.cbbPDsalefor.ValueMember = "ID"

                dt.Columns.Add("Name", GetType(String))
                dt.Columns.Add("ID", GetType(String))
                While Dr.Read()
                    dt.Rows.Add(Dr.Item("sale_company_name"), Dr.Item("sale_company_id"))
                End While
                Me.cbbPDsalefor.DataSource = dt
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub
    ''' <summary>
    ''' โหลด prosection_name Exp. GetSectionNmae("PS0002") As String
    ''' </summary>
    ''' <param name="sid">prosection_id As String</param>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Private Function GetSectionName(ByVal sid) As String
        Try
            strSQL = "SELECT prosection_name FROM product_section WHERE prosection_id='" & sid & "';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                Dr.Read()
                Return Dr.Item("prosection_name")
            Else
                Return "-"
            End If
        Catch ex As Exception
            Return "-"
        End Try
    End Function
    ''' <summary>
    ''' โหลด product_section_subs Exp. GetSubSectionNmae("2") As String
    ''' </summary>
    ''' <param name="ssid">product_section_subs_id As String</param>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Private Function GetSubSectionName(ByVal ssid) As String
        Try
            strSQL = "SELECT product_section_subs_name FROM product_section_subs WHERE product_section_subs_id='" & ssid & "';"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                Dr.Read()
                Return Dr.Item("product_section_subs_name")
            Else
                Return "-"
            End If
        Catch ex As Exception
            Return "-"
        End Try
    End Function
    ''' <summary>
    ''' ใส๋ code_pro Exp. LoadEditProduct("PD00005")
    ''' </summary>
    ''' <param name="proid">code_pro</param>
    ''' <remarks></remarks>
    Friend Sub LoadEditProduct(ByVal proid)

        strSQL = "SELECT `id`,code_pro,bar_code,name_pro,price_cost," _
            & "price_buy,price_wholesale,price_technician,price_loyal," _
            & "price_members,unit,varuntee,check_stock,count_num,`type`," _
            & "company_buy,notepro,spec,sub_section,service_chart FROM product " _
            & "WHERE id='" & proid & "';"
        dt = New DataTable
        dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
        Call open_connection()
        Try
            dtAdapter.Fill(dt)
            Me.txtPDproID.Text = dt(0).Item("code_pro")
            Me.txtPDproID.Tag = Me.txtPDproID.Text
            Me.txtPDbarcode.Text = dt(0).Item("bar_code")
            Me.txtPDbarcode.Tag = Me.txtPDbarcode.Text
            Me.txtPDproName.Text = dt(0).Item("name_pro")
            Me.txtPDproName.Tag = dt(0).Item("id")
            Me.txtPDEsection.Text = GetSectionName(dt(0).Item("type"))
            Me.txtPDEsection.Tag = dt(0).Item("type")
            Me.txtPDEsubsection.Text = GetSubSectionName(dt(0).Item("sub_section"))
            Me.txtPDEsubsection.Tag = dt(0).Item("sub_section")
            Me.cbbPDproUnit.Text = dt(0).Item("unit")
            Me.cbPDvaruntee.Text = dt(0).Item("varuntee")
            Me.txtPDstockbalance.Text = dt(0).Item("count_num")
            Me.txtPDprodepleted.Text = dt(0).Item("check_stock")
            Me.txtPDproPiceCost.Text = dt(0).Item("price_cost")
            Me.txtDprobuy.Text = dt(0).Item("price_buy")
            Me.txtPDp_wholsale.Text = dt(0).Item("price_wholesale")
            Me.txtPDp_technician.Text = dt(0).Item("price_technician")
            Me.txtPDp_loyel.Text = dt(0).Item("price_loyal")
            Me.txtPDp_member.Text = dt(0).Item("price_members")
            RichTextProdetail.Rtf = BytetoStringRTF(dt(0).Item("spec"))
            Me.cbbPDsalefor.Text = dt(0).Item("company_buy")
            Me.txtPDnote.Text = dt(0).Item("notepro")
            Dim sc As Integer = dt(0).Item("service_chart")
            If sc = 1 Then
                If Me.CheckBox1.CheckState = CheckState.Unchecked Then
                    Me.CheckBox1.CheckState = CheckState.Checked
                End If
            Else
                If Me.CheckBox1.CheckState = CheckState.Checked Then
                    Me.CheckBox1.CheckState = CheckState.Unchecked
                End If
            End If
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try

        Try
            Me.dgPDserial.Rows.Clear()
            strSQL = "SELECT code_pro,serial_pro,date_in FROM product_serial " _
               & "WHERE code_pro='" & Me.txtPDproID.Tag & "' LIMIT " & Me.NumericUpDown1.Value & ";"
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    Dim r As Integer
                    While Dr.Read
                        With Me.dgPDserial
                            r = .RowCount
                            .Rows.Add()
                            .Rows(r).Cells(0).Tag = Dr.Item("code_pro")
                            .Rows(r).Cells(0).Value = Dr.Item("serial_pro")
                            .Rows(r).Cells(1).Value = Dr.Item("date_in")
                        End With
                    End While
                End If
            End Using
            Call ProductDetailFrm.CountSN(Me.txtPDproID.Text)
            Me.lblSNcount.Text = Me.dgPDserial.Rows.Count.ToString("N0") & "/" & ProductDetailFrm.l2.ToString("N0")
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub SaveAddProduct()
        If Me.txtPDproID.Text = String.Empty Then
            MsgBox("กรุณาใส่รหัสสินค้าหรือกดปุ่มสร้างรหัสสินค้า", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            Me.txtPDproID.Focus()
            Exit Sub
        End If

        If Me.txtPDbarcode.Text = String.Empty Then
            MsgBox("กรุณาใส่บาร์โค๊ดหรือกดปุ่มสร้างบาร์โค๊ด", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            Me.txtPDbarcode.Focus()
            Exit Sub
        End If

        If Me.txtPDproName.Text = String.Empty Then
            MsgBox("กรุณาใส่ชื่อสินค้า", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            Me.txtPDproName.Focus()
            Exit Sub
        End If

        If Me.txtPDEsection.Text = String.Empty Then
            MsgBox("กรุณาเลือกประเภทสินค้า", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            SelectSectionFrm.ShowDialog(Me)
            Exit Sub
        End If

        If Me.txtPDEsubsection.Text = String.Empty Then
            MsgBox("กรุณาเลือกประเภทสินค้า", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            SelectSectionFrm.ShowDialog(Me)
            Exit Sub
        End If

        If Me.cbbPDproUnit.Text = String.Empty Then
            MsgBox("กรุณาเลือกหน่วยนับ", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            Me.cbbPDproUnit.Focus()
            Exit Sub
        End If

        If Me.cbPDvaruntee.Text = String.Empty Then
            MsgBox("กรุณาเลือกระยะเวลารับประกัน", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            Me.cbPDvaruntee.Focus()
            Exit Sub
        End If

        If Me.txtDprobuy.Text = String.Empty Then
            MsgBox("กรุณาใส่ราคาขายปลีก", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            Me.txtDprobuy.Focus()
            Exit Sub
        End If

        If Me.txtPDproPiceCost.Text = String.Empty Then
            MsgBox("กรุณาใส่ราคาต้นทุน", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            Me.txtPDproPiceCost.Focus()
            Exit Sub
        End If

        If Me.cbbPDproUnit.Text = String.Empty Then
            MsgBox("กรุณาเลือกหรือใส่ หน่วยนับ", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            Me.cbbPDproUnit.Focus()
            Exit Sub
        End If

        If Me.txtPDstockbalance.Text = String.Empty Then
            MsgBox("กรุณาใส่สต็อกที่มีสต็อก", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            Me.txtPDstockbalance.Focus()
            Exit Sub
        End If

        If Me.txtPDprodepleted.Text = String.Empty Then
            MsgBox("กรุณาใส่จำนวนเมื่อสิ้นค้าใกล้หมดให้เตือน", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            Me.txtPDprodepleted.Focus()
            Exit Sub
        End If

        If Me.cbbPDsalefor.Text = String.Empty Then
            MsgBox("กรุณาเลือกบริษัทหรือรายที่จัดซื้อมา", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            Me.cbbPDsalefor.Focus()
            Exit Sub
        End If

        If Me.txtPDnote.Text = String.Empty Then
            MsgBox("กรุณาใส่หมายเหตุ หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            Me.txtPDnote.Focus()
            Exit Sub
        End If

        If Me.txtPDp_wholsale.Text = String.Empty Or Me.txtPDp_wholsale.Text = "-" Then
            Me.txtPDp_wholsale.Text = "0"
        End If

        If Me.txtPDp_technician.Text = String.Empty Or Me.txtPDp_technician.Text = "-" Then
            Me.txtPDp_technician.Text = "0"
        End If

        If Me.txtPDp_loyel.Text = String.Empty Or Me.txtPDp_loyel.Text = "-" Then
            Me.txtPDp_loyel.Text = "0"
        End If

        If Me.txtPDp_member.Text = String.Empty Or Me.txtPDp_member.Text = "-" Then
            Me.txtPDp_member.Text = "0"
        End If

        If checkMySQLDruplicateDB("SELECT code_pro FROM product WHERE code_pro='" & Me.txtPDproID.Text & "';") = True Then
            MsgBox("พบรหัสสินค้าซ้ำกัน กรุณาเปลี่ยนรหัสสินค้าใหม่", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            Me.txtPDproID.Focus()
            Me.txtPDproID.SelectAll()
            Exit Sub
        End If

        If checkMySQLDruplicateDB("SELECT bar_code FROM product WHERE bar_code='" & Me.txtPDbarcode.Text & "';") = True Then
            MsgBox("พบรหัสบาร์โค๊ตซ้ำกัน กรุณาเปลี่ยนรหัสบาร์โค๊ตใหม่", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            Me.txtPDbarcode.Focus()
            Me.txtPDbarcode.SelectAll()
            Exit Sub
        End If
        If MessageBox.Show(Me, "คุณแน่ใจว่าจะเพิ่มข้อมูลนี้", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                If checkMySQLDruplicateDB("SELECT unit_p FROM `unit` WHERE unit_p='" & Me.cbbPDproUnit.Text & "';") = False Then
                    strSQL = "INSERT INTO `unit`(unit_p)VALUES('" & Me.cbbPDproUnit.Text & "');"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                strSQL = "INSERT INTO product(code_pro,bar_code,name_pro,`type`,varuntee," _
                    & "price_cost,price_buy,price_wholesale,price_technician,price_loyal," _
                    & "price_members,unit,count_num,check_stock,company_buy,notepro,spec,update_date,sub_section,service_chart)" _
                    & "VALUES(@code_pro,@bar_code,@name_pro,@type,@varuntee," _
                    & "@price_cost,@price_buy,@price_wholesale,@price_technician,@price_loyal," _
                    & "@price_members,@unit,@count_num,@check_stock,@company_buy,@notepro,@spec,@update_date,@sub_section,service_chart=@service_chart)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.AddWithValue("@code_pro", Me.txtPDproID.Text.Trim)
                cmd.Parameters.AddWithValue("@bar_code", Me.txtPDbarcode.Text.Trim)
                cmd.Parameters.AddWithValue("@name_pro", Me.txtPDproName.Text.Trim)
                cmd.Parameters.AddWithValue("@type", Me.txtPDEsection.Tag.ToString)
                cmd.Parameters.AddWithValue("@varuntee", Me.cbPDvaruntee.Text)
                cmd.Parameters.AddWithValue("@price_buy", Me.txtDprobuy.Text)
                cmd.Parameters.AddWithValue("@price_cost", Me.txtPDproPiceCost.Text)
                cmd.Parameters.AddWithValue("@price_wholesale", Me.txtPDp_wholsale.Text)
                cmd.Parameters.AddWithValue("@price_technician", Me.txtPDp_technician.Text)
                cmd.Parameters.AddWithValue("@price_loyal", Me.txtPDp_loyel.Text)
                cmd.Parameters.AddWithValue("@price_members", Me.txtPDp_member.Text)
                cmd.Parameters.AddWithValue("@unit", Me.cbbPDproUnit.Text)
                cmd.Parameters.AddWithValue("@count_num", Me.txtPDstockbalance.Text)
                cmd.Parameters.AddWithValue("@check_stock", Me.txtPDprodepleted.Text)
                cmd.Parameters.AddWithValue("@company_buy", Me.cbbPDsalefor.Text)
                cmd.Parameters.AddWithValue("@notepro", Me.txtPDnote.Text)
                If Me.RichTextProdetail.Text = Nothing Then
                    Me.RichTextProdetail.Text = "-"
                End If
                cmd.Parameters.AddWithValue("@spec", StringRTFtoByte(RichTextProdetail.Rtf))
                cmd.Parameters.AddWithValue("@update_date", Now.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")))
                cmd.Parameters.AddWithValue("@sub_section", Me.txtPDEsubsection.Tag.ToString)
                If CheckBox1.Checked = True Then
                    cmd.Parameters.AddWithValue("@service_chart", 1)
                Else
                    cmd.Parameters.AddWithValue("@service_chart", 0)
                End If
                Call open_connection()
                Dim saveR As Integer = Nothing
                saveR = cmd.ExecuteNonQuery()
                If saveR = 1 Then
                    'อัพเดทรูปชั่วคราวให้เป็นถาวร
                    Try
                        strSQL = "UPDATE picture_all SET note_pic=@note_pic WHERE key_pic=@key_pic AND note_pic='" & tempPic & "';"
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        cmd.Parameters.AddWithValue("@note_pic", Me.txtPDbarcode.Text)
                        cmd.Parameters.AddWithValue("@key_pic", Me.txtPDproID.Text)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try

                    MessageBox.Show(Me, "บันทึกข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call ProductDetailFrm.SearchProduct("SELECT `id`,code_pro,name_pro,count_num,update_date FROM " _
                      & "product WHERE `type`='" & Me.txtPDEsection.Tag.ToString & "' AND sub_section='" & Me.txtPDEsubsection.Tag.ToString & "';", "where")
                    Me.Close()
                Else
                    MessageBox.Show(Me, "บันทึกข้อมูลไม่สำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
        End If
    End Sub

    Private Sub SaveEditProduct()
        If Me.txtPDproID.Text = String.Empty Then
            MsgBox("กรุณาใส่รหัสสินค้าหรือกดปุ่มสร้างรหัสสินค้า", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            Me.txtPDproID.Focus()
            Exit Sub
        End If

        If Me.txtPDbarcode.Text = String.Empty Then
            MsgBox("กรุณาใส่บาร์โค๊ดหรือกดปุ่มสร้างบาร์โค๊ด", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            Me.txtPDbarcode.Focus()
            Exit Sub
        End If

        If Me.txtPDproName.Text = String.Empty Then
            MsgBox("กรุณาใส่ชื่อสินค้า", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            Me.txtPDproName.Focus()
            Exit Sub
        End If

        If Me.txtPDEsection.Text = String.Empty Then
            MsgBox("กรุณาเลือกประเภทสินค้า", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            SelectSectionFrm.ShowDialog(Me)
            Exit Sub
        End If

        If Me.txtPDEsubsection.Text = String.Empty Then
            MsgBox("กรุณาเลือกประเภทสินค้า", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            SelectSectionFrm.ShowDialog(Me)
            Exit Sub
        End If

        If Me.cbbPDproUnit.Text = String.Empty Then
            MsgBox("กรุณาเลือกหน่วยนับ", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            Me.cbbPDproUnit.Focus()
            Exit Sub
        End If

        If Me.cbPDvaruntee.Text = String.Empty Then
            MsgBox("กรุณาเลือกระยะเวลารับประกัน", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            Me.cbPDvaruntee.Focus()
            Exit Sub
        End If

        If Me.txtDprobuy.Text = String.Empty Then
            MsgBox("กรุณาใส่ราคาขายปลีก", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            Me.txtDprobuy.Focus()
            Exit Sub
        End If

        If Me.txtPDproPiceCost.Text = String.Empty Then
            MsgBox("กรุณาใส่ราคาต้นทุน", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            Me.txtPDproPiceCost.Focus()
            Exit Sub
        End If

        If Me.cbbPDproUnit.Text = String.Empty Then
            MsgBox("กรุณาเลือกหรือใส่ หน่วยนับ", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            Me.cbbPDproUnit.Focus()
            Exit Sub
        End If

        If Me.txtPDstockbalance.Text = String.Empty Then
            MsgBox("กรุณาใส่สต็อกที่มีสต็อก", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            Me.txtPDstockbalance.Focus()
            Exit Sub
        End If

        If Me.txtPDprodepleted.Text = String.Empty Then
            MsgBox("กรุณาใส่จำนวนเมื่อสิ้นค้าใกล้หมดให้เตือน", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            Me.txtPDprodepleted.Focus()
            Exit Sub
        End If

        If Me.cbbPDsalefor.Text = String.Empty Then
            MsgBox("กรุณาเลือกบริษัทหรือรายที่จัดซื้อมา", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            Me.cbbPDsalefor.Focus()
            Exit Sub
        End If

        If Me.txtPDnote.Text = String.Empty Then
            MsgBox("กรุณาใส่หมายเหตุ หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
            Me.txtPDnote.Focus()
            Exit Sub
        End If

        If Me.txtPDp_wholsale.Text = String.Empty Or Me.txtPDp_wholsale.Text = "-" Then
            Me.txtPDp_wholsale.Text = "0"
        End If

        If Me.txtPDp_technician.Text = String.Empty Or Me.txtPDp_technician.Text = "-" Then
            Me.txtPDp_technician.Text = "0"
        End If

        If Me.txtPDp_loyel.Text = String.Empty Or Me.txtPDp_loyel.Text = "-" Then
            Me.txtPDp_loyel.Text = "0"
        End If

        If Me.txtPDp_member.Text = String.Empty Or Me.txtPDp_member.Text = "-" Then
            Me.txtPDp_member.Text = "0"
        End If
        If Me.txtPDproID.Text <> Me.txtPDproID.Tag Then
            If checkMySQLDruplicateDB("SELECT code_pro FROM product WHERE code_pro='" & Me.txtPDproID.Text & "' AND " _
                                      & "id <> '" & Me.txtPDproName.Tag & "';") = True Then
                MsgBox("พบรหัสสินค้าซ้ำกัน กรุณาเปลี่ยนรหัสสินค้าใหม่", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.txtPDproID.Focus()
                Me.txtPDproID.SelectAll()
                Exit Sub
            End If
        End If

        If Me.txtPDbarcode.Text <> Me.txtPDbarcode.Tag Then
            If checkMySQLDruplicateDB("SELECT bar_code FROM product WHERE bar_code='" & Me.txtPDbarcode.Text & "' AND " _
                                      & "id <> '" & Me.txtPDproName.Tag & "';") = True Then
                MsgBox("พบรหัสบาร์โค๊ตซ้ำกัน กรุณาเปลี่ยนรหัสบาร์โค๊ตใหม่", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.txtPDbarcode.Focus()
                Me.txtPDbarcode.SelectAll()
                Exit Sub
            End If
        End If

        If MessageBox.Show(Me, "คุณแน่ใจว่าจะบันทึกข้อมูลนี้", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                If checkMySQLDruplicateDB("SELECT unit_p FROM `unit` WHERE unit_p='" & Me.cbbPDproUnit.Text & "';") = False Then
                    strSQL = "INSERT INTO `unit`(unit_p)VALUES('" & Me.cbbPDproUnit.Text & "');"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                strSQL = "UPDATE product SET  bar_code=@bar_code, name_pro=@name_pro" _
                    & ", `type`=@type, varuntee=@varuntee, price_buy=@price_buy, price_cost=@price_cost" _
                    & ", price_wholesale=@price_wholesale, price_technician=@price_technician, price_loyal=@price_loyal" _
                    & ", price_members=@price_members, `unit`=@unit, count_num=@count_num, check_stock=@check_stock" _
                    & ", company_buy=@company_buy, notepro=@notepro, spec=@spec, update_date=@update_date" _
                    & ", sub_section=@sub_section, service_chart=@service_chart WHERE `id`=@id;"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.AddWithValue("@bar_code", Me.txtPDbarcode.Text.Trim)
                cmd.Parameters.AddWithValue("@name_pro", Me.txtPDproName.Text.Trim)
                cmd.Parameters.AddWithValue("@type", Me.txtPDEsection.Tag)
                cmd.Parameters.AddWithValue("@varuntee", Me.cbPDvaruntee.Text)
                cmd.Parameters.AddWithValue("@price_buy", Me.txtDprobuy.Text)
                cmd.Parameters.AddWithValue("@price_cost", Me.txtPDproPiceCost.Text)
                cmd.Parameters.AddWithValue("@price_wholesale", Me.txtPDp_wholsale.Text)
                cmd.Parameters.AddWithValue("@price_technician", Me.txtPDp_technician.Text)
                cmd.Parameters.AddWithValue("@price_loyal", Me.txtPDp_loyel.Text)
                cmd.Parameters.AddWithValue("@price_members", Me.txtPDp_member.Text)
                cmd.Parameters.AddWithValue("@unit", Me.cbbPDproUnit.Text)
                cmd.Parameters.AddWithValue("@count_num", Me.txtPDstockbalance.Text)
                cmd.Parameters.AddWithValue("@check_stock", Me.txtPDprodepleted.Text)
                cmd.Parameters.AddWithValue("@company_buy", Me.cbbPDsalefor.Text)
                cmd.Parameters.AddWithValue("@notepro", Me.txtPDnote.Text)
                If Me.RichTextProdetail.Text = Nothing Then
                    Me.RichTextProdetail.Text = "-"
                End If
                cmd.Parameters.AddWithValue("@spec", StringRTFtoByte(RichTextProdetail.Rtf))
                cmd.Parameters.AddWithValue("@update_date", Now.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-US")))
                cmd.Parameters.AddWithValue("@sub_section", Me.txtPDEsubsection.Tag)
                If CheckBox1.Checked = True Then
                    cmd.Parameters.AddWithValue("@service_chart", 1)
                Else
                    cmd.Parameters.AddWithValue("@service_chart", 0)
                End If
                cmd.Parameters.AddWithValue("@id", Me.txtPDproName.Tag)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            'อัพเดทรูปชั่วคราวให้เป็นถาวร
            Try
                strSQL = "UPDATE picture_all SET note_pic=@note_pic WHERE key_pic=@key_pic AND note_pic='" & tempPic & "';"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.AddWithValue("@note_pic", Me.txtPDbarcode.Text)
                cmd.Parameters.AddWithValue("@key_pic", Me.txtPDproID.Text)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            'อัพเดท product_serial
            Try
                strSQL = "UPDATE product_serial SET name_pro='" & Me.txtPDproName.Text.Trim & "'" & _
                    " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            'อัพเดท product_id
            Try
                strSQL = "UPDATE product_id SET bar_code='" & Me.txtPDbarcode.Text.Trim & "',name_pro='" & Me.txtPDproName.Text.Trim & "'" & _
                    " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            'อัพเดท buy_pro
            Try
                strSQL = "UPDATE buy_pro SET bar_code='" & Me.txtPDbarcode.Text.Trim & "'," & _
                    "name_pro='" & Me.txtPDproName.Text.Trim & "',unit='" & Me.cbbPDproUnit.Text & "' WHERE code_pro='" & Me.txtPDproID.Text.Trim & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            'อัพเดท cash_sale_barcode
            Try
                strSQL = "UPDATE cash_sale_barcode SET bar_code='" & Me.txtPDbarcode.Text.Trim & "'," & _
                            "name_pro='" & Me.txtPDproName.Text.Trim & "',unit='" & Me.cbbPDproUnit.Text & "'," & _
                            "type='" & Me.txtPDEsection.Text & "' WHERE code_pro='" & Me.txtPDproID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            'อัพเดท cash_sale_serial
            Try
                strSQL = "UPDATE cash_sale_serial SET bar_code='" & Me.txtPDbarcode.Text.Trim & "'," & _
                    "name_pro='" & Me.txtPDproName.Text.Trim & "'" & _
                    " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            'อัพเดท check_stock
            Try
                strSQL = "UPDATE check_stock SET " & _
                    "name_pro='" & Me.txtPDproName.Text.Trim & "'" & _
                    " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            'อัพเดท check_stock_bc
            Try
                strSQL = "UPDATE check_stock_bc SET bar_code='" & Me.txtPDbarcode.Text.Trim & "'," & _
                    "name_pro='" & Me.txtPDproName.Text.Trim & "'" & _
                    " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            'อัพเดท claims
            Try
                strSQL = "UPDATE claims SET bar_code='" & Me.txtPDbarcode.Text.Trim & "'," & _
                    "name_pro='" & Me.txtPDproName.Text.Trim & "'" & _
                    " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            'อัพเดท claims_cache
            Try
                strSQL = "UPDATE claims_cache SET bar_code='" & Me.txtPDbarcode.Text.Trim & "'," & _
                    "name_pro='" & Me.txtPDproName.Text.Trim & "'" & _
                    " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            'อัพเดท claims_copy
            Try
                strSQL = "UPDATE claims_copy SET bar_code='" & Me.txtPDbarcode.Text.Trim & "'," & _
                    "name_pro='" & Me.txtPDproName.Text.Trim & "'" & _
                    " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            'อัพเดท claims_send_report
            Try
                strSQL = "UPDATE claims_send_report SET bar_code='" & Me.txtPDbarcode.Text.Trim & "'," & _
                    "name_pro='" & Me.txtPDproName.Text.Trim & "',unit='" & Me.cbbPDproUnit.Text & "'," & _
                    "type='" & Me.txtPDEsection.Text & "'" & _
                    " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            'อัพเดท returnproduct_barcode
            Try
                strSQL = "UPDATE returnproduct_barcode SET " & _
                    "name_pro='" & Me.txtPDproName.Text.Trim & "'" & _
                    " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            'อัพเดท returnproduct_serial
            Try
                strSQL = "UPDATE returnproduct_serial SET " & _
                    "name_pro='" & Me.txtPDproName.Text.Trim & "'" & _
                    " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            'อัพเดท sale_barcode
            Try
                strSQL = "UPDATE sale_barcode SET bar_code='" & Me.txtPDbarcode.Text.Trim & "'," & _
                    "name_pro='" & Me.txtPDproName.Text.Trim & "',unit='" & Me.cbbPDproUnit.Text & "'," & _
                    "type='" & Me.txtPDEsection.Text & "'," & _
                    "name_pro='" & Me.txtPDproName.Text.Trim & "'" & _
                    " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            'อัพเดท sale_serial
            Try
                strSQL = "UPDATE sale_serial SET bar_code='" & Me.txtPDbarcode.Text.Trim & "'," & _
                    "name_pro='" & Me.txtPDproName.Text.Trim & "'" & _
                    " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            'อัพเดท stock_number_cache
            Try
                strSQL = "UPDATE stock_number_cache SET bar_code='" & Me.txtPDbarcode.Text.Trim & "'," & _
                    "name_pro='" & Me.txtPDproName.Text.Trim & "',type='" & Me.txtPDEsection.Text & "'" & _
                    " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            'อัพเดท stock_number_sn_cache
            Try
                strSQL = "UPDATE stock_number_sn_cache SET " & _
                    "name_pro='" & Me.txtPDproName.Text.Trim & "'" & _
                    " WHERE code_pro='" & Me.txtPDproID.Text.Trim & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Call ProductDetailFrm.SearchProduct("SELECT `id`,code_pro,name_pro,count_num,update_date FROM " _
               & "product WHERE `type`='" & Me.txtPDEsection.Tag.ToString & "' AND sub_section='" & Me.txtPDEsubsection.Tag.ToString & "';", "where")
            MessageBox.Show(Me, "บันทึกข้อมูลแล้ว", "บันทึกข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        End If
    End Sub

    Private Sub addSN()
        If checkMySQLDruplicateDB("SELECT serial_pro FROM product_serial WHERE serial_pro='" & Me.txtPDAddSn.Text & "';") = True Then
            MessageBox.Show(Me, "พบรหัส SN ซ้ำกัน ในระบบ กรุณาตรวจสอบ", "SN ซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                strSQL = "INSERT INTO product_serial(code_pro,serial_pro,name_pro,date_in)" _
                         & "VALUES(@code_pro,@serial_pro,@name_pro,@date_in)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.AddWithValue("@code_pro", Me.txtPDproID.Text.Trim)
                cmd.Parameters.AddWithValue("@serial_pro", Me.txtPDAddSn.Text.Trim)
                cmd.Parameters.AddWithValue("@name_pro", Me.txtPDproName.Text.Trim)
                cmd.Parameters.AddWithValue("@date_in", Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")))
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                Dim rs As Integer
                With Me.dgPDserial
                    rs = .Rows.Count
                    .Rows.Add()
                    .Rows(rs).Cells(0).Value = Me.txtPDAddSn.Text
                    .Rows(rs).Cells(1).Value = Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"))
                End With
                Me.lblSNcount.Text = Me.dgPDserial.Rows.Count.ToString("N") & "/" & ProductDetailFrm.l2.ToString("N")
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try


            'sum count_num product
            Try
                'update count_num product
                strSQL = "UPDATE product SET count_num=CAST(count_num AS UNSIGNED) + 1 WHERE code_pro='" & Me.txtPDproID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                Call ProductDetailFrm.addSNrows(Me.txtPDAddSn.Text.Trim)
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try

            Try
                strSQL = "SELECT count_num FROM product WHERE code_pro='" & Me.txtPDproID.Text & "';"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                Me.txtPDstockbalance.Text = Dr.Item("count_num")
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Call ProductDetailFrm.CountSN(Me.txtPDproID.Text.Trim)
            Me.lblSNcount.Text = Me.dgPDserial.Rows.Count.ToString("N0") & "/" & ProductDetailFrm.l2.ToString("N0")
        End If
    End Sub

    Private Sub codeproSelect2Next()
        Try
            cmd = New MySqlCommand("SELECT id,code_pro,serial_pro,date_in FROM " _
                                   & "product_serial WHERE code_pro='" & Me.txtPDproID.Text & "' " _
                                   & "AND `id` > '" & Me.dgPDserial.Rows(Me.dgPDserial.RowCount - 1).Cells(0).Tag & "' " _
                                   & "LIMIT " & Me.NumericUpDown1.Value & ";", ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                ' Me.dgMSN.Rows.Clear()
                Dim r As Integer
                While Dr.Read()
                    With Me.dgPDserial
                        r = .Rows.Count
                        .Rows.Add()
                        .Rows(r).Cells(0).Tag = Dr.Item("id")
                        .Rows(r).Cells(0).Value = Dr.Item("serial_pro")
                        .Rows(r).Cells(1).Tag = Dr.Item("code_pro")
                        .Rows(r).Cells(1).Value = Dr.Item("date_in")
                    End With
                End While
            End If
            lblSNcount.Text = Me.dgPDserial.Rows.Count.ToString("N0") & "/" & ProductDetailFrm.l2.ToString("N0")
            Me.dgPDserial.Refresh()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
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
        ListView1.LargeImageList.ImageSize = New System.Drawing.Size(200, 200)
        Try
            cmd = New MySqlCommand("SELECT pa_id,byte_pic,note_pic,datetime_save FROM " _
                                   & "picture_all WHERE key_pic='" & key_pic & "' AND del='no' ORDER BY datetime_save;", ConnectionDB)
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

#End Region

    Private Sub RichTextProdetail_Click(sender As Object, e As EventArgs) Handles RichTextProdetail.Click
        If Me.RichTextProdetail.Enabled = True Then
            ProductRichTextDetailFrm.RichTextBox1.Rtf = Me.RichTextProdetail.Rtf
            ProductRichTextDetailFrm.ShowDialog(Me)
        End If
    End Sub

    Private Sub btnPDgetCodepro_Click(sender As Object, e As EventArgs) Handles btnPDgetCodepro.Click
        Call ALLAutonumber("ver_productid", Me.txtPDproID.Text)
    End Sub

    Private Sub txtPDproID_TextChanged(sender As Object, e As EventArgs) Handles txtPDproID.TextChanged
        Me.txtPDproID.Text = strReplacetext(Me.txtPDproID.Text)
        If Me.txtPDproID.Text <> Nothing And Me.txtPDbarcode.Text <> Nothing Then
            Me.btnPDselectImage.Enabled = True
        Else
            Me.btnPDselectImage.Enabled = False
        End If
    End Sub

    Private Sub btnPDgetBarcode_Click(sender As Object, e As EventArgs) Handles btnPDgetBarcode.Click
        Call ALLAutonumber("ver_barcode", Me.txtPDbarcode.Text)
    End Sub

    Private Sub txtPDbarcode_TextChanged(sender As Object, e As EventArgs) Handles txtPDbarcode.TextChanged
        Me.txtPDbarcode.Text = strReplacetext(Me.txtPDbarcode.Text)
        If Me.txtPDproID.Text <> Nothing And Me.txtPDbarcode.Text <> Nothing Then
            Me.btnPDselectImage.Enabled = True
        Else
            Me.btnPDselectImage.Enabled = False
        End If
    End Sub

    Private Sub txtPDproName_TextChanged(sender As Object, e As EventArgs) Handles txtPDproName.TextChanged
        Me.txtPDproName.Text = strReplacetext(Me.txtPDproName.Text)
    End Sub

    Private Sub cbbPDsalefor_DropDown(sender As Object, e As EventArgs) Handles cbbPDsalefor.DropDown
        Call GetSaleFor()
    End Sub

    Private Sub cbbPDsalefor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbPDsalefor.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbPDvaruntee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbPDvaruntee.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbbPDproUnit_DropDown(sender As Object, e As EventArgs) Handles cbbPDproUnit.DropDown
        Call GetProductType()
    End Sub

    Private Sub cbPDvaruntee_DropDown(sender As Object, e As EventArgs) Handles cbPDvaruntee.DropDown
        Call GetProductVaruntee()
    End Sub

    Private Sub txtPDstockbalance_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPDstockbalance.KeyDown
        AddHandler CType(txtPDstockbalance, TextBox).KeyPress, AddressOf KeyPress_Integer
    End Sub

    Private Sub txtPDprodepleted_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPDprodepleted.KeyDown
        AddHandler txtPDprodepleted.KeyPress, AddressOf KeyPress_Integer
    End Sub

    Private Sub txtPDproPiceCost_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPDproPiceCost.KeyDown
        AddHandler txtPDproPiceCost.KeyPress, AddressOf KeyPress_decimal
    End Sub

    Private Sub txtDprobuy_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDprobuy.KeyDown
        AddHandler txtDprobuy.KeyPress, AddressOf KeyPress_decimal
    End Sub

    Private Sub txtPDp_wholsale_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPDp_wholsale.KeyDown
        AddHandler txtPDp_wholsale.KeyPress, AddressOf KeyPress_decimal
    End Sub

    Private Sub txtPDp_technician_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPDp_technician.KeyDown
        AddHandler txtPDp_technician.KeyPress, AddressOf KeyPress_decimal
    End Sub

    Private Sub txtPDp_loyel_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPDp_loyel.KeyDown
        AddHandler txtPDp_loyel.KeyPress, AddressOf KeyPress_decimal
    End Sub

    Private Sub txtPDp_member_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPDp_member.KeyDown
        AddHandler txtPDp_member.KeyPress, AddressOf KeyPress_decimal
    End Sub

    Private Sub btnPDbp_Click(sender As Object, e As EventArgs) Handles btnPDbp.Click
        Me.txtPDp_wholsale.Text = Me.txtDprobuy.Text
        Me.txtPDp_technician.Text = Me.txtDprobuy.Text
        Me.txtPDp_loyel.Text = Me.txtDprobuy.Text
        Me.txtPDp_member.Text = Me.txtDprobuy.Text
    End Sub

    Private Sub ProductDetailEditFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            strSQL = "DELETE FROM picture_all WHERE key_pic=@key_pic AND note_pic=@note_pic;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            cmd.Parameters.AddWithValue("@key_pic", Me.txtPDproID.Text)
            cmd.Parameters.AddWithValue("@note_pic", tempPic)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub ProductDetailEditFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainFrm.Icon
    End Sub

    Private Sub txtPDnote_TextChanged(sender As Object, e As EventArgs) Handles txtPDnote.TextChanged
        Me.txtPDnote.Text = strReplacetext(Me.txtPDnote.Text)
    End Sub
    Friend tempPic As String
    Private Sub btnPDselectImage_Click(sender As Object, e As EventArgs) Handles btnPDselectImage.Click
        If tempPic = Nothing Then
            tempPic = sRnd()
        End If
        CameraCaptureProFrm.ShowDialog(Me)
    End Sub

    Private Sub btnPSselectSection_Click(sender As Object, e As EventArgs) Handles btnPSselectSection.Click
        SelectSectionFrm.ShowDialog(Me)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If saveCheck = True Then
            Call SaveAddProduct()
        ElseIf saveCheck = False Then
            Call SaveEditProduct()
        End If
    End Sub
    ''' <summary>
    ''' เพิ่มใหม่ = True , แก้ไข = False
    ''' </summary>
    ''' <remarks></remarks>
    Friend saveCheck As Boolean
    Private Sub ProductDetailEditFrm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        saveCheck = Nothing
        Me.Dispose()
        OnTopFrm()
    End Sub

    Private Sub btuPDaddSaleCompany_Click(sender As Object, e As EventArgs) Handles btuPDaddSaleCompany.Click
        SaleCompanyFrm.ShowDialog(Me)
    End Sub

    Dim Thread1 As System.Threading.Thread
    Private Sub btnPDSerialSave_Click(sender As Object, e As EventArgs) Handles btnPDSerialSave.Click
        If Me.txtPDAddSn.Text <> Nothing Then
            Call addSN()
            Me.txtPDAddSn.Clear()
        End If
    End Sub

    Private Sub txtPDAddSn_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPDAddSn.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtPDAddSn.Text <> Nothing Then
                Call addSN()
                Me.txtPDAddSn.Clear()
            End If
        End If
    End Sub

    Private Sub dgPDserial_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgPDserial.CellMouseClick
        Try
            If Me.dgPDserial.Rows.Count <> 0 Then
                If e.Button = MouseButtons.Right Then
                    Me.dgPDserial.Rows(e.RowIndex).Selected = True
                    Me.dgPDserial.CurrentCell = Me.dgPDserial.Rows(e.RowIndex).Cells(1)
                    Me.DelSNContextMenu.Show(dgPDserial, e.Location)
                    Me.DelSNContextMenu.Show(Cursor.Position)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' So if you wanted to get the row where the metric_value is 1, you could use
    ''' </summary>
    ''' <param name="dgv">dataGridView1.FindValue(1)</param>
    ''' <param name="metric_key"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function FindValue(ByRef dgv As DataGridView, ByVal metric_key As Object) As DataGridViewRow
        For Each row As DataGridViewRow In dgv.Rows
            If row.Cells.Item(0).Value = metric_key Then
                Return row
            End If
        Next
        Return Nothing
    End Function

    Private Sub DelSNToolStripMenu_Click(sender As Object, e As EventArgs) Handles DelSNToolStripMenu.Click
        If MessageBox.Show(Me, "แน่ใจว่าจะลบ SN นี้", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                strSQL = "DELETE FROM product_serial WHERE serial_pro='" & Me.dgPDserial.CurrentRow.Cells(0).Value & "';"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dim del As Integer
                del = cmd.ExecuteNonQuery()
                If del = 1 Then
                    'sum count_num product
                    Try
                        'update count_num product
                        strSQL = "UPDATE product SET count_num=CAST(count_num AS UNSIGNED) - 1 WHERE code_pro='" & Me.txtPDproID.Text & "';"
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()

                        Call ProductDetailFrm.DelSNrows(Me.dgPDserial.CurrentRow.Cells(0).Value)
                        Dim a As Integer = Me.dgPDserial.SelectedRows.Count - 1
                        Me.dgPDserial.Rows.Remove(Me.dgPDserial.SelectedRows(a))
                        Me.dgPDserial.Refresh()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try

                    Try
                        strSQL = "SELECT count_num FROM product WHERE code_pro='" & Me.txtPDproID.Text & "';"
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        Dr = cmd.ExecuteReader
                        Dr.Read()
                        Me.txtPDstockbalance.Text = Dr.Item("count_num")
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                    MessageBox.Show(Me, "ลบข้อมูลแล้ว", "ลบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show(Me, "ลบข้อมูลไม่สำเร็จ", "ลบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
            End Try
            Call ProductDetailFrm.CountSN(Me.txtPDproID.Text)
            Me.lblSNcount.Text = Me.dgPDserial.Rows.Count.ToString("N0") & "/" & ProductDetailFrm.l2.ToString("N0")
        End If
    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        Me.btnForward.Enabled = False
        Call codeproSelect2Next()
        Me.btnForward.Enabled = True
    End Sub

    Private Sub lblSNcount_TextChanged(sender As Object, e As EventArgs) Handles lblSNcount.TextChanged
        If ProductDetailFrm.l2 > Me.NumericUpDown1.Value Then
            Me.btnForward.Enabled = True
        Else
            Me.btnForward.Enabled = False
        End If
    End Sub

    Private Sub RichTextProdetail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RichTextProdetail.KeyPress
        e.Handled = True
        If Me.RichTextProdetail.Enabled = True Then
            ProductRichTextDetailFrm.RichTextBox1.Rtf = Me.RichTextProdetail.Rtf
            ProductRichTextDetailFrm.ShowDialog(Me)
        End If
    End Sub

    Private Sub ListView1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView1.KeyDown
        If e.KeyCode = (e.Shift And Keys.Delete) Then
            If ListView1.SelectedItems.Count > 0 Then
                If MessageBox.Show(Me, "ลบแบบถาวรไม่สามารถนำคืนรูปที่ลบได้อีก ต้องการจะทำต่อหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Try
                        cmd = New MySqlCommand("DELETE FROM picture_all WHERE pa_id='" & ListView1.FocusedItem.ImageKey.ToString & "';", ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                        While ListView1.SelectedItems.Count > 0
                            Dim lvi As ListViewItem = ListView1.SelectedItems(0)
                            ListView1.Items.Remove(lvi)
                        End While
                        ListView1.Refresh()
                    Catch ex As Exception
                        MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
                    End Try
                End If
            End If
        End If

        If e.KeyCode = Keys.Enter Then
            If Me.ListView1.Items.Count > 0 Then
                If ListView1.SelectedItems.Count > 0 Then
                    MainViewPictureFrm.GetPicture(ListView1.FocusedItem.ImageKey.ToString)
                    MainViewPictureFrm.ShowDialog(Me)
                End If
            End If
        End If
    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        If e.Button = MouseButtons.Left Then
            If Me.ListView1.Items.Count > 0 Then
                If ListView1.SelectedItems.Count > 0 Then
                    MainViewPictureFrm.GetPicture(ListView1.FocusedItem.ImageKey.ToString)
                    MainViewPictureFrm.ShowDialog(Me)
                End If
            End If
        End If
    End Sub

    Private Sub DelPicToolStripMenu_Click(sender As Object, e As EventArgs) Handles DelPicToolStripMenu.Click
        Try
            cmd = New MySqlCommand("UPDATE picture_all SET del='yes' WHERE pa_id='" & ListView1.FocusedItem.ImageKey.ToString & "';", ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            While ListView1.SelectedItems.Count > 0
                Dim lvi As ListViewItem = ListView1.SelectedItems(0)
                ListView1.Items.Remove(lvi)
            End While
            ListView1.Refresh()
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - " & Me.GetType().Name & " - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
    End Sub

    Private Sub ListView1_MouseUp(sender As Object, e As MouseEventArgs) Handles ListView1.MouseUp
        If e.Button = MouseButtons.Right Then
            If Me.ListView1.Items.Count > 0 Then
                If ListView1.SelectedItems.Count > 0 Then
                    Me.DelPicContextMenu.Show(ListView1, e.Location)
                End If
            End If
        End If
    End Sub


End Class