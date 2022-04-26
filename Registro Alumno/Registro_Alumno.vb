
Imports System.Data.OleDb

Public Class Registro_Alumno
    Private Sub Registro_Alumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Mostrar_Alumnos()
        Dim Paquete As New DataSet
        Dim ConsultaSql As String
        'Dim Adaptador As New OleDbDataAdapter

        ConsultaSql = "SELECT * FROM Alumnos ORDER BY "


        '//Conteo de registros de alumnos
        ''TxtTotal.Text = GridAlumnos.Rows.Count

        '// Tamaño de columnas en un datagrid
        'GridAlumnos.Columns("Nombre").Width = 150
        'GridAlumnos.Columns("Direccion").Width = 200
        'GridAlumnos.Columns("Correo").Width = 150

        '// Ocultar columnas en un datagrid
        GridAlumnos.Columns("Genero").Visible = False
        GridAlumnos.Columns("Direccion").Visible = False

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

        End Try

    End Sub
End Class