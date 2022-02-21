'**************************************************'
'Se importan librerias y codigos necesarios'
'**************************************************'
Imports System.Data.OleDb
Imports System.Runtime.InteropServices

Public Class Formulario_Principal

    Private Sub Formulario_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelNombre.Text = Iniciar_Sesion.CB_Usuarios.Text
        LabelCorreo.Text = Iniciar_Sesion.Micorreo
        LabelNombreFacultad.Text = Iniciar_Sesion.Facultad
        LabelTipoUsuario.Text = Iniciar_Sesion.Tipo_InicioSesion
    End Sub

    Private Sub BtnInicio_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Application.Exit()
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

    Private Sub PanelBarraMenu_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelBarraMenu.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PanelContenedor_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelContenedor.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub LabelBienvenido_Click(sender As Object, e As EventArgs) Handles LabelBienvenido.Click

    End Sub

    Private Sub BtnInicio_Click_1(sender As Object, e As EventArgs) Handles BtnInicio.Click

    End Sub

    Private Sub ButtonMinimizar_Click(sender As Object, e As EventArgs) Handles ButtonMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    '--------------------------------------------------------------------------------------------------------------


End Class