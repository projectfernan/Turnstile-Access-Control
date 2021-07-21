Public Class frmConDB

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cmdCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCon.Click
        save()
        MsgBox("New Database connection saved!     ", vbInformation, "Database Connection")
        Me.Close()
    End Sub
    Sub save()
        With My.Settings
            .DB_IpAdd = txtIpAdd.Text
            .DB_UID = txtUser.Text
            .DB_PWD = txtPass.Text
            .DB_Port = txtPort.Text
            .Save()
        End With
    End Sub

    Private Sub frmConDB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With My.Settings
            txtIpAdd.Text = .DB_IpAdd
            txtUser.Text = .DB_UID
            txtPass.Text = .DB_PWD
            txtPort.Text = .DB_Port
        End With
    End Sub

    Private Sub cmdCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub txtport_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            save()
            MsgBox("New Database connection saved!     ", vbInformation, "Database Connection")
            Me.Close()

        End If
    End Sub

    Private Sub cmdTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest.Click
        save()
        With MainForm
            If conServer() = True Then
                MsgBox("Successfully connected!    ", MsgBoxStyle.Information, "Server Connection")
                .txtDbStat.Text = "Connected"
                .txtDbStat.ForeColor = Color.Blue
            Else
                MsgBox("Failed to connect!    ", MsgBoxStyle.Exclamation, "Server Connection")
                .txtDbStat.Text = "Disconnected"
                .txtDbStat.ForeColor = Color.Red
            End If
        End With
    End Sub
End Class