
Module D8U_FUNCTION
    'Public strUpdateCode As String

    'Public rd As COMRD800Lib.RD800
    'Public st As Integer
    'Public CardCod As String
    'Public snr As String

    ''------------------------------------------------------ D8 CONFIG ---------------------------------------------------------'

    'Public Function d8_conn() As Boolean
    '    rd = New COMRD800Lib.RD800
    '    st = rd.dc_init(100, 115200)
    '    If st < 0 Then
    '        Return False
    '    Else
    '        Return True
    '    End If
    'End Function

    'Public Sub d8_Beep()
    '    rd = New COMRD800Lib.RD800
    '    st = rd.dc_init(100, 115200)
    '    If st < 0 Then

    '    Else
    '        rd.dc_beep(10)
    '    End If
    'End Sub

    'Public Function d8_Card() As Boolean
    '    rd = New COMRD800Lib.RD800
    '    st = rd.dc_init(100, 115200)
    '    If st < 0 Then
    '        Return False
    '    Else
    '        st = rd.dc_card(0, snr)
    '        CardCod = snr
    '        If st = 0 Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    End If
    'End Function
End Module
