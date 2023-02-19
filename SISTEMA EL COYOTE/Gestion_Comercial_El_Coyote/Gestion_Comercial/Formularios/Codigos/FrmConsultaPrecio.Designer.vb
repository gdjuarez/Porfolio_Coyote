<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConsultaPrecio
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
        Me.TxtArticulo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnArticulos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtArticulo
        '
        Me.TxtArticulo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtArticulo.Location = New System.Drawing.Point(14, 115)
        Me.TxtArticulo.Name = "TxtArticulo"
        Me.TxtArticulo.ReadOnly = True
        Me.TxtArticulo.Size = New System.Drawing.Size(237, 29)
        Me.TxtArticulo.TabIndex = 14
        Me.TxtArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre articulo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Busca precio"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.Location = New System.Drawing.Point(14, 39)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(237, 29)
        Me.TxtCodigo.TabIndex = 0
        Me.TxtCodigo.Text = "Codigo"
        Me.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecio.Location = New System.Drawing.Point(14, 183)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.ReadOnly = True
        Me.TxtPrecio.Size = New System.Drawing.Size(237, 29)
        Me.TxtPrecio.TabIndex = 16
        Me.TxtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(78, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 21)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Precio articulo"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(14, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(237, 29)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Buscar otro"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnArticulos
        '
        Me.BtnArticulos.BackgroundImage = Global.Gestion_Comercial.My.Resources.Resources.BI_addCart_48
        Me.BtnArticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnArticulos.Location = New System.Drawing.Point(14, 81)
        Me.BtnArticulos.Name = "BtnArticulos"
        Me.BtnArticulos.Size = New System.Drawing.Size(30, 30)
        Me.BtnArticulos.TabIndex = 118
        Me.BtnArticulos.UseVisualStyleBackColor = True
        '
        'FrmConsultaPrecio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 271)
        Me.Controls.Add(Me.BtnArticulos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtPrecio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtArticulo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(900, 0)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConsultaPrecio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Consulta Precios"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents TxtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnArticulos As System.Windows.Forms.Button
End Class
