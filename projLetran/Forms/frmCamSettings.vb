Public Class frmCamSettings

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        camEntrance()
    End Sub

    Private Sub cmdTest_Click(sender As System.Object, e As System.EventArgs) Handles cmdTest.Click
        camExt()
    End Sub

    Sub save()
        With My.Settings
            .CAM_User = txtUser.Text
            .CAM_Pass = txtpass.Text
            .CAM_IP = txtIp.Text
            .CAM_Port = txtPort.Text

            .CAM_ChannelEnt = ChanEntry.Value
            .CAM_ChannelCap1 = CaptureEnt.Value
            .CAM_ChannelExt = ChanExt.Value
            .CAM_ChannelCap2 = CaptureExt.Value
            .Save()
        End With
        camEntrance()
        camExt()
        Me.Close()
        MsgBox("New Camera settings saved!    ", vbInformation, "Camera Settings")
    End Sub

    Private Sub frmCamSettings_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        With My.Settings
            txtUser.Text = .CAM_User
            txtpass.Text = .CAM_Pass
            txtIp.Text = .CAM_IP
            txtPort.Text = .CAM_Port

            ChanEntry.Value = .CAM_ChannelEnt
            CaptureEnt.Value = .CAM_ChannelCap1
            ChanExt.Value = .CAM_ChannelExt
            CaptureExt.Value = .CAM_ChannelCap2
        End With
    End Sub

    Private Sub cmdCon_Click(sender As System.Object, e As System.EventArgs) Handles cmdCon.Click
        save()
    End Sub
End Class