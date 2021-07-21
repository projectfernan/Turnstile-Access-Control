Public Class frmSettings

    Private Sub cmdReader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReader.Click
        frmDevrec.ShowDialog()
    End Sub

    Private Sub cmdDesignatePath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDesignatePath.Click
        frmEmpImgPath.ShowDialog()
    End Sub

    Private Sub cmdConn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConn.Click
        frmConDB.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmLogo.ShowDialog()
    End Sub

    Private Sub cmdAntiPsb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAntiPsb.Click
        frmPsb.ShowDialog()
    End Sub

    Private Sub cmdDbPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDbPath.Click
        frmDBPathCon.ShowDialog()
    End Sub

    Private Sub cmdAutoRestart_Click(sender As System.Object, e As System.EventArgs) Handles cmdAutoRestart.Click
        frmAutoRestart.ShowDialog()
    End Sub

    Private Sub btnVoiceSettings_Click(sender As System.Object, e As System.EventArgs) Handles btnVoiceSettings.Click
        Dim shw As New frmVoicePrompt()
        shw.ShowDialog()
    End Sub
End Class