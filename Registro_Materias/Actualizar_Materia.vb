'**************************************************'
'Se importan librerias y codigos necesarios'
'**************************************************'
Imports System.Data.OleDb
Imports System.Runtime.InteropServices

Public Class Actualizar_Materia
    Private Sub Actualizar_Materia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Close()
    End Sub

    Private Sub ButtonMinimizar_Click(sender As Object, e As EventArgs) Handles ButtonMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PanelBarraTitutlo_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelBarraTitutlo.MouseDown

    End Sub

    '//**************************************************************
    '// Librearias y eventos para poder mover de lugar el formulario
    '//**************************************************************
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    Private Sub Actualizar_Materia_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown

    End Sub

    Private Sub PanelInferior_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelInferior.MouseDown

    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        If TxtMaestro.Text = Nothing Or
            TxtClave.Text = Nothing Or
            TxtCorreo.Text = Nothing Or
            TxtDescripcion.Text = Nothing Or
            TxtMateria.Text = Nothing Or
            Cbo_Semestre.Text = Nothing Or
            Cbo_Semestre.Text = "Selecciona semestre" Then

            MsgBox("Ingrese la información necesaria", MsgBoxStyle.Critical, "Actualizando materia")
        Else
            Dim Respuesta As DialogResult = MessageBox.Show("Se actualizara el registro, ¿Deseas continuar con la actualizacion?", "Actualizar Materias", MessageBoxButtons.YesNo)

            If Respuesta = DialogResult.Yes Then
                Actualizar_Materia()
            ElseIf Respuesta = DialogResult.No Then
                'Instrucciones en blanco
            End If
        End If

    End Sub

    Private Sub Actualizar_Materia()
        Try
            Dim cmdUpdate As New OleDbCommand
            Dim Formulario As Registro_Materias = CType(Owner, Registro_Materias)

            Dim Clave As Double
            Clave = TxtClave.Text

            cmdUpdate.Connection = Conexion

            cmdUpdate.CommandText = "UPDATE Materias SET Nombre_Materia = '" & TxtMateria.Text &
                "', Semestre = '" & Cbo_Semestre.Text &
                "', Descripcion = '" & TxtDescripcion.Text &
                "', Nombre_Maestro = '" & TxtMaestro.Text &
                "', Correo_Asignado = '" & TxtCorreo.Text &
                "' WHERE Clave = " & Clave

            cmdUpdate.ExecuteNonQuery()
            Me.Close()
            Formulario.Mostrar_Materias()
        Catch ex As Exception
            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------
        End Try

    End Sub
End Class