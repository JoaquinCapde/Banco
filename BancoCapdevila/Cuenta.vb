Imports System.Security.Cryptography

Public Class Cuenta
    Public id, descubierto, saldo As Integer
    Public nombre, direccion, dni, telefono As String
    Public cuenta As Char

    Public Sub New(nombre As String, direccion As String, dni As String, telefono As String, cuenta As Char, descubierto As Integer, saldo As Integer)
        Me.id += 1
        Me.nombre = nombre
        Me.direccion = direccion
        Me.dni = dni
        Me.telefono = telefono
        Me.saldo = 0
        Me.cuenta = cuenta
        If (Me.cuenta = "A") Then
            Me.descubierto = 0
        Else
            Me.descubierto = descubierto
        End If
    End Sub

    Public Sub New()

    End Sub

    Public Function Datos() As String
        MsgBox("ID " & Me.id & " " & Me.nombre & " - " & Me.direccion & " - " & Me.telefono & " - Tipo Cta:" & Me.cuenta)
    End Function

    Public Sub Depositar(monto As Integer)
        If (monto > 0) Then
            Me.saldo += monto
        End If
    End Sub

    Public Function Extraer(monto As Integer) As Boolean
        If (Me.cuenta = "C") Then
            If (monto > (Me.saldo + Me.descubierto)) Then
                Return False
            Else
                Me.saldo = Me.saldo - monto
                Return True
            End If
        End If
        If (Me.cuenta = "A") Then
            If (monto > Me.saldo) Then
                Return False
            Else
                Me.saldo = Me.saldo - monto
                Return True
            End If
        End If
    End Function

    Public Function Extraer() As Boolean
        If (Me.saldo >= 0) Then
            Me.saldo = 0
            Return True
        Else
            Return False
        End If
    End Function
End Class
