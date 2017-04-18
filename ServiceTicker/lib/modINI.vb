Module modINI
    Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
     Alias "WritePrivateProfileStringW" (ByVal lpApplicationName As String, _
     ByVal lpKeyName As String, ByVal lpString As String, _
     ByVal lpFileName As String) As Int32

    Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" _
    Alias "GetPrivateProfileStringW" (ByVal lpApplicationName As String, _
    ByVal lpKeyName As String, ByVal lpDefault As String, _
    ByVal lpReturnedString As String, ByVal nSize As Int32, _
    ByVal lpFileName As String) As Int32
    ''' <summary>
    '''  Write INI File  writeIni(FilePath, Section, ParameterName, Value)
    ''' </summary>
    ''' <param name="iniFileName">File Path</param>
    ''' <param name="Section">Section Name</param>
    ''' <param name="ParamName">Parameter Name</param>
    ''' <param name="ParamVal">Values</param>
    ''' <remarks></remarks>
    Public Sub writeIni(ByVal iniFileName As String, ByVal Section As String, ByVal ParamName As String, ByVal ParamVal As String)
        Dim Result As Integer = WritePrivateProfileString(Section, ParamName, ParamVal, iniFileName)
    End Sub
    ''' <summary>
    ''' Read INI File : TextBox1.Text = ReadIni(FilePath, Section, ParameterName, "")
    ''' </summary>
    ''' <param name="IniFileName">File Path</param>
    ''' <param name="Section">Section Name</param>
    ''' <param name="ParamName">Parameter Name</param>
    ''' <param name="ParamDefault">Return Values</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ReadIni(ByVal IniFileName As String, ByVal Section As String, ByVal ParamName As String, ByVal ParamDefault As String) As String
        Dim ParamVal As String = Space$(1024)
        Dim LenParamVal As Long = GetPrivateProfileString(Section, ParamName, ParamDefault, ParamVal, Len(ParamVal), IniFileName)
        ReadIni = Left$(ParamVal, LenParamVal)
    End Function
End Module
