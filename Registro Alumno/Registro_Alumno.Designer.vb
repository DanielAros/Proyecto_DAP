<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_Alumno
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
        Me.GridAlumnos = New System.Windows.Forms.DataGridView()
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.ButtonRegistrar = New System.Windows.Forms.Button()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.LabelGenero = New System.Windows.Forms.Label()
        Me.LabelExpediente = New System.Windows.Forms.Label()
        Me.TxtExpediente = New System.Windows.Forms.TextBox()
        Me.LabelParcial1 = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LabelDireccion = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Cbo_Facultad = New System.Windows.Forms.ComboBox()
        Me.LabelFacultad = New System.Windows.Forms.Label()
        Me.LabelSemestre = New System.Windows.Forms.Label()
        Me.Cbo_Semestre = New System.Windows.Forms.ComboBox()
        Me.Cbo_Genero = New System.Windows.Forms.ComboBox()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.ContextMenuStripAlumno = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        CType(Me.GridAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelInferior.SuspendLayout()
        Me.ContextMenuStripAlumno.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridAlumnos
        '
        Me.GridAlumnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridAlumnos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.GridAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridAlumnos.Location = New System.Drawing.Point(229, 276)
        Me.GridAlumnos.Name = "GridAlumnos"
        Me.GridAlumnos.ReadOnly = True
        Me.GridAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridAlumnos.Size = New System.Drawing.Size(408, 109)
        Me.GridAlumnos.TabIndex = 0
        '
        'PanelInferior
        '
        Me.PanelInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelInferior.Controls.Add(Me.ButtonRegistrar)
        Me.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInferior.Location = New System.Drawing.Point(0, 407)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(794, 50)
        Me.PanelInferior.TabIndex = 39
        '
        'ButtonRegistrar
        '
        Me.ButtonRegistrar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.ButtonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRegistrar.ForeColor = System.Drawing.Color.White
        Me.ButtonRegistrar.Location = New System.Drawing.Point(676, 14)
        Me.ButtonRegistrar.Name = "ButtonRegistrar"
        Me.ButtonRegistrar.Size = New System.Drawing.Size(94, 24)
        Me.ButtonRegistrar.TabIndex = 0
        Me.ButtonRegistrar.Text = "Registrar"
        Me.ButtonRegistrar.UseVisualStyleBackColor = True
        '
        'LabelFecha
        '
        Me.LabelFecha.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelFecha.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelFecha.Location = New System.Drawing.Point(29, 162)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(195, 18)
        Me.LabelFecha.TabIndex = 49
        Me.LabelFecha.Text = "Fecha"
        Me.LabelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtFecha
        '
        Me.TxtFecha.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtFecha.Location = New System.Drawing.Point(31, 183)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(294, 20)
        Me.TxtFecha.TabIndex = 48
        Me.TxtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelGenero
        '
        Me.LabelGenero.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelGenero.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelGenero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelGenero.Location = New System.Drawing.Point(361, 105)
        Me.LabelGenero.Name = "LabelGenero"
        Me.LabelGenero.Size = New System.Drawing.Size(195, 18)
        Me.LabelGenero.TabIndex = 47
        Me.LabelGenero.Text = "Genero"
        Me.LabelGenero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelExpediente
        '
        Me.LabelExpediente.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelExpediente.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelExpediente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelExpediente.Location = New System.Drawing.Point(29, 45)
        Me.LabelExpediente.Name = "LabelExpediente"
        Me.LabelExpediente.Size = New System.Drawing.Size(195, 18)
        Me.LabelExpediente.TabIndex = 45
        Me.LabelExpediente.Text = "Expediente"
        Me.LabelExpediente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtExpediente
        '
        Me.TxtExpediente.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtExpediente.Location = New System.Drawing.Point(31, 66)
        Me.TxtExpediente.Name = "TxtExpediente"
        Me.TxtExpediente.Size = New System.Drawing.Size(294, 20)
        Me.TxtExpediente.TabIndex = 44
        Me.TxtExpediente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelParcial1
        '
        Me.LabelParcial1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelParcial1.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelParcial1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelParcial1.Location = New System.Drawing.Point(29, 105)
        Me.LabelParcial1.Name = "LabelParcial1"
        Me.LabelParcial1.Size = New System.Drawing.Size(195, 18)
        Me.LabelParcial1.TabIndex = 43
        Me.LabelParcial1.Text = "Apellido"
        Me.LabelParcial1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelNombre
        '
        Me.LabelNombre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelNombre.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelNombre.Location = New System.Drawing.Point(361, 45)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(195, 18)
        Me.LabelNombre.TabIndex = 42
        Me.LabelNombre.Text = "Nombre"
        Me.LabelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtApellido
        '
        Me.TxtApellido.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtApellido.Location = New System.Drawing.Point(31, 126)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(294, 20)
        Me.TxtApellido.TabIndex = 41
        Me.TxtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNombre
        '
        Me.TxtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtNombre.Location = New System.Drawing.Point(363, 66)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(266, 20)
        Me.TxtNombre.TabIndex = 40
        Me.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelDireccion
        '
        Me.LabelDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelDireccion.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelDireccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelDireccion.Location = New System.Drawing.Point(361, 162)
        Me.LabelDireccion.Name = "LabelDireccion"
        Me.LabelDireccion.Size = New System.Drawing.Size(195, 18)
        Me.LabelDireccion.TabIndex = 51
        Me.LabelDireccion.Text = "Dirección"
        Me.LabelDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtDireccion.Location = New System.Drawing.Point(363, 183)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(266, 20)
        Me.TxtDireccion.TabIndex = 50
        Me.TxtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cbo_Facultad
        '
        Me.Cbo_Facultad.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Cbo_Facultad.FormattingEnabled = True
        Me.Cbo_Facultad.Items.AddRange(New Object() {"Contaduria", "Informática", "Enfermeria", "Ciencias Naturales", "Psicología"})
        Me.Cbo_Facultad.Location = New System.Drawing.Point(31, 235)
        Me.Cbo_Facultad.Name = "Cbo_Facultad"
        Me.Cbo_Facultad.Size = New System.Drawing.Size(294, 21)
        Me.Cbo_Facultad.TabIndex = 52
        '
        'LabelFacultad
        '
        Me.LabelFacultad.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelFacultad.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelFacultad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelFacultad.Location = New System.Drawing.Point(29, 214)
        Me.LabelFacultad.Name = "LabelFacultad"
        Me.LabelFacultad.Size = New System.Drawing.Size(195, 18)
        Me.LabelFacultad.TabIndex = 53
        Me.LabelFacultad.Text = "Facultad"
        Me.LabelFacultad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelSemestre
        '
        Me.LabelSemestre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelSemestre.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelSemestre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelSemestre.Location = New System.Drawing.Point(361, 214)
        Me.LabelSemestre.Name = "LabelSemestre"
        Me.LabelSemestre.Size = New System.Drawing.Size(195, 18)
        Me.LabelSemestre.TabIndex = 55
        Me.LabelSemestre.Text = "Semestre"
        Me.LabelSemestre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cbo_Semestre
        '
        Me.Cbo_Semestre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Cbo_Semestre.FormattingEnabled = True
        Me.Cbo_Semestre.Items.AddRange(New Object() {"1-Semestre", "2-Semestre", "3-Semestre", "4-Semestre", "5-Semestre", "6-Semestre"})
        Me.Cbo_Semestre.Location = New System.Drawing.Point(363, 235)
        Me.Cbo_Semestre.Name = "Cbo_Semestre"
        Me.Cbo_Semestre.Size = New System.Drawing.Size(266, 21)
        Me.Cbo_Semestre.TabIndex = 54
        '
        'Cbo_Genero
        '
        Me.Cbo_Genero.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Cbo_Genero.FormattingEnabled = True
        Me.Cbo_Genero.Items.AddRange(New Object() {"Hombre", "Mujer", "Indefinido"})
        Me.Cbo_Genero.Location = New System.Drawing.Point(363, 125)
        Me.Cbo_Genero.Name = "Cbo_Genero"
        Me.Cbo_Genero.Size = New System.Drawing.Size(266, 21)
        Me.Cbo_Genero.TabIndex = 56
        '
        'LabelTotal
        '
        Me.LabelTotal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTotal.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelTotal.Location = New System.Drawing.Point(659, 93)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(101, 18)
        Me.LabelTotal.TabIndex = 58
        Me.LabelTotal.Text = "Total"
        Me.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtTotal
        '
        Me.TxtTotal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtTotal.Location = New System.Drawing.Point(661, 114)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(99, 20)
        Me.TxtTotal.TabIndex = 57
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ContextMenuStripAlumno
        '
        Me.ContextMenuStripAlumno.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem, Me.EliminarToolStripMenuItem1, Me.ActualizarToolStripMenuItem})
        Me.ContextMenuStripAlumno.Name = "ContextMenuStripAlumno"
        Me.ContextMenuStripAlumno.Size = New System.Drawing.Size(173, 70)
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.EliminarToolStripMenuItem.Text = "Limpiar"
        '
        'EliminarToolStripMenuItem1
        '
        Me.EliminarToolStripMenuItem1.Name = "EliminarToolStripMenuItem1"
        Me.EliminarToolStripMenuItem1.Size = New System.Drawing.Size(172, 22)
        Me.EliminarToolStripMenuItem1.Text = "Eliminar"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar Registro"
        '
        'LabelTitulo
        '
        Me.LabelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.BackColor = System.Drawing.SystemColors.Control
        Me.LabelTitulo.Font = New System.Drawing.Font("MS PGothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.Color.Black
        Me.LabelTitulo.Location = New System.Drawing.Point(225, 9)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(235, 19)
        Me.LabelTitulo.TabIndex = 81
        Me.LabelTitulo.Text = "REGISTRO DE ALUMNOS"
        '
        'Registro_Alumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 457)
        Me.ContextMenuStrip = Me.ContextMenuStripAlumno
        Me.Controls.Add(Me.LabelTitulo)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.TxtTotal)
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
        Me.Controls.Add(Me.GridAlumnos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registro_Alumno"
        Me.Text = "Registro_Alumno"
        CType(Me.GridAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelInferior.ResumeLayout(False)
        Me.ContextMenuStripAlumno.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridAlumnos As DataGridView
    Friend WithEvents PanelInferior As Panel
    Friend WithEvents ButtonRegistrar As Button
    Friend WithEvents LabelFecha As Label
    Friend WithEvents TxtFecha As TextBox
    Friend WithEvents LabelGenero As Label
    Friend WithEvents LabelExpediente As Label
    Friend WithEvents TxtExpediente As TextBox
    Friend WithEvents LabelParcial1 As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LabelDireccion As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Cbo_Facultad As ComboBox
    Friend WithEvents LabelFacultad As Label
    Friend WithEvents LabelSemestre As Label
    Friend WithEvents Cbo_Semestre As ComboBox
    Friend WithEvents Cbo_Genero As ComboBox
    Friend WithEvents LabelTotal As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents ContextMenuStripAlumno As ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabelTitulo As Label
End Class
