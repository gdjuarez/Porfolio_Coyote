Public Class FrmBusquedaVenta

    Dim dt As New DataTable
    Dim tabla As New DataTable
    Dim miVenta As New ClassVenta
    Dim anularmiVenta As New ClassVenta
    Dim miCliente As New ClassCliente
    Dim miConeccion As New GestionMySQL

    Private Sub FrmBusquedaProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenarDatagrid()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LlenarDatagrid()
    End Sub

    Private Sub LlenarDatagrid()
        dt = miConeccion.ConsultarTabla("vistaVentas")
        DataGridViewVentas.DataSource = dt
        DataGridViewVentas.Columns(0).HeaderText = "Codigo"
        'cierro conexion
        miConeccion.Dispose()
    End Sub

    Private Sub TxtVenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtVentas.TextChanged
        'uso funcion para buscar en tabla , columna y campo que return un Datatable 
        tabla = miConeccion.BuscarenTablaEscribo("vistaVentas", "codigo", TxtVentas.Text)
        DataGridViewVentas.DataSource = tabla
        'cierro conexion
        miConeccion.Dispose()
    End Sub

    Private Sub TxtRazonsocial_TextChanged(sender As Object, e As EventArgs) Handles TxtRazonsocial.TextChanged
        'uso funcion para buscar en tabla , columna y campo que return un Datatable 
        tabla = miConeccion.BuscarenTablaEscribo("vistaVentas", "RazonSocial", TxtRazonsocial.Text)
        DataGridViewVentas.DataSource = tabla
        miConeccion.Dispose()
    End Sub

    Private Sub TxtApellido_TextChanged(sender As Object, e As EventArgs) Handles TxtApellido.TextChanged
        'uso funcion para buscar en tabla , columna y campo que return un Datatable 
        tabla = miConeccion.BuscarenTablaEscribo("vistaVentas", "Apellido", TxtApellido.Text)
        DataGridViewVentas.DataSource = tabla
        miConeccion.Dispose()
    End Sub
    Private Sub BtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimir.Click

        'MsgBox("Abrir VentaImpresion y cargar la venta")
        Global_numeroVenta = 0

        If DataGridViewVentas.RowCount > 0 Then
            If IsDBNull(DataGridViewVentas.SelectedCells(0).Value) Then
                miVenta.IdVenta = "0"
            Else
                miVenta.IdVenta = DataGridViewVentas.SelectedCells(0).Value
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

            'Obtengo el idVenta del grid y lo asigno al la 
            'variable global  que se pasa por parametro para imprimir 
            'la venta
            Global_numeroVenta = miVenta.IdVenta

            'MsgBox("IMPRIMIR VENTA N°: " & Global_numeroVenta)
            FacturaImpresion.MdiParent = MDIMenu
            FacturaImpresion.Show()

        Else

            Me.DialogResult = Windows.Forms.DialogResult.Ignore
            MsgBox("Seleccione")
        End If

        Me.Close()
    End Sub

    Private Sub BtnAnularVenta_Click(sender As Object, e As EventArgs) Handles BtnAnularVenta.Click

        Global_AnularVenta = 0
        Global_RazonSocialCliente = ""
        Dim razonSocial As String = ""
        Dim nombre As String = ""
        Dim apellido As String = ""


        If DataGridViewVentas.RowCount > 0 Then

            If IsDBNull(DataGridViewVentas.SelectedCells(0).Value) Then
                anularmiVenta.IdVenta = "0"
            Else
                anularmiVenta.IdVenta = DataGridViewVentas.SelectedCells(0).Value
            End If

            anularmiVenta.Fecha = DataGridViewVentas.SelectedCells(1).Value

            If IsDBNull(DataGridViewVentas.SelectedCells(2).Value) Then
                razonSocial = ""
            Else
                razonSocial = DataGridViewVentas.SelectedCells(2).Value
            End If

            If IsDBNull(DataGridViewVentas.SelectedCells(3).Value) Then
                nombre = ""
            Else
                nombre = DataGridViewVentas.SelectedCells(3).Value
            End If


            If IsDBNull(DataGridViewVentas.SelectedCells(4).Value) Then
                apellido = ""
            Else
                apellido = DataGridViewVentas.SelectedCells(4).Value
            End If

            If IsDBNull(DataGridViewVentas.SelectedCells(6).Value) Then
                anularmiVenta.Importe = "0"
            Else
                anularmiVenta.Importe = DataGridViewVentas.SelectedCells(6).Value
            End If
            'codigo de venta lo asigno a la global para pasarlo por paramerto 
            'en el frmAnulaVenta y obtener los datros dela factura ha anular
            Global_AnularVenta = anularmiVenta.IdVenta
            Global_RazonSocialCliente = "" & razonSocial & " " & apellido & " " & nombre

            Me.DialogResult = Windows.Forms.DialogResult.OK

            MsgBox("VENTA N°: " & anularmiVenta.IdVenta & vbNewLine &
                "-----------------------------------" & vbNewLine &
                   "Total: $" & anularmiVenta.Importe & vbNewLine &
                   "" & Global_RazonSocialCliente)

            FrmAnulaVenta.MdiParent = MDIMenu
            FrmAnulaVenta.Show()
            FrmAnulaVenta.TxtTotal.Text = anularmiVenta.Importe
            FrmAnulaVenta.lblNumeroPedido.Text = anularmiVenta.IdVenta
            FrmAnulaVenta.DateTimePicker1.Text = anularmiVenta.Fecha
        Else

            Me.DialogResult = Windows.Forms.DialogResult.Ignore
            MsgBox("Seleccione la Venta que quiere ANULAR")

        End If

            Me.Close()


    End Sub

End Class