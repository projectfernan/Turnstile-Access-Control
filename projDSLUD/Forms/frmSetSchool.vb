Public Class frmSetSchool

    Private Sub cmdEduLv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEduLv.Click
        frmEduLevel.ShowDialog()
    End Sub

    Private Sub cmdGy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGy.Click
        frmGy.ShowDialog()
    End Sub

    Private Sub cmdSec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSec.Click
        frmSection.ShowDialog()
    End Sub
End Class