Imports System.Threading
Public Class LetranMain
    Private Delegate Sub LoadDev()
    Private Delegate Sub LoadStart()

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        txtLongDate.Text = Format(Now, "Long Date") & " " & Format(Now, "HH:mm:ss")
    End Sub

    Private Sub LetranMain_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Control = True And e.KeyCode = Keys.Insert Then
            ' frmSystem.ShowDialog()
        End If

        If e.Control = True And e.KeyCode = Keys.Enter Then
            frmLogin.ShowDialog()
        End If
    End Sub

    Private Sub LetranMain_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        ViewConn()
        If conServer() = False And ConnLocdb() = False Then
            frmConDB.ShowDialog()
        End If
        ' PanelDev.Controls.Clear()
        Dim th As New Thread(New ThreadStart(Sub() LoadDevList()))
        th.Start()
    End Sub

    Sub LoadDevList()
        If (InvokeRequired) Then
            Invoke(New LoadDev(AddressOf LoadDevList))
        Else

            If ConnLocdb() = False Then
                Exit Sub
            End If

            Try
                Dim rs As New Recordset
                rs = New Recordset

                rs = conSqlLoc.Execute("select * from tbldevices")
                Do While rs.EOF = False

                    DevStructure.Dev_Name = rs("DeviceName").Value
                    DevStructure.Dev_Ip = rs("Ip").Value
                    DevStructure.Dev_Stat = rs("Status").Value
                    DevStructure.Dev_Delay = rs("Delay").Value
                    'Sleep(1000)

                    Dim dev As New DevControl
                    PanelDev.Controls.Add(dev)

                    rs.MoveNext()
                Loop
            Catch ex As Exception
                'txtSystemErr.Text = ex.Message
            End Try
        End If
    End Sub

    Private Sub Label10_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class