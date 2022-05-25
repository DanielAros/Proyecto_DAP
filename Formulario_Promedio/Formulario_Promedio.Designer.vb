<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formulario_Promedio
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
        Me.LabelCal3 = New System.Windows.Forms.Label()
        Me.TxtCal3 = New System.Windows.Forms.TextBox()
        Me.LabelCal2 = New System.Windows.Forms.Label()
        Me.TxtCal2 = New System.Windows.Forms.TextBox()
        Me.LabelCal1 = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.TxtCal1 = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LabelCal4 = New System.Windows.Forms.Label()
        Me.TxtCal4 = New System.Windows.Forms.TextBox()
        Me.LabelPromedio = New System.Windows.Forms.Label()
        Me.TxtPromedio = New System.Windows.Forms.TextBox()
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.ButtonCalcular = New System.Windows.Forms.Button()
        Me.LabelFacultad = New System.Windows.Forms.Label()
        Me.TxtFacultad = New System.Windows.Forms.TextBox()
        Me.LabelSemestre = New System.Windows.Forms.Label()
        Me.TxtSemestre = New System.Windows.Forms.TextBox()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.ContextMenuStripLimpiar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelInferior.SuspendLayout()
        Me.ContextMenuStripLimpiar.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelCal3
        '
        Me.LabelCal3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelCal3.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelCal3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelCal3.Location = New System.Drawing.Point(91, 262)
        Me.LabelCal3.Name = "LabelCal3"
        Me.LabelCal3.Size = New System.Drawing.Size(195, 18)
        Me.LabelCal3.TabIndex = 33
        Me.LabelCal3.Text = "Calificación 3:"
        Me.LabelCal3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtCal3
        '
        Me.TxtCal3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtCal3.Location = New System.Drawing.Point(92, 279)
        Me.TxtCal3.Name = "TxtCal3"
        Me.TxtCal3.Size = New System.Drawing.Size(273, 20)
        Me.TxtCal3.TabIndex = 32
        Me.TxtCal3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelCal2
        '
        Me.LabelCal2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelCal2.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelCal2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelCal2.Location = New System.Drawing.Point(411, 198)
        Me.LabelCal2.Name = "LabelCal2"
        Me.LabelCal2.Size = New System.Drawing.Size(195, 18)
        Me.LabelCal2.TabIndex = 31
        Me.LabelCal2.Text = "Calificación 2:"
        Me.LabelCal2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtCal2
        '
        Me.TxtCal2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtCal2.Location = New System.Drawing.Point(412, 214)
        Me.TxtCal2.Name = "TxtCal2"
        Me.TxtCal2.Size = New System.Drawing.Size(273, 20)
        Me.TxtCal2.TabIndex = 30
        Me.TxtCal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelCal1
        '
        Me.LabelCal1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelCal1.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelCal1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelCal1.Location = New System.Drawing.Point(92, 197)
        Me.LabelCal1.Name = "LabelCal1"
        Me.LabelCal1.Size = New System.Drawing.Size(195, 18)
        Me.LabelCal1.TabIndex = 27
        Me.LabelCal1.Text = "Calificación 1:"
        Me.LabelCal1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelNombre
        '
        Me.LabelNombre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelNombre.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelNombre.Location = New System.Drawing.Point(91, 83)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(156, 14)
        Me.LabelNombre.TabIndex = 26
        Me.LabelNombre.Text = "Nombre del alumno:"
        Me.LabelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtCal1
        '
        Me.TxtCal1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtCal1.Location = New System.Drawing.Point(93, 214)
        Me.TxtCal1.Name = "TxtCal1"
        Me.TxtCal1.Size = New System.Drawing.Size(273, 20)
        Me.TxtCal1.TabIndex = 25
        Me.TxtCal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNombre
        '
        Me.TxtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtNombre.Location = New System.Drawing.Point(92, 99)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(593, 20)
        Me.TxtNombre.TabIndex = 24
        Me.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelCal4
        '
        Me.LabelCal4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelCal4.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelCal4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelCal4.Location = New System.Drawing.Point(412, 262)
        Me.LabelCal4.Name = "LabelCal4"
        Me.LabelCal4.Size = New System.Drawing.Size(195, 18)
        Me.LabelCal4.TabIndex = 35
        Me.LabelCal4.Text = "Calificación 4:"
        Me.LabelCal4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtCal4
        '
        Me.TxtCal4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtCal4.Location = New System.Drawing.Point(413, 279)
        Me.TxtCal4.Name = "TxtCal4"
        Me.TxtCal4.Size = New System.Drawing.Size(273, 20)
        Me.TxtCal4.TabIndex = 34
        Me.TxtCal4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelPromedio
        '
        Me.LabelPromedio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelPromedio.Font = New System.Drawing.Font("MS Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPromedio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelPromedio.Location = New System.Drawing.Point(274, 335)
        Me.LabelPromedio.Name = "LabelPromedio"
        Me.LabelPromedio.Size = New System.Drawing.Size(156, 14)
        Me.LabelPromedio.TabIndex = 37
        Me.LabelPromedio.Text = "Promedio:"
        Me.LabelPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtPromedio
        '
        Me.TxtPromedio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtPromedio.Location = New System.Drawing.Point(277, 352)
        Me.TxtPromedio.Name = "TxtPromedio"
        Me.TxtPromedio.ReadOnly = True
        Me.TxtPromedio.Size = New System.Drawing.Size(317, 20)
        Me.TxtPromedio.TabIndex = 36
        Me.TxtPromedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PanelInferior
        '
        Me.PanelInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelInferior.Controls.Add(Me.ButtonCalcular)
        Me.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInferior.Location = New System.Drawing.Point(0, 407)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(794, 50)
        Me.PanelInferior.TabIndex = 38
        '
        'ButtonCalcular
        '
        Me.ButtonCalcular.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCalcular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCalcular.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.ButtonCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCalcular.ForeColor = System.Drawing.Color.White
        Me.ButtonCalcular.Location = New System.Drawing.Point(676, 14)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(94, 24)
        Me.ButtonCalcular.TabIndex = 0
        Me.ButtonCalcular.Text = "Calcular"
        Me.ButtonCalcular.UseVisualStyleBackColor = True
        '
        'LabelFacultad
        '
        Me.LabelFacultad.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelFacultad.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelFacultad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelFacultad.Location = New System.Drawing.Point(411, 142)
        Me.LabelFacultad.Name = "LabelFacultad"
        Me.LabelFacultad.Size = New System.Drawing.Size(156, 14)
        Me.LabelFacultad.TabIndex = 40
        Me.LabelFacultad.Text = "Facultad:"
        Me.LabelFacultad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtFacultad
        '
        Me.TxtFacultad.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtFacultad.Location = New System.Drawing.Point(412, 158)
        Me.TxtFacultad.Name = "TxtFacultad"
        Me.TxtFacultad.Size = New System.Drawing.Size(273, 20)
        Me.TxtFacultad.TabIndex = 39
        Me.TxtFacultad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelSemestre
        '
        Me.LabelSemestre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelSemestre.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelSemestre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelSemestre.Location = New System.Drawing.Point(91, 142)
        Me.LabelSemestre.Name = "LabelSemestre"
        Me.LabelSemestre.Size = New System.Drawing.Size(156, 14)
        Me.LabelSemestre.TabIndex = 42
        Me.LabelSemestre.Text = "Semestre:"
        Me.LabelSemestre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtSemestre
        '
        Me.TxtSemestre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtSemestre.Location = New System.Drawing.Point(92, 158)
        Me.TxtSemestre.Name = "TxtSemestre"
        Me.TxtSemestre.Size = New System.Drawing.Size(273, 20)
        Me.TxtSemestre.TabIndex = 41
        Me.TxtSemestre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelTitulo
        '
        Me.LabelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.BackColor = System.Drawing.SystemColors.Control
        Me.LabelTitulo.Font = New System.Drawing.Font("MS PGothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.Color.Black
        Me.LabelTitulo.Location = New System.Drawing.Point(257, 28)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(247, 19)
        Me.LabelTitulo.TabIndex = 81
        Me.LabelTitulo.Text = "PROMEDIO CONDICIONAL"
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
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'Formulario_Promedio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 457)
        Me.ContextMenuStrip = Me.ContextMenuStripLimpiar
        Me.Controls.Add(Me.LabelTitulo)
        Me.Controls.Add(Me.LabelSemestre)
        Me.Controls.Add(Me.TxtSemestre)
        Me.Controls.Add(Me.LabelFacultad)
        Me.Controls.Add(Me.TxtFacultad)
        Me.Controls.Add(Me.PanelInferior)
        Me.Controls.Add(Me.LabelPromedio)
        Me.Controls.Add(Me.TxtPromedio)
        Me.Controls.Add(Me.LabelCal4)
        Me.Controls.Add(Me.TxtCal4)
        Me.Controls.Add(Me.LabelCal3)
        Me.Controls.Add(Me.TxtCal3)
        Me.Controls.Add(Me.LabelCal2)
        Me.Controls.Add(Me.TxtCal2)
        Me.Controls.Add(Me.LabelCal1)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.TxtCal1)
        Me.Controls.Add(Me.TxtNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Formulario_Promedio"
        Me.Text = "Formulario_Promedio"
        Me.PanelInferior.ResumeLayout(False)
        Me.ContextMenuStripLimpiar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelCal3 As Label
    Friend WithEvents TxtCal3 As TextBox
    Friend WithEvents LabelCal2 As Label
    Friend WithEvents TxtCal2 As TextBox
    Friend WithEvents LabelCal1 As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents TxtCal1 As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LabelCal4 As Label
    Friend WithEvents TxtCal4 As TextBox
    Friend WithEvents LabelPromedio As Label
    Friend WithEvents TxtPromedio As TextBox
    Friend WithEvents PanelInferior As Panel
    Friend WithEvents ButtonCalcular As Button
    Friend WithEvents LabelFacultad As Label
    Friend WithEvents TxtFacultad As TextBox
    Friend WithEvents LabelSemestre As Label
    Friend WithEvents TxtSemestre As TextBox
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents ContextMenuStripLimpiar As ContextMenuStrip
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
End Class
