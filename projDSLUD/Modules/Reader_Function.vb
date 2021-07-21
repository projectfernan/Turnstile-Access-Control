Module Reader_Function

    Sub Dev1DisConnect()
        With MainForm
            .Dev1.EndInit()
            .Dev1.Disconnect()

            .txtDev1Stat.Text = "Disconnected"
            .txtDev1Stat.ForeColor = Color.Red
        End With
    End Sub

    Sub Dev2DisConnect()
        With MainForm
            .Dev2.EndInit()
            .Dev2.Disconnect()

            .txtDev2Stat.Text = "Disconnected"
            .txtDev2Stat.ForeColor = Color.Red
        End With
    End Sub

    Public Function Dev1Conn(ByVal ipAdd As String) As Boolean
        With MainForm
            If PingMe(ipAdd) = True Then
                .Dev1.BeginInit()
                .Dev1.Connect_Net(ipAdd, 4370)
                .Dev1.BASE64 = 0
                .Dev1.RegEvent(1, 32767)
                Return True
            Else
                Return False
            End If
        End With
    End Function

    Public Function Dev2Conn(ByVal ipAdd As String) As Boolean
        With MainForm
            If PingMe(ipAdd) = True Then
                .Dev2.BeginInit()
                .Dev2.Connect_Net(ipAdd, 4370)
                .Dev2.BASE64 = 0
                .Dev2.RegEvent(1, 32767)
                Return True
            Else
                Return False
            End If
        End With
    End Function

    Public Sub viewReaderSet()
        With My.Settings
            frmDevConn.txtDev1IP.Text = .DEV1_IP
            frmDevConn.txtDev2IP.Text = .DEV2_IP
            frmDevConn.txtDelay.Text = .CLEAR_delay
        End With
    End Sub

End Module
