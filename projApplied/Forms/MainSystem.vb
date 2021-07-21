Public Class MainSystem

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        txtTimeDate.Text = Format(Now, "long date") & "    " & Format(Now, "HH:mm:ss tt")
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
        frmDevrec.ShowDialog()
    End Sub

    Private Sub MainSystem_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            frmLogin.ShowDialog()
        End If
    End Sub

    Private Sub MainSystem_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        'Server
        setcon()
        If subSQl() = True Then
            If frmLogo.chk = False Then
                Pic2Sa.Image = Logo_Image()
            End If
        End If

        'msAccessDB
        ConPath()

        'LoadDevices
        LoadDevList()

        lock()
    End Sub

    Sub LoadDevList()
        If subSQl() = False Then
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

                Sleep(1000)
                Dim dev As New Dev1Control
                PanelDev.Controls.Add(dev)

                rs.MoveNext()
            Loop
        Catch ex As Exception
            txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem2.Click
        frmLogin.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        logout()
        lock()
  
        txtAdmin.Text = vbNullString
        Access = vbNullString
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        If MsgBox("Are you sure do you want to exit?    ", vbYesNo + vbQuestion + vbDefaultButton2, "Exit") = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub AdministratorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AdministratorToolStripMenuItem.Click
        frmAdminAcc.ShowDialog()
    End Sub

    Private Sub EmployeeRecordToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EmployeeRecordToolStripMenuItem.Click
        frmEmployee.ShowDialog()
    End Sub

    Private Sub MySQLConnectionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MySQLConnectionToolStripMenuItem.Click
        frmConDB.ShowDialog()
    End Sub

    Private Sub MSAccessConnectionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MSAccessConnectionToolStripMenuItem.Click
        frmDBPathCon.ShowDialog()
    End Sub

    Private Sub CameraToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CameraToolStripMenuItem.Click
        frmCamSettings.ShowDialog()
    End Sub

    Private Sub SetSystemLogoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SetSystemLogoToolStripMenuItem.Click
        frmLogo.ShowDialog()
    End Sub

    Private Sub ByDateAndTimeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ByDateAndTimeToolStripMenuItem.Click
        frmLogs.ShowDialog()
    End Sub

    Private Sub CaptureImageDesignatePathToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CaptureImageDesignatePathToolStripMenuItem.Click
        frmImgDesig.ShowDialog()
    End Sub

    Private Sub EmployeeImageDesignatePathToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EmployeeImageDesignatePathToolStripMenuItem.Click
        frmEmpImgPath.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem4.Click
        frmDowloadLogs.ShowDialog()
    End Sub
End Class