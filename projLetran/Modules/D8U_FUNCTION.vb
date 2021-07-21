
Module D8U_FUNCTION
    Public rd As COMRD800Lib.RD800
    Public st As Integer
    Public d8CardCod As String
    Public snr As String

    '------------------------------------------------------ D8 CONFIG ---------------------------------------------------------'

    Public Function d8_conn() As Boolean
        rd = New COMRD800Lib.RD800
        st = rd.dc_init(100, 115200)
        If st < 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub d8_Beep()
        rd = New COMRD800Lib.RD800
        st = rd.dc_init(100, 115200)
        If st < 0 Then

        Else
            rd.dc_beep(10)
        End If
    End Sub

    Public Function d8_Card() As Boolean
        rd = New COMRD800Lib.RD800
        st = rd.dc_init(100, 115200)
        If st < 0 Then
            Return False
        Else
            st = rd.dc_card(0, snr)
            d8CardCod = snr
            If st = 0 Then
                rd.dc_halt()
                Return True
            Else
                Return False
            End If
        End If
    End Function
End Module
