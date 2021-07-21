Public Class frmDevConn
    Sub save()
        With My.Settings
            .DEV1_IP = txtDev1IP.Text
            .DEV2_IP = txtDev2IP.Text
            .CLEAR_delay = txtDelay.Text
            .Save()
            MsgBox("Reader setting saved!    ", vbInformation, "Reader settings")
            Me.Close()
        End With
    End Sub

    Private Sub cmdTest1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest1.Click
        Dev1DisConnect()
        With MainForm
            If Dev1Conn(txtDev1IP.Text) = True Then
                .txtDev1Stat.Text = "Connected"
                .txtDev1Stat.ForeColor = Color.Blue
                MsgBox("Successfully connected!    ", vbInformation, "Connect")
            Else
                .txtDev1Stat.Text = "Disconnected"
                .txtDev1Stat.ForeColor = Color.Red
                MsgBox("Failed to connect!    ", vbExclamation, "Connect")
            End If
        End With
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        save()
        With MainForm
            .tmrClearStud.Interval = txtDelay.Text
            .tmrClearFetch.Interval = txtDelay.Text
        End With
    End Sub

    Private Sub frmDevConn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            save()
        End If
    End Sub

    Private Sub cmdTest2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest2.Click
        Dev2DisConnect()
        With MainForm
            If Dev2Conn(txtDev2IP.Text) = True Then
                .txtDev2Stat.Text = "Connected"
                .txtDev2Stat.ForeColor = Color.Blue
                MsgBox("Successfully connected!    ", vbInformation, "Connect")
            Else
                .txtDev2Stat.Text = "Disconnected"
                .txtDev2Stat.ForeColor = Color.Red
                MsgBox("Failed to connect!    ", vbExclamation, "Connect")
            End If
        End With
    End Sub
End Class