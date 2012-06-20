Module Module1

    Public Function validarRut(ByVal rut_Verificar As String) As Boolean
        Dim rutLimpio As String
        Dim digitoVerificador As String
        Dim suma As Integer
        Dim contador As Integer = 2
        Dim valida As Boolean = True
        Dim retorno As Boolean = False
        rutLimpio = rut_Verificar.Replace(".", "")
        rutLimpio = rutLimpio.Replace("-", "")
        rutLimpio = rutLimpio.Replace(" ", "")
        rutLimpio = rutLimpio.Substring(0, rutLimpio.Length - 1)
        digitoVerificador = rut_Verificar.Substring(rut_Verificar.Length - 1, 1)
        Dim i As Integer
        For i = rutLimpio.Length - 1 To 0 Step -1
            If contador > 7 Then
                contador = 2
            End If
            Try
                suma += Integer.Parse(rutLimpio(i).ToString()) * contador
                contador += 1
            Catch ex As Exception
                valida = False
            End Try
        Next
        If valida Then
            Dim dv As Integer = 11 - (suma Mod 11)
            Dim DigVer As String = dv.ToString()
            If DigVer = "10" Then
                DigVer = "K"
            End If
            If DigVer = "11" Then
                DigVer = "0"
            End If
            If DigVer = digitoVerificador.ToUpper Then
                retorno = True
            Else
                retorno = False
            End If
        End If
        Return retorno
    End Function

End Module
