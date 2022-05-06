'**************************************************'
'Se importan librerias y codigos necesarios'
'**************************************************'
Imports System.Data.OleDb
Imports System.Runtime.InteropServices

Public Class Formulario_Principal

    Private Sub Formulario_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelNombre.Text = Iniciar_Sesion.CB_Usuarios.Text
        LabelCorreo.Text = Iniciar_Sesion.Correo
        LabelNombreFacultad.Text = Iniciar_Sesion.Facultad

        Maximizar()

        BtnInicio.PerformClick()
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

    Private Sub ButtonMinimizar_Click(sender As Object, e As EventArgs) Handles ButtonMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Dim Lx, Ly As Integer 'Location (Lx, Ly)
    Dim Sw, Sh As Integer 'Size 
    Private Sub Maximizar()
        Try
            Lx = Me.Location.X
            Ly = Me.Location.Y

            Sw = Me.Size.Width
            Sh = Me.Size.Height

            Me.Size = Screen.PrimaryScreen.WorkingArea.Size
            Me.Location = Screen.PrimaryScreen.WorkingArea.Location

            BtnMaximizar.Visible = False
            BtnRestaurar.Visible = True
        Catch ex As Exception
            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------
        End Try

    End Sub


    Private Sub BtnRestaurar_Click(sender As Object, e As EventArgs) Handles BtnRestaurar.Click

        Try
            Me.Size = New Size(Sw, Sh)
            Me.Location = New Point(Lx, Ly)
            BtnMaximizar.Visible = True
            BtnRestaurar.Visible = False
        Catch ex As Exception
            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------
        End Try
    End Sub

    Private Sub BtnMaximizar_Click(sender As Object, e As EventArgs) Handles BtnMaximizar.Click
        Maximizar()
    End Sub

    '--------------------------------------------------------------------------------------------------------------
    '//**************************************************************
    '// Botones que dan inicio a los formularios hijos
    '//**************************************************************

    Private Sub BtnInicio_Click_1(sender As Object, e As EventArgs) Handles BtnInicio.Click
        If (Not (FormularioActivo) Is Nothing) Then
            FormularioActivo.Close()
            regresarColores()
        End If

        BtnInicio.FlatAppearance.BorderColor = Color.Red
        BtnInicio.FlatAppearance.BorderSize = 2
        'regresarColores()
        'AbrirFormularioContenedor(New Formulario_Uno)
        'BtnInicio.FlatAppearance.BorderColor = Color.Turquoise
        ''BtnInicio.FlatAppearance.BorderColor = Color.FromArgb(24, 24, 24)

    End Sub


    Dim FormularioActivo As Form = Nothing

    Private Sub AbrirFormularioContenedor(ByVal FormularioHijo As Form)

        Try
            If (Not (FormularioActivo) Is Nothing) Then
                FormularioActivo.Close()
            End If

            FormularioActivo = FormularioHijo
            FormularioHijo.TopLevel = False
            FormularioHijo.FormBorderStyle = FormBorderStyle.None
            FormularioHijo.Dock = DockStyle.Fill

            PanelContenedor.Controls.Add(FormularioHijo)
            PanelContenedor.Tag = FormularioHijo

            FormularioHijo.BringToFront()
            FormularioHijo.Show()
        Catch ex As Exception
            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------
        End Try

    End Sub

    Private Sub PanelContenedor_Paint(sender As Object, e As PaintEventArgs) Handles PanelContenedor.Paint

    End Sub

    Private Sub BtnAlumnos_Click(sender As Object, e As EventArgs) Handles BtnAlumnos.Click
        regresarColores()
        AbrirFormularioContenedor(New Alumnos)
        BtnAlumnos.FlatAppearance.BorderColor = Color.Red
    End Sub

    Private Sub BtnPromedio_Click(sender As Object, e As EventArgs) Handles BtnPromedio.Click
        regresarColores()
        AbrirFormularioContenedor(New Alumnos_Promedio)
        BtnPromedio.FlatAppearance.BorderColor = Color.Red


    End Sub

    Private Sub PromedioCondicional_Click(sender As Object, e As EventArgs) Handles PromedioCondicional.Click
        regresarColores()
        'AbrirFormularioContenedor(New Alumnos_Promedio)
        AbrirFormularioContenedor(New Formulario_Promedio)
        PromedioCondicional.FlatAppearance.BorderColor = Color.Red
    End Sub

    Private Sub BtnRegistroAlumno_Click(sender As Object, e As EventArgs) Handles BtnRegistroAlumno.Click
        regresarColores()
        AbrirFormularioContenedor(New Registro_Alumno)
        BtnRegistroAlumno.FlatAppearance.BorderColor = Color.Red
    End Sub

    Private Sub BtnRegistroMateria_Click(sender As Object, e As EventArgs) Handles BtnRegistroMateria.Click
        regresarColores()
        AbrirFormularioContenedor(New Registro_Materias)
        BtnRegistroMateria.FlatAppearance.BorderColor = Color.Red
    End Sub

    Private Sub regresarColores()
        BtnInicio.FlatAppearance.BorderColor = Color.FromArgb(46, 48, 60)
        BtnAlumnos.FlatAppearance.BorderColor = Color.FromArgb(46, 48, 60)
        BtnPromedio.FlatAppearance.BorderColor = Color.FromArgb(46, 48, 60)
        PromedioCondicional.FlatAppearance.BorderColor = Color.FromArgb(46, 48, 60)
        BtnRegistroAlumno.FlatAppearance.BorderColor = Color.FromArgb(46, 48, 60)
        BtnRegistroMateria.FlatAppearance.BorderColor = Color.FromArgb(46, 48, 60)
    End Sub

    Private Sub TimerHora_Tick(sender As Object, e As EventArgs) Handles TimerHora.Tick

        Try
            LabelHora.Text = DateTime.Now.ToString("HH:mm:ss")
            LabelFecha.Text = DateTime.Now.ToLongDateString
        Catch ex As Exception
            '-----------------MENSAJE DE ERROR---------------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '------------------------------------------------------------------------
        End Try

    End Sub


End Class