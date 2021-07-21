Module Voice_Prompt
    Public Sub PlayVoice(ByVal Path As String)
        System.Threading.Thread.Sleep(35)
        Try
            My.Computer.Audio.Play(Path, AudioPlayMode.Background)
        Catch ex As Exception
        End Try
    End Sub
End Module
