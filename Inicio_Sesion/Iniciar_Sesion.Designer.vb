<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Iniciar_Sesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Iniciar_Sesion))
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.LabelFacultad = New System.Windows.Forms.Label()
        Me.PanelBarraTitutlo = New System.Windows.Forms.Panel()
        Me.ButtonLogoAdm = New System.Windows.Forms.Button()
        Me.ButtonMinimizar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.ButtonRegresar = New System.Windows.Forms.Button()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.CB_Usuarios = New System.Windows.Forms.ComboBox()
        Me.LabelUsuarios = New System.Windows.Forms.Label()
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.LinkLabelPassword = New System.Windows.Forms.LinkLabel()
        Me.ButtonMostrarPassword = New System.Windows.Forms.Button()
        Me.ButtonOcultarPassword = New System.Windows.Forms.Button()
        Me.PanelBarraTitutlo.SuspendLayout()
        Me.PanelInferior.SuspendLayout()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTitulo
        '
        Me.LabelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Font = New System.Drawing.Font("Niagara Engraved", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.Color.White
        Me.LabelTitulo.Location = New System.Drawing.Point(69, 131)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(120, 34)
        Me.LabelTitulo.TabIndex = 0
        Me.LabelTitulo.Text = "Iniciar Sesión"
        '
        'LabelFacultad
        '
        Me.LabelFacultad.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LabelFacultad.AutoSize = True
        Me.LabelFacultad.Font = New System.Drawing.Font("Niagara Engraved", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFacultad.ForeColor = System.Drawing.Color.White
        Me.LabelFacultad.Location = New System.Drawing.Point(52, 323)
        Me.LabelFacultad.Name = "LabelFacultad"
        Me.LabelFacultad.Size = New System.Drawing.Size(153, 26)
        Me.LabelFacultad.TabIndex = 1
        Me.LabelFacultad.Text = "Facultad de Informática"
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
        Me.PanelBarraTitutlo.Size = New System.Drawing.Size(257, 32)
        Me.PanelBarraTitutlo.TabIndex = 2
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
        Me.ButtonMinimizar.Location = New System.Drawing.Point(197, 0)
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
        Me.ButtonSalir.Location = New System.Drawing.Point(227, 0)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(30, 32)
        Me.ButtonSalir.TabIndex = 3
        Me.ButtonSalir.Text = "X"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'PanelInferior
        '
        Me.PanelInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelInferior.Controls.Add(Me.ButtonRegresar)
        Me.PanelInferior.Controls.Add(Me.ButtonAceptar)
        Me.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInferior.Location = New System.Drawing.Point(0, 360)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(257, 50)
        Me.PanelInferior.TabIndex = 3
        '
        'ButtonRegresar
        '
        Me.ButtonRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRegresar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.ButtonRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRegresar.ForeColor = System.Drawing.Color.White
        Me.ButtonRegresar.Location = New System.Drawing.Point(170, 15)
        Me.ButtonRegresar.Name = "ButtonRegresar"
        Me.ButtonRegresar.Size = New System.Drawing.Size(75, 24)
        Me.ButtonRegresar.TabIndex = 1
        Me.ButtonRegresar.Text = "Regresar"
        Me.ButtonRegresar.UseVisualStyleBackColor = True
        Me.ButtonRegresar.Visible = False
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.ButtonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAceptar.ForeColor = System.Drawing.Color.White
        Me.ButtonAceptar.Location = New System.Drawing.Point(170, 15)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(75, 24)
        Me.ButtonAceptar.TabIndex = 0
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'CB_Usuarios
        '
        Me.CB_Usuarios.FormattingEnabled = True
        Me.CB_Usuarios.Items.AddRange(New Object() {"Daniel Aros", "Elias Ramirez", "Maria Perez"})
        Me.CB_Usuarios.Location = New System.Drawing.Point(28, 195)
        Me.CB_Usuarios.Name = "CB_Usuarios"
        Me.CB_Usuarios.Size = New System.Drawing.Size(208, 21)
        Me.CB_Usuarios.TabIndex = 4
        '
        'LabelUsuarios
        '
        Me.LabelUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelUsuarios.AutoSize = True
        Me.LabelUsuarios.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsuarios.ForeColor = System.Drawing.Color.White
        Me.LabelUsuarios.Location = New System.Drawing.Point(25, 176)
        Me.LabelUsuarios.Name = "LabelUsuarios"
        Me.LabelUsuarios.Size = New System.Drawing.Size(64, 16)
        Me.LabelUsuarios.TabIndex = 5
        Me.LabelUsuarios.Text = "Usuarios"
        '
        'PBLogo
        '
        Me.PBLogo.BackgroundImage = CType(resources.GetObject("PBLogo.BackgroundImage"), System.Drawing.Image)
        Me.PBLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBLogo.Location = New System.Drawing.Point(85, 38)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(85, 81)
        Me.PBLogo.TabIndex = 6
        Me.PBLogo.TabStop = False
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(28, 252)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(208, 20)
        Me.TxtPassword.TabIndex = 7
        Me.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelPassword
        '
        Me.LabelPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPassword.ForeColor = System.Drawing.Color.White
        Me.LabelPassword.Location = New System.Drawing.Point(25, 233)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(79, 16)
        Me.LabelPassword.TabIndex = 8
        Me.LabelPassword.Text = "Contraseña"
        '
        'LinkLabelPassword
        '
        Me.LinkLabelPassword.AutoSize = True
        Me.LinkLabelPassword.LinkColor = System.Drawing.Color.White
        Me.LinkLabelPassword.Location = New System.Drawing.Point(54, 292)
        Me.LinkLabelPassword.Name = "LinkLabelPassword"
        Me.LinkLabelPassword.Size = New System.Drawing.Size(136, 13)
        Me.LinkLabelPassword.TabIndex = 9
        Me.LinkLabelPassword.TabStop = True
        Me.LinkLabelPassword.Text = "¿Olvidaste tu constraseña?"
        '
        'ButtonMostrarPassword
        '
        Me.ButtonMostrarPassword.BackColor = System.Drawing.SystemColors.Window
        Me.ButtonMostrarPassword.BackgroundImage = CType(resources.GetObject("ButtonMostrarPassword.BackgroundImage"), System.Drawing.Image)
        Me.ButtonMostrarPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonMostrarPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonMostrarPassword.FlatAppearance.BorderSize = 0
        Me.ButtonMostrarPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMostrarPassword.Location = New System.Drawing.Point(217, 253)
        Me.ButtonMostrarPassword.Name = "ButtonMostrarPassword"
        Me.ButtonMostrarPassword.Size = New System.Drawing.Size(17, 17)
        Me.ButtonMostrarPassword.TabIndex = 10
        Me.ButtonMostrarPassword.UseVisualStyleBackColor = False
        '
        'ButtonOcultarPassword
        '
        Me.ButtonOcultarPassword.BackColor = System.Drawing.SystemColors.Window
        Me.ButtonOcultarPassword.BackgroundImage = CType(resources.GetObject("ButtonOcultarPassword.BackgroundImage"), System.Drawing.Image)
        Me.ButtonOcultarPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonOcultarPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonOcultarPassword.FlatAppearance.BorderSize = 0
        Me.ButtonOcultarPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOcultarPassword.Location = New System.Drawing.Point(217, 253)
        Me.ButtonOcultarPassword.Name = "ButtonOcultarPassword"
        Me.ButtonOcultarPassword.Size = New System.Drawing.Size(17, 17)
        Me.ButtonOcultarPassword.TabIndex = 11
        Me.ButtonOcultarPassword.UseVisualStyleBackColor = False
        Me.ButtonOcultarPassword.Visible = False
        '
        'Iniciar_Sesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(257, 410)
        Me.Controls.Add(Me.ButtonOcultarPassword)
        Me.Controls.Add(Me.ButtonMostrarPassword)
        Me.Controls.Add(Me.LinkLabelPassword)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.PBLogo)
        Me.Controls.Add(Me.LabelUsuarios)
        Me.Controls.Add(Me.CB_Usuarios)
        Me.Controls.Add(Me.PanelInferior)
        Me.Controls.Add(Me.PanelBarraTitutlo)
        Me.Controls.Add(Me.LabelFacultad)
        Me.Controls.Add(Me.LabelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Iniciar_Sesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar_Sesion"
        Me.PanelBarraTitutlo.ResumeLayout(False)
        Me.PanelInferior.ResumeLayout(False)
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitulo As Label
    Friend WithEvents LabelFacultad As Label
    Friend WithEvents PanelBarraTitutlo As Panel
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents ButtonMinimizar As Button
    Friend WithEvents PanelInferior As Panel
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents ButtonRegresar As Button
    Friend WithEvents CB_Usuarios As ComboBox
    Friend WithEvents LabelUsuarios As Label
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents LabelPassword As Label
    Friend WithEvents ButtonLogoAdm As Button
    Friend WithEvents LinkLabelPassword As LinkLabel
    Friend WithEvents ButtonMostrarPassword As Button
    Friend WithEvents ButtonOcultarPassword As Button
End Class
