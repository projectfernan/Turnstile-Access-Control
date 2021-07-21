Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports WG3000_COMM.Core
Imports ADODB

Public Class frmAddController
    Private ControllerConn As Boolean
    Public watching As New wgWatchingService
    Public Event EventHandler(ByVal message As String)
    Public receivedPktCount As New Integer
    Public QueRecText As New Queue

    Private Delegate Sub txtInfoHaveNewInfo()
    Shared dealingTxt As Integer = 0
    Shared infoRowsCount As Integer = 0
    Dim seventhandler As OnEventHandler

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim snNo As Integer = txtSN.Text
        If wgMjController.GetControllerType(snNo) = 0 Then

        Else
            controler = New wgMjController
            controler.NetIPConfigure(txtSN.Text, txtMack.Text, txtIP.Text, txtSubnet.Text, txtGateway.Text, txtPort.Text, PCip)
            If Me.Text = "Add Controller" Then
                If ChkNodeExist(txtNodeName.Text) = False Then
                    Save()
                Else
                    MsgBox("Node name already exist! ", vbExclamation, "Save")
                End If
            Else
                Edit()
            End If


reconfig:
            controler.ControllerSN = CInt(txtSN.Text)
            controler.IP = txtIP.Text
            controler.PORT = txtPort.Text

            'tmeRead.Enabled = True

            'If ControllerConn = True Then
            Dim controlConfigure As New wgMjControllerConfigure

            controlConfigure.DoorControlSet(1, 3)
            controlConfigure.DoorControlSet(2, 3)

            controlConfigure.DoorDelaySet(1, txtTriggerDelay.Value)
            controlConfigure.DoorDelaySet(2, txtTriggerDelay.Value)
            My.Settings.TriggerDelay = txtTriggerDelay.Value
            My.Settings.Save()

            If controler.UpdateConfigureIP(controlConfigure) > 0 Then
                MsgBox("Controller successfully saved and configured! ", vbInformation, "Save")
            Else
                MsgBox("Failed to configure, Please connect the controller!", vbExclamation, "Save")
                ' GoTo reconfig
                Exit Sub
            End If
            'Else

            '    Exit Sub
            'End If

            Me.Close()
        End If
    End Sub

    Sub Save()
        If subSQlLoc() = False Then
            MsgBox("Please connect to server! ", vbInformation, "Save")
            'frmDbSettings.ShowDialog()
            Exit Sub
        End If

        If MsgBox("Are you sure your entries are correct? ", vbQuestion + vbYesNo + vbDefaultButton2, "Saves") = vbYes Then
            Try
                Dim rs As New Recordset
                rs = New Recordset

                rs.Open("select * from tblcontroler", conSqlLoc, 1, 2)
                rs.AddNew()
                rs("NodeName").Value = txtNodeName.Text
                rs("SN").Value = txtSN.Text
                rs("Ip").Value = txtIP.Text
                rs("Port").Value = txtPort.Text
                rs("MacAdd").Value = txtMack.Text
                rs("Subnet").Value = txtSubnet.Text
                rs("Gateway").Value = txtGateway.Text
                rs("PCip").Value = PCip
                rs("Lane").Value = cboLane.Text
                If chkAuto.Checked = False Then
                    rs("Stat").Value = 0
                Else
                    rs("Stat").Value = 1
                End If
                
                rs.Update()
                ' MsgBox("Controller successfully saved and configured! ", vbInformation, "Save")
                ' Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Save")
            End Try
        End If
    End Sub

    Sub Edit()
        If subSQlLoc() = False Then
            MsgBox("Please connect to server! ", vbInformation, "Save")
            ' frmDbSettings.ShowDialog()
            Exit Sub
        End If

        If MsgBox("Are you sure do you want to save changes? ", vbQuestion + vbYesNo + vbDefaultButton2, "Saves") = vbYes Then
            Try
                Dim rs As New Recordset
                rs = New Recordset

                rs.Open("select * from tblcontroler where SN = '" & txtSN.Text & "'", conSqlLoc, 1, 2)
                rs("NodeName").Value = txtNodeName.Text
                rs("SN").Value = txtSN.Text
                rs("Ip").Value = txtIP.Text
                rs("Port").Value = txtPort.Text
                rs("MacAdd").Value = txtMack.Text
                rs("Subnet").Value = txtSubnet.Text
                rs("Gateway").Value = txtGateway.Text
                rs("PCip").Value = PCip
                rs("Lane").Value = cboLane.Text
                If chkAuto.Checked = False Then
                    rs("Stat").Value = 0
                Else
                    rs("Stat").Value = 1
                End If
            
                rs.Update()

                ' Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Save")
            End Try
        End If
    End Sub

    Function ChkNodeExist(ByVal Node As String) As Boolean
        If subSQlLoc() = False Then Return False
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("select * from tblcontroler where NodeName = '" & Node & "'")
            If rs.EOF = False Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub cmdTest1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Camera_Connect(txtCamIP.Text, txtPortCam.Value, txtUser.Text, txtPass.Text, txtCam1.Value) = True Then
        '    MsgBox("Camera " & Cap1.Value.ToString & "successfully connected!", vbInformation, "Test Connect")
        'Else
        '    MsgBox("Failed to connect in Camera " & Cap1.Value.ToString & " !", vbExclamation, "Test Connect")
        'End If
    End Sub

    Public Sub updateControllerStatus()

        If watching Is Nothing Then

        Else
            Dim conRunInfo As wgMjControllerRunInformation = Nothing
            Dim commStatus As Integer
            commStatus = watching.CheckControllerCommStatus(CInt(txtSN.Text), conRunInfo)

            If commStatus = -1 Then
                ControllerConn = False
            ElseIf commStatus = 1 Then
                ControllerConn = True
            End If
        End If

    End Sub

    Private Sub txtInfoHaveNewInfoEntry()
        If dealingTxt > 0 Then
            Exit Sub
        End If
        If watching.WatchingController Is Nothing Then
            '2010-8-1 08:27:15 没有选中监控的就退出
            Exit Sub
        End If
        System.Threading.Interlocked.Exchange(dealingTxt, 1)
        Dim dealt As Integer = 0
        Dim obj As Object
        Dim startTicks As Long = DateTime.Now.Ticks
        ' Date.Now.Ticks  'us
        Dim updateSpan As Long = 2000 * 1000 * 10
        Dim endTicks As Long = startTicks + updateSpan
        ' '100毫微秒的倍数  '一个Ticks＝10亿分之一秒，一毫秒＝10000Ticks
        While QueRecText.Count > 0
            SyncLock QueRecText.SyncRoot
                '取出
                obj = QueRecText.Dequeue()
            End SyncLock
            txtInfoUpdateEntry(obj)
            infoRowsCount += 1
            dealt += 1
            If DateTime.Now.Ticks > endTicks Then
                endTicks = DateTime.Now.Ticks + updateSpan
                If watching.WatchingController Is Nothing Then
                    Exit While
                End If
            End If
        End While
        Application.DoEvents()
        '显示
        System.Threading.Interlocked.Exchange(dealingTxt, 0)
    End Sub

    Private Sub txtInfoUpdateEntry(ByVal info As Object)
        Dim mjrec As New wgMjControllerSwipeRecord(TryCast(info, String))
        If mjrec.ControllerSN > 0 Then
            Try
                If Not watching.WatchingController.ContainsKey(CInt(mjrec.ControllerSN)) Then
                    Return
                End If
            Catch generatedExceptionName As Exception
                Return
            End Try
            TextBox1.Text = vbNullString
            '  txtCode.Text = vbNullString
            TextBox1.AppendText(mjrec.ToDisplaySimpleInfo(True))
        End If
    End Sub
    Private Sub tmeRead_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmeRead.Tick
        tmeRead.Enabled = False
        If watching IsNot Nothing Then
            updateControllerStatus()
            If QueRecText.Count > 0 Then
                Me.Invoke(New txtInfoHaveNewInfo(AddressOf txtInfoHaveNewInfoEntry))
            End If
            Application.DoEvents()
            tmeRead.Enabled = True
        End If
    End Sub

    Private Sub frmAddController_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtTriggerDelay.Value = My.Settings.TriggerDelay
    End Sub
End Class