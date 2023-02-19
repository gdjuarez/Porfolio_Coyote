<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCargaPagoCC
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
        Me.LblIdcliente = New System.Windows.Forms.Label()
        Me.CBRazonSocial = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMonto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.DTPpcc = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'LblIdcliente
        '
        Me.LblIdcliente.AutoSize = True
        Me.LblIdcliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIdcliente.Location = New System.Drawing.Point(345, 18)
        Me.LblIdcliente.Name = "LblIdcliente"
        Me.LblIdcliente.Size = New System.Drawing.Size(71, 21)
        Me.LblIdcliente.TabIndex = 69
        Me.LblIdcliente.Text = "IdCliente"
        '
        'CBRazonSocial
        '
        Me.CBRazonSocial.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBRazonSocial.FormattingEnabled = True
        Me.CBRazonSocial.Location = New System.Drawing.Point(90, 14)
        Me.CBRazonSocial.Name = "CBRazonSocial"
        Me.CBRazonSocial.Size = New System.Drawing.Size(253, 29)
        Me.CBRazonSocial.TabIndex = 68
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 21)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Cliente"
        '
        'TxtMonto
        '
        Me.TxtMonto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMonto.Location = New System.Drawing.Point(103, 75)
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.Size = New System.Drawing.Size(100, 29)
        Me.TxtMonto.TabIndex = 71
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 21)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Monto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(221, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 21)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Fecha"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.Location = New System.Drawing.Point(40, 132)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(360, 34)
        Me.BtnAceptar.TabIndex = 74
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'DTPpcc
        '
        Me.DTPpcc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPpcc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPpcc.Location = New System.Drawing.Point(276, 75)
        Me.DTPpcc.Name = "DTPpcc"
        Me.DTPpcc.Size = New System.Drawing.Size(122, 29)
        Me.DTPpcc.TabIndex = 75
        '
        'FrmCargaPagoCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 181)
        Me.Controls.Add(Me.DTPpcc)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtMonto)
        Me.Controls.Add(Me.LblIdcliente)
        Me.Controls.Add(Me.CBRazonSocial)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargaPagoCC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga Pago de  Cuenta Corriente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblIdcliente As System.Windows.Forms.Label
    Friend WithEvents CBRazonSocial As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents DTPpcc As System.Windows.Forms.DateTimePicker
End Class
