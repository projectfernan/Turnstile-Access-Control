Public Class MainControl

    Private Sub MainControl_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            frmLogin.ShowDialog()
        End If

        If e.KeyCode = Keys.Escape Then
            If MsgBox("Are you sure do you want to logout? ", vbYesNo + vbQuestion + vbDefaultButton2, "Logout") = vbYes Then
                txtDesig.Text = "System :"
                txtSystemUser.Text = "Lock"
                Exit Sub
            End If
        End If
    End Sub

    Private Sub MainControl_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

        ViewConn()

        If conServer() = True Then
            If frmLogo.chk = False Then
                Pic2Sa.Image = Logo_Image()
            End If
        End If

        If ConPath() = True Then

        End If

        PanelDev.Controls.Clear()
        LoadDevList()
    End Sub

    Sub LoadDevList()
        If conServer() = False Then
            Exit Sub
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSql.Execute("select * from tbldevices")
            Do While rs.EOF = False
                Dev_Name = rs("DeviceName").Value
                Dev_Ip = rs("Ip").Value
                Dev_Frame = rs("Frame").Value
                Dev_Stat = rs("Status").Value
                Dev_Delay = rs("Delay").Value

                Dvr_IP = rs("DvrIP").Value
                Dvr_UID = rs("DvrUID").Value
                Dvr_PWD = rs("DvrPWD").Value
                Dvr_Port = rs("DvrPort").Value
                Dvr_Cam_Chan = rs("DvrCamChannel").Value
                Dvr_Cam_Capture = rs("DvrCamCapture").Value

                Dim dev As New DevControl
                PanelDev.Controls.Add(dev)

                rs.MoveNext()
            Loop
        Catch ex As Exception
            txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        txtTimeDate.Text = Format(Now, "long date") & "    " & Format(Now, "HH:mm:ss tt")
    End Sub
End Class