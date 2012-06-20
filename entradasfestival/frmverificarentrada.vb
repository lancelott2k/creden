Public Class frmverificarentrada

    Private Sub txtrut_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrut.KeyPress

        Dim EN As New C_Entradas
        If e.KeyChar = ChrW(Keys.Enter) Then

            If (txtrut.Text <> "") Then
                If (validarRut(txtrut.Text)) Then

                    e.Handled = True

                    EN.rut = txtrut.Text

                    If (EN.cargarrut(EN.rut)) Then
                        If (EN.editarrut(EN.rut)) Then
                            lblresultado.ForeColor = Color.Blue
                            lblresultado.Text = "ENTRADA RESERVADA VALIDA"
                        End If
                        'lblresultado.ForeColor = Color.Blue
                        'lblresultado.Text = "ENTRADA RESERVADA VALIDA"
                    Else
                        'If (EN.ingresarrut(EN.rut)) Then
                        lblresultado.ForeColor = Color.Red
                        lblresultado.Text = "RESERVA INEXISTENTE O ENTREGADA"
                    End If


                Else
                    MsgBox("Rut Ingresado No Es válido, Favor Ingresar Nuevamente", MsgBoxStyle.Exclamation, "Creden - Ingreso Clientes Puma")
                    txtrut.Focus()
                End If
            Else
                MsgBox("Rut Ingresado No Es válido, Favor Ingresar Nuevamente", MsgBoxStyle.Exclamation, "Creden - Ingreso Clientes Puma")
                txtrut.Focus()
            End If
        End If
    End Sub

    Private Sub txtrut_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrut.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtrut.Clear()
        lblresultado.Text = "__"
        txtrut.Focus()

    End Sub
End Class
