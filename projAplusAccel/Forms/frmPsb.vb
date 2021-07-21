Public Class frmPsb
    Public psbFlag As String
    Sub save()
        With My.Settings
            If OnAntiPsb.Checked = True Then
                .PSb_Set = True
            Else
                .PSb_Set = False
            End If
            .Save()
        End With
    End Sub

    Private Sub frmPsb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With My.Settings

            If .PSb_Set = True Then
                OnAntiPsb.Checked = True
                OffAntiPsb.Checked = False
            Else
                OffAntiPsb.Checked = True
                OnAntiPsb.Checked = False
            End If
        End With
    End Sub

    Private Sub cmdSubmit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubmit.Click
        save()
        MsgBox("Anti passback sttings saved!    ", vbInformation, "Anti Passback Settings")
        Me.Close()
    End Sub
End Class