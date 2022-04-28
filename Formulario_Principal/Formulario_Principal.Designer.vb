<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario_Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formulario_Principal))
        Me.PanelBarraTitutlo = New System.Windows.Forms.Panel()
        Me.BtnMaximizar = New System.Windows.Forms.Button()
        Me.BtnRestaurar = New System.Windows.Forms.Button()
        Me.ButtonLogoAdm = New System.Windows.Forms.Button()
        Me.ButtonMinimizar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.PanelBarraMenu = New System.Windows.Forms.Panel()
        Me.BtnRegistroAlumno = New System.Windows.Forms.Button()
        Me.PromedioCondicional = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.BtnPromedio = New System.Windows.Forms.Button()
        Me.BtnAlumnos = New System.Windows.Forms.Button()
        Me.BtnInicio = New System.Windows.Forms.Button()
        Me.LabelCorreo = New System.Windows.Forms.Label()
        Me.LabelNombreFacultad = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelTipoUsuario = New System.Windows.Forms.Label()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.LabelHora = New System.Windows.Forms.Label()
        Me.LabelBienvenido = New System.Windows.Forms.Label()
        Me.TimerHora = New System.Windows.Forms.Timer(Me.components)
        Me.PanelBarraTitutlo.SuspendLayout()
        Me.PanelBarraMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBarraTitutlo
        '
        Me.PanelBarraTitutlo.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.PanelBarraTitutlo.Controls.Add(Me.BtnMaximizar)
        Me.PanelBarraTitutlo.Controls.Add(Me.BtnRestaurar)
        Me.PanelBarraTitutlo.Controls.Add(Me.ButtonLogoAdm)
        Me.PanelBarraTitutlo.Controls.Add(Me.ButtonMinimizar)
        Me.PanelBarraTitutlo.Controls.Add(Me.ButtonSalir)
        Me.PanelBarraTitutlo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitutlo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitutlo.Name = "PanelBarraTitutlo"
        Me.PanelBarraTitutlo.Size = New System.Drawing.Size(705, 25)
        Me.PanelBarraTitutlo.TabIndex = 3
        '
        'BtnMaximizar
        '
        Me.BtnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMaximizar.FlatAppearance.BorderSize = 0
        Me.BtnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.BtnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMaximizar.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.BtnMaximizar.Location = New System.Drawing.Point(639, 0)
        Me.BtnMaximizar.Name = "BtnMaximizar"
        Me.BtnMaximizar.Size = New System.Drawing.Size(30, 25)
        Me.BtnMaximizar.TabIndex = 7
        Me.BtnMaximizar.Text = "<-"
        Me.BtnMaximizar.UseVisualStyleBackColor = True
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRestaurar.FlatAppearance.BorderSize = 0
        Me.BtnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.BtnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRestaurar.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.BtnRestaurar.Location = New System.Drawing.Point(639, 0)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(30, 25)
        Me.BtnRestaurar.TabIndex = 6
        Me.BtnRestaurar.Text = "->"
        Me.BtnRestaurar.UseVisualStyleBackColor = True
        Me.BtnRestaurar.Visible = False
        '
        'ButtonLogoAdm
        '
        Me.ButtonLogoAdm.BackgroundImage = CType(resources.GetObject("ButtonLogoAdm.BackgroundImage"), System.Drawing.Image)
        Me.ButtonLogoAdm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonLogoAdm.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonLogoAdm.FlatAppearance.BorderSize = 0
        Me.ButtonLogoAdm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ButtonLogoAdm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ButtonLogoAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLogoAdm.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.ButtonLogoAdm.Location = New System.Drawing.Point(3, 0)
        Me.ButtonLogoAdm.Name = "ButtonLogoAdm"
        Me.ButtonLogoAdm.Size = New System.Drawing.Size(30, 32)
        Me.ButtonLogoAdm.TabIndex = 5
        Me.ButtonLogoAdm.Text = "_"
        Me.ButtonLogoAdm.UseVisualStyleBackColor = True
        '
        'ButtonMinimizar
        '
        Me.ButtonMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonMinimizar.FlatAppearance.BorderSize = 0
        Me.ButtonMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.ButtonMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMinimizar.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.ButtonMinimizar.Location = New System.Drawing.Point(603, 0)
        Me.ButtonMinimizar.Name = "ButtonMinimizar"
        Me.ButtonMinimizar.Size = New System.Drawing.Size(30, 25)
        Me.ButtonMinimizar.TabIndex = 4
        Me.ButtonMinimizar.Text = "___"
        Me.ButtonMinimizar.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSalir.FlatAppearance.BorderSize = 0
        Me.ButtonSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.ButtonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.ButtonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSalir.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.ButtonSalir.Location = New System.Drawing.Point(675, 0)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(30, 25)
        Me.ButtonSalir.TabIndex = 3
        Me.ButtonSalir.Text = "X"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'PanelBarraMenu
        '
        Me.PanelBarraMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.PanelBarraMenu.Controls.Add(Me.BtnRegistroAlumno)
        Me.PanelBarraMenu.Controls.Add(Me.PromedioCondicional)
        Me.PanelBarraMenu.Controls.Add(Me.PanelLogo)
        Me.PanelBarraMenu.Controls.Add(Me.BtnPromedio)
        Me.PanelBarraMenu.Controls.Add(Me.BtnAlumnos)
        Me.PanelBarraMenu.Controls.Add(Me.BtnInicio)
        Me.PanelBarraMenu.Controls.Add(Me.LabelCorreo)
        Me.PanelBarraMenu.Controls.Add(Me.LabelNombreFacultad)
        Me.PanelBarraMenu.Controls.Add(Me.LabelNombre)
        Me.PanelBarraMenu.Controls.Add(Me.LabelTipoUsuario)
        Me.PanelBarraMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelBarraMenu.Location = New System.Drawing.Point(0, 25)
        Me.PanelBarraMenu.Name = "PanelBarraMenu"
        Me.PanelBarraMenu.Size = New System.Drawing.Size(136, 387)
        Me.PanelBarraMenu.TabIndex = 4
        '
        'BtnRegistroAlumno
        '
        Me.BtnRegistroAlumno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegistroAlumno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnRegistroAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistroAlumno.Font = New System.Drawing.Font("MS PGothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistroAlumno.ForeColor = System.Drawing.Color.White
        Me.BtnRegistroAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegistroAlumno.ImageIndex = 1
        Me.BtnRegistroAlumno.Location = New System.Drawing.Point(0, 232)
        Me.BtnRegistroAlumno.Margin = New System.Windows.Forms.Padding(1)
        Me.BtnRegistroAlumno.Name = "BtnRegistroAlumno"
        Me.BtnRegistroAlumno.Size = New System.Drawing.Size(136, 30)
        Me.BtnRegistroAlumno.TabIndex = 11
        Me.BtnRegistroAlumno.Text = "REGISTRO ALUMNO"
        Me.BtnRegistroAlumno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnRegistroAlumno.UseVisualStyleBackColor = True
        '
        'PromedioCondicional
        '
        Me.PromedioCondicional.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PromedioCondicional.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PromedioCondicional.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PromedioCondicional.Font = New System.Drawing.Font("MS PGothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PromedioCondicional.ForeColor = System.Drawing.Color.White
        Me.PromedioCondicional.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PromedioCondicional.ImageIndex = 1
        Me.PromedioCondicional.Location = New System.Drawing.Point(3, 200)
        Me.PromedioCondicional.Margin = New System.Windows.Forms.Padding(1)
        Me.PromedioCondicional.Name = "PromedioCondicional"
        Me.PromedioCondicional.Size = New System.Drawing.Size(136, 30)
        Me.PromedioCondicional.TabIndex = 10
        Me.PromedioCondicional.Text = "PROM CONDIC"
        Me.PromedioCondicional.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PromedioCondicional.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PBLogo)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(136, 100)
        Me.PanelLogo.TabIndex = 9
        '
        'PBLogo
        '
        Me.PBLogo.BackgroundImage = CType(resources.GetObject("PBLogo.BackgroundImage"), System.Drawing.Image)
        Me.PBLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBLogo.Location = New System.Drawing.Point(30, 13)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(78, 74)
        Me.PBLogo.TabIndex = 0
        Me.PBLogo.TabStop = False
        '
        'BtnPromedio
        '
        Me.BtnPromedio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPromedio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnPromedio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPromedio.Font = New System.Drawing.Font("MS PGothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPromedio.ForeColor = System.Drawing.Color.White
        Me.BtnPromedio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPromedio.ImageIndex = 1
        Me.BtnPromedio.Location = New System.Drawing.Point(0, 168)
        Me.BtnPromedio.Margin = New System.Windows.Forms.Padding(1)
        Me.BtnPromedio.Name = "BtnPromedio"
        Me.BtnPromedio.Size = New System.Drawing.Size(136, 30)
        Me.BtnPromedio.TabIndex = 2
        Me.BtnPromedio.Text = "PROMEDIO"
        Me.BtnPromedio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPromedio.UseVisualStyleBackColor = True
        '
        'BtnAlumnos
        '
        Me.BtnAlumnos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAlumnos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAlumnos.Font = New System.Drawing.Font("MS PGothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlumnos.ForeColor = System.Drawing.Color.White
        Me.BtnAlumnos.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.BtnAlumnos.ImageIndex = 2
        Me.BtnAlumnos.Location = New System.Drawing.Point(0, 136)
        Me.BtnAlumnos.Margin = New System.Windows.Forms.Padding(1)
        Me.BtnAlumnos.Name = "BtnAlumnos"
        Me.BtnAlumnos.Size = New System.Drawing.Size(136, 30)
        Me.BtnAlumnos.TabIndex = 3
        Me.BtnAlumnos.Text = "ALUMNOS"
        Me.BtnAlumnos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAlumnos.UseVisualStyleBackColor = True
        '
        'BtnInicio
        '
        Me.BtnInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnInicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInicio.Font = New System.Drawing.Font("MS PGothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInicio.ForeColor = System.Drawing.Color.White
        Me.BtnInicio.Image = CType(resources.GetObject("BtnInicio.Image"), System.Drawing.Image)
        Me.BtnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInicio.Location = New System.Drawing.Point(0, 104)
        Me.BtnInicio.Margin = New System.Windows.Forms.Padding(1)
        Me.BtnInicio.Name = "BtnInicio"
        Me.BtnInicio.Size = New System.Drawing.Size(136, 30)
        Me.BtnInicio.TabIndex = 8
        Me.BtnInicio.Text = "      INICIO"
        Me.BtnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnInicio.UseVisualStyleBackColor = True
        '
        'LabelCorreo
        '
        Me.LabelCorreo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LabelCorreo.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelCorreo.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelCorreo.Location = New System.Drawing.Point(0, 349)
        Me.LabelCorreo.Name = "LabelCorreo"
        Me.LabelCorreo.Size = New System.Drawing.Size(136, 21)
        Me.LabelCorreo.TabIndex = 6
        Me.LabelCorreo.Text = "Correo"
        Me.LabelCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelNombreFacultad
        '
        Me.LabelNombreFacultad.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LabelNombreFacultad.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelNombreFacultad.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelNombreFacultad.Location = New System.Drawing.Point(0, 331)
        Me.LabelNombreFacultad.Name = "LabelNombreFacultad"
        Me.LabelNombreFacultad.Size = New System.Drawing.Size(136, 18)
        Me.LabelNombreFacultad.TabIndex = 7
        Me.LabelNombreFacultad.Text = "Facultad"
        Me.LabelNombreFacultad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelNombre
        '
        Me.LabelNombre.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LabelNombre.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelNombre.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelNombre.Location = New System.Drawing.Point(0, 313)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(136, 18)
        Me.LabelNombre.TabIndex = 5
        Me.LabelNombre.Text = "Nombre"
        Me.LabelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTipoUsuario
        '
        Me.LabelTipoUsuario.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LabelTipoUsuario.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelTipoUsuario.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.LabelTipoUsuario.Location = New System.Drawing.Point(0, 295)
        Me.LabelTipoUsuario.Name = "LabelTipoUsuario"
        Me.LabelTipoUsuario.Size = New System.Drawing.Size(136, 23)
        Me.LabelTipoUsuario.TabIndex = 4
        Me.LabelTipoUsuario.Text = "Tipo Usuario"
        Me.LabelTipoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PanelContenedor.Controls.Add(Me.LabelFecha)
        Me.PanelContenedor.Controls.Add(Me.LabelHora)
        Me.PanelContenedor.Controls.Add(Me.LabelBienvenido)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(136, 25)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(569, 387)
        Me.PanelContenedor.TabIndex = 5
        '
        'LabelFecha
        '
        Me.LabelFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelFecha.AutoSize = True
        Me.LabelFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.LabelFecha.Font = New System.Drawing.Font("MS PGothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFecha.ForeColor = System.Drawing.Color.White
        Me.LabelFecha.Location = New System.Drawing.Point(146, 179)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(258, 19)
        Me.LabelFecha.TabIndex = 2
        Me.LabelFecha.Text = "Lunes, 2 de Enero del 2022"
        '
        'LabelHora
        '
        Me.LabelHora.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelHora.AutoSize = True
        Me.LabelHora.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.LabelHora.Font = New System.Drawing.Font("MS PGothic", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHora.ForeColor = System.Drawing.Color.White
        Me.LabelHora.Location = New System.Drawing.Point(213, 130)
        Me.LabelHora.Name = "LabelHora"
        Me.LabelHora.Size = New System.Drawing.Size(123, 29)
        Me.LabelHora.TabIndex = 1
        Me.LabelHora.Text = "00:00:00"
        '
        'LabelBienvenido
        '
        Me.LabelBienvenido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelBienvenido.AutoSize = True
        Me.LabelBienvenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.LabelBienvenido.Font = New System.Drawing.Font("MS PGothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBienvenido.ForeColor = System.Drawing.Color.White
        Me.LabelBienvenido.Location = New System.Drawing.Point(463, 352)
        Me.LabelBienvenido.Name = "LabelBienvenido"
        Me.LabelBienvenido.Size = New System.Drawing.Size(94, 13)
        Me.LabelBienvenido.TabIndex = 0
        Me.LabelBienvenido.Text = "¡BIENVENIDO!"
        '
        'TimerHora
        '
        Me.TimerHora.Enabled = True
        '
        'Formulario_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 412)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelBarraMenu)
        Me.Controls.Add(Me.PanelBarraTitutlo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Formulario_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario_Principal"
        Me.PanelBarraTitutlo.ResumeLayout(False)
        Me.PanelBarraMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelContenedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBarraTitutlo As Panel
    Friend WithEvents ButtonLogoAdm As Button
    Friend WithEvents ButtonMinimizar As Button
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents PanelBarraMenu As Panel
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents LabelTipoUsuario As Label
    Friend WithEvents BtnAlumnos As Button
    Friend WithEvents BtnPromedio As Button
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents LabelNombreFacultad As Label
    Friend WithEvents LabelCorreo As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents BtnInicio As Button
    Friend WithEvents LabelBienvenido As Label
    Friend WithEvents BtnMaximizar As Button
    Friend WithEvents BtnRestaurar As Button
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents LabelFecha As Label
    Friend WithEvents LabelHora As Label
    Friend WithEvents TimerHora As Timer
    Friend WithEvents PromedioCondicional As Button
    Friend WithEvents BtnRegistroAlumno As Button
End Class
