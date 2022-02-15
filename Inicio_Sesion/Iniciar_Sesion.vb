'**************************************************'
'Se importan librerias y codigos necesarios'
'**************************************************'
Imports System.Data.OleDb
Imports System.Runtime.InteropServices

Public Class Iniciar_Sesion
    'Dim significa que es privada la variable
    'Dim Micorreo As String

    'Variable publica
    Public Micorreo As String
    Public Tipo_InicioSesion As String
    Public Telefono As String
    Public Direccion As String

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
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
        CB_Usuarios.Text = "Seleccione un usuario"

        CB_Usuarios.SelectedIndex = 0
        TxtPassword.Text = "1234"
    End Sub

    Private Sub PanelInferior_Paint(sender As Object, e As PaintEventArgs) Handles PanelInferior.Paint

    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click

        If CB_Usuarios.Text = "Daniel Aros" And TxtPassword.Text = "1234" Or
           CB_Usuarios.Text = "Elias Ramirez" And TxtPassword.Text = "123" Or
           CB_Usuarios.Text = "Maria Perez" And TxtPassword.Text = "12" Then

            Me.Hide()
            'Bienvenida.Show() se sobreponen los formularios
            Bienvenida.ShowDialog()


            '############# Mensaje de confirmacion #################'
            'MsgBox("Inicio sesion con exito", MsgBoxStyle.OkOnly, "Inicio Sesion")
        Else
            '############# Mensaje de error #################'
            MsgBox("Contraseña incorrecta", MsgBoxStyle.Critical, "Inicio Sesion")
            TxtPassword.Clear()
            TxtPassword.Focus()
        End If

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

        If CB_Usuarios.Text = "Daniel Aros" Then
            Micorreo = "danielaros@gmail.com"
            Tipo_InicioSesion = "Administrador"
            Telefono = "4425689215"
            Direccion = "Av de las ciencias"

            '-------------------MENSAJE DE CONFIRMACION------------------------------
            'MsgBox("El correo del usuario es: " & Micorreo, MsgBoxStyle.OkOnly, "Iniciando Sesion")
        Else
            Micorreo = "Correo"
            Tipo_InicioSesion = "Tipo"
            Telefono = "Telefono"
            Direccion = "Direccion"
        End If
    End Sub

    'Si eliminamos la palabra reservada Private, podemos usar este proceso en otro formulario
    Private Sub Limpiar_Txt()
        CB_Usuarios.Text = "Selecciona un usuario"
        LabelPassword.Text = ""
    End Sub

    'Apuntes: Que es un evento, variable, temporizador, clear. 
End Class