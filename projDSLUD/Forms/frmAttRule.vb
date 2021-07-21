Public Class frmAttRule

    Private Sub cmdCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub save()
        With My.Settings
            .OFH_in = dtOFHin.Value
            .OFH_Out = dtOFHout.Value
            .LR_CHLin = dtCHLin.Value
            .LR_CHLout = dtCHLout.Value
            .Save()
        End With
        ' .LR_CHLin = dtCHLin.Value
        ' .LR_CHLout = dtCHLout.Value
        ' .LR_CHDin = dtCHDin.Value
        '.LR_CHDout = dtCHDout.Value
        ' .LR_CHin = dtCTin.Value
        '.LR_CDin = dtCDin.Value

        Me.Close()
        MsgBox("New attendance rule saved!    ", vbInformation, "Attendance Rule")
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmAttRule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        With My.Settings
            dtOFHin.Value = .OFH_in
            dtOFHout.Value = .OFH_Out
            dtCHLin.Value = .LR_CHLin
            dtCHLout.Value = .LR_CHLout
            'dtCHDin.Value = .LR_CHDin
            ' dtCHDout.Value = .LR_CHDout
            ' dtCTin.Value = .LR_CHin
            'dtCDin.Value = .LR_CDin
        End With
    End Sub

    Private Sub cmdCon_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCon.Click
        save()
    End Sub

    Private Sub cmdCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
End Class