Imports System.IO
Public Class FrmCargaPagoCC
    Dim miCaja As New ClassCaja
    Private Sub FrmCargaPagoCC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarComboxVentaCC("RazonSocial", "RazonSocial")
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

    Private Sub CBRazonSocial_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBRazonSocial.SelectedIndexChanged
        Get_idcliente(CBRazonSocial.Text)
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

    Private Sub TxtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMonto.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar = _
                Threading.Thread.CurrentThread. _
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)
        End If
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
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

        If LblIdcliente.Text = "IdCliente" Or TxtMonto.Text = "" Then
            MsgBox("Faltan datos ")
            TxtMonto.Select()
        Else
            Dim miGestionMySQL As New GestionMySQL
            Dim sql As String
            pagocc.IdCliente = Me.LblIdcliente.Text.Trim
            pagocc.Fecha = Me.DTPpcc.Text.Trim
            pagocc.Haber = Me.TxtMonto.Text.Trim
            pagocc.Saldo = saldo + TxtMonto.Text
            'idpagocc, idcliente, fecha, debe, haber, saldo
            Try
                sql = "INSERT INTO pagoCC (idcliente, fecha, debe, haber, saldo)"
                sql += "VALUES ('" & pagocc.IdCliente & "', STR_TO_DATE('" & pagocc.Fecha & "' ,'%d/%m/%Y'),"
                sql += "0, " & pagocc.Haber & "," & pagocc.Saldo & ")"
                'MsgBox(sql)
                miGestionMySQL.EjecutarSQL(sql)
                miGestionMySQL.Dispose()

            Catch ex As Exception
                MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
            End Try

        End If
        IngresoDepositoccCaja()
        Me.Close()
    End Sub


    Public Sub IngresoDepositoccCaja()

        Dim meConecto As New GestionMySQL
        Dim meConecto2 As New GestionMySQL
        Dim meConecto3 As New GestionMySQL
        Dim dtTabla As New DataTable
        Dim miCaja As New ClassCaja
        Dim sqlcaja As String = ""
        ' idCajaMov, tipoMovimiento, Descripcion, tipoComprobante, serienumero, Importe
        Dim sql As String = ""
        miCaja.TipoMovimiento = "INGRESO"
        miCaja.Descripcion = "Deposito Cta. Cte."
        miCaja.TipoComprobante = "Deposito Cta. Cte."
        miCaja.Serienumero = "0000"
        miCaja.Importe = Convert.ToDecimal(TxtMonto.Text)
        ' MsgBox(miCaja.Importe)
        miCaja.Ingreso = miCaja.Importe
        miCaja.Egreso = 0
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
        miCaja.Fecha = DTPpcc.Text.Trim
        miCaja.Operador = usuarioGlobal
        saldoT = CDec(meConecto4.CalcularSaldoInicial(DTPpcc.Text.Trim))
        saldoinicialT = CDec(meConecto4.CalcularSaldo(DTPpcc.Text.Trim) + TxtMonto.Text)
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