Public Class Formulario_Promedio
    Private Sub Formulario_Promedio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click
        Dim Nombre As String
        Dim Facultad As String
        Dim Semestre As String
        Dim Cal1 As Double
        Dim Cal2 As Double
        Dim Cal3 As Double
        Dim Cal4 As Double
        Dim Promedio As Double

        Try
            If TxtNombre.Text = Nothing Or TxtFacultad.Text = Nothing Or TxtSemestre.Text = Nothing Or TxtCal1.Text = Nothing Or TxtCal2.Text = Nothing Or TxtCal3.Text = Nothing Or TxtCal4.Text = Nothing Then
                '-----------------MENSAJE---------------------------------------
                MsgBox("Existen informacion sin registrar, ingresa la necesaria ", MsgBoxStyle.Critical, "Promedio")
                '------------------------------------------------------------------------
            ElseIf TxtCal1.Text = 0 Or TxtCal2.Text = 0 Or TxtCal3.Text = 0 Or TxtCal4.Text = 0 Then
                '-----------------MENSAJE---------------------------------------
                MsgBox("Ingrese información valida mayor a 0", MsgBoxStyle.Critical, "Promedio")
                '------------------------------------------------------------------------
            Else
                Cal1 = TxtCal1.Text
                Cal2 = TxtCal2.Text
                Cal3 = TxtCal3.Text
                Cal4 = TxtCal4.Text

                Promedio = (Cal1 + Cal2 + Cal3 + Cal4) / 4

                TxtPromedio.Text = Promedio

                If Promedio > 6 Then
                    'Mensaje de confirmacion
                    MsgBox("El alumno: " & TxtNombre.Text & " , de la facultad de: " & TxtFacultad.Text & " ,del semestre: " & TxtSemestre.Text & " , obtuvo un promedio de: " & Promedio & " , Esta aprobado." & "", MsgBoxStyle.OkOnly, "Promedio")
                Else
                    'Mensaje de confirmacion
                    MsgBox("El alumno: " & TxtNombre.Text & " , de la facultad de: " & TxtFacultad.Text & " ,del semestre: " & TxtSemestre.Text & " , obtuvo un promedio de: " & Promedio & ", Esta reprobado." & "", MsgBoxStyle.OkOnly, "Promedio")
                End If


            End If
        Catch ex As Exception
            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------
        End Try
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        TxtNombre.Clear()
        TxtFacultad.Clear()
        TxtSemestre.Clear()
        TxtCal1.Clear()
        TxtCal2.Clear()
        TxtCal3.Clear()
        TxtCal4.Clear()
        TxtPromedio.Clear()
    End Sub

    Private Sub TxtPromedio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPromedio.KeyPress
        e.KeyChar = ""
    End Sub
End Class