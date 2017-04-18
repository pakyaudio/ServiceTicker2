Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Data.SQLite
Imports System.Security.Cryptography
Imports System.Text
Imports System.Configuration
Imports System.Globalization
Imports System.Drawing.Imaging

Module ModuleCode
    ''' <summary>
    ''' ไฟล์พาร์ทสำหรับรีพอร์ต ขนาด A4 Crystal Report , rptPathA4 + "ชื่อรีพอร์ต.rpt"
    ''' </summary>
    ''' <remarks>rptPathA4 + "ชื่อรีพอร์ต.rpt"</remarks>
    Friend rptPathA4 As String = Application.StartupPath & "\Report\A4\"

    ''' <summary>
    ''' ไฟล์พาร์ทสำหรับรีพอร์ต ขนาด A5 Crystal Report , rptPathA5 + "ชื่อรีพอร์ต.rpt"
    ''' </summary>
    ''' <remarks>rptPathA5 + "ชื่อรีพอร์ต.rpt"</remarks>
    Friend rptPathA5 As String = Application.StartupPath & "\Report\A5\"

    ''' <summary>
    ''' ไฟล์พาร์ทสำหรับ ไฟล์คอนฟิก
    ''' </summary>
    ''' <remarks></remarks>
    Friend FileConfigINI_mcode = Application.StartupPath + "\CONFIG.ini"
    Friend server As String = HexToStr(ReadIni(FileConfigINI_mcode, "database_config", "server", ""))
    Friend database As String = HexToStr(ReadIni(FileConfigINI_mcode, "database_config", "data_base_name", ""))
    Friend user As String = HexToStr(ReadIni(FileConfigINI_mcode, "database_config", "data_base_user", ""))
    Friend password As String = HexToStr(ReadIni(FileConfigINI_mcode, "database_config", "data_base_password", ""))
    Friend port As String = HexToStr(ReadIni(FileConfigINI_mcode, "database_config", "data_base_port", ""))
    'connect database
    Public data As String = "Server='" & server & "';Port='" & port & "';Database='" & database & "';Uid='" & user & "';Pwd='" & password & "';Convert Zero Datetime=True;"

    ''' <summary>
    ''' MySqlConnection
    ''' </summary>
    ''' <remarks></remarks>
    Public ConnectionDB As New MySqlConnection(data)
    Dim constrAppconfig As String = "server=" + server + ";Port=" + port + ";user id=" + user + ";password=" + password + ";database=" + database + ";Convert Zero Datetime=True;"

    ''' <summary>
    ''' String สำหรับ MySQL
    ''' </summary>
    ''' <remarks></remarks>
    Public strSQL As String

    ''' <summary>
    ''' MySqlDataAdapter
    ''' </summary>
    ''' <remarks></remarks>
    Public dtAdapter As MySqlDataAdapter

    ''' <summary>
    ''' DataTable Form MySQL
    ''' </summary>
    ''' <remarks></remarks>
    Public dt As DataTable

    ''' <summary>
    ''' DataSet Form MySQL
    ''' </summary>
    ''' <remarks></remarks>
    Public ds As DataSet

    ''' <summary>
    '''  DataRow Form MySQL
    ''' </summary>
    ''' <remarks></remarks>
    Public dRow As DataRow

    ''' <summary>
    ''' MySqlCommand
    ''' </summary>
    ''' <remarks></remarks>
    Public cmd As MySqlCommand

    ''' <summary>
    ''' MySqlDataReader
    ''' </summary>
    ''' <remarks></remarks>
    Public Dr As MySqlDataReader

    ''' <summary>
    ''' DataView From MySQL
    ''' </summary>
    ''' <remarks></remarks>
    Public dv As DataView
    Public saveMess As Integer
    Friend cashSelectDetail As String

    ''' <summary>
    ''' เปิด/ปิด การเชื่อมต่อฐานข้อมูล MySQL อัตโนมัติ 
    ''' </summary>
    ''' <remarks>Call open_connection()</remarks>
    Public Sub open_connection()
        Try
            If ConnectionDB.State = ConnectionState.Open Then ConnectionDB.Close()
            ConnectionDB.Open()
        Catch ex As Exception
            Throw New Exception("การเชื่อมต่อฐานข้อมูลใช้งานไม่ได้ เกิดข้อผิดพลาด : " & ex.Message)
        End Try
    End Sub

    'SQLite connection
    Friend cnn As String = "Data Source=" & Application.StartupPath & "\localdb.db;Version=3;Pooling=True;Synchronous=Off;journal mode=WAL"

    ''' <summary>
    ''' SQLiteConnection
    ''' </summary>
    ''' <remarks></remarks>
    Public connSQLite As New SQLiteConnection(cnn)

    ''' <summary>
    ''' String สำหรับ SQLite
    ''' </summary>
    ''' <remarks></remarks>
    Public strSQLite As String

    ''' <summary>
    ''' SQLiteDataAdapter
    ''' </summary>
    ''' <remarks></remarks>
    Public dtSQLiteAdapter As SQLiteDataAdapter

    ''' <summary>
    '''  DataTable Form SQLite
    ''' </summary>
    ''' <remarks></remarks>
    Public dtSQLite As DataTable

    ''' <summary>
    ''' DataSet Form SQLite
    ''' </summary>
    ''' <remarks></remarks>
    Public dsSQLite As DataSet

    ''' <summary>
    ''' SQLiteCommand
    ''' </summary>
    ''' <remarks></remarks>
    Public cmdSQLite As SQLiteCommand

    ''' <summary>
    ''' SQLiteDataReader
    ''' </summary>
    ''' <remarks></remarks>
    Public DrSQLite As SQLiteDataReader

    ''' <summary>
    ''' เปิด/ปิด การเชื่อมต่อฐานข้อมูล SQLite อัตโนมัติ 
    ''' </summary>
    ''' <remarks>Call open_connectionSQLite()</remarks>
    Public Sub open_connectionSQLite()
        Try
            If connSQLite.State = ConnectionState.Open Then connSQLite.Close()
            connSQLite.Open()
        Catch ex As Exception

        End Try
    End Sub
    ''' <summary>
    ''' ตรวจสอบว่าเป็นวินโดว์ XP หรือไม่ xp=True
    ''' </summary>
    ''' <returns>xp=True</returns>
    ''' <remarks></remarks>
    Friend Function GetOSXP() As Boolean
        Dim osVer As Version = Environment.OSVersion.Version
        If osVer.Major <= 5 Then
            Return True
        ElseIf osVer.Major > 5 Then
            Return False
        Else
            Return True
        End If
    End Function
    ''' <summary>
    ''' เคลียร์ TextBox ทั้งหมดบนหน้าต่างโปรแกรมเท่านั้น
    ''' </summary>
    ''' <param name="frm">Call ClearTextBoxes(From Name)</param>
    ''' <remarks></remarks>
    Public Sub ClearTextBoxes(frm As Form)
        For Each Control In frm.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = Nothing      'Clear all text
            End If
        Next Control
    End Sub

    ''' <summary>
    ''' Disable TextBox ทั้งหมดบนหน้าต่างโปรแกรม 
    ''' </summary>
    ''' <param name="frm">Call disableTextBoxes(From Name)</param>
    ''' <remarks></remarks>
    Public Sub disableTextBoxes(frm As Form)
        For Each Control In frm.Controls
            If TypeOf Control Is TextBox Then
                Control.Enabled = False      'diable all text
            End If
        Next Control
    End Sub

    ''' <summary>
    ''' Enable TextBox ทั้งหมดบนหน้าต่างโปรแกรม 
    ''' </summary>
    ''' <param name="frm">Call enableTextBoxes(From Name)</param>
    ''' <remarks></remarks>
    Public Sub enableTextBoxes(frm As Form)
        For Each Control In frm.Controls
            If TypeOf Control Is TextBox Then
                Control.Enabled = True     'Enabled all text
            End If
        Next Control
    End Sub

    ''' <summary>
    ''' ฟังก์ชั่นแปลงไบต์เป็นรูปภาพ Drawing.Image
    ''' </summary>
    ''' <param name="byteArr">ไบต์ข้อมูล (As Byte)</param>
    ''' <returns>Drawing.Image</returns>
    ''' <remarks></remarks>
    Public Function Byte2Image(ByVal byteArr() As Byte) As Drawing.Image
        Dim ImageStream As New MemoryStream(byteArr)
        Dim newImage As Drawing.Image
        Try
            If byteArr.GetUpperBound(0) > 0 Then
                newImage = System.Drawing.Image.FromStream(ImageStream)
            Else
                newImage = Nothing
            End If
        Catch ex As Exception
            newImage = Nothing
            MainFrm.lblMainStatus.Text = "Error - " & System.Reflection.MethodBase.GetCurrentMethod().Name & " - " & ex.Message
        End Try
        Return newImage
        ImageStream.Close()
    End Function

    ''' <summary>
    ''' แปลงรูปเป็นไบต์ (รูปที่มีในเครื่อง)
    ''' </summary>
    ''' <param name="ImageFilePath">เช่น C:\Images1.jpg</param>
    ''' <returns>As Byte()</returns>
    ''' <remarks></remarks>
    Public Function ConvertImageFiletoBytes(ByVal ImageFilePath As String) As Byte()
        Dim _tempByte() As Byte = Nothing
        If String.IsNullOrEmpty(ImageFilePath) = True Then
            Throw New ArgumentNullException("Image File Name Cannot be Null or Empty", "ImageFilePath")
            Return Nothing
        End If
        Try
            Dim _fileInfo As New IO.FileInfo(ImageFilePath)
            Dim _NumBytes As Long = _fileInfo.Length
            Dim _FStream As New IO.FileStream(ImageFilePath, IO.FileMode.Open, IO.FileAccess.Read)
            Dim _BinaryReader As New IO.BinaryReader(_FStream)
            _tempByte = _BinaryReader.ReadBytes(Convert.ToInt32(_NumBytes))
            _fileInfo = Nothing
            _NumBytes = 0
            _FStream.Close()
            _FStream.Dispose()
            _BinaryReader.Close()
            Return _tempByte
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' เข้ารหัส String To HexDecimal
    ''' </summary>
    ''' <param name="Data">Data As String</param>
    ''' <returns>As String</returns>
    ''' <remarks></remarks>
    Public Function StrToHex(ByRef Data As String) As String
        Dim sVal As String
        Dim sHex As String = ""
        While Data.Length > 0
            sVal = Conversion.Hex(Strings.Asc(Data.Substring(0, 1).ToString()))
            Data = Data.Substring(1, Data.Length - 1)
            sHex = sHex & sVal
        End While
        Return sHex
    End Function

    ''' <summary>
    '''  ถอดรหัส HexDecimal To String
    ''' </summary>
    ''' <param name="Data">As String</param>
    ''' <returns> As String</returns>
    ''' <remarks></remarks>
    Public Function HexToStr(ByVal Data As String) As String
        Dim com As String = String.Empty
        For x = 0 To Data.Length - 1 Step 2
            com &= ChrW(CInt("&H" & Data.Substring(x, 2)))
        Next
        Return com
    End Function

    ''' <summary>
    ''' เข้ารหัส สตริง เป็น base64
    ''' </summary>
    ''' <param name="sData"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function base64Encode(sData)
        Try
            'Dim encData_byte As Byte() = New Byte(sData.Length - 1) {}
            'encData_byte = System.Text.Encoding.UTF8.GetBytes(sData)
            'Dim encodedData As String = Convert.ToBase64String(encData_byte)
            'Return encodedData
            Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(sData)

            ' convert the byte array to a Base64 string

            Dim strModified = Convert.ToBase64String(byt)
            Return strModified
        Catch ex As Exception
            Throw New Exception("Error in base64Encode" + ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' ถอดรหัส จาก base64 เป็น สตริง 
    ''' </summary>
    ''' <param name="sData"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function base64Decode(sData)
        Dim encoder As New System.Text.UTF8Encoding()
        Dim utf8Decode As System.Text.Decoder = encoder.GetDecoder()
        Dim todecode_byte As Byte() = Convert.FromBase64String(sData)
        Dim charCount As Integer = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length)
        Dim decoded_char As Char() = New Char(charCount - 1) {}
        utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0)
        Dim result As String = New [String](decoded_char)
        Return result
    End Function

    'MD5 HAS  Encode
    Friend Function GetHash(theInput) As String
        Using hasher As MD5 = MD5.Create()    ' create hash object
            ' Convert to byte array and get hash
            Dim dbytes As Byte() =
                 hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput))
            ' sb to create string from bytes
            Dim sBuilder As New StringBuilder()
            ' convert byte data to hex string
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n
            Return sBuilder.ToString()
        End Using
    End Function
    'Check HAS
    Friend Function CheckHash(hashedStr, newInput) As Boolean
        ' get the hash value of user input: 
        Dim newHash As String = GetHash(newInput)
        If newHash = hashedStr Then
            Return True
        Else
            Return False
        End If
    End Function
    ''' <summary>
    ''' เช็คข้อมูลซ้ำสำหรับฐานข้อมูล MYSQL, เจอข้อมูลซ้ำ= True , ไม่เจอข้อมูลซ้ำ= False
    ''' </summary>
    ''' <param name="strSQLfuc">MySQL Commend as String Ex. "SELECT Find1 FROM Table1 WHERE Find1='123';"</param>
    ''' <returns>เจอข้อมูลซ้ำ= True , ไม่เจอข้อมูลซ้ำ= False</returns>
    ''' <remarks></remarks>
    Friend Function checkMySQLDruplicateDB(ByVal strSQLfuc As String) As Boolean
        cmd = New MySqlCommand(strSQLfuc, ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader
            Dr.Read()
        Catch ex As Exception
            Return Nothing
        End Try
        If Dr.HasRows Then
            Return True
        Else
            Return False
        End If
    End Function
    ''' <summary>
    ''' เช็คข้อมูลซ้ำสำหรับฐานข้อมูล SQLite, เจอข้อมูลซ้ำ= True , ไม่เจอข้อมูลซ้ำ= False
    ''' </summary>
    ''' <param name="strSQLiteFuc">SQLite Commend as String Ex. "SELECT Find1 FROM Table1 WHERE Find1='123';"</param>
    ''' <returns>เจอข้อมูลซ้ำ= True , ไม่เจอข้อมูลซ้ำ= False</returns>
    ''' <remarks></remarks>
    Friend Function checkSQLiteDruplicateDB(ByVal strSQLiteFuc As String) As Boolean
        cmdSQLite = New SQLiteCommand(strSQLiteFuc, connSQLite)
        Call open_connectionSQLite()
        Try
            DrSQLite = cmdSQLite.ExecuteReader
            DrSQLite.Read()
        Catch ex As Exception
            Return Nothing
        End Try
        If DrSQLite.HasRows Then
            Return True
        Else
            Return False
        End If
    End Function
    ''' <summary>
    ''' นำ RTF String เข้ารหัส UTF8 แปลงเป็นไบต์ Exp. StringRTFtoByte(RichTextProdetail.Rtf)
    ''' </summary>
    ''' <param name="rtfb">RTF String As String</param>
    ''' <returns>As Byte()</returns>
    ''' <remarks></remarks>
    Friend Function StringRTFtoByte(ByVal rtfb As String) As Byte()
        Dim array() As Byte = System.Text.Encoding.UTF8.GetBytes(rtfb)
        Return array
    End Function

    ''' <summary>
    ''' นำไบต์ถอดรหัส UTF8 ทำเป็นสตริงสำหรับ RichTextBox Exp. RichTextProdetail.Rtf = BytetoString(Dr.Item("spec"))
    ''' </summary>
    ''' <param name="brtf">As Byte Array</param>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Friend Function BytetoStringRTF(ByVal brtf As Byte()) As String
        Dim rtfstring As String = System.Text.Encoding.UTF8.GetString(brtf)
        Return rtfstring
    End Function

    Friend Function checkPrinter() As String
        Dim paper As String = ReadIni(FileConfigINI_mcode, "checkPrinter", "paper", "")
        Return paper
    End Function
    ''' <summary>
    ''' ส่ง MainFrm ให้ขึ้นมาด้านหน้าเสมอ กันหน้าต่างโปรแกรมขึ้นมาอยู่หน้า โปรแกรมนี้
    ''' </summary>
    ''' <remarks>Code MainFrm.BringToFront()</remarks>
    Public Sub OnTopFrm()
        MainFrm.BringToFront()
    End Sub


    ''' <summary>
    '''  ลบอักษระเฉพาะในข้อความ
    ''' </summary>
    ''' <param name="input">ข้อความใน TextBox หรืออื่น ๆ As Object</param>
    ''' <returns>As String</returns>
    ''' <remarks></remarks>
    Friend Function strReplacetext(input) As String
        Try
            Dim pattern As String = "[';!#$&'*+/\=?^_`{|}~:]"
            Dim replaced As String = System.Text.RegularExpressions.Regex.Replace(input, pattern, "")
            Return replaced
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    ''' <summary>
    '''  เช่น ส่ง 4 เข้าไป ได้ "0000" กลับมา สูงสุด 19 ตัว น้อยกว่า 4 เกินกว่า 19 จะเท่ากับ "0000"
    ''' </summary>
    ''' <param name="num">ตัวเลข</param>
    ''' <returns>เช่น ส่ง 4 เข้าไป ได้ "0000" กลับมา สูงสุด 19 ตัว น้อยกว่า 4 เกินกว่า 19 จะเท่ากับ "0000"</returns>
    ''' <remarks></remarks>
    Friend Function DocManNumTotal(ByVal num As Integer) As String
        If num = 4 Then
            Return "0000"
        ElseIf num = 5 Then
            Return "00000"
        ElseIf num = 6 Then
            Return "000000"
        ElseIf num = 7 Then
            Return "0000000"
        ElseIf num = 8 Then
            Return "00000000"
        ElseIf num = 9 Then
            Return "000000000"
        ElseIf num = 10 Then
            Return "0000000000"
        ElseIf num = 11 Then
            Return "00000000000"
        ElseIf num = 12 Then
            Return "000000000000"
        ElseIf num = 13 Then
            Return "0000000000000"
        ElseIf num = 14 Then
            Return "00000000000000"
        ElseIf num = 15 Then
            Return "000000000000000"
        ElseIf num = 16 Then
            Return "0000000000000000"
        ElseIf num = 17 Then
            Return "00000000000000000"
        ElseIf num = 18 Then
            Return "000000000000000000"
        ElseIf num = 19 Then
            Return "0000000000000000000"
        Else
            Return "000"
        End If
    End Function

    ''' <summary>
    ''' Get Local Server Times
    ''' </summary>
    ''' <returns>Date Time Format 2017-03-10 09:33:54</returns>
    ''' <remarks>yyyy-MM-dd HH:mm:ss</remarks>
    Friend Function GetLocalServerDateTime()
        'Try
        '    cmd = New MySqlCommand("SELECT DATE_FORMAT(NOW(),'%Y-%m-%d %T') FROM DUAL;", ConnectionDB)
        '    Call open_connection()
        '    Dr = cmd.ExecuteReader
        '    Dr.Read()
        '    Return Dr.Item(0)
        'Catch ex As Exception
        '    Return Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"))
        'End Try
        Return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"))
    End Function

    ''' <summary>
    ''' สุ่มตัวเลข ตัวอักษร 30 ตัว
    ''' </summary>
    ''' <returns>Object</returns>
    ''' <remarks></remarks>
    Friend Function sRnd()
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 30
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function

    ''' <summary>
    '''  บันทึกรูปเข้า INSERT INTO picture_all (MySQL) ; img=รูป As PictureBox, key_id= หมายเลขสำหรับค้นหารูป As String , note= บันทึกช่วยจำหรือ อื่นๆ As String (Optional)
    ''' </summary>
    ''' <param name="img">ByVal img As PictureBox</param>
    ''' <param name="key_id">ByVal key_id As String</param>
    ''' <param name="note">ByVal note As String</param>
    ''' <remarks></remarks>
    Friend Sub SavePictureToDB(ByVal img As PictureBox, ByVal key_id As String, Optional ByVal note As String = "-")
        Try
            Using stream As New IO.MemoryStream
                img.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
                strSQL = "INSERT INTO picture_all(byte_pic,key_pic,note_pic)" _
                    & "VALUES(@byte_pic,@key_pic,@note_pic)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.AddWithValue("@byte_pic", stream.GetBuffer())
                cmd.Parameters.AddWithValue("@key_pic", key_id)
                cmd.Parameters.AddWithValue("@note_pic", note)
                Call open_connection()
                cmd.ExecuteNonQuery()
                stream.Close()
            End Using
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub SavePictureToDB:" & ex.Message
        End Try
    End Sub
    ''' <summary>
    ''' เฉพาะตัวเลขไม่มีจุดทศนิยม ใช้ปุ่ม Delete ได้, ใช้ Backspace ได้ AddHandler CType(TextBox1, TextBox).KeyPress, AddressOf KeyPress_Integer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Friend Sub KeyPress_Integer(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 127 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
    ''' <summary>
    '''  เฉพาะตัวเลขมีจุดทศนิยม 2 ตำแหน่ง ใช้ปุ่ม Delete ได้, ใช้ Backspace ได้ AddHandler CType(TextBox1, TextBox).KeyPress, AddressOf KeyPress_decimal
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Friend Sub KeyPress_decimal(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If sender.Text.Contains(".") Then
                    If sender.Text.Split(".")(1).Length < 2 Then
                        If Char.IsDigit(e.KeyChar) = False Then
                            e.Handled = True
                        End If
                    Else
                        e.Handled = True
                    End If
                End If
            Else
                e.Handled = True
            End If
        End If
    End Sub

    ''' <summary>
    ''' สร้างหมายเลขเอกสารอัตโนมัติ และบันทึกไอดีที่สร้างลงฐานข้อมูลอัตโนมัติ
    ''' </summary>
    ''' <param name="ver">รหัสใบรับซ่อม=ver_fixid,รหัสลูกค้า=ver_cusid,รหัสใบสั่งซื้อ=ver_order,รหัสใบคืนสินค้า=ver_returns,
    ''' รหัสชำระเงิน=ver_cash,รหัสใบเสนอราคา=ver_quotation,รหัสใบเคลมสินค้า=ver_claims,รหัสใบเบิกอะไหล่=ver_PartsWithdrawal,
    ''' รหัสประเภทสินค้า=ver_productsectio,รหัสบาร์โค๊ตสินค้า=ver_barcode,รหัสใบรับเข้าสินค้า=ver_receive,
    ''' เลขที่ใบชำระหนี้ค้างจ่าย/มัดจำ='ver_debtor,เลขที่ใบเสร็จรับเงิน/ใบกำกับภาษี=ver_cashinvoice,รหัสผู้ใช้งาน=ver_user,
    ''' รหัสประจำเครื่องรับซ่อม=ver_sn,รหัสล็อตส่งเคลม=ver_claimsid,รหัสสินค้า=ver_productid</param>
    ''' <param name="OutID">ไอดีออกเป็นสตริง As String</param>
    ''' <remarks>ตัวอย่าง Call ALLAutonumber(ver_cusid, Me.TextBox1.Text)</remarks>
    Friend Sub ALLAutonumber(ByVal ver As String, ByRef OutID As String)
        OutID = String.Empty
        Dim ver_detail As String = String.Empty
        Dim Format As String = String.Empty
        Dim dat As String = String.Empty
        Dim num_total As String = String.Empty
        Dim MAXid As Integer = Nothing
        Dim newid As String = String.Empty
        Dim y_reset As Integer = Nothing
        strSQL = "SELECT ver_detail,format,num_total,ver_name,dat,y_reset FROM ver_name WHERE ver='" & ver & "'"
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        Try
            Dr = cmd.ExecuteReader
            Dr.Read()
            Try
                ver_detail = Dr.Item("ver_detail")
            Catch ex As Exception
                ver_detail = Nothing
            End Try
            Try
                Format = Dr.Item("format")
            Catch ex As Exception
                Format = DateTime.Now.ToString("yyyyMMdd", CultureInfo.CreateSpecificCulture("en-US"))
            End Try
            Try
                num_total = DocManNumTotal(Dr.GetUInt64("num_total"))
            Catch ex As Exception
                num_total = Nothing
            End Try
            Try
                dat = Dr.Item("dat")
            Catch ex As Exception
                dat = Nothing
            End Try

            Try
                y_reset = Dr.Item("y_reset")
            Catch ex As Exception
                y_reset = 0
            End Try
        Catch ex As Exception
            MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber - Select ver:" & ex.Message
        End Try

        If ver = "ver_cusid" Then
            'แก้ไขแล้ว 
            Try
                strSQL = "SELECT `ID`,datetime_save FROM customer_id ORDER BY datetime_save DESC LIMIT 1;"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    Dr.Read()
                    Dim DByear As Date = Dr.GetDateTime("datetime_save")
                    Dim Nowyear As Date = Now
                    If y_reset = 1 Then
                        If Nowyear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) > DByear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) Then
                            MAXid = 1
                        Else
                            MAXid = Dr.Item("ID")
                            MAXid += 1
                        End If
                    Else
                        MAXid = Dr.Item("ID")
                        MAXid += 1
                    End If
                Else
                    MAXid = 1
                End If
                newid = ver_detail & Now.ToString(Format) & dat & MAXid.ToString(num_total)
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_cusid - " & ex.Message
            End Try

            Try
                strSQL = "INSERT INTO customer_id(`ID`,customer_id,datetime_save)VALUES(@ID,@customer_id,@datetime_save);"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.AddWithValue("@ID", MAXid)
                cmd.Parameters.AddWithValue("@customer_id", newid)
                cmd.Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")))
                Call open_connection()
                cmd.ExecuteReader()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_cusid - " & ex.Message
            End Try

        ElseIf ver = "ver_user" Then
            'แก้ไขแล้ว 
            Try
                strSQL = "SELECT `ID`,datetime_save FROM users_id ORDER BY datetime_save DESC LIMIT 1;"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    Dr.Read()
                    Dim DByear As Date = Dr.GetDateTime("datetime_save")
                    Dim Nowyear As Date = Now
                    If y_reset = 1 Then
                        If Nowyear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) > DByear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) Then
                            MAXid = 1
                        Else
                            MAXid = Dr.Item("ID")
                            MAXid += 1
                        End If
                    Else
                        MAXid = Dr.Item("ID")
                        MAXid += 1
                    End If
                Else
                    MAXid = 1
                End If
                newid = ver_detail & Now.ToString(Format) & dat & MAXid.ToString(num_total)
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_user - " & ex.Message
            End Try

            Try
                strSQL = "INSERT INTO users_id(`ID`,user_id,datetime_save)VALUES(@ID,@user_id,@datetime_save);"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.AddWithValue("@ID", MAXid)
                cmd.Parameters.AddWithValue("@user_id", newid)
                cmd.Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")))
                Call open_connection()
                cmd.ExecuteReader()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_user - " & ex.Message
            End Try
        ElseIf ver = "ver_fixid" Then
            'แก้ไขแล้ว 
            Try
                strSQL = "SELECT id,datetime_save FROM comfix_id ORDER BY datetime_save DESC LIMIT 1;"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    Dr.Read()
                    Dim DByear As Date = Dr.GetDateTime("datetime_save")
                    Dim Nowyear As Date = Now
                    If y_reset = 1 Then
                        If Nowyear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) > DByear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) Then
                            MAXid = 1
                        Else
                            MAXid = Dr.Item("id")
                            MAXid += 1
                        End If
                    Else
                        MAXid = Dr.Item("id")
                        MAXid += 1
                    End If
                Else
                    MAXid = 1
                End If
                newid = ver_detail & Now.ToString(Format) & dat & MAXid.ToString(num_total)
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_fixid - " & ex.Message
            End Try

            Try
                strSQL = "INSERT INTO comfix_id(id,fix_id,datetime_save)VALUES(@id,@fix_id,@datetime_save);"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.AddWithValue("@id", MAXid)
                cmd.Parameters.AddWithValue("@fix_id", newid)
                cmd.Parameters.AddWithValue("@datetime_save", GetLocalServerDateTime)
                Call open_connection()
                cmd.ExecuteReader()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_fixid - " & ex.Message
            End Try
        ElseIf ver = "ver_sn" Then
            'แก้ไขแล้ว 
            Try
                strSQL = "SELECT `id`,datetime_save FROM sn_id ORDER BY datetime_save DESC LIMIT 1;"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    Dr.Read()
                    Dim DByear As Date = Dr.GetDateTime("datetime_save")
                    Dim Nowyear As Date = Now
                    If y_reset = 1 Then
                        If Nowyear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) > DByear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) Then
                            MAXid = 1
                        Else
                            MAXid = Dr.Item("id")
                            MAXid += 1
                        End If
                    Else
                        MAXid = Dr.Item("id")
                        MAXid += 1
                    End If
                Else
                    MAXid = 1
                End If
                newid = ver_detail & Now.ToString(Format) & dat & MAXid.ToString(num_total)
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_sn - " & ex.Message
            End Try

            Try
                strSQL = "INSERT INTO sn_id(id,sn_id,datetime_save)VALUES(@id,@sn_id,@datetime_save);"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.AddWithValue("@id", MAXid)
                cmd.Parameters.AddWithValue("@sn_id", newid)
                cmd.Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")))
                Call open_connection()
                cmd.ExecuteReader()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_sn - " & ex.Message
            End Try
        ElseIf ver = "ver_debtor" Then
            'แก้ไขแล้ว 
            Try
                strSQL = "SELECT `ID`,datetime_save FROM pledge_id ORDER BY datetime_save DESC LIMIT 1;"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    Dr.Read()
                    Dim DByear As Date = Dr.GetDateTime("datetime_save")
                    Dim Nowyear As Date = Now
                    If y_reset = 1 Then
                        If Nowyear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) > DByear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) Then
                            MAXid = 1
                        Else
                            MAXid = Dr.Item("id")
                            MAXid += 1
                        End If
                    Else
                        MAXid = Dr.Item("id")
                        MAXid += 1
                    End If
                Else
                    MAXid = 1
                End If
                newid = ver_detail & Now.ToString(Format) & dat & MAXid.ToString(num_total)
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_debtor - " & ex.Message
            End Try

            Try
                strSQL = "INSERT INTO pledge_id(`ID`,pl_id,datetime_save)VALUES(@ID,@pl_id,@datetime_save);"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.AddWithValue("@ID", MAXid)
                cmd.Parameters.AddWithValue("@pl_id", newid)
                cmd.Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")))
                Call open_connection()
                cmd.ExecuteReader()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_debtor - " & ex.Message
            End Try
        ElseIf ver = "ver_cash" Then
            'แก้ไขแล้ว 
            Try
                strSQL = "SELECT `ID`,datetime_save FROM cash_id ORDER BY datetime_save DESC LIMIT 1;"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    Dr.Read()
                    Dim DByear As Date = Dr.GetDateTime("datetime_save")
                    Dim Nowyear As Date = Now
                    If y_reset = 1 Then
                        If Nowyear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) > DByear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) Then
                            MAXid = 1
                        Else
                            MAXid = Dr.Item("id")
                            MAXid += 1
                        End If
                    Else
                        MAXid = Dr.Item("id")
                        MAXid += 1
                    End If
                Else
                    MAXid = 1
                End If
                newid = ver_detail & Now.ToString(Format) & dat & MAXid.ToString(num_total)
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_cash - " & ex.Message
            End Try

            Try
                strSQL = "INSERT INTO cash_id(`ID`,cash_id,datetime_save)VALUES(@ID,@cash_id,@datetime_save);"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.AddWithValue("@ID", MAXid)
                cmd.Parameters.AddWithValue("@cash_id", newid)
                cmd.Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")))
                Call open_connection()
                cmd.ExecuteReader()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_cash - " & ex.Message
            End Try
        ElseIf ver = "ver_order" Then
            'แก้ไขแล้ว 
            Try
                strSQL = "SELECT `ID`,datetime_save FROM buy_id ORDER BY datetime_save DESC LIMIT 1;"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    Dr.Read()
                    Dim DByear As Date = Dr.GetDateTime("datetime_save")
                    Dim Nowyear As Date = Now
                    If y_reset = 1 Then
                        If Nowyear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) > DByear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) Then
                            MAXid = 1
                        Else
                            MAXid = Dr.Item("id")
                            MAXid += 1
                        End If
                    Else
                        MAXid = Dr.Item("id")
                        MAXid += 1
                    End If
                Else
                    MAXid = 1
                End If
                newid = ver_detail & Now.ToString(Format) & dat & MAXid.ToString(num_total)
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_order - " & ex.Message
            End Try

            Try
                strSQL = "INSERT INTO buy_id(`ID`,buy_id,datetime_save)VALUES(@ID,@buy_id,@datetime_save);"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.AddWithValue("@ID", MAXid)
                cmd.Parameters.AddWithValue("@buy_id", newid)
                cmd.Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")))
                Call open_connection()
                cmd.ExecuteReader()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_order - " & ex.Message
            End Try
        ElseIf ver = "ver_receive" Then
            'แก้ไขแล้ว 
            Try
                strSQL = "SELECT `ID`,datetime_save FROM receive_id ORDER BY datetime_save DESC LIMIT 1;"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    Dr.Read()
                    Dim DByear As Date = Dr.GetDateTime("datetime_save")
                    Dim Nowyear As Date = Now
                    If y_reset = 1 Then
                        If Nowyear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) > DByear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) Then
                            MAXid = 1
                        Else
                            MAXid = Dr.Item("id")
                            MAXid += 1
                        End If
                    Else
                        MAXid = Dr.Item("id")
                        MAXid += 1
                    End If
                Else
                    MAXid = 1
                End If
                newid = ver_detail & Now.ToString(Format) & dat & MAXid.ToString(num_total)
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_receive - " & ex.Message
            End Try

            Try
                strSQL = "INSERT INTO receive_id(`ID`,receive_id,datetime_save)VALUES(@ID,@receive_id,@datetime_save);"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.AddWithValue("@ID", MAXid)
                cmd.Parameters.AddWithValue("@receive_id", newid)
                cmd.Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")))
                Call open_connection()
                cmd.ExecuteReader()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_receive - " & ex.Message
            End Try
        ElseIf ver = "ver_PartsWithdrawal" Then
            'แก้ไขแล้ว 
            Try
                strSQL = "SELECT `ID`,datetime_save FROM sale_id ORDER BY datetime_save DESC LIMIT 1;"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    Dr.Read()
                    Dim DByear As Date = Dr.GetDateTime("datetime_save")
                    Dim Nowyear As Date = Now
                    If y_reset = 1 Then
                        If Nowyear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) > DByear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) Then
                            MAXid = 1
                        Else
                            MAXid = Dr.Item("id")
                            MAXid += 1
                        End If
                    Else
                        MAXid = Dr.Item("id")
                        MAXid += 1
                    End If
                Else
                    MAXid = 1
                End If
                newid = ver_detail & Now.ToString(Format) & dat & MAXid.ToString(num_total)
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_PartsWithdrawal - " & ex.Message
            End Try

            Try
                strSQL = "INSERT INTO sale_id(`ID`,sale_id,fix_id,customer_id,customer_name,date_in,datetime_save) " _
                           & " VALUES(@ID,@sale_id,@fix_id,@customer_id,@customer_name,@date_in,@datetime_save)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.AddWithValue("@ID", MAXid)
                    .Parameters.AddWithValue("@sale_id", newid)
                    .Parameters.AddWithValue("@fix_id", "N/A")
                    .Parameters.AddWithValue("@customer_id", "N/A")
                    .Parameters.AddWithValue("@customer_name", "N/A")
                    .Parameters.AddWithValue("@date_in", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss",
                                                                                               CultureInfo.CreateSpecificCulture("en-US")))
                    .Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss",
                                                                                               CultureInfo.CreateSpecificCulture("en-US")))
                End With
                Call open_connection()
                cmd.ExecuteReader()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_PartsWithdrawal - " & ex.Message
            End Try
        ElseIf ver = "ver_returns" Then
            'แก้ไขแล้ว 
            Try
                strSQL = "SELECT `ID`,datetime_save FROM returnproduct_id ORDER BY datetime_save DESC LIMIT 1;"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    Dr.Read()
                    Dim DByear As Date = Dr.GetDateTime("datetime_save")
                    Dim Nowyear As Date = Now
                    If y_reset = 1 Then
                        If Nowyear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) > DByear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) Then
                            MAXid = 1
                        Else
                            MAXid = Dr.Item("id")
                            MAXid += 1
                        End If
                    Else
                        MAXid = Dr.Item("id")
                        MAXid += 1
                    End If
                Else
                    MAXid = 1
                End If
                newid = ver_detail & Now.ToString(Format) & dat & MAXid.ToString(num_total)
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_returns - " & ex.Message
            End Try

            Try
                strSQL = "INSERT INTO returnproduct_id(`ID`,return_id,datetime_save) " _
                           & " VALUES(@ID,@return_id,@datetime_save)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.AddWithValue("@ID", MAXid)
                    .Parameters.AddWithValue("@return_id", newid)
                    .Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss",
                                                                                               CultureInfo.CreateSpecificCulture("en-US")))
                End With
                Call open_connection()
                cmd.ExecuteReader()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_returns - " & ex.Message
            End Try
        ElseIf ver = "ver_claims" Then
            'แก้ไขแล้ว 
            Try
                strSQL = "SELECT `id`,datetime_save FROM claims_id ORDER BY datetime_save DESC LIMIT 1;"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    Dr.Read()
                    Dim DByear As Date = Dr.GetDateTime("datetime_save")
                    Dim Nowyear As Date = Now
                    If y_reset = 1 Then
                        If Nowyear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) > DByear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) Then
                            MAXid = 1
                        Else
                            MAXid = Dr.Item("id")
                            MAXid += 1
                        End If
                    Else
                        MAXid = Dr.Item("id")
                        MAXid += 1
                    End If
                Else
                    MAXid = 1
                End If
                newid = ver_detail & Now.ToString(Format) & dat & MAXid.ToString(num_total)
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_claims - " & ex.Message
            End Try

            Try
                strSQL = "INSERT INTO claims_id(`id`,claims_id,datetime_save) " _
                           & " VALUES(@id,@claims_id,@datetime_save)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.AddWithValue("@id", MAXid)
                    .Parameters.AddWithValue("@claims_id", newid)
                    .Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss",                                                                       CultureInfo.CreateSpecificCulture("en-US")))
                End With
                Call open_connection()
                cmd.ExecuteReader()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_claims - " & ex.Message
            End Try
        ElseIf ver = "ver_claimsid" Then
            'แก้ไขแล้ว 
            Try
                strSQL = "SELECT `id`,datetime_save FROM claims_lot_id ORDER BY datetime_save DESC LIMIT 1;"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    Dr.Read()
                    Dim DByear As Date = Dr.GetDateTime("datetime_save")
                    Dim Nowyear As Date = Now
                    If y_reset = 1 Then
                        If Nowyear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) > DByear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) Then
                            MAXid = 1
                        Else
                            MAXid = Dr.Item("id")
                            MAXid += 1
                        End If
                    Else
                        MAXid = Dr.Item("id")
                        MAXid += 1
                    End If
                Else
                    MAXid = 1
                End If
                newid = ver_detail & Now.ToString(Format) & dat & MAXid.ToString(num_total)
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_claimsid - " & ex.Message
            End Try

            Try
                strSQL = "INSERT INTO claims_lot_id(`id`,claims_lot,datetime_save) " _
                           & " VALUES(@id,@claims_lot,@datetime_save)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.AddWithValue("@id", MAXid)
                    .Parameters.AddWithValue("@claims_lot", newid)
                    .Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss",
                                                                                               CultureInfo.CreateSpecificCulture("en-US")))
                End With
                Call open_connection()
                cmd.ExecuteReader()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_claimsid - " & ex.Message
            End Try
        ElseIf ver = "ver_productsectio" Then
            'แก้ไขแล้ว 
            Try
                strSQL = "SELECT `id`,datetime_save FROM product_section_id ORDER BY datetime_save DESC LIMIT 1;"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    Dr.Read()
                    Dim DByear As Date = Dr.GetDateTime("datetime_save")
                    Dim Nowyear As Date = Now
                    If y_reset = 1 Then
                        If Nowyear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) > DByear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) Then
                            MAXid = 1
                        Else
                            MAXid = Dr.Item("id")
                            MAXid += 1
                        End If
                    Else
                        MAXid = Dr.Item("id")
                        MAXid += 1
                    End If
                Else
                    MAXid = 1
                End If
                newid = ver_detail & Now.ToString(Format) & dat & MAXid.ToString(num_total)
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_productsectio - " & ex.Message
            End Try

            Try
                strSQL = "INSERT INTO product_section_id(`ID`,prosection_id,datetime_save) " _
                           & " VALUES(@ID,@prosection_id,@datetime_save)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.AddWithValue("@ID", MAXid)
                    .Parameters.AddWithValue("@prosection_id", newid)
                    .Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss",
                                                                                               CultureInfo.CreateSpecificCulture("en-US")))
                End With
                Call open_connection()
                cmd.ExecuteReader()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_productsectio - " & ex.Message
            End Try
        ElseIf ver = "ver_productid" Then
            'แก้ไขแล้ว 
            Try
                strSQL = "SELECT `id`,datetime_save FROM product_id ORDER BY datetime_save DESC LIMIT 1;"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    Dr.Read()
                    Dim DByear As Date = Dr.GetDateTime("datetime_save")
                    Dim Nowyear As Date = Now
                    If y_reset = 1 Then
                        If Nowyear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) > DByear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) Then
                            MAXid = 1
                        Else
                            MAXid = Dr.Item("id")
                            MAXid += 1
                        End If
                    Else
                        MAXid = Dr.Item("id")
                        MAXid += 1
                    End If
                Else
                    MAXid = 1
                End If
                newid = ver_detail & Now.ToString(Format) & dat & MAXid.ToString(num_total)
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_productid - " & ex.Message
            End Try

            Try
                strSQL = "INSERT INTO product_id(`ID`,code_pro,bar_code,name_pro,datetime_save) " _
                           & " VALUES(@ID,@code_pro,@bar_code,@name_pro,@datetime_save)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.AddWithValue("@ID", MAXid)
                    .Parameters.AddWithValue("@code_pro", newid)
                    .Parameters.AddWithValue("@bar_code", "-")
                    .Parameters.AddWithValue("@name_pro", "-")
                    .Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss",
                                                                                               CultureInfo.CreateSpecificCulture("en-US")))
                End With
                Call open_connection()
                cmd.ExecuteReader()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_productid - " & ex.Message
            End Try

        ElseIf ver = "ver_barcode" Then
            'แก้ไขแล้ว 
            Try
                strSQL = "SELECT `id`,datetime_save FROM barcode_id ORDER BY datetime_save DESC LIMIT 1;"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    Dr.Read()
                    Dim DByear As Date = Dr.GetDateTime("datetime_save")
                    Dim Nowyear As Date = Now
                    If y_reset = 1 Then
                        If Nowyear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) > DByear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) Then
                            MAXid = 1
                        Else
                            MAXid = Dr.Item("id")
                            MAXid += 1
                        End If
                    Else
                        MAXid = Dr.Item("id")
                        MAXid += 1
                    End If
                Else
                    MAXid = 1
                End If
                newid = ver_detail & Now.ToString(Format) & dat & MAXid.ToString(num_total)
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_productid - " & ex.Message
            End Try

            Try
                strSQL = "INSERT INTO barcode_id(`id`,barcode_id,datetime_save) " _
                           & " VALUES(@id,@barcode_id,@datetime_save)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.AddWithValue("@id", MAXid)
                    .Parameters.AddWithValue("@barcode_id", newid)
                    .Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss",
                                                                                               CultureInfo.CreateSpecificCulture("en-US")))
                End With
                Call open_connection()
                cmd.ExecuteReader()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_barcode - " & ex.Message
            End Try
        ElseIf ver = "ver_cashinvoice" Then
            'แก้ไขแล้ว 
            Try
                strSQL = "SELECT `id`,datetime_save FROM taxinvoice_id ORDER BY datetime_save DESC LIMIT 1;"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    Dr.Read()
                    Dim DByear As Date = Dr.GetDateTime("datetime_save")
                    Dim Nowyear As Date = Now
                    If y_reset = 1 Then
                        If Nowyear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) > DByear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) Then
                            MAXid = 1
                        Else
                            MAXid = Dr.Item("id")
                            MAXid += 1
                        End If
                    Else
                        MAXid = Dr.Item("id")
                        MAXid += 1
                    End If
                Else
                    MAXid = 1
                End If
                newid = ver_detail & Now.ToString(Format) & dat & MAXid.ToString(num_total)
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_cashinvoice - " & ex.Message
            End Try

            Try
                strSQL = "INSERT INTO taxinvoice_id(`id`,ti_id,datetime_save) " _
                           & " VALUES(@id,@ti_id,@datetime_save)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.AddWithValue("@id", MAXid)
                    .Parameters.AddWithValue("@ti_id", newid)
                    .Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss",
                                                                                               CultureInfo.CreateSpecificCulture("en-US")))
                End With
                Call open_connection()
                cmd.ExecuteReader()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_cashinvoice - " & ex.Message
            End Try
        ElseIf ver = "ver_quotation" Then
            'แก้ไขแล้ว 
            Try
                strSQL = "SELECT `id`,datetime_save FROM quotation_id ORDER BY datetime_save DESC LIMIT 1;"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    Dr.Read()
                    Dim DByear As Date = Dr.GetDateTime("datetime_save")
                    Dim Nowyear As Date = Now
                    If y_reset = 1 Then
                        If Nowyear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) > DByear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) Then
                            MAXid = 1
                        Else
                            MAXid = Dr.Item("id")
                            MAXid += 1
                        End If
                    Else
                        MAXid = Dr.Item("id")
                        MAXid += 1
                    End If
                Else
                    MAXid = 1
                End If
                newid = ver_detail & Now.ToString(Format) & dat & MAXid.ToString(num_total)
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_cashinvoice - " & ex.Message
            End Try

            Try
                strSQL = "INSERT INTO quotation_id(`id`,q_id,datetime_save) " _
                           & " VALUES(@id,@q_id,@datetime_save)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.AddWithValue("@id", MAXid)
                    .Parameters.AddWithValue("@q_id", newid)
                    .Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss",
                                                                                               CultureInfo.CreateSpecificCulture("en-US")))
                End With
                Call open_connection()
                cmd.ExecuteReader()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_quotation - " & ex.Message
            End Try
        ElseIf ver = "ver_invoice" Then
            'แก้ไขแล้ว 
            Try
                strSQL = "SELECT `id`,datetime_save FROM invoice_id ORDER BY datetime_save DESC LIMIT 1;"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    Dr.Read()
                    Dim DByear As Date = Dr.GetDateTime("datetime_save")
                    Dim Nowyear As Date = Now
                    If y_reset = 1 Then
                        If Nowyear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) > DByear.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US")) Then
                            MAXid = 1
                        Else
                            MAXid = Dr.Item("id")
                            MAXid += 1
                        End If
                    Else
                        MAXid = Dr.Item("id")
                        MAXid += 1
                    End If
                Else
                    MAXid = 1
                End If
                newid = ver_detail & Now.ToString(Format) & dat & MAXid.ToString(num_total)
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_invoice - " & ex.Message
            End Try

            Try
                strSQL = "INSERT INTO invoice_id(`id`,ti_id,datetime_save) " _
                           & " VALUES(@id,@ti_id,@datetime_save)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.AddWithValue("@id", MAXid)
                    .Parameters.AddWithValue("@ti_id", newid)
                    .Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss",
                                                                                               CultureInfo.CreateSpecificCulture("en-US")))
                End With
                Call open_connection()
                cmd.ExecuteReader()
            Catch ex As Exception
                MainFrm.lblMainStatus.Text = "Error - ModuleCode Sub ALLAutonumber-ver_invoice - " & ex.Message
            End Try
        End If

        OutID = newid
    End Sub
End Module
