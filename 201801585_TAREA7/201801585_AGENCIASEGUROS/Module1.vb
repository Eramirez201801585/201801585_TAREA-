Imports System.Math
Module Module1
    Public Vedad(6) As Integer
    Public Vgenero(6) As String
    Public Vregistro(6) As String
    Public Vmonto(6) As Double
    Public Vtaller(6) As String
    Public Vdeducible(6) As Double
    Public Vaseguradora(6) As Double
    Public indice As Byte = 0
    Public n As Byte = 0
    Public E1 As Byte = 0
    Public E2 As Byte = 0
    Public E3 As Byte = 0
    Public E4 As Byte = 0
    Public E5 As Byte = 0
    Public E6 As Double = 0
    Sub Lentradas()
        Form1.txtEdad.Text = ""
        Form1.cmbGenero.Text = ""
        Form1.cmbRegistro.Text = ""
        Form1.txtMonto.Text = ""
        Form1.cmbTaller.Text = ""
        Form1.txtEdad.Focus()

    End Sub
    Sub mostrar()

        For i = n To indice - 1 Step 1
            Form1.DataGridView1.Rows.Add(Vedad(i).ToString, Vgenero(i), Vregistro(i), Vmonto(i).ToString, Vtaller(i), Vdeducible(i).ToString, Vaseguradora(i).ToString)
        Next
        n = indice
    End Sub

    Sub Lvectores()
        ReDim Vedad(6), Vgenero(6), Vregistro(6), Vmonto(6), Vtaller(6), Vdeducible(6), Vaseguradora(6)
        indice = 0
        n = 0
        Form1.DataGridView1.Rows.Clear()

    End Sub

    Sub Estadisticas()
        E1 = 0 : E2 = 0 : E3 = 0 : E4 = 0 : E5 = 0 : E6 = 0
        For i = 0 To indice - 1 Step 1
            If Vedad(i) < 25 Then
                E1 = E1 + 1
            End If
            If Vgenero(i) = "F" Then
                E2 = E2 + 1
            End If
            If Vgenero(i) = "M" And Vedad(i) > 18 And Vedad(i) < 26 Then
                E3 = E3 + 1
            End If
            If Vregistro(i) = "0" Then
                E4 = E4 + 1
            End If
            E5 = indice
            E6 = Round(E6 + Vmonto(i), 2)
        Next
        If E5 >= 1 Then
            Form1.lblE1.Text = Round((E1 * 100 / E5), 2).ToString + "%"
            Form1.lblE2.Text = Round((E2 * 100 / E5), 2).ToString + "%"
            Form1.lblE3.Text = Round((E3 * 100 / E5), 2).ToString + "%"
            Form1.lblE4.Text = Round((E4 * 100 / E5), 2).ToString + "%"
            Form1.lblE5.Text = E5.ToString
            Form1.lblE6.Text = "Q" + E6.ToString
        Else
            MsgBox("Ingrese datos a la memoria para calcular estadisticas",, "Error")
        End If


    End Sub

    Sub Lestadisticas()
        E1 = 0 : E2 = 0 : E3 = 0 : E4 = 0 : E5 = 0 : E6 = 0
        Form1.lblE1.Text = ""
        Form1.lblE2.Text = ""
        Form1.lblE3.Text = ""
        Form1.lblE4.Text = ""
        Form1.lblE5.Text = ""
        Form1.lblE6.Text = ""
    End Sub

End Module
