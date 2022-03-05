'**************************************************'
'Se importan librerias y codigos necesarios'
'**************************************************'
Imports System.Data.OleDb
Imports System.Runtime.InteropServices

Public Class Recuperar_Password

    Dim correo As String

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Close()
        Iniciar_Sesion.Show()
        'Application.Exit()
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

    Private Sub Recuperar_Password_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub ButtonMinimizar_Click(sender As Object, e As EventArgs) Handles ButtonMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Recuperar_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CB_Usuarios.SelectedIndex = 0
    End Sub

    Private Sub CB_Usuarios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_Usuarios.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub CB_Usuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Usuarios.SelectedIndexChanged

        If CB_Usuarios.Text = "Daniel Aros" Then
            correo = "danielaros200@gmail.com"

        ElseIf CB_Usuarios.Text = "Elias Ramirez" Then
            correo = "elias.ramirez@gmail.com"
        ElseIf CB_Usuarios.Text = "Maria Perez" Then
            correo = "mariaperez@gmail.com"
        End If

        TxtCorreo.Text = correo
    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        MsgBox("Se ha enviado la recuperacion de contraseña al correo: " + correo, MsgBoxStyle.OkOnly, "Recuperar Contraseña")
    End Sub

    Private Sub TxtCorreo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCorreo.KeyPress
        e.KeyChar = ""
    End Sub
End Class