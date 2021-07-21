Public Class frmImgDesig
    Sub browse()
        Dim FBD As New FolderBrowserDialog
        FBD.Description = "Data Path Designation"
        FBD.ShowNewFolderButton = True      'OR FALSE
        FBD.SelectedPath = "C:\"
        FBD.ShowDialog()
        txtpath.Text = FBD.SelectedPath      'Use this path to Process the folder...or files
        FBD = Nothing
    End Sub

    Private Sub frmImgDesig_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.CapImgPath = txtpath.Text
        My.Settings.Save()
    End Sub

    Private Sub frmImgDesig_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtpath.Text = My.Settings.CapImgPath
    End Sub

    Private Sub cmdFP_Click(sender As System.Object, e As System.EventArgs) Handles cmdFP.Click
        browse()
    End Sub
End Class