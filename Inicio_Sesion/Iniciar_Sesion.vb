'**************************************************'
'Se importan librerias y codigos necesarios'
'**************************************************'
Imports System.Data.OleDb
Imports System.Runtime.InteropServices

Public Class Iniciar_Sesion

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
    End Sub

    Private Sub PanelInferior_Paint(sender As Object, e As PaintEventArgs) Handles PanelInferior.Paint

    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click

        If CB_Usuarios.Text = "Daniel Aros" And TxtPassword.Text = "1234" Or
           CB_Usuarios.Text = "Elias Ramirez" And TxtPassword.Text = "123" Or
           CB_Usuarios.Text = "Maria Perez" And TxtPassword.Text = "12" Then

            '############# Mensaje de confirmacion #################'
            MsgBox("Inicio sesion con exito", MsgBoxStyle.OkOnly, "Inicio Sesion")
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
End Class