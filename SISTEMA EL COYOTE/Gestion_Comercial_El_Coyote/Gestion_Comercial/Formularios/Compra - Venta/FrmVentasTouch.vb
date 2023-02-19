Public Class FrmVentasTouch

    Dim dttabla As New DataTable
    Dim miArticulo As New ClassArticulo
    Dim miVenta As New ClassVenta
    Dim micaja As New ClassCaja
    Dim ControlStock As Integer = 0
    Dim cantidadgridTouch As String = ""

    Private Sub FrmVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Date.Today
        ObtengoNumeroVenta()
        TxtBuscarCodigoBarra.Focus()
        TxtBuscarCodigoBarra.Select()
    End Sub

    Private Sub BtnArticulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArticulos.Click
        FrmBusquedaArticulo.MdiParent = MDIMenu
        FrmBusquedaArticulo.Show()
        FrmBusquedaArticulo.BtnCopiarVentaTouch.Visible = True
    End Sub

    Private Sub BtnBusquedaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBusquedaCliente.Click
        FrmBusquedaCliente.MdiParent = MDIMenu
        FrmBusquedaCliente.Show()
        FrmBusquedaCliente.BtnCopiaVentaTouch.Visible = True
    End Sub

    Private Sub BtnIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngreso.Click

        If Txtcantidad.Text = "" Or TxtidProducto.Text = "" Then     'Or TxtImporte.Text = 0
            MsgBox("INGRESE ARTICULO")
            TxtBuscarCodigoBarra.Text = ""
            TxtBuscarCodigoBarra.Select()
        Else
            If Convert.ToInt32(Txtcantidad.Text) > Convert.ToInt32(TxtStock.Text) Then
                MsgBox("No existe la cantidad solicitada :Pedir Articulo" & vbNewLine &
                       "Stock Minimo = " & TxtStockminimo.Text & vbNewLine &
                       "Stock Actual = " & TxtStock.Text & vbNewLine &
                       "Cantidad Solicitada = " & Txtcantidad.Text)
            ElseIf TxtImporte.Text > 0 Then
                ' lleno el datagridview en el mismo orden que tengan las columnas
                Dim values() As Object = {Txtcantidad.Text, TxtidProducto.Text, Txtdescripcion.Text, txtprecioUnitario.Text, TxtImporte.Text, TxtStock.Text}
                ' Añadimos una nueva fila al control DataGridView
                Dim index As Integer = DataGridViewIngVenta.Rows.Add()
                ' Referenciamos la nueva fila
                Dim currentRow As DataGridViewRow = DataGridViewIngVenta.Rows(index)
                ' Añadimos los valores a las celdas de la fila
                currentRow.SetValues(values)
                'limpio los textbox
                Txtcantidad.Text = 0
                TxtidProducto.Text = ""
                Txtdescripcion.Text = ""
                txtprecioUnitario.Text = 0
                TxtImporte.Text = 0
                TxtBuscarCodigoBarra.Text = ""
                'Uso funcion sumar para sumar la columna Importe
                TxtTotal.Text = Sumar("Importe", DataGridViewIngVenta).ToString("0.00")
                TxtBuscarCodigoBarra.Select()
                'limpio panel de articulo y foto
                TxtIdArticulo.Text = ""
                TxtArticulo.Text = ""
                TxtMarca.Text = ""
                TxtPrecioVenta.Text = "0.00"
                TxtStock.Text = "0"
                TxtStockminimo.Text = "0"
                PictureBox1.Image = Nothing
            Else
                MsgBox("Ingrese  ARTICULO")
                TxtBuscarCodigoBarra.Text = ""
                TxtBuscarCodigoBarra.Select()
            End If
        End If
    End Sub



    Private Sub BtnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorrar.Click
        Dim rowToDelete As Integer
        rowToDelete = DataGridViewIngVenta.Rows.GetFirstRow(DataGridViewElementStates.Selected)
        If (rowToDelete > -1) Then
            DataGridViewIngVenta.Rows.RemoveAt(rowToDelete)
        End If
        'sumo nuevamente la columna importe porque saque un item
        TxtTotal.Text = Sumar("Importe", DataGridViewIngVenta).ToString("0.00")
    End Sub

    Private Sub ayudaLTC()
        'vacio a cada cambio de letra el textbox
        Me.TxtidProducto.Text = ""
        Me.Txtdescripcion.Text = ""
        Me.txtprecioUnitario.Text = 0
        Me.TxtIdArticulo.Text = ""
        Me.TxtArticulo.Text = ""
        Me.TxtPrecioVenta.Text = ""
        Me.TxtMarca.Text = ""
        Me.TxtStock.Text = ""
        Me.TxtStockminimo.Text = ""
        Me.PictureBox1.Image = Nothing

    End Sub



    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.TxtImporte.Text = 0
        Me.TxtidProducto.Text = ""
        Me.Txtdescripcion.Text = ""
        Me.txtprecioUnitario.Text = 0
        Me.TxtIdArticulo.Text = ""
        Me.TxtArticulo.Text = ""
        Me.TxtPrecioVenta.Text = ""
        Me.TxtMarca.Text = ""
        Me.TxtStock.Text = ""
        Me.TxtStockminimo.Text = ""
        Me.PictureBox1.Image = Nothing
        Me.LblIdCliente.Text = ""
        Me.TxtRazonSocial.Clear()
        Me.TxtTotal.Clear()
        Me.TxtBuscarCodigoBarra.Text = ""
        Me.TxtBuscarCodigoBarra.Select()
    End Sub

    Private Sub LblIdCliente_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        If LblIdCliente.Text <> "Sin_Cliente" Then
            LblIdCliente.ForeColor = Color.Black
        Else
            LblIdCliente.ForeColor = Color.Red
        End If
    End Sub

    Private Sub TxtBuscarCodigoBarra_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TxtBuscarCodigoBarra.KeyDown
        Dim miImagen As Image = PictureBox1.Image
        Select Case e.KeyData
            Case Keys.Enter
                ayudaLTC()
                If TxtBuscarCodigoBarra.Text <> "" Then
                    'conecto
                    Dim consulta As New GestionMySQL
                    'uso funcion para buscar en tabla , columna y campo que return un Datatable 
                    dttabla = consulta.BuscarArtStockID(TxtBuscarCodigoBarra.Text)

                    If dttabla.Rows.Count = 0 Then
                        MsgBox("Articulo NO cargado")
                        TxtBuscarCodigoBarra.Text = ""
                        TxtBuscarCodigoBarra.Select()

                    Else

                        For Each fila As DataRow In dttabla.Rows
                            If IsDBNull(fila("IdArticulo")) Then
                                miArticulo.IdArticulo = "0"
                            Else
                                miArticulo.IdArticulo = fila("IdArticulo")
                            End If
                            If IsDBNull(fila("Descripcion")) Then
                                miArticulo.Descripcion = ""
                            Else
                                miArticulo.Descripcion = fila("Descripcion")
                            End If
                            If IsDBNull(fila("PrecioVenta")) Then
                                miArticulo.PrecioVenta = "0"
                            Else
                                miArticulo.PrecioVenta = fila("PrecioVenta")
                            End If
                            If IsDBNull(fila("Marca")) Then
                                miArticulo.Marca = ""
                            Else
                                miArticulo.Marca = fila("Marca")
                            End If
                            If IsDBNull(fila("Imagen")) Then
                                miArticulo.Foto = Nothing
                            Else
                                miImagen = Bytes_Imagen(fila("Imagen"))
                            End If
                            If IsDBNull(fila("Rubro")) Then
                                miArticulo.Rubro = "0"
                            Else
                                miArticulo.Rubro = fila("Rubro")
                            End If
                            If IsDBNull(fila("Stock")) Then
                                miArticulo.Stock = "0"
                            Else
                                miArticulo.Stock = fila("Stock")
                            End If
                            If IsDBNull(fila("StockMinimo")) Then
                                miArticulo.StockMinimo = "0"
                            Else
                                miArticulo.StockMinimo = fila("StockMinimo")
                            End If
                        Next
                        'calcularimporte()
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

                        Txtcantidad.Text = 1
                        TxtImporte.Text = (Txtcantidad.Text * txtprecioUnitario.Text)

                    End If
                End If
            Case Keys.Add
                BtnIngreso.PerformClick()
            Case Keys.F1
                BtnVenta.PerformClick()
            Case Keys.F5
                BtnArticulos.PerformClick()
            Case Keys.F6
                BtnBusquedaCliente.PerformClick()
        End Select
    End Sub
    Private Sub TxtBuscarCodigoBarra_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtBuscarCodigoBarra.KeyUp
        If TxtBuscarCodigoBarra.Text = "+" Then
            TxtBuscarCodigoBarra.Text = ""
        End If
    End Sub



    Private Sub TxtBuscarCodigoBarra_Enter(sender As Object, e As EventArgs) Handles TxtBuscarCodigoBarra.Enter
        TxtBuscarCodigoBarra.BackColor = Color.Azure
        Lblseleccionado.Text = "TxtBuscarCodigoBarra.text"
    End Sub
    Private Sub TxtBuscarCodigoBarra_Leave(sender As Object, e As EventArgs) Handles TxtBuscarCodigoBarra.Leave
        TxtBuscarCodigoBarra.BackColor = Color.White
    End Sub


    Private Sub TxtRazonSocial_Enter(sender As Object, e As EventArgs) Handles TxtRazonSocial.Enter
        TxtRazonSocial.BackColor = Color.Azure
    End Sub
    Private Sub TxtRazonSocial_Leave(sender As Object, e As EventArgs) Handles TxtRazonSocial.Leave
        TxtRazonSocial.BackColor = Color.White
    End Sub


    Private Sub DataGridViewIngVenta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewIngVenta.CellClick
        Lblseleccionado.Text = "Cell"
    End Sub

    Private Sub DataGridViewIngVenta_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewIngVenta.CellValueChanged
        Try
            Dim PrecioUnitario As Decimal = 0
            Dim Cantidad As Integer = 0
            Dim stock As Integer = 0
            Dim row As DataGridViewRow = CType(DataGridViewIngVenta.Rows(e.RowIndex), DataGridViewRow)
            PrecioUnitario = row.Cells("PrecioUnitario").Value
            Cantidad = row.Cells("Cantidad").Value
            stock = row.Cells("stock").Value
            row.Cells("Importe").Value = PrecioUnitario * Cantidad
            TxtTotal.Text = Sumar("Importe", DataGridViewIngVenta).ToString("0.00")
        Catch ex As Exception
        End Try
    End Sub


    '*****************************    T E C L A D O  ******************************************************************

    Private Sub BtnCero_Click(sender As Object, e As EventArgs) Handles BtnCero.Click
        If Lblseleccionado.Text = "TxtBuscarCodigoBarra.text" And TxtBuscarCodigoBarra.TextLength < 13 Then
            TxtBuscarCodigoBarra.Text += "0"
        End If
        If Lblseleccionado.Text = "Cell" Then
            DataGridViewIngVenta.CurrentCell.Value += "0"
        End If
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        If Lblseleccionado.Text = "TxtBuscarCodigoBarra.text" And TxtBuscarCodigoBarra.TextLength < 13 Then
            TxtBuscarCodigoBarra.Text += "1"
        End If
        If Lblseleccionado.Text = "Cell" Then
            DataGridViewIngVenta.CurrentCell.Value += "1"
        End If
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        If Lblseleccionado.Text = "TxtBuscarCodigoBarra.text" And TxtBuscarCodigoBarra.TextLength < 13 Then
            TxtBuscarCodigoBarra.Text += "2"
        End If
        If Lblseleccionado.Text = "Cell" Then
            DataGridViewIngVenta.CurrentCell.Value += "2"
        End If
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        If Lblseleccionado.Text = "TxtBuscarCodigoBarra.text" And TxtBuscarCodigoBarra.TextLength < 13 Then
            TxtBuscarCodigoBarra.Text += "3"
        End If
        If Lblseleccionado.Text = "Cell" Then
            DataGridViewIngVenta.CurrentCell.Value += "3"
        End If
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        If Lblseleccionado.Text = "TxtBuscarCodigoBarra.text" And TxtBuscarCodigoBarra.TextLength < 13 Then
            TxtBuscarCodigoBarra.Text += "4"
        End If
        If Lblseleccionado.Text = "Cell" Then
            DataGridViewIngVenta.CurrentCell.Value += "4"
        End If
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        If Lblseleccionado.Text = "TxtBuscarCodigoBarra.text" And TxtBuscarCodigoBarra.TextLength < 13 Then
            TxtBuscarCodigoBarra.Text += "5"
        End If
        If Lblseleccionado.Text = "Cell" Then
            DataGridViewIngVenta.CurrentCell.Value += "5"
        End If
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        If Lblseleccionado.Text = "TxtBuscarCodigoBarra.text" And TxtBuscarCodigoBarra.TextLength < 13 Then
            TxtBuscarCodigoBarra.Text += "6"
        End If
        If Lblseleccionado.Text = "Cell" Then
            DataGridViewIngVenta.CurrentCell.Value += "6"
        End If
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        If Lblseleccionado.Text = "TxtBuscarCodigoBarra.text" And TxtBuscarCodigoBarra.TextLength < 13 Then
            TxtBuscarCodigoBarra.Text += "7"
        End If
        If Lblseleccionado.Text = "Cell" Then
            DataGridViewIngVenta.CurrentCell.Value += "7"
        End If
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        If Lblseleccionado.Text = "TxtBuscarCodigoBarra.text" And TxtBuscarCodigoBarra.TextLength < 13 Then
            TxtBuscarCodigoBarra.Text += "8"
        End If
        If Lblseleccionado.Text = "Cell" Then
            DataGridViewIngVenta.CurrentCell.Value += "8"
        End If
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        If Lblseleccionado.Text = "TxtBuscarCodigoBarra.text" And TxtBuscarCodigoBarra.TextLength < 13 Then
            TxtBuscarCodigoBarra.Text += "9"
        End If
        If Lblseleccionado.Text = "Cell" Then
            DataGridViewIngVenta.CurrentCell.Value += "9"
        End If
    End Sub


    Private Sub BtnC_Click(sender As Object, e As EventArgs) Handles BtnC.Click
        If Lblseleccionado.Text = "TxtBuscarCodigoBarra.text" Then
            TxtBuscarCodigoBarra.Text = ""
        End If
        If Lblseleccionado.Text = "Cell" Then
            DataGridViewIngVenta.CurrentCell.Value = ""
        End If
    End Sub


    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click

        If Lblseleccionado.Text = "TxtBuscarCodigoBarra.text" Then
            TxtBuscarCodigoBarra.Select()
            SendKeys.Send("{ENTER}")
        End If
        If Lblseleccionado.Text = "Txtcantidad.text" Then
            Txtcantidad.Select()
            SendKeys.Send("{ENTER}")
        End If
    End Sub



    Private Sub BtnFlechaArriba_Click(sender As Object, e As EventArgs) Handles BtnFlechaArriba.Click

        If DataGridViewIngVenta.RowCount > 0 Then
            Lblseleccionado.Text = "Cell"
            Dim Actual As Integer = DataGridViewIngVenta.CurrentCell.RowIndex
            Dim Atras As Integer = Actual - 1
            Try
                If Atras >= 0 Then
                    DataGridViewIngVenta.CurrentCell = DataGridViewIngVenta.Rows(Atras).Cells(0)
                    DataGridViewIngVenta.Rows(Atras).Selected = True

                Else
                    'MsgBox("Llego al inicio")
                End If
            Catch ex As Exception
                MsgBox("No se completo el proceso por: " & ex.Message)
            End Try
        Else
            MsgBox("Ingrese un Articulo")
        End If
    End Sub

    Private Sub BtnFlechaAbajo_Click(sender As Object, e As EventArgs) Handles BtnFlechaAbajo.Click
        If DataGridViewIngVenta.RowCount > 0 Then
            Lblseleccionado.Text = "Cell"
            Dim Actual As Integer = DataGridViewIngVenta.CurrentCell.RowIndex
            Dim Siguiente As Integer = Actual + 1
            Try
                If DataGridViewIngVenta.RowCount > Siguiente Then
                    DataGridViewIngVenta.CurrentCell = DataGridViewIngVenta.Rows(Siguiente).Cells(0)
                    DataGridViewIngVenta.Rows(Siguiente).Selected = True

                Else
                    'MsgBox("Llego al final")
                End If
            Catch ex As Exception
                MsgBox("No se completo el proceso por: " & ex.Message)
            End Try
        Else
            MsgBox("Ingrese un Articulo")
        End If
    End Sub


    '*************************************************************

    '******************************            V E N T A             *************************************************** 

    Private Sub BtnVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVenta.Click

        If DataGridViewIngVenta.RowCount = 0 Then
            MsgBox("Faltan datos " & vbNewLine & " para completar la Venta")
            TxtBuscarCodigoBarra.Select()
            Exit Sub
        Else
            'Control de cantidad  NO cero
            Dim Cero As String = ""
            For Each fila As DataGridViewRow In DataGridViewIngVenta.Rows
                Cero = DataGridViewIngVenta.CurrentRow.Cells("cantidad").Value
                If Cero = "0" Or Cero = "" Then
                    MsgBox("Cantidad erronea de Articulo")
                    Exit Sub
                End If
            Next
            'control stock
            Dim cantidad As Integer = 0
            Dim stock As Integer = 0
            For Each fila As DataGridViewRow In DataGridViewIngVenta.Rows
                cantidad = DataGridViewIngVenta.CurrentRow.Cells("cantidad").Value
                stock = DataGridViewIngVenta.CurrentRow.Cells("stock").Value

                If cantidad > stock Then
                    MsgBox("Cantidad supera al STOCK" & vbNewLine &
                      "Stock Disponible = " & stock)
                    Exit Sub
                End If
            Next
            'grabo VENTA
            Dim miconexion1 As New GestionMySQL
            Dim consultaMysql1 As String = ""
            miVenta.Fecha = DateTimePicker1.Value
            miVenta.Total = Me.TxtTotal.Text.Trim
            'ventaImporte = totalPedido
            consultaMysql1 = "INSERT INTO ventas (fecha,total)"
            consultaMysql1 += "VALUES ( STR_TO_DATE('" & miVenta.Fecha & "' ,'%d/%m/%Y') ," & Replace(miVenta.Total, ",", ".") & ")"
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
        ObtengoNumeroVenta()
        Grabo_clienteVenta()
        '============================================================================================
        'HAY QUE RECORRER EL DATAGRIED E IR GRABANDO EN LA
        'TABLA ventaarticulos
        'Tomar el idventas del lblNumeroPedido.text
        '( idVenta, idArticulo, Cantidad, PrecioUnitario, Importe )
        ''------------------------------------------------------------------------------------
        If DataGridViewIngVenta.RowCount = 0 Then
            MsgBox("Ingrese los datos " & vbNewLine & " de la venta")
            Txtcantidad.Select()
        Else
            Dim miconexion2 As New GestionMySQL
            Dim miconexion3 As New GestionMySQL
            'Dim idVta As Integer
            Dim consultaMysql2 As String = ""
            miVenta.IdVenta = Global_numeroVenta
            'ventaNumero = Global_numeroVenta
            'con este ciclo recorro el datagridview
            For Each row As DataGridViewRow In DataGridViewIngVenta.Rows
                consultaMysql2 = "INSERT INTO ventaarticulos (idVenta,idArticulo,Cantidad,PrecioUnitario,Importe)"
                consultaMysql2 += "VALUES (" & miVenta.IdVenta & ",'" & row.Cells(1).Value & "'," & row.Cells(0).Value & "," & Replace(row.Cells(3).Value, ",", ".") & "," & Replace(row.Cells(4).Value, ",", ".") & ")"
                Try
                    miconexion2.EjecutarSQL(consultaMysql2)
                    'MsgBox(consultaMysql)
                    'MsgBox("Registro Guardado", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical)
                End Try
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
            miconexion2.Dispose()
            miconexion3.Dispose()
            MsgBox("Registro Guardado", MsgBoxStyle.Information)
            '********************************************************************
            '**********************GRABO EN CAJA*********************************
            IngresoVentaCaja(miVenta.IdVenta, miVenta.Total, miVenta.Fecha)
            '************************************************************************
        End If
        Me.Close()
        'IMPRIME TICKET ????
        Dim resultado As DialogResult = MessageBox.Show("Desea imprimir ticket?",
                                                    "Atención", MessageBoxButtons.YesNo)
        If resultado = Windows.Forms.DialogResult.Yes Then
            FacturaImpresion.MdiParent = MDIMenu
            FacturaImpresion.Show()
        End If
    End Sub


    Public Sub IngresoVentaCaja(ByVal venta As String, ByVal importe As Decimal, ByVal fecha As String)
        Dim miconexion1 As New GestionMySQL
        Dim miVentaCaja As New ClassCaja
        Dim consultaMysql As String = ""
        miVentaCaja.TipoMovimiento = "INGRESO"
        miVentaCaja.Descripcion = "VENTA"
        miVentaCaja.TipoComprobante = "No valido como factura"
        miVentaCaja.Serienumero = venta
        miVentaCaja.Egreso = 0
        miVentaCaja.Ingreso = importe
        'MsgBox("importe Ingreso" & ": " & importeIngreso & ": " & "importe egreso" & ": " & importeEgreso)
        consultaMysql = "INSERT INTO cajamov (tipoMovimiento, Descripcion, tipoComprobante, serienumero, ingreso,egreso)"
        consultaMysql += "VALUES ('" & miVentaCaja.TipoMovimiento & "','" & miVentaCaja.Descripcion & "','" & miVentaCaja.TipoComprobante & "','" & miVentaCaja.Serienumero & "'," & Replace(miVentaCaja.Ingreso, ",", ".") & "," & Replace(miVentaCaja.Egreso, ",", ".") & ")"
        Try
            miconexion1.EjecutarSQL(consultaMysql)
            'MsgBox(consultaMysql)
            'MsgBox("Registro Guardado", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        miconexion1.Dispose()
        '======== Obtengo el ULTIMO CODMOV GRABADO en  tabla cajamov (autoincremental)==================
        Dim miconexion2 As New GestionMySQL
        Dim sql As String = ""
        sql = "SELECT MAX(idCajaMov) as ultimoCodmov FROM cajamov;"
        miconexion2.EjecutarSQL(sql)
        dttabla = miconexion2.Consulta(sql)
        Try
            For Each MiDataRow As DataRow In dttabla.Rows
                If IsDBNull(MiDataRow("ultimoCodmov")) Then
                    micaja.CodMovCaja = 0
                Else
                    micaja.CodMovCaja = MiDataRow("ultimoCodmov")
                End If
            Next
        Catch ex As Exception
            MsgBox("error" + ex.ToString)
        End Try
        miconexion2.Dispose()
        '============================================================================================
        '----------------------- DEBE GRABAR EN LA TABLA CAJA ---------------------------
        Dim Gestiondb As New GestionMySQL
        micaja.Saldo = Gestiondb.CalcularSaldo(DateTimePicker1.Text) + miVenta.Total
        ' MsgBox(micaja.Saldo)
        micaja.Saldoinicial = Gestiondb.CalcularSaldoInicial(DateTimePicker1.Text)
        ' MsgBox(micaja.Saldoinicial)
        Dim miconexion3 As New GestionMySQL
        Dim sqlcaja As String = ""
        micaja.Fecha = DateTimePicker1.Value
        sqlcaja = "INSERT INTO caja (codMovCaja, Fecha, operador, saldoinicial, saldo)"
        sqlcaja += "VALUES (" & micaja.CodMovCaja & ", STR_TO_DATE('" & micaja.Fecha & "','%d/%m/%Y'),"
        sqlcaja += "'" & micaja.Operador & "', " & Replace(micaja.Saldoinicial, ",", ".") & "," & Replace(micaja.Saldo, ",", ".") & ")"
        Try
            ' MsgBox(sqlcaja)
            miconexion3.EjecutarSQL(sqlcaja)
            ' MsgBox("Registro Guardado", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        miconexion3.Dispose()
        Gestiondb.Dispose()
    End Sub


    Private Sub Grabo_clienteVenta()
        Dim encabezado As New GestionMySQL
        Dim clienteventa As New ClassVenta
        Dim sql As String
        clienteventa.IdCliente = LblIdCliente.Text
        clienteventa.IdVenta = Global_numeroVenta
        Try
            sql = "INSERT INTO clienteventa (idVenta, idCliente)"
            sql += "VALUES (" & clienteventa.IdVenta & ",'" & clienteventa.IdCliente & "')"
            encabezado.EjecutarSQL(sql)
            encabezado.Dispose()
            'MsgBox("Registro Guardado clienteventa", MsgBoxStyle.Information)
        Catch ex As Exception
            ' MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub ObtengoNumeroVenta()
        Dim miConexion As New GestionMySQL
        Dim dtTabla As New DataTable
        Global_numeroVenta = 0
        '======== Obtengo el ULTIMO idventas tabla ventas(autoincremental)====================
        Dim sql As String
        sql = "SELECT MAX(idVentas) as ultimoIdv FROM Ventas;"
        miConexion.EjecutarSQL(sql)
        dtTabla = miConexion.Consulta(sql)
        Try
            For Each MiDataRow As DataRow In dtTabla.Rows
                Dim ultimoIdP As String = ""
                Global_numeroVenta = MiDataRow("ultimoIdV")
            Next
        Catch ex As Exception
            'MsgBox("Realizara su primera VENTA " + ex.ToString)
            MsgBox("Realizara su primera VENTA ")
        End Try
        miConexion.Dispose()
    End Sub


End Class