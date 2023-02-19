Public Class FrmDesdeHastaProveedores

    Private Sub FrmDesdeHastaCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarComboxProveedor("Proveedores", "RazonSocial", "RazonSocial")
    End Sub


    Private Sub BtnInfProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInfProveedor.Click
        BtnInfProveedor.Enabled = False
        GlobalDesdeProveedor = Convert.ToDateTime(DTPdesde.Text)
        GlobalHastaProveedor = Convert.ToDateTime(DTPhasta.Text)
        GlobalIdProveedor = TxtProveedor.Text.Trim
        GlobalProveedor = CBProveedor.Text.Trim
        FrmImpresionComprasxProveedores.MdiParent = MDIMenu
        FrmImpresionComprasxProveedores.Show()
        Me.Close()
    End Sub

    'Lleno combobox Proveedor
    Private Sub llenarComboxProveedor(ByVal tabla As String, ByVal display As String, ByVal value As String)
        Dim dtP As New DataTable
        Dim miGestionMySQLCliente As New GestionMySQL
        dtP = miGestionMySQLCliente.ConsultarTabla("Proveedores")
        With CBProveedor
            .DataSource = dtP                   ' DataSource = DataTable
            .DisplayMember = display            ' DisplayMember = "Nombre" Nombre del campo que quieres que muestre el combo.
            .ValueMember = value                ' ValueMembes = "ID" Nombre de campo que utilizaras como identificador
        End With
        miGestionMySQLCliente.Dispose()
    End Sub

    Private Sub CBProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBProveedor.SelectedIndexChanged
        GlobalClienteCC = CBProveedor.Text.Trim
        Get_idProveedor(CBProveedor.Text)
    End Sub

    Private Sub Get_idProveedor(ByVal RazonSocial As String)
        Dim dtidcliente As New DataTable
        Dim miConexionIdCliente As New GestionMySQL
        Dim sql As String = ""
        Try
            sql = "select idproveedor from proveedores where RazonSocial = '" & RazonSocial & "'"
            'MsgBox(sql)
            dtidcliente = miConexionIdCliente.Consulta(sql)
            For Each MiDataRow In dtidcliente.Rows
                TxtProveedor.Text = MiDataRow("idproveedor")
            Next
            miConexionIdCliente.Dispose()
        Catch ex As Exception
            MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
        End Try
    End Sub

End Class