'----------------- Se importan dll para DBA access y codigos necesarios ------------------
Imports System.Data.OleDb

Public Class Registro_Alumno
    Private Sub Registro_Alumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar_Alumnos()
    End Sub


    '------------------ PROCESO PARA MOSTRAR INFORMACION INFORMACION DE LA TABLA ALUMNOS EN EL DATAGRID
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
            GridAlumnos.AllowUserToAddRows = False

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
        Registro_De_Alumnos()
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
End Class