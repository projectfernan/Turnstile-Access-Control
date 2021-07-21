Public Class frmConDB

    Sub save()
        With My.Settings
            .DB_IpAdd = txtIpAdd.Text
            .DB_UID = txtUser.Text
            .DB_PWD = txtPass.Text
            .DB_DB = txtDb.Text
            .Save()
        End With
        MsgBox("New Database connection saved!     ", vbInformation, "Database Connection")
        setcon()
        subSQl()
        Me.Close()
    End Sub

    Private Sub frmConDB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With My.Settings
            txtIpAdd.Text = .DB_IpAdd
            txtUser.Text = .DB_UID
            txtPass.Text = .DB_PWD
            txtDb.Text = .DB_DB
        End With
    End Sub

    Private Sub cmdTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest.Click
        With My.Settings
            .DB_IpAdd = txtIpAdd.Text
            .DB_UID = txtUser.Text
            .DB_PWD = txtPass.Text
            .DB_DB = txtDb.Text
            .Save()
        End With
        setcon()
        If subSQl() = False Then
            MsgBox("Failed to connect to server!    ", vbExclamation, "Connect")
        Else
            MsgBox("Successfully connected!    ", vbInformation, "Connect")
        End If
    End Sub

    Private Sub cmdCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdCon_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCon.Click
        save()
    End Sub
End Class