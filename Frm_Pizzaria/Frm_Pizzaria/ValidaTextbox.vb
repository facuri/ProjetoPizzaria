Module ValidaTextbox
    Function SoNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoNumeros = 0
            'MsgBox("Digite apenas Números")
        Else
            SoNumeros = Keyascii

        End If

        Select Case Keyascii
            Case 8
                SoNumeros = Keyascii
            Case 13
                SoNumeros = Keyascii
            Case 32
                SoNumeros = Keyascii
            Case 46
                SoNumeros = Keyascii
            Case 45
                SoNumeros = Keyascii
        End Select
    End Function



End Module
