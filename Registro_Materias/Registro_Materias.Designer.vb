<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_Materias
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
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonRegistrar = New System.Windows.Forms.Button()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.LabelSemestre = New System.Windows.Forms.Label()
        Me.Cbo_Semestre = New System.Windows.Forms.ComboBox()
        Me.LabelDireccion = New System.Windows.Forms.Label()
        Me.LabelMaestro = New System.Windows.Forms.Label()
        Me.TxtMaestro = New System.Windows.Forms.TextBox()
        Me.LabelMateria = New System.Windows.Forms.Label()
        Me.TxtMateria = New System.Windows.Forms.TextBox()
        Me.LabelDescripcion = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.LabelCorreo = New System.Windows.Forms.Label()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.GridMaterias = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStripEliminar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarRegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarRegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelInferior.SuspendLayout()
        CType(Me.GridMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripEliminar.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelInferior
        '
        Me.PanelInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelInferior.Controls.Add(Me.ButtonEliminar)
        Me.PanelInferior.Controls.Add(Me.ButtonRegistrar)
        Me.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInferior.Location = New System.Drawing.Point(0, 407)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(794, 50)
        Me.PanelInferior.TabIndex = 40
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.ButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEliminar.ForeColor = System.Drawing.Color.White
        Me.ButtonEliminar.Location = New System.Drawing.Point(564, 14)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(94, 24)
        Me.ButtonEliminar.TabIndex = 2
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
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
        'LabelTotal
        '
        Me.LabelTotal.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelTotal.Location = New System.Drawing.Point(661, 71)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(101, 18)
        Me.LabelTotal.TabIndex = 76
        Me.LabelTotal.Text = "Total"
        Me.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(663, 92)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(99, 20)
        Me.TxtTotal.TabIndex = 75
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelSemestre
        '
        Me.LabelSemestre.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelSemestre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelSemestre.Location = New System.Drawing.Point(363, 22)
        Me.LabelSemestre.Name = "LabelSemestre"
        Me.LabelSemestre.Size = New System.Drawing.Size(195, 18)
        Me.LabelSemestre.TabIndex = 73
        Me.LabelSemestre.Text = "Semestre"
        Me.LabelSemestre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cbo_Semestre
        '
        Me.Cbo_Semestre.FormattingEnabled = True
        Me.Cbo_Semestre.Items.AddRange(New Object() {"1-Semestre", "2-Semestre", "3-Semestre", "4-Semestre", "5-Semestre", "6-Semestre"})
        Me.Cbo_Semestre.Location = New System.Drawing.Point(365, 44)
        Me.Cbo_Semestre.Name = "Cbo_Semestre"
        Me.Cbo_Semestre.Size = New System.Drawing.Size(266, 21)
        Me.Cbo_Semestre.TabIndex = 72
        '
        'LabelDireccion
        '
        Me.LabelDireccion.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelDireccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelDireccion.Location = New System.Drawing.Point(363, 22)
        Me.LabelDireccion.Name = "LabelDireccion"
        Me.LabelDireccion.Size = New System.Drawing.Size(195, 18)
        Me.LabelDireccion.TabIndex = 69
        Me.LabelDireccion.Text = "Dirección"
        Me.LabelDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMaestro
        '
        Me.LabelMaestro.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelMaestro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelMaestro.Location = New System.Drawing.Point(31, 140)
        Me.LabelMaestro.Name = "LabelMaestro"
        Me.LabelMaestro.Size = New System.Drawing.Size(195, 18)
        Me.LabelMaestro.TabIndex = 67
        Me.LabelMaestro.Text = "Nombre del maestro: "
        Me.LabelMaestro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtMaestro
        '
        Me.TxtMaestro.Location = New System.Drawing.Point(33, 161)
        Me.TxtMaestro.Name = "TxtMaestro"
        Me.TxtMaestro.Size = New System.Drawing.Size(294, 20)
        Me.TxtMaestro.TabIndex = 66
        Me.TxtMaestro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelMateria
        '
        Me.LabelMateria.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelMateria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelMateria.Location = New System.Drawing.Point(31, 23)
        Me.LabelMateria.Name = "LabelMateria"
        Me.LabelMateria.Size = New System.Drawing.Size(195, 18)
        Me.LabelMateria.TabIndex = 64
        Me.LabelMateria.Text = "Nombre de la materia:"
        Me.LabelMateria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtMateria
        '
        Me.TxtMateria.Location = New System.Drawing.Point(33, 44)
        Me.TxtMateria.Name = "TxtMateria"
        Me.TxtMateria.Size = New System.Drawing.Size(294, 20)
        Me.TxtMateria.TabIndex = 63
        Me.TxtMateria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelDescripcion
        '
        Me.LabelDescripcion.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelDescripcion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelDescripcion.Location = New System.Drawing.Point(31, 83)
        Me.LabelDescripcion.Name = "LabelDescripcion"
        Me.LabelDescripcion.Size = New System.Drawing.Size(195, 18)
        Me.LabelDescripcion.TabIndex = 62
        Me.LabelDescripcion.Text = "Descripción:"
        Me.LabelDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(33, 104)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(598, 20)
        Me.TxtDescripcion.TabIndex = 60
        Me.TxtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelCorreo
        '
        Me.LabelCorreo.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelCorreo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelCorreo.Location = New System.Drawing.Point(363, 140)
        Me.LabelCorreo.Name = "LabelCorreo"
        Me.LabelCorreo.Size = New System.Drawing.Size(195, 18)
        Me.LabelCorreo.TabIndex = 78
        Me.LabelCorreo.Text = "Correo electrónico: "
        Me.LabelCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(365, 161)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(266, 20)
        Me.TxtCorreo.TabIndex = 77
        Me.TxtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GridMaterias
        '
        Me.GridMaterias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridMaterias.BackgroundColor = System.Drawing.SystemColors.Control
        Me.GridMaterias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridMaterias.Location = New System.Drawing.Point(6, 216)
        Me.GridMaterias.Name = "GridMaterias"
        Me.GridMaterias.ReadOnly = True
        Me.GridMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridMaterias.Size = New System.Drawing.Size(780, 175)
        Me.GridMaterias.TabIndex = 79
        '
        'ContextMenuStripEliminar
        '
        Me.ContextMenuStripEliminar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarToolStripMenuItem, Me.EliminarRegistroToolStripMenuItem, Me.ActualizarRegistroToolStripMenuItem})
        Me.ContextMenuStripEliminar.Name = "ContextMenuStripEliminar"
        Me.ContextMenuStripEliminar.Size = New System.Drawing.Size(181, 92)
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'EliminarRegistroToolStripMenuItem
        '
        Me.EliminarRegistroToolStripMenuItem.Name = "EliminarRegistroToolStripMenuItem"
        Me.EliminarRegistroToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EliminarRegistroToolStripMenuItem.Text = "Eliminar Registro"
        '
        'ActualizarRegistroToolStripMenuItem
        '
        Me.ActualizarRegistroToolStripMenuItem.Name = "ActualizarRegistroToolStripMenuItem"
        Me.ActualizarRegistroToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ActualizarRegistroToolStripMenuItem.Text = "Actualizar Registro"
        '
        'Registro_Materias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 457)
        Me.ContextMenuStrip = Me.ContextMenuStripEliminar
        Me.Controls.Add(Me.GridMaterias)
        Me.Controls.Add(Me.LabelCorreo)
        Me.Controls.Add(Me.TxtCorreo)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.LabelSemestre)
        Me.Controls.Add(Me.Cbo_Semestre)
        Me.Controls.Add(Me.LabelDireccion)
        Me.Controls.Add(Me.LabelMaestro)
        Me.Controls.Add(Me.TxtMaestro)
        Me.Controls.Add(Me.LabelMateria)
        Me.Controls.Add(Me.TxtMateria)
        Me.Controls.Add(Me.LabelDescripcion)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.PanelInferior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registro_Materias"
        Me.Text = "Registro_Materias"
        Me.PanelInferior.ResumeLayout(False)
        CType(Me.GridMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripEliminar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelInferior As Panel
    Friend WithEvents ButtonRegistrar As Button
    Friend WithEvents LabelTotal As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents LabelSemestre As Label
    Friend WithEvents Cbo_Semestre As ComboBox
    Friend WithEvents LabelDireccion As Label
    Friend WithEvents LabelMaestro As Label
    Friend WithEvents TxtMaestro As TextBox
    Friend WithEvents LabelMateria As Label
    Friend WithEvents TxtMateria As TextBox
    Friend WithEvents LabelDescripcion As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents LabelCorreo As Label
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents GridMaterias As DataGridView
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ContextMenuStripEliminar As ContextMenuStrip
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarRegistroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarRegistroToolStripMenuItem As ToolStripMenuItem
End Class
