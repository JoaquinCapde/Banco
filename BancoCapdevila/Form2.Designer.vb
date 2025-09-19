<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        gpb1 = New GroupBox()
        lblMonto = New Label()
        lblSaldo = New Label()
        gpb2 = New GroupBox()
        txtImporte = New TextBox()
        lblImporte = New Label()
        btnDeposito = New Button()
        btnExtraccion = New Button()
        btnSalir = New Button()
        btnCerrar = New Button()
        gpb1.SuspendLayout()
        gpb2.SuspendLayout()
        SuspendLayout()
        ' 
        ' gpb1
        ' 
        gpb1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        gpb1.Controls.Add(lblMonto)
        gpb1.Controls.Add(lblSaldo)
        gpb1.Location = New Point(200, 82)
        gpb1.Margin = New Padding(3, 4, 3, 4)
        gpb1.Name = "gpb1"
        gpb1.Padding = New Padding(3, 4, 3, 4)
        gpb1.Size = New Size(423, 127)
        gpb1.TabIndex = 0
        gpb1.TabStop = False
        ' 
        ' lblMonto
        ' 
        lblMonto.AutoSize = True
        lblMonto.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMonto.ForeColor = Color.Yellow
        lblMonto.Location = New Point(307, 38)
        lblMonto.Name = "lblMonto"
        lblMonto.Size = New Size(25, 30)
        lblMonto.TabIndex = 3
        lblMonto.Text = "0"
        ' 
        ' lblSaldo
        ' 
        lblSaldo.AutoSize = True
        lblSaldo.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSaldo.ForeColor = SystemColors.AppWorkspace
        lblSaldo.Location = New Point(31, 38)
        lblSaldo.Name = "lblSaldo"
        lblSaldo.Size = New Size(110, 30)
        lblSaldo.TabIndex = 2
        lblSaldo.Text = "Saldo     $"
        ' 
        ' gpb2
        ' 
        gpb2.BackColor = Color.CornflowerBlue
        gpb2.Controls.Add(txtImporte)
        gpb2.Controls.Add(lblImporte)
        gpb2.Location = New Point(200, 217)
        gpb2.Margin = New Padding(3, 4, 3, 4)
        gpb2.Name = "gpb2"
        gpb2.Padding = New Padding(3, 4, 3, 4)
        gpb2.Size = New Size(261, 191)
        gpb2.TabIndex = 1
        gpb2.TabStop = False
        ' 
        ' txtImporte
        ' 
        txtImporte.Location = New Point(65, 105)
        txtImporte.Margin = New Padding(3, 4, 3, 4)
        txtImporte.Name = "txtImporte"
        txtImporte.Size = New Size(114, 26)
        txtImporte.TabIndex = 1
        ' 
        ' lblImporte
        ' 
        lblImporte.AutoSize = True
        lblImporte.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblImporte.Location = New Point(56, 48)
        lblImporte.Name = "lblImporte"
        lblImporte.Size = New Size(117, 30)
        lblImporte.TabIndex = 0
        lblImporte.Text = "Importe  $"
        ' 
        ' btnDeposito
        ' 
        btnDeposito.Location = New Point(467, 217)
        btnDeposito.Margin = New Padding(3, 4, 3, 4)
        btnDeposito.Name = "btnDeposito"
        btnDeposito.Size = New Size(155, 86)
        btnDeposito.TabIndex = 2
        btnDeposito.Text = "Deposito"
        btnDeposito.UseVisualStyleBackColor = True
        ' 
        ' btnExtraccion
        ' 
        btnExtraccion.Location = New Point(467, 322)
        btnExtraccion.Margin = New Padding(3, 4, 3, 4)
        btnExtraccion.Name = "btnExtraccion"
        btnExtraccion.Size = New Size(155, 86)
        btnExtraccion.TabIndex = 3
        btnExtraccion.Text = "Extracción"
        btnExtraccion.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(467, 415)
        btnSalir.Margin = New Padding(3, 4, 3, 4)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(155, 86)
        btnSalir.TabIndex = 4
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Location = New Point(200, 415)
        btnCerrar.Margin = New Padding(3, 4, 3, 4)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(261, 86)
        btnCerrar.TabIndex = 5
        btnCerrar.Text = "Cerrar Cuenta"
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(914, 570)
        Controls.Add(btnCerrar)
        Controls.Add(btnSalir)
        Controls.Add(btnExtraccion)
        Controls.Add(btnDeposito)
        Controls.Add(gpb2)
        Controls.Add(gpb1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form2"
        Text = "Form2"
        gpb1.ResumeLayout(False)
        gpb1.PerformLayout()
        gpb2.ResumeLayout(False)
        gpb2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents gpb1 As GroupBox
    Friend WithEvents gpb2 As GroupBox
    Friend WithEvents btnDeposito As Button
    Friend WithEvents btnExtraccion As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblImporte As Label
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents lblMonto As Label
    Friend WithEvents lblSaldo As Label
End Class
