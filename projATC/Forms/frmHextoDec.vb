Public Class frmHextoDec

    Private Sub cmdConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConvert.Click
        txtHexa.Text = Hex(txtDecimal.Value)
    End Sub
End Class