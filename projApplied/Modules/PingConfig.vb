Module PingConfig

    Public Function PingMe(ByVal IPaddress As String) As Boolean
        Try
            If My.Computer.Network.IsAvailable = False Then
                MainSystem.txtSystemErr.Text = "There is no Network Available."
                Return False
            End If

            If My.Computer.Network.Ping(IPaddress, 5) = False Then
                MainSystem.txtSystemErr.Text = "Ping Test Fail @ " & IPaddress
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
            Return False
        End Try
    End Function
End Module
