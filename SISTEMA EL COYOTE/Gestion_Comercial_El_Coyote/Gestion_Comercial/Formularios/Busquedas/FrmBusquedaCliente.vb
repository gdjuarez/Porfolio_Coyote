Public Class FrmBusquedaCliente

    Dim dt As New DataTable
    Dim tabla As New DataTable
    Dim miCliente As New ClassCliente
    'conecto a base de datos
    Dim miGestionMySQL As New GestionMySQL

    Private Sub FrmBusquedaCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        iniciar()
    End Sub

    Private Sub iniciar()
        dt = miGestionMySQL.ConsultarTabla("cliente")
        DataGridViewClientes.DataSource = dt
        TxtClientes.Text = ""
    End Sub

    Private Sub TxtClientes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtClientes.TextChanged
        'uso funcion para buscar en tabla , columna y campo que return un Datatable 
        tabla = miGestionMySQL.BuscarenTablaEscribo("Cliente", "RazonSocial", TxtClientes.Text)
        DataGridViewClientes.DataSource = tabla
        'cierro conexion
        miGestionMySQL.Dispose()
    End Sub


    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        iniciar()
    End Sub

    Private Sub btnCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopiarPresupuesto.Click

        If DataGridViewClientes.RowCount > 0 Then

            miCliente.IdCliente = DataGridViewClientes.SelectedCells(0).Value
            miCliente.Nombre = DataGridViewClientes.SelectedCells(1).Value
            miCliente.Apellido = DataGridViewClientes.SelectedCells(2).Value
            miCliente.RazonSocial = DataGridViewClientes.SelectedCells(3).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
            FrmPresupuestos.LblIdCliente.Text = miCliente.IdCliente
            FrmPresupuestos.TxtRazonSocial.Text = miCliente.RazonSocial & " " & miCliente.Nombre & " " & miCliente.Apellido

        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If

        Me.Close()

    End Sub

    Private Sub BtnCopiaVentaTouch_Click(sender As Object, e As EventArgs) Handles BtnCopiaVentaTouch.Click
        If DataGridViewClientes.RowCount > 0 Then

            miCliente.IdCliente = DataGridViewClientes.SelectedCells(0).Value
            miCliente.Nombre = DataGridViewClientes.SelectedCells(1).Value
            miCliente.Apellido = DataGridViewClientes.SelectedCells(2).Value
            miCliente.RazonSocial = DataGridViewClientes.SelectedCells(3).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
            FrmVentasTouch.LblIdCliente.Text = miCliente.IdCliente
            FrmVentasTouch.TxtRazonSocial.Text = miCliente.RazonSocial & " " & miCliente.Nombre & " " & miCliente.Apellido

        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If

        Me.Close()

    End Sub

    Private Sub btnCopiarVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopiarVentas.Click

        If DataGridViewClientes.RowCount > 0 Then

            miCliente.IdCliente = DataGridViewClientes.SelectedCells(0).Value
            miCliente.Nombre = DataGridViewClientes.SelectedCells(1).Value
            miCliente.Apellido = DataGridViewClientes.SelectedCells(2).Value
            miCliente.RazonSocial = DataGridViewClientes.SelectedCells(3).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
            FrmVentas.LblIdCliente.Text = miCliente.IdCliente
            FrmVentas.TxtRazonSocial.Text = miCliente.RazonSocial & " " & miCliente.Nombre & " " & miCliente.Apellido

        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If

        Me.Close()

    End Sub

    Private Sub BtnCopiarClienteCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopiarClienteCC.Click
        If DataGridViewClientes.RowCount > 0 Then
            miCliente.IdCliente = DataGridViewClientes.SelectedCells(0).Value
            miCliente.Nombre = DataGridViewClientes.SelectedCells(1).Value
            miCliente.Apellido = DataGridViewClientes.SelectedCells(2).Value
            miCliente.RazonSocial = DataGridViewClientes.SelectedCells(3).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
            FrmVentasCC.LblIdCliente.Visible = True
            FrmVentasCC.LblIdCliente.Text = miCliente.IdCliente
            FrmVentasCC.TxtCliente.Text = miCliente.RazonSocial & " " & miCliente.Nombre & " " & miCliente.Apellido
            llenarComboxRetira("clienteretira", "Apellido", "Apellido")
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If

        Me.Close()
    End Sub

    'Lleno combobox Marca
    Public Sub llenarComboxRetira(ByVal tabla As String, ByVal display As String, ByVal value As String)
        Dim miGestionMySQLMarca As New GestionMySQL
        Dim dtRetira As New DataTable
        Dim sql As String = ("select apellido from Clienteretira where idcliente = '" & miCliente.IdCliente & "'")
        'MsgBox(sql)
        dtRetira = miGestionMySQLMarca.Consulta(sql)
        With FrmVentasCC.CBRetira
            .DataSource = dtRetira              ' DataSource = DataTable
            .DisplayMember = display           ' DisplayMember = "Nombre" Nombre del campo que quieres que muestre el combo.
            .ValueMember = value               ' ValueMembes = "ID" Nombre de campo que utilizaras como identificador
        End With
        miGestionMySQLMarca.Dispose()
    End Sub


End Class