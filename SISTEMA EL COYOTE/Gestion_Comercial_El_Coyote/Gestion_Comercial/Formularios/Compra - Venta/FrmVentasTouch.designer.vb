<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentasTouch
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVentasTouch))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblIdCliente = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtRazonSocial = New System.Windows.Forms.TextBox()
        Me.BtnBusquedaCliente = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBuscarCodigoBarra = New System.Windows.Forms.TextBox()
        Me.BtnArticulos = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TxtImporte = New System.Windows.Forms.TextBox()
        Me.Txtdescripcion = New System.Windows.Forms.TextBox()
        Me.TxtidProducto = New System.Windows.Forms.TextBox()
        Me.txtprecioUnitario = New System.Windows.Forms.TextBox()
        Me.Txtcantidad = New System.Windows.Forms.TextBox()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnIngreso = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridViewIngVenta = New System.Windows.Forms.DataGridView()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Detalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Articulo = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.TxtArticulo = New System.Windows.Forms.TextBox()
        Me.TxtIdArticulo = New System.Windows.Forms.TextBox()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtStockminimo = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnVenta = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnC = New System.Windows.Forms.Button()
        Me.BtnEnter = New System.Windows.Forms.Button()
        Me.BtnFlechaAbajo = New System.Windows.Forms.Button()
        Me.BtnFlechaArriba = New System.Windows.Forms.Button()
        Me.BtnCero = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.Btn9 = New System.Windows.Forms.Button()
        Me.Btn8 = New System.Windows.Forms.Button()
        Me.Btn7 = New System.Windows.Forms.Button()
        Me.Lblseleccionado = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridViewIngVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.LblIdCliente)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.TxtRazonSocial)
        Me.Panel2.Controls.Add(Me.BtnBusquedaCliente)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TxtBuscarCodigoBarra)
        Me.Panel2.Controls.Add(Me.BtnArticulos)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Location = New System.Drawing.Point(5, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(736, 86)
        Me.Panel2.TabIndex = 72
        '
        'LblIdCliente
        '
        Me.LblIdCliente.AutoSize = True
        Me.LblIdCliente.ForeColor = System.Drawing.Color.Red
        Me.LblIdCliente.Location = New System.Drawing.Point(432, 13)
        Me.LblIdCliente.Name = "LblIdCliente"
        Me.LblIdCliente.Size = New System.Drawing.Size(60, 13)
        Me.LblIdCliente.TabIndex = 125
        Me.LblIdCliente.Text = "Sin_Cliente"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(524, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 17)
        Me.Label10.TabIndex = 124
        Me.Label10.Text = "Agregar cliente"
        '
        'TxtRazonSocial
        '
        Me.TxtRazonSocial.Location = New System.Drawing.Point(421, 30)
        Me.TxtRazonSocial.MaxLength = 13
        Me.TxtRazonSocial.Name = "TxtRazonSocial"
        Me.TxtRazonSocial.Size = New System.Drawing.Size(250, 20)
        Me.TxtRazonSocial.TabIndex = 120
        '
        'BtnBusquedaCliente
        '
        Me.BtnBusquedaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnBusquedaCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBusquedaCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBusquedaCliente.Image = Global.Gestion_Comercial.My.Resources.Resources.BI_find_b2_36
        Me.BtnBusquedaCliente.Location = New System.Drawing.Point(677, 7)
        Me.BtnBusquedaCliente.Name = "BtnBusquedaCliente"
        Me.BtnBusquedaCliente.Size = New System.Drawing.Size(51, 56)
        Me.BtnBusquedaCliente.TabIndex = 121
        Me.BtnBusquedaCliente.Text = "(F6)"
        Me.BtnBusquedaCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBusquedaCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnBusquedaCliente.UseVisualStyleBackColor = True
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
        Me.Label5.Location = New System.Drawing.Point(90, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Codigo de barras"
        '
        'TxtBuscarCodigoBarra
        '
        Me.TxtBuscarCodigoBarra.Location = New System.Drawing.Point(82, 29)
        Me.TxtBuscarCodigoBarra.MaxLength = 13
        Me.TxtBuscarCodigoBarra.Name = "TxtBuscarCodigoBarra"
        Me.TxtBuscarCodigoBarra.Size = New System.Drawing.Size(227, 20)
        Me.TxtBuscarCodigoBarra.TabIndex = 1
        '
        'BtnArticulos
        '
        Me.BtnArticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnArticulos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnArticulos.Image = Global.Gestion_Comercial.My.Resources.Resources.BI_addCart_48
        Me.BtnArticulos.Location = New System.Drawing.Point(8, 5)
        Me.BtnArticulos.Name = "BtnArticulos"
        Me.BtnArticulos.Size = New System.Drawing.Size(68, 68)
        Me.BtnArticulos.TabIndex = 0
        Me.BtnArticulos.Text = "(F5)"
        Me.BtnArticulos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnArticulos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'TxtImporte
        '
        Me.TxtImporte.BackColor = System.Drawing.Color.White
        Me.TxtImporte.Location = New System.Drawing.Point(411, 40)
        Me.TxtImporte.Name = "TxtImporte"
        Me.TxtImporte.ReadOnly = True
        Me.TxtImporte.Size = New System.Drawing.Size(77, 20)
        Me.TxtImporte.TabIndex = 83
        Me.TxtImporte.Text = "0"
        Me.TxtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtImporte.Visible = False
        '
        'Txtdescripcion
        '
        Me.Txtdescripcion.BackColor = System.Drawing.Color.White
        Me.Txtdescripcion.Location = New System.Drawing.Point(237, 40)
        Me.Txtdescripcion.Name = "Txtdescripcion"
        Me.Txtdescripcion.ReadOnly = True
        Me.Txtdescripcion.Size = New System.Drawing.Size(59, 20)
        Me.Txtdescripcion.TabIndex = 80
        Me.Txtdescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Txtdescripcion.Visible = False
        '
        'TxtidProducto
        '
        Me.TxtidProducto.BackColor = System.Drawing.Color.White
        Me.TxtidProducto.Location = New System.Drawing.Point(155, 39)
        Me.TxtidProducto.Name = "TxtidProducto"
        Me.TxtidProducto.ReadOnly = True
        Me.TxtidProducto.Size = New System.Drawing.Size(65, 20)
        Me.TxtidProducto.TabIndex = 74
        Me.TxtidProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtidProducto.Visible = False
        '
        'txtprecioUnitario
        '
        Me.txtprecioUnitario.BackColor = System.Drawing.Color.White
        Me.txtprecioUnitario.Location = New System.Drawing.Point(322, 40)
        Me.txtprecioUnitario.Name = "txtprecioUnitario"
        Me.txtprecioUnitario.ReadOnly = True
        Me.txtprecioUnitario.Size = New System.Drawing.Size(65, 20)
        Me.txtprecioUnitario.TabIndex = 89
        Me.txtprecioUnitario.Text = "0"
        Me.txtprecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtprecioUnitario.Visible = False
        '
        'Txtcantidad
        '
        Me.Txtcantidad.BackColor = System.Drawing.Color.White
        Me.Txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcantidad.Location = New System.Drawing.Point(97, 34)
        Me.Txtcantidad.Name = "Txtcantidad"
        Me.Txtcantidad.Size = New System.Drawing.Size(38, 26)
        Me.Txtcantidad.TabIndex = 1
        Me.Txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Txtcantidad.Visible = False
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.ForeColor = System.Drawing.Color.Red
        Me.BtnBorrar.Location = New System.Drawing.Point(274, 259)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(168, 54)
        Me.BtnBorrar.TabIndex = 80
        Me.BtnBorrar.Text = "Borrar seleccion" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        Me.BtnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnIngreso
        '
        Me.BtnIngreso.AutoEllipsis = True
        Me.BtnIngreso.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnIngreso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngreso.Image = Global.Gestion_Comercial.My.Resources.Resources.BI_add2_36
        Me.BtnIngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnIngreso.Location = New System.Drawing.Point(139, 325)
        Me.BtnIngreso.Name = "BtnIngreso"
        Me.BtnIngreso.Size = New System.Drawing.Size(208, 55)
        Me.BtnIngreso.TabIndex = 2
        Me.BtnIngreso.Text = "Ingresar Articulo"
        Me.BtnIngreso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnIngreso.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.DataGridViewIngVenta)
        Me.Panel3.Location = New System.Drawing.Point(5, 98)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(736, 465)
        Me.Panel3.TabIndex = 73
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewIngVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewIngVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewIngVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Codigo, Me.Detalle, Me.PrecioUnitario, Me.Importe, Me.stock})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewIngVenta.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewIngVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewIngVenta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DataGridViewIngVenta.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewIngVenta.MultiSelect = False
        Me.DataGridViewIngVenta.Name = "DataGridViewIngVenta"
        Me.DataGridViewIngVenta.RowHeadersVisible = False
        Me.DataGridViewIngVenta.RowHeadersWidth = 144
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewIngVenta.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewIngVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewIngVenta.Size = New System.Drawing.Size(732, 461)
        Me.DataGridViewIngVenta.TabIndex = 0
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Cantidad.DataPropertyName = "Cantidad"
        Me.Cantidad.FillWeight = 76.14214!
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 80
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 97
        '
        'Codigo
        '
        Me.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.FillWeight = 105.9645!
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.MaxInputLength = 13
        Me.Codigo.MinimumWidth = 100
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Detalle
        '
        Me.Detalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Detalle.DataPropertyName = "Detalle"
        Me.Detalle.FillWeight = 105.9645!
        Me.Detalle.HeaderText = "Detalle"
        Me.Detalle.MinimumWidth = 350
        Me.Detalle.Name = "Detalle"
        Me.Detalle.ReadOnly = True
        '
        'PrecioUnitario
        '
        Me.PrecioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PrecioUnitario.DataPropertyName = "PrecioUnitario"
        Me.PrecioUnitario.FillWeight = 105.9645!
        Me.PrecioUnitario.HeaderText = "P/Unit."
        Me.PrecioUnitario.MinimumWidth = 100
        Me.PrecioUnitario.Name = "PrecioUnitario"
        Me.PrecioUnitario.ReadOnly = True
        '
        'Importe
        '
        Me.Importe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Importe.DataPropertyName = "Importe"
        Me.Importe.FillWeight = 105.9645!
        Me.Importe.HeaderText = "Importe"
        Me.Importe.MinimumWidth = 100
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        '
        'stock
        '
        Me.stock.HeaderText = "stock"
        Me.stock.Name = "stock"
        Me.stock.Visible = False
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(555, 582)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(180, 35)
        Me.TxtTotal.TabIndex = 84
        Me.TxtTotal.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(461, 585)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 29)
        Me.Label16.TabIndex = 89
        Me.Label16.Text = "Total: $"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(41, 126)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 29)
        Me.Label15.TabIndex = 100
        Me.Label15.Text = "Precio"
        '
        'TxtPrecioVenta
        '
        Me.TxtPrecioVenta.Enabled = False
        Me.TxtPrecioVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecioVenta.Location = New System.Drawing.Point(12, 152)
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
        Me.Label17.Location = New System.Drawing.Point(167, 106)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 16)
        Me.Label17.TabIndex = 98
        Me.Label17.Text = "Marca"
        '
        'Articulo
        '
        Me.Articulo.AutoSize = True
        Me.Articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Articulo.Location = New System.Drawing.Point(167, 54)
        Me.Articulo.Name = "Articulo"
        Me.Articulo.Size = New System.Drawing.Size(60, 16)
        Me.Articulo.TabIndex = 96
        Me.Articulo.Text = "Articulo"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(167, 4)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 16)
        Me.Label20.TabIndex = 95
        Me.Label20.Text = "Codigo:"
        '
        'TxtMarca
        '
        Me.TxtMarca.Enabled = False
        Me.TxtMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMarca.Location = New System.Drawing.Point(161, 125)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.ReadOnly = True
        Me.TxtMarca.Size = New System.Drawing.Size(211, 26)
        Me.TxtMarca.TabIndex = 93
        Me.TxtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtArticulo
        '
        Me.TxtArticulo.Enabled = False
        Me.TxtArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtArticulo.Location = New System.Drawing.Point(161, 74)
        Me.TxtArticulo.Name = "TxtArticulo"
        Me.TxtArticulo.ReadOnly = True
        Me.TxtArticulo.Size = New System.Drawing.Size(283, 26)
        Me.TxtArticulo.TabIndex = 91
        Me.TxtArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtIdArticulo
        '
        Me.TxtIdArticulo.Enabled = False
        Me.TxtIdArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdArticulo.Location = New System.Drawing.Point(161, 23)
        Me.TxtIdArticulo.MaxLength = 13
        Me.TxtIdArticulo.Name = "TxtIdArticulo"
        Me.TxtIdArticulo.ReadOnly = True
        Me.TxtIdArticulo.Size = New System.Drawing.Size(283, 26)
        Me.TxtIdArticulo.TabIndex = 90
        Me.TxtIdArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtStock
        '
        Me.TxtStock.Enabled = False
        Me.TxtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStock.Location = New System.Drawing.Point(289, 172)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.ReadOnly = True
        Me.TxtStock.Size = New System.Drawing.Size(52, 22)
        Me.TxtStock.TabIndex = 102
        Me.TxtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(292, 152)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 16)
        Me.Label18.TabIndex = 103
        Me.Label18.Text = "Stock"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.TxtStockminimo)
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
        Me.Panel4.Location = New System.Drawing.Point(746, 9)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(459, 206)
        Me.Panel4.TabIndex = 105
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 101
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(351, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Stock-Minimo"
        '
        'TxtStockminimo
        '
        Me.TxtStockminimo.Enabled = False
        Me.TxtStockminimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStockminimo.Location = New System.Drawing.Point(358, 172)
        Me.TxtStockminimo.Name = "TxtStockminimo"
        Me.TxtStockminimo.ReadOnly = True
        Me.TxtStockminimo.Size = New System.Drawing.Size(86, 22)
        Me.TxtStockminimo.TabIndex = 106
        Me.TxtStockminimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.Gestion_Comercial.My.Resources.Resources.BI_cancel_48
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(247, 569)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(200, 60)
        Me.BtnCancelar.TabIndex = 107
        Me.BtnCancelar.Text = "(Esc)      Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnVenta
        '
        Me.BtnVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVenta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVenta.Image = Global.Gestion_Comercial.My.Resources.Resources.BI_save_48
        Me.BtnVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVenta.Location = New System.Drawing.Point(11, 569)
        Me.BtnVenta.Name = "BtnVenta"
        Me.BtnVenta.Size = New System.Drawing.Size(200, 60)
        Me.BtnVenta.TabIndex = 4
        Me.BtnVenta.Text = "(F1)         Aceptar"
        Me.BtnVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnVenta.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.BtnIngreso)
        Me.Panel1.Controls.Add(Me.BtnC)
        Me.Panel1.Controls.Add(Me.BtnEnter)
        Me.Panel1.Controls.Add(Me.BtnFlechaAbajo)
        Me.Panel1.Controls.Add(Me.BtnFlechaArriba)
        Me.Panel1.Controls.Add(Me.BtnCero)
        Me.Panel1.Controls.Add(Me.BtnBorrar)
        Me.Panel1.Controls.Add(Me.Btn3)
        Me.Panel1.Controls.Add(Me.Btn2)
        Me.Panel1.Controls.Add(Me.Btn1)
        Me.Panel1.Controls.Add(Me.Btn6)
        Me.Panel1.Controls.Add(Me.Btn5)
        Me.Panel1.Controls.Add(Me.Btn4)
        Me.Panel1.Controls.Add(Me.Btn9)
        Me.Panel1.Controls.Add(Me.Btn8)
        Me.Panel1.Controls.Add(Me.Btn7)
        Me.Panel1.Location = New System.Drawing.Point(748, 220)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(459, 395)
        Me.Panel1.TabIndex = 108
        '
        'BtnC
        '
        Me.BtnC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnC.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnC.ForeColor = System.Drawing.Color.Red
        Me.BtnC.Location = New System.Drawing.Point(173, 243)
        Me.BtnC.Name = "BtnC"
        Me.BtnC.Size = New System.Drawing.Size(75, 70)
        Me.BtnC.TabIndex = 84
        Me.BtnC.Text = "C"
        Me.BtnC.UseVisualStyleBackColor = True
        '
        'BtnEnter
        '
        Me.BtnEnter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEnter.Location = New System.Drawing.Point(268, 17)
        Me.BtnEnter.Name = "BtnEnter"
        Me.BtnEnter.Size = New System.Drawing.Size(171, 119)
        Me.BtnEnter.TabIndex = 83
        Me.BtnEnter.Text = "ENTER"
        Me.BtnEnter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnEnter.UseVisualStyleBackColor = True
        '
        'BtnFlechaAbajo
        '
        Me.BtnFlechaAbajo.BackgroundImage = CType(resources.GetObject("BtnFlechaAbajo.BackgroundImage"), System.Drawing.Image)
        Me.BtnFlechaAbajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFlechaAbajo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFlechaAbajo.Location = New System.Drawing.Point(359, 170)
        Me.BtnFlechaAbajo.Name = "BtnFlechaAbajo"
        Me.BtnFlechaAbajo.Size = New System.Drawing.Size(75, 70)
        Me.BtnFlechaAbajo.TabIndex = 82
        Me.BtnFlechaAbajo.UseVisualStyleBackColor = True
        '
        'BtnFlechaArriba
        '
        Me.BtnFlechaArriba.BackgroundImage = CType(resources.GetObject("BtnFlechaArriba.BackgroundImage"), System.Drawing.Image)
        Me.BtnFlechaArriba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnFlechaArriba.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFlechaArriba.Location = New System.Drawing.Point(272, 170)
        Me.BtnFlechaArriba.Name = "BtnFlechaArriba"
        Me.BtnFlechaArriba.Size = New System.Drawing.Size(75, 70)
        Me.BtnFlechaArriba.TabIndex = 81
        Me.BtnFlechaArriba.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BtnFlechaArriba.UseVisualStyleBackColor = True
        '
        'BtnCero
        '
        Me.BtnCero.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCero.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCero.Location = New System.Drawing.Point(11, 243)
        Me.BtnCero.Name = "BtnCero"
        Me.BtnCero.Size = New System.Drawing.Size(154, 70)
        Me.BtnCero.TabIndex = 9
        Me.BtnCero.Text = "0"
        Me.BtnCero.UseVisualStyleBackColor = True
        '
        'Btn3
        '
        Me.Btn3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn3.Location = New System.Drawing.Point(173, 167)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(75, 70)
        Me.Btn3.TabIndex = 8
        Me.Btn3.Text = "3"
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn2.Location = New System.Drawing.Point(92, 166)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(75, 70)
        Me.Btn2.TabIndex = 7
        Me.Btn2.Text = "2"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn1
        '
        Me.Btn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn1.Location = New System.Drawing.Point(11, 167)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(75, 70)
        Me.Btn1.TabIndex = 6
        Me.Btn1.Text = "1"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn6
        '
        Me.Btn6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn6.Location = New System.Drawing.Point(172, 90)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(75, 70)
        Me.Btn6.TabIndex = 5
        Me.Btn6.Text = "6"
        Me.Btn6.UseVisualStyleBackColor = True
        '
        'Btn5
        '
        Me.Btn5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn5.Location = New System.Drawing.Point(90, 90)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(75, 70)
        Me.Btn5.TabIndex = 4
        Me.Btn5.Text = "5"
        Me.Btn5.UseVisualStyleBackColor = True
        '
        'Btn4
        '
        Me.Btn4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn4.Location = New System.Drawing.Point(11, 90)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(75, 70)
        Me.Btn4.TabIndex = 3
        Me.Btn4.Text = "4"
        Me.Btn4.UseVisualStyleBackColor = True
        '
        'Btn9
        '
        Me.Btn9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn9.Location = New System.Drawing.Point(172, 14)
        Me.Btn9.Name = "Btn9"
        Me.Btn9.Size = New System.Drawing.Size(75, 70)
        Me.Btn9.TabIndex = 2
        Me.Btn9.Text = "9"
        Me.Btn9.UseVisualStyleBackColor = True
        '
        'Btn8
        '
        Me.Btn8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn8.Location = New System.Drawing.Point(90, 14)
        Me.Btn8.Name = "Btn8"
        Me.Btn8.Size = New System.Drawing.Size(75, 70)
        Me.Btn8.TabIndex = 1
        Me.Btn8.Text = "8"
        Me.Btn8.UseVisualStyleBackColor = True
        '
        'Btn7
        '
        Me.Btn7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn7.Location = New System.Drawing.Point(9, 14)
        Me.Btn7.Name = "Btn7"
        Me.Btn7.Size = New System.Drawing.Size(75, 70)
        Me.Btn7.TabIndex = 0
        Me.Btn7.Text = "7"
        Me.Btn7.UseVisualStyleBackColor = True
        '
        'Lblseleccionado
        '
        Me.Lblseleccionado.AutoSize = True
        Me.Lblseleccionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblseleccionado.Location = New System.Drawing.Point(920, 618)
        Me.Lblseleccionado.Name = "Lblseleccionado"
        Me.Lblseleccionado.Size = New System.Drawing.Size(102, 16)
        Me.Lblseleccionado.TabIndex = 107
        Me.Lblseleccionado.Text = "seleccionado"
        Me.Lblseleccionado.Visible = False
        '
        'FrmVentasTouch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1211, 638)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Lblseleccionado)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnVenta)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Txtcantidad)
        Me.Controls.Add(Me.TxtImporte)
        Me.Controls.Add(Me.TxtidProducto)
        Me.Controls.Add(Me.txtprecioUnitario)
        Me.Controls.Add(Me.Txtdescripcion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FrmVentasTouch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas_Touch"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridViewIngVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TxtidProducto As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewIngVenta As System.Windows.Forms.DataGridView
    Friend WithEvents Txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents TxtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents BtnIngreso As System.Windows.Forms.Button
    Friend WithEvents txtprecioUnitario As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents BtnBorrar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtPrecioVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Articulo As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TxtMarca As System.Windows.Forms.TextBox
    Friend WithEvents TxtArticulo As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdArticulo As System.Windows.Forms.TextBox
    Friend WithEvents TxtStock As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtStockminimo As System.Windows.Forms.TextBox
    Friend WithEvents BtnVenta As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents LblIdCliente As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents BtnBusquedaCliente As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtBuscarCodigoBarra As System.Windows.Forms.TextBox
    Friend WithEvents BtnArticulos As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnCero As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn1 As Button
    Friend WithEvents Btn6 As Button
    Friend WithEvents Btn5 As Button
    Friend WithEvents Btn4 As Button
    Friend WithEvents Btn9 As Button
    Friend WithEvents Btn8 As Button
    Friend WithEvents Btn7 As Button
    Friend WithEvents BtnFlechaAbajo As Button
    Friend WithEvents BtnFlechaArriba As Button
    Friend WithEvents Lblseleccionado As Label
    Friend WithEvents BtnC As Button
    Friend WithEvents BtnEnter As Button
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Detalle As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitario As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
End Class
