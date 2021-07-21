Public Class frmDBPathCon

    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click
        browse()
        cmdSubmit.Visible = True
        cmdBrowse.Visible = False
    End Sub
    Sub browse()
        OpenPath.Filter = "Database File (Att2000.mdb)|Att2000.mdb"
        OpenPath.InitialDirectory = "C:\"
        OpenPath.FileName = vbNullString
        If OpenPath.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtpath.Text = OpenPath.FileName
        End If
    End Sub

    Private Sub cmdSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubmit.Click
        With My.Settings
            .DB_Path = txtpath.Text
            .Save()
        End With
        MsgBox("New Database path saved!", vbInformation, "Database Path")
        cmdSubmit.Visible = False
        cmdBrowse.Visible = True
        ConPath()
        Me.Close()
    End Sub

    Private Sub frmDBPathCon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With My.Settings
            txtpath.Text = .DB_Path
        End With
        cmdSubmit.Visible = False
        cmdBrowse.Visible = True
    End Sub
End Class