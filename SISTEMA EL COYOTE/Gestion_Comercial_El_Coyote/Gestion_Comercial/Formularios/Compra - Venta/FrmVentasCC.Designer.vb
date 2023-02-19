<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentasCC
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtprecioUnitario = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtImporte = New System.Windows.Forms.TextBox()
        Me.Txtcantidad = New System.Windows.Forms.TextBox()
        Me.Txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtidProducto = New System.Windows.Forms.TextBox()
        Me.LblDNIretira = New System.Windows.Forms.Label()
        Me.CBRetira = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BtnIngreso = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.TxtBuscarCodigoBarra = New System.Windows.Forms.TextBox()
        Me.BtnBusquedaVendedores = New System.Windows.Forms.Button()
        Me.LblIdCliente = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnArticulos = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridViewIngVentaCC = New System.Windows.Forms.DataGridView()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNumeroPedido = New System.Windows.Forms.Label()
        Me.DataGridViewBarra = New System.Windows.Forms.DataGridView()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtStockminimo = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtImagen = New System.Windows.Forms.TextBox()
        Me.TxtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtArticulo = New System.Windows.Forms.TextBox()
        Me.Articulo = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtIdArticulo = New System.Windows.Forms.TextBox()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnConfirmar = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridViewIngVentaCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtprecioUnitario)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.TxtImporte)
        Me.Panel2.Controls.Add(Me.Txtcantidad)
        Me.Panel2.Controls.Add(Me.Txtdescripcion)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TxtidProducto)
        Me.Panel2.Controls.Add(Me.LblDNIretira)
        Me.Panel2.Controls.Add(Me.CBRetira)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.BtnIngreso)
        Me.Panel2.Controls.Add(Me.BtnBorrar)
        Me.Panel2.Controls.Add(Me.TxtBuscarCodigoBarra)
        Me.Panel2.Controls.Add(Me.BtnBusquedaVendedores)
        Me.Panel2.Controls.Add(Me.LblIdCliente)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.TxtCliente)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.BtnArticulos)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Location = New System.Drawing.Point(10, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(840, 162)
        Me.Panel2.TabIndex = 72
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(640, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 17)
        Me.Label8.TabIndex = 141
        Me.Label8.Text = "P/Unit."
        '
        'txtprecioUnitario
        '
        Me.txtprecioUnitario.Location = New System.Drawing.Point(642, 80)
        Me.txtprecioUnitario.Name = "txtprecioUnitario"
        Me.txtprecioUnitario.ReadOnly = True
        Me.txtprecioUnitario.Size = New System.Drawing.Size(65, 20)
        Me.txtprecioUnitario.TabIndex = 140
        Me.txtprecioUnitario.Text = "0"
        Me.txtprecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(264, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 17)
        Me.Label13.TabIndex = 138
        Me.Label13.Text = "Articulo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(737, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 17)
        Me.Label9.TabIndex = 139
        Me.Label9.Text = "Importe"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(44, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 17)
        Me.Label7.TabIndex = 137
        Me.Label7.Text = "Cant."
        '
        'TxtImporte
        '
        Me.TxtImporte.Location = New System.Drawing.Point(735, 80)
        Me.TxtImporte.Name = "TxtImporte"
        Me.TxtImporte.ReadOnly = True
        Me.TxtImporte.Size = New System.Drawing.Size(77, 20)
        Me.TxtImporte.TabIndex = 136
        Me.TxtImporte.Text = "0"
        Me.TxtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txtcantidad
        '
        Me.Txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcantidad.Location = New System.Drawing.Point(48, 77)
        Me.Txtcantidad.Name = "Txtcantidad"
        Me.Txtcantidad.Size = New System.Drawing.Size(38, 26)
        Me.Txtcantidad.TabIndex = 3
        Me.Txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txtdescripcion
        '
        Me.Txtdescripcion.Location = New System.Drawing.Point(258, 80)
        Me.Txtdescripcion.Name = "Txtdescripcion"
        Me.Txtdescripcion.ReadOnly = True
        Me.Txtdescripcion.Size = New System.Drawing.Size(378, 20)
        Me.Txtdescripcion.TabIndex = 135
        Me.Txtdescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(104, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 134
        Me.Label4.Text = "Cod."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(276, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "Articulo"
        '
        'TxtidProducto
        '
        Me.TxtidProducto.Location = New System.Drawing.Point(92, 80)
        Me.TxtidProducto.Name = "TxtidProducto"
        Me.TxtidProducto.ReadOnly = True
        Me.TxtidProducto.Size = New System.Drawing.Size(160, 20)
        Me.TxtidProducto.TabIndex = 5
        Me.TxtidProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblDNIretira
        '
        Me.LblDNIretira.AutoSize = True
        Me.LblDNIretira.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.LblDNIretira.ForeColor = System.Drawing.Color.Red
        Me.LblDNIretira.Location = New System.Drawing.Point(322, 11)
        Me.LblDNIretira.Name = "LblDNIretira"
        Me.LblDNIretira.Size = New System.Drawing.Size(70, 16)
        Me.LblDNIretira.TabIndex = 130
        Me.LblDNIretira.Text = "Sin_Retira"
        Me.LblDNIretira.Visible = False
        '
        'CBRetira
        '
        Me.CBRetira.FormattingEnabled = True
        Me.CBRetira.Location = New System.Drawing.Point(325, 34)
        Me.CBRetira.Name = "CBRetira"
        Me.CBRetira.Size = New System.Drawing.Size(202, 21)
        Me.CBRetira.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.Location = New System.Drawing.Point(399, 12)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 17)
        Me.Label21.TabIndex = 128
        Me.Label21.Text = "Retira"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(89, 14)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(133, 17)
        Me.Label19.TabIndex = 126
        Me.Label19.Text = "Codigo de barras"
        '
        'BtnIngreso
        '
        Me.BtnIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnIngreso.Location = New System.Drawing.Point(29, 115)
        Me.BtnIngreso.Name = "BtnIngreso"
        Me.BtnIngreso.Size = New System.Drawing.Size(290, 40)
        Me.BtnIngreso.TabIndex = 4
        Me.BtnIngreso.Text = "Ingresar a la cuenta"
        Me.BtnIngreso.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnIngreso.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.ForeColor = System.Drawing.Color.Red
        Me.BtnBorrar.Location = New System.Drawing.Point(526, 110)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(304, 40)
        Me.BtnBorrar.TabIndex = 80
        Me.BtnBorrar.Text = "Borrar seleccion "
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'TxtBuscarCodigoBarra
        '
        Me.TxtBuscarCodigoBarra.Location = New System.Drawing.Point(69, 34)
        Me.TxtBuscarCodigoBarra.MaxLength = 13
        Me.TxtBuscarCodigoBarra.Name = "TxtBuscarCodigoBarra"
        Me.TxtBuscarCodigoBarra.Size = New System.Drawing.Size(250, 20)
        Me.TxtBuscarCodigoBarra.TabIndex = 2
        '
        'BtnBusquedaVendedores
        '
        Me.BtnBusquedaVendedores.BackgroundImage = Global.Gestion_Comercial.My.Resources.Resources.BI_addP_48
        Me.BtnBusquedaVendedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnBusquedaVendedores.Location = New System.Drawing.Point(782, 8)
        Me.BtnBusquedaVendedores.Name = "BtnBusquedaVendedores"
        Me.BtnBusquedaVendedores.Size = New System.Drawing.Size(48, 48)
        Me.BtnBusquedaVendedores.TabIndex = 0
        Me.BtnBusquedaVendedores.UseVisualStyleBackColor = True
        '
        'LblIdCliente
        '
        Me.LblIdCliente.AutoSize = True
        Me.LblIdCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.LblIdCliente.ForeColor = System.Drawing.Color.Red
        Me.LblIdCliente.Location = New System.Drawing.Point(536, 13)
        Me.LblIdCliente.Name = "LblIdCliente"
        Me.LblIdCliente.Size = New System.Drawing.Size(75, 16)
        Me.LblIdCliente.TabIndex = 123
        Me.LblIdCliente.Text = "Sin_Cliente"
        Me.LblIdCliente.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(626, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 17)
        Me.Label10.TabIndex = 122
        Me.Label10.Text = "Agregar cliente"
        '
        'TxtCliente
        '
        Me.TxtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TxtCliente.Location = New System.Drawing.Point(533, 33)
        Me.TxtCliente.MaxLength = 13
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(243, 22)
        Me.TxtCliente.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(394, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 17)
        Me.Label6.TabIndex = 121
        Me.Label6.Text = "Fecha"
        '
        'BtnArticulos
        '
        Me.BtnArticulos.BackgroundImage = Global.Gestion_Comercial.My.Resources.Resources.BI_addCart_48
        Me.BtnArticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnArticulos.Location = New System.Drawing.Point(11, 8)
        Me.BtnArticulos.Name = "BtnArticulos"
        Me.BtnArticulos.Size = New System.Drawing.Size(48, 48)
        Me.BtnArticulos.TabIndex = 120
        Me.BtnArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnArticulos.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(373, 128)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(95, 22)
        Me.DateTimePicker1.TabIndex = 118
        Me.DateTimePicker1.Value = New Date(2013, 4, 28, 0, 0, 0, 0)
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.DataGridViewIngVentaCC)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.lblNumeroPedido)
        Me.Panel3.Controls.Add(Me.DataGridViewBarra)
        Me.Panel3.Location = New System.Drawing.Point(10, 168)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(840, 385)
        Me.Panel3.TabIndex = 73
        '
        'DataGridViewIngVentaCC
        '
        Me.DataGridViewIngVentaCC.AllowUserToAddRows = False
        Me.DataGridViewIngVentaCC.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewIngVentaCC.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewIngVentaCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewIngVentaCC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewIngVentaCC.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridViewIngVentaCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewIngVentaCC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Column2, Me.Column3, Me.Column4, Me.Importe})
        Me.DataGridViewIngVentaCC.Location = New System.Drawing.Point(3, 37)
        Me.DataGridViewIngVentaCC.Name = "DataGridViewIngVentaCC"
        Me.DataGridViewIngVentaCC.ReadOnly = True
        Me.DataGridViewIngVentaCC.RowHeadersVisible = False
        Me.DataGridViewIngVentaCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewIngVentaCC.Size = New System.Drawing.Size(830, 323)
        Me.DataGridViewIngVentaCC.TabIndex = 116
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "Cantidad"
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Codigo"
        Me.Column2.HeaderText = "Codigo"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Detalle"
        Me.Column3.HeaderText = "Detalle"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "PrecioUnitario"
        Me.Column4.HeaderText = "P/Unit."
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Importe
        '
        Me.Importe.DataPropertyName = "Importe"
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(281, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(259, 16)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Articulos ingresados a la Cta. Cte n°:"
        '
        'lblNumeroPedido
        '
        Me.lblNumeroPedido.AutoSize = True
        Me.lblNumeroPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroPedido.Location = New System.Drawing.Point(540, 17)
        Me.lblNumeroPedido.Name = "lblNumeroPedido"
        Me.lblNumeroPedido.Size = New System.Drawing.Size(25, 16)
        Me.lblNumeroPedido.TabIndex = 79
        Me.lblNumeroPedido.Text = " n°"
        '
        'DataGridViewBarra
        '
        Me.DataGridViewBarra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBarra.Enabled = False
        Me.DataGridViewBarra.Location = New System.Drawing.Point(159, 158)
        Me.DataGridViewBarra.Name = "DataGridViewBarra"
        Me.DataGridViewBarra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewBarra.Size = New System.Drawing.Size(519, 64)
        Me.DataGridViewBarra.TabIndex = 115
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(634, 562)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(221, 35)
        Me.TxtTotal.TabIndex = 84
        Me.TxtTotal.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(535, 565)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 29)
        Me.Label16.TabIndex = 89
        Me.Label16.Text = "Total: $"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.TxtStockminimo)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.TxtImagen)
        Me.Panel4.Controls.Add(Me.TxtPrecioVenta)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.TxtMarca)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.TxtArticulo)
        Me.Panel4.Controls.Add(Me.Articulo)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.TxtIdArticulo)
        Me.Panel4.Controls.Add(Me.TxtStock)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Location = New System.Drawing.Point(861, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(310, 608)
        Me.Panel4.TabIndex = 105
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 523)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "Stock-Minimo"
        '
        'TxtStockminimo
        '
        Me.TxtStockminimo.Enabled = False
        Me.TxtStockminimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.TxtStockminimo.Location = New System.Drawing.Point(77, 543)
        Me.TxtStockminimo.Name = "TxtStockminimo"
        Me.TxtStockminimo.ReadOnly = True
        Me.TxtStockminimo.Size = New System.Drawing.Size(86, 35)
        Me.TxtStockminimo.TabIndex = 120
        Me.TxtStockminimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(28, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 250)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 116
        Me.PictureBox1.TabStop = False
        '
        'TxtImagen
        '
        Me.TxtImagen.Enabled = False
        Me.TxtImagen.Location = New System.Drawing.Point(66, 33)
        Me.TxtImagen.Name = "TxtImagen"
        Me.TxtImagen.ReadOnly = True
        Me.TxtImagen.Size = New System.Drawing.Size(175, 20)
        Me.TxtImagen.TabIndex = 110
        Me.TxtImagen.Visible = False
        '
        'TxtPrecioVenta
        '
        Me.TxtPrecioVenta.Enabled = False
        Me.TxtPrecioVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecioVenta.Location = New System.Drawing.Point(174, 543)
        Me.TxtPrecioVenta.Name = "TxtPrecioVenta"
        Me.TxtPrecioVenta.ReadOnly = True
        Me.TxtPrecioVenta.Size = New System.Drawing.Size(125, 35)
        Me.TxtPrecioVenta.TabIndex = 114
        Me.TxtPrecioVenta.Text = "0.00"
        Me.TxtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(197, 511)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 29)
        Me.Label15.TabIndex = 115
        Me.Label15.Text = "Precio"
        '
        'TxtMarca
        '
        Me.TxtMarca.Enabled = False
        Me.TxtMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMarca.Location = New System.Drawing.Point(8, 462)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.ReadOnly = True
        Me.TxtMarca.Size = New System.Drawing.Size(283, 35)
        Me.TxtMarca.TabIndex = 109
        Me.TxtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(25, 442)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 16)
        Me.Label17.TabIndex = 113
        Me.Label17.Text = "Marca"
        '
        'TxtArticulo
        '
        Me.TxtArticulo.Enabled = False
        Me.TxtArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtArticulo.Location = New System.Drawing.Point(8, 392)
        Me.TxtArticulo.Name = "TxtArticulo"
        Me.TxtArticulo.ReadOnly = True
        Me.TxtArticulo.Size = New System.Drawing.Size(283, 35)
        Me.TxtArticulo.TabIndex = 108
        Me.TxtArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Articulo
        '
        Me.Articulo.AutoSize = True
        Me.Articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Articulo.Location = New System.Drawing.Point(25, 372)
        Me.Articulo.Name = "Articulo"
        Me.Articulo.Size = New System.Drawing.Size(60, 16)
        Me.Articulo.TabIndex = 112
        Me.Articulo.Text = "Articulo"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(11, 523)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 16)
        Me.Label18.TabIndex = 118
        Me.Label18.Text = "Stock"
        '
        'TxtIdArticulo
        '
        Me.TxtIdArticulo.Enabled = False
        Me.TxtIdArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.TxtIdArticulo.Location = New System.Drawing.Point(8, 324)
        Me.TxtIdArticulo.MaxLength = 13
        Me.TxtIdArticulo.Name = "TxtIdArticulo"
        Me.TxtIdArticulo.ReadOnly = True
        Me.TxtIdArticulo.Size = New System.Drawing.Size(283, 35)
        Me.TxtIdArticulo.TabIndex = 107
        Me.TxtIdArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtStock
        '
        Me.TxtStock.Enabled = False
        Me.TxtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.TxtStock.Location = New System.Drawing.Point(8, 543)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.ReadOnly = True
        Me.TxtStock.Size = New System.Drawing.Size(52, 35)
        Me.TxtStock.TabIndex = 117
        Me.TxtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(12, 305)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 16)
        Me.Label20.TabIndex = 111
        Me.Label20.Text = "Codigo:"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCancelar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.Gestion_Comercial.My.Resources.Resources.BI_cancel_48
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(192, 557)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(170, 48)
        Me.BtnCancelar.TabIndex = 107
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnConfirmar
        '
        Me.BtnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnConfirmar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmar.Image = Global.Gestion_Comercial.My.Resources.Resources.BI_save_48
        Me.BtnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConfirmar.Location = New System.Drawing.Point(10, 557)
        Me.BtnConfirmar.Name = "BtnConfirmar"
        Me.BtnConfirmar.Size = New System.Drawing.Size(170, 48)
        Me.BtnConfirmar.TabIndex = 0
        Me.BtnConfirmar.Text = "Confirmar"
        Me.BtnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnConfirmar.UseVisualStyleBackColor = True
        '
        'FrmVentasCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1179, 613)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.BtnConfirmar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FrmVentasCC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Ventas a Cuenta Corriente"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridViewIngVentaCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewBarra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnConfirmar As System.Windows.Forms.Button
    Friend WithEvents BtnIngreso As System.Windows.Forms.Button
    Friend WithEvents lblNumeroPedido As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents BtnBorrar As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnBusquedaVendedores As System.Windows.Forms.Button
    Friend WithEvents LblIdCliente As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnArticulos As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtBuscarCodigoBarra As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents CBRetira As System.Windows.Forms.ComboBox
    Friend WithEvents LblDNIretira As System.Windows.Forms.Label
    Friend WithEvents DataGridViewBarra As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtStockminimo As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtImagen As TextBox
    Friend WithEvents TxtPrecioVenta As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtMarca As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtArticulo As TextBox
    Friend WithEvents Articulo As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtIdArticulo As TextBox
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents DataGridViewIngVentaCC As DataGridView
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents txtprecioUnitario As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtImporte As TextBox
    Friend WithEvents Txtcantidad As TextBox
    Friend WithEvents Txtdescripcion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtidProducto As TextBox
End Class
