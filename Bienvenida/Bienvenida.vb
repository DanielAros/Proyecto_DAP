'**************************************************'
'Se importan librerias y codigos necesarios'
'**************************************************'
Imports System.Data.OleDb
Imports System.Runtime.InteropServices

Public Class Bienvenida

    Private Sub Bienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelNombre.Text = Iniciar_Sesion.CB_Usuarios.Text
        ProgressBarCargando.Value = 0
        Me.Opacity = 0
        TimerAbrir.Start()
    End Sub
    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        'Me.Close()
        Application.Exit()
        'TimerCerrar.Start()
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

    Private Sub Bienvenida_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PBLogo_Click(sender As Object, e As EventArgs) Handles PBLogo.Click

    End Sub

    Private Sub PBLogo_MouseDown(sender As Object, e As MouseEventArgs) Handles PBLogo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LabelCargando.Click

    End Sub


    '//**************************************************************
    '// Temporizador para abrir y cerrar formulario con evento desvanecido
    '//**************************************************************

    Private Sub TimerAbrir_Tick(sender As Object, e As EventArgs) Handles TimerAbrir.Tick

        ProgressBarCargando.Value += 1

        LabelCargando.Text = CLng((ProgressBarCargando.Value * 100) / ProgressBarCargando.Maximum) & "%"
        'LabelCargando.Text = ProgressBarCargando.Value & "%"


        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        End If

        If ProgressBarCargando.Value = 100 Then
            TimerAbrir.Stop()
        End If

    End Sub

    Private Sub TimerCerrar_Tick(sender As Object, e As EventArgs) Handles TimerCerrar.Tick

        Me.Opacity -= 0.1

        If Me.Opacity = 0 Then
            TimerCerrar.Stop()
            Application.Exit()
        End If
    End Sub
End Class