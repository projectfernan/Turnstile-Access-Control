Public Class frmAutoCon

    Private Sub tmrConn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrConn.Tick
        'Dim lup As Integer
        ProgBar.Maximum = 800
        t1devcon1(frmConDev.T1DevIp1.Text)
        ProgBar.Value = ProgBar.Value + 100

        t1devcon2(frmConDev.T1DevIp2.Text)

        ProgBar.Value = ProgBar.Value + 100
        t2devcon1(frmConDev.T2DevIp1.Text)

        ProgBar.Value = ProgBar.Value + 100
        t2devcon2(frmConDev.T2DevIp2.Text)

        ProgBar.Value = ProgBar.Value + 100
        t3devcon1(frmConDev.T3DevIp1.Text)

        ProgBar.Value = ProgBar.Value + 100
        t3devcon2(frmConDev.T3DevIp2.Text)

        ProgBar.Value = ProgBar.Value + 100
        t4devcon1(frmConDev.T4DevIp1.Text)

        ProgBar.Value = ProgBar.Value + 100
        t4devcon2(frmConDev.T4DevIp2.Text)

        ProgBar.Value = ProgBar.Value + 100

        tmrConn.Enabled = False
        ' frmMain.tmrEvent.Enabled = True
        Me.Close()
    End Sub

    Private Sub frmAutoCon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmrConn.Enabled = True
    End Sub
End Class