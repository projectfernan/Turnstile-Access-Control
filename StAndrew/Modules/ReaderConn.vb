Imports ADODB
Module ReaderConn
    Public devNo As String
    Public devNo2 As String
    Public Sub tbldevcon()
        Try
            With My.Settings
                frmConDev.T1DevIp1.Text = .T1Dev1
                frmConDev.T1DevIp2.Text = .T1Dev2

                frmConDev.T2DevIp1.Text = .T2Dev1
                frmConDev.T2DevIp2.Text = .T2Dev2

                frmConDev.T3DevIp1.Text = .T3Dev1
                frmConDev.T3DevIp2.Text = .T3Dev2

                frmConDev.T4DevIp1.Text = .T4Dev1
                frmConDev.T4DevIp2.Text = .T4Dev2
            End With
        Catch ex As Exception

        End Try
    End Sub
    Sub t1devDisCon()
        With frmMain
            .T1Dev1.EndInit()
            .T1Dev2.EndInit()
            .T1Dev1.Disconnect()
            .T1Dev2.Disconnect()
        End With
        frmMain.T1Dev1Stat.Text = "Disconnected"
        frmMain.T1Dev1Stat.ForeColor = Color.Red
        frmMain.T1Dev2Stat.Text = "Disconnected"
        frmMain.T1Dev2Stat.ForeColor = Color.Red
    End Sub
    Sub t2devDisCon()
        With frmMain
            .T2Dev1.EndInit()
            .T2Dev2.EndInit()
            .T2Dev1.Disconnect()
            .T2Dev2.Disconnect()
        End With
        frmMain.T2Dev1Stat.Text = "Disconnected"
        frmMain.T2Dev1Stat.ForeColor = Color.Red
        frmMain.T2Dev2Stat.Text = "Disconnected"
        frmMain.T2Dev2Stat.ForeColor = Color.Red
    End Sub
    Sub t3devDisCon()
        With frmMain
            .T3Dev1.EndInit()
            .T3Dev2.EndInit()
            .T3Dev1.Disconnect()
            .T3Dev2.Disconnect()
        End With
        frmMain.T3Dev1Stat.Text = "Disconnected"
        frmMain.T3Dev1Stat.ForeColor = Color.Red
        frmMain.T3Dev2Stat.Text = "Disconnected"
        frmMain.T3Dev2Stat.ForeColor = Color.Red
    End Sub
    Sub t4devDisCon()
        With frmMain
            .T4Dev1.EndInit()
            .T4Dev2.EndInit()
            .T4Dev1.Disconnect()
            .T4Dev2.Disconnect()
        End With
        frmMain.T4Dev1Stat.Text = "Disconnected"
        frmMain.T4Dev1Stat.ForeColor = Color.Red
        frmMain.T4Dev2Stat.Text = "Disconnected"
        frmMain.T4Dev2Stat.ForeColor = Color.Red
    End Sub
    Public Function devcon1() As Boolean
        If PingMe(frmConDev.T1DevIp1.Text) = True Then
            'frmMain.StatDev1.Text = "Connected"
            'frmMain.StatDev1.ForeColor = Color.Blue
            frmMain.T1Dev1.BeginInit()
            frmMain.T1Dev1.Connect_Net(frmConDev.T1DevIp1.Text, 4370)
            frmMain.T1Dev1.BASE64 = 0
            frmMain.T1Dev1.RegEvent(devNo, 32767)
            ' frmMain.tmrPingT1.Enabled = True
            Return True
        Else
            'frmMain.StatDev1.Text = "Disconnected"
            'frmMain.StatDev1.ForeColor = Color.Maroon
            'frmMain.tmrPingT1.Enabled = False
            Return False
        End If
    End Function
    Public Function devcon2() As Boolean
        'If PingMe(frmConDev.txtIP2.Text) = True Then
        'frmMain.StatDev2.Text = "Connected"
        'frmMain.StatDev2.ForeColor = Color.Blue
        frmMain.T1Dev2.BeginInit()
        'frmMain.T1Dev2.Connect_Net(frmConDev.txtIP2.Text, 4370)
        frmMain.T1Dev2.BASE64 = 0
        frmMain.T1Dev2.RegEvent(devNo2, 32767)
        'frmMain.tmrPingT2.Enabled = True
        Return True
        'Else
        'frmMain.StatDev2.Text = "Disconnected"
        'frmMain.StatDev2.ForeColor = Color.Maroon
        'frmMain.tmrPingT2.Enabled = False
        Return False
        'End If
    End Function
    Public Sub stopread()
        t1devDisCon()
        'frmMain.tmrPingT1.Enabled = False
        'frmMain.tmrPingT2.Enabled = False
        t1devDisCon()
    End Sub
    Public Function t1devcon1(ByVal ipAdd As String) As Boolean
        '
        If PingMe(ipAdd) = True Then
            frmMain.T1Dev1Stat.Text = "Connected"
            frmMain.T1Dev1Stat.ForeColor = Color.Blue
            frmMain.T1Dev1.BeginInit()
            frmMain.T1Dev1.Connect_Net(ipAdd, 4370)
            frmMain.T1Dev1.BASE64 = 0
            frmMain.T1Dev1.RegEvent(1, 32767)
            'frmMain.tmrPingT1.Enabled = True
            Return True
        Else
            frmMain.T1Dev1Stat.Text = "Disconnected"
            frmMain.T1Dev1Stat.ForeColor = Color.Red
            'frmMain.tmrPingDev1.Enabled = False
            Return False
        End If
    End Function
    Public Sub t1devcon11(ByVal ipAdd As String)
        If PingMe(ipAdd) = True Then
            frmMain.T1Dev1Stat.Text = "Connected"
            frmMain.T1Dev1Stat.ForeColor = Color.Blue
            frmMain.T1Dev1.BeginInit()
            frmMain.T1Dev1.Connect_Net(ipAdd, 4370)
            frmMain.T1Dev1.BASE64 = 0
            frmMain.T1Dev1.RegEvent(1, 32767)
            'frmMain.tmrPingT1.Enabled = True
        Else
            frmMain.T1Dev1Stat.Text = "Disconnected"
            frmMain.T1Dev1Stat.ForeColor = Color.Red
            'frmMain.tmrPingDev1.Enabled = False
        End If
    End Sub

    Public Function t1devcon2(ByVal ipAdd As String) As Boolean
        't1devDisCon()
        If PingMe(ipAdd) = True Then
            frmMain.T1Dev2Stat.Text = "Connected"
            frmMain.T1Dev2Stat.ForeColor = Color.Blue
            frmMain.T1Dev2.BeginInit()
            frmMain.T1Dev2.Connect_Net(ipAdd, 4370)
            frmMain.T1Dev2.BASE64 = 0
            frmMain.T1Dev2.RegEvent(1, 32767)
            'frmMain.tmrPingT1.Enabled = True
            Return True
        Else
            frmMain.T1Dev2Stat.Text = "Disconnected"
            frmMain.T1Dev2Stat.ForeColor = Color.Red
            'frmMain.tmrPingDev1.Enabled = False
            Return False
        End If
    End Function

    Public Function t2devcon1(ByVal ipAdd As String) As Boolean
        If PingMe(ipAdd) = True Then
            frmMain.T2Dev1Stat.Text = "Connected"
            frmMain.T2Dev1Stat.ForeColor = Color.Blue
            frmMain.T2Dev1.BeginInit()
            frmMain.T2Dev1.Connect_Net(ipAdd, 4370)
            frmMain.T2Dev1.BASE64 = 0
            frmMain.T2Dev1.RegEvent(1, 32767)
            'frmMain.tmrPingT2.Enabled = True
            Return True
        Else
            frmMain.T2Dev1Stat.Text = "Disconnected"
            frmMain.T2Dev1Stat.ForeColor = Color.Red
            'frmMain.tmrPingDev1.Enabled = False
            Return False
        End If
    End Function
    Public Function t2devcon2(ByVal ipAdd As String) As Boolean
        If PingMe(ipAdd) = True Then
            frmMain.T2Dev2Stat.Text = "Connected"
            frmMain.T2Dev2Stat.ForeColor = Color.Blue
            frmMain.T2Dev2.BeginInit()
            frmMain.T2Dev2.Connect_Net(ipAdd, 4370)
            frmMain.T2Dev2.BASE64 = 0
            frmMain.T2Dev2.RegEvent(1, 32767)
            'frmMain.tmrPingT2.Enabled = True
            Return True
        Else
            frmMain.T2Dev2Stat.Text = "Disconnected"
            frmMain.T2Dev2Stat.ForeColor = Color.Red
            'frmMain.tmrPingDev1.Enabled = False
            Return False
        End If
    End Function

    Public Function t3devcon1(ByVal ipAdd As String) As Boolean
        If PingMe(ipAdd) = True Then
            frmMain.T3Dev1Stat.Text = "Connected"
            frmMain.T3Dev1Stat.ForeColor = Color.Blue
            frmMain.T3Dev1.BeginInit()
            frmMain.T3Dev1.Connect_Net(ipAdd, 4370)
            frmMain.T3Dev1.BASE64 = 0
            frmMain.T3Dev1.RegEvent(1, 32767)
            'frmMain.tmrPingDev1.Enabled = True
            Return True
        Else
            frmMain.T3Dev1Stat.Text = "Disconnected"
            frmMain.T3Dev1Stat.ForeColor = Color.Red
            'frmMain.tmrPingDev1.Enabled = False
            Return False
        End If
    End Function
    Public Function t3devcon2(ByVal ipAdd As String) As Boolean
        If PingMe(ipAdd) = True Then
            frmMain.T3Dev2Stat.Text = "Connected"
            frmMain.T3Dev2Stat.ForeColor = Color.Blue
            frmMain.T3Dev2.BeginInit()
            frmMain.T3Dev2.Connect_Net(ipAdd, 4370)
            frmMain.T3Dev2.BASE64 = 0
            frmMain.T3Dev2.RegEvent(1, 32767)
            'frmMain.tmrPingDev1.Enabled = True
            Return True
        Else
            frmMain.T3Dev2Stat.Text = "Disconnected"
            frmMain.T3Dev2Stat.ForeColor = Color.Red
            'frmMain.tmrPingDev1.Enabled = False
            Return False
        End If
    End Function
    Public Function t4devcon1(ByVal ipAdd As String) As Boolean
        If PingMe(ipAdd) = True Then
            frmMain.T4Dev1Stat.Text = "Connected"
            frmMain.T4Dev1Stat.ForeColor = Color.Blue
            frmMain.T4Dev1.BeginInit()
            frmMain.T4Dev1.Connect_Net(ipAdd, 4370)
            frmMain.T4Dev1.BASE64 = 0
            frmMain.T4Dev1.RegEvent(1, 32767)
            'frmMain.tmrPingDev1.Enabled = True
            Return True
        Else
            frmMain.T4Dev1Stat.Text = "Disconnected"
            frmMain.T4Dev1Stat.ForeColor = Color.Red
            'frmMain.tmrPingDev1.Enabled = False
            Return False
        End If
    End Function
    Public Function t4devcon2(ByVal ipAdd As String) As Boolean
        If PingMe(ipAdd) = True Then
            frmMain.T4Dev2Stat.Text = "Connected"
            frmMain.T4Dev2Stat.ForeColor = Color.Blue
            frmMain.T4Dev2.BeginInit()
            frmMain.T4Dev2.Connect_Net(ipAdd, 4370)
            frmMain.T4Dev2.BASE64 = 0
            frmMain.T4Dev2.RegEvent(1, 32767)
            'frmMain.tmrPingDev1.Enabled = True
            Return True
        Else
            frmMain.T4Dev2Stat.Text = "Disconnected"
            frmMain.T4Dev2Stat.ForeColor = Color.Red
            'frmMain.tmrPingDev1.Enabled = False
            Return False
        End If
    End Function
End Module
