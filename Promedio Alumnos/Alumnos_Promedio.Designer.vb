<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alumnos_Promedio
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
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.LabelExpediente = New System.Windows.Forms.Label()
        Me.TxtExpediente = New System.Windows.Forms.TextBox()
        Me.LabelParcial1 = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.TxtParcial1 = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LabelParcial2 = New System.Windows.Forms.Label()
        Me.txtDos = New System.Windows.Forms.TextBox()
        Me.LabelParcial3 = New System.Windows.Forms.Label()
        Me.txtTres = New System.Windows.Forms.TextBox()
        Me.LabelPromedio = New System.Windows.Forms.Label()
        Me.TextPromedio = New System.Windows.Forms.TextBox()
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.ButtonCalcular = New System.Windows.Forms.Button()
        Me.PanelInferior.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelTitulo
        '
        Me.LabelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.LabelTitulo.Font = New System.Drawing.Font("MS PGothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.Color.White
        Me.LabelTitulo.Location = New System.Drawing.Point(274, 28)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(239, 19)
        Me.LabelTitulo.TabIndex = 9
        Me.LabelTitulo.Text = "PROMEDIO DE ALUMNOS"
        '
        'LabelExpediente
        '
        Me.LabelExpediente.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelExpediente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelExpediente.Location = New System.Drawing.Point(73, 82)
        Me.LabelExpediente.Name = "LabelExpediente"
        Me.LabelExpediente.Size = New System.Drawing.Size(195, 18)
        Me.LabelExpediente.TabIndex = 19
        Me.LabelExpediente.Text = "Expediente"
        Me.LabelExpediente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtExpediente
        '
        Me.TxtExpediente.Location = New System.Drawing.Point(75, 103)
        Me.TxtExpediente.Name = "TxtExpediente"
        Me.TxtExpediente.Size = New System.Drawing.Size(294, 20)
        Me.TxtExpediente.TabIndex = 18
        Me.TxtExpediente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelParcial1
        '
        Me.LabelParcial1.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelParcial1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelParcial1.Location = New System.Drawing.Point(73, 176)
        Me.LabelParcial1.Name = "LabelParcial1"
        Me.LabelParcial1.Size = New System.Drawing.Size(195, 18)
        Me.LabelParcial1.TabIndex = 17
        Me.LabelParcial1.Text = "Parcial1"
        Me.LabelParcial1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelNombre
        '
        Me.LabelNombre.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelNombre.Location = New System.Drawing.Point(73, 128)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(195, 18)
        Me.LabelNombre.TabIndex = 16
        Me.LabelNombre.Text = "Nombre"
        Me.LabelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtParcial1
        '
        Me.TxtParcial1.Location = New System.Drawing.Point(75, 197)
        Me.TxtParcial1.Name = "TxtParcial1"
        Me.TxtParcial1.Size = New System.Drawing.Size(294, 20)
        Me.TxtParcial1.TabIndex = 15
        Me.TxtParcial1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(75, 149)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(294, 20)
        Me.TxtNombre.TabIndex = 14
        Me.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelParcial2
        '
        Me.LabelParcial2.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelParcial2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelParcial2.Location = New System.Drawing.Point(73, 235)
        Me.LabelParcial2.Name = "LabelParcial2"
        Me.LabelParcial2.Size = New System.Drawing.Size(195, 18)
        Me.LabelParcial2.TabIndex = 21
        Me.LabelParcial2.Text = "Parcial Dos"
        Me.LabelParcial2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDos
        '
        Me.txtDos.Location = New System.Drawing.Point(75, 256)
        Me.txtDos.Name = "txtDos"
        Me.txtDos.Size = New System.Drawing.Size(294, 20)
        Me.txtDos.TabIndex = 20
        Me.txtDos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelParcial3
        '
        Me.LabelParcial3.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelParcial3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelParcial3.Location = New System.Drawing.Point(73, 294)
        Me.LabelParcial3.Name = "LabelParcial3"
        Me.LabelParcial3.Size = New System.Drawing.Size(195, 18)
        Me.LabelParcial3.TabIndex = 23
        Me.LabelParcial3.Text = "Parcial Tres"
        Me.LabelParcial3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTres
        '
        Me.txtTres.Location = New System.Drawing.Point(75, 315)
        Me.txtTres.Name = "txtTres"
        Me.txtTres.Size = New System.Drawing.Size(294, 20)
        Me.txtTres.TabIndex = 22
        Me.txtTres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelPromedio
        '
        Me.LabelPromedio.Font = New System.Drawing.Font("MS Gothic", 8.0!)
        Me.LabelPromedio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelPromedio.Location = New System.Drawing.Point(455, 376)
        Me.LabelPromedio.Name = "LabelPromedio"
        Me.LabelPromedio.Size = New System.Drawing.Size(195, 18)
        Me.LabelPromedio.TabIndex = 25
        Me.LabelPromedio.Text = "Promedio"
        Me.LabelPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextPromedio
        '
        Me.TextPromedio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextPromedio.Location = New System.Drawing.Point(457, 397)
        Me.TextPromedio.Name = "TextPromedio"
        Me.TextPromedio.Size = New System.Drawing.Size(294, 20)
        Me.TextPromedio.TabIndex = 24
        Me.TextPromedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PanelInferior
        '
        Me.PanelInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelInferior.Controls.Add(Me.ButtonLimpiar)
        Me.PanelInferior.Controls.Add(Me.ButtonCalcular)
        Me.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInferior.Location = New System.Drawing.Point(0, 446)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(800, 50)
        Me.PanelInferior.TabIndex = 26
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.ButtonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLimpiar.ForeColor = System.Drawing.Color.White
        Me.ButtonLimpiar.Location = New System.Drawing.Point(564, 14)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(94, 24)
        Me.ButtonLimpiar.TabIndex = 1
        Me.ButtonLimpiar.Text = "Limpiar"
        Me.ButtonLimpiar.UseVisualStyleBackColor = True
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
        Me.ButtonCalcular.Location = New System.Drawing.Point(682, 14)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(94, 24)
        Me.ButtonCalcular.TabIndex = 0
        Me.ButtonCalcular.Text = "Calcular"
        Me.ButtonCalcular.UseVisualStyleBackColor = True
        '
        'Alumnos_Promedio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 496)
        Me.Controls.Add(Me.PanelInferior)
        Me.Controls.Add(Me.LabelPromedio)
        Me.Controls.Add(Me.TextPromedio)
        Me.Controls.Add(Me.LabelParcial3)
        Me.Controls.Add(Me.txtTres)
        Me.Controls.Add(Me.LabelParcial2)
        Me.Controls.Add(Me.txtDos)
        Me.Controls.Add(Me.LabelExpediente)
        Me.Controls.Add(Me.TxtExpediente)
        Me.Controls.Add(Me.LabelParcial1)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.TxtParcial1)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LabelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Alumnos_Promedio"
        Me.Text = "Alumnos_Promedio"
        Me.PanelInferior.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitulo As Label
    Friend WithEvents LabelExpediente As Label
    Friend WithEvents TxtExpediente As TextBox
    Friend WithEvents LabelParcial1 As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents TxtParcial1 As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LabelParcial2 As Label
    Friend WithEvents txtDos As TextBox
    Friend WithEvents LabelParcial3 As Label
    Friend WithEvents txtTres As TextBox
    Friend WithEvents LabelPromedio As Label
    Friend WithEvents TextPromedio As TextBox
    Friend WithEvents PanelInferior As Panel
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents ButtonCalcular As Button
End Class
