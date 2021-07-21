Module Camera_Function
    Public Sub CAM_CLOSE()
        With frmMain
            .CamEntry.StopRealPlay()
            .CamEntry.Logout()
            .CamEntry.ClearOCX()
            .CamExit.StopRealPlay()
            .CamExit.Logout()
            .CamExit.ClearOCX()
        End With
    End Sub
    Public Sub camInfo()
        With My.Settings
            frmCamSettings.txtUser.Text = .CAM_User
            frmCamSettings.txtpass.Text = .CAM_Pass
            frmCamSettings.txtIp.Text = .CAM_IP
            frmCamSettings.txtPort.Text = .CAM_Port

            frmCamSettings.ChanEntry.Value = .CAM_ChannelEnt
            frmCamSettings.CaptureEnt.Value = .CAM_ChannelCap1
            frmCamSettings.ChanExt.Value = .CAM_ChannelExt
            frmCamSettings.CaptureExt.Value = .CAM_ChannelCap2
        End With
    End Sub
    Public Sub camEntrance()
        'CAM_CLOSE()
        Dim val As Long
        Try
            With frmMain
                val = .CamEntry.Login(frmCamSettings.txtIp.Text, frmCamSettings.txtPort.Text, frmCamSettings.txtUser.Text, frmCamSettings.txtpass.Text)
                .CamEntry.StartRealPlay(frmCamSettings.ChanEntry.Text, 0, 0)
                If val < 0 Then

                Else

                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Public Sub camExt()
        'CAM_CLOSE()
        Dim val As Long
        Try
            With frmMain
                val = .CamExit.Login(frmCamSettings.txtIp.Text, frmCamSettings.txtPort.Text, frmCamSettings.txtUser.Text, frmCamSettings.txtpass.Text)
                .CamExit.StartRealPlay(frmCamSettings.ChanExt.Text, 0, 0)
                If val < 0 Then

                Else

                End If
            End With
        Catch ex As Exception

        End Try

    End Sub

End Module
