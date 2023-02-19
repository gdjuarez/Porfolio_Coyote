<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCreaCodigos
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
        Me.PBCodigo = New System.Windows.Forms.PictureBox()
        Me.BtnGenerarCodigos = New System.Windows.Forms.Button()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtArticulo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblArticulo = New System.Windows.Forms.Label()
        CType(Me.PBCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBCodigo
        '
        Me.PBCodigo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PBCodigo.Location = New System.Drawing.Point(16, 159)
        Me.PBCodigo.Name = "PBCodigo"
        Me.PBCodigo.Size = New System.Drawing.Size(237, 65)
        Me.PBCodigo.TabIndex = 7
        Me.PBCodigo.TabStop = False
        '
        'BtnGenerarCodigos
        '
        Me.BtnGenerarCodigos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenerarCodigos.Location = New System.Drawing.Point(16, 247)
        Me.BtnGenerarCodigos.Name = "BtnGenerarCodigos"
        Me.BtnGenerarCodigos.Size = New System.Drawing.Size(237, 38)
        Me.BtnGenerarCodigos.TabIndex = 6
        Me.BtnGenerarCodigos.Text = "Generar"
        Me.BtnGenerarCodigos.UseVisualStyleBackColor = True
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.Location = New System.Drawing.Point(16, 37)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(237, 29)
        Me.TxtCodigo.TabIndex = 5
        Me.TxtCodigo.Text = "Codigo"
        Me.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 21)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombre articulo"
        '
        'TxtArticulo
        '
        Me.TxtArticulo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtArticulo.Location = New System.Drawing.Point(16, 99)
        Me.TxtArticulo.Name = "TxtArticulo"
        Me.TxtArticulo.ReadOnly = True
        Me.TxtArticulo.Size = New System.Drawing.Size(237, 29)
        Me.TxtArticulo.TabIndex = 10
        Me.TxtArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(103, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 21)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Imagen"
        '
        'LblArticulo
        '
        Me.LblArticulo.AutoSize = True
        Me.LblArticulo.Location = New System.Drawing.Point(30, 202)
        Me.LblArticulo.Name = "LblArticulo"
        Me.LblArticulo.Size = New System.Drawing.Size(0, 13)
        Me.LblArticulo.TabIndex = 12
        '
        'FrmCreaCodigos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 296)
        Me.Controls.Add(Me.LblArticulo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtArticulo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PBCodigo)
        Me.Controls.Add(Me.BtnGenerarCodigos)
        Me.Controls.Add(Me.TxtCodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCreaCodigos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Codigos"
        CType(Me.PBCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PBCodigo As System.Windows.Forms.PictureBox
    Friend WithEvents BtnGenerarCodigos As System.Windows.Forms.Button
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblArticulo As System.Windows.Forms.Label
End Class
