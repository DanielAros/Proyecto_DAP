<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alumnos
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
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelApellido = New System.Windows.Forms.Label()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.ButtonRegistrar = New System.Windows.Forms.Button()
        Me.GridAlumnos = New System.Windows.Forms.DataGridView()
        Me.Expediente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelGenero = New System.Windows.Forms.Label()
        Me.LabelExpediente = New System.Windows.Forms.Label()
        Me.TxtExpediente = New System.Windows.Forms.TextBox()
        Me.CB_Genero = New System.Windows.Forms.ComboBox()
        Me.ContextMenuStripLimpiar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelInferior.SuspendLayout()
        CType(Me.GridAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripLimpiar.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(50, 121)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(294, 20)
        Me.TxtNombre.TabIndex = 0
        Me.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(50, 169)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(294, 20)
        Me.TxtApellido.TabIndex = 1
        Me.TxtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelNombre
        '
        Me.LabelNombre.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelNombre.Location = New System.Drawing.Point(48, 100)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(195, 18)
        Me.LabelNombre.TabIndex = 6
        Me.LabelNombre.Text = "Nombre"
        Me.LabelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelApellido
        '
        Me.LabelApellido.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelApellido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelApellido.Location = New System.Drawing.Point(48, 148)
        Me.LabelApellido.Name = "LabelApellido"
        Me.LabelApellido.Size = New System.Drawing.Size(195, 18)
        Me.LabelApellido.TabIndex = 7
        Me.LabelApellido.Text = "Apellido"
        Me.LabelApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelTitulo
        '
        Me.LabelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.BackColor = System.Drawing.SystemColors.Control
        Me.LabelTitulo.Font = New System.Drawing.Font("MS PGothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.Color.Black
        Me.LabelTitulo.Location = New System.Drawing.Point(274, 19)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(235, 19)
        Me.LabelTitulo.TabIndex = 8
        Me.LabelTitulo.Text = "REGISTRO DE ALUMNOS"
        '
        'PanelInferior
        '
        Me.PanelInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelInferior.Controls.Add(Me.ButtonRegistrar)
        Me.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInferior.Location = New System.Drawing.Point(0, 446)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(800, 50)
        Me.PanelInferior.TabIndex = 9
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
        Me.ButtonRegistrar.Location = New System.Drawing.Point(682, 14)
        Me.ButtonRegistrar.Name = "ButtonRegistrar"
        Me.ButtonRegistrar.Size = New System.Drawing.Size(94, 24)
        Me.ButtonRegistrar.TabIndex = 0
        Me.ButtonRegistrar.Text = "Registrar"
        Me.ButtonRegistrar.UseVisualStyleBackColor = True
        '
        'GridAlumnos
        '
        Me.GridAlumnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridAlumnos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.GridAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Expediente, Me.Nombre, Me.Apellido, Me.Genero})
        Me.GridAlumnos.Location = New System.Drawing.Point(50, 261)
        Me.GridAlumnos.Name = "GridAlumnos"
        Me.GridAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridAlumnos.Size = New System.Drawing.Size(696, 165)
        Me.GridAlumnos.TabIndex = 10
        '
        'Expediente
        '
        Me.Expediente.HeaderText = "Expediente"
        Me.Expediente.Name = "Expediente"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        '
        'Genero
        '
        Me.Genero.HeaderText = "Genero"
        Me.Genero.Name = "Genero"
        '
        'LabelGenero
        '
        Me.LabelGenero.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelGenero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelGenero.Location = New System.Drawing.Point(48, 196)
        Me.LabelGenero.Name = "LabelGenero"
        Me.LabelGenero.Size = New System.Drawing.Size(195, 18)
        Me.LabelGenero.TabIndex = 11
        Me.LabelGenero.Text = "Genero"
        Me.LabelGenero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelExpediente
        '
        Me.LabelExpediente.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelExpediente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelExpediente.Location = New System.Drawing.Point(48, 54)
        Me.LabelExpediente.Name = "LabelExpediente"
        Me.LabelExpediente.Size = New System.Drawing.Size(195, 18)
        Me.LabelExpediente.TabIndex = 13
        Me.LabelExpediente.Text = "Expediente"
        Me.LabelExpediente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtExpediente
        '
        Me.TxtExpediente.Location = New System.Drawing.Point(50, 75)
        Me.TxtExpediente.Name = "TxtExpediente"
        Me.TxtExpediente.Size = New System.Drawing.Size(294, 20)
        Me.TxtExpediente.TabIndex = 12
        Me.TxtExpediente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CB_Genero
        '
        Me.CB_Genero.FormattingEnabled = True
        Me.CB_Genero.Items.AddRange(New Object() {"Hombre", "Mujer", "Indefinido"})
        Me.CB_Genero.Location = New System.Drawing.Point(50, 217)
        Me.CB_Genero.Name = "CB_Genero"
        Me.CB_Genero.Size = New System.Drawing.Size(294, 21)
        Me.CB_Genero.TabIndex = 14
        '
        'ContextMenuStripLimpiar
        '
        Me.ContextMenuStripLimpiar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarToolStripMenuItem})
        Me.ContextMenuStripLimpiar.Name = "ContextMenuStripLimpiar"
        Me.ContextMenuStripLimpiar.Size = New System.Drawing.Size(115, 26)
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'Alumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 496)
        Me.ContextMenuStrip = Me.ContextMenuStripLimpiar
        Me.Controls.Add(Me.CB_Genero)
        Me.Controls.Add(Me.LabelExpediente)
        Me.Controls.Add(Me.TxtExpediente)
        Me.Controls.Add(Me.LabelGenero)
        Me.Controls.Add(Me.GridAlumnos)
        Me.Controls.Add(Me.PanelInferior)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Controls.Add(Me.LabelApellido)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Alumnos"
        Me.Text = "Alumnos"
        Me.PanelInferior.ResumeLayout(False)
        CType(Me.GridAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripLimpiar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents LabelNombre As Label
    Friend WithEvents LabelApellido As Label
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents PanelInferior As Panel
    Friend WithEvents ButtonRegistrar As Button
    Friend WithEvents GridAlumnos As DataGridView
    Friend WithEvents LabelGenero As Label
    Friend WithEvents Expediente As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Genero As DataGridViewTextBoxColumn
    Friend WithEvents LabelExpediente As Label
    Friend WithEvents TxtExpediente As TextBox
    Friend WithEvents CB_Genero As ComboBox
    Friend WithEvents ContextMenuStripLimpiar As ContextMenuStrip
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
End Class
