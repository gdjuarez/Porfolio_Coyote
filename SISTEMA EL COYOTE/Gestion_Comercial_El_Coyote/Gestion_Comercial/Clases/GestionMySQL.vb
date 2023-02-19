Imports MySql.Data.MySqlClient

Public Class GestionMySQL
    Private miConexion As New MySqlConnection
    Private miComando As New MySqlCommand

    Public Sub New()
        Try
            miConexion.ConnectionString = (Global_Conexion_Local)
            miConexion.Open()
            miComando.Connection = miConexion
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub EjecutarSQL(ByVal SentenciaSQL As String)
        miComando.CommandText = SentenciaSQL
        miComando.ExecuteNonQuery()
    End Sub

    Public Sub Dispose()
        miConexion.Close()
        miConexion.Dispose()
        miComando.Dispose()
    End Sub

    Public Function ConsultarTabla(ByVal tabla As String) As DataTable
        Dim dt As New DataTable
        Dim strMysql As String = "SELECT * FROM " + tabla
        'MsgBox(strMysql)
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

    Public Function BuscarenTablaEscribo(ByVal tabla As String, ByVal columna As String, ByVal campo As String) As DataTable
        Dim dt As New DataTable
        Dim strMysql As String = "SELECT * FROM " & tabla & " WHERE " & columna & " LIKE '" & campo & "%'"
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

    Public Function BuscarArtStockDescripcion(ByVal campo As String) As DataTable
        Dim dt As New DataTable
        Dim strMysql As String
        strMysql = "SELECT v.idArticulo, v.Descripcion, v.PrecioCompra, v.PrecioVenta, v.Marca, "
        strMysql += "v.Imagen,v.Rubro, s.Stock, s.StockMinimo,v.situado "
        strMysql += "From articulo v inner join stockarticulos s on v.idArticulo = s.idArticulo Where Descripcion  LIKE '" & campo & "%'"
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

    Public Function BuscarPresupuesto(ByVal campo As String) As DataTable
        Dim dt As New DataTable
        Dim strMysql As String
        strMysql = "SELECT p.idPresupuesto, p.Fecha, c.RazonSocial, c.Nombre, c.Apellido, p.Total "
        strMysql += "FROM presupuestos p left join clientepresupuesto cp "
        strMysql += "on p.idpresupuesto = cp.idpresupuesto left join cliente c "
        strMysql += "on c.idcliente = cp.idcliente Where p.idPresupuesto LIKE '" & campo & "%'"
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

    Public Function BuscarArtStockID(ByVal idArticulo As String) As DataTable
        Dim dt As New DataTable
        Dim strMysql As String
        strMysql = "SELECT v.idArticulo, v.Descripcion, v.PrecioCompra, v.PrecioVenta, v.Marca, "
        strMysql += "v.Imagen,v.Rubro, s.Stock, s.StockMinimo,v.situado "
        strMysql += "FROM articulo v inner join stockarticulos s on v.idArticulo = s.idArticulo Where v.idArticulo ='" & idArticulo & "'"
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

    Public Function Consulta(ByVal sql As String) As DataTable
        Dim dt As New DataTable
        Dim strMysql As String = sql
        'MsgBox(strMysql)
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

    Public Function Agrego_Presupuesto(ByVal numero As String) As DataTable
        Dim miDt As New DataTable
        Dim strMysql As String
        strMysql = "SELECT  cantidad, idArticulo as Codigo,Descripcion as Detalle,Preciounitario,Importe FROM  vistapresupuesto "
        strMysql += "WHERE idPresupuesto = " & numero
        'MsgBox(strMysql)
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(miDt)
        miConexion.Close()
        Return miDt
    End Function

    '--------------ComprobanteCC --- cuenta corriente uso Global_numeroVentaCC
    Public Function get_ComprobanteCC(ByVal numeroVentacc As Integer) As DataTable
        Dim dt As New DataTable
        Dim strMysql As String
        strMysql = "SELECT"
        strMysql += "cl.RazonSocial, cl.Apellido, Cl.Nombre,cl.Domicilio,v.idVentascc, v.Fecha, v.Total,"
        strMysql += "va.idVentaccArticulo, va.idArticulo, a.Descripcion, va.Cantidad, va.PrecioUnitario, va.Importe"
        strMysql += "FROM ventascc v"
        strMysql += "left join ventaccarticulos va on va.idventacc= v.idventasCC "
        strMysql += "left join Articulo a on a.idArticulo=va.idArticulo "
        strMysql += "left join clienteventacc cv on cv.idventacc = v.idventascc "
        strMysql += "left join cliente cl on cl.idcliente = cv.idcliente "
        strMysql += " where v.idVentascc = " & numeroVentacc & ""


        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

    '------Dataset para reporte presupuesto---
    Public Function Presupuesto(ByVal numero As String) As DataSet
        Dim miDataSet As New DataSet
        Dim strMysql As String
        strMysql = "SELECT * FROM  vistapresupuesto "
        strMysql += "WHERE idPresupuesto = " & numero
        'MsgBox(strMysql)
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(miDataSet)
        miConexion.Close()
        Return miDataSet
    End Function


    '----------get_Factura para ANULAR la venta  DETALLE----------------------------
    Public Function Anular_Venta_Detalle(ByVal numeroVenta As Integer) As DataTable
        Dim dt As New DataTable
        Dim strMysql As String = ""
        strMysql += "SELECT va.Cantidad,va.idArticulo as codigo ,a.Descripcion as Detalle,  va.PrecioUnitario, va.Importe "
        strMysql += "FROM ventas v "
        strMysql += "inner join ventaarticulos va on va.idventa= v.idventas "
        strMysql += "inner join Articulo a on a.idArticulo=va.idArticulo "
        strMysql += "where idVenta = " & numeroVenta

        'MsgBox(strMysql)
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

    '---------------------------------------------------------------------------


    '------------------CAJA------------------------

    Public Function ConsultarMovimientosCaja(ByVal FECHA As Date) As DataTable

        Dim dt As New DataTable
        Dim strMysql As String = "SELECT * FROM vistacajamovimientos WHERE Fecha =  STR_TO_DATE('" & FECHA & "' ,'%d/%m/%Y') "
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)

        adaptador.Fill(dt)
        miConexion.Close()

        Return dt

    End Function


    Public Function CalcularSaldoInicial(ByVal FECHA As Date) As Decimal
        '====================== S A L D O  I N I C I A L =================================================
        '======== Obtengo el ultimo SALDO GRABADO en  tabla caja MENOR A LA FECHA ELEGIDA=================
        Dim miConexion As New GestionMySQL
        Dim dtSaldo As New DataTable
        Dim saldoInicial As String = "0.00"
        Dim sql As String = ""

        'Busco el ultimo registro grabado en la TABLA CAJA anterior a la fecha de hoy
        sql = "SELECT saldo FROM caja WHERE codCaja =(SELECT MAX(codCaja) FROM caja WHERE FECHA < STR_TO_DATE('" & FECHA & "' ,'%d/%m/%Y'))"

        Try
            dtSaldo = miConexion.Consulta(sql)
            For Each MiDataRow As DataRow In dtSaldo.Rows
                If IsDBNull(MiDataRow("saldo")) Then
                    saldoInicial = "0.00"
                Else
                    saldoInicial = MiDataRow("saldo")
                End If
            Next
            ' MsgBox(saldoInicial)
        Catch ex As Exception
            MsgBox("error" + ex.ToString)
        End Try
        miConexion.Dispose()

        Return saldoInicial

    End Function

    Public Function CalcularSaldo(ByVal FECHA As Date) As Decimal
        Dim misaldoinicial
        misaldoinicial = CalcularSaldoInicial(FECHA)

        Dim miConexion As New GestionMySQL
        Dim dtTabla As New DataTable
        Dim sumasalida, sumaIngreso As Decimal

        '-----------------------------suma salida---y -suma INGRESOS---------------------------
        Dim sql As String
        sql = "SELECT SUM(ImporteSalida) as salida,SUM(ImporteIngreso) as ingreso FROM vistacajamovimientos "
        sql += "WHERE Fecha = STR_TO_DATE('" & FECHA & "' ,'%d/%m/%Y') "
        miConexion.EjecutarSQL(sql)
        dtTabla = miConexion.Consulta(sql)
        Try
            For Each MiDataRow As DataRow In dtTabla.Rows
                If IsDBNull(MiDataRow("salida")) Then
                    sumasalida = "0"
                Else
                    sumasalida = MiDataRow("salida")
                End If
                If IsDBNull(MiDataRow("ingreso")) Then
                    sumaIngreso = "0"
                Else
                    sumaIngreso = MiDataRow("ingreso")
                End If
            Next
            ' MsgBox(sumasalida & " / " & sumaIngreso)
        Catch ex As Exception
            MsgBox("error" + ex.ToString)
        End Try
        miConexion.Dispose()
        '-----------------------------CALCULA SALDO---------------------------
        Dim saldo As Decimal = 0
        Format(saldo, "0.00")
        Dim ingresos, salidas, saldoinicial As Decimal
        ingresos = sumaIngreso
        salidas = sumasalida
        saldoinicial = misaldoinicial
        saldo = CDbl((misaldoinicial + ingresos) - salidas)


        frmCaja.TxtSaldo.Text = saldo
        frmCaja.TxtsumaIngreso.Text = ingresos
        frmCaja.TxtsumaSalida.Text = salidas
        frmCaja.TxtSaldo.Text = saldo.ToString("0.00")


        Return saldo

    End Function


    Public Function Get_Saldo()

        Dim miConexion As New GestionMySQL
        Dim dtTabla As New DataTable
        Dim saldo As Decimal

        dtTabla = miConexion.Consulta("SELECT * FROM vista_saldo")

        Try
            For Each MiDataRow As DataRow In dtTabla.Rows
                If IsDBNull(MiDataRow("Saldo")) Then
                    saldo = "0"
                Else
                    saldo = MiDataRow("Saldo")
                End If
            Next
        Catch ex As Exception
            MsgBox("error" + ex.ToString)
        End Try
        Return saldo
        Global_saldo = saldo
    End Function

End Class
