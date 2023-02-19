<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaVentaSinPago
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGVVentasCC = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnCobrar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTotalSelect = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.CBRazonSocial = New System.Windows.Forms.ComboBox()
        Me.LblIdcliente = New System.Windows.Forms.Label()
        Me.BtnBuscarCliente = New System.Windows.Forms.Button()
        Me.LblIdRetira = New System.Windows.Forms.Label()
        Me.CBRetira = New System.Windows.Forms.ComboBox()
        Me.BtnBuscarClienteRetira = New System.Windows.Forms.Button()
        Me.BtnTotalSeleccionado = New System.Windows.Forms.Button()
        Me.TxtSaldo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBCobraCC = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTodos = New System.Windows.Forms.CheckBox()
        CType(Me.DGVVentasCC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVVentasCC
        '
        Me.DGVVentasCC.AllowUserToAddRows = False
        Me.DGVVentasCC.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DGVVentasCC.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVVentasCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVVentasCC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVVentasCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVentasCC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.DGVVentasCC.Location = New System.Drawing.Point(10, 143)
        Me.DGVVentasCC.Name = "DGVVentasCC"
        Me.DGVVentasCC.RowHeadersVisible = False
        Me.DGVVentasCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVVentasCC.Size = New System.Drawing.Size(946, 325)
        Me.DGVVentasCC.TabIndex = 49
        '
        'Column1
        '
        Me.Column1.HeaderText = "Selecionar"
        Me.Column1.Name = "Column1"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Location = New System.Drawing.Point(12, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(943, 47)
        Me.Panel1.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(671, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Busqueda de articulos vendidos a cuenta corriente"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(836, 15)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(94, 20)
        Me.DateTimePicker1.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(118, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(553, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Retira"
        '
        'BtnCobrar
        '
        Me.BtnCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCobrar.Image = Global.Gestion_Comercial.My.Resources.Resources.Caja
        Me.BtnCobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCobrar.Location = New System.Drawing.Point(12, 474)
        Me.BtnCobrar.Name = "BtnCobrar"
        Me.BtnCobrar.Size = New System.Drawing.Size(107, 54)
        Me.BtnCobrar.TabIndex = 59
        Me.BtnCobrar.Text = "Cobrar"
        Me.BtnCobrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCobrar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(459, 483)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 20)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Total seleccionado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(776, 483)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 20)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Total"
        '
        'TxtTotalSelect
        '
        Me.TxtTotalSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalSelect.Location = New System.Drawing.Point(624, 479)
        Me.TxtTotalSelect.Name = "TxtTotalSelect"
        Me.TxtTotalSelect.Size = New System.Drawing.Size(125, 29)
        Me.TxtTotalSelect.TabIndex = 62
        '
        'TxtTotal
        '
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(831, 479)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(125, 29)
        Me.TxtTotal.TabIndex = 63
        '
        'CBRazonSocial
        '
        Me.CBRazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBRazonSocial.FormattingEnabled = True
        Me.CBRazonSocial.Location = New System.Drawing.Point(170, 76)
        Me.CBRazonSocial.Name = "CBRazonSocial"
        Me.CBRazonSocial.Size = New System.Drawing.Size(248, 24)
        Me.CBRazonSocial.TabIndex = 64
        '
        'LblIdcliente
        '
        Me.LblIdcliente.AutoSize = True
        Me.LblIdcliente.Location = New System.Drawing.Point(421, 82)
        Me.LblIdcliente.Name = "LblIdcliente"
        Me.LblIdcliente.Size = New System.Drawing.Size(48, 13)
        Me.LblIdcliente.TabIndex = 65
        Me.LblIdcliente.Text = "IdCliente"
        '
        'BtnBuscarCliente
        '
        Me.BtnBuscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarCliente.Image = Global.Gestion_Comercial.My.Resources.Resources.BI_find_b2_36
        Me.BtnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarCliente.Location = New System.Drawing.Point(10, 67)
        Me.BtnBuscarCliente.Name = "BtnBuscarCliente"
        Me.BtnBuscarCliente.Size = New System.Drawing.Size(106, 42)
        Me.BtnBuscarCliente.TabIndex = 66
        Me.BtnBuscarCliente.Text = "Buscar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cliente"
        Me.BtnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscarCliente.UseVisualStyleBackColor = True
        '
        'LblIdRetira
        '
        Me.LblIdRetira.AutoSize = True
        Me.LblIdRetira.Location = New System.Drawing.Point(795, 82)
        Me.LblIdRetira.Name = "LblIdRetira"
        Me.LblIdRetira.Size = New System.Drawing.Size(44, 13)
        Me.LblIdRetira.TabIndex = 68
        Me.LblIdRetira.Text = "IdRetira"
        '
        'CBRetira
        '
        Me.CBRetira.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBRetira.FormattingEnabled = True
        Me.CBRetira.Location = New System.Drawing.Point(599, 76)
        Me.CBRetira.Name = "CBRetira"
        Me.CBRetira.Size = New System.Drawing.Size(193, 24)
        Me.CBRetira.TabIndex = 67
        '
        'BtnBuscarClienteRetira
        '
        Me.BtnBuscarClienteRetira.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarClienteRetira.Image = Global.Gestion_Comercial.My.Resources.Resources.BI_find_b2_36
        Me.BtnBuscarClienteRetira.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarClienteRetira.Location = New System.Drawing.Point(850, 67)
        Me.BtnBuscarClienteRetira.Name = "BtnBuscarClienteRetira"
        Me.BtnBuscarClienteRetira.Size = New System.Drawing.Size(106, 42)
        Me.BtnBuscarClienteRetira.TabIndex = 69
        Me.BtnBuscarClienteRetira.Text = "Buscar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "C/Retira"
        Me.BtnBuscarClienteRetira.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscarClienteRetira.UseVisualStyleBackColor = True
        '
        'BtnTotalSeleccionado
        '
        Me.BtnTotalSeleccionado.Location = New System.Drawing.Point(27, 485)
        Me.BtnTotalSeleccionado.Name = "BtnTotalSeleccionado"
        Me.BtnTotalSeleccionado.Size = New System.Drawing.Size(75, 23)
        Me.BtnTotalSeleccionado.TabIndex = 70
        Me.BtnTotalSeleccionado.Text = "Button1"
        Me.BtnTotalSeleccionado.UseVisualStyleBackColor = True
        '
        'TxtSaldo
        '
        Me.TxtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSaldo.Location = New System.Drawing.Point(303, 479)
        Me.TxtSaldo.Name = "TxtSaldo"
        Me.TxtSaldo.Size = New System.Drawing.Size(125, 29)
        Me.TxtSaldo.TabIndex = 72
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(143, 483)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 20)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Saldo depositado:"
        '
        'CheckBCobraCC
        '
        Me.CheckBCobraCC.AutoSize = True
        Me.CheckBCobraCC.Location = New System.Drawing.Point(309, 514)
        Me.CheckBCobraCC.Name = "CheckBCobraCC"
        Me.CheckBCobraCC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBCobraCC.Size = New System.Drawing.Size(115, 17)
        Me.CheckBCobraCC.TabIndex = 73
        Me.CheckBCobraCC.Text = "Paga con deposito"
        Me.CheckBCobraCC.UseVisualStyleBackColor = True
        '
        'CheckBoxTodos
        '
        Me.CheckBoxTodos.AutoSize = True
        Me.CheckBoxTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxTodos.Location = New System.Drawing.Point(12, 115)
        Me.CheckBoxTodos.Name = "CheckBoxTodos"
        Me.CheckBoxTodos.Size = New System.Drawing.Size(67, 20)
        Me.CheckBoxTodos.TabIndex = 74
        Me.CheckBoxTodos.Text = "Todos"
        Me.CheckBoxTodos.UseVisualStyleBackColor = True
        '
        'FrmBusquedaVentaSinPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 540)
        Me.Controls.Add(Me.CheckBoxTodos)
        Me.Controls.Add(Me.CheckBCobraCC)
        Me.Controls.Add(Me.TxtSaldo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnBuscarClienteRetira)
        Me.Controls.Add(Me.LblIdRetira)
        Me.Controls.Add(Me.BtnBuscarCliente)
        Me.Controls.Add(Me.CBRetira)
        Me.Controls.Add(Me.LblIdcliente)
        Me.Controls.Add(Me.CBRazonSocial)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.TxtTotalSelect)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnCobrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DGVVentasCC)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnTotalSeleccionado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.Name = "FrmBusquedaVentaSinPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de articulos vendidos en cuenta corriente"
        CType(Me.DGVVentasCC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVVentasCC As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnCobrar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtTotalSelect As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents CBRazonSocial As System.Windows.Forms.ComboBox
    Friend WithEvents LblIdcliente As System.Windows.Forms.Label
    Friend WithEvents BtnBuscarCliente As System.Windows.Forms.Button
    Friend WithEvents LblIdRetira As System.Windows.Forms.Label
    Friend WithEvents CBRetira As System.Windows.Forms.ComboBox
    Friend WithEvents BtnBuscarClienteRetira As System.Windows.Forms.Button
    Friend WithEvents BtnTotalSeleccionado As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TxtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBCobraCC As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBoxTodos As System.Windows.Forms.CheckBox
End Class
