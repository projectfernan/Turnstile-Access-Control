Public Class frmAutoRestart

    Private Sub chkEnable1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEnable1.CheckedChanged
        With My.Settings
            .EnableRestart1 = chkEnable1.Checked
            .Save()
        End With
    End Sub

    Private Sub chkEnable2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEnable2.CheckedChanged
        With My.Settings
            .EnableRestart2 = chkEnable2.Checked
            .Save()
        End With
    End Sub

    Private Sub chkEnable3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEnable3.CheckedChanged
        With My.Settings
            .EnableRestart3 = chkEnable3.Checked
            .Save()
        End With
    End Sub

    Private Sub frmAutoRestart_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        With My.Settings
            .Restart1 = dtRestart1.Value
            .Restart2 = dtRestart2.Value
            .Restart3 = dtRestart3.Value
            .Save()
        End With
    End Sub

    Sub loadInfo()
        With My.Settings
            chkEnable1.Checked = .EnableRestart1
            chkEnable2.Checked = .EnableRestart2
            chkEnable3.Checked = .EnableRestart3

            dtRestart1.Value = .Restart1
            dtRestart2.Value = .Restart2
            dtRestart3.Value = .Restart3
        End With
    End Sub

    Private Sub frmAutoRestart_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        loadInfo()
    End Sub
End Class