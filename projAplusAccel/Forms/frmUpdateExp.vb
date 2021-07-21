Public Class frmUpdateExp

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If MsgBox("Are you sure do you want to update expiration date of this card?     ", vbYesNo + vbQuestion + vbDefaultButton2, "Delete") = vbYes Then
            UpdateExp(txtAcno.Text, dtNewExp.Value)
        End If
    End Sub
End Class