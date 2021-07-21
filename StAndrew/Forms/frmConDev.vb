Public Class frmConDev

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCon.Click
        sveCon()
    End Sub
    Sub sveCon()
        With My.Settings
            .T1Dev1 = T1DevIp1.Text
            .T1Dev2 = T1DevIp2.Text

            .T2Dev1 = T2DevIp1.Text
            .T2Dev2 = T2DevIp2.Text

            .T3Dev1 = T3DevIp1.Text
            .T3Dev2 = T3DevIp2.Text

            .T4Dev1 = T4DevIp1.Text
            .T4Dev2 = T4DevIp2.Text
            .Save()
        End With
        MsgBox("Reader settings successfully saved!    ", vbInformation, "Reader Settings")
        'frmMain.tmrEvent.Enabled = True
        Me.Close()
    End Sub

    Sub save()
        With My.Settings
            .DEV1_Ip = T1DevIp1.Text
            '.DEV1_Com = txtCom1.Value
            '.DEV2_Ip = txtIP2.Text
            '.DEV2_Com = txtCom2.Value
            .Save()
        End With
        t1devDisCon()
        devcon1()
        devcon2()
        'frmMain.tmrPingDev1.Enabled = True
        'frmMain.tmrPingDev2.Enabled = True
        Me.Close()
        MsgBox("New Device settings saved!    ", vbInformation, "Device Settings")
    End Sub
    Private Sub txtIP1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles T1DevIp1.KeyPress
        If Len(T1DevIp1.Text) = 0 And Asc(e.KeyChar) = 45 Then
            e.KeyChar = vbNullString
        End If
        If Asc(e.KeyChar) >= 58 Then
            e.KeyChar = vbNullString
        End If
        If Asc(e.KeyChar) = 13 Then
            'txtCom1.Focus()
        End If
    End Sub

    Private Sub txtCom1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            'txtIP2.Focus()
        End If
    End Sub

    Private Sub txtIP2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'If Len(txtIP2.Text) = 0 And Asc(e.KeyChar) = 45 Then
        e.KeyChar = vbNullString
        'End If
        If Asc(e.KeyChar) >= 58 Then
            e.KeyChar = vbNullString
        End If
        If Asc(e.KeyChar) = 13 Then
            'txtCom2.Focus()
        End If
    End Sub

    Private Sub txtCom2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            save()
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

        If t1devcon1(T1DevIp1.Text) = True Then
            MsgBox("Successfully connected!    ", vbInformation, "Reader Settings")
        Else
            MsgBox("Failed to connect!    ", vbExclamation, "Reader Settings")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If t1devcon2(T1DevIp2.Text) = True Then
            MsgBox("Successfully connected!    ", vbInformation, "Reader Settings")
        Else
            MsgBox("Failed to connect!    ", vbExclamation, "Reader Settings")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If t3devcon1(T3DevIp1.Text) = True Then
            MsgBox("Successfully connected!    ", vbInformation, "Reader Settings")
        Else
            MsgBox("Failed to connect!    ", vbExclamation, "Reader Settings")
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        If t2devcon1(T2DevIp1.Text) = True Then
            MsgBox("Successfully connected!    ", vbInformation, "Reader Settings")
        Else
            MsgBox("Failed to connect!    ", vbExclamation, "Reader Settings")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If t2devcon2(T2DevIp2.Text) = True Then
            MsgBox("Successfully connected!    ", vbInformation, "Reader Settings")
        Else
            MsgBox("Failed to connect!    ", vbExclamation, "Reader Settings")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If t3devcon2(T3DevIp2.Text) = True Then
            MsgBox("Successfully connected!    ", vbInformation, "Reader Settings")
        Else
            MsgBox("Failed to connect!    ", vbExclamation, "Reader Settings")
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        If t4devcon1(T4DevIp1.Text) = True Then
            MsgBox("Successfully connected!    ", vbInformation, "Reader Settings")
        Else
            MsgBox("Failed to connect!    ", vbExclamation, "Reader Settings")
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        If t4devcon2(T4DevIp2.Text) = True Then
            MsgBox("Successfully connected!    ", vbInformation, "Reader Settings")
        Else
            MsgBox("Failed to connect!    ", vbExclamation, "Reader Settings")
        End If
    End Sub

    Private Sub frmConDev_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        t1devDisCon()
        t2devDisCon()
        t3devDisCon()
        t4devDisCon()
        frmMain.tmrEvent.Enabled = False
    End Sub
End Class