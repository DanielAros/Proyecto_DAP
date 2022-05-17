'----------------- Se importan dll para DBA access y codigos necesarios ------------------
Imports System.Data.OleDb

Public Class Registro_Materias
    Private Sub Registro_Materias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar_Materias()
        Limpiar_Txt()
    End Sub

    '------------------ PROCESO PARA MOSTRAR INFORMACION DE LA TABLA ALUMNOS EN EL DATAGRID
    Private Sub Mostrar_Materias()
        Try
            Dim Paquete As New DataSet
            Dim ConsultaSql As String
            Dim Adaptador As New OleDbDataAdapter

            ConsultaSql = "SELECT * FROM Materias ORDER BY Nombre_Materia Asc"
            Adaptador = New OleDbDataAdapter(ConsultaSql, Conexion)
            Paquete.Tables.Add("Materias")
            Adaptador.Fill(Paquete.Tables("Materias"))

            GridMaterias.DataSource = Paquete.Tables("Materias")
            GridMaterias.AllowUserToAddRows = False 'Permite que no se agregue una fila en blanco

            '/ Conteo de registros de alumnos 
            TxtTotal.Text = GridMaterias.Rows.Count

            '/ Tamaño de columnas en un dataGrid
            GridMaterias.Columns("Nombre_Materia").Width = 200
            GridMaterias.Columns("Descripcion").Width = 240
            GridMaterias.Columns("Nombre_Maestro").Width = 200
            GridMaterias.Columns("Correo_Asignado").Width = 200

        Catch ex As Exception
            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------
        End Try
    End Sub

    Private Sub GridAlumnos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridMaterias.CellContentClick

    End Sub

    Private Sub ButtonRegistrar_Click(sender As Object, e As EventArgs) Handles ButtonRegistrar.Click
        Try
            If TxtMateria.Text = Nothing Or
                Cbo_Semestre.Text = Nothing Or
                TxtDescripcion.Text = Nothing Or
                TxtCorreo.Text = Nothing Or
                TxtMaestro.Text = Nothing Then

                '------------Mensaje de Error
                MsgBox("Existe mensaje en blanco, rellenala porfavor", MsgBoxStyle.Critical, "Registro de Materias")
            Else
                Dim Respuesta As DialogResult = MessageBox.Show("Se agregará un nuevo registro, ¿Deseas continuar con el registro?", "Registro Materias", MessageBoxButtons.YesNo)

                If Respuesta = DialogResult.Yes Then
                    Registro_De_Materias()
                    Mostrar_Materias()
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

    Private Sub Registro_De_Materias()
        Try
            Comandos.Connection = Conexion
            Comandos = New OleDb.OleDbCommand("INSERT INTO Materias(Nombre_Materia, Semestre, Descripcion, Nombre_Maestro, Correo_Asignado)" & Chr(13) &
                                              "VALUES(Nombre_Materia, Semestre, Descripcion, Nombre_Maestro, Correo_Asignado)", Conexion)

            Comandos.Parameters.AddWithValue("@Nombre_Materia", TxtMateria.Text)
            Comandos.Parameters.AddWithValue("@Semestre", Cbo_Semestre.Text)
            Comandos.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text)
            Comandos.Parameters.AddWithValue("@Nombre_Maestro", TxtMaestro.Text)
            Comandos.Parameters.AddWithValue("@Correo_Asignado", TxtCorreo.Text)

            Comandos.ExecuteNonQuery() 'Ejecuta la sentencia de instrucciones
        Catch ex As Exception
            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------
        End Try
    End Sub

    Private Sub Limpiar_Txt()
        TxtMateria.Clear()
        Cbo_Semestre.Text = "Seleccione un semestre"
        TxtDescripcion.Clear()
        TxtMaestro.Clear()
        TxtCorreo.Clear()
        GridMaterias.ClearSelection()
    End Sub


    Private Sub Eliminar_Materias()

    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click

    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        Limpiar_Txt()
    End Sub

    Private Sub EliminarRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarRegistroToolStripMenuItem.Click
        Try
            If GridMaterias.SelectedRows.Count = 0 Then
                '------------Mensaje de Error
                MsgBox("No hay ninguna fila seleccionada para eliminar", MsgBoxStyle.Critical, "Registro de Materias")
            Else
                Dim Respuesta As DialogResult = MessageBox.Show("Se eliminar las filas seleccionadas, ¿Deseas continuar con la operacion?", "Registro Materias", MessageBoxButtons.YesNo)

                If Respuesta = DialogResult.Yes Then
                    Dim cmdDelete = New OleDbCommand
                    For Each Row As DataGridViewRow In GridMaterias.SelectedRows
                        Dim Clave As Double = Row.Cells("Clave").Value
                        cmdDelete.Connection = Conexion
                        cmdDelete.CommandText = "DELETE FROM Materias Where Clave = " & Clave
                        cmdDelete.ExecuteNonQuery()
                    Next
                    Mostrar_Materias()
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

    Private Sub ActualizarRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarRegistroToolStripMenuItem.Click

        Try
            If GridMaterias.SelectedRows.Count = 0 Then
                '------------Mensaje de Error
                MsgBox("No hay ninguna fila seleccionada para actualizar", MsgBoxStyle.Critical, "Registro de Materias")
            Else
                Dim Actualizar_Materia As New Actualizar_Materia
                AddOwnedForm(Actualizar_Materia)
                Actualizar_Materia.TxtClave.Text = GridMaterias.CurrentRow.Cells(0).Value
                Actualizar_Materia.TxtMateria.Text = GridMaterias.CurrentRow.Cells(1).Value
                Actualizar_Materia.Cbo_Semestre.Text = GridMaterias.CurrentRow.Cells(2).Value
                Actualizar_Materia.TxtDescripcion.Text = GridMaterias.CurrentRow.Cells(3).Value
                Actualizar_Materia.TxtMaestro.Text = GridMaterias.CurrentRow.Cells(4).Value
                Actualizar_Materia.TxtCorreo.Text = GridMaterias.CurrentRow.Cells(5).Value

                Actualizar_Materia.ShowDialog()

            End If
        Catch ex As Exception
            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------
        End Try

    End Sub
End Class