Public Class frmMsg
    Sub save()
        With My.Settings
            .Sys_Msg = txtmsg.Text
            .Save()
        End With
    End Sub
    Sub viw()
        With My.Settings
            txtmsg.Text = .Sys_Msg
        End With
    End Sub
    Private Sub cmdSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubmit.Click
        save()
        MsgBox("System message saved!    ", vbInformation, "Save")
        frmMain.sysMsg.Text = My.Settings.Sys_Msg
        Me.Close()
    End Sub

    Private Sub frmMsg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viw()
    End Sub
End Class