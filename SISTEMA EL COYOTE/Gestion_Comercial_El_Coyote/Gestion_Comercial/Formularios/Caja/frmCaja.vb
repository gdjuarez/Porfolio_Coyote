
Public Class frmCaja

    Dim dtInicial As New DataTable
    Dim dtCaja As New DataTable
    Dim GESTIONBD As New GestionMySQL
    Dim GESTIONBDsaldo As New GestionMySQL

    Private Sub frmCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Inicio()
        flag = "C"
        GESTIONBDsaldo.CalcularSaldo(DateTimePickerFecha.Text)
      
    End Sub

    Private Sub Limpiar()
        'TxtSaldoInicial.Text = "0"
        ComboBoxComprobante.Text = "FACTURA"
        TxtDescripcion.Text = ""
        Txtnumero.Text = ""
        TxtImporte.Text = ""
    End Sub

    Private Sub Inicio()
        Limpiar()
        Dim conectar As New GestionMySQL
        TxtSaldoInicial.Text = GESTIONBD.CalcularSaldoInicial(DateTimePickerFecha.Text)

        dtCaja = conectar.consultarMovimientosCaja(DateTimePickerFecha.Text)
        DataGridViewCaja.DataSource = dtCaja
    End Sub


    Private Sub DateTimePickerFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePickerFecha.ValueChanged

        Me.Size = New System.Drawing.Size(640, 581)
        Inicio()
        GESTIONBD.CalcularSaldoInicial(DateTimePickerFecha.Text)
        GESTIONBDsaldo.CalcularSaldo(DateTimePickerFecha.Text)
        ' MsgBox("Activar no poder grabar distinta FECHA")
        '------------evita grabar dia anterior O POSTERIOR en caja----OK
        If DateTimePickerFecha.Text <> Date.Today Then
            Panel1.Enabled = False
            ComboBoxComprobante.Enabled = False
            Txtnumero.Enabled = False
            TxtDescripcion.Enabled = False
            TxtImporte.Enabled = False
            BtnRegistrar.Enabled = False
            BtnArqueo.Enabled = False
        Else
            Panel1.Enabled = True
            ComboBoxComprobante.Enabled = True
            Txtnumero.Enabled = True
            TxtDescripcion.Enabled = True
            TxtImporte.Enabled = True
            BtnRegistrar.Enabled = True
            BtnArqueo.Enabled = True
        End If
    End Sub

    Private Sub BtnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegistrar.Click

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
            miCaja.TipoMovimiento = LblIngresoEgreso.Text.Trim
            miCaja.Descripcion = TxtDescripcion.Text.Trim
            miCaja.TipoComprobante = ComboBoxComprobante.Text.Trim
            miCaja.Serienumero = Txtnumero.Text.Trim
            miCaja.Importe = Convert.ToDecimal(TxtImporte.Text)
            ' MsgBox(miCaja.Importe)
            miCaja.Ingreso = 0
            miCaja.Egreso = 0
            If LblIngresoEgreso.Text = "INGRESO" Then
                miCaja.Ingreso = miCaja.Importe
            ElseIf LblIngresoEgreso.Text = "SALIDA" Then
                miCaja.Egreso = miCaja.Importe
            End If
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
            miCaja.Fecha = DateTimePickerFecha.Text.Trim
            miCaja.Operador = usuarioGlobal
            miCaja.Saldoinicial = CDec(TxtSaldoInicial.Text)
            miCaja.Saldo = CDec(TxtSaldo.Text + (miCaja.Ingreso - miCaja.Egreso))

            'codCaja, codMovCaja, Fecha, operador, saldoinicial, saldo
            sqlcaja = "INSERT INTO caja (codMovCaja, Fecha, operador, saldoinicial, saldo)"
            sqlcaja += "VALUES (" & miCaja.CodMovCaja & ", STR_TO_DATE('" & miCaja.Fecha & "','%d/%m/%Y'),"
            sqlcaja += "'" & miCaja.Operador & "', " & Replace(miCaja.Saldoinicial, ",", ".") & "," & Replace(miCaja.Saldo, ",", ".") & ")"
            Try
                meConecto3.EjecutarSQL(sqlcaja)
                MsgBox("Registrado", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try
            meConecto3.Dispose()
            '=========================================
        End If
        Inicio()
        GESTIONBDsaldo.CalcularSaldo(DateTimePickerFecha.Text)
    End Sub

    Private Sub BtnArqueo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArqueo.Click
        If flag = "C" Then
            FrmArqueo.MdiParent = MDIMenu
            FrmArqueo.Show()
            flag = "A"
        Else
            FrmArqueo.Close()
            flag = "C"
        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        FrmArqueo.Close()
        Me.Close()
    End Sub

    Private Sub BtnINGRESO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnINGRESO.Click
        BtnSALIDA.FlatStyle = FlatStyle.Standard
        BtnSALIDA.ForeColor = Color.Gray
        LblIngresoEgreso.ForeColor = Color.Green
        LblIngresoEgreso.Text = "INGRESO"
        BtnINGRESO.ForeColor = Color.Green
        BtnINGRESO.FlatStyle = FlatStyle.Flat
    End Sub

    Private Sub BtnSALIDA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSALIDA.Click
        BtnINGRESO.FlatStyle = FlatStyle.Standard
        BtnINGRESO.ForeColor = Color.Gray
        LblIngresoEgreso.ForeColor = Color.Red
        LblIngresoEgreso.Text = "SALIDA"
        BtnSALIDA.ForeColor = Color.Red
        BtnSALIDA.FlatStyle = FlatStyle.Flat
    End Sub

    Private Sub TxtSaldo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSaldo.TextChanged
        If TxtSaldo.Text < 0 Then
            TxtSaldo.ForeColor = Color.Red
        Else
            TxtSaldo.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtImporte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtImporte.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar = _
                Threading.Thread.CurrentThread. _
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)
        End If
    End Sub

End Class