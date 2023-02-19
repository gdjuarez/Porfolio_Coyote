Public Class FrmVentasCC

    Dim dttabla As New DataTable
    Dim miArticulo As New ClassArticulo
    Dim miVendedor As New ClassVendedor
    Dim miConeccion As New GestionMySQL
    Dim miventaCC As New ClassVentaCC
    Dim ControlStock As Integer = 0

    Private Sub FrmVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Date.Today
    End Sub

    Private Sub BtnArticulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArticulos.Click

        If LblIdCliente.Text = "Sin_Cliente" Then
            MsgBox("Seleccione un Cliente")
        Else
            FrmBusquedaArticulo.MdiParent = MDIMenu
            FrmBusquedaArticulo.Show()
            FrmBusquedaArticulo.btnCopiarVentacc.Visible = True
        End If

        TxtBuscarCodigoBarra.Select()

    End Sub

    Private Sub BtnIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngreso.Click

        If Txtcantidad.Text = "" Or TxtidProducto.Text = "" Or TxtImporte.Text = 0 Then
            MsgBox("INGRESE CANTIDAD , ARTICULO")
        Else
            If Convert.ToInt32(Txtcantidad.Text) > Convert.ToInt32(TxtStock.Text) Then
                MsgBox("No existe la cantidad solicitada :Pedir Articulo" & vbNewLine &
                       "Stock Minimo = " & TxtStockminimo.Text & vbNewLine &
                       "Stock Actual = " & TxtStock.Text & vbNewLine &
                       "Cantidad Solicitada = " & Txtcantidad.Text)
            ElseIf TxtImporte.Text > 0 Then
                ' lleno el datagridview en el mismo orden que tengan las columnas
                Dim values() As Object = {Txtcantidad.Text, TxtidProducto.Text, Txtdescripcion.Text, txtprecioUnitario.Text, TxtImporte.Text}
                ' Añadimos una nueva fila al control DataGridView
                Dim index As Integer = DataGridViewIngVentaCC.Rows.Add()
                ' Referenciamos la nueva fila
                Dim currentRow As DataGridViewRow = DataGridViewIngVentaCC.Rows(index)
                ' Añadimos los valores a las celdas de la fila
                currentRow.SetValues(values)
                'limpio los textbox
                Txtcantidad.Text = 0
                TxtidProducto.Text = ""
                Txtdescripcion.Text = ""
                txtprecioUnitario.Text = 0
                TxtImporte.Text = 0
                TxtBuscarCodigoBarra.Text = 0
                'Uso funcion sumar para sumar la columna Importe
                TxtTotal.Text = Sumar("Importe", DataGridViewIngVentaCC).ToString("0.00")
            Else
                MsgBox("Ingrese CANTIDAD y ARTICULO")
            End If
            TxtBuscarCodigoBarra.Text = ""
            TxtBuscarCodigoBarra.Select()
        End If
    End Sub

    Private Sub Btnconfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConfirmar.Click

        If DataGridViewIngVentaCC.RowCount = 0 Or LblIdCliente.Text = "Sin_Cliente" Then
            MsgBox("Faltan datos " & vbNewLine & " para completar la Venta en Cta Cte")
            Txtcantidad.Select()
        Else
            '-----------------------------------------------------------------------------------------
            If DataGridViewIngVentaCC.RowCount = 0 Then
                MsgBox("Faltan datos " & vbNewLine & " para completar la Venta en Cta Cte")
                Txtcantidad.Select()
                Exit Sub
            Else
                Dim miconexion1 As New GestionMySQL
                Dim consultaMysql1 As String = ""
                miventaCC.Fecha = DateTimePicker1.Value
                miventaCC.Total = Me.TxtTotal.Text.Trim
                'ventaImporte = totalPedido
                consultaMysql1 = "INSERT INTO ventascc (fecha,total)"
                consultaMysql1 += "VALUES ( STR_TO_DATE('" & miventaCC.Fecha & "' ,'%d/%m/%Y') ," & Replace(miventaCC.Total, ",", ".") & ")"
                Try
                    miconexion1.EjecutarSQL(consultaMysql1)
                    'MsgBox("Registro Guardado", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical)
                End Try
                miconexion1.Dispose()
            End If
            'MsgBox("busco el ultimo idPedido")
            ''======== Obtengo el ULTIMO idventas tabla ventas(autoincremental)====================
            ObtengoNumeroVentacc()
            'Grabo_clienteVentacc()
            '============================================================================================
            'HAY QUE RECORRER EL DATAGRIED E IR GRABANDO EN LA
            'TABLA ventaCCarticulos
            '( idVenta, idArticulo, Cantidad, PrecioUnitario, Importe,PAGADO )
            ''------------------------------------------------------------------------------------
            If DataGridViewIngVentaCC.RowCount = 0 Then
                MsgBox("Ingrese los datos " & vbNewLine & " de la venta")
                Txtcantidad.Select()
            Else
                Dim miconexion2 As New GestionMySQL
                Dim miconexion3 As New GestionMySQL
                Dim miconexion4 As New GestionMySQL
                'Dim idVta As Integer
                Dim consultaMysql2 As String = ""
                miventaCC.IdVentacc = Global_numeroVentacc
                'con este ciclo recorro el datagridview
                For Each row As DataGridViewRow In DataGridViewIngVentaCC.Rows
                    consultaMysql2 = "INSERT INTO ventaccarticulos (idVentacc,idArticulo,Cantidad,PrecioUnitario,Importe,Pagado)"
                    consultaMysql2 += "VALUES (" & miventaCC.IdVentacc & ",'" & row.Cells(1).Value & "'," & row.Cells(0).Value & "," & Replace(row.Cells(3).Value, ",", ".") & "," & Replace(row.Cells(4).Value, ",", ".") & ",'NO' )"
                    Try
                        miconexion2.EjecutarSQL(consultaMysql2)
                        'MsgBox(consultaMysql)
                        'MsgBox("Registro Guardado", MsgBoxStyle.Information)
                    Catch ex As Exception
                        MsgBox(ex.ToString, MsgBoxStyle.Critical)
                    End Try
                    '--------------------------------------------------
                    '------TENGO QUE RESTAR LA CANTIDAD AL STOCK-->  Stock= stock - variable
                    'idArticulo, Stock, StockMinimo
                    Dim consultaMysql3 As String = ""
                    consultaMysql3 = "Update stockarticulos SET "
                    consultaMysql3 += "Stock = Stock -'" & row.Cells(0).Value & "' "
                    consultaMysql3 += "WHERE idArticulo = '" & row.Cells(1).Value & "'; "
                    Try
                        miconexion3.EjecutarSQL(consultaMysql3)
                        'MsgBox(consultaMysql)
                        'MsgBox("Registro Guardado", MsgBoxStyle.Information)
                    Catch ex As Exception
                        MsgBox(ex.ToString, MsgBoxStyle.Critical)
                    End Try
                    '-----------------------------------------------------
                Next
                '-------clienteventaccretira
                consultaMysql2 = ""
                consultaMysql2 = "INSERT INTO clienteventacc (idventacc, idCliente, DNIRetira)"
                consultaMysql2 += "VALUES (" & miventaCC.IdVentacc & ",'" & LblIdCliente.Text & "','" & LblDNIretira.Text & "')"

                'MsgBox(consultaMysql2)
                Try
                    miconexion4.EjecutarSQL(consultaMysql2)

                    'MsgBox("Registro Guardado", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical)
                End Try
                '-------------------
                miconexion2.Dispose()
                miconexion3.Dispose()
                miconexion4.Dispose()
                'MsgBox("Registro Guardado", MsgBoxStyle.Information)

                MsgBox("Articulos cargados a la Cuenta Corriente")
            End If

            'IMPRIME TICKET ????
            Dim resultado As DialogResult = MessageBox.Show("Desea imprimir ticket?",
                                                    "Atención", MessageBoxButtons.YesNo)
            If resultado = Windows.Forms.DialogResult.Yes Then
                ComprobanteCC.MdiParent = MDIMenu
                ComprobanteCC.Show()

                'MsgBox("hacer ticket de cuenta corriente ???")

                'End If
            End If

        End If

        Me.Close()

    End Sub

    Private Sub ObtengoNumeroVentacc()
        Dim miConexion As New GestionMySQL
        Dim dtTabla As New DataTable
        Global_numeroVentacc = 0
        '======== Obtengo el ULTIMO idventas tabla ventas(autoincremental)====================
        Dim sql As String
        sql = "SELECT MAX(idVentascc) as ultimoIdv FROM Ventascc;"
        miConexion.EjecutarSQL(sql)
        dtTabla = miConexion.Consulta(sql)
        Try
            For Each MiDataRow As DataRow In dtTabla.Rows
                Global_numeroVentacc = MiDataRow("ultimoIdV")
            Next
        Catch ex As Exception
            MsgBox("error" + ex.ToString)
        End Try
        miConexion.Dispose()
    End Sub

    Private Sub BtnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorrar.Click
        Dim rowToDelete As Integer
        rowToDelete = DataGridViewIngVentaCC.Rows.GetFirstRow(DataGridViewElementStates.Selected)
        If (rowToDelete > -1) Then
            DataGridViewIngVentaCC.Rows.RemoveAt(rowToDelete)
        End If
        'sumo nuevamente la columna importe porque saque un item
        TxtTotal.Text = Sumar("Importe", DataGridViewIngVentaCC).ToString("0.00")
    End Sub

    Private Sub calcularimporte()
        If Txtcantidad.Text = "" Or TxtPrecioUnitario.Text = "" Then
            TxtImporte.Text = "0"
        Else
            TxtImporte.Text = (Txtcantidad.Text * txtprecioUnitario.Text).ToString("0.00")
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.LblIdCliente.Text = "Sin_Vendedor"
        Me.LblIdCliente.Visible = False
        Me.TxtCliente.Clear()
        Me.Txtcantidad.Text = 1
        Me.TxtDescripcion.Clear()
        Me.TxtPrecioUnitario.Clear()
        Me.TxtImporte.Clear()
        Me.TxtStock.Clear()
        Me.TxtIdArticulo.Clear()
        Me.TxtMarca.Clear()
        Me.TxtPrecioVenta.Clear()
        Me.TxtImagen.Clear()
        Me.PictureBox1.Image = Nothing
        Me.TxtTotal.Clear()

    End Sub

    Private Sub LblIdCliente_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        If LblIdCliente.Text <> "Sin_Cliente" Then
            LblIdCliente.ForeColor = Color.Black
        Else
            LblIdCliente.ForeColor = Color.Red
        End If
    End Sub

    Private Sub BtnBusquedaVendedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBusquedaVendedores.Click
        CBRetira.Text = ""
        LblDNIretira.Text = ""
        LblDNIretira.Visible = False
        FrmBusquedaCliente.MdiParent = MDIMenu
        FrmBusquedaCliente.Show()
        FrmBusquedaCliente.BtnCopiarClienteCC.Visible = True
    End Sub

    Private Sub TxtPrecioUnitario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)
        End If
    End Sub

    Private Sub txtprecioUnitario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        calcularimporte()
    End Sub

    Private Sub Txtcantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        soloNumeros(e)
    End Sub

    Private Sub Txtcantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        calcularimporte()
    End Sub

    Private Sub CBRetira_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBRetira.SelectedIndexChanged
        get_Idretira(CBRetira.Text)
        LblDNIretira.Visible = True
    End Sub

    Private Sub get_Idretira(ByVal Apellidoretira As String)
        Dim miConexionIDRetira As New GestionMySQL
        Dim dtARetira As New DataTable
        Dim sql As String = ""
        Try
            sql = "select DNI from clienteretira where Apellido = '" & Apellidoretira & "'"
            'MsgBox(sql)
            dtARetira = miConexionIDRetira.Consulta(sql)
            For Each MiDataRow In dtARetira.Rows
                LblDNIretira.Text = MiDataRow("DNI")
            Next
            miConexionIDRetira.Dispose()
        Catch ex As Exception
            MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
        End Try
    End Sub

    Private Sub TxtBuscarCodigoBarra_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TxtBuscarCodigoBarra.KeyDown

        Dim miImagen As Image = PictureBox1.Image

        Select Case e.KeyData
            Case Keys.Enter
                If TxtBuscarCodigoBarra.Text <> "" Then
                    'conecto
                    Dim consulta As New GestionMySQL
                    'uso funcion para buscar en tabla , columna y campo que return un Datatable 
                    dttabla = consulta.BuscarArtStockID(TxtBuscarCodigoBarra.Text)
                    DataGridViewBarra.DataSource = dttabla
                    '----------------------------------------------------------------------------
                    If DataGridViewBarra.RowCount > 1 Then
                        If IsDBNull(DataGridViewBarra.SelectedCells(0).Value) Then
                            miArticulo.IdArticulo = "1"
                        Else
                            miArticulo.IdArticulo = DataGridViewBarra.SelectedCells(0).Value
                        End If
                        '
                        If IsDBNull(DataGridViewBarra.SelectedCells(1).Value) Then
                            miArticulo.Descripcion = ""
                        Else
                            miArticulo.Descripcion = DataGridViewBarra.SelectedCells(1).Value
                        End If
                        '
                        If IsDBNull(DataGridViewBarra.SelectedCells(3).Value) Then
                            miArticulo.PrecioVenta = "0"
                        Else
                            miArticulo.PrecioVenta = DataGridViewBarra.SelectedCells(3).Value
                        End If
                        '
                        If IsDBNull(DataGridViewBarra.SelectedCells(4).Value) Then
                            miArticulo.Marca = ""
                        Else
                            miArticulo.Marca = DataGridViewBarra.SelectedCells(4).Value
                        End If
                        '
                        If IsDBNull(DataGridViewBarra.SelectedCells(5).Value) Then
                            miArticulo.Foto = Nothing
                        Else
                            miImagen = Bytes_Imagen(DataGridViewBarra.SelectedCells(5).Value)
                            'miArticulo.Foto = DataGridViewBarra.SelectedCells(5).Value
                        End If
                        '
                        If IsDBNull(DataGridViewBarra.SelectedCells(6).Value) Then
                            miArticulo.Rubro = ""
                        Else
                            miArticulo.Rubro = DataGridViewBarra.SelectedCells(6).Value
                        End If
                        '
                        If IsDBNull(DataGridViewBarra.SelectedCells(7).Value) Then
                            miArticulo.Stock = ""
                        Else
                            miArticulo.Stock = DataGridViewBarra.SelectedCells(7).Value
                        End If
                        '
                        If IsDBNull(DataGridViewBarra.SelectedCells(8).Value) Then
                            miArticulo.StockMinimo = "0"
                        Else
                            miArticulo.StockMinimo = DataGridViewBarra.SelectedCells(8).Value
                        End If
                        calcularimporte()
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.TxtidProducto.Text = miArticulo.IdArticulo
                        Me.Txtdescripcion.Text = miArticulo.Descripcion
                        Me.txtprecioUnitario.Text = miArticulo.PrecioVenta
                        Me.TxtIdArticulo.Text = miArticulo.IdArticulo
                        Me.TxtArticulo.Text = miArticulo.Descripcion
                        Me.TxtPrecioVenta.Text = miArticulo.PrecioVenta
                        Me.TxtMarca.Text = miArticulo.Marca
                        Me.TxtStock.Text = miArticulo.Stock
                        Me.TxtStockminimo.Text = miArticulo.StockMinimo
                        Me.PictureBox1.Image = miImagen
                    Else
                        Me.DialogResult = Windows.Forms.DialogResult.Ignore
                    End If
                Else
                    MsgBox("Ingrese CODIGO DE BARRAS")
                End If
                Txtcantidad.Text = 1
                TxtImporte.Text = (Txtcantidad.Text * txtprecioUnitario.Text).ToString("#0.00")
        End Select
    End Sub

    Private Sub Txtcantidad_TextChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles Txtcantidad.TextChanged
        If IsNumeric(Txtcantidad.Text) Then
            If txtprecioUnitario.Text >= 0 Then
                TxtImporte.Text = (txtprecioUnitario.Text * Txtcantidad.Text).ToString("#0.00")
            Else
                MsgBox("Ingrese Articulo")
                Txtcantidad.Text = "0"
            End If
        Else
            MsgBox("Ingrese números")
        End If
    End Sub

    'funcion que me devuelve el stock de un articulo 
    Private Sub NOSTOCKBIGOGNO(ByVal idarticulo As String)
        Dim dtnostock As New DataTable
        Dim miConexiondtnostock As New GestionMySQL
        Dim sql As String = ""

        Try
            sql = "select stock from stockarticulos where idarticulo = '" & idarticulo & "'"
            'MsgBox(sql)
            dtnostock = miConexiondtnostock.Consulta(sql)
            For Each MiDataRow In dtnostock.Rows
                ControlStock = CInt(MiDataRow("stock"))
            Next
            miConexiondtnostock.Dispose()
        Catch ex As Exception
            MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
        End Try
    End Sub

End Class