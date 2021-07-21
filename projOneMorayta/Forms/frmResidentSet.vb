Public Class frmResidentSet

    Private Sub cmdSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSettings.Click
        frmRoomName.ShowDialog()
    End Sub

    Private Sub cmdAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcc.Click
        frmBedNumber.ShowDialog()
    End Sub

    Private Sub cmdEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEmp.Click
        Dim s As New frmEmployee
        s.ShowDialog()
    End Sub
End Class