Public Class frmPassBack
    Public psbFlag As String
    Private Sub frmPassBack_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'OnAntiPsb.Checked = True
        With My.Settings
            If .PSb_Set = "OnPSB" Then
                OnAntiPsb.Checked = True
            Else
                OffAntiPsb.Checked = True
            End If
        End With
    End Sub

    Private Sub cmdSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubmit.Click
        psbFlag = vbNullString
        If OnAntiPsb.Checked = True Then
            psbFlag = "OnPSB"
            save()
        ElseIf OffAntiPsb.Checked = True Then
            psbFlag = "OffPSB"
            save()
        End If
        MsgBox("Anti passback sttings saved!    ", vbInformation, "Anti Passback Settings")
        Me.Close()
    End Sub
    Sub save()
        With My.Settings
            .PSb_Set = psbFlag
            .Save()
        End With
    End Sub
    Sub offPsb()
        With My.Settings
            .PSb_Set = psbFlag
            .Save()
        End With
    End Sub

    Private Sub OnAntiPsb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnAntiPsb.CheckedChanged

    End Sub

    Private Sub OffAntiPsb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OffAntiPsb.CheckedChanged

    End Sub
End Class