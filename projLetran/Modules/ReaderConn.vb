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
        With frmSystemMain
            .Dev1.EndInit()
            .Dev2.EndInit()
            .Dev1.Disconnect()
            .Dev2.Disconnect()

            .Dev1Stat.Text = "Disconnected"
            .Dev1Stat.ForeColor = Color.Red
            .Dev2Stat.Text = "Disconnected"
            .Dev2Stat.ForeColor = Color.Red
        End With
    End Sub

    Sub t2devDisCon()
        With frmSystemMain
            .Dev3.EndInit()
            .Dev4.EndInit()
            .Dev3.Disconnect()
            .Dev4.Disconnect()

            .Dev3Stat.Text = "Disconnected"
            .Dev3Stat.ForeColor = Color.Red
            .Dev4Stat.Text = "Disconnected"
            .Dev4Stat.ForeColor = Color.Red
        End With
    End Sub

    Sub t3devDisCon()
        With frmSystemMain
            .Dev5.EndInit()
            .Dev6.EndInit()
            .Dev5.Disconnect()
            .Dev6.Disconnect()

            .Dev5Stat.Text = "Disconnected"
            .Dev5Stat.ForeColor = Color.Red
            .Dev6Stat.Text = "Disconnected"
            .Dev6Stat.ForeColor = Color.Red
        End With
    End Sub

    Sub t4devDisCon()
        With frmSystemMain
            .Dev7.EndInit()
            .Dev8.EndInit()
            .Dev7.Disconnect()
            .Dev8.Disconnect()

            .Dev7Stat.Text = "Disconnected"
            .Dev7Stat.ForeColor = Color.Red
            .Dev8Stat.Text = "Disconnected"
            .Dev8Stat.ForeColor = Color.Red
        End With
    End Sub

    Public Function t1devcon1(ByVal ipAdd As String) As Boolean

        If PingMe(ipAdd) = True Then
            frmSystemMain.Dev1Stat.Text = "Connected"
            frmSystemMain.Dev1Stat.ForeColor = Color.Blue
            frmSystemMain.Dev1.BeginInit()
            frmSystemMain.Dev1.Connect_Net(ipAdd, 4370)
            frmSystemMain.Dev1.BASE64 = 0
            frmSystemMain.Dev1.RegEvent(1, 32767)
            Return True
        Else
            frmSystemMain.Dev1Stat.Text = "Disconnected"
            frmSystemMain.Dev1Stat.ForeColor = Color.Red
            Return False
        End If
    End Function

    Public Function t1devcon2(ByVal ipAdd As String) As Boolean
        If PingMe(ipAdd) = True Then
            frmSystemMain.Dev2Stat.Text = "Connected"
            frmSystemMain.Dev2Stat.ForeColor = Color.Blue
            frmSystemMain.Dev2.BeginInit()
            frmSystemMain.Dev2.Connect_Net(ipAdd, 4370)
            frmSystemMain.Dev2.BASE64 = 0
            frmSystemMain.Dev2.RegEvent(1, 32767)
            Return True
        Else
            frmSystemMain.Dev2Stat.Text = "Disconnected"
            frmSystemMain.Dev2Stat.ForeColor = Color.Red
            Return False
        End If
    End Function

    Public Function t2devcon1(ByVal ipAdd As String) As Boolean
        If PingMe(ipAdd) = True Then
            frmSystemMain.Dev3Stat.Text = "Connected"
            frmSystemMain.Dev3Stat.ForeColor = Color.Blue
            frmSystemMain.Dev3.BeginInit()
            frmSystemMain.Dev3.Connect_Net(ipAdd, 4370)
            frmSystemMain.Dev3.BASE64 = 0
            frmSystemMain.Dev3.RegEvent(1, 32767)
            Return True
        Else
            frmSystemMain.Dev3Stat.Text = "Disconnected"
            frmSystemMain.Dev3Stat.ForeColor = Color.Red
            Return False
        End If
    End Function

    Public Function t2devcon2(ByVal ipAdd As String) As Boolean
        If PingMe(ipAdd) = True Then
            frmSystemMain.Dev4Stat.Text = "Connected"
            frmSystemMain.Dev4Stat.ForeColor = Color.Blue
            frmSystemMain.Dev4.BeginInit()
            frmSystemMain.Dev4.Connect_Net(ipAdd, 4370)
            frmSystemMain.Dev4.BASE64 = 0
            frmSystemMain.Dev4.RegEvent(1, 32767)
            Return True
        Else
            frmSystemMain.Dev4Stat.Text = "Disconnected"
            frmSystemMain.Dev4Stat.ForeColor = Color.Red
            Return False
        End If
    End Function

    Public Function t3devcon1(ByVal ipAdd As String) As Boolean
        If PingMe(ipAdd) = True Then
            frmSystemMain.Dev5Stat.Text = "Connected"
            frmSystemMain.Dev5Stat.ForeColor = Color.Blue
            frmSystemMain.Dev5.BeginInit()
            frmSystemMain.Dev5.Connect_Net(ipAdd, 4370)
            frmSystemMain.Dev5.BASE64 = 0
            frmSystemMain.Dev5.RegEvent(1, 32767)
            Return True
        Else
            frmSystemMain.Dev5Stat.Text = "Disconnected"
            frmSystemMain.Dev5Stat.ForeColor = Color.Red
            Return False
        End If
    End Function

    Public Function t3devcon2(ByVal ipAdd As String) As Boolean
        If PingMe(ipAdd) = True Then
            frmSystemMain.Dev6Stat.Text = "Connected"
            frmSystemMain.Dev6Stat.ForeColor = Color.Blue
            frmSystemMain.Dev6.BeginInit()
            frmSystemMain.Dev6.Connect_Net(ipAdd, 4370)
            frmSystemMain.Dev6.BASE64 = 0
            frmSystemMain.Dev6.RegEvent(1, 32767)
            Return True
        Else
            frmSystemMain.Dev6Stat.Text = "Disconnected"
            frmSystemMain.Dev6Stat.ForeColor = Color.Red
            Return False
        End If
    End Function

    Public Function t4devcon1(ByVal ipAdd As String) As Boolean
        If PingMe(ipAdd) = True Then
            frmSystemMain.Dev7Stat.Text = "Connected"
            frmSystemMain.Dev7Stat.ForeColor = Color.Blue
            frmSystemMain.Dev7.BeginInit()
            frmSystemMain.Dev7.Connect_Net(ipAdd, 4370)
            frmSystemMain.Dev7.BASE64 = 0
            frmSystemMain.Dev7.RegEvent(1, 32767)
            Return True
        Else
            frmSystemMain.Dev7Stat.Text = "Disconnected"
            frmSystemMain.Dev7Stat.ForeColor = Color.Red
            Return False
        End If
    End Function

    Public Function t4devcon2(ByVal ipAdd As String) As Boolean
       If PingMe(ipAdd) = True Then
            frmSystemMain.Dev8Stat.Text = "Connected"
            frmSystemMain.Dev8Stat.ForeColor = Color.Blue
            frmSystemMain.Dev8.BeginInit()
            frmSystemMain.Dev8.Connect_Net(ipAdd, 4370)
            frmSystemMain.Dev8.BASE64 = 0
            frmSystemMain.Dev8.RegEvent(1, 32767)
            Return True
        Else
            frmSystemMain.Dev8Stat.Text = "Disconnected"
            frmSystemMain.Dev8Stat.ForeColor = Color.Red
            Return False
        End If
    End Function
End Module
