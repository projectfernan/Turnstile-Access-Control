Public Class frmMsgIn

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmMsgIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblIn.Text = frmMain.OrasIn
    End Sub
End Class