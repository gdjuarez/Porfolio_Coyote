Public Class FrmDesdeHastaCliente

    Private Sub FrmDesdeHastaCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarComboxRazonSocial("cliente", "RazonSocial", "RazonSocial")
        llenarComboxApellido("cliente", "Apellido", "Apellido")
    End Sub


    Private Sub BtnInfCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInfCliente.Click
        BtnInfCliente.Enabled = False
        GlobalDesdeClienteCC = Convert.ToDateTime(DTPdesde.Text)
        GlobalHastaClienteCC = Convert.ToDateTime(DTPhasta.Text)
        GlobalIdClienteCC = TxtCliente.Text.Trim

        FrmInformeCCxCliente.MdiParent = MDIMenu
        FrmInformeCCxCliente.Show()
        Me.Close()
    End Sub

    'Lleno combobox RazonSocial
    Private Sub llenarComboxRazonSocial(ByVal tabla As String, ByVal display As String, ByVal value As String)
        Dim dtCliente As New DataTable
        Dim miGestionMySQLCliente As New GestionMySQL
        dtCliente = miGestionMySQLCliente.ConsultarTabla("Cliente")
        With CBRazonSocial
            .DataSource = dtCliente              ' DataSource = DataTable
            .DisplayMember = display           ' DisplayMember = "Nombre" Nombre del campo que quieres que muestre el combo.
            .ValueMember = value               ' ValueMembes = "ID" Nombre de campo que utilizaras como identificador
        End With
        miGestionMySQLCliente.Dispose()
    End Sub

    'Lleno combobox Apellido
    Private Sub llenarComboxApellido(ByVal tabla As String, ByVal display As String, ByVal value As String)
        Dim dtCliente As New DataTable
        Dim miGestionMySQLCliente As New GestionMySQL
        dtCliente = miGestionMySQLCliente.ConsultarTabla("Cliente")
        With CBApellido
            .DataSource = dtCliente              ' DataSource = DataTable
            .DisplayMember = display           ' DisplayMember = "Nombre" Nombre del campo que quieres que muestre el combo.
            .ValueMember = value               ' ValueMembes = "ID" Nombre de campo que utilizaras como identificador
        End With
        miGestionMySQLCliente.Dispose()
    End Sub


    Private Sub CBRazonSocial_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBRazonSocial.SelectedIndexChanged
        GlobalClienteCC = CBRazonSocial.Text.Trim
        Get_idClienteRazonSocial(CBRazonSocial.Text)
        CBApellido.Text = ""
    End Sub

    Private Sub CBApellido_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBApellido.SelectedIndexChanged
        GlobalClienteCC = CBApellido.Text.Trim
        Get_idClienteApellido(CBApellido.Text)
        CBRazonSocial.Text = ""
    End Sub

    Private Sub Get_idClienteRazonSocial(ByVal RazonSocial As String)
        Dim dtidcliente As New DataTable
        Dim miConexionIdCliente As New GestionMySQL
        Dim sql As String = ""
        Try
            sql = "select idcliente from cliente where RazonSocial = '" & RazonSocial & "'"
            'MsgBox(sql)
            dtidcliente = miConexionIdCliente.Consulta(sql)
            For Each MiDataRow In dtidcliente.Rows
                TxtCliente.Text = MiDataRow("idcliente")
            Next
            miConexionIdCliente.Dispose()
        Catch ex As Exception
            MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
        End Try
    End Sub

    Private Sub Get_idClienteApellido(ByVal Apellido As String)
        Dim dtidcliente As New DataTable
        Dim miConexionIdCliente As New GestionMySQL
        Dim sql As String = ""
        Try
            sql = "select idcliente from cliente where Apellido = '" & Apellido & "'"
            'MsgBox(sql)
            dtidcliente = miConexionIdCliente.Consulta(sql)
            For Each MiDataRow In dtidcliente.Rows
                TxtCliente.Text = MiDataRow("idcliente")
            Next
            miConexionIdCliente.Dispose()
        Catch ex As Exception
            MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
        End Try
    End Sub


End Class