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

        Maximizar()
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


    Dim Lx, Ly As Integer 'Location (Lx, Ly)
    Dim Sw, Sh As Integer 'Size 
    Private Sub Maximizar()
        Lx = Me.Location.X
        Ly = Me.Location.Y

        Sw = Me.Size.Width
        Sh = Me.Size.Height

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location

        BtnMaximizar.Visible = False
        BtnRestaurar.Visible = True

    End Sub

    Private Sub BtnRestaurar_Click(sender As Object, e As EventArgs) Handles BtnRestaurar.Click
        Me.Size = New Size(Sw, Sh)
        Me.Location = New Point(Lx, Ly)
        BtnMaximizar.Visible = True
        BtnRestaurar.Visible = False
    End Sub

    Private Sub BtnMaximizar_Click(sender As Object, e As EventArgs) Handles BtnMaximizar.Click
        Maximizar()
    End Sub

    '--------------------------------------------------------------------------------------------------------------


End Class