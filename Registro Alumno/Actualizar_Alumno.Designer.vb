<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Actualizar_Alumno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Actualizar_Alumno))
        Me.PanelBarraTitutlo = New System.Windows.Forms.Panel()
        Me.ButtonLogoAdm = New System.Windows.Forms.Button()
        Me.ButtonMinimizar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.Cbo_Genero = New System.Windows.Forms.ComboBox()
        Me.LabelSemestre = New System.Windows.Forms.Label()
        Me.Cbo_Semestre = New System.Windows.Forms.ComboBox()
        Me.LabelFacultad = New System.Windows.Forms.Label()
        Me.Cbo_Facultad = New System.Windows.Forms.ComboBox()
        Me.LabelDireccion = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.LabelGenero = New System.Windows.Forms.Label()
        Me.LabelExpediente = New System.Windows.Forms.Label()
        Me.TxtExpediente = New System.Windows.Forms.TextBox()
        Me.LabelParcial1 = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.PanelBarraTitutlo.SuspendLayout()
        Me.PanelInferior.SuspendLayout()
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
        Me.PanelBarraTitutlo.Size = New System.Drawing.Size(658, 32)
        Me.PanelBarraTitutlo.TabIndex = 4
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
        Me.ButtonMinimizar.Location = New System.Drawing.Point(598, 0)
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
        Me.ButtonSalir.Location = New System.Drawing.Point(628, 0)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(30, 32)
        Me.ButtonSalir.TabIndex = 3
        Me.ButtonSalir.Text = "X"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'PanelInferior
        '
        Me.PanelInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelInferior.Controls.Add(Me.ButtonActualizar)
        Me.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInferior.Location = New System.Drawing.Point(0, 328)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(658, 50)
        Me.PanelInferior.TabIndex = 5
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonActualizar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.ButtonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonActualizar.ForeColor = System.Drawing.Color.White
        Me.ButtonActualizar.Location = New System.Drawing.Point(571, 14)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(75, 24)
        Me.ButtonActualizar.TabIndex = 0
        Me.ButtonActualizar.Text = "Actualizar"
        Me.ButtonActualizar.UseVisualStyleBackColor = True
        '
        'Cbo_Genero
        '
        Me.Cbo_Genero.FormattingEnabled = True
        Me.Cbo_Genero.Items.AddRange(New Object() {"Hombre", "Mujer", "Indefinido"})
        Me.Cbo_Genero.Location = New System.Drawing.Point(358, 137)
        Me.Cbo_Genero.Name = "Cbo_Genero"
        Me.Cbo_Genero.Size = New System.Drawing.Size(266, 21)
        Me.Cbo_Genero.TabIndex = 72
        '
        'LabelSemestre
        '
        Me.LabelSemestre.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelSemestre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelSemestre.Location = New System.Drawing.Point(356, 226)
        Me.LabelSemestre.Name = "LabelSemestre"
        Me.LabelSemestre.Size = New System.Drawing.Size(195, 18)
        Me.LabelSemestre.TabIndex = 71
        Me.LabelSemestre.Text = "Semestre"
        Me.LabelSemestre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cbo_Semestre
        '
        Me.Cbo_Semestre.FormattingEnabled = True
        Me.Cbo_Semestre.Items.AddRange(New Object() {"1-Semestre", "2-Semestre", "3-Semestre", "4-Semestre", "5-Semestre", "6-Semestre"})
        Me.Cbo_Semestre.Location = New System.Drawing.Point(358, 247)
        Me.Cbo_Semestre.Name = "Cbo_Semestre"
        Me.Cbo_Semestre.Size = New System.Drawing.Size(266, 21)
        Me.Cbo_Semestre.TabIndex = 70
        '
        'LabelFacultad
        '
        Me.LabelFacultad.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelFacultad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelFacultad.Location = New System.Drawing.Point(24, 226)
        Me.LabelFacultad.Name = "LabelFacultad"
        Me.LabelFacultad.Size = New System.Drawing.Size(195, 18)
        Me.LabelFacultad.TabIndex = 69
        Me.LabelFacultad.Text = "Facultad"
        Me.LabelFacultad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cbo_Facultad
        '
        Me.Cbo_Facultad.FormattingEnabled = True
        Me.Cbo_Facultad.Items.AddRange(New Object() {"Contaduria", "Informática", "Enfermeria", "Ciencias Naturales", "Psicología"})
        Me.Cbo_Facultad.Location = New System.Drawing.Point(26, 247)
        Me.Cbo_Facultad.Name = "Cbo_Facultad"
        Me.Cbo_Facultad.Size = New System.Drawing.Size(294, 21)
        Me.Cbo_Facultad.TabIndex = 68
        '
        'LabelDireccion
        '
        Me.LabelDireccion.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelDireccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelDireccion.Location = New System.Drawing.Point(356, 174)
        Me.LabelDireccion.Name = "LabelDireccion"
        Me.LabelDireccion.Size = New System.Drawing.Size(195, 18)
        Me.LabelDireccion.TabIndex = 67
        Me.LabelDireccion.Text = "Dirección"
        Me.LabelDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(358, 195)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(266, 20)
        Me.TxtDireccion.TabIndex = 66
        Me.TxtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelFecha
        '
        Me.LabelFecha.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelFecha.Location = New System.Drawing.Point(24, 174)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(195, 18)
        Me.LabelFecha.TabIndex = 65
        Me.LabelFecha.Text = "Fecha"
        Me.LabelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(26, 195)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(294, 20)
        Me.TxtFecha.TabIndex = 64
        Me.TxtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelGenero
        '
        Me.LabelGenero.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelGenero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelGenero.Location = New System.Drawing.Point(356, 117)
        Me.LabelGenero.Name = "LabelGenero"
        Me.LabelGenero.Size = New System.Drawing.Size(195, 18)
        Me.LabelGenero.TabIndex = 63
        Me.LabelGenero.Text = "Genero"
        Me.LabelGenero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelExpediente
        '
        Me.LabelExpediente.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelExpediente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelExpediente.Location = New System.Drawing.Point(24, 57)
        Me.LabelExpediente.Name = "LabelExpediente"
        Me.LabelExpediente.Size = New System.Drawing.Size(195, 18)
        Me.LabelExpediente.TabIndex = 62
        Me.LabelExpediente.Text = "Expediente"
        Me.LabelExpediente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtExpediente
        '
        Me.TxtExpediente.Location = New System.Drawing.Point(26, 78)
        Me.TxtExpediente.Name = "TxtExpediente"
        Me.TxtExpediente.ReadOnly = True
        Me.TxtExpediente.Size = New System.Drawing.Size(294, 20)
        Me.TxtExpediente.TabIndex = 61
        Me.TxtExpediente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelParcial1
        '
        Me.LabelParcial1.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelParcial1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelParcial1.Location = New System.Drawing.Point(24, 117)
        Me.LabelParcial1.Name = "LabelParcial1"
        Me.LabelParcial1.Size = New System.Drawing.Size(195, 18)
        Me.LabelParcial1.TabIndex = 60
        Me.LabelParcial1.Text = "Apellido"
        Me.LabelParcial1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelNombre
        '
        Me.LabelNombre.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelNombre.Location = New System.Drawing.Point(356, 57)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(195, 18)
        Me.LabelNombre.TabIndex = 59
        Me.LabelNombre.Text = "Nombre"
        Me.LabelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(26, 138)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(294, 20)
        Me.TxtApellido.TabIndex = 58
        Me.TxtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(358, 78)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(266, 20)
        Me.TxtNombre.TabIndex = 57
        Me.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Actualizar_Alumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 378)
        Me.Controls.Add(Me.Cbo_Genero)
        Me.Controls.Add(Me.LabelSemestre)
        Me.Controls.Add(Me.Cbo_Semestre)
        Me.Controls.Add(Me.LabelFacultad)
        Me.Controls.Add(Me.Cbo_Facultad)
        Me.Controls.Add(Me.LabelDireccion)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.LabelFecha)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.LabelGenero)
        Me.Controls.Add(Me.LabelExpediente)
        Me.Controls.Add(Me.TxtExpediente)
        Me.Controls.Add(Me.LabelParcial1)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.PanelInferior)
        Me.Controls.Add(Me.PanelBarraTitutlo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Actualizar_Alumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar_Alumno"
        Me.PanelBarraTitutlo.ResumeLayout(False)
        Me.PanelInferior.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelBarraTitutlo As Panel
    Friend WithEvents ButtonLogoAdm As Button
    Friend WithEvents ButtonMinimizar As Button
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents PanelInferior As Panel
    Friend WithEvents ButtonActualizar As Button
    Friend WithEvents Cbo_Genero As ComboBox
    Friend WithEvents LabelSemestre As Label
    Friend WithEvents Cbo_Semestre As ComboBox
    Friend WithEvents LabelFacultad As Label
    Friend WithEvents Cbo_Facultad As ComboBox
    Friend WithEvents LabelDireccion As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents LabelFecha As Label
    Friend WithEvents TxtFecha As TextBox
    Friend WithEvents LabelGenero As Label
    Friend WithEvents LabelExpediente As Label
    Friend WithEvents TxtExpediente As TextBox
    Friend WithEvents LabelParcial1 As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtNombre As TextBox
End Class
