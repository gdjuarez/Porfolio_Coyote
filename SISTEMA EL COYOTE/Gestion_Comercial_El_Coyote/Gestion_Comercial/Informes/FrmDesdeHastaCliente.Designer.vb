<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDesdeHastaCliente
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
        Me.BtnInfCliente = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPhasta = New System.Windows.Forms.DateTimePicker()
        Me.DTPdesde = New System.Windows.Forms.DateTimePicker()
        Me.CBRazonSocial = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.CBApellido = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnInfCliente
        '
        Me.BtnInfCliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInfCliente.Location = New System.Drawing.Point(160, 275)
        Me.BtnInfCliente.Name = "BtnInfCliente"
        Me.BtnInfCliente.Size = New System.Drawing.Size(153, 36)
        Me.BtnInfCliente.TabIndex = 17
        Me.BtnInfCliente.Text = "Seleccionar"
        Me.BtnInfCliente.UseVisualStyleBackColor = True
        Me.BtnInfCliente.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(140, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 25)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Seleccione las fechas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(242, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 21)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 21)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Desde"
        '
        'DTPhasta
        '
        Me.DTPhasta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPhasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPhasta.Location = New System.Drawing.Point(294, 52)
        Me.DTPhasta.Name = "DTPhasta"
        Me.DTPhasta.Size = New System.Drawing.Size(125, 29)
        Me.DTPhasta.TabIndex = 12
        '
        'DTPdesde
        '
        Me.DTPdesde.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPdesde.Location = New System.Drawing.Point(111, 52)
        Me.DTPdesde.Name = "DTPdesde"
        Me.DTPdesde.Size = New System.Drawing.Size(125, 29)
        Me.DTPdesde.TabIndex = 11
        '
        'CBRazonSocial
        '
        Me.CBRazonSocial.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBRazonSocial.FormattingEnabled = True
        Me.CBRazonSocial.Location = New System.Drawing.Point(159, 150)
        Me.CBRazonSocial.Name = "CBRazonSocial"
        Me.CBRazonSocial.Size = New System.Drawing.Size(259, 29)
        Me.CBRazonSocial.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 21)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Razon Social"
        '
        'TxtCliente
        '
        Me.TxtCliente.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TxtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCliente.Location = New System.Drawing.Point(198, 230)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(157, 22)
        Me.TxtCliente.TabIndex = 21
        Me.TxtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBApellido
        '
        Me.CBApellido.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBApellido.FormattingEnabled = True
        Me.CBApellido.Location = New System.Drawing.Point(157, 195)
        Me.CBApellido.Name = "CBApellido"
        Me.CBApellido.Size = New System.Drawing.Size(259, 29)
        Me.CBApellido.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(87, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 21)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Apellido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(152, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 25)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Seleccione cliente"
        '
        'FrmDesdeHastaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 323)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CBApellido)
        Me.Controls.Add(Me.TxtCliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBRazonSocial)
        Me.Controls.Add(Me.BtnInfCliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTPhasta)
        Me.Controls.Add(Me.DTPdesde)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDesdeHastaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desde Hasta Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnInfCliente As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTPhasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPdesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBRazonSocial As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtCliente As System.Windows.Forms.TextBox
    Friend WithEvents CBApellido As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
