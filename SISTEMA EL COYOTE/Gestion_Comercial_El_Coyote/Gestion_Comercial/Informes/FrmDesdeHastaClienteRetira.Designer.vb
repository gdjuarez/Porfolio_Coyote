<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDesdeHastaClienteRetira
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
        Me.BtnInfClienteRetira = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPhasta = New System.Windows.Forms.DateTimePicker()
        Me.DTPdesde = New System.Windows.Forms.DateTimePicker()
        Me.CBRazonSocial = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.CBClienteRetira = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtRetira = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnInfClienteRetira
        '
        Me.BtnInfClienteRetira.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInfClienteRetira.Location = New System.Drawing.Point(160, 275)
        Me.BtnInfClienteRetira.Name = "BtnInfClienteRetira"
        Me.BtnInfClienteRetira.Size = New System.Drawing.Size(153, 36)
        Me.BtnInfClienteRetira.TabIndex = 17
        Me.BtnInfClienteRetira.Text = "Seleccionar"
        Me.BtnInfClienteRetira.UseVisualStyleBackColor = True
        Me.BtnInfClienteRetira.Visible = False
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
        Me.CBRazonSocial.Location = New System.Drawing.Point(154, 130)
        Me.CBRazonSocial.Name = "CBRazonSocial"
        Me.CBRazonSocial.Size = New System.Drawing.Size(259, 29)
        Me.CBRazonSocial.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(93, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 21)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Cliente"
        '
        'TxtCliente
        '
        Me.TxtCliente.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TxtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCliente.Location = New System.Drawing.Point(119, 238)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(157, 22)
        Me.TxtCliente.TabIndex = 21
        Me.TxtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBClienteRetira
        '
        Me.CBClienteRetira.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBClienteRetira.FormattingEnabled = True
        Me.CBClienteRetira.Location = New System.Drawing.Point(154, 198)
        Me.CBClienteRetira.Name = "CBClienteRetira"
        Me.CBClienteRetira.Size = New System.Drawing.Size(259, 29)
        Me.CBClienteRetira.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(60, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 21)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Quien retira"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(152, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 25)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Seleccione cliente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(126, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(221, 25)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Seleccione cliente retira"
        '
        'TxtRetira
        '
        Me.TxtRetira.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TxtRetira.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtRetira.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRetira.Location = New System.Drawing.Point(292, 238)
        Me.TxtRetira.Name = "TxtRetira"
        Me.TxtRetira.Size = New System.Drawing.Size(157, 22)
        Me.TxtRetira.TabIndex = 26
        Me.TxtRetira.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmDesdeHastaClienteRetira
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 323)
        Me.Controls.Add(Me.TxtRetira)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CBClienteRetira)
        Me.Controls.Add(Me.TxtCliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBRazonSocial)
        Me.Controls.Add(Me.BtnInfClienteRetira)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTPhasta)
        Me.Controls.Add(Me.DTPdesde)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDesdeHastaClienteRetira"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desde Hasta Cliente Retira"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnInfClienteRetira As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTPhasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPdesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBRazonSocial As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtCliente As System.Windows.Forms.TextBox
    Friend WithEvents CBClienteRetira As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtRetira As System.Windows.Forms.TextBox
End Class
