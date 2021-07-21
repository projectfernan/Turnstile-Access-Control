Public Class frmControlPanel

    Private Sub cmdSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSettings.Click
        frmSettings.ShowDialog()
    End Sub

    Private Sub cmdStudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEmp.Click
        frmEmployee.ShowDialog()
    End Sub

    Private Sub cmdTerminate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTerminate.Click
        If MsgBox("Are you sure do you want to terminate the system? ", vbQuestion + vbYesNo + vbDefaultButton2, "Terminate") = vbYes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub cmdAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcc.Click
        frmAdminAcc.ShowDialog()
    End Sub

    Private Sub cmdReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReport.Click
        frmLogs.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAbout.Click
        frmAbout.ShowDialog()
    End Sub
End Class