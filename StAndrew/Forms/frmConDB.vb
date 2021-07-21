Public Class frmConDB

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub cmdCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCon.Click
        save()
    End Sub
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
        '.Enabled = True
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

    Private Sub cmdCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub txtIpAdd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIpAdd.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtUser.Focus()
        End If
    End Sub

    Private Sub txtUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUser.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtPass.Focus()
        End If
    End Sub

    Private Sub txtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPass.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtDb.Focus()
        End If
    End Sub

    Private Sub txtDb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDb.KeyPress
        If Asc(e.KeyChar) = 13 Then
            save()
        End If
    End Sub
End Class