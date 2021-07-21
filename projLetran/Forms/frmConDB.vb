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

            .DBloc_Ip = txtLocal.Text
            .DBloc_PWD = txtPassLoc.Text
            .DBloc_UID = txtUserLoc.Text
            .DBloc_DB = txtdbLoc.Text
            .Save()
        End With
    End Sub

    Private Sub frmConDB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With My.Settings
            txtIpAdd.Text = .DB_IpAdd
            txtUser.Text = .DB_UID
            txtPass.Text = .DB_PWD
            txtPort.Text = .DB_Port

            txtLocal.Text = .DBloc_Ip
            txtPassLoc.Text = .DBloc_PWD
            txtUserLoc.Text = .DBloc_UID
            txtdbLoc.Text = .DBloc_DB
        End With
    End Sub

    Private Sub cmdCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
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

    Private Sub btnTestLoc_Click(sender As Object, e As EventArgs) Handles btnTestLoc.Click
        save()
        With MainForm
            If ConnLocdb() = True Then
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