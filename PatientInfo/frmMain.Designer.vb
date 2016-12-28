<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.toolFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOpenIni = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuReadIni = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuEnd = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolDisplay = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuForeDisp = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuPatClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuVersion = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPid = New System.Windows.Forms.TextBox()
        Me.txtPname_Sei = New System.Windows.Forms.TextBox()
        Me.txtPname_Mei = New System.Windows.Forms.TextBox()
        Me.txtPkana_Mei = New System.Windows.Forms.TextBox()
        Me.txtPkana_Sei = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.timPbirth = New System.Windows.Forms.DateTimePicker()
        Me.cmbPsex = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPage = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAddress1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.cmbAbo = New System.Windows.Forms.ComboBox()
        Me.cmbRh = New System.Windows.Forms.ComboBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAddress2 = New System.Windows.Forms.TextBox()
        Me.btnOpenRoot = New System.Windows.Forms.Button()
        Me.btnMake = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnZip = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolFile, Me.toolDisplay, Me.toolHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(756, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'toolFile
        '
        Me.toolFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuOpenIni, Me.menuReadIni, Me.ToolStripSeparator1, Me.menuEnd})
        Me.toolFile.Name = "toolFile"
        Me.toolFile.Size = New System.Drawing.Size(77, 20)
        Me.toolFile.Text = "ファイル（&F）"
        '
        'menuOpenIni
        '
        Me.menuOpenIni.Name = "menuOpenIni"
        Me.menuOpenIni.Size = New System.Drawing.Size(205, 22)
        Me.menuOpenIni.Text = "iniファイルを開く（&O）"
        '
        'menuReadIni
        '
        Me.menuReadIni.Name = "menuReadIni"
        Me.menuReadIni.Size = New System.Drawing.Size(205, 22)
        Me.menuReadIni.Text = "iniファイルを読み込む（&R）"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(202, 6)
        '
        'menuEnd
        '
        Me.menuEnd.Name = "menuEnd"
        Me.menuEnd.Size = New System.Drawing.Size(205, 22)
        Me.menuEnd.Text = "終了（&X）"
        '
        'toolDisplay
        '
        Me.toolDisplay.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuForeDisp, Me.ToolStripSeparator2, Me.menuPatClear})
        Me.toolDisplay.Name = "toolDisplay"
        Me.toolDisplay.Size = New System.Drawing.Size(67, 20)
        Me.toolDisplay.Text = "表示（&V）"
        '
        'menuForeDisp
        '
        Me.menuForeDisp.CheckOnClick = True
        Me.menuForeDisp.Name = "menuForeDisp"
        Me.menuForeDisp.Size = New System.Drawing.Size(194, 22)
        Me.menuForeDisp.Text = "常に最善面に表示（&T）"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(191, 6)
        '
        'menuPatClear
        '
        Me.menuPatClear.Name = "menuPatClear"
        Me.menuPatClear.Size = New System.Drawing.Size(194, 22)
        Me.menuPatClear.Text = "入力内容のクリア（&C）"
        '
        'toolHelp
        '
        Me.toolHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuVersion})
        Me.toolHelp.Name = "toolHelp"
        Me.toolHelp.Size = New System.Drawing.Size(73, 20)
        Me.toolHelp.Text = "ヘルプ（&H）"
        '
        'menuVersion
        '
        Me.menuVersion.Name = "menuVersion"
        Me.menuVersion.Size = New System.Drawing.Size(172, 22)
        Me.menuVersion.Text = "バージョン情報（&A）"
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEnd.CausesValidation = False
        Me.btnEnd.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnEnd.Location = New System.Drawing.Point(645, 222)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(93, 33)
        Me.btnEnd.TabIndex = 53
        Me.btnEnd.Text = "終了"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "患者ID"
        '
        'txtPid
        '
        Me.txtPid.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtPid.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtPid.Location = New System.Drawing.Point(82, 35)
        Me.txtPid.Name = "txtPid"
        Me.txtPid.Size = New System.Drawing.Size(170, 23)
        Me.txtPid.TabIndex = 1
        '
        'txtPname_Sei
        '
        Me.txtPname_Sei.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtPname_Sei.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtPname_Sei.Location = New System.Drawing.Point(82, 99)
        Me.txtPname_Sei.Name = "txtPname_Sei"
        Me.txtPname_Sei.Size = New System.Drawing.Size(133, 23)
        Me.txtPname_Sei.TabIndex = 4
        '
        'txtPname_Mei
        '
        Me.txtPname_Mei.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtPname_Mei.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtPname_Mei.Location = New System.Drawing.Point(221, 99)
        Me.txtPname_Mei.Name = "txtPname_Mei"
        Me.txtPname_Mei.Size = New System.Drawing.Size(181, 23)
        Me.txtPname_Mei.TabIndex = 5
        '
        'txtPkana_Mei
        '
        Me.txtPkana_Mei.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtPkana_Mei.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.txtPkana_Mei.Location = New System.Drawing.Point(221, 70)
        Me.txtPkana_Mei.Name = "txtPkana_Mei"
        Me.txtPkana_Mei.Size = New System.Drawing.Size(181, 23)
        Me.txtPkana_Mei.TabIndex = 3
        '
        'txtPkana_Sei
        '
        Me.txtPkana_Sei.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtPkana_Sei.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.txtPkana_Sei.Location = New System.Drawing.Point(82, 70)
        Me.txtPkana_Sei.Name = "txtPkana_Sei"
        Me.txtPkana_Sei.Size = New System.Drawing.Size(133, 23)
        Me.txtPkana_Sei.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "患者氏名"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "カナ氏名"
        '
        'timPbirth
        '
        Me.timPbirth.CalendarFont = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.timPbirth.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.timPbirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.timPbirth.Location = New System.Drawing.Point(497, 70)
        Me.timPbirth.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.timPbirth.Name = "timPbirth"
        Me.timPbirth.Size = New System.Drawing.Size(112, 23)
        Me.timPbirth.TabIndex = 6
        '
        'cmbPsex
        '
        Me.cmbPsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPsex.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbPsex.FormattingEnabled = True
        Me.cmbPsex.Location = New System.Drawing.Point(497, 99)
        Me.cmbPsex.Name = "cmbPsex"
        Me.cmbPsex.Size = New System.Drawing.Size(76, 24)
        Me.cmbPsex.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(421, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "生年月日"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(453, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "性別"
        '
        'lblPage
        '
        Me.lblPage.AutoSize = True
        Me.lblPage.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPage.Location = New System.Drawing.Point(492, 45)
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Size = New System.Drawing.Size(99, 16)
        Me.lblPage.TabIndex = 14
        Me.lblPage.Text = "XXX才YYヶ月"
        '
        'txtZip
        '
        Me.txtZip.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtZip.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtZip.Location = New System.Drawing.Point(82, 144)
        Me.txtZip.MaxLength = 8
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(100, 23)
        Me.txtZip.TabIndex = 8
        Me.txtZip.Tag = "郵便番号"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "郵便番号"
        '
        'txtAddress1
        '
        Me.txtAddress1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtAddress1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtAddress1.Location = New System.Drawing.Point(82, 173)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(472, 23)
        Me.txtAddress1.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "住所"
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtTel.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtTel.Location = New System.Drawing.Point(400, 144)
        Me.txtTel.MaxLength = 8
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(154, 23)
        Me.txtTel.TabIndex = 9
        Me.txtTel.Tag = "電話番号"
        '
        'cmbAbo
        '
        Me.cmbAbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAbo.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbAbo.FormattingEnabled = True
        Me.cmbAbo.Location = New System.Drawing.Point(407, 231)
        Me.cmbAbo.Name = "cmbAbo"
        Me.cmbAbo.Size = New System.Drawing.Size(81, 24)
        Me.cmbAbo.TabIndex = 14
        '
        'cmbRh
        '
        Me.cmbRh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRh.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbRh.FormattingEnabled = True
        Me.cmbRh.Location = New System.Drawing.Point(495, 231)
        Me.cmbRh.Name = "cmbRh"
        Me.cmbRh.Size = New System.Drawing.Size(59, 24)
        Me.cmbRh.TabIndex = 15
        '
        'txtHeight
        '
        Me.txtHeight.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtHeight.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtHeight.Location = New System.Drawing.Point(82, 231)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(75, 23)
        Me.txtHeight.TabIndex = 12
        Me.txtHeight.Tag = "身長"
        '
        'txtWeight
        '
        Me.txtWeight.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtWeight.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtWeight.Location = New System.Drawing.Point(236, 231)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(75, 23)
        Me.txtWeight.TabIndex = 13
        Me.txtWeight.Tag = "体重"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 234)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 16)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "身長"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(192, 234)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 16)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "体重"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(346, 234)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "血液型"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.Location = New System.Drawing.Point(320, 147)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "電話番号"
        '
        'txtAddress2
        '
        Me.txtAddress2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtAddress2.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtAddress2.Location = New System.Drawing.Point(82, 202)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(472, 23)
        Me.txtAddress2.TabIndex = 11
        '
        'btnOpenRoot
        '
        Me.btnOpenRoot.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnOpenRoot.CausesValidation = False
        Me.btnOpenRoot.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnOpenRoot.Location = New System.Drawing.Point(645, 74)
        Me.btnOpenRoot.Name = "btnOpenRoot"
        Me.btnOpenRoot.Size = New System.Drawing.Size(93, 30)
        Me.btnOpenRoot.TabIndex = 51
        Me.btnOpenRoot.Text = "出力先"
        Me.btnOpenRoot.UseVisualStyleBackColor = False
        '
        'btnMake
        '
        Me.btnMake.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMake.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnMake.Location = New System.Drawing.Point(645, 110)
        Me.btnMake.Name = "btnMake"
        Me.btnMake.Size = New System.Drawing.Size(93, 30)
        Me.btnMake.TabIndex = 52
        Me.btnMake.Text = "データ作成"
        Me.btnMake.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClear.CausesValidation = False
        Me.btnClear.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnClear.Location = New System.Drawing.Point(645, 38)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(93, 30)
        Me.btnClear.TabIndex = 50
        Me.btnClear.Text = "患者クリア"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label12.Location = New System.Drawing.Point(160, 234)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 16)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "cm"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.Location = New System.Drawing.Point(312, 234)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(22, 16)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "kg"
        '
        'btnZip
        '
        Me.btnZip.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnZip.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnZip.Location = New System.Drawing.Point(195, 144)
        Me.btnZip.Name = "btnZip"
        Me.btnZip.Size = New System.Drawing.Size(69, 23)
        Me.btnZip.TabIndex = 9
        Me.btnZip.Text = "検索"
        Me.btnZip.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(756, 275)
        Me.Controls.Add(Me.btnZip)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnOpenRoot)
        Me.Controls.Add(Me.btnMake)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtAddress2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.cmbRh)
        Me.Controls.Add(Me.cmbAbo)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAddress1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.lblPage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbPsex)
        Me.Controls.Add(Me.timPbirth)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPkana_Mei)
        Me.Controls.Add(Me.txtPkana_Sei)
        Me.Controls.Add(Me.txtPname_Mei)
        Me.Controls.Add(Me.txtPname_Sei)
        Me.Controls.Add(Me.txtPid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents toolFile As ToolStripMenuItem
    Friend WithEvents toolDisplay As ToolStripMenuItem
    Friend WithEvents menuForeDisp As ToolStripMenuItem
    Friend WithEvents toolHelp As ToolStripMenuItem
    Friend WithEvents menuVersion As ToolStripMenuItem
    Friend WithEvents menuEnd As ToolStripMenuItem
    Friend WithEvents btnEnd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPid As TextBox
    Friend WithEvents txtPname_Sei As TextBox
    Friend WithEvents txtPname_Mei As TextBox
    Friend WithEvents txtPkana_Mei As TextBox
    Friend WithEvents txtPkana_Sei As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents timPbirth As DateTimePicker
    Friend WithEvents cmbPsex As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPage As Label
    Friend WithEvents txtZip As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAddress1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTel As TextBox
    Friend WithEvents cmbAbo As ComboBox
    Friend WithEvents cmbRh As ComboBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAddress2 As TextBox
    Friend WithEvents btnOpenRoot As Button
    Friend WithEvents btnMake As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents menuOpenIni As ToolStripMenuItem
    Friend WithEvents menuReadIni As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents menuPatClear As ToolStripMenuItem
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnZip As Button
End Class
