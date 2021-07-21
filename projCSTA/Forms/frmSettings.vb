Public Class frmSettings

    Private Sub cmdConn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSelectDb.ShowDialog()
    End Sub

    Private Sub cmdReader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmConDev.ShowDialog()
    End Sub

    Private Sub cmdControler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmControler.ShowDialog()
    End Sub

    Private Sub cmdAntiPBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPassBack.ShowDialog()
    End Sub

    Private Sub cmdLateRule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAttRule.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        frmLogo.ShowDialog()
    End Sub

    Private Sub cmdConn_Click_1(sender As System.Object, e As System.EventArgs) Handles cmdConn.Click
        frmSelectDb.ShowDialog()
    End Sub

    Private Sub cmdReader_Click_1(sender As System.Object, e As System.EventArgs) Handles cmdReader.Click
        frmDevRec.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frmLogo.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        frmPicPath.ShowDialog()
    End Sub
End Class