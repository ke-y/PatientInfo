Option Explicit On

Public Class patData
    Private _facilityCode As String
    Private _pId As String
    Private _pName_Sei As String
    Private _pName_Mei As String
    Private _pKana_Sei As String
    Private _pKana_Mei As String
    Private _pBirth As String
    Private _pSex As String
    Private _pZip As String
    Private _pAddress As String
    Private _pTel As String
    Private _pHeight As String
    Private _pWeight As String
    Private _pAbo As String
    Private _pRh As String
    Private _currentDate As String

    Public Sub New()
        _facilityCode = "1"
        _pId = "000000"
        _pName_Sei = "TEST"
        _pName_Mei = "001"
        _pKana_Sei = "TEST"
        _pKana_Mei = "001"
        _pBirth = "19001231"
        _pSex = "U"
        _pZip = ""
        _pAddress = ""
        _pTel = ""
        _pHeight = ""
        _pWeight = ""
        _pAbo = ""
        _pRh = ""
        _currentDate = "19000101000000"
    End Sub

    Friend Property facilityCode() As String
        Set(ByVal value As String)
            _facilityCode = value
        End Set
        Get
            Return _facilityCode
        End Get
    End Property

    Friend Property pId() As String
        Set(ByVal value As String)
            _pId = value
        End Set
        Get
            Return _pId
        End Get
    End Property

    Friend ReadOnly Property pId13() As String
        Get
            Return strMid(Me._pId, 1, 3)
        End Get
    End Property

    Friend ReadOnly Property pId46() As String
        Get
            Return strMid(Me._pId, 4, 3)
        End Get
    End Property

    Friend Property pName_Sei() As String
        Set(ByVal value As String)
            _pName_Sei = StrConv(Trim(value), VbStrConv.Uppercase Or VbStrConv.Wide)
        End Set
        Get
            Return _pName_Sei
        End Get
    End Property

    Friend Property pName_Mei() As String
        Set(ByVal value As String)
            _pName_Mei = StrConv(Trim(value), VbStrConv.Uppercase Or VbStrConv.Wide)
        End Set
        Get
            Return _pName_Mei
        End Get
    End Property

    Friend Property pKana_Sei() As String
        Set(ByVal value As String)
            _pKana_Sei = StrConv(Trim(value), VbStrConv.Uppercase Or VbStrConv.Wide)
        End Set
        Get
            Return _pKana_Sei
        End Get
    End Property

    Friend Property pKana_Mei() As String
        Set(ByVal value As String)
            _pKana_Mei = StrConv(Trim(value), VbStrConv.Uppercase Or VbStrConv.Wide)
        End Set
        Get
            Return _pKana_Mei
        End Get
    End Property

    Friend Property pBirth() As String
        Set(ByVal value As String)
            _pBirth = strMid(value, 1, 4) & strMid(value, 6, 2) & strMid(value, 9, 2)
        End Set
        Get
            Return _pBirth
        End Get
    End Property

    Friend Property pSex() As String
        Set(ByVal value As String)
            Select Case Trim(value)
                Case "男"
                    _pSex = "M"
                Case "女"
                    _pSex = "F"
                Case "未知"
                    _pSex = "U"
                Case Else
                    _pSex = "O"
            End Select
        End Set
        Get
            Return _pSex
        End Get
    End Property

    Friend Property pZip() As String
        Set(ByVal value As String)
            _pZip = StrConv(Trim(value), VbStrConv.Narrow)
        End Set
        Get
            Return _pZip
        End Get
    End Property

    Friend Property pAddress() As String
        Set(ByVal value As String)
            _pAddress = StrConv(Trim(value), VbStrConv.Wide)
        End Set
        Get
            Return _pAddress
        End Get
    End Property

    Friend Property pTel() As String
        Set(ByVal value As String)
            _pTel = StrConv(Trim(value), VbStrConv.Narrow)
        End Set
        Get
            Return _pTel
        End Get
    End Property

    Friend Property pHeight() As String
        Set(ByVal value As String)
            _pHeight = StrConv(Trim(value), VbStrConv.Narrow)
        End Set
        Get
            Return _pHeight
        End Get
    End Property

    Friend Property pWeight() As String
        Set(ByVal value As String)
            _pWeight = StrConv(Trim(value), VbStrConv.Narrow)
        End Set
        Get
            Return _pWeight
        End Get
    End Property

    Friend Property pAbo() As String
        Set(ByVal value As String)
            Select Case StrConv(Trim(value), VbStrConv.Narrow)
                Case ""
                    _pAbo = ""
                Case "A"
                    _pAbo = "A"
                Case "B"
                    _pAbo = "B"
                Case "O"
                    _pAbo = "O"
                Case "AB"
                    _pAbo = "AB"
                Case Else
                    _pAbo = "U"
            End Select
        End Set
        Get
            Return _pAbo
        End Get
    End Property

    Friend Property pRh() As String
        Set(ByVal value As String)
            Select Case StrConv(Trim(value), VbStrConv.Narrow)
                Case ""
                    _pRh = ""
                Case "+"
                    _pRh = "+"
                Case "-"
                    _pRh = "-"
                Case Else
                    _pRh = "U"
            End Select
        End Set
        Get
            Return _pRh
        End Get
    End Property

    Friend Property currentDate() As String
        Set(ByVal value As String)
            _currentDate = value
        End Set
        Get
            Return _currentDate
        End Get
    End Property

    Friend ReadOnly Property getMSH() As String
        Get
            Dim str As String

            str = "MSH|^~\&|PatientInfoTool|" & _facilityCode & "|GW|" & _facilityCode & "|" & currentDate & "||ADT^A08^ADT_A01|" & strMid(pId, pId.Length - 6, 6) & currentDate &
                  "|P|2.5||||||~ISO IR87||ISO 2022-1994|SS-MIX2_1.20^SS-MIX2^1.2.392.200250.2.1.100.1.2.120^ISO"

            Return str
        End Get
    End Property

    Friend ReadOnly Property getEVN() As String
        Get
            Dim str As String

            str = "EVN||" & currentDate

            Return str
        End Get
    End Property

    Friend ReadOnly Property getPID() As String
        Get
            Dim str As String

            str = "PID|0001||" & pId & "^^^^PI||" & pName_Sei & "^" & pName_Mei & "^^^^^L^I~" & pKana_Sei & "^" & pKana_Mei & "^^^^^L^P||" &
                  pBirth & "|" & pSex & "|||^^^^" & pZip & "^JPN^H^" & pAddress & "||^PRN^PH^^^^^^^^^" & pTel & "||||||||||||||||||||" & currentDate

            Return str
        End Get
    End Property

    Friend ReadOnly Property getPV1() As String
        Get
            Dim str As String

            str = "PV1|0001|O"

            Return str
        End Get
    End Property

    Friend ReadOnly Property getOBX() As List(Of String)
        Get
            Dim tmpLst As List(Of String) = New List(Of String)
            Dim str As String
            Dim seq As Integer

            seq = 1
            If pHeight <> "" Then
                str = "OBX|" & seq & "|NM|9N001000000000001^身長^JC10||" & pHeight & "|cm^cm^ISO+|||||F"
                tmpLst.Add(str)
                seq = seq + 1
            End If
            If pWeight <> "" Then
                str = "OBX|" & seq & "|NM|9N006000000000001^体重^JC10||" & pWeight & "|kg^kg^ISO+|||||F"
                tmpLst.Add(str)
                seq = seq + 1
            End If
            If pAbo <> "" And pRh <> "" Then
                str = "OBX|" & seq & "|CWE|5H010000001999911^血液型-ABO式^JC10||" & pAbo & "^" & pAbo & "^JSHR002||||||F"
                tmpLst.Add(str)
                seq = seq + 1
                str = "OBX|" & seq & "|CWE|5H020000001999911^血液型-Rh式^JC10||" & pRh & "^" & pRh & "^JSHR002||||||F"
                tmpLst.Add(str)
            End If

            Return tmpLst
        End Get
    End Property

End Class
