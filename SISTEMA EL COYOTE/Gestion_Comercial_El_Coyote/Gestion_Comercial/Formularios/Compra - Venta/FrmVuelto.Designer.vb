<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVuelto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVuelto))
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TxtVenta = New System.Windows.Forms.TextBox()
        Me.TxtPago = New System.Windows.Forms.TextBox()
        Me.TxtVuelto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(16, 249)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(150, 50)
        Me.BtnAceptar.TabIndex = 0
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'TxtVenta
        '
        Me.TxtVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVenta.Location = New System.Drawing.Point(80, 54)
        Me.TxtVenta.Margin = New System.Windows.Forms.Padding(6)
        Me.TxtVenta.Name = "TxtVenta"
        Me.TxtVenta.ReadOnly = True
        Me.TxtVenta.Size = New System.Drawing.Size(196, 29)
        Me.TxtVenta.TabIndex = 1
        Me.TxtVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtPago
        '
        Me.TxtPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPago.Location = New System.Drawing.Point(80, 125)
        Me.TxtPago.Margin = New System.Windows.Forms.Padding(6)
        Me.TxtPago.Name = "TxtPago"
        Me.TxtPago.Size = New System.Drawing.Size(196, 29)
        Me.TxtPago.TabIndex = 2
        Me.TxtPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtVuelto
        '
        Me.TxtVuelto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVuelto.Location = New System.Drawing.Point(80, 196)
        Me.TxtVuelto.Margin = New System.Windows.Forms.Padding(6)
        Me.TxtVuelto.Name = "TxtVuelto"
        Me.TxtVuelto.ReadOnly = True
        Me.TxtVuelto.Size = New System.Drawing.Size(196, 29)
        Me.TxtVuelto.TabIndex = 3
        Me.TxtVuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(146, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Venta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Pago"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(140, 163)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Vuelto:"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ForeColor = System.Drawing.Color.Red
        Me.BtnCancelar.Location = New System.Drawing.Point(178, 249)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(150, 50)
        Me.BtnCancelar.TabIndex = 7
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'FrmVuelto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 321)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtVuelto)
        Me.Controls.Add(Me.TxtPago)
        Me.Controls.Add(Me.TxtVenta)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.Name = "FrmVuelto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vuelto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents TxtVenta As System.Windows.Forms.TextBox
    Friend WithEvents TxtPago As System.Windows.Forms.TextBox
    Friend WithEvents TxtVuelto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
End Class
