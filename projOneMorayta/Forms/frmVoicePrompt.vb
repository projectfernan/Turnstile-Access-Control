Public Class frmVoicePrompt

    Private Sub cmdTestDbloc_Click(sender As System.Object, e As System.EventArgs) Handles cmdTestDbloc.Click
        Ofd.Title = "Select see admin voice prompt"
        If Ofd.ShowDialog = DialogResult.OK Then
            txtSeeAdmin.Text = Ofd.FileName
            With My.Settings
                .vpSeeAdmin = txtSeeAdmin.Text
                .Save()
            End With
        End If
    End Sub

    Private Sub btnOfdEF_Click(sender As System.Object, e As System.EventArgs) Handles btnOfdEF.Click
        Ofd.Title = "Select entry first voice prompt"
        If Ofd.ShowDialog = DialogResult.OK Then
            txtEntryFirst.Text = Ofd.FileName
            With My.Settings
                .vpEntry = txtEntryFirst.Text
                .Save()
            End With
        End If
    End Sub

    Private Sub btnExtF_Click(sender As System.Object, e As System.EventArgs) Handles btnExtF.Click
        Ofd.Title = "Select exit first voice prompt"
        If Ofd.ShowDialog = DialogResult.OK Then
            txtExitFirst.Text = Ofd.FileName
            With My.Settings
                .vpExit = txtExitFirst.Text
                .Save()
            End With
        End If
    End Sub

    Private Sub btnExpired_Click(sender As System.Object, e As System.EventArgs) Handles btnExpired.Click
        Ofd.Title = "Select card expired voice prompt"
        If Ofd.ShowDialog = DialogResult.OK Then
            txtCardExp.Text = Ofd.FileName
            With My.Settings
                .vpExpired = txtCardExp.Text
                .Save()
            End With
        End If
    End Sub

    Private Sub btnUnknown_Click(sender As System.Object, e As System.EventArgs) Handles btnUnknown.Click
        Ofd.Title = "Select unknown card voice prompt"
        If Ofd.ShowDialog = DialogResult.OK Then
            txtUnknown.Text = Ofd.FileName
            With My.Settings
                .vpUnknown = txtUnknown.Text
                .Save()
            End With
        End If
    End Sub

    Private Sub btnAcG_Click(sender As System.Object, e As System.EventArgs) Handles btnAcG.Click
        Ofd.Title = "Select access group voice prompt"
        If Ofd.ShowDialog = DialogResult.OK Then
            txtAcGroup.Text = Ofd.FileName
            With My.Settings
                .vpAcGroup = txtAcGroup.Text
                .Save()
            End With
        End If
    End Sub

    Private Sub btnPlaySeeAdmin_Click(sender As System.Object, e As System.EventArgs) Handles btnPlaySeeAdmin.Click
        PlayVoice(txtSeeAdmin.Text)
    End Sub

    Private Sub btnPlayEntryFirst_Click(sender As System.Object, e As System.EventArgs) Handles btnPlayEntryFirst.Click
        PlayVoice(txtEntryFirst.Text)
    End Sub

    Private Sub btnPlayExitFirst_Click(sender As System.Object, e As System.EventArgs) Handles btnPlayExitFirst.Click
        PlayVoice(txtExitFirst.Text)
    End Sub

    Private Sub btnPlayExpired_Click(sender As System.Object, e As System.EventArgs) Handles btnPlayExpired.Click
        PlayVoice(txtCardExp.Text)
    End Sub

    Private Sub btnPlayUnknown_Click(sender As System.Object, e As System.EventArgs) Handles btnPlayUnknown.Click
        PlayVoice(txtUnknown.Text)
    End Sub

    Private Sub btnPlayAcGroup_Click(sender As System.Object, e As System.EventArgs) Handles btnPlayAcGroup.Click
        PlayVoice(txtAcGroup.Text)
    End Sub

    Private Sub frmVoicePrompt_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        With My.Settings
            .vpSeeAdmin = txtSeeAdmin.Text
            .vpEntry = txtEntryFirst.Text
            .vpExit = txtExitFirst.Text
            .vpExpired = txtCardExp.Text
            .vpUnknown = txtUnknown.Text
            .vpAcGroup = txtAcGroup.Text
            .Save()
        End With
    End Sub

    Private Sub frmVoicePrompt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        With My.Settings
            txtSeeAdmin.Text = .vpSeeAdmin
            txtEntryFirst.Text = .vpEntry
            txtExitFirst.Text = .vpExit
            txtCardExp.Text = .vpExpired
            txtUnknown.Text = .vpUnknown
            txtAcGroup.Text = .vpAcGroup
        End With
    End Sub
End Class