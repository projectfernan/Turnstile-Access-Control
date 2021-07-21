Imports System.Threading
Public Class moraytaMain
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

    Private Sub moraytaMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            frmLogin.ShowDialog()
        End If

        If e.Control = True And e.KeyCode = Keys.Insert Then
            If txtAdmin.Text <> "Locked" Then
                frmControlPanel.ShowDialog()
            End If
        End If

        If e.Shift = True And e.KeyCode = Keys.Escape Then
            If MsgBox("Are you sure do you want to logout? ", vbQuestion + vbYesNo + vbDefaultButton2, "Logout") = vbYes Then
                txtAdmin.Text = "Locked"
                SystemLocked()
            End If
        End If

    End Sub

    Private Sub moraytaMain_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        LstT1.Clear()
        headerT1()

        lstT2.Clear()
        headerT2()

        lstT3.Clear()
        headerT3()

        'Server()
        setcon()
        If subSQl() = True Then
            If frmLogo.chk = False Then
                Pic2Sa.Image = Logo_Image()
            End If
        Else
            frmConDB.ShowDialog()
        End If

        subSQlLoc()

        'LoadDevices
        Dim th As New Thread(New ThreadStart(Sub() LoadDevList()))
        th.Start()

        txtAdmin.Text = "Locked"
        SystemLocked()

    End Sub

    Sub LoadDevList()
        If (InvokeRequired) Then
            Invoke(New LoadDev(AddressOf LoadDevList))
        Else
            If subSQlLoc() = False Then
                Exit Sub
            End If

            Try
                Dim rs As New Recordset
                rs = New Recordset

                rs = conSqlLoc.Execute("select * from tbldevices")
                Do While rs.EOF = False
                    DevStructure.Dev_Name = rs("DeviceName").Value
                    DevStructure.Dev_Ip = rs("Ip").Value
                    DevStructure.Dev_Lane = rs("Lane").Value
                    DevStructure.Dev_Stat = rs("Status").Value
                    DevStructure.Dev_Delay = rs("Delay").Value

                    If rs("Startup").Value = 1 Then
                        Sleep(1000)
                        Dim dev As New Dev1Control
                        PanelDev.Controls.Add(dev)
                    End If

                    rs.MoveNext()
                Loop
            Catch ex As Exception
                txtSystemErr.Text = ex.Message
            End Try
        End If
    End Sub

    Sub headerT1()
        Dim w As Integer = LstT1.Width / 4
        Dim ww As Integer = w / 2
        Dim wLog As Integer = w / 4
        Dim wnlog As Integer = w - wLog
        Dim rb As Integer = ww + wLog
        LstT1.Columns.Add("", 0, HorizontalAlignment.Left)
        LstT1.Columns.Add("LogTime", wnlog, HorizontalAlignment.Left)
        LstT1.Columns.Add("Name", w, HorizontalAlignment.Left)
        LstT1.Columns.Add("Room", rb, HorizontalAlignment.Left)
        LstT1.Columns.Add("Stat", ww, HorizontalAlignment.Left)
        LstT1.Columns.Add("Remarks", w, HorizontalAlignment.Left)
    End Sub

    Sub headerT2()
        Dim w As Integer = lstT2.Width / 4
        Dim ww As Integer = w / 2
        Dim wLog As Integer = w / 4
        Dim wnlog As Integer = w - wLog
        Dim rb As Integer = ww + wLog
        lstT2.Columns.Add("", 0, HorizontalAlignment.Left)
        lstT2.Columns.Add("LogTime", wnlog, HorizontalAlignment.Left)
        lstT2.Columns.Add("Name", w, HorizontalAlignment.Left)
        lstT2.Columns.Add("Room", rb, HorizontalAlignment.Left)
        lstT2.Columns.Add("Stat", ww, HorizontalAlignment.Left)
        lstT2.Columns.Add("Remarks", w, HorizontalAlignment.Left)
    End Sub

    Sub headerT3()
        Dim w As Integer = lstT3.Width / 4
        Dim ww As Integer = w / 2
        Dim wLog As Integer = w / 4
        Dim wnlog As Integer = w - wLog
        Dim rb As Integer = ww + wLog
        lstT3.Columns.Add("", 0, HorizontalAlignment.Left)
        lstT3.Columns.Add("LogTime", wnlog, HorizontalAlignment.Left)
        lstT3.Columns.Add("Name", w, HorizontalAlignment.Left)
        lstT3.Columns.Add("Room", rb, HorizontalAlignment.Left)
        lstT3.Columns.Add("Stat", ww, HorizontalAlignment.Left)
        lstT3.Columns.Add("Remarks", w, HorizontalAlignment.Left)
    End Sub

    Sub fillT1Logs(ByVal fullDt As String, ByVal tme As String, ByVal Name As String, ByVal Room As String, ByVal Logstat As String, ByVal CardStat As String)
        Dim viewlst As New ListViewItem

        viewlst = LstT1.Items.Add(fullDt)
        viewlst.SubItems.Add(tme)
        viewlst.SubItems.Add(Name)
        viewlst.SubItems.Add(Room)
        viewlst.SubItems.Add(Logstat)
        viewlst.SubItems.Add(CardStat)

       

        Select Case CardStat
            Case "SEE ADMIN"
                viewlst.BackColor = Color.Red
                '  viewlst.ForeColor = Color.Blue
            Case "PLS ENTRY"
                viewlst.BackColor = Color.Yellow
                'viewlst.ForeColor = Color.Blue
            Case "PLS EXIT"
                viewlst.BackColor = Color.Yellow
                '  viewlst.ForeColor = Color.Blue
            Case "EXPIRED"
                viewlst.BackColor = Color.Red
                ' viewlst.ForeColor = Color.Blue
            Case "CURFEW"
                viewlst.BackColor = Color.Red
                '  viewlst.ForeColor = Color.Blue
            Case "UNKNOWN"
                viewlst.BackColor = Color.Yellow
            Case Else
                If Logstat = "IN" Then
                    viewlst.BackColor = Color.Lime
                Else
                    viewlst.BackColor = Color.White
                End If
                ' viewlst.ForeColor = Color.Black
        End Select

        'lstList.Refresh()
    End Sub

    Sub fillT2Logs(ByVal fullDt As String, ByVal tme As String, ByVal Name As String, ByVal Room As String, ByVal Logstat As String, ByVal CardStat As String)
        Dim viewlst As New ListViewItem

        viewlst = lstT2.Items.Add(fullDt)
        viewlst.SubItems.Add(tme)
        viewlst.SubItems.Add(Name)
        viewlst.SubItems.Add(Room)
        viewlst.SubItems.Add(Logstat)
        viewlst.SubItems.Add(CardStat)

        Select Case CardStat
            Case "SEE ADMIN"
                viewlst.BackColor = Color.Red
                '  viewlst.ForeColor = Color.Blue
            Case "PLS ENTRY"
                viewlst.BackColor = Color.Yellow
                ' viewlst.ForeColor = Color.Blue
            Case "PLS EXIT"
                viewlst.BackColor = Color.Yellow
                'viewlst.ForeColor = Color.Blue
            Case "EXPIRED"
                viewlst.BackColor = Color.Red
                '  viewlst.ForeColor = Color.Blue
            Case "CURFEW"
                viewlst.BackColor = Color.Red
                '  viewlst.ForeColor = Color.Blue
            Case "UNKNOWN"
                viewlst.BackColor = Color.Yellow
            Case Else
                If Logstat = "IN" Then
                    viewlst.BackColor = Color.Lime
                Else
                    viewlst.BackColor = Color.White
                End If
        End Select
        'lstList.Refresh()
    End Sub

    Sub fillT3Logs(ByVal fullDt As String, ByVal tme As String, ByVal Name As String, ByVal Room As String, ByVal Logstat As String, ByVal CardStat As String)

        Dim viewlst As New ListViewItem
        viewlst = lstT3.Items.Add(fullDt)
        viewlst.SubItems.Add(tme)
        viewlst.SubItems.Add(Name)
        viewlst.SubItems.Add(Room)
        viewlst.SubItems.Add(Logstat)
        viewlst.SubItems.Add(CardStat)

        Select Case CardStat
            Case "SEE ADMIN"
                viewlst.BackColor = Color.Red
                'viewlst.ForeColor = Color.Blue
            Case "PLS ENTRY"
                viewlst.BackColor = Color.Yellow
                ' viewlst.ForeColor = Color.Blue
            Case "PLS EXIT"
                viewlst.BackColor = Color.Yellow
                ' viewlst.ForeColor = Color.Blue
            Case "EXPIRED"
                viewlst.BackColor = Color.Red
                ' viewlst.ForeColor = Color.Blue
            Case "CURFEW"
                viewlst.BackColor = Color.Red
                '  viewlst.ForeColor = Color.Blue
            Case "UNKNOWN"
                viewlst.BackColor = Color.Yellow
            Case Else
                If Logstat = "IN" Then
                    viewlst.BackColor = Color.Lime
                Else
                    viewlst.BackColor = Color.White
                End If
        End Select
        'lstList.Refresh()
    End Sub

End Class