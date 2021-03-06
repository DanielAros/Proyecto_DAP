'**************************************************'
'Se importan librerias y codigos necesarios'
'**************************************************'
Imports System.Data.OleDb
Imports System.Runtime.InteropServices

Public Class Iniciar_Sesion
    'Dim significa que es privada la variable
    'Dim Micorreo As String

    'Variable publica
    Public Correo As String
    Public Apellido As String
    Public Facultad As String

    '**************************************************'
    'Botones para minimizar y cerrar (Evento click)'
    '**************************************************'

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Close()
    End Sub

    Private Sub ButtonMinimizar_Click(sender As Object, e As EventArgs) Handles ButtonMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
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

    Private Sub Iniciar_Sesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Enlace()
        Cargar_Usuarios_En_Combobox()
    End Sub

    '//**************************************************************
    '// Proceso para cargar usuarios en el combobox
    '//**************************************************************

    Private Sub Cargar_Usuarios_En_Combobox()
        Try

            Dim Tabla As New DataTable
            Dim ConsultaSql As String = "SELECT Nombre From Usuarios"
            Dim adaptador As New OleDbDataAdapter(ConsultaSql, Conexion)
            adaptador.Fill(Tabla)

            CB_Usuarios.DataSource = Tabla
            CB_Usuarios.DisplayMember = "Nombre"

        Catch ex As Exception
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub PanelInferior_Paint(sender As Object, e As PaintEventArgs) Handles PanelInferior.Paint

    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click

        Try
            Dim ConsultaSql As String
            Dim Adaptador As New OleDbDataAdapter
            Dim Lector As OleDb.OleDbDataReader
            Dim Comando As New OleDb.OleDbCommand


            ConsultaSql = "SELECT * FROM Usuarios Where Nombre = '" & CB_Usuarios.Text & "' AND Clave = '" & TxtPassword.Text & "'"
            Comando = New OleDbCommand(ConsultaSql, Conexion)
            Adaptador.SelectCommand = Comando
            Lector = Comando.ExecuteReader

            If Lector.Read = True Then
                '//Instrucciones si los datos coinciden
                Me.Hide()
                Bienvenida.ShowDialog()
            Else
                '//Instrucciones si los datos no coinciden
                '############# Mensaje de error #################'
                MsgBox("Contraseña incorrecta", MsgBoxStyle.Critical, "Inicio Sesion")
                TxtPassword.Clear()
            End If

        Catch ex As Exception
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
        End Try

        'If CB_Usuarios.Text = "Daniel Aros" And TxtPassword.Text = "1234" Or
        '   CB_Usuarios.Text = "Elias Ramirez" And TxtPassword.Text = "123" Or
        '   CB_Usuarios.Text = "Maria Perez" And TxtPassword.Text = "12" Then

        '    Me.Hide()
        '    'Bienvenida.Show() se sobreponen los formularios
        '    Bienvenida.ShowDialog()


        '    '############# Mensaje de confirmacion #################'
        '    'MsgBox("Inicio sesion con exito", MsgBoxStyle.OkOnly, "Inicio Sesion")
        'Else
        '    '############# Mensaje de error #################'
        '    MsgBox("Contraseña incorrecta", MsgBoxStyle.Critical, "Inicio Sesion")
        '    TxtPassword.Clear()
        '    TxtPassword.Focus()
        'End If

        'TxtPassword.PasswordChar = ""
        'LabelTitulo.Text = "Daniel Aros"
        'LabelFacultad.Text = "21"
        'ButtonAceptar.Visible = False
        'ButtonRegresar.Visible = True
    End Sub

    Private Sub ButtonRegresar_Click(sender As Object, e As EventArgs) Handles ButtonRegresar.Click
        LabelTitulo.Text = "Iniciar Sesión"
        LabelFacultad.Text = "Facultad de Informática"
        ButtonRegresar.Visible = False
        ButtonAceptar.Visible = True
    End Sub

    Private Sub ButtonMostrarPassword_Click(sender As Object, e As EventArgs) Handles ButtonMostrarPassword.Click
        TxtPassword.PasswordChar = "*"
        ButtonMostrarPassword.Visible = False
        ButtonOcultarPassword.Visible = True

    End Sub

    Private Sub ButtonOcultarPassword_Click(sender As Object, e As EventArgs) Handles ButtonOcultarPassword.Click
        TxtPassword.PasswordChar = ""
        ButtonMostrarPassword.Visible = True
        ButtonOcultarPassword.Visible = False
    End Sub

    Private Sub CB_Usuarios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_Usuarios.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub CB_Usuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Usuarios.SelectedIndexChanged

        Cargar_Datos_De_Usuario()



        'If CB_Usuarios.Text = "Daniel Aros" Then

        '    Micorreo = "danielaros@gmail.com"
        '    Tipo_InicioSesion = "Administrador"
        '    Telefono = "4425689215"
        '    Direccion = "Av de las ciencias"
        '    Facultad = "Informatica"

        '    '-------------------MENSAJE DE CONFIRMACION------------------------------
        '    'MsgBox("El correo del usuario es: " & Micorreo, MsgBoxStyle.OkOnly, "Iniciando Sesion")
        'Else
        '    Micorreo = "Correo"
        '    Tipo_InicioSesion = "Tipo"
        '    Telefono = "Telefono"
        '    Direccion = "Direccion"
        'End If
    End Sub

    '//**************************************************************
    '// Proceso para cargar datos del usuario seleccionado
    '//**************************************************************

    Private Sub Cargar_Datos_De_Usuario()
        Try

            Dim ConsultaSql As String
            Dim Lista As Long
            Dim Registro As DataSet
            Dim adaptador As OleDbDataAdapter

            ConsultaSql = "SELECT Apellido, Correo, Facultad FROM Usuarios WHERE Nombre = '" & CB_Usuarios.Text & "'"
            adaptador = New OleDbDataAdapter(ConsultaSql, Conexion)

            Registro = New DataSet

            adaptador.Fill(Registro, "Usuarios")
            Lista = Registro.Tables("Usuarios").Rows.Count

            If Lista <> 0 Then

                Apellido = Registro.Tables("Usuarios").Rows(0).Item("Apellido")
                Correo = Registro.Tables("Usuarios").Rows(0).Item("Correo")
                Facultad = Registro.Tables("Usuarios").Rows(0).Item("Facultad")

            End If

        Catch ex As Exception
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    'Si eliminamos la palabra reservada Private, podemos usar este proceso en otro formulario
    Private Sub Limpiar_Txt()
        CB_Usuarios.Text = "Selecciona un usuario"
        LabelPassword.Text = ""
    End Sub

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged

    End Sub

    Private Sub Iniciar_Sesion_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub LinkLabelPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelPassword.LinkClicked
        Me.Hide()
        Recuperar_Password.ShowDialog()
    End Sub

    Private Sub PanelBarraTitutlo_Paint(sender As Object, e As PaintEventArgs) Handles PanelBarraTitutlo.Paint

    End Sub

    Private Sub Iniciar_Sesion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

    End Sub

    'Apuntes: Que es un evento, variable, temporizador, clear. 
End Class