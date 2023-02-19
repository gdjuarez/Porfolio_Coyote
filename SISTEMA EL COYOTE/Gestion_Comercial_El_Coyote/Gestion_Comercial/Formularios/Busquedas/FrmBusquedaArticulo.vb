Public Class FrmBusquedaArticulo

    Dim dt As New DataTable
    Dim tabla As New DataTable
    Dim Articulo As New ClassArticulo
    'conecto a base de datos
    Dim miGestionMySQL As New GestionMySQL

    Private Sub FrmBusquedaProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dt = miGestionMySQL.ConsultarTabla("vistaConsultarArticuloStock")
        DataGridViewProductos.DataSource = dt
        CType(DataGridViewProductos.Columns("Imagen"), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom
        DataGridViewProductos.Columns(0).HeaderText = "Codigo"
        'cierro conexion
        miGestionMySQL.Dispose()
    End Sub

    Private Sub TxtProductos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtProductos.TextChanged
        'uso funcion para buscar en tabla , columna y campo que return un Datatable 
        tabla = miGestionMySQL.BuscarArtStockDescripcion(TxtProductos.Text)
        DataGridViewProductos.DataSource = tabla
        CType(DataGridViewProductos.Columns("Imagen"), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom
        'cierro conexion
        miGestionMySQL.Dispose()
    End Sub

    Private Sub BtnCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopiarVenta.Click

        Dim miImagen As Image = Nothing

        If DataGridViewProductos.RowCount > 0 Then


            If IsDBNull(DataGridViewProductos.SelectedCells(0).Value) Then
                Articulo.IdArticulo = ""
            Else
                Articulo.IdArticulo = DataGridViewProductos.SelectedCells(0).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(1).Value) Then
                Articulo.Descripcion = ""
            Else
                Articulo.Descripcion = DataGridViewProductos.SelectedCells(1).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(3).Value) Then
                Articulo.PrecioVenta = ""
            Else
                Articulo.PrecioVenta = DataGridViewProductos.SelectedCells(3).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(4).Value) Then
                Articulo.Marca = ""
            Else
                Articulo.Marca = DataGridViewProductos.SelectedCells(4).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(5).Value) Then
                Articulo.Foto = Nothing
            Else
                miImagen = Bytes_Imagen(DataGridViewProductos.SelectedCells(5).Value)

            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(7).Value) Then
                Articulo.Stock = ""
            Else
                Articulo.Stock = DataGridViewProductos.SelectedCells(7).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(8).Value) Then
                Articulo.StockMinimo = ""
            Else
                Articulo.StockMinimo = DataGridViewProductos.SelectedCells(8).Value
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

            FrmVentas.TxtidProducto.Text = Articulo.IdArticulo
            FrmVentas.Txtdescripcion.Text = Articulo.Descripcion
            FrmVentas.txtprecioUnitario.Text = Articulo.PrecioVenta
            FrmVentas.TxtIdArticulo.Text = Articulo.IdArticulo
            FrmVentas.TxtArticulo.Text = Articulo.Descripcion
            FrmVentas.TxtPrecioVenta.Text = Articulo.PrecioVenta
            FrmVentas.TxtMarca.Text = Articulo.Marca

            FrmVentas.TxtStock.Text = Articulo.Stock
            FrmVentas.TxtStockminimo.Text = Articulo.StockMinimo

            FrmVentas.PictureBox1.Image = miImagen

        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If

        FrmVentas.Txtcantidad.Text = 1
        FrmVentas.TxtImporte.Text = (FrmVentas.Txtcantidad.Text * FrmVentas.TxtPrecioVenta.Text).ToString("0.00")
        Me.Close()

    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        dt = miGestionMySQL.ConsultarTabla("vistaConsultarArticuloStock")
        DataGridViewProductos.DataSource = dt
        DataGridViewProductos.Columns(0).HeaderText = "Codigo"
        CType(DataGridViewProductos.Columns("Imagen"), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom
        'cierro conexion
        miGestionMySQL.Dispose()
    End Sub

    Private Sub BtnCopiarPresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopiarPresupuesto.Click

        Dim miImagen As Image = Nothing

        If DataGridViewProductos.RowCount > 0 Then

            If IsDBNull(DataGridViewProductos.SelectedCells(0).Value) Then
                Articulo.IdArticulo = ""
            Else
                Articulo.IdArticulo = DataGridViewProductos.SelectedCells(0).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(1).Value) Then
                Articulo.Descripcion = ""
            Else
                Articulo.Descripcion = DataGridViewProductos.SelectedCells(1).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(3).Value) Then
                Articulo.PrecioVenta = ""
            Else
                Articulo.PrecioVenta = DataGridViewProductos.SelectedCells(3).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(4).Value) Then
                Articulo.Marca = ""
            Else
                Articulo.Marca = DataGridViewProductos.SelectedCells(4).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(5).Value) Then
                Articulo.Foto = Nothing
            Else
                miImagen = Bytes_Imagen(DataGridViewProductos.SelectedCells(5).Value)

            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(7).Value) Then
                Articulo.Stock = ""
            Else
                Articulo.Stock = DataGridViewProductos.SelectedCells(7).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(8).Value) Then
                Articulo.StockMinimo = ""
            Else
                Articulo.StockMinimo = DataGridViewProductos.SelectedCells(8).Value
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

            FrmPresupuestos.TxtidProducto.Text = Articulo.IdArticulo
            FrmPresupuestos.Txtdescripcion.Text = Articulo.Descripcion
            FrmPresupuestos.txtprecioUnitario.Text = Articulo.PrecioVenta
            FrmPresupuestos.TxtIdArticulo.Text = Articulo.IdArticulo
            FrmPresupuestos.TxtArticulo.Text = Articulo.Descripcion
            FrmPresupuestos.TxtPrecioVenta.Text = Articulo.PrecioVenta
            FrmPresupuestos.TxtMarca.Text = Articulo.Marca

            FrmPresupuestos.TxtStock.Text = Articulo.Stock
            FrmPresupuestos.TxtStockminimo.Text = Articulo.StockMinimo

            FrmPresupuestos.PictureBox1.Image = miImagen


        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If

        FrmPresupuestos.Txtcantidad.Text = 1
        FrmPresupuestos.TxtImporte.Text = (FrmPresupuestos.Txtcantidad.Text * FrmPresupuestos.TxtPrecioVenta.Text).ToString("0.00")
        Me.Close()
    End Sub

    Private Sub btnCopiarVentacc_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCopiarVentacc.Click

        Dim miImagen As Image = Nothing

        If DataGridViewProductos.RowCount > 0 Then


            If IsDBNull(DataGridViewProductos.SelectedCells(0).Value) Then
                Articulo.IdArticulo = ""
            Else
                Articulo.IdArticulo = DataGridViewProductos.SelectedCells(0).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(1).Value) Then
                Articulo.Descripcion = ""
            Else
                Articulo.Descripcion = DataGridViewProductos.SelectedCells(1).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(3).Value) Then
                Articulo.PrecioVenta = ""
            Else
                Articulo.PrecioVenta = DataGridViewProductos.SelectedCells(3).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(4).Value) Then
                Articulo.Marca = ""
            Else
                Articulo.Marca = DataGridViewProductos.SelectedCells(4).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(5).Value) Then
                Articulo.Foto = Nothing
            Else
                miImagen = Bytes_Imagen(DataGridViewProductos.SelectedCells(5).Value)

            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(7).Value) Then
                Articulo.Stock = ""
            Else
                Articulo.Stock = DataGridViewProductos.SelectedCells(7).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(8).Value) Then
                Articulo.StockMinimo = ""
            Else
                Articulo.StockMinimo = DataGridViewProductos.SelectedCells(8).Value
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

            FrmVentasCC.TxtidProducto.Text = Articulo.IdArticulo
            FrmVentasCC.Txtdescripcion.Text = Articulo.Descripcion
            FrmVentasCC.txtprecioUnitario.Text = Articulo.PrecioVenta
            FrmVentasCC.TxtIdArticulo.Text = Articulo.IdArticulo
            FrmVentasCC.TxtArticulo.Text = Articulo.Descripcion
            FrmVentasCC.TxtPrecioVenta.Text = Articulo.PrecioVenta
            FrmVentasCC.TxtMarca.Text = Articulo.Marca

            FrmVentasCC.TxtStock.Text = Articulo.Stock
            FrmVentasCC.TxtStockminimo.Text = Articulo.StockMinimo

            FrmVentasCC.PictureBox1.Image = miImagen

        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If

        FrmVentasCC.Txtcantidad.Text = 1
        FrmVentasCC.TxtImporte.Text = (FrmVentasCC.Txtcantidad.Text * FrmVentasCC.TxtPrecioVenta.Text).ToString("0.00")
        Me.Close()



    End Sub


    Private Sub BtnCopiarPrecio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopiarPrecio.Click

        Dim miImagen As Image = Nothing

        If DataGridViewProductos.RowCount > 0 Then

            If IsDBNull(DataGridViewProductos.SelectedCells(0).Value) Then
                Articulo.IdArticulo = ""
            Else
                Articulo.IdArticulo = DataGridViewProductos.SelectedCells(0).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(1).Value) Then
                Articulo.Descripcion = ""
            Else
                Articulo.Descripcion = DataGridViewProductos.SelectedCells(1).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(3).Value) Then
                Articulo.PrecioVenta = ""
            Else
                Articulo.PrecioVenta = DataGridViewProductos.SelectedCells(3).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(4).Value) Then
                Articulo.Marca = ""
            Else
                Articulo.Marca = DataGridViewProductos.SelectedCells(4).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(5).Value) Then
                Articulo.Foto = Nothing
            Else
                miImagen = Bytes_Imagen(DataGridViewProductos.SelectedCells(5).Value)

            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(7).Value) Then
                Articulo.Stock = ""
            Else
                Articulo.Stock = DataGridViewProductos.SelectedCells(7).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(8).Value) Then
                Articulo.StockMinimo = ""
            Else
                Articulo.StockMinimo = DataGridViewProductos.SelectedCells(8).Value
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

            FrmConsultaPrecio.TxtCodigo.Text = Articulo.IdArticulo
            FrmConsultaPrecio.TxtArticulo.Text = Articulo.Descripcion
            FrmConsultaPrecio.TxtPrecio.Text = Articulo.PrecioVenta
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If

   Me.Close()
    End Sub

    Private Sub BtnCopiarVentaTouch_Click(sender As Object, e As EventArgs) Handles BtnCopiarVentaTouch.Click

        Dim miImagen As Image = Nothing

        If DataGridViewProductos.RowCount > 0 Then


            If IsDBNull(DataGridViewProductos.SelectedCells(0).Value) Then
                Articulo.IdArticulo = ""
            Else
                Articulo.IdArticulo = DataGridViewProductos.SelectedCells(0).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(1).Value) Then
                Articulo.Descripcion = ""
            Else
                Articulo.Descripcion = DataGridViewProductos.SelectedCells(1).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(3).Value) Then
                Articulo.PrecioVenta = ""
            Else
                Articulo.PrecioVenta = DataGridViewProductos.SelectedCells(3).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(4).Value) Then
                Articulo.Marca = ""
            Else
                Articulo.Marca = DataGridViewProductos.SelectedCells(4).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(5).Value) Then
                Articulo.Foto = Nothing
            Else
                miImagen = Bytes_Imagen(DataGridViewProductos.SelectedCells(5).Value)

            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(7).Value) Then
                Articulo.Stock = ""
            Else
                Articulo.Stock = DataGridViewProductos.SelectedCells(7).Value
            End If

            If IsDBNull(DataGridViewProductos.SelectedCells(8).Value) Then
                Articulo.StockMinimo = ""
            Else
                Articulo.StockMinimo = DataGridViewProductos.SelectedCells(8).Value
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

            FrmVentasTouch.TxtidProducto.Text = Articulo.IdArticulo
            FrmVentasTouch.Txtdescripcion.Text = Articulo.Descripcion
            FrmVentasTouch.txtprecioUnitario.Text = Articulo.PrecioVenta
            FrmVentasTouch.TxtIdArticulo.Text = Articulo.IdArticulo
            FrmVentasTouch.TxtArticulo.Text = Articulo.Descripcion
            FrmVentasTouch.TxtPrecioVenta.Text = Articulo.PrecioVenta
            FrmVentasTouch.TxtMarca.Text = Articulo.Marca

            FrmVentasTouch.TxtStock.Text = Articulo.Stock
            FrmVentasTouch.TxtStockminimo.Text = Articulo.StockMinimo

            FrmVentasTouch.PictureBox1.Image = miImagen

        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If
        FrmVentasTouch.Txtcantidad.Text = 1
        FrmVentasTouch.TxtImporte.Text = (FrmVentasTouch.Txtcantidad.Text * FrmVentasTouch.TxtPrecioVenta.Text).ToString("0.00")

        FrmVentasTouch.TxtBuscarCodigoBarra.Select()

        Me.Close()


    End Sub
End Class