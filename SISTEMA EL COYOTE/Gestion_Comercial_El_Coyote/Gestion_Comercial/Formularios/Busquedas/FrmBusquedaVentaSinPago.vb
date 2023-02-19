Public Class FrmBusquedaVentaSinPago
    Dim dt As New DataTable
    Dim miCliente As New ClassCliente
    Dim miConeccion As New GestionMySQL
    Dim miventa As New ClassVenta
    Dim micaja As New ClassCaja

    Private Sub FrmBusquedaProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarComboxVentaCC("RazonSocial", "RazonSocial")
        DateTimePicker1.Value = Date.Today
    End Sub

    Private Sub LlenarDatagridCliente()
        'Codigo, Fecha, Cantidad, Descripcion, PrecioUnitario, Importe, Apellido_Retira, Pagado


        Dim miConexionBuscar As New GestionMySQL
        Dim sql As String = ""
        Try
            sql = "CALL Get_ArticulosEnCCporCliente('" & LblIdcliente.Text & "')"
            dt = miConeccion.Consulta(sql)
            DGVVentasCC.DataSource = dt
            'cierro conexion
            miConeccion.Dispose()
            SumaColumnaDatagridTotal()
        Catch ex As Exception
            MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
        End Try
    End Sub

    Private Sub LlenarDatagridClienteRetira(ByVal retira)
        Dim miConexionBuscar As New GestionMySQL
        Dim sql As String = ""
        Try
            sql = "CALL Get_ArticulosEnCCporClienteRetira('" & LblIdcliente.Text & "', '" & retira & "' )"
            dt = miConeccion.Consulta(sql)
            DGVVentasCC.DataSource = dt
            'cierro conexion
            miConeccion.Dispose()
            SumaColumnaDatagridTotal()
        Catch ex As Exception
            MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
        End Try
    End Sub

    Private Sub BtnCobrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCobrar.Click

        If TxtTotalSelect.Text = "" Or TxtTotalSelect.Text = "0,00" Then
            MsgBox("Faltan datos " & vbNewLine & " Seleccione articulos")
        Else
            If CheckBCobraCC.Checked Then
                If CDbl(TxtTotalSelect.Text) > CDbl(TxtSaldo.Text) Then
                    MsgBox("Saldo depositado insufiiciente" & vbNewLine & "Debera depositar la diferencia")
                Else
                    cobroCC()
                    pagocondeposito()
                    ContraAsientopagoCC()
                    Me.Close()
                End If
            Else
                cobroCC()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub cobroCC()
        'SELECCION, Codigo, Fecha, Cantidad, Descripcion, PrecioUnitario, Importe, Apellido_Retira, Pagado 
        Dim bandera As Boolean = False
        For Each row As DataGridViewRow In DGVVentasCC.Rows
            If row.Cells(0).Value = True Then
                bandera = True
            End If
        Next
        If bandera = False Then
            MsgBox("Faltan datos " & vbNewLine & " Seleccione articulos")
        Else

            Dim miconexion1 As New GestionMySQL
            Dim consultaMysql1 As String = ""
            miventa.Fecha = DateTimePicker1.Value
            miventa.Total = Me.TxtTotalSelect.Text.Trim

            consultaMysql1 = "INSERT INTO ventas (fecha,total)"
            consultaMysql1 += "VALUES ( STR_TO_DATE('" & miventa.Fecha & "' ,'%d/%m/%Y') ," & Replace(miventa.Total, ",", ".") & ")"
            Try
                miconexion1.EjecutarSQL(consultaMysql1)
                'MsgBox("Registro Guardado", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try
            miconexion1.Dispose()

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

            Dim miconexion2 As New GestionMySQL
            Dim miconexion3 As New GestionMySQL
            Dim consultaMysql2 As String = ""
            miventa.IdVenta = Global_numeroVenta

            'con este ciclo recorro el datagridview

            'SELECCION, Codigo, Fecha, Cantidad, idarticulo, Descripcion, PrecioUnitario, Importe, Apellido_Retira, Pagado 

            For Each row As DataGridViewRow In DGVVentasCC.Rows

                If row.Cells(0).Value = True Then

                    consultaMysql2 = "INSERT INTO ventaarticulos (idVenta,idArticulo,Cantidad,PrecioUnitario,Importe)"
                    consultaMysql2 += "VALUES (" & miventa.IdVenta & ",'" & row.Cells(4).Value & "'," & row.Cells(3).Value & "," & Replace(row.Cells(6).Value, ",", ".") & "," & Replace(row.Cells(7).Value, ",", ".") & ")"
                    Try
                        miconexion2.EjecutarSQL(consultaMysql2)
                        'MsgBox(consultaMysql2)
                        'MsgBox("Registro Guardado", MsgBoxStyle.Information)
                    Catch ex As Exception
                        MsgBox(ex.ToString, MsgBoxStyle.Critical)
                    End Try

                    'Cambio de ventaccarticulo pagado si no

                    Dim consultaMysql3 As String = ""
                    consultaMysql3 = "Update ventaccarticulos SET "
                    consultaMysql3 += "Pagado = 'SI'"
                    consultaMysql3 += "WHERE idVentaccArticulo = '" & row.Cells(10).Value & "'; "

                    Try
                        miconexion3.EjecutarSQL(consultaMysql3)
                        'MsgBox(consultaMysql)
                        'MsgBox("Registro Guardado", MsgBoxStyle.Information)
                    Catch ex As Exception
                        MsgBox(ex.ToString, MsgBoxStyle.Critical)
                    End Try
                    '-----------------------------------------------------
                End If
            Next
            miconexion2.Dispose()
            miconexion3.Dispose()
            MsgBox("Registro Guardado", MsgBoxStyle.Information)

            'Graba en la caja solamente si no esta tildado el check box
            IngresoVentaCaja(miventa.IdVenta, miventa.Total, miventa.Fecha)
            'IMPRIME TICKET ????
            Dim resultado As DialogResult = MessageBox.Show("Desea imprimir ticket?",
                                                    "Atención", MessageBoxButtons.YesNo)
            If resultado = Windows.Forms.DialogResult.Yes Then
                FacturaImpresion.MdiParent = MDIMenu
                FacturaImpresion.Show()
            End If
        End If
    End Sub

    Private Sub SumaColumnaDatagridTotal()
        Try
            Dim Total As Double = 0
            Dim Col As DataGridViewRow = New DataGridViewRow()
            For Each Col In DGVVentasCC.Rows
                Total += Convert.ToDouble(Col.Cells("Importe").Value)
            Next
            TxtTotal.Text = Total.ToString("C")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SumaColumnaDatagridParcial()
        Dim Total As Double = 0

        For Each row As DataGridViewRow In DGVVentasCC.Rows
            If row.Cells(0).Value = True Then
                Total += Convert.ToDouble(row.Cells("Importe").Value)
            End If
        Next
        TxtTotalSelect.Text = Total.ToString("#0.00")

    End Sub

    Private Sub CBRazonSocial_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBRazonSocial.SelectedIndexChanged
        CBRetira.Text = ""
        LblIdRetira.Text = ""
        Get_idcliente(CBRazonSocial.Text)
    End Sub

    Public Sub llenarComboxVentaCC(ByVal display As String, ByVal value As String)
        Dim miGestionMySQLVentaCC As New GestionMySQL
        Dim dtVentaCC As New DataTable
        Dim sql As String = ("select RazonSocial from cliente")
        'MsgBox(sql)
        dtVentaCC = miGestionMySQLVentaCC.Consulta(sql)
        With Me.CBRazonSocial
            .DataSource = dtVentaCC              ' DataSource = DataTable
            .DisplayMember = display           ' DisplayMember = "Nombre" Nombre del campo que quieres que muestre el combo.
            .ValueMember = value               ' ValueMembes = "ID" Nombre de campo que utilizaras como identificador
        End With
        miGestionMySQLVentaCC.Dispose()
    End Sub

    Private Sub Get_idcliente(ByVal RazonSocial As String)
        Dim dtidcliente As New DataTable
        Dim miConexionIdCliente As New GestionMySQL
        Dim sql As String = ""
        Try
            sql = "select idcliente from cliente where Razonsocial = '" & RazonSocial & "'"
            'MsgBox(sql)
            dtidcliente = miConexionIdCliente.Consulta(sql)
            For Each MiDataRow In dtidcliente.Rows
                LblIdcliente.Text = MiDataRow("idcliente")
            Next
            miConexionIdCliente.Dispose()
        Catch ex As Exception
            MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
        End Try
    End Sub

    Private Sub LblIdcliente_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblIdcliente.TextChanged
        llenarComboxRetira("Apellido", "Apellido")
    End Sub

    Public Sub llenarComboxRetira(ByVal display As String, ByVal value As String)
        Dim miGestionMySQLRetira As New GestionMySQL
        Dim dtRetira As New DataTable
        Dim sql As String = ("select Apellido from clienteretira WHERE idcliente = '" & LblIdcliente.Text & " '")
        'MsgBox(sql)
        dtRetira = miGestionMySQLRetira.Consulta(sql)
        With Me.CBRetira
            .DataSource = dtRetira              ' DataSource = DataTable
            .DisplayMember = display           ' DisplayMember = "Nombre" Nombre del campo que quieres que muestre el combo.
            .ValueMember = value               ' ValueMembes = "ID" Nombre de campo que utilizaras como identificador
        End With
        miGestionMySQLRetira.Dispose()
    End Sub

    Private Sub Get_IdRetira(ByVal Apellido As String)
        Dim dtidretira As New DataTable
        Dim miConexionIdRetira As New GestionMySQL
        Dim sql As String = ""
        Try
            sql = "select dni from clienteretira WHERE Apellido = '" & Apellido & "'"
            'MsgBox(sql)
            dtidretira = miConexionIdRetira.Consulta(sql)
            For Each MiDataRow In dtidretira.Rows
                LblIdRetira.Text = MiDataRow("DNI")
            Next
            miConexionIdRetira.Dispose()
        Catch ex As Exception
            MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
        End Try
    End Sub

    Private Sub CBRetira_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBRetira.SelectedIndexChanged
        Get_IdRetira(CBRetira.Text)
    End Sub

    Private Sub BtnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarCliente.Click
        LlenarDatagridCliente()
        get_saldo(LblIdcliente.Text)
    End Sub

    Private Sub BtnBuscarClienteRetira_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarClienteRetira.Click
        LlenarDatagridClienteRetira(LblIdRetira.Text)
        get_saldo(LblIdcliente.Text)
    End Sub

    'Obrengo el subtotal de lo seleccionado
    Private Sub BtnTotalSeleccionado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTotalSeleccionado.Click
        SumaColumnaDatagridParcial()
    End Sub

    Private Sub DGVVentasCC_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVVentasCC.CellContentClick
        BtnTotalSeleccionado.PerformClick()
    End Sub

    'Obtengo saldo del cliente
    Private Sub get_saldo(ByVal cliente)

        Dim miGestionSaldo As New GestionMySQL
        Dim dtsaldo As New DataTable
        Dim pagocc As New ClassCuentaCorriente
        Dim consulta As String = "CALL Get_Saldo('" & LblIdcliente.Text & "')"
        Global_saldo = 0
        'MsgBox(consulta)
        dtsaldo = miGestionSaldo.Consulta(consulta)

        Try
            For Each MiDataRow As DataRow In dtsaldo.Rows
                If IsDBNull(MiDataRow("Saldo")) Then
                    Global_saldo = "0"
                Else
                    Global_saldo = MiDataRow("Saldo")
                End If
            Next
        Catch ex As Exception
            MsgBox("error" + ex.ToString)
        End Try
        TxtSaldo.Text = (Global_saldo).ToString("#0.00")

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
            MsgBox("error" + ex.ToString)
        End Try
        miConexion.Dispose()
    End Sub

    Private Sub Grabo_clienteVenta()
        Dim encabezado As New GestionMySQL
        Dim clienteventa As New ClassVenta
        Dim sql As String
        clienteventa.IdCliente = LblIdcliente.Text
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


    Public Sub IngresoVentaCaja(ByVal venta As String, ByVal importe As Decimal, ByVal fecha As String)
        Dim dttabla As New DataTable
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
        micaja.Saldo = Gestiondb.CalcularSaldo(DateTimePicker1.Text) + miventa.Total
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


    Private Sub pagocondeposito()

        Dim miGestionSaldo As New GestionMySQL
        Dim dtsaldo As New DataTable
        Dim pagocc As New ClassCuentaCorriente
        Dim consulta As String = "CALL Get_Saldo('" & LblIdcliente.Text & "')"
        Global_saldo = 0
        'MsgBox(consulta)
        dtsaldo = miGestionSaldo.Consulta(consulta)

        Try
            For Each MiDataRow As DataRow In dtsaldo.Rows
                If IsDBNull(MiDataRow("Saldo")) Then
                    Global_saldo = "0"
                Else
                    Global_saldo = MiDataRow("Saldo")
                End If
            Next
        Catch ex As Exception
            MsgBox("error" + ex.ToString)
        End Try
        Dim saldo As Double = Global_saldo
        Dim miGestionMySQL As New GestionMySQL
        Dim sql As String
        pagocc.IdCliente = Me.LblIdcliente.Text.Trim
        pagocc.Fecha = Me.DateTimePicker1.Text.Trim
        pagocc.Debe = Me.TxtTotalSelect.Text.Trim
        pagocc.Saldo = saldo - TxtTotalSelect.Text
        'idpagocc, idcliente, fecha, debe, haber, saldo
        Try

            sql = "INSERT INTO pagoCC (idcliente, fecha, debe, haber, saldo)"
            sql += "VALUES ('" & pagocc.IdCliente & "', STR_TO_DATE('" & pagocc.Fecha & "' ,'%d/%m/%Y'),"
            sql += "" & pagocc.Debe & ",  0," & pagocc.Saldo & ")"
            'MsgBox(sql)
            miGestionMySQL.EjecutarSQL(sql)
            miGestionMySQL.Dispose()
            MsgBox("Los Datos Insertados Correctamente en la Base de Datos", MsgBoxStyle.Information, "Insertar Datos")
        Catch ex As Exception
            MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
        End Try

    End Sub

    Private Sub CheckBCobraCC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBCobraCC.CheckedChanged
        If CheckBCobraCC.Checked = True Then
            MsgBox("Se aplicara el cobro sobre el saldo depositado")
        End If
    End Sub


    'Selecciono todo
    Private Sub CheckBoxTodos_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBoxTodos.CheckedChanged
        If CheckBoxTodos.Checked = True Then
            For Each row As DataGridViewRow In DGVVentasCC.Rows
                row.Cells(0).Value = True
            Next
        Else
            For Each row As DataGridViewRow In DGVVentasCC.Rows
                row.Cells(0).Value = False
            Next
        End If
    End Sub

    Public Sub ContraAsientopagoCC()

        Dim meConecto As New GestionMySQL
        Dim meConecto2 As New GestionMySQL
        Dim meConecto3 As New GestionMySQL
        Dim dtTabla As New DataTable
        Dim miCaja As New ClassCaja
        Dim sqlcaja As String = ""
        '
        ' idCajaMov, tipoMovimiento, Descripcion, tipoComprobante, serienumero, Importe
        Dim sql As String = ""
        miCaja.TipoMovimiento = "SALIDA"
        miCaja.Descripcion = "Pago Cta. Cte."
        miCaja.TipoComprobante = "Pago con depósito Cta. Cte."
        miCaja.Serienumero = LblIdcliente.Text
        miCaja.Importe = Convert.ToDecimal(TxtTotalSelect.Text)
        ' MsgBox(miCaja.Importe)
        miCaja.Ingreso = 0
        miCaja.Egreso = miCaja.Importe
        'If LblIngresoEgreso.Text = "INGRESO" Then
        '    miCaja.Ingreso = miCaja.Importe
        'ElseIf LblIngresoEgreso.Text = "SALIDA" Then
        '    miCaja.Egreso = miCaja.Importe
        'End If
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

        Catch ex As Exception
            MsgBox("error" + ex.ToString)
        End Try
        meConecto2.Dispose()

        '============================================================================================
        '----------------------- DEBE GRABAR EN LA TABLA CAJA ---------------------------
        'codCaja, codMovCaja, Fecha
        ' miCaja.CodMovCaja =Lblcodmov.Text
        Dim sqlcaja2 As String = ""
        Dim meConecto4 As New GestionMySQL
        Dim saldoT As Decimal = 0
        Dim saldoinicialT As Decimal = 0
        miCaja.Fecha = DateTimePicker1.Text.Trim
        miCaja.Operador = usuarioGlobal
        saldoT = CDec(meConecto4.CalcularSaldoInicial(DateTimePicker1.Text.Trim))
        saldoinicialT = CDec(meConecto4.CalcularSaldo(DateTimePicker1.Text.Trim) - miCaja.Importe)
        miCaja.Saldoinicial = saldoT
        miCaja.Saldo = saldoinicialT

        'codCaja, codMovCaja, Fecha, operador, saldoinicial, saldo
        sqlcaja2 = "INSERT INTO caja (codMovCaja, Fecha, operador, saldoinicial, saldo)"
        sqlcaja2 += "VALUES (" & miCaja.CodMovCaja & ", STR_TO_DATE('" & miCaja.Fecha & "','%d/%m/%Y'),"
        sqlcaja2 += "'" & miCaja.Operador & "', " & Replace(miCaja.Saldoinicial, ",", ".") & "," & Replace(miCaja.Saldo, ",", ".") & ")"

        'MsgBox(sqlcaja2)
        Try
            meConecto4.EjecutarSQL(sqlcaja2)
            MsgBox("Registrado", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        meConecto4.Dispose()
        '=========================================

    End Sub


End Class