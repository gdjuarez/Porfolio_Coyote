﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompras
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCodArticulo = New System.Windows.Forms.TextBox()
        Me.TxtDescArticulo = New System.Windows.Forms.TextBox()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.TxtImporte = New System.Windows.Forms.TextBox()
        Me.TxtRazonSocial = New System.Windows.Forms.TextBox()
        Me.TxtProveedor = New System.Windows.Forms.TextBox()
        Me.DTPcompras = New System.Windows.Forms.DateTimePicker()
        Me.BtnIngresoArticulo = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.BtnArticulo = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnCompra = New System.Windows.Forms.Button()
        Me.BtnProveedor = New System.Windows.Forms.Button()
        Me.DataGridViewCompras = New System.Windows.Forms.DataGridView()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtprecioUnitario = New System.Windows.Forms.TextBox()
        Me.DataGridViewBarra = New System.Windows.Forms.DataGridView()
        Me.lblNumeroPedido = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPVentaO = New System.Windows.Forms.TextBox()
        Me.CBPorcentaje = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtPVentaM = New System.Windows.Forms.TextBox()
        CType(Me.DataGridViewCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Cod. Proveedor"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(168, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Razon Social del Proveedor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Cod. Artículo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(168, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Descripción  "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(447, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Cantidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(606, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 17)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Importe"
        '
        'TxtCodArticulo
        '
        Me.TxtCodArticulo.Location = New System.Drawing.Point(52, 107)
        Me.TxtCodArticulo.Name = "TxtCodArticulo"
        Me.TxtCodArticulo.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodArticulo.TabIndex = 3
        '
        'TxtDescArticulo
        '
        Me.TxtDescArticulo.Location = New System.Drawing.Point(170, 107)
        Me.TxtDescArticulo.Name = "TxtDescArticulo"
        Me.TxtDescArticulo.Size = New System.Drawing.Size(273, 20)
        Me.TxtDescArticulo.TabIndex = 4
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(452, 107)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(54, 20)
        Me.TxtCantidad.TabIndex = 5
        Me.TxtCantidad.Text = "1"
        Me.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtImporte
        '
        Me.TxtImporte.Location = New System.Drawing.Point(586, 107)
        Me.TxtImporte.Name = "TxtImporte"
        Me.TxtImporte.ReadOnly = True
        Me.TxtImporte.Size = New System.Drawing.Size(96, 20)
        Me.TxtImporte.TabIndex = 7
        Me.TxtImporte.Text = "0"
        Me.TxtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtRazonSocial
        '
        Me.TxtRazonSocial.Enabled = False
        Me.TxtRazonSocial.Location = New System.Drawing.Point(170, 61)
        Me.TxtRazonSocial.Name = "TxtRazonSocial"
        Me.TxtRazonSocial.Size = New System.Drawing.Size(273, 20)
        Me.TxtRazonSocial.TabIndex = 2
        '
        'TxtProveedor
        '
        Me.TxtProveedor.Enabled = False
        Me.TxtProveedor.Location = New System.Drawing.Point(52, 61)
        Me.TxtProveedor.Name = "TxtProveedor"
        Me.TxtProveedor.Size = New System.Drawing.Size(100, 20)
        Me.TxtProveedor.TabIndex = 1
        '
        'DTPcompras
        '
        Me.DTPcompras.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPcompras.Location = New System.Drawing.Point(508, 61)
        Me.DTPcompras.Name = "DTPcompras"
        Me.DTPcompras.Size = New System.Drawing.Size(96, 20)
        Me.DTPcompras.TabIndex = 0
        Me.DTPcompras.Value = New Date(2017, 12, 16, 0, 0, 0, 0)
        '
        'BtnIngresoArticulo
        '
        Me.BtnIngresoArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresoArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnIngresoArticulo.Location = New System.Drawing.Point(13, 146)
        Me.BtnIngresoArticulo.Name = "BtnIngresoArticulo"
        Me.BtnIngresoArticulo.Size = New System.Drawing.Size(270, 40)
        Me.BtnIngresoArticulo.TabIndex = 8
        Me.BtnIngresoArticulo.Text = "Ingresar a la compra"
        Me.BtnIngresoArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnIngresoArticulo.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnBorrar.ForeColor = System.Drawing.Color.Red
        Me.BtnBorrar.Location = New System.Drawing.Point(607, 146)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(270, 40)
        Me.BtnBorrar.TabIndex = 81
        Me.BtnBorrar.Text = "Borrar seleccion de la compra"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(399, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 25)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Compras"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(646, 465)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(99, 32)
        Me.Label16.TabIndex = 111
        Me.Label16.Text = "Total: $"
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(746, 464)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(131, 35)
        Me.TxtTotal.TabIndex = 110
        Me.TxtTotal.Text = "0"
        '
        'BtnArticulo
        '
        Me.BtnArticulo.Image = Global.Gestion_Comercial.My.Resources.Resources.BI_find_b2_36
        Me.BtnArticulo.Location = New System.Drawing.Point(11, 89)
        Me.BtnArticulo.Name = "BtnArticulo"
        Me.BtnArticulo.Size = New System.Drawing.Size(40, 40)
        Me.BtnArticulo.TabIndex = 112
        Me.BtnArticulo.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Gestion_Comercial.My.Resources.Resources.BI_cancel_48
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(149, 456)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 50)
        Me.Button1.TabIndex = 109
        Me.Button1.Text = "Cancelar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnCompra
        '
        Me.BtnCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCompra.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompra.Image = Global.Gestion_Comercial.My.Resources.Resources.BI_save_48
        Me.BtnCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCompra.Location = New System.Drawing.Point(13, 456)
        Me.BtnCompra.Name = "BtnCompra"
        Me.BtnCompra.Size = New System.Drawing.Size(130, 50)
        Me.BtnCompra.TabIndex = 108
        Me.BtnCompra.Text = "Aceptar"
        Me.BtnCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCompra.UseVisualStyleBackColor = True
        '
        'BtnProveedor
        '
        Me.BtnProveedor.Image = Global.Gestion_Comercial.My.Resources.Resources.BI_find_b2_36
        Me.BtnProveedor.Location = New System.Drawing.Point(9, 36)
        Me.BtnProveedor.Name = "BtnProveedor"
        Me.BtnProveedor.Size = New System.Drawing.Size(40, 40)
        Me.BtnProveedor.TabIndex = 79
        Me.BtnProveedor.UseVisualStyleBackColor = True
        '
        'DataGridViewCompras
        '
        Me.DataGridViewCompras.AllowUserToAddRows = False
        Me.DataGridViewCompras.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewCompras.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewCompras.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridViewCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Column2, Me.Column3, Me.Column4, Me.Importe, Me.PVenta})
        Me.DataGridViewCompras.Location = New System.Drawing.Point(13, 192)
        Me.DataGridViewCompras.Name = "DataGridViewCompras"
        Me.DataGridViewCompras.ReadOnly = True
        Me.DataGridViewCompras.RowHeadersVisible = False
        Me.DataGridViewCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewCompras.Size = New System.Drawing.Size(864, 259)
        Me.DataGridViewCompras.TabIndex = 113
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Codigo"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Detalle"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "P/Unit."
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Importe
        '
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        '
        'PVenta
        '
        Me.PVenta.HeaderText = "P/Venta"
        Me.PVenta.Name = "PVenta"
        Me.PVenta.ReadOnly = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(523, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 17)
        Me.Label9.TabIndex = 115
        Me.Label9.Text = "P/Unit."
        '
        'txtprecioUnitario
        '
        Me.txtprecioUnitario.Location = New System.Drawing.Point(522, 107)
        Me.txtprecioUnitario.Name = "txtprecioUnitario"
        Me.txtprecioUnitario.Size = New System.Drawing.Size(58, 20)
        Me.txtprecioUnitario.TabIndex = 6
        Me.txtprecioUnitario.Text = "1"
        Me.txtprecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataGridViewBarra
        '
        Me.DataGridViewBarra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBarra.Enabled = False
        Me.DataGridViewBarra.Location = New System.Drawing.Point(154, 303)
        Me.DataGridViewBarra.Name = "DataGridViewBarra"
        Me.DataGridViewBarra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewBarra.Size = New System.Drawing.Size(519, 117)
        Me.DataGridViewBarra.TabIndex = 116
        '
        'lblNumeroPedido
        '
        Me.lblNumeroPedido.AutoSize = True
        Me.lblNumeroPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroPedido.Location = New System.Drawing.Point(427, 158)
        Me.lblNumeroPedido.Name = "lblNumeroPedido"
        Me.lblNumeroPedido.Size = New System.Drawing.Size(25, 16)
        Me.lblNumeroPedido.TabIndex = 117
        Me.lblNumeroPedido.Text = " n°"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(531, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 17)
        Me.Label10.TabIndex = 118
        Me.Label10.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "Original"
        '
        'TxtPVentaO
        '
        Me.TxtPVentaO.Location = New System.Drawing.Point(12, 83)
        Me.TxtPVentaO.Name = "TxtPVentaO"
        Me.TxtPVentaO.ReadOnly = True
        Me.TxtPVentaO.Size = New System.Drawing.Size(58, 20)
        Me.TxtPVentaO.TabIndex = 120
        Me.TxtPVentaO.Text = "0"
        Me.TxtPVentaO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBPorcentaje
        '
        Me.CBPorcentaje.FormattingEnabled = True
        Me.CBPorcentaje.Items.AddRange(New Object() {"0", "1", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60", "65", "70", "75"})
        Me.CBPorcentaje.Location = New System.Drawing.Point(74, 83)
        Me.CBPorcentaje.Name = "CBPorcentaje"
        Me.CBPorcentaje.Size = New System.Drawing.Size(39, 21)
        Me.CBPorcentaje.TabIndex = 122
        Me.CBPorcentaje.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(84, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 17)
        Me.Label11.TabIndex = 123
        Me.Label11.Text = "%"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.TxtPVentaM)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.CBPorcentaje)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtPVentaO)
        Me.Panel1.Location = New System.Drawing.Point(690, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(187, 113)
        Me.Panel1.TabIndex = 125
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(18, 5)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(151, 50)
        Me.Label13.TabIndex = 126
        Me.Label13.Text = "Modifica Precio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " de venta"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(123, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 17)
        Me.Label12.TabIndex = 125
        Me.Label12.Text = "Actual"
        '
        'TxtPVentaM
        '
        Me.TxtPVentaM.Location = New System.Drawing.Point(117, 83)
        Me.TxtPVentaM.Name = "TxtPVentaM"
        Me.TxtPVentaM.ReadOnly = True
        Me.TxtPVentaM.Size = New System.Drawing.Size(58, 20)
        Me.TxtPVentaM.TabIndex = 124
        Me.TxtPVentaM.Text = "0"
        Me.TxtPVentaM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(889, 511)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblNumeroPedido)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtprecioUnitario)
        Me.Controls.Add(Me.BtnArticulo)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnCompra)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnIngresoArticulo)
        Me.Controls.Add(Me.BtnProveedor)
        Me.Controls.Add(Me.DTPcompras)
        Me.Controls.Add(Me.TxtProveedor)
        Me.Controls.Add(Me.TxtRazonSocial)
        Me.Controls.Add(Me.TxtImporte)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.TxtDescArticulo)
        Me.Controls.Add(Me.TxtCodArticulo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridViewCompras)
        Me.Controls.Add(Me.DataGridViewBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras"
        CType(Me.DataGridViewCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewBarra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtCodArticulo As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescArticulo As System.Windows.Forms.TextBox
    Friend WithEvents TxtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents TxtImporte As System.Windows.Forms.TextBox
    Friend WithEvents TxtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents TxtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents DTPcompras As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnProveedor As System.Windows.Forms.Button
    Friend WithEvents BtnIngresoArticulo As System.Windows.Forms.Button
    Friend WithEvents BtnBorrar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnCompra As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents BtnArticulo As System.Windows.Forms.Button
    Friend WithEvents DataGridViewCompras As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtprecioUnitario As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewBarra As System.Windows.Forms.DataGridView
    Friend WithEvents lblNumeroPedido As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtPVentaO As System.Windows.Forms.TextBox
    Friend WithEvents CBPorcentaje As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtPVentaM As System.Windows.Forms.TextBox
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
