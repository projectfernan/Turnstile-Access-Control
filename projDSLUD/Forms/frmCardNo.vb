Public Class frmCardNo

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If optStud.Checked = True Then
            With frmNewStud
                enableTxt(frmNewStud)
                .txtAC.Text = lblAcc.Text
                .cmdBrowse.Enabled = True
                .cmdSubmit.Enabled = True
                .txtId.Focus()

            End With
            Me.Close()
        Else
            With frmNewStud
                .txtFetchAC.Text = lblAcc.Text
                .cmdAdd.Enabled = True
                .cmdEdit.Enabled = True
                .cmdDel.Enabled = True
            End With
            Me.Close()
        End If
    End Sub

    Private Sub frmCardNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If optStud.Checked = True Then
                With frmNewStud
                    enableTxt(frmNewStud)
                    .txtAC.Text = lblAcc.Text
           
                    .cmdBrowse.Enabled = True
                    .cmdSubmit.Enabled = True
                    .txtId.Focus()

                End With
                Me.Close()
            Else
                With frmNewStud
                    .txtFetchAC.Text = lblAcc.Text
                    .cmdAdd.Enabled = True
                    .cmdEdit.Enabled = True
                    .cmdDel.Enabled = True
                End With
                Me.Close()
            End If
        End If
    End Sub

End Class