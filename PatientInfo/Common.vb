Option Explicit On

Module Common
    ''' <summary>
    ''' 入力内容・形式のチェック
    ''' </summary>
    ''' <param name="obj">コントロール</param>
    ''' <param name="fmt">入力内容(正規表現)</param>
    Friend Sub checkFormat(ByRef obj As Control, ByVal fmt As String)
        Dim regex As Text.RegularExpressions.Regex
        regex = New Text.RegularExpressions.Regex(fmt)

        If obj.Text = "" Then
        Else
            If regex.IsMatch(obj.Text) Then
            Else
                MsgBox("不正な値が入力されています：" & obj.Tag & "=[" & obj.Text & "]")
                obj.Text = ""
            End If
        End If

    End Sub

    ''' <summary>
    ''' ファイルもしくはフォルダが存在するか確認
    ''' </summary>
    ''' <param name="pass">対象データ</param>
    ''' <param name="file">True=ファイル、False=ディレクトリ</param>
    ''' <returns>True/False</returns>
    Friend Function checkExists(ByVal pass As String, ByVal file As Boolean) As Boolean
        If Trim(pass) = "" Then
            checkExists = False
        Else
            If file Then
                checkExists = IO.File.Exists(pass)
            Else
                checkExists = IO.Directory.Exists(pass)
            End If
        End If

        Return checkExists
    End Function

    ''' <summary>
    ''' 文字列から指定された範囲の文字を返す
    ''' </summary>
    ''' <param name="str">対象文字列</param>
    ''' <param name="start">開始位置</param>
    ''' <param name="count">文字数</param>
    ''' <returns>文字列</returns>
    Friend Function strMid(ByVal str As String, ByVal start As Integer, ByVal count As Integer) As String
        If Trim(str) = "" Then
            strMid = ""
        ElseIf str.Length < count Then
            strMid = ""
        Else
            strMid = str.Substring(start - 1, count)
        End If

        Return strMid
    End Function

    ''' <summary>
    ''' ログメッセージ出力
    ''' </summary>
    ''' <param name="pass">LOG出力先フォルダ</param>
    ''' <param name="file">LOGファイル名</param>
    ''' <param name="cmt">出力コメント</param>
    Friend Sub putLog(ByVal pass As String, ByVal file As String, ByVal cmt As String)
        Dim sWrite As IO.StreamWriter

        If Not checkExists(pass, False) Then
            IO.Directory.CreateDirectory(pass)
        End If

        If checkExists(pass & "\" & file, True) Then
            'ファイルがすでにある場合は追記する
            sWrite = New IO.StreamWriter(pass & "\" & file, True, Text.Encoding.GetEncoding("Shift_JIS"))
        Else
            sWrite = New IO.StreamWriter(pass & "\" & file, False, Text.Encoding.GetEncoding("Shift_JIS"))
        End If

        sWrite.WriteLine(Date.Now.ToString("yyyy/MM/dd hh:mm:ss") & " : " & cmt)
        sWrite.Close()
    End Sub
End Module
