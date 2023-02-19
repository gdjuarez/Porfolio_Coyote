<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentas
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblIdCliente = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.TxtRazonSocial = New System.Windows.Forms.TextBox()
        Me.BtnBusquedaCliente = New System.Windows.Forms.Button()
        Me.BtnIngreso = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBuscarCodigoBarra = New System.Windows.Forms.TextBox()
        Me.BtnArticulos = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblNumeroPedido = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPresupuesto = New System.Windows.Forms.TextBox()
        Me.DataGridViewIngVenta = New System.Windows.Forms.DataGridView()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnPresupuesto = New System.Windows.Forms.Button()
        Me.DataGridViewBarra = New System.Windows.Forms.DataGridView()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Articulo = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtImagen = New System.Windows.Forms.TextBox()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.TxtArticulo = New System.Windows.Forms.TextBox()
        Me.TxtIdArticulo = New System.Windows.Forms.TextBox()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtStockminimo = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnVenta = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridViewIngVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.LblIdCliente)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.BtnBorrar)
        Me.Panel2.Controls.Add(Me.TxtRazonSocial)
        Me.Panel2.Controls.Add(Me.BtnBusquedaCliente)
        Me.Panel2.Controls.Add(Me.BtnIngreso)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TxtBuscarCodigoBarra)
        Me.Panel2.Controls.Add(Me.BtnArticulos)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
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
        Me.Panel2.Location = New System.Drawing.Point(5, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(736, 156)
        Me.Panel2.TabIndex = 72
        '
        'LblIdCliente
        '
        Me.LblIdCliente.AutoSize = True
        Me.LblIdCliente.ForeColor = System.Drawing.Color.Red
        Me.LblIdCliente.Location = New System.Drawing.Point(424, 11)
        Me.LblIdCliente.Name = "LblIdCliente"
        Me.LblIdCliente.Size = New System.Drawing.Size(60, 13)
        Me.LblIdCliente.TabIndex = 125
        Me.LblIdCliente.Text = "Sin_Cliente"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(524, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 17)
        Me.Label10.TabIndex = 124
        Me.Label10.Text = "Agregar cliente"
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.ForeColor = System.Drawing.Color.Red
        Me.BtnBorrar.Location = New System.Drawing.Point(408, 103)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(288, 40)
        Me.BtnBorrar.TabIndex = 80
        Me.BtnBorrar.Text = "Borrar seleccion de la venta"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'TxtRazonSocial
        '
        Me.TxtRazonSocial.Location = New System.Drawing.Point(424, 30)
        Me.TxtRazonSocial.MaxLength = 13
        Me.TxtRazonSocial.Name = "TxtRazonSocial"
        Me.TxtRazonSocial.Size = New System.Drawing.Size(250, 20)
        Me.TxtRazonSocial.TabIndex = 120
        '
        'BtnBusquedaCliente
        '
        Me.BtnBusquedaCliente.BackgroundImage = Global.Gestion_Comercial.My.Resources.Resources.BI_addP_48
        Me.BtnBusquedaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnBusquedaCliente.Location = New System.Drawing.Point(680, 4)
        Me.BtnBusquedaCliente.Name = "BtnBusquedaCliente"
        Me.BtnBusquedaCliente.Size = New System.Drawing.Size(48, 46)
        Me.BtnBusquedaCliente.TabIndex = 121
        Me.BtnBusquedaCliente.UseVisualStyleBackColor = True
        '
        'BtnIngreso
        '
        Me.BtnIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnIngreso.Location = New System.Drawing.Point(40, 103)
        Me.BtnIngreso.Name = "BtnIngreso"
        Me.BtnIngreso.Size = New System.Drawing.Size(239, 40)
        Me.BtnIngreso.TabIndex = 2
        Me.BtnIngreso.Text = "Ingresar a la venta"
        Me.BtnIngreso.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnIngreso.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(344, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 17)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "Fecha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(79, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Codigo de barras"
        '
        'TxtBuscarCodigoBarra
        '
        Me.TxtBuscarCodigoBarra.Location = New System.Drawing.Point(59, 29)
        Me.TxtBuscarCodigoBarra.MaxLength = 13
        Me.TxtBuscarCodigoBarra.Name = "TxtBuscarCodigoBarra"
        Me.TxtBuscarCodigoBarra.Size = New System.Drawing.Size(250, 20)
        Me.TxtBuscarCodigoBarra.TabIndex = 0
        '
        'BtnArticulos
        '
        Me.BtnArticulos.BackgroundImage = Global.Gestion_Comercial.My.Resources.Resources.BI_addCart_48
        Me.BtnArticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnArticulos.Location = New System.Drawing.Point(5, 3)
        Me.BtnArticulos.Name = "BtnArticulos"
        Me.BtnArticulos.Size = New System.Drawing.Size(48, 46)
        Me.BtnArticulos.TabIndex = 117
        Me.BtnArticulos.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(320, 29)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(95, 20)
        Me.DateTimePicker1.TabIndex = 119
        Me.DateTimePicker1.Value = New Date(2013, 4, 28, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(546, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 17)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "P/Unit."
        '
        'txtprecioUnitario
        '
        Me.txtprecioUnitario.Location = New System.Drawing.Point(548, 74)
        Me.txtprecioUnitario.Name = "txtprecioUnitario"
        Me.txtprecioUnitario.ReadOnly = True
        Me.txtprecioUnitario.Size = New System.Drawing.Size(65, 20)
        Me.txtprecioUnitario.TabIndex = 89
        Me.txtprecioUnitario.Text = "0"
        Me.txtprecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(256, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 17)
        Me.Label13.TabIndex = 85
        Me.Label13.Text = "Articulo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(621, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 17)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "Importe"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(36, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 17)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Cant."
        '
        'TxtImporte
        '
        Me.TxtImporte.Location = New System.Drawing.Point(619, 74)
        Me.TxtImporte.Name = "TxtImporte"
        Me.TxtImporte.ReadOnly = True
        Me.TxtImporte.Size = New System.Drawing.Size(77, 20)
        Me.TxtImporte.TabIndex = 83
        Me.TxtImporte.Text = "0"
        Me.TxtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txtcantidad
        '
        Me.Txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcantidad.Location = New System.Drawing.Point(40, 71)
        Me.Txtcantidad.Name = "Txtcantidad"
        Me.Txtcantidad.Size = New System.Drawing.Size(38, 26)
        Me.Txtcantidad.TabIndex = 1
        Me.Txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txtdescripcion
        '
        Me.Txtdescripcion.Location = New System.Drawing.Point(250, 74)
        Me.Txtdescripcion.Name = "Txtdescripcion"
        Me.Txtdescripcion.ReadOnly = True
        Me.Txtdescripcion.Size = New System.Drawing.Size(292, 20)
        Me.Txtdescripcion.TabIndex = 80
        Me.Txtdescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(96, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Cod."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(268, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Articulo"
        '
        'TxtidProducto
        '
        Me.TxtidProducto.Location = New System.Drawing.Point(84, 74)
        Me.TxtidProducto.Name = "TxtidProducto"
        Me.TxtidProducto.ReadOnly = True
        Me.TxtidProducto.Size = New System.Drawing.Size(160, 20)
        Me.TxtidProducto.TabIndex = 74
        Me.TxtidProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.lblNumeroPedido)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.TxtPresupuesto)
        Me.Panel3.Controls.Add(Me.DataGridViewIngVenta)
        Me.Panel3.Controls.Add(Me.BtnPresupuesto)
        Me.Panel3.Controls.Add(Me.DataGridViewBarra)
        Me.Panel3.Location = New System.Drawing.Point(5, 171)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(736, 385)
        Me.Panel3.TabIndex = 73
        '
        'lblNumeroPedido
        '
        Me.lblNumeroPedido.AutoSize = True
        Me.lblNumeroPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroPedido.Location = New System.Drawing.Point(492, 18)
        Me.lblNumeroPedido.Name = "lblNumeroPedido"
        Me.lblNumeroPedido.Size = New System.Drawing.Size(25, 16)
        Me.lblNumeroPedido.TabIndex = 79
        Me.lblNumeroPedido.Text = " n°"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(54, 3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(161, 17)
        Me.Label11.TabIndex = 114
        Me.Label11.Text = "Agregar presupuesto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(244, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 16)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Articulos ingresados a la Venta n°:"
        '
        'TxtPresupuesto
        '
        Me.TxtPresupuesto.Location = New System.Drawing.Point(57, 24)
        Me.TxtPresupuesto.MaxLength = 13
        Me.TxtPresupuesto.Name = "TxtPresupuesto"
        Me.TxtPresupuesto.ReadOnly = True
        Me.TxtPresupuesto.Size = New System.Drawing.Size(118, 20)
        Me.TxtPresupuesto.TabIndex = 113
        '
        'DataGridViewIngVenta
        '
        Me.DataGridViewIngVenta.AllowUserToAddRows = False
        Me.DataGridViewIngVenta.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        Me.DataGridViewIngVenta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewIngVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewIngVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewIngVenta.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewIngVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewIngVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewIngVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Column2, Me.Column3, Me.Column4, Me.Importe})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewIngVenta.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewIngVenta.Location = New System.Drawing.Point(5, 55)
        Me.DataGridViewIngVenta.Name = "DataGridViewIngVenta"
        Me.DataGridViewIngVenta.ReadOnly = True
        Me.DataGridViewIngVenta.RowHeadersVisible = False
        Me.DataGridViewIngVenta.RowHeadersWidth = 144
        Me.DataGridViewIngVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewIngVenta.Size = New System.Drawing.Size(723, 323)
        Me.DataGridViewIngVenta.TabIndex = 77
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "Cantidad"
        Me.Cantidad.FillWeight = 76.14214!
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Codigo"
        Me.Column2.FillWeight = 105.9645!
        Me.Column2.HeaderText = "Codigo"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Detalle"
        Me.Column3.FillWeight = 105.9645!
        Me.Column3.HeaderText = "Detalle"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "PrecioUnitario"
        Me.Column4.FillWeight = 105.9645!
        Me.Column4.HeaderText = "P/Unit."
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Importe
        '
        Me.Importe.DataPropertyName = "Importe"
        Me.Importe.FillWeight = 105.9645!
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        '
        'BtnPresupuesto
        '
        Me.BtnPresupuesto.BackgroundImage = Global.Gestion_Comercial.My.Resources.Resources.BI_list_48
        Me.BtnPresupuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnPresupuesto.Location = New System.Drawing.Point(5, 3)
        Me.BtnPresupuesto.Name = "BtnPresupuesto"
        Me.BtnPresupuesto.Size = New System.Drawing.Size(48, 48)
        Me.BtnPresupuesto.TabIndex = 112
        Me.BtnPresupuesto.UseVisualStyleBackColor = True
        '
        'DataGridViewBarra
        '
        Me.DataGridViewBarra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBarra.Enabled = False
        Me.DataGridViewBarra.Location = New System.Drawing.Point(65, 152)
        Me.DataGridViewBarra.Name = "DataGridViewBarra"
        Me.DataGridViewBarra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewBarra.Size = New System.Drawing.Size(519, 64)
        Me.DataGridViewBarra.TabIndex = 107
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(580, 566)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(155, 35)
        Me.TxtTotal.TabIndex = 84
        Me.TxtTotal.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(481, 569)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 29)
        Me.Label16.TabIndex = 89
        Me.Label16.Text = "Total: $"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(198, 501)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 29)
        Me.Label15.TabIndex = 100
        Me.Label15.Text = "Precio"
        '
        'TxtPrecioVenta
        '
        Me.TxtPrecioVenta.Enabled = False
        Me.TxtPrecioVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecioVenta.Location = New System.Drawing.Point(175, 533)
        Me.TxtPrecioVenta.Name = "TxtPrecioVenta"
        Me.TxtPrecioVenta.ReadOnly = True
        Me.TxtPrecioVenta.Size = New System.Drawing.Size(125, 35)
        Me.TxtPrecioVenta.TabIndex = 99
        Me.TxtPrecioVenta.Text = "0.00"
        Me.TxtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(26, 432)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 16)
        Me.Label17.TabIndex = 98
        Me.Label17.Text = "Marca"
        '
        'Articulo
        '
        Me.Articulo.AutoSize = True
        Me.Articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Articulo.Location = New System.Drawing.Point(26, 362)
        Me.Articulo.Name = "Articulo"
        Me.Articulo.Size = New System.Drawing.Size(60, 16)
        Me.Articulo.TabIndex = 96
        Me.Articulo.Text = "Articulo"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(13, 295)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 16)
        Me.Label20.TabIndex = 95
        Me.Label20.Text = "Codigo:"
        '
        'TxtImagen
        '
        Me.TxtImagen.Enabled = False
        Me.TxtImagen.Location = New System.Drawing.Point(67, 23)
        Me.TxtImagen.Name = "TxtImagen"
        Me.TxtImagen.ReadOnly = True
        Me.TxtImagen.Size = New System.Drawing.Size(175, 20)
        Me.TxtImagen.TabIndex = 94
        Me.TxtImagen.Visible = False
        '
        'TxtMarca
        '
        Me.TxtMarca.Enabled = False
        Me.TxtMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMarca.Location = New System.Drawing.Point(9, 452)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.ReadOnly = True
        Me.TxtMarca.Size = New System.Drawing.Size(283, 35)
        Me.TxtMarca.TabIndex = 93
        Me.TxtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtArticulo
        '
        Me.TxtArticulo.Enabled = False
        Me.TxtArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtArticulo.Location = New System.Drawing.Point(9, 382)
        Me.TxtArticulo.Name = "TxtArticulo"
        Me.TxtArticulo.ReadOnly = True
        Me.TxtArticulo.Size = New System.Drawing.Size(283, 35)
        Me.TxtArticulo.TabIndex = 91
        Me.TxtArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtIdArticulo
        '
        Me.TxtIdArticulo.Enabled = False
        Me.TxtIdArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.TxtIdArticulo.Location = New System.Drawing.Point(9, 314)
        Me.TxtIdArticulo.MaxLength = 13
        Me.TxtIdArticulo.Name = "TxtIdArticulo"
        Me.TxtIdArticulo.ReadOnly = True
        Me.TxtIdArticulo.Size = New System.Drawing.Size(283, 35)
        Me.TxtIdArticulo.TabIndex = 90
        Me.TxtIdArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtStock
        '
        Me.TxtStock.Enabled = False
        Me.TxtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.TxtStock.Location = New System.Drawing.Point(9, 533)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.ReadOnly = True
        Me.TxtStock.Size = New System.Drawing.Size(52, 35)
        Me.TxtStock.TabIndex = 102
        Me.TxtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(12, 513)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 16)
        Me.Label18.TabIndex = 103
        Me.Label18.Text = "Stock"
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
        Me.Panel4.Location = New System.Drawing.Point(747, 7)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(312, 604)
        Me.Panel4.TabIndex = 105
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 513)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Stock-Minimo"
        '
        'TxtStockminimo
        '
        Me.TxtStockminimo.Enabled = False
        Me.TxtStockminimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.TxtStockminimo.Location = New System.Drawing.Point(78, 533)
        Me.TxtStockminimo.Name = "TxtStockminimo"
        Me.TxtStockminimo.ReadOnly = True
        Me.TxtStockminimo.Size = New System.Drawing.Size(86, 35)
        Me.TxtStockminimo.TabIndex = 106
        Me.TxtStockminimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(29, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 250)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 101
        Me.PictureBox1.TabStop = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCancelar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.Gestion_Comercial.My.Resources.Resources.BI_cancel_48
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(209, 561)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(170, 48)
        Me.BtnCancelar.TabIndex = 107
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnVenta
        '
        Me.BtnVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnVenta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVenta.Image = Global.Gestion_Comercial.My.Resources.Resources.BI_save_48
        Me.BtnVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVenta.Location = New System.Drawing.Point(13, 562)
        Me.BtnVenta.Name = "BtnVenta"
        Me.BtnVenta.Size = New System.Drawing.Size(170, 48)
        Me.BtnVenta.TabIndex = 4
        Me.BtnVenta.Text = "Aceptar"
        Me.BtnVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnVenta.UseVisualStyleBackColor = True
        '
        'FrmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1064, 613)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnVenta)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FrmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridViewIngVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewBarra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtidProducto As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewIngVenta As System.Windows.Forms.DataGridView
    Friend WithEvents Txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents BtnIngreso As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblNumeroPedido As System.Windows.Forms.Label
    Friend WithEvents txtprecioUnitario As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents BtnBorrar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtPrecioVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Articulo As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TxtImagen As System.Windows.Forms.TextBox
    Friend WithEvents TxtMarca As System.Windows.Forms.TextBox
    Friend WithEvents TxtArticulo As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdArticulo As System.Windows.Forms.TextBox
    Friend WithEvents TxtStock As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtStockminimo As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewBarra As System.Windows.Forms.DataGridView
    Friend WithEvents BtnVenta As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtPresupuesto As System.Windows.Forms.TextBox
    Friend WithEvents BtnPresupuesto As System.Windows.Forms.Button
    Friend WithEvents LblIdCliente As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents BtnBusquedaCliente As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtBuscarCodigoBarra As System.Windows.Forms.TextBox
    Friend WithEvents BtnArticulos As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
End Class
