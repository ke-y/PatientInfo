Option Explicit On

Friend Class dbConnect

    Private _conn As SQLiteConnection
    Private _cmd As SQLiteCommand
    Private _adp As SQLiteDataAdapter

    Friend Sub New()
        _conn = New SQLiteConnection
        _cmd = New SQLiteCommand
        _adp = New SQLiteDataAdapter
    End Sub

    ''' <summary>
    ''' 接続先を指定
    ''' </summary>
    Friend WriteOnly Property setPath() As String
        Set(ByVal value As String)
            _conn.ConnectionString = "DataSource=" & Trim(value)
        End Set
    End Property

    ''' <summary>
    ''' Open処理
    ''' </summary>
    ''' <returns></returns>
    Private Function Open() As Boolean
        Try
            _cmd = _conn.CreateCommand
            _conn.Open()

            Return True
        Catch ex As Exception
        End Try

        Return False
    End Function

    ''' <summary>
    ''' Close処理
    ''' </summary>
    ''' <returns></returns>
    Private Function Close() As Boolean
        Try
            If _conn.State = ConnectionState.Open Then
                _conn.Close()
            End If

            Return True
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try

        Return False
    End Function

    ''' <summary>
    ''' 郵便番号から住所を検索
    ''' </summary>
    ''' <param name="zipCode">郵便番号(XXXYYYY)</param>
    ''' <returns></returns>
    Friend Function getZip(ByVal zipCode As String, ByVal oldAddress As String) As String
        Dim dtTbl = New DataTable
        Dim strSql As String
        Dim ret As String

        ret = ""
        'SQLの実行
        If Open() Then
            strSql = "select ken,shi,machi from zip where zip=" & zipCode
            _adp = New SQLiteDataAdapter(strSql, _conn)
            _adp.Fill(dtTbl)

            If dtTbl.Rows.Count > 0 Then
                For i As Integer = 0 To 2
                    ret = ret & dtTbl.Rows(0).Item(i).ToString
                Next i
            Else
                '検索結果が見つからない場合は、元の住所を保持
                ret = oldAddress
            End If
        End If

        Close()
        dtTbl = Nothing

        Return ret
    End Function

End Class
