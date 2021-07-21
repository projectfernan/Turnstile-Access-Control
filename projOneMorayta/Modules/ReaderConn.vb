Imports ADODB
Module ReaderConn
    Public devNo As String
    Public devNo2 As String
    Public Sub tbldevcon()
        Try
            With My.Settings
                frmConDev.txtIP1.Text = .DEV1_IP
                frmConDev.txtIP2.Text = .DEV2_IP
                frmConDev.txtIP3.Text = .DEV3_IP
                frmConDev.txtIP4.Text = .DEV4_IP
            End With
        Catch ex As Exception

        End Try
    End Sub

    Sub devDisCon()
        With frmMain
            .Dev1.EndInit()
            .Dev2.EndInit()
            .Dev3.EndInit()
            .Dev4.EndInit()

            .Dev1.Disconnect()
            .Dev2.Disconnect()
            .Dev3.Disconnect()
            .Dev4.Disconnect()
        End With
    End Sub

    Public Function devcon1() As Boolean
        If PingMe(frmConDev.txtIP1.Text) = True Then
            frmMain.StatDev1.Text = "Connected"
            frmMain.StatDev1.ForeColor = Color.Blue
            frmMain.Dev1.BeginInit()
            frmMain.Dev1.Connect_Net(frmConDev.txtIP1.Text, 4370)
            frmMain.Dev1.BASE64 = 0
            frmMain.Dev1.DisableDeviceWithTimeOut(1, 432000000)
            frmMain.Dev1.RegEvent(1, 32767)
            Return True
        Else
            frmMain.StatDev1.Text = "Disconnected"
            frmMain.StatDev1.ForeColor = Color.Maroon
            frmMain.tmrPingDev1.Enabled = False
            Return False
        End If
    End Function

    Public Function devcon2() As Boolean
        If PingMe(frmConDev.txtIP2.Text) = True Then
            frmMain.StatDev2.Text = "Connected"
            frmMain.StatDev2.ForeColor = Color.Blue
            frmMain.Dev2.BeginInit()
            frmMain.Dev2.Connect_Net(frmConDev.txtIP2.Text, 4370)
            frmMain.Dev2.BASE64 = 0
            frmMain.Dev1.DisableDeviceWithTimeOut(1, 432000000)
            frmMain.Dev2.RegEvent(1, 32767)
            Return True
        Else
            frmMain.StatDev2.Text = "Disconnected"
            frmMain.StatDev2.ForeColor = Color.Maroon
            frmMain.tmrPingDev2.Enabled = False
            Return False
        End If
    End Function

    Public Function devcon3() As Boolean
        If PingMe(frmConDev.txtIP3.Text) = True Then
            frmMain.StatDev3.Text = "Connected"
            frmMain.StatDev3.ForeColor = Color.Blue
            frmMain.Dev3.BeginInit()
            frmMain.Dev3.Connect_Net(frmConDev.txtIP3.Text, 4370)
            frmMain.Dev3.BASE64 = 0
            frmMain.Dev1.DisableDeviceWithTimeOut(1, 432000000)
            frmMain.Dev3.RegEvent(1, 32767)
            Return True
        Else
            frmMain.StatDev3.Text = "Disconnected"
            frmMain.StatDev3.ForeColor = Color.Maroon
            Return False
        End If
    End Function

    Public Function devcon4() As Boolean
        If PingMe(frmConDev.txtIP4.Text) = True Then
            frmMain.StatDev4.Text = "Connected"
            frmMain.StatDev4.ForeColor = Color.Blue
            frmMain.Dev4.BeginInit()
            frmMain.Dev4.Connect_Net(frmConDev.txtIP4.Text, 4370)
            frmMain.Dev4.BASE64 = 0
            frmMain.Dev1.DisableDeviceWithTimeOut(1, 432000000)
            frmMain.Dev4.RegEvent(1, 32767)
            Return True
        Else
            frmMain.StatDev4.Text = "Disconnected"
            frmMain.StatDev4.ForeColor = Color.Maroon
            Return False
        End If
    End Function

    Public Sub stopread()
        devDisCon()
        frmMain.tmrPingDev1.Enabled = False
        frmMain.tmrPingDev2.Enabled = False
        devDisCon()
    End Sub
End Module
