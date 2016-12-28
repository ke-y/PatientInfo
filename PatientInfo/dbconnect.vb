Option Explicit On

Friend Class dbconnect

    Private _conn As SQLiteConnection
    Private _cmd As SQLiteCommand
    Private _adp As SQLiteDataAdapter

    Friend Sub New()
        _conn = New SQLiteConnection
        _cmd = New SQLiteCommand
        _adp = New SQLiteDataAdapter
    End Sub

    Friend Sub getZip(ByVal zipCode As String)
        Dim dtTbl = New DataTable
        Dim strSql As String

        '接続パス
        _conn.ConnectionString = "DataSource=D:\sqlite\zip.sqlite"

        'Open処理
        _cmd = _conn.CreateCommand
        _conn.Open()

        'SQLの実行
        If _conn.State <> ConnectionState.Open Then
            dtTbl = Nothing
        Else
            strSql = "select ken,shi,machi from zip where zip=" & zipCode
            _adp = New SQLiteDataAdapter(strSql, _conn)
            _adp.Fill(dtTbl)
        End If

        'Close処理
        _conn.Close()

    End Sub

End Class
