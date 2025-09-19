Public Class Form2
    Dim cuenta1 As Cuenta = New Cuenta("Nombre", "Direccion", "DNI", "Telefono", "C"c, 200, 100)
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnCerrarClick(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If (cuenta1.Extraer() = False) Then
            MsgBox("Imposible cerrar la cuenta porque tiene saldo deudor")
        Else
            MsgBox("Cuenta cerrada exitosamente")
        End If
        lblMonto.Text = cuenta1.saldo
    End Sub

    Private Sub btnDeposito_Click(sender As Object, e As EventArgs) Handles btnDeposito.Click
        cuenta1.Depositar(Convert.ToInt32(txtImporte.Text))
        lblMonto.Text = cuenta1.saldo
    End Sub

    Private Sub btnExtraccion_Click(sender As Object, e As EventArgs) Handles btnExtraccion.Click
        If (cuenta1.Extraer(Convert.ToInt32(txtImporte.Text)) = True) Then
            MsgBox("Extraccion realizada con exito")
        Else
            MsgBox("No se puede extraer ese monto")
        End If
        lblMonto.Text = cuenta1.saldo
    End Sub
End Class