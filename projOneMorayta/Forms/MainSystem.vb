Imports System.Threading
Public Class MainSystem
    Private Delegate Sub LoadDev()
    Private Delegate Sub LoadStart()


    Public Function IsProcessRunning(ByVal name As String) As Boolean
        For Each clsProcess As Process In Process.GetProcesses()
            If clsProcess.ProcessName.StartsWith(name) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txtTimeDate.Text = Format(Now, "long date") & "    " & Format(Now, "HH:mm:ss tt")

        With My.Settings
            If .EnableRestart1 = True Then
                Dim strSetOras1 As String = Format(.Restart1, "HH:mm:ss")
                Dim strOrasngaun1 As String = Format(Now, "HH:mm:ss")
                If strSetOras1 = strOrasngaun1 Then
                    If IsProcessRunning(Application.StartupPath & "\prjStarter.exe") = False Then
                        Process.Start(Application.StartupPath & "\prjStarter.exe")
                        Application.ExitThread()
                    End If
                End If
            End If

            If .EnableRestart2 = True Then
                Dim strSetOras2 As String = Format(.Restart2, "HH:mm:ss")
                Dim strOrasngaun2 As String = Format(Now, "HH:mm:ss")
                If strSetOras2 = strOrasngaun2 Then
                    If IsProcessRunning(Application.StartupPath & "\prjStarter.exe") = False Then
                        Process.Start(Application.StartupPath & "\prjStarter.exe")
                        Application.ExitThread()
                    End If
                End If
            End If

            If .EnableRestart3 = True Then
                Dim strSetOras3 As String = Format(.Restart3, "HH:mm:ss")
                Dim strOrasngaun3 As String = Format(Now, "HH:mm:ss")
                If strSetOras3 = strOrasngaun3 Then
                    If IsProcessRunning(Application.StartupPath & "\prjStarter.exe") = False Then
                        Process.Start(Application.StartupPath & "\prjStarter.exe")
                        Application.ExitThread()
                    End If
                End If
            End If

        End With
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        frmDevrec.ShowDialog()
    End Sub

    Private Sub MainSystem_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.ExitThread()
    End Sub

    Private Sub MainSystem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            frmLogin.ShowDialog()
        End If
    End Sub

    Private Sub MainSystem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
     
    End Sub

    Private Sub MainSystem_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim th As New Thread(New ThreadStart(Sub() mainLoad()))
        th.Start()
    End Sub

    Sub mainLoad()
        If (InvokeRequired) Then
            Invoke(New LoadStart(AddressOf mainLoad))
        Else
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
            Dim th As New Thread(New ThreadStart(Sub() LoadDevList()))
            th.Start()

            lock()
        End If
    End Sub

    Sub LoadDevList()
        If (InvokeRequired) Then
            Invoke(New LoadDev(AddressOf LoadDevList))
        Else
            If subSQl() = False Then
                Exit Sub
            End If

            Try
                Dim rs As New Recordset
                rs = New Recordset

                rs = conSql.Execute("select * from tbldevices")
                Do While rs.EOF = False

                    DevStructure.Dev_Name = rs("DeviceName").Value
                    DevStructure.Dev_Ip = rs("Ip").Value
                    DevStructure.Dev_Frame = rs("Frame").Value
                    DevStructure.Dev_Stat = rs("Status").Value
                    DevStructure.Dev_Delay = rs("Delay").Value

                    Sleep(1000)
                    Dim dev As New Dev1Control
                    PanelDev.Controls.Add(dev)

                    rs.MoveNext()
                Loop
            Catch ex As Exception
                txtSystemErr.Text = ex.Message
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        frmLogin.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        logout()
        lock()

        txtAdmin.Text = vbNullString
        Access = vbNullString
    End Sub

    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        If MsgBox("Are you sure do you want to exit?    ", vbYesNo + vbQuestion + vbDefaultButton2, "Exit") = vbYes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub AdministratorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministratorToolStripMenuItem.Click
        frmAdminAcc.ShowDialog()
    End Sub

    Private Sub EmployeeRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeRecordToolStripMenuItem.Click
        frmEmployee.ShowDialog()
    End Sub

    Private Sub MySQLConnectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MySQLConnectionToolStripMenuItem.Click
        frmConDB.ShowDialog()
    End Sub

    Private Sub MSAccessConnectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSAccessConnectionToolStripMenuItem.Click
        frmDBPathCon.ShowDialog()
    End Sub

    Private Sub CameraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CameraToolStripMenuItem.Click
        frmCamSettings.ShowDialog()
    End Sub

    Private Sub SetSystemLogoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetSystemLogoToolStripMenuItem.Click
        frmLogo.ShowDialog()
    End Sub

    Private Sub ByDateAndTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByDateAndTimeToolStripMenuItem.Click
        frmLogs.ShowDialog()
    End Sub

    Private Sub CaptureImageDesignatePathToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaptureImageDesignatePathToolStripMenuItem.Click
        frmImgDesig.ShowDialog()
    End Sub

    Private Sub EmployeeImageDesignatePathToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeImageDesignatePathToolStripMenuItem.Click
        frmEmpImgPath.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        frmDowloadLogs.ShowDialog()
    End Sub

    Private Sub ShiftManagementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShiftManagementToolStripMenuItem.Click
        frmAccessGroup.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        frmPsb.ShowDialog()
    End Sub

    Private Sub SystemAutoRestartSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemAutoRestartSettingsToolStripMenuItem.Click
        frmAutoRestart.ShowDialog()
    End Sub
End Class