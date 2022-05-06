'----------------- Se importan dll para DBA access y codigos necesarios ------------------
Imports System.Data.OleDb

Public Class Registro_Alumno
    Private Sub Registro_Alumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar_Alumnos()
        Limpiar_Txt()
    End Sub

    '------------------ PROCESO PARA MOSTRAR INFORMACION DE LA TABLA ALUMNOS EN EL DATAGRID
    Private Sub Mostrar_Alumnos()
        Try
            Dim Paquete As New DataSet
            Dim ConsultaSql As String
            Dim Adaptador As New OleDbDataAdapter

            ConsultaSql = "SELECT * FROM Alumnos ORDER BY Apellido Asc"
            Adaptador = New OleDbDataAdapter(ConsultaSql, Conexion)
            Paquete.Tables.Add("Alumnos")
            Adaptador.Fill(Paquete.Tables("Alumnos"))

            GridAlumnos.DataSource = Paquete.Tables("Alumnos")
            GridAlumnos.AllowUserToAddRows = False 'Permite que no se agregue una fila en blanco

            '/ Conteo de registros de alumnos 
            TxtTotal.Text = GridAlumnos.Rows.Count

            '/ Tamaño de columnas en un dataGrid
            GridAlumnos.Columns("Nombre").Width = 150
            GridAlumnos.Columns("Direccion").Width = 200

            '/ Ocultar columnas en un dataGrid
            GridAlumnos.Columns("Genero").Visible = False
            GridAlumnos.Columns("Direccion").Visible = False
        Catch ex As Exception
            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------
        End Try
    End Sub

    Private Sub ButtonRegistrar_Click(sender As Object, e As EventArgs) Handles ButtonRegistrar.Click
        'Registro_De_Alumnos()
        Try
            If TxtNombre.Text = Nothing Or
                TxtApellido.Text = Nothing Or
                TxtExpediente.Text = Nothing Or
                TxtFecha.Text = Nothing Or
                TxtDireccion.Text = Nothing Or
                Cbo_Facultad.Text = Nothing Or
                Cbo_Genero.Text = Nothing Or
                Cbo_Semestre.Text = Nothing Then

                '------------Mensaje de Error
                MsgBox("Existe mensaje en blanco, rellenala porfavor", MsgBoxStyle.Critical, "Registro de Alumnos")

            Else
                Dim Respuesta As DialogResult = MessageBox.Show("Se agregará un nuevo registro, ¿Deseas continuar con el registro?", "Registro Alumno", MessageBoxButtons.YesNo)

                If Respuesta = DialogResult.Yes Then
                    Registro_De_Alumnos()
                    Mostrar_Alumnos()
                    Limpiar_Txt()
                ElseIf Respuesta = DialogResult.No Then
                    'Instrucciones en blanco

                End If
            End If

        Catch ex As Exception
            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------
        End Try
    End Sub


    '//####################################
    '// Proceso para agregar un nuevo usuario a la base de datos
    '//####################################
    Dim Comandos As New OleDb.OleDbCommand

    Private Sub Registro_De_Alumnos()
        Try

            Comandos.Connection = Conexion
            Comandos = New OleDb.OleDbCommand("INSERT INTO Alumnos(Expediente, Nombre, Apellido, Genero, Fecha_Nacimiento, Direccion, Facultad, Semestre)" & Chr(13) &
                                              "VALUES(Expediente, Nombre, Apelldio, Genero, Fecha_Nacimiento, Direccion, Facultad, Semestre)", Conexion)

            Comandos.Parameters.AddWithValue("@Expediente", TxtExpediente.Text)
            Comandos.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
            Comandos.Parameters.AddWithValue("@Apellido", TxtApellido.Text)
            Comandos.Parameters.AddWithValue("@Genero", Cbo_Genero.Text)
            Comandos.Parameters.AddWithValue("@Fecha_Nacimiento", TxtFecha.Text)
            Comandos.Parameters.AddWithValue("@Direccion", TxtDireccion.Text)
            Comandos.Parameters.AddWithValue("@Facultad", Cbo_Facultad.Text)
            Comandos.Parameters.AddWithValue("@Semestre", Cbo_Semestre.Text)

            Comandos.ExecuteNonQuery() 'Ejecuta la sentencia de instrucciones
        Catch ex As Exception
            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------
        End Try

    End Sub

    Private Sub GridAlumnos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridAlumnos.CellContentClick

    End Sub

    Private Sub Limpiar_Txt()
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtExpediente.Clear()
        TxtFecha.Clear()
        TxtDireccion.Clear()
        Cbo_Genero.Text = "Selecciona genero"
        Cbo_Facultad.Text = "Selecciona facultad"
        Cbo_Semestre.Text = "Selecciona Semestre"
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        Limpiar_Txt()
    End Sub

    Private Sub Buscar_Expediente()
        Try
            Dim Adaptador As New OleDbDataAdapter
            Dim Paquete As New DataSet
            Dim ConsultaSql As String
            Dim Registro As Long

            ConsultaSql = "SELECT * FROM Alumnos WHERE Expediente = " & TxtExpediente.Text

            Adaptador = New OleDbDataAdapter(ConsultaSql, Conexion)
            Paquete = New DataSet

            Adaptador.Fill(Paquete, "Alumnos")
            Registro = Paquete.Tables("Alumnos").Rows.Count

            If Registro <> 0 Then
                '---------------Mensaje de error---------------------------------
                MsgBox("El expediente que ingresaste ya está registrado", MsgBoxStyle.Critical, "Registro Alumnos")
                '----------------------------------------------------------------

                TxtExpediente.Focus()
            End If
        Catch ex As Exception
            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------
        End Try
    End Sub

    Private Sub TxtExpediente_Leave(sender As Object, e As EventArgs) Handles TxtExpediente.Leave
        Buscar_Expediente()
    End Sub
End Class