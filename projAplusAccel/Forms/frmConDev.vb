Public Class frmConDev

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cmdCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        save()
    End Sub
    Sub save()
        With My.Settings
            .DEV1_Ip = txtIP1.Text
            .DEV2_IP = txtIP2.Text
            .DEV3_IP = txtIP3.Text
            .DEV4_IP = txtIP4.Text
            .Save()
        End With
        devDisCon()
        devcon1()
        devcon2()
        devcon3()
        devcon4()
        'frmMain.tmrPingDev1.Enabled = True
        'frmMain.tmrPingDev2.Enabled = True
        Me.Close()
        MsgBox("New Device settings saved!    ", vbInformation, "Device Settings")
    End Sub

    Private Sub cmdCon_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCon.Click
        save()
    End Sub

    Private Sub cmdCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdTest1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest1.Click
        With My.Settings
            .DEV1_IP = txtIP1.Text
            .Save()
        End With
        ' If 'Dev1Control.devcon1() = True Then
        ' MsgBox("Successfully connected!    ", vbInformation, "Device 1")
        'Else
        ' MsgBox("Failed to connect to device!    ", vbExclamation, "Device 1")
        ' End If
    End Sub

    Private Sub cmdTest2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest2.Click
        With My.Settings
            .DEV2_IP = txtIP2.Text
            .Save()
        End With

        If devcon2() = True Then
            MsgBox("Successfully connected!    ", vbInformation, "Device 2")
        Else
            MsgBox("Failed to connect to device!    ", vbExclamation, "Device 2")
        End If
    End Sub

    Private Sub frmConDev_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        With My.Settings
            .DEV3_IP = txtIP3.Text
            .Save()
        End With

        If devcon3() = True Then
            MsgBox("Successfully connected!    ", vbInformation, "Device 3")
        Else
            MsgBox("Failed to connect to device!    ", vbExclamation, "Device 3")
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        With My.Settings
            .DEV4_IP = txtIP4.Text
            .Save()
        End With

        If devcon4() = True Then
            MsgBox("Successfully connected!    ", vbInformation, "Device 4")
        Else
            MsgBox("Failed to connect to device!    ", vbExclamation, "Device 4")
        End If
    End Sub
End Class