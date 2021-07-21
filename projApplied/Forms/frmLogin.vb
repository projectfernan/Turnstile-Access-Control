Public Class frmLogin
    Sub pasok()
        Dim user As String
        Dim pass As String

        user = "fernan"
        pass = "s0bad3l1g3r"

        If Trim(txtUser.Text) = user Then
            If Trim(txtPass.Text) = pass Then
                admin = txtUser.Text
                MainSystem.txtAdmin.Text = admin
                txtUser.Text = vbNullString
                txtPass.Text = vbNullString
                MainSystem.AdministratorToolStripMenuItem.Enabled = True
                unlock()
                login()
                Me.Close()
                Exit Sub
            Else
                MsgBox("Unknown password!    ", vbExclamation, "Login")
                txtPass.Text = vbNullString
                txtPass.Focus()
            End If
        Else
            MsgBox("Unknown username!     ", vbExclamation, "Login")
            txtUser.Text = vbNullString
            txtPass.Text = vbNullString
            txtUser.Focus()
        End If
    End Sub

    Sub login2()
        If subSQl() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Me.Close()
            frmConDB.ShowDialog()
            Exit Sub
        End If
        Dim rs As New Recordset
        Dim rs2 As New Recordset
        rs = New Recordset
        rs = conSql.Execute("Select * from tblUserAcc where Username = '" & txtUser.Text & "'")
        If rs.EOF = False Then
            desig = rs("Designation").Value
            If desig = "User" Then
                MainSystem.AdministratorToolStripMenuItem.Enabled = False
            Else
                MainSystem.AdministratorToolStripMenuItem.Enabled = True
            End If

            If Trim(txtPass.Text) = rs("Password").Value Then
                admin = txtUser.Text
                MainSystem.txtAdmin.Text = admin
                txtUser.Text = vbNullString
                txtPass.Text = vbNullString
                unlock()
                login()
                Me.Close()
                Exit Sub
            Else
                MsgBox("Unknown password!    ", vbExclamation, "Login")
                txtPass.Text = vbNullString
                txtPass.Focus()
                Exit Sub
            End If
        Else
            MsgBox("Unknown username!     ", vbExclamation, "Login")
            txtUser.Text = vbNullString
            txtPass.Text = vbNullString
            txtUser.Focus()
            Exit Sub
        End If
    End Sub

    Function testadmin() As Boolean
        If txtUser.Text = "fernan" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub txtUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txtPass.Focus()
        End If
    End Sub

    Private Sub txtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            If testadmin() = True Then
                pasok()
                Exit Sub
            Else
                login2()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cmdLogin_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        If testadmin() = True Then
            pasok()
            Access = "Login"
            frmMain.KeyPreview = True
            Exit Sub
        Else
            login2()
            Access = "Login"
            frmMain.KeyPreview = True
            Exit Sub
        End If
    End Sub

    Private Sub frmLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdLogin_Click_1(sender, New System.EventArgs)
        End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmMain.KeyPreview = False
    End Sub

    Private Sub frmLogin_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        txtUser.Text = vbNullString
        txtPass.Text = vbNullString
        txtUser.Focus()
    End Sub
End Class