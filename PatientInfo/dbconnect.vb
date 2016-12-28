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

    Friend Sub getZip(ByVal zipCode As String)
        Dim dtTbl = New DataTable
        Dim strSql As String

        'Open処理
        Open()

        'SQLの実行
        If _conn.State <> ConnectionState.Open Then
            dtTbl = Nothing
        Else
            strSql = "select ken,shi,machi from zip where zip=" & zipCode
            _adp = New SQLiteDataAdapter(strSql, _conn)
            _adp.Fill(dtTbl)
        End If

        'Close処理
        Close()

        dtTbl = Nothing
    End Sub

End Class
