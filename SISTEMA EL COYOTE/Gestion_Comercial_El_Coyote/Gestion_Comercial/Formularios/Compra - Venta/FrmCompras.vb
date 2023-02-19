Public Class frmCompras

    Dim dtTabla As New DataTable
    Dim tabla As New DataTable
    Dim miCompra As New ClassCompra

    Private Sub frmCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicio()
        TxtProveedor.Select()
    End Sub

    Private Sub inicio()
        TxtProveedor.Select()
        DTPcompras.Value = Today
    End Sub

    Private Sub BtnArticulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArticulo.Click
        frmArticulos.MdiParent = MDIMenu
        frmArticulos.Show()
        frmArticulos.BrnAgregaArticulo.Visible = True
    End Sub

    Private Sub BtnProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProveedor.Click
        frmProveedores.MdiParent = MDIMenu
        frmProveedores.Show()
        frmProveedores.BtnAgregaProveedor.Visible = True
    End Sub

    Private Sub BtnIngresoArticulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngresoArticulo.Click
        TxtImporte.Text = (TxtCantidad.Text * txtprecioUnitario.Text).ToString("0.00")
        'MsgBox(TxtImporte.Text)
        If TxtCantidad.Text = "" Or TxtCodArticulo.Text = "" Or Convert.ToDouble(TxtImporte.Text) = 0 Or TxtProveedor.Text = "" Then
            MsgBox("INGRESE CANTIDAD, ARTICULO Y PROVEEDOR")
        ElseIf TxtImporte.Text > 0 Then
            ' lleno el datagridview en el mismo orden que tengan las columnas
            Dim values() As Object = {TxtCantidad.Text, TxtCodArticulo.Text, TxtDescArticulo.Text, txtprecioUnitario.Text, TxtImporte.Text, TxtPVentaM.Text}
            ' Añadimos una nueva fila al control DataGridView
            Dim index As Integer = DataGridViewCompras.Rows.Add()
            ' Referenciamos la nueva fila
            Dim currentRow As DataGridViewRow = DataGridViewCompras.Rows(index)
            ' Añadimos los valores a las celdas de la fila
            currentRow.SetValues(values)
            'limpio los textbox
            TxtCantidad.Text = 1
            TxtCodArticulo.Text = "0000000000000"
            TxtDescArticulo.Text = ""
            txtprecioUnitario.Text = 0
            TxtImporte.Text = 0
            TxtPVentaO.Text = 0
            'Uso funcion sumar para sumar la columna Importe
            TxtTotal.Text = Sumar("Importe", DataGridViewCompras).ToString("0.00")
            TxtCodArticulo.Select()

        Else
            MsgBox("Ingrese CANTIDAD y ARTICULO")
        End If
    End Sub

    Private Sub BtnCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCompra.Click
        '-----------------------------------------------------------------------------------------
        'Formato para la fecha 
        'para grabar
        'INSERT INTO mytabla (fecha) VALUES STR_TO_DATE(fecha, '%d/%m/%y')
        'para leer
        'SELECT id, DATE_FORMAT(fecha, '%d/%m/%y') AS fecha FROM mytabla;
        '-----------------------------------------------------------------------------------------
        If DataGridViewCompras.RowCount = 0 Then
            MsgBox("Faltan datos " & vbNewLine & " para completar la Compra")
            TxtCantidad.Select()
            Exit Sub
        Else
            Dim miProveedor As New ClassProveedor
            ' Dim miCompra As New ClassCompra
            Dim miConexionEncabezado As New GestionMySQL
            Dim Sql As String = ""
            miProveedor.IdProveedor = TxtProveedor.Text.Trim
            miCompra.Fecha = DTPcompras.Value
            miCompra.Total = Me.TxtTotal.Text.Trim
            Dim pagado As String = "NO"

            If BtnCompra.Enabled = True Then
                Try
                    Sql = "INSERT INTO compras (idProveedor,fecha,total,pagado)"
                    Sql += "VALUES( " & miProveedor.IdProveedor & ", STR_TO_DATE('" & miCompra.Fecha & "' ,'%d/%m/%Y') ,"
                    Sql += "" & Replace(miCompra.Total, ",", ".") & ",'" & pagado & "')"
                    ' MsgBox(Sql)
                    miConexionEncabezado.EjecutarSQL(Sql)
                    miConexionEncabezado.Dispose()
                    ' MsgBox("Registro Guardado", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical)
                End Try

            End If
            'MsgBox("busco el ultimo idPedido")
            ''======== Obtengo el ULTIMO idcompras tabla COMPRAS(autoincremental)====================
            obtengonumeroCompra()
            '============================================================================================
            'HAY QUE RECORRER EL DATAGRIED E IR GRABANDO EN LA
            'TABLA COMPRAarticulos
            'Tomar el idCOMPRAS del lblNumeroPedido.text// no lo tomo de globalnumeroCompra
            '( idCompra, idArticulo, Cantidad, PrecioUnitario, Importe )
            ''------------------------------------------------------------------------------------
            If DataGridViewCompras.RowCount = 0 Then
                MsgBox("Ingrese los datos " & vbNewLine & " de la compra")
                TxtCantidad.Select()
            Else
                Dim miConexionDetalle As New GestionMySQL
                Dim miConexionModifica As New GestionMySQL
                Dim miConexionStock As New GestionMySQL
                Dim sql2 As String = ""
                Dim sql3 As String = ""
                Dim sql4 As String = ""
                miCompra.IdCompras = Global_numeroCompra
                lblNumeroPedido.Text = Global_numeroCompra

                If BtnCompra.Enabled = True Then
                    'con este ciclo recorro el datagridview
                    For Each row As DataGridViewRow In DataGridViewCompras.Rows
                        sql2 = "INSERT INTO compraarticulos (idCompra,idArticulo,Cantidad,PrecioUnitario,Importe)"
                        sql2 += "VALUES (" & miCompra.IdCompras & ",'" & row.Cells(1).Value & "'," & row.Cells(0).Value & "," & Replace(row.Cells(3).Value, ",", ".") & "," & Replace(row.Cells(4).Value, ",", ".") & ")"
                        'MsgBox(consultaMysql)
                        Try
                            miConexionDetalle.EjecutarSQL(sql2)
                            ' MsgBox("Registro Guardado", MsgBoxStyle.Information)
                        Catch ex As Exception
                            MsgBox(ex.ToString, MsgBoxStyle.Critical)
                        End Try
                        '--------------------------------------------------
                        '------TENGO QUE actualiar los precios compra y venta
                        'idArticulo, Descripcion, PrecioCompra, PrecioVenta, Marca, Imagen, Rubro, Situado
                        sql3 = "Update articulo SET "
                        sql3 += "PrecioCompra = " & Replace(row.Cells(3).Value, ",", ".") & ", "
                        sql3 += " PrecioVenta = " & Replace(row.Cells(5).Value, ",", ".") & " "
                        sql3 += "WHERE idArticulo = '" & row.Cells(1).Value & "'; "

                        'MsgBox(sql3)
                        Try
                            miConexionModifica.EjecutarSQL(sql3)
                            ' MsgBox("Registro Guardado", MsgBoxStyle.Information)
                        Catch ex As Exception
                            MsgBox(ex.ToString, MsgBoxStyle.Critical)
                        End Try
                        '-----------------------------------------------------
                        '--------------------------------------------------
                        '------TENGO QUE SUMAR LA CANTIDAD AL STOCK-->  Stock= stock - variable
                        'idArticulo, Stock, StockMinimo
                        sql4 = "Update stockarticulos SET "
                        sql4 += "Stock = Stock +'" & row.Cells(0).Value & "' "
                        sql4 += "WHERE idArticulo = '" & row.Cells(1).Value & "'; "

                        ' MsgBox(consultaMysql)
                        Try
                            miConexionStock.EjecutarSQL(sql4)
                            ' MsgBox("Registro Guardado", MsgBoxStyle.Information)
                        Catch ex As Exception
                            MsgBox(ex.ToString, MsgBoxStyle.Critical)
                        End Try
                        '-----------------------------------------------------
                    Next
                    miConexionDetalle.Dispose()
                    miConexionStock.Dispose()
                    Dim fecha As String = DTPcompras.Text.Trim
                    '************************************************************************
                    '******************GRABO COMPRA EN CAJA************************
                    IngresoCompraCaja()

                    '************************************************************************
                    MsgBox("Compra registrada ", MsgBoxStyle.Information)
                End If
            End If
        End If

        Me.Close()
    End Sub

    Private Sub obtengonumeroCompra()

        Dim miConexion As New GestionMySQL
        Dim dtTabla As New DataTable
        Global_numeroCompra = 0
        ''======== Obtengo el ULTIMO idcompras tabla compras(autoincremental)====
        Dim sql As String
        sql = "SELECT MAX(idCompras) as ultimoidCompras FROM compras; "
        miConexion.EjecutarSQL(sql)
        dtTabla = miConexion.Consulta(sql)
        Try
            For Each MiDataRow As DataRow In dtTabla.Rows
                Global_numeroCompra = MiDataRow("ultimoidCompras")
            Next
            ' MsgBox(Global_numeroCompra)
        Catch ex As Exception
            MsgBox("error" + ex.ToString)
        End Try
        miConexion.Dispose()
    End Sub

    Private Sub IngresoCompraCaja()

        If TxtImporte.Text = "" Then
            MsgBox("Ingrese el importe  ")
        Else
            Dim meConecto As New GestionMySQL
            Dim meConecto2 As New GestionMySQL
            Dim meConecto3 As New GestionMySQL
            Dim dtTabla As New DataTable
            Dim miCaja As New ClassCaja
            Dim sqlcaja As String = ""
            ' idCajaMov, tipoMovimiento, Descripcion, tipoComprobante, serienumero, Importe
            Dim sql As String = ""
            miCaja.TipoMovimiento = "SALIDA"
            miCaja.Descripcion = "Compra"
            miCaja.TipoComprobante = "RECIBO"
            miCaja.Serienumero = Global_numeroCompra
            miCaja.Importe = Convert.ToDecimal(Me.TxtTotal.Text.Trim)
            ' MsgBox(miCaja.Importe)
            miCaja.Ingreso = 0
            'Egreso de dinero es una COMPRA
            miCaja.Egreso = miCaja.Importe
            sql = "INSERT INTO cajamov (tipoMovimiento, Descripcion, tipoComprobante, serienumero, ingreso,egreso)"
            sql += "VALUES ('" & miCaja.TipoMovimiento & "','" & miCaja.Descripcion & "','" & miCaja.TipoComprobante & ""
            sql += "','" & miCaja.Serienumero & "'," & Replace(miCaja.Ingreso, ",", ".") & "," & Replace(miCaja.Egreso, ",", ".") & ")"
            Try
                meConecto.EjecutarSQL(sql)
                ' MsgBox("Registro Guardado", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try
            meConecto.Dispose()
            '======== Obtengo el ULTIMO CODMOV GRABADO en  tabla cajamov (autoincremental)==================
            Dim sql2 As String
            sql2 = "SELECT MAX(idCajaMov) as ultimoCodmov FROM cajamov; "
            meConecto2.EjecutarSQL(sql2)
            dtTabla = meConecto2.Consulta(sql2)
            Try
                For Each MiDataRow As DataRow In dtTabla.Rows
                    If IsDBNull(MiDataRow("ultimoCodmov")) Then
                        miCaja.CodMovCaja = 0
                    Else
                        miCaja.CodMovCaja = MiDataRow("ultimoCodmov")
                    End If
                Next
                ' MsgBox()
            Catch ex As Exception
                MsgBox("error" + ex.ToString)
            End Try
            meConecto2.Dispose()
            '============================================================================================
            '----------------------- DEBE GRABAR EN LA TABLA CAJA ---------------------------
            Dim Gestiondb As New GestionMySQL
            miCaja.Saldo = Gestiondb.CalcularSaldo(DTPcompras.Text) - miCompra.Total
            ' MsgBox(miCaja.Saldo)
            miCaja.Saldoinicial = Gestiondb.CalcularSaldoInicial(DTPcompras.Text)
            ' MsgBox(miCaja.Saldoinicial)
            miCaja.Fecha = Today
            miCaja.Operador = usuarioGlobal
            sqlcaja = "INSERT INTO caja (codMovCaja, Fecha, operador, saldoinicial, saldo)"
            sqlcaja += "VALUES (" & miCaja.CodMovCaja & ", STR_TO_DATE('" & miCaja.Fecha & "','%d/%m/%Y'),"
            sqlcaja += "'" & miCaja.Operador & "', " & Replace(miCaja.Saldoinicial, ",", ".") & "," & Replace(miCaja.Saldo, ",", ".") & ")"
            Try
                ' MsgBox("compra caja: " + sqlcaja)
                meConecto3.EjecutarSQL(sqlcaja)
                ' MsgBox("Registro Guardado", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try
            meConecto3.Dispose()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BtnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorrar.Click
        Dim rowToDelete As Integer
        rowToDelete = DataGridViewCompras.Rows.GetFirstRow(DataGridViewElementStates.Selected)
        If (rowToDelete > -1) Then
            DataGridViewCompras.Rows.RemoveAt(rowToDelete)
        End If
        'sumo nuevamente la columna importe porque saque un item
        TxtTotal.Text = Sumar("Importe", DataGridViewCompras)
    End Sub

    Private Sub TxtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCantidad.TextChanged
        If IsNumeric(TxtCantidad.Text) Then
            If txtprecioUnitario.Text = "" Then
                
            Else

                TxtImporte.Text = (CDbl(TxtCantidad.Text) * CDbl(txtprecioUnitario.Text)).ToString("0.00")
            End If

        Else
            MsgBox("Ingrese números")
        End If
    End Sub

    Private Sub txtprecioUnitario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprecioUnitario.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar = _
                Threading.Thread.CurrentThread. _
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)
        End If
    End Sub

    Private Sub txtprecioUnitario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprecioUnitario.TextChanged
        Dim punitario As Decimal = 0
        Dim cantidad As Decimal = 1
        If IsNumeric(txtprecioUnitario.Text) Then
            cantidad = Convert.ToDecimal(TxtCantidad.Text)
            punitario = Convert.ToDecimal(txtprecioUnitario.Text)
            If cantidad >= 0 Then
                TxtImporte.Text = Convert.ToString(punitario * cantidad)
            Else
                MsgBox("Ingrese Articulo")
                TxtCantidad.Text = ""
            End If
        Else
            MsgBox("Ingrese números")
        End If
    End Sub

    Private Sub TxtCodArticulo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodArticulo.TextChanged
        Me.TxtDescArticulo.Text = ""
        Dim conecto As New GestionMySQL
        Dim miArticulo As New ClassArticulo
        'uso funcion para buscar en tabla , columna y campo que return un Datatable 
        tabla = conecto.BuscarArtStockID(TxtCodArticulo.Text)
        DataGridViewBarra.DataSource = tabla
        If DataGridViewBarra.RowCount > 1 Then
            If IsDBNull(DataGridViewBarra.SelectedCells(0).Value) Then
                miArticulo.IdArticulo = "1"
            Else
                miArticulo.IdArticulo = DataGridViewBarra.SelectedCells(0).Value
            End If
            If IsDBNull(DataGridViewBarra.SelectedCells(1).Value) Then
                miArticulo.Descripcion = "1"
            Else
                miArticulo.Descripcion = DataGridViewBarra.SelectedCells(1).Value
            End If
            If IsDBNull(DataGridViewBarra.SelectedCells(2).Value) Then
                miArticulo.PrecioCompra = "0"
            Else
                miArticulo.PrecioCompra = DataGridViewBarra.SelectedCells(2).Value
            End If
            If IsDBNull(DataGridViewBarra.SelectedCells(3).Value) Then
                miArticulo.PrecioVenta = "0"
            Else
                miArticulo.PrecioVenta = DataGridViewBarra.SelectedCells(3).Value
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.TxtDescArticulo.Text = miArticulo.Descripcion
            'Me.txtprecioUnitario.Text = miArticulo.PrecioCompra
            Me.TxtPVentaO.Text = miArticulo.PrecioVenta
            Me.TxtPVentaM.Text = miArticulo.PrecioVenta
            Me.txtprecioUnitario.Text = (miArticulo.PrecioCompra * 1).ToString("0.00")
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If
        TxtCantidad.Text = 1
    End Sub

    Private Sub CBPorcentaje_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBPorcentaje.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub CBPorcentaje_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBPorcentaje.SelectedIndexChanged
        TxtPVentaM.Text = Math.Round(CInt(txtprecioUnitario.Text) + ((CInt(txtprecioUnitario.Text) * CInt(CBPorcentaje.Text)) / 100), 0)
    End Sub

    Private Sub CBPorcentaje_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBPorcentaje.TextChanged
        If CBPorcentaje.Text = "" Then
        Else
            TxtPVentaM.Text = Math.Round(CInt(txtprecioUnitario.Text) + ((CInt(txtprecioUnitario.Text) * CInt(CBPorcentaje.Text)) / 100), 0)
        End If
    End Sub


End Class