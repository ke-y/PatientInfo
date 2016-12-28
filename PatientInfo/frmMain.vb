Option Explicit On

Public Class frmMain
    Private patInfo As New patData
    Private patEnv As New envData
    Private zipData As New dbconnect

    ''' <summary>
    ''' メニュー：最前面に表示
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub menuForeDisp_Click(sender As Object, e As EventArgs) Handles menuForeDisp.Click
        putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Change TopMost value")

        If menuForeDisp.Checked Then
            TopMost = True
        Else
            TopMost = False
        End If
    End Sub

    ''' <summary>
    ''' メニュー：表示内容のクリア
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub menuPatClear_Click(sender As Object, e As EventArgs) Handles menuPatClear.Click
        clearPat()
    End Sub

    ''' <summary>
    ''' メニュー：バージョン
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub menuVersion_Click(sender As Object, e As EventArgs) Handles menuVersion.Click
        Dim frm As New frmVersion()

        putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Disp Version")

        frm.ShowDialog(Me)
        frm.Dispose()
    End Sub

    ''' <summary>
    ''' メニュー：iniファイルを開く
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub menuOpenIni_Click(sender As Object, e As EventArgs) Handles menuOpenIni.Click
        openIni()
    End Sub

    ''' <summary>
    ''' メニュー：iniファイルを読み込む
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub menuReadIni_Click(sender As Object, e As EventArgs) Handles menuReadIni.Click
        readIni()
        clearPat()
        setIni()
    End Sub

    ''' <summary>
    ''' メニュー：終了
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub menuEnd_Click(sender As Object, e As EventArgs) Handles menuEnd.Click
        putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "End System")

        Close()
    End Sub

    ''' <summary>
    ''' 起動時処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Start System")

        Text = Application.ProductName & " - MAIN"

        'iniファイルの読み込み
        readIni()

        '入力画面の制御
        clearPat()
        setIni()
    End Sub

    ''' <summary>
    ''' 終了時処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "End System")

        Close()
    End Sub

    ''' <summary>
    '''入力内容をクリア
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearPat()
    End Sub

    ''' <summary>
    ''' ROOTフォルダを開く
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnOpenRoot_Click(sender As Object, e As EventArgs) Handles btnOpenRoot.Click
        putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Open the Root Dir")

        Process.Start(patEnv.root)
    End Sub

    ''' <summary>
    ''' 郵便番号から住所を検索
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnZip_Click(sender As Object, e As EventArgs) Handles btnZip.Click
        putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Search the Address from ZIP CODE")

        zipData.getZip(strMid(txtZip.Text, 1, 3) & strMid(txtZip.Text, 5, 4))
    End Sub

    ''' <summary>
    ''' HL7データを作成
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnMake_Click(sender As Object, e As EventArgs) Handles btnMake.Click
        Dim sWrite As IO.StreamWriter
        Dim dtNow As Date = Date.Now
        Dim regex As Text.RegularExpressions.Regex
        Dim lstError As List(Of String) = New List(Of String)
        Dim lstOutput As List(Of String) = New List(Of String)
        Dim oldData() As String
        Dim dataDir As String
        Dim dataFile As String
        Dim fmt As String
        Dim rename As String
        Dim i As Integer

        putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Start HL7 file making")

        '必須入力チェック
        lstError = requiredInput()
        If lstError.Count <> 0 Then
            For i = 0 To lstError.Count - 1
                MsgBox(lstError.Item(i))
            Next
            Exit Sub
        End If

        '画面入力項目をセット
        putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Set the input item")
        patInfo.pId = txtPid.Text
        patInfo.pKana_Sei = txtPkana_Sei.Text
        patInfo.pKana_Mei = txtPkana_Mei.Text
        patInfo.pName_Sei = txtPname_Sei.Text
        patInfo.pName_Mei = txtPname_Mei.Text
        patInfo.pBirth = timPbirth.Text
        patInfo.pSex = cmbPsex.Text
        patInfo.pZip = txtZip.Text
        patInfo.pTel = txtTel.Text
        patInfo.pAddress = Trim(txtAddress1.Text) & " " & Trim(txtAddress2.Text)
        patInfo.pHeight = txtHeight.Text
        patInfo.pWeight = txtWeight.Text
        patInfo.pAbo = cmbAbo.Text
        patInfo.pRh = cmbRh.Text
        patInfo.currentDate = dtNow.ToString("yyyyMMddHHmmss")

        '出力先、ファイル名の設定
        If patEnv.direct Then
            dataDir = patEnv.root
        Else
            dataDir = patEnv.root & "\" & patInfo.pId13 & "\" & patInfo.pId46 & "\" & patInfo.pId & "\-\ADT-00"
        End If
        dataFile = patInfo.pId & "_-_ADT-00_999999999999999_" & patInfo.currentDate & "_-_1"
        putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "FileName = " & dataFile)

        '旧データがある場合は、無効化フラグを立てる
        putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Set the invalid flag")
        If checkExists(dataDir, False) Then
            oldData = IO.Directory.GetFiles(dataDir, "*", IO.SearchOption.AllDirectories)
            fmt = patInfo.pId & "_-_ADT-00_999999999999999_[0-9]{14}_-_1"
            regex = New Text.RegularExpressions.Regex(fmt)
            For i = 0 To oldData.Count - 1
                If regex.IsMatch(oldData(i)) Then
                    rename = strMid(oldData(i), 1, oldData(i).Length - 1)
                    rename = rename & "0"
                    IO.File.Move(oldData(i), rename)
                End If
            Next
        End If

        'HL7データの作成
        putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Make HL7 Data")
        lstOutput.Clear()
        lstOutput.Add(patInfo.getMSH)
        lstOutput.Add(patInfo.getEVN)
        lstOutput.Add(patInfo.getPID)
        lstOutput.Add(patInfo.getPV1)
        lstOutput.AddRange(patInfo.getOBX)

        'ファイル出力
        IO.Directory.CreateDirectory(dataDir)
        sWrite = New IO.StreamWriter(dataDir & "\" & dataFile, False, System.Text.Encoding.GetEncoding("iso-2022-jp"))
        For i = 0 To lstOutput.Count - 1
            sWrite.WriteLine(lstOutput.Item(i))
        Next
        sWrite.Close()
        putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Output : " & dataDir & "\" & dataFile)

        If checkExists(dataDir & "\" & dataFile, True) Then
            MsgBox("患者情報を出力しました" & vbCrLf & "【出力先】" & vbCrLf & dataDir & vbCrLf & "【ファイル名】" & vbCrLf & dataFile)
        Else
            MsgBox("ファイル出力に失敗しました")
        End If

    End Sub

    ''' <summary>
    ''' 患者ID：入力内容のチェック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtPid_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPid.Validating
        Dim regex As Text.RegularExpressions.Regex
        Dim tmpFmt As String
        Dim str As String

        putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Check Format of Patiend ID")

        '入力形式の定義
        If patEnv.pIdchr >= "0"c And patEnv.pIdchr <= "9"c Then
            tmpFmt = "[0-9]{" & patEnv.pIdlen & "}"
        Else
            tmpFmt = "[0-9a-zA-Z]{" & patEnv.pIdlen & "}"
        End If
        regex = New Text.RegularExpressions.Regex(tmpFmt)

        If txtPid.Text = "" Then
        Else
            str = txtPid.Text.PadLeft(patEnv.pIdlen, patEnv.pIdchr)
            If regex.IsMatch(str) Then
                txtPid.Text = str
            Else
                MsgBox("不正な値が入力されています：患者ID=[" & txtPid.Text & "]")
                e.Cancel = True
            End If
        End If

    End Sub

    ''' <summary>
    ''' 生年月日入力後の処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub timPbirth_LostFocus(sender As Object, e As EventArgs) Handles timPbirth.LostFocus
        Dim baseDay As Date
        Dim today As Date
        Dim dt As Date
        Dim tmpYear As Integer
        Dim tmpMonth As Long
        Dim tmpDay As Integer

        putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Calculation the Patiend Age")

        baseDay = Date.Parse(timPbirth.Text)
        today = Date.Now
        tmpMonth = DateDiff(DateInterval.Month, baseDay, today)
        '日付をチェック
        If baseDay.Day > today.Day Then
            tmpMonth = tmpMonth - 1
            '前月の末日を計算
            dt = today.AddMonths(-1)
            tmpDay = Date.DaysInMonth(today.Year, dt.Month)
            '末日までの日数を計算
            tmpDay = tmpDay - baseDay.Day
            '当月の日数をプラス
            tmpDay = tmpDay + today.Day
        Else
            tmpDay = today.Day - baseDay.Day
        End If
        tmpYear = tmpMonth / 12
        tmpMonth = tmpMonth Mod 12

        lblPage.Text = tmpYear & "才 " & tmpMonth & "ヶ月 " & tmpDay & "日"

    End Sub

    ''' <summary>
    ''' 郵便番号：入力内容のチェック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtZip_Validating(sender As Object, e As EventArgs) Handles txtZip.Validating
        putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Check Format of ZIP")

        checkFormat(txtZip, "^\d{3}\-\d{4}$")
    End Sub

    ''' <summary>
    ''' 電話番号：入力内容のチェック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtTel_Validating(sender As Object, e As EventArgs) Handles txtTel.Validating
        putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Check Format of TEL")

        checkFormat(txtTel, "\A0\d{1,4}-\d{1,4}-\d{4}\z")
    End Sub

    ''' <summary>
    ''' 身長：入力内容のチェック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtHeight_Validating(sender As Object, e As EventArgs) Handles txtHeight.Validating
        putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Check Format of Height")

        checkFormat(txtHeight, "^\d{1,3}\.?\d*$")
    End Sub

    ''' <summary>
    ''' 体重：入力内容のチェック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtWeight_Validating(sender As Object, e As EventArgs) Handles txtWeight.Validating
        putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Check Format of Weight")

        checkFormat(txtWeight, "^\d{1,3}\.?\d*$")
    End Sub

    ''' <summary>
    ''' iniファイルを開く
    ''' </summary>
    Private Sub openIni()
        Dim file_pass As String

        putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Open the Ini file")

        file_pass = patEnv.appPath & patEnv.appIni
        If checkExists(file_pass, True) Then
            Shell(patEnv.editorPath & " " & file_pass, vbNormalFocus)
        Else
            MsgBox(file_pass & "が存在しません" & vbCrLf & "システムを終了します")

            putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Stop System")
            Close()
        End If

    End Sub

    ''' <summary>
    ''' iniファイルを読み込む
    ''' </summary>
    Private Sub readIni()
        Dim errList As New List(Of String)
        Dim sRead As IO.StreamReader
        Dim regex As Text.RegularExpressions.Regex
        Dim file_pass As String
        Dim str As String
        Dim strTmp() As String
        Dim tmpNum As Integer
        Dim i As Integer

        putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Read the Ini file")

        file_pass = patEnv.appPath & patEnv.appIni
        If checkExists(file_pass, True) Then
            sRead = New IO.StreamReader(file_pass, System.Text.Encoding.GetEncoding("Shift_JIS"))
            regex = New Text.RegularExpressions.Regex("[a-zA-Z0-9]")

            Do
                str = sRead.ReadLine()
                If str Is Nothing Then
                    Exit Do
                End If

                If Trim(str) <> "" Then
                    If str.Substring(0, 1) <> "*" Then
                        strTmp = Split(str, "=")
                        Select Case Trim(strTmp(0))
                            Case "EDITOR"
                                If checkExists(Trim(strTmp(1)), True) Then
                                    patEnv.editorPath = Trim(strTmp(1))

                                    putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Set the Editor path")
                                Else
                                    errList.Add(Trim(strTmp(1)) & "が存在しません")
                                End If
                            Case "ROOT"
                                If checkExists(Trim(strTmp(1)), False) Then
                                    patEnv.root = Trim(strTmp(1))

                                    putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Set the Root dir")
                                Else
                                    errList.Add(Trim(strTmp(1)) & "が存在しません")
                                End If
                            Case "DIRECT"
                                If Trim(strTmp(1)) = "ON" Then
                                    patEnv.direct = True
                                Else
                                    patEnv.direct = False
                                End If

                                putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Set the DIRECT value")
                            Case "PATLEN"
                                If Integer.TryParse(Trim(strTmp(1)), tmpNum) Then
                                    If tmpNum >= 6 Then
                                        patEnv.pIdlen = tmpNum

                                        putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Set the Patient Length")
                                    Else
                                        errList.Add("患者IDの桁数は6桁以上を指定してください。")
                                    End If
                                Else
                                    errList.Add("設定値が異常です：PATLEN=[" & Trim(strTmp(1)) & "]")
                                End If
                            Case "FORMAT"
                                If Trim(strTmp(1)).Count = 1 Then
                                    If regex.IsMatch(Trim(strTmp(1))) Then
                                        patEnv.pIdchr = Trim(strTmp(1))

                                        putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Set the padding number")
                                    Else
                                        errList.Add("設定値が異常です：FORMAT=[" & Trim(strTmp(1)) & "]")
                                    End If
                                Else
                                    errList.Add("設定値が異常です：FORMAT=[" & Trim(strTmp(1)) & "]")
                                End If
                            Case "FACILITY"
                                If Trim(strTmp(1)) <> "" Then
                                    patInfo.facilityCode = Trim(strTmp(1))

                                    putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Set the Facility Code")
                                Else
                                    errList.Add("設定値が異常です：FACILITY=[" & Trim(strTmp(1)) & "]")
                                End If
                        End Select
                    End If
                End If
            Loop
            sRead.Close()
        Else
            MsgBox(file_pass & "が存在しません" & vbCrLf & "システムを終了します")

            putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Stop System")
            Close()
        End If

        file_pass = patEnv.appPath & patEnv.zipDb
        If checkExists(file_pass, True) Then
            zipData.setPath = file_pass
            btnZip.Enabled = True
        Else
            errList.Add("郵便番号DBが存在しないため、機能を無効にします [" & Trim(file_pass) & "]")
            btnZip.Enabled = False
        End If

        If errList.Count > 0 Then
            For i = 0 To errList.Count - 1
                MsgBox(errList.Item(i))
            Next i
        End If

    End Sub

    ''' <summary>
    ''' 入力した画面上の患者情報をクリア
    ''' </summary>
    Private Sub clearPat()
        putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Clear the input Info")

        txtPid.Text = ""
        txtPname_Mei.Text = ""
        txtPname_Sei.Text = ""
        txtPkana_Mei.Text = ""
        txtPkana_Sei.Text = ""
        timPbirth.Text = ""
        lblPage.Text = ""
        cmbPsex.SelectedIndex = -1
        txtZip.Text = ""
        txtTel.Text = ""
        txtAddress1.Text = ""
        txtAddress2.Text = ""
        txtHeight.Text = ""
        txtWeight.Text = ""
        cmbAbo.SelectedIndex = -1
        cmbRh.SelectedIndex = -1
    End Sub

    ''' <summary>
    ''' 入力画面の初期設定
    ''' </summary>
    Private Sub setIni()
        Dim tmpSex() As String = {"", "男", "女", "未知", "その他"}
        Dim tmpAbo() As String = {"", "A", "B", "O", "AB", "不明"}
        Dim tmpRh() As String = {"", "+", "-", "不明"}

        putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Initialize Input item")

        '患者ID
        txtPid.MaxLength = patEnv.pIdlen
        txtPid.ImeMode = ImeMode.Disable

        '患者氏名, カナ氏名
        txtPname_Sei.ImeMode = ImeMode.On
        txtPname_Mei.ImeMode = ImeMode.On
        txtPkana_Sei.ImeMode = ImeMode.Katakana
        txtPkana_Mei.ImeMode = ImeMode.Katakana

        '生年月日

        '性別
        cmbPsex.Items.Clear()
        cmbPsex.Items.AddRange(tmpSex)

        '郵便番号
        txtZip.MaxLength = 8
        txtZip.ImeMode = ImeMode.Disable

        '電話番号
        txtTel.MaxLength = 14
        txtTel.ImeMode = ImeMode.Disable

        '住所1, 住所2
        txtAddress1.ImeMode = ImeMode.On
        txtAddress2.ImeMode = ImeMode.On

        '身長, 体重
        txtHeight.MaxLength = 7
        txtHeight.ImeMode = ImeMode.Disable
        txtWeight.MaxLength = 7
        txtWeight.ImeMode = ImeMode.Disable

        '血液型(ABO, RH)
        cmbAbo.Items.Clear()
        cmbAbo.Items.AddRange(tmpAbo)
        cmbRh.Items.Clear()
        cmbRh.Items.AddRange(tmpRh)
    End Sub

    ''' <summary>
    ''' 必須入力項目のチェック
    ''' </summary>
    ''' <returns></returns>
    Private Function requiredInput() As List(Of String)
        requiredInput = New List(Of String)

        putLog(patEnv.appPath & "\" & patEnv.appLog, My.Application.Info.ProductName & "_" & Date.Now.ToString("yyyyMMdd") & ".log", "Check the Required Item")

        If txtPid.Text = "" Then
            requiredInput.Add("患者IDが未入力です")
        End If
        If txtPkana_Sei.Text = "" Then
            requiredInput.Add("患者カナが未入力です")
        End If
        If txtPname_Sei.Text = "" Then
            requiredInput.Add("患者名が未入力です")
        End If
        If cmbPsex.SelectedIndex <= 0 Then
            requiredInput.Add("性別が未選択です")
        End If
        If cmbAbo.SelectedIndex > 0 Then
            If cmbRh.SelectedIndex <= 0 Then
                requiredInput.Add("血液型(ABO, Rh)が未選択です")
            End If
        End If

        Return requiredInput
    End Function

    ''' <summary>
    ''' フォームを閉じる場合は、Validatingイベントを発生させない
    ''' </summary>
    ''' <param name="m"></param>
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Const WM_CLOSE As Integer = &H10
        Const WM_SYSCOMMAND As Integer = &H112
        Const SC_CLOSE As Integer = &HF060

        Select Case m.Msg
            Case WM_SYSCOMMAND
                If m.WParam.ToInt32() = SC_CLOSE Then
                    'Xボタン、コントロールメニューの「閉じる」、  
                    'コントロールボックスのダブルクリック、  
                    'Atl+F4などにより閉じられようとしている  
                    'このときValidatingイベントを発生させない。  
                    Me.AutoValidate = Windows.Forms.AutoValidate.Disable
                End If
            Case WM_CLOSE
                'Application.Exit以外で閉じられようとしている  
                'このときValidatingイベントを発生させない。  
                Me.AutoValidate = Windows.Forms.AutoValidate.Disable
        End Select

        MyBase.WndProc(m)
    End Sub

End Class
