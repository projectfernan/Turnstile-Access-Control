Public Class frmSettings

    Private Sub cmdReader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReader.Click
        frmController.ShowDialog()
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
End Class