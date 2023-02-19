<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMarca
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
        Me.BtnAgregaMarca = New System.Windows.Forms.Button()
        Me.BtnGrabaMarca = New System.Windows.Forms.Button()
        Me.BtnBorraMarca = New System.Windows.Forms.Button()
        Me.ListBoxMarca = New System.Windows.Forms.ListBox()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnAgregaMarca
        '
        Me.BtnAgregaMarca.Image = Global.Gestion_Comercial.My.Resources.Resources.BI_add2_36
        Me.BtnAgregaMarca.Location = New System.Drawing.Point(14, 33)
        Me.BtnAgregaMarca.Name = "BtnAgregaMarca"
        Me.BtnAgregaMarca.Size = New System.Drawing.Size(55, 55)
        Me.BtnAgregaMarca.TabIndex = 0
        Me.BtnAgregaMarca.Text = "Agregar"
        Me.BtnAgregaMarca.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAgregaMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnAgregaMarca.UseVisualStyleBackColor = True
        '
        'BtnGrabaMarca
        '
        Me.BtnGrabaMarca.Enabled = False
        Me.BtnGrabaMarca.Image = Global.Gestion_Comercial.My.Resources.Resources.BI_disk_36
        Me.BtnGrabaMarca.Location = New System.Drawing.Point(14, 88)
        Me.BtnGrabaMarca.Name = "BtnGrabaMarca"
        Me.BtnGrabaMarca.Size = New System.Drawing.Size(55, 55)
        Me.BtnGrabaMarca.TabIndex = 1
        Me.BtnGrabaMarca.Text = "Grabar"
        Me.BtnGrabaMarca.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGrabaMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnGrabaMarca.UseVisualStyleBackColor = True
        '
        'BtnBorraMarca
        '
        Me.BtnBorraMarca.Image = Global.Gestion_Comercial.My.Resources.Resources.BI_delete_36
        Me.BtnBorraMarca.Location = New System.Drawing.Point(14, 143)
        Me.BtnBorraMarca.Name = "BtnBorraMarca"
        Me.BtnBorraMarca.Size = New System.Drawing.Size(55, 55)
        Me.BtnBorraMarca.TabIndex = 2
        Me.BtnBorraMarca.Text = "Borrar"
        Me.BtnBorraMarca.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBorraMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnBorraMarca.UseVisualStyleBackColor = True
        '
        'ListBoxMarca
        '
        Me.ListBoxMarca.FormattingEnabled = True
        Me.ListBoxMarca.Location = New System.Drawing.Point(77, 33)
        Me.ListBoxMarca.Name = "ListBoxMarca"
        Me.ListBoxMarca.Size = New System.Drawing.Size(260, 173)
        Me.ListBoxMarca.TabIndex = 3
        '
        'TxtMarca
        '
        Me.TxtMarca.BackColor = System.Drawing.Color.LightGreen
        Me.TxtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMarca.Location = New System.Drawing.Point(77, 6)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.ReadOnly = True
        Me.TxtMarca.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtMarca.Size = New System.Drawing.Size(260, 20)
        Me.TxtMarca.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnAgregaMarca)
        Me.Panel1.Controls.Add(Me.TxtMarca)
        Me.Panel1.Controls.Add(Me.BtnGrabaMarca)
        Me.Panel1.Controls.Add(Me.ListBoxMarca)
        Me.Panel1.Controls.Add(Me.BtnBorraMarca)
        Me.Panel1.Location = New System.Drawing.Point(12, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 210)
        Me.Panel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Marca"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(299, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Altas, bajas y modificación de Marcas "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.Location = New System.Drawing.Point(0, 246)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(374, 29)
        Me.BtnCerrar.TabIndex = 8
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'FrmMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 275)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMarca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM Marca "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAgregaMarca As System.Windows.Forms.Button
    Friend WithEvents BtnGrabaMarca As System.Windows.Forms.Button
    Friend WithEvents BtnBorraMarca As System.Windows.Forms.Button
    Friend WithEvents ListBoxMarca As System.Windows.Forms.ListBox
    Friend WithEvents TxtMarca As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
End Class
