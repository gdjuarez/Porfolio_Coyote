<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDesdeHastaProveedores
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
        Me.BtnInfProveedor = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPhasta = New System.Windows.Forms.DateTimePicker()
        Me.DTPdesde = New System.Windows.Forms.DateTimePicker()
        Me.CBProveedor = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtProveedor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnInfProveedor
        '
        Me.BtnInfProveedor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInfProveedor.Location = New System.Drawing.Point(129, 163)
        Me.BtnInfProveedor.Name = "BtnInfProveedor"
        Me.BtnInfProveedor.Size = New System.Drawing.Size(153, 36)
        Me.BtnInfProveedor.TabIndex = 17
        Me.BtnInfProveedor.Text = "Seleccionar"
        Me.BtnInfProveedor.UseVisualStyleBackColor = True
        Me.BtnInfProveedor.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(109, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 25)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Seleccione las fechas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(211, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 21)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 21)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Desde"
        '
        'DTPhasta
        '
        Me.DTPhasta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPhasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPhasta.Location = New System.Drawing.Point(263, 40)
        Me.DTPhasta.Name = "DTPhasta"
        Me.DTPhasta.Size = New System.Drawing.Size(125, 29)
        Me.DTPhasta.TabIndex = 12
        '
        'DTPdesde
        '
        Me.DTPdesde.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPdesde.Location = New System.Drawing.Point(80, 40)
        Me.DTPdesde.Name = "DTPdesde"
        Me.DTPdesde.Size = New System.Drawing.Size(125, 29)
        Me.DTPdesde.TabIndex = 11
        '
        'CBProveedor
        '
        Me.CBProveedor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBProveedor.FormattingEnabled = True
        Me.CBProveedor.Location = New System.Drawing.Point(118, 120)
        Me.CBProveedor.Name = "CBProveedor"
        Me.CBProveedor.Size = New System.Drawing.Size(259, 29)
        Me.CBProveedor.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 21)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Proveedor"
        '
        'TxtProveedor
        '
        Me.TxtProveedor.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TxtProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtProveedor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProveedor.Location = New System.Drawing.Point(171, 123)
        Me.TxtProveedor.Name = "TxtProveedor"
        Me.TxtProveedor.Size = New System.Drawing.Size(157, 22)
        Me.TxtProveedor.TabIndex = 21
        Me.TxtProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(121, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 25)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Seleccione cliente"
        '
        'FrmDesdeHastaProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 210)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBProveedor)
        Me.Controls.Add(Me.BtnInfProveedor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTPhasta)
        Me.Controls.Add(Me.DTPdesde)
        Me.Controls.Add(Me.TxtProveedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDesdeHastaProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desde Hasta Proveedores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnInfProveedor As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTPhasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPdesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
