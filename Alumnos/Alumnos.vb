Public Class Alumnos
    Private Sub Alumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar_text()
    End Sub

    Private Sub ButtonRegistrar_Click(sender As Object, e As EventArgs) Handles ButtonRegistrar.Click
        Try

            If TxtExpediente.Text = Nothing Or TxtNombre.Text = Nothing Or TxtApellido.Text = Nothing Or CB_Genero.Text = "Selecciona genero" Then
                MsgBox("Existen informacion sin registrar, ingresa la necesaria ", MsgBoxStyle.Critical, "Registro Alumnos")
            Else

                Dim Respuesta As DialogResult = MessageBox.Show("Se registrara nuevo alumno en la Dase de datos, ¿Deseas Continuar?", "Alumnos", MessageBoxButtons.YesNo)

                If Respuesta = DialogResult.Yes Then
                    '//Instrucciones si dice que SI
                    GridAlumnos.Rows.Add(TxtExpediente.Text, TxtNombre.Text, TxtApellido.Text, CB_Genero.Text)
                    Limpiar_text()
                ElseIf Respuesta = DialogResult.No Then
                    '//Instrucciones si dice que NO

                End If
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

    Private Sub Limpiar_text()
        TxtExpediente.Clear()
        TxtNombre.Clear()
        TxtApellido.Clear()
        CB_Genero.Text = "Selecciona genero"
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        Limpiar_text()
    End Sub
End Class