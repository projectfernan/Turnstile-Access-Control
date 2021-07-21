Public Class frmSelectDb

    Private Sub cmdConn_Click(sender As System.Object, e As System.EventArgs) Handles cmdConn.Click
        frmConDB.ShowDialog()
    End Sub

    Private Sub cmdReader_Click(sender As System.Object, e As System.EventArgs) Handles cmdReader.Click
        frmAccessDb.ShowDialog()
    End Sub
End Class