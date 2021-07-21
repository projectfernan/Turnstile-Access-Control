Public Class frmCamSettings
    Private Sub txtpass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpass.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtIp.Focus()
        End If
    End Sub

    Private Sub txtUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUser.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtpass.Focus()
        End If
    End Sub

    Private Sub cmdCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCon.Click
        save()
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
    Private Sub frmCamSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub txtIp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIp.KeyPress
        If Len(txtIp.Text) = 0 And Asc(e.KeyChar) = 45 Then
            e.KeyChar = vbNullString
        End If
        If Asc(e.KeyChar) >= 58 Then
            e.KeyChar = vbNullString
        End If
        If Asc(e.KeyChar) = 13 Then
            txtPort.Focus()
        End If
    End Sub

    Private Sub txtPort_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPort.KeyPress
        If Asc(e.KeyChar) = 13 Then
            ChanEntry.Focus()
        End If
    End Sub

    Private Sub ChanEntry_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ChanEntry.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CaptureEnt.Focus()
        End If
    End Sub
    Private Sub CaptureEnt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CaptureEnt.KeyPress
        If Asc(e.KeyChar) = 13 Then
            ChanExt.Focus()
        End If
    End Sub
    Private Sub ChanExt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ChanExt.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CaptureExt.Focus()
        End If
    End Sub
    Private Sub CaptureExt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CaptureExt.KeyPress
        If Asc(e.KeyChar) = 13 Then
            save()
        End If
    End Sub

    Private Sub txtIp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIp.TextChanged

    End Sub

    Private Sub txtUser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUser.TextChanged

    End Sub
End Class