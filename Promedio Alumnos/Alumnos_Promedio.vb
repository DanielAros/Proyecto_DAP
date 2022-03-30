Public Class Alumnos_Promedio
    Private Sub Alumnos_Promedio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click
        Dim ParcialUno As Double
        Dim ParcialDos As Double
        Dim ParcialTres As Double
        Dim Promedio As Double
        Try
            If TxtExpediente.Text = Nothing Or
                TxtNombre.Text = Nothing Or TxtParcial1.Text = Nothing Or txtDos.Text = Nothing Or txtTres.Text = Nothing Then
                MsgBox("Existen informacion sin registrar, ingresa la necesaria ", MsgBoxStyle.Critical, "Promedio Alumnos")
            Else
                ParcialUno = TxtParcial1.Text
                ParcialDos = txtDos.Text
                ParcialTres = txtTres.Text

                Promedio = (ParcialUno + ParcialDos + ParcialTres) / 3
                TextPromedio.Text = Promedio

                'Mensaje de confirmacion
                MsgBox("El usuario: " & TxtNombre.Text & " , con un expediente: " & TxtExpediente.Text & " , obtuvo un promedio de: " & Promedio & "", MsgBoxStyle.OkOnly, "Promedio Alumnos")
            End If
        Catch ex As Exception
            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
        '------------------------------------------------------------------------
        End Try

    End Sub

    Private Sub TxtExpediente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtExpediente.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtParcial1_TextChanged(sender As Object, e As EventArgs) Handles TxtParcial1.TextChanged

    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click

    End Sub
End Class