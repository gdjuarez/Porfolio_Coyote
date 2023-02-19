Public Class FrmVuelto

    Private Sub TxtPago_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPago.TextChanged
        If TxtPago.Text = "" Then
        Else
            TxtVuelto.Text = Convert.ToDecimal(TxtPago.Text) - Convert.ToDecimal(TxtVenta.Text)
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Dim resultado As DialogResult = MessageBox.Show("Está seguro de Eliminar la venta?",
                                                   "Atención", MessageBoxButtons.YesNo)
        If resultado = Windows.Forms.DialogResult.Yes Then
            FrmVentas.Close()
            Me.Close()
        End If
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If TxtVuelto.Text < 0 Then
            MsgBox("Pago insuficiente!!")
        Else
            Me.Close()
            'FrmVentas.BtnConfirmar.PerformClick()
        End If
    End Sub

    Private Sub TxtVuelto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtVuelto.TextChanged
        If TxtVuelto.Text < 0 Then
            TxtVuelto.ForeColor = Color.Red
        Else
            TxtVuelto.ForeColor = Color.Blue
        End If
    End Sub
End Class