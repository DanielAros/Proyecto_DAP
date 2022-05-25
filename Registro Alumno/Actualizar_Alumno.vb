'**************************************************'
'Se importan librerias y codigos necesarios'
'**************************************************'
Imports System.Data.OleDb
Imports System.Runtime.InteropServices

Public Class Actualizar_Alumno
    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Close()
    End Sub

    Private Sub ButtonMinimizar_Click(sender As Object, e As EventArgs) Handles ButtonMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Actualizar_Alumno()
        Try
            Dim cmdUpdate As New OleDbCommand
            Dim Formulario As Registro_Alumno = CType(Owner, Registro_Alumno)

            Dim Expediente As Double
            Expediente = TxtExpediente.Text

            cmdUpdate.Connection = Conexion
            cmdUpdate.CommandText = "UPDATE Alumnos SET Nombre = '" & TxtNombre.Text &
                "', Apellido = '" & TxtApellido.Text &
                "', Genero = '" & Cbo_Genero.Text &
                "', Fecha_Nacimiento = '" & TxtFecha.Text &
                "', Direccion = '" & TxtDireccion.Text &
                "', Facultad = '" & Cbo_Facultad.Text &
                "', Semestre = '" & Cbo_Semestre.Text &
                "' WHERE Expediente = " & Expediente

            cmdUpdate.ExecuteNonQuery()
            Me.Close()
            Formulario.Mostrar_Alumnos()

        Catch ex As Exception
            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------
        End Try
    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        If TxtNombre.Text = Nothing Or
            TxtApellido.Text = Nothing Or
            TxtDireccion.Text = Nothing Or
            TxtFecha.Text = Nothing Or
            TxtExpediente.Text = Nothing Or
            Cbo_Facultad.Text = Nothing Or
            Cbo_Facultad.Text = "Selecciona facultad" Or
            Cbo_Genero.Text = Nothing Or
            Cbo_Genero.Text = "Selecciona genero" Or
            Cbo_Semestre.Text = Nothing Or
            Cbo_Semestre.Text = "Selecciona Semestre" Then

            MsgBox("Ingrese la información necesaria", MsgBoxStyle.Critical, "Actualizar Alumno")
        Else
            Dim Respuesta As DialogResult = MessageBox.Show("Se actualizara el registro, ¿Deseas continuar con la actualizacion?", "Actualizar Alumno", MessageBoxButtons.YesNo)

            If Respuesta = DialogResult.Yes Then
                Actualizar_Alumno()
            ElseIf Respuesta = DialogResult.No Then
                'Instrucciones en blanco
            End If
        End If
    End Sub

    '//**************************************************************
    '// Librearias y eventos para poder mover de lugar el formulario
    '//**************************************************************
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelBarraTitutlo_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelBarraTitutlo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Actualizar_Alumno_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PanelInferior_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelInferior.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class