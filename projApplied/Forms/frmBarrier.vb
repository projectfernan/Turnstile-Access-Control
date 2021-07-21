﻿Public Class frmBarrier

    Private Sub frmBarrier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub save()
        With My.Settings
            .PortAdd = txtPortAdd.Text
            .StatAdd = txtStatAdd.Text
            .Port = txtPort.Value
            .Extport = txtExtPort.Value
            .Delay = txtDelay.Value
            .LoopCode = txtLoop.Value
            .Save()
        End With
    End Sub

    Private Sub cmdCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCon.Click
        save()
        MsgBox("Barrier settings saved!    ", MsgBoxStyle.Information, "Barrier Settings")
        Me.Close()
    End Sub

    Private Sub cmdTest1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest1.Click
        If txtPortAdd.Text = vbNullString Then
            MsgBox("Please enter port address!    ", MsgBoxStyle.Exclamation, "Trigger settings")
            txtPortAdd.Focus()
            Exit Sub
        End If

        If txtPort.Value = vbNullString Then
            MsgBox("Please enter Entry port!    ", MsgBoxStyle.Exclamation, "Trigger settings")
            txtPort.Focus()
            Exit Sub
        End If

        If txtDelay.Value = vbNullString Then
            MsgBox("Please enter delay!    ", MsgBoxStyle.Exclamation, "Trigger settings")
            txtDelay.Focus()
            Exit Sub
        End If
        trigerOff()
        triger()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdTestExt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTestExt.Click
        If txtPortAdd.Text = vbNullString Then
            MsgBox("Please enter port address!    ", MsgBoxStyle.Exclamation, "Trigger settings")
            txtPortAdd.Focus()
            Exit Sub
        End If

        If txtExtPort.Value = vbNullString Then
            MsgBox("Please enter Exit port!    ", MsgBoxStyle.Exclamation, "Trigger settings")
            txtExtPort.Focus()
            Exit Sub
        End If

        If txtDelay.Value = vbNullString Then
            MsgBox("Please enter delay!    ", MsgBoxStyle.Exclamation, "Trigger settings")
            txtDelay.Focus()
            Exit Sub
        End If
        trigerOff()
        trigerExt()
    End Sub

    Private Sub tmrInp_Tick(sender As System.Object, e As System.EventArgs) Handles tmrInp.Tick
        txtOutput.Text = Output(txtStatAdd.Text)
    End Sub

    Private Sub cmdPin_Click(sender As System.Object, e As System.EventArgs) Handles cmdPin.Click
        If cmdPin.Text = "  Scan Pin" Then
            cmdPin.Text = "  Stop"
            tmrInp.Enabled = True
            Exit Sub
        End If

        If cmdPin.Text = "  Stop" Then
            cmdPin.Text = "  Scan Pin"
            tmrInp.Enabled = False
            Exit Sub
        End If
    End Sub
End Class