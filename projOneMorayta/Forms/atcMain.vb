Imports System.Threading
Public Class atcMain

    Private Delegate Sub LoadDev()
    Private Delegate Sub LoadStart()

    Private Sub atcMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Control = True And e.KeyCode = Keys.Enter Then
            frmLogin.ShowDialog()
        End If

        If e.Control = True And e.KeyCode = Keys.Insert Then
            If txtAdmin.Text <> vbNullString Then
                frmControlPanel.ShowDialog()
            End If
        End If

        If e.Shift = True And e.KeyCode = Keys.Escape Then
            If MsgBox("Are you sure do you want to logout? ", vbQuestion + vbYesNo + vbDefaultButton2, "Logout") = vbYes Then
                SystemLocked()
            End If
        End If
    End Sub
    Private Sub atcMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LstEntyLogs.Clear()
        headerEntry()

        lstExitLogs.Clear()
        headerExit()
    End Sub

    Sub headerEntry()
        Dim w As Integer = LstEntyLogs.Width / 5
        LstEntyLogs.Columns.Add("TimeIn", w, HorizontalAlignment.Left)
        LstEntyLogs.Columns.Add("IDnumber", w, HorizontalAlignment.Left)
        LstEntyLogs.Columns.Add("Name", w, HorizontalAlignment.Left)
        LstEntyLogs.Columns.Add("Positon", w, HorizontalAlignment.Left)
        LstEntyLogs.Columns.Add("Lane", w, HorizontalAlignment.Left)
    End Sub

    Sub headerExit()
        Dim w As Integer = lstExitLogs.Width / 5
        lstExitLogs.Columns.Add("TimeOut", w, HorizontalAlignment.Left)
        lstExitLogs.Columns.Add("IDnumber", w, HorizontalAlignment.Left)
        lstExitLogs.Columns.Add("Name", w, HorizontalAlignment.Left)
        lstExitLogs.Columns.Add("Positon", w, HorizontalAlignment.Left)
        lstExitLogs.Columns.Add("Lane", w, HorizontalAlignment.Left)
    End Sub

    Sub fillEntryLogs(ByVal IDno As String, ByVal Name As String, ByVal Posi As String, ByVal tme As String, ByVal Lane As String)

        Dim viewlst As New ListViewItem
        viewlst = LstEntyLogs.Items.Add(tme)
        viewlst.SubItems.Add(IDno)
        viewlst.SubItems.Add(Name)
        viewlst.SubItems.Add(Posi)
        viewlst.SubItems.Add(Lane)
        'lstList.Refresh()
    End Sub

    Sub fillExitLogs(ByVal IDno As String, ByVal Name As String, ByVal Posi As String, ByVal tme As String, ByVal Lane As String)

        Dim viewlst As New ListViewItem
        viewlst = lstExitLogs.Items.Add(tme)
        viewlst.SubItems.Add(IDno)
        viewlst.SubItems.Add(Name)
        viewlst.SubItems.Add(Posi)
        viewlst.SubItems.Add(Lane)
        'lstList.Refresh()
    End Sub

    Sub fillReviewEnt()
        Dim viewlst As New ListViewItem
        Dim lup As Integer = 1

        For Each viewlst In LstEntyLogs.Items
            If lup > 4 Then Exit For


            Select Case lup
                Case 1
                    PicEntry1.Image = Get_PicEmp(viewlst.SubItems(1).Text)
                Case 2
                    PicEntry2.Image = Get_PicEmp(viewlst.SubItems(1).Text)
                Case 3
                    PicEntry3.Image = Get_PicEmp(viewlst.SubItems(1).Text)
                Case 4
                    PicEntry4.Image = Get_PicEmp(viewlst.SubItems(1).Text)
            End Select
            lup = lup + 1
        Next
    End Sub

    Sub fillReviewExt()
        Dim viewlst As New ListViewItem
        Dim lup As Integer = 1

        For Each viewlst In lstExitLogs.Items
            If lup > 4 Then Exit For


            Select Case lup
                Case 1
                    PicExit1.Image = Get_PicEmp(viewlst.SubItems(1).Text)
                Case 2
                    PicExit2.Image = Get_PicEmp(viewlst.SubItems(1).Text)
                Case 3
                    PicExit3.Image = Get_PicEmp(viewlst.SubItems(1).Text)
                Case 4
                    PicExit4.Image = Get_PicEmp(viewlst.SubItems(1).Text)
            End Select
            lup = lup + 1
        Next
    End Sub

   

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txtTimeDate.Text = Format(Now, "long date") & "    " & Format(Now, "HH:mm:ss tt")
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

    Private Sub atcMain_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Server
        setcon()
        If subSQl() = True Then
            If frmLogo.chk = False Then
                Pic2Sa.Image = Logo_Image()
            End If
        End If

        subSQlLoc()

        'LoadDevices
        Dim th As New Thread(New ThreadStart(Sub() LoadDevList()))
        th.Start()

        SystemLocked()
    End Sub

    Private Sub LstEntyLogs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstEntyLogs.SelectedIndexChanged
        Dim viewlst As New ListViewItem
        For Each viewlst In LstEntyLogs.Items
            If viewlst.Selected = True Then
                EntryImg.Image = Get_PicEmp(viewlst.SubItems(1).Text)
            End If
        Next
    End Sub

    Private Sub lstExitLogs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstExitLogs.SelectedIndexChanged
        Dim viewlst As New ListViewItem
        For Each viewlst In lstExitLogs.Items
            If viewlst.Selected = True Then
                ExitImg.Image = Get_PicEmp(viewlst.SubItems(1).Text)
            End If
        Next
    End Sub
End Class