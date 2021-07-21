Public Class frmMsgOut

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmMsgOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblOut.Text = frmMain.OrasOut
    End Sub
End Class