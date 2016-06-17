Option Explicit On

Friend Class envData
    Private _appPath As String
    Private _appIni As String
    Private _appLog As String
    Private _root As String
    Private _editorPath As String
    Private _direct As Boolean
    Private _pId_len As Integer
    Private _pId_chr As Char

    Friend Sub New()
        _appPath = "C:\PatientInfo"
        _appIni = "\conf\PatientInfo.ini"
        _appLog = "\log"
        _root = "C:\PatientInfo\root"
        _editorPath = "C:\Windows\System32\notepad.exe"
        _direct = False
        _pId_len = 6
        _pId_chr = "0"
    End Sub

    ''' <summary>
    ''' アプリ配置先フォルダ
    ''' </summary>
    ''' <returns></returns>
    Friend ReadOnly Property appPath() As String
        Get
            Return _appPath
        End Get
    End Property

    ''' <summary>
    ''' INIファイル名
    ''' </summary>
    ''' <returns></returns>
    Friend ReadOnly Property appIni() As String
        Get
            Return _appIni
        End Get
    End Property

    Friend ReadOnly Property appLog() As String
        Get
            Return _appLog
        End Get
    End Property

    ''' <summary>
    ''' HL7データ出力先ROOTフォルダ
    ''' </summary>
    ''' <returns></returns>
    Friend Property root() As String
        Set(ByVal value As String)
            _root = value
        End Set
        Get
            Return _root
        End Get
    End Property

    ''' <summary>
    ''' エディタ
    ''' </summary>
    ''' <returns></returns>
    Friend Property editorPath() As String
        Set(ByVal value As String)
            _editorPath = value
        End Set
        Get
            Return _editorPath
        End Get
    End Property

    ''' <summary>
    ''' ROOT配下に直接出力
    ''' </summary>
    ''' <returns>True/False</returns>
    Friend Property direct As Boolean
        Set(ByVal value As Boolean)
            _direct = value
        End Set
        Get
            Return _direct
        End Get
    End Property

    ''' <summary>
    ''' 患者IDの桁数
    ''' </summary>
    ''' <returns></returns>
    Friend Property pIdlen() As Integer
        Set(ByVal value As Integer)
            _pId_len = value
        End Set
        Get
            Return _pId_len
        End Get
    End Property

    ''' <summary>
    ''' 患者IDの桁埋め文字
    ''' </summary>
    ''' <returns></returns>
    Friend Property pIdchr() As Char
        Set(ByVal value As Char)
            _pId_chr = value
        End Set
        Get
            Return _pId_chr
        End Get
    End Property

End Class
