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
        Me.ButtonLogoAdm = New System.Windows.Forms.Button()
        Me.ButtonMinimizar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.PanelBarraMenu = New System.Windows.Forms.Panel()
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.BtnAddMeterias = New System.Windows.Forms.Button()
        Me.BtnDocentes = New System.Windows.Forms.Button()
        Me.LabelTipoUsuario = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelCorreo = New System.Windows.Forms.Label()
        Me.LabelNombreFacultad = New System.Windows.Forms.Label()
        Me.BtnInicio = New System.Windows.Forms.Button()
        Me.LabelBienvenido = New System.Windows.Forms.Label()
        Me.ImageListIconos = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelBarraTitutlo.SuspendLayout()
        Me.PanelBarraMenu.SuspendLayout()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBarraTitutlo
        '
        Me.PanelBarraTitutlo.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.PanelBarraTitutlo.Controls.Add(Me.ButtonLogoAdm)
        Me.PanelBarraTitutlo.Controls.Add(Me.ButtonMinimizar)
        Me.PanelBarraTitutlo.Controls.Add(Me.ButtonSalir)
        Me.PanelBarraTitutlo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitutlo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitutlo.Name = "PanelBarraTitutlo"
        Me.PanelBarraTitutlo.Size = New System.Drawing.Size(705, 25)
        Me.PanelBarraTitutlo.TabIndex = 3
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
        Me.ButtonMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonMinimizar.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonMinimizar.FlatAppearance.BorderSize = 0
        Me.ButtonMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.ButtonMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMinimizar.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.ButtonMinimizar.Location = New System.Drawing.Point(645, 0)
        Me.ButtonMinimizar.Name = "ButtonMinimizar"
        Me.ButtonMinimizar.Size = New System.Drawing.Size(30, 25)
        Me.ButtonMinimizar.TabIndex = 4
        Me.ButtonMinimizar.Text = "___"
        Me.ButtonMinimizar.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSalir.Dock = System.Windows.Forms.DockStyle.Right
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
        Me.PanelBarraMenu.Controls.Add(Me.BtnInicio)
        Me.PanelBarraMenu.Controls.Add(Me.LabelCorreo)
        Me.PanelBarraMenu.Controls.Add(Me.LabelNombreFacultad)
        Me.PanelBarraMenu.Controls.Add(Me.LabelNombre)
        Me.PanelBarraMenu.Controls.Add(Me.LabelTipoUsuario)
        Me.PanelBarraMenu.Controls.Add(Me.BtnDocentes)
        Me.PanelBarraMenu.Controls.Add(Me.BtnAddMeterias)
        Me.PanelBarraMenu.Controls.Add(Me.PBLogo)
        Me.PanelBarraMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelBarraMenu.Location = New System.Drawing.Point(0, 25)
        Me.PanelBarraMenu.Name = "PanelBarraMenu"
        Me.PanelBarraMenu.Size = New System.Drawing.Size(136, 383)
        Me.PanelBarraMenu.TabIndex = 4
        '
        'PBLogo
        '
        Me.PBLogo.BackgroundImage = CType(resources.GetObject("PBLogo.BackgroundImage"), System.Drawing.Image)
        Me.PBLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBLogo.Location = New System.Drawing.Point(32, 13)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(78, 74)
        Me.PBLogo.TabIndex = 0
        Me.PBLogo.TabStop = False
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PanelContenedor.Controls.Add(Me.LabelBienvenido)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(136, 25)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(569, 383)
        Me.PanelContenedor.TabIndex = 5
        '
        'BtnAddMeterias
        '
        Me.BtnAddMeterias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddMeterias.FlatAppearance.BorderSize = 0
        Me.BtnAddMeterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddMeterias.Font = New System.Drawing.Font("MS PGothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddMeterias.ForeColor = System.Drawing.Color.White
        Me.BtnAddMeterias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddMeterias.ImageIndex = 1
        Me.BtnAddMeterias.ImageList = Me.ImageListIconos
        Me.BtnAddMeterias.Location = New System.Drawing.Point(0, 177)
        Me.BtnAddMeterias.Margin = New System.Windows.Forms.Padding(1)
        Me.BtnAddMeterias.Name = "BtnAddMeterias"
        Me.BtnAddMeterias.Size = New System.Drawing.Size(136, 30)
        Me.BtnAddMeterias.TabIndex = 2
        Me.BtnAddMeterias.Text = "ADD MATERIAS"
        Me.BtnAddMeterias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddMeterias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAddMeterias.UseVisualStyleBackColor = True
        '
        'BtnDocentes
        '
        Me.BtnDocentes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDocentes.FlatAppearance.BorderSize = 0
        Me.BtnDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDocentes.Font = New System.Drawing.Font("MS PGothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDocentes.ForeColor = System.Drawing.Color.White
        Me.BtnDocentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDocentes.ImageIndex = 2
        Me.BtnDocentes.ImageList = Me.ImageListIconos
        Me.BtnDocentes.Location = New System.Drawing.Point(0, 145)
        Me.BtnDocentes.Margin = New System.Windows.Forms.Padding(1)
        Me.BtnDocentes.Name = "BtnDocentes"
        Me.BtnDocentes.Size = New System.Drawing.Size(136, 30)
        Me.BtnDocentes.TabIndex = 3
        Me.BtnDocentes.Text = "DOCENTES"
        Me.BtnDocentes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDocentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDocentes.UseVisualStyleBackColor = True
        '
        'LabelTipoUsuario
        '
        Me.LabelTipoUsuario.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelTipoUsuario.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.LabelTipoUsuario.Location = New System.Drawing.Point(0, 291)
        Me.LabelTipoUsuario.Name = "LabelTipoUsuario"
        Me.LabelTipoUsuario.Size = New System.Drawing.Size(136, 23)
        Me.LabelTipoUsuario.TabIndex = 4
        Me.LabelTipoUsuario.Text = "Tipo Usuario"
        Me.LabelTipoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelNombre
        '
        Me.LabelNombre.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelNombre.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelNombre.Location = New System.Drawing.Point(0, 309)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(136, 18)
        Me.LabelNombre.TabIndex = 5
        Me.LabelNombre.Text = "Nombre"
        Me.LabelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelCorreo
        '
        Me.LabelCorreo.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelCorreo.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelCorreo.Location = New System.Drawing.Point(0, 345)
        Me.LabelCorreo.Name = "LabelCorreo"
        Me.LabelCorreo.Size = New System.Drawing.Size(136, 21)
        Me.LabelCorreo.TabIndex = 6
        Me.LabelCorreo.Text = "Correo"
        Me.LabelCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelNombreFacultad
        '
        Me.LabelNombreFacultad.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelNombreFacultad.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelNombreFacultad.Location = New System.Drawing.Point(0, 327)
        Me.LabelNombreFacultad.Name = "LabelNombreFacultad"
        Me.LabelNombreFacultad.Size = New System.Drawing.Size(136, 18)
        Me.LabelNombreFacultad.TabIndex = 7
        Me.LabelNombreFacultad.Text = "Facultad"
        Me.LabelNombreFacultad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnInicio
        '
        Me.BtnInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInicio.Font = New System.Drawing.Font("MS PGothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInicio.ForeColor = System.Drawing.Color.White
        Me.BtnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInicio.ImageIndex = 0
        Me.BtnInicio.ImageList = Me.ImageListIconos
        Me.BtnInicio.Location = New System.Drawing.Point(0, 113)
        Me.BtnInicio.Margin = New System.Windows.Forms.Padding(1)
        Me.BtnInicio.Name = "BtnInicio"
        Me.BtnInicio.Size = New System.Drawing.Size(136, 30)
        Me.BtnInicio.TabIndex = 8
        Me.BtnInicio.Text = "INICIO"
        Me.BtnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnInicio.UseVisualStyleBackColor = True
        '
        'LabelBienvenido
        '
        Me.LabelBienvenido.AutoSize = True
        Me.LabelBienvenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.LabelBienvenido.Font = New System.Drawing.Font("MS PGothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBienvenido.ForeColor = System.Drawing.Color.White
        Me.LabelBienvenido.Location = New System.Drawing.Point(463, 348)
        Me.LabelBienvenido.Name = "LabelBienvenido"
        Me.LabelBienvenido.Size = New System.Drawing.Size(94, 13)
        Me.LabelBienvenido.TabIndex = 0
        Me.LabelBienvenido.Text = "¡BIENVENIDO!"
        '
        'ImageListIconos
        '
        Me.ImageListIconos.ImageStream = CType(resources.GetObject("ImageListIconos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListIconos.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListIconos.Images.SetKeyName(0, "menu.png")
        Me.ImageListIconos.Images.SetKeyName(1, "materias.png")
        Me.ImageListIconos.Images.SetKeyName(2, "personaDocente.png")
        '
        'Formulario_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 408)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelBarraMenu)
        Me.Controls.Add(Me.PanelBarraTitutlo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Formulario_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario_Principal"
        Me.PanelBarraTitutlo.ResumeLayout(False)
        Me.PanelBarraMenu.ResumeLayout(False)
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
    Friend WithEvents BtnDocentes As Button
    Friend WithEvents BtnAddMeterias As Button
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents LabelNombreFacultad As Label
    Friend WithEvents LabelCorreo As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents BtnInicio As Button
    Friend WithEvents LabelBienvenido As Label
    Friend WithEvents ImageListIconos As ImageList
End Class
