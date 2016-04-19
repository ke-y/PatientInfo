Option Explicit On

Public Class frmVersion

    ''' <summary>
    ''' 起動時処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmVersion_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim appName As String = My.Application.Info.ProductName

        Text = appName & " - Version"

        lblAppName.Text = appName
        lblTitle.Text = My.Application.Info.Title
        lblVer.Text = "Version : " & My.Application.Info.Version.ToString
        lblCopyright.Text = My.Application.Info.Copyright
        lblSpec.Text = My.Application.Info.Description

    End Sub

    ''' <summary>
    ''' 終了時処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

End Class