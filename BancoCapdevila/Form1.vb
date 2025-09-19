Public Class Form1
    Dim cuenta1 As Cuenta = New Cuenta()
    Private Sub rdbCorriente_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCorriente.CheckedChanged
        lblDescubierto.Visible = True
        txtDescubierto.Visible = True
    End Sub

    Private Sub rdbAhorros_CheckedChanged(sender As Object, e As EventArgs) Handles rdbAhorros.CheckedChanged
        lblDescubierto.Visible = False
        txtDescubierto.Visible = False
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        cuenta1.nombre = txtNombre.Text
        cuenta1.direccion = txtDireccion.Text
        cuenta1.dni = txtDni.Text
        cuenta1.telefono = txtTelefono.Text
        If (rdbAhorros.Checked) Then
            cuenta1.cuenta = "A"c
            cuenta1.descubierto = 0
        Else
            cuenta1.cuenta = "C"c
            cuenta1.descubierto = Convert.ToInt32(txtDescubierto.Text)
        End If
        cuenta1.Datos()
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        End
    End Sub
End Class
