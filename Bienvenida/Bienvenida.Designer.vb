<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bienvenida
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bienvenida))
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.PanelBarraTitutlo = New System.Windows.Forms.Panel()
        Me.ButtonLogoAdm = New System.Windows.Forms.Button()
        Me.ButtonMinimizar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.ProgressBarCargando = New System.Windows.Forms.ProgressBar()
        Me.LabelCargando = New System.Windows.Forms.Label()
        Me.TimerAbrir = New System.Windows.Forms.Timer(Me.components)
        Me.TimerCerrar = New System.Windows.Forms.Timer(Me.components)
        Me.LabelCorreo = New System.Windows.Forms.Label()
        Me.LabelApellido = New System.Windows.Forms.Label()
        Me.LabelFacultad = New System.Windows.Forms.Label()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBarraTitutlo.SuspendLayout()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.BackgroundImage = CType(resources.GetObject("PBLogo.BackgroundImage"), System.Drawing.Image)
        Me.PBLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBLogo.Location = New System.Drawing.Point(26, 88)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(169, 174)
        Me.PBLogo.TabIndex = 8
        Me.PBLogo.TabStop = False
        '
        'LabelTitulo
        '
        Me.LabelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Font = New System.Drawing.Font("Niagara Engraved", 45.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.Color.White
        Me.LabelTitulo.Location = New System.Drawing.Point(319, 45)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(200, 64)
        Me.LabelTitulo.TabIndex = 7
        Me.LabelTitulo.Text = "¡Bienvenido!"
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
        Me.PanelBarraTitutlo.Size = New System.Drawing.Size(657, 32)
        Me.PanelBarraTitutlo.TabIndex = 9
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
        Me.ButtonMinimizar.Location = New System.Drawing.Point(597, 0)
        Me.ButtonMinimizar.Name = "ButtonMinimizar"
        Me.ButtonMinimizar.Size = New System.Drawing.Size(30, 32)
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
        Me.ButtonSalir.Location = New System.Drawing.Point(627, 0)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(30, 32)
        Me.ButtonSalir.TabIndex = 3
        Me.ButtonSalir.Text = "X"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'LabelNombre
        '
        Me.LabelNombre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Niagara Engraved", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.ForeColor = System.Drawing.Color.White
        Me.LabelNombre.Location = New System.Drawing.Point(244, 113)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(63, 29)
        Me.LabelNombre.TabIndex = 10
        Me.LabelNombre.Text = "Nombre"
        '
        'ProgressBarCargando
        '
        Me.ProgressBarCargando.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ProgressBarCargando.Location = New System.Drawing.Point(242, 267)
        Me.ProgressBarCargando.Name = "ProgressBarCargando"
        Me.ProgressBarCargando.Size = New System.Drawing.Size(365, 26)
        Me.ProgressBarCargando.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBarCargando.TabIndex = 11
        Me.ProgressBarCargando.Value = 50
        '
        'LabelCargando
        '
        Me.LabelCargando.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelCargando.AutoSize = True
        Me.LabelCargando.Font = New System.Drawing.Font("Niagara Engraved", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCargando.ForeColor = System.Drawing.Color.White
        Me.LabelCargando.Location = New System.Drawing.Point(576, 239)
        Me.LabelCargando.Name = "LabelCargando"
        Me.LabelCargando.Size = New System.Drawing.Size(31, 23)
        Me.LabelCargando.TabIndex = 12
        Me.LabelCargando.Text = "10%"
        '
        'TimerAbrir
        '
        Me.TimerAbrir.Interval = 16
        '
        'TimerCerrar
        '
        Me.TimerCerrar.Interval = 15
        '
        'LabelCorreo
        '
        Me.LabelCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelCorreo.AutoSize = True
        Me.LabelCorreo.Font = New System.Drawing.Font("Niagara Engraved", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCorreo.ForeColor = System.Drawing.Color.White
        Me.LabelCorreo.Location = New System.Drawing.Point(244, 151)
        Me.LabelCorreo.Name = "LabelCorreo"
        Me.LabelCorreo.Size = New System.Drawing.Size(59, 29)
        Me.LabelCorreo.TabIndex = 13
        Me.LabelCorreo.Text = "Correo"
        '
        'LabelApellido
        '
        Me.LabelApellido.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelApellido.AutoSize = True
        Me.LabelApellido.Font = New System.Drawing.Font("Niagara Engraved", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelApellido.ForeColor = System.Drawing.Color.White
        Me.LabelApellido.Location = New System.Drawing.Point(244, 190)
        Me.LabelApellido.Name = "LabelApellido"
        Me.LabelApellido.Size = New System.Drawing.Size(65, 29)
        Me.LabelApellido.TabIndex = 14
        Me.LabelApellido.Text = "Apellido"
        '
        'LabelFacultad
        '
        Me.LabelFacultad.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelFacultad.AutoSize = True
        Me.LabelFacultad.Font = New System.Drawing.Font("Niagara Engraved", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFacultad.ForeColor = System.Drawing.Color.White
        Me.LabelFacultad.Location = New System.Drawing.Point(244, 231)
        Me.LabelFacultad.Name = "LabelFacultad"
        Me.LabelFacultad.Size = New System.Drawing.Size(70, 29)
        Me.LabelFacultad.TabIndex = 15
        Me.LabelFacultad.Text = "Facultad"
        '
        'Bienvenida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(657, 311)
        Me.Controls.Add(Me.LabelFacultad)
        Me.Controls.Add(Me.LabelApellido)
        Me.Controls.Add(Me.LabelCorreo)
        Me.Controls.Add(Me.LabelCargando)
        Me.Controls.Add(Me.ProgressBarCargando)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.PanelBarraTitutlo)
        Me.Controls.Add(Me.PBLogo)
        Me.Controls.Add(Me.LabelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Bienvenida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenida"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBarraTitutlo.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents PanelBarraTitutlo As Panel
    Friend WithEvents ButtonLogoAdm As Button
    Friend WithEvents ButtonMinimizar As Button
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents LabelNombre As Label
    Friend WithEvents ProgressBarCargando As ProgressBar
    Friend WithEvents LabelCargando As Label
    Friend WithEvents TimerAbrir As Timer
    Friend WithEvents TimerCerrar As Timer
    Friend WithEvents LabelCorreo As Label
    Friend WithEvents LabelApellido As Label
    Friend WithEvents LabelFacultad As Label
End Class
