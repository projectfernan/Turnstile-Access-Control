Public Class frmPsb
    Public psbFlag As String
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
    Private Sub frmPsb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With My.Settings
            If .PSb_Set = vbNullString Then
                Exit Sub
            End If
            If .PSb_Set = "OnPSB" Then
                OnAntiPsb.Checked = True
            Else
                OffAntiPsb.Checked = True
            End If
        End With
    End Sub

    Private Sub cmdSubmit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubmit.Click
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
End Class