<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        gpb1 = New GroupBox()
        rdbCorriente = New RadioButton()
        rdbAhorros = New RadioButton()
        lblNombre = New Label()
        txtNombre = New TextBox()
        txtDireccion = New TextBox()
        lblDireccion = New Label()
        txtDni = New TextBox()
        lblDni = New Label()
        txtTelefono = New TextBox()
        lblTelefono = New Label()
        txtDescubierto = New TextBox()
        lblDescubierto = New Label()
        btnCancelar = New Button()
        btnAlta = New Button()
        gpb1.SuspendLayout()
        SuspendLayout()
        ' 
        ' gpb1
        ' 
        gpb1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        gpb1.Controls.Add(rdbCorriente)
        gpb1.Controls.Add(rdbAhorros)
        gpb1.Location = New Point(16, 19)
        gpb1.Margin = New Padding(3, 4, 3, 4)
        gpb1.Name = "gpb1"
        gpb1.Padding = New Padding(3, 4, 3, 4)
        gpb1.Size = New Size(355, 67)
        gpb1.TabIndex = 0
        gpb1.TabStop = False
        gpb1.Text = "TIPO DE CUENTA"
        ' 
        ' rdbCorriente
        ' 
        rdbCorriente.AutoSize = True
        rdbCorriente.ForeColor = Color.Red
        rdbCorriente.Location = New Point(203, 28)
        rdbCorriente.Margin = New Padding(3, 4, 3, 4)
        rdbCorriente.Name = "rdbCorriente"
        rdbCorriente.Size = New Size(132, 23)
        rdbCorriente.TabIndex = 1
        rdbCorriente.TabStop = True
        rdbCorriente.Text = "Cuenta Corriente"
        rdbCorriente.UseVisualStyleBackColor = True
        ' 
        ' rdbAhorros
        ' 
        rdbAhorros.AutoSize = True
        rdbAhorros.ForeColor = Color.Lime
        rdbAhorros.Location = New Point(29, 28)
        rdbAhorros.Margin = New Padding(3, 4, 3, 4)
        rdbAhorros.Name = "rdbAhorros"
        rdbAhorros.Size = New Size(125, 23)
        rdbAhorros.TabIndex = 0
        rdbAhorros.TabStop = True
        rdbAhorros.Text = "Caja de Ahorros"
        rdbAhorros.UseVisualStyleBackColor = True
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Location = New Point(38, 98)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(123, 19)
        lblNombre.TabIndex = 1
        lblNombre.Text = "Nombre y Apellido"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(178, 94)
        txtNombre.Margin = New Padding(3, 4, 3, 4)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(172, 26)
        txtNombre.TabIndex = 2
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(178, 134)
        txtDireccion.Margin = New Padding(3, 4, 3, 4)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(172, 26)
        txtDireccion.TabIndex = 4
        ' 
        ' lblDireccion
        ' 
        lblDireccion.AutoSize = True
        lblDireccion.Location = New Point(38, 138)
        lblDireccion.Name = "lblDireccion"
        lblDireccion.Size = New Size(65, 19)
        lblDireccion.TabIndex = 3
        lblDireccion.Text = "Dirección"
        ' 
        ' txtDni
        ' 
        txtDni.Location = New Point(178, 176)
        txtDni.Margin = New Padding(3, 4, 3, 4)
        txtDni.Name = "txtDni"
        txtDni.Size = New Size(172, 26)
        txtDni.TabIndex = 6
        ' 
        ' lblDni
        ' 
        lblDni.AutoSize = True
        lblDni.Location = New Point(38, 180)
        lblDni.Name = "lblDni"
        lblDni.Size = New Size(33, 19)
        lblDni.TabIndex = 5
        lblDni.Text = "DNI"
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(178, 219)
        txtTelefono.Margin = New Padding(3, 4, 3, 4)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(172, 26)
        txtTelefono.TabIndex = 8
        ' 
        ' lblTelefono
        ' 
        lblTelefono.AutoSize = True
        lblTelefono.Location = New Point(38, 223)
        lblTelefono.Name = "lblTelefono"
        lblTelefono.Size = New Size(60, 19)
        lblTelefono.TabIndex = 7
        lblTelefono.Text = "Telefono"
        ' 
        ' txtDescubierto
        ' 
        txtDescubierto.Location = New Point(178, 263)
        txtDescubierto.Margin = New Padding(3, 4, 3, 4)
        txtDescubierto.Name = "txtDescubierto"
        txtDescubierto.Size = New Size(172, 26)
        txtDescubierto.TabIndex = 10
        txtDescubierto.Visible = False
        ' 
        ' lblDescubierto
        ' 
        lblDescubierto.AutoSize = True
        lblDescubierto.Location = New Point(38, 267)
        lblDescubierto.Name = "lblDescubierto"
        lblDescubierto.Size = New Size(98, 19)
        lblDescubierto.TabIndex = 9
        lblDescubierto.Text = "Descubierto  $"
        lblDescubierto.Visible = False
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(214, 318)
        btnCancelar.Margin = New Padding(3, 4, 3, 4)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(113, 29)
        btnCancelar.TabIndex = 11
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnAlta
        ' 
        btnAlta.Location = New Point(61, 318)
        btnAlta.Margin = New Padding(3, 4, 3, 4)
        btnAlta.Name = "btnAlta"
        btnAlta.Size = New Size(113, 29)
        btnAlta.TabIndex = 12
        btnAlta.Text = "Alta Cliente"
        btnAlta.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(397, 417)
        Controls.Add(btnAlta)
        Controls.Add(btnCancelar)
        Controls.Add(txtDescubierto)
        Controls.Add(lblDescubierto)
        Controls.Add(txtTelefono)
        Controls.Add(lblTelefono)
        Controls.Add(txtDni)
        Controls.Add(lblDni)
        Controls.Add(txtDireccion)
        Controls.Add(lblDireccion)
        Controls.Add(txtNombre)
        Controls.Add(lblNombre)
        Controls.Add(gpb1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Form1"
        gpb1.ResumeLayout(False)
        gpb1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents gpb1 As GroupBox
    Friend WithEvents rdbCorriente As RadioButton
    Friend WithEvents rdbAhorros As RadioButton
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents txtDni As TextBox
    Friend WithEvents lblDni As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtDescubierto As TextBox
    Friend WithEvents lblDescubierto As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAlta As Button

End Class
