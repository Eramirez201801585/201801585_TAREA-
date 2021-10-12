Imports System.Math
Public Class Form1
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtEdad.Text = "" Or IsNumeric(txtEdad.Text) = False Then
            MsgBox("Por favor ingrese la edad en números",, "Error")
            Exit Sub
        End If
        If cmbGenero.Text = "" Then
            MsgBox("Seleccione el género",, "Error")
            Exit Sub
        End If
        If cmbRegistro.Text = "" Then
            MsgBox("Seleccione el código de Registro",, "Error")
            Exit Sub
        End If
        If txtMonto.Text = "" Or IsNumeric(txtMonto.Text) = False Then
            MsgBox("Ingrese el monto de daños en números",, "Error")
            Exit Sub
        End If
        If cmbTaller.Text = "" Then
            MsgBox("Seleccione el taller que realizará la reparación",, "Error")
            Exit Sub
        End If

        If indice < 7 Then
            Vedad(indice) = Val(txtEdad.Text)
            Vgenero(indice) = cmbGenero.Text
            Vregistro(indice) = cmbRegistro.Text
            Vmonto(indice) = Val(txtMonto.Text)
            Vtaller(indice) = cmbTaller.Text
            Vdeducible(indice) = Round(Val(Vmonto(indice)) * 0.06, 2)
            Vaseguradora(indice) = Round(Val(Vmonto(indice)) - Val(Vdeducible(indice)), 2)
            indice = indice + 1
            Lentradas()
        Else
            MsgBox("Memoria llena",, "Error")

        End If
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        mostrar()
    End Sub

    Private Sub btnLvectores_Click(sender As Object, e As EventArgs) Handles btnLvectores.Click
        If MsgBox("¿Desea Limpiar la memoria?", vbYesNo, "Advertencia") = MsgBoxResult.Yes Then
            Lvectores()
        End If
    End Sub

    Private Sub btnEstadisticas_Click(sender As Object, e As EventArgs) Handles btnEstadisticas.Click
        Estadisticas()
    End Sub

    Private Sub btnLestadisticas_Click(sender As Object, e As EventArgs) Handles btnLestadisticas.Click
        If MsgBox("¿Desea Limpiar las estadisticas?", vbYesNo, "Advertencia") = MsgBoxResult.Yes Then
            Lestadisticas()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Desea Salir?", vbYesNo, "Advertencia") = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub


End Class
