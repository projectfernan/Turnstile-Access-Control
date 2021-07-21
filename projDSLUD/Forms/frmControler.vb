Public Class frmControler

    Sub port()
        With ComboPort
            If .Text = "COM1" Then
                com = 0
            ElseIf .Text = "COM2" Then
                com = 1
            ElseIf .Text = "COM3" Then
                com = 2
            ElseIf .Text = "COM4" Then
                com = 3
            End If
        End With
    End Sub

    Sub save()
        port()
        With My.Settings
            .CR_SRno = txtControlSN.Text
            .CR_SRport = com
            .CR_Com = ComboPort.Text
            .Save()
        End With
    End Sub

    Private Sub cmdCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCon.Click
        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database")
            frmConDB.ShowDialog()
            Exit Sub
        End If
        close_com()
        port()
        save()

        With MainForm
            If ctrlCon() = True Then
                .txtCtrlStat.Visible = False
                .txtRuning.Visible = True
            Else
                .txtCtrlStat.Text = "Disconnected"
                .txtCtrlStat.ForeColor = Color.Red
            End If
        End With

        MsgBox("Controller settings saved!    ", vbInformation, "Controller")
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
End Class