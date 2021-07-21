Public Class frmSystem

    Private Sub cmdAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcc.Click
        frmAdminAcc.ShowDialog()
    End Sub

    Private Sub cmdStudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStudent.Click
        frmStudRec.ShowDialog()
    End Sub

    Private Sub cmdReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReport.Click
        frmLogs.ShowDialog()
    End Sub

    Private Sub cmdTerminate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTerminate.Click
        If MsgBox("Are you sure do you want to terminate the system?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Terminate sytem") = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub cmdSetSchool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetSchool.Click
        frmSetSchool.ShowDialog()
    End Sub

    Private Sub cmdSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSettings.Click
        frmSettings.ShowDialog()
    End Sub

    Private Sub cmdItemCateg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmItems.ShowDialog()
    End Sub

    Private Sub cmdFetcher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmFetcherRec.ShowDialog()
    End Sub

    Private Sub frmSystem_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
   
    End Sub

    Private Sub frmSystem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If desig = "User" Then
            cmdSettings.Enabled = False
            cmdAcc.Enabled = False
            cmdSetSchool.Enabled = True
            cmdStudent.Enabled = True
            frmItems.cmdItemCateg.Enabled = False
        Else
            cmdSettings.Enabled = True
            cmdAcc.Enabled = True
            cmdSetSchool.Enabled = True
            cmdStudent.Enabled = True
            frmItems.cmdItemCateg.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub cmdNotice_Click(sender As System.Object, e As System.EventArgs) Handles cmdNotice.Click
        Dim f As New frmNotice
        f.ShowDialog()
    End Sub
End Class