Public Class FrmDesdeHastaClienteRetira

    Private Sub FrmDesdeHastaCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarComboxRazonSocial("cliente", "RazonSocial", "RazonSocial")
    End Sub

    Private Sub limpiar()
        CBClienteRetira.Text = ""
        TxtRetira.Text = ""
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
        GlobalIdClienteCC = TxtCliente.Text
    End Sub

    Private Sub CBRazonSocial_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBRazonSocial.SelectedIndexChanged
        limpiar()
        GlobalClienteCCRetira = CBRazonSocial.Text.Trim
        Get_idClienteRazonSocial(CBRazonSocial.Text)
    End Sub

    Private Sub TxtCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCliente.TextChanged
        llenarComboxRetira("Apellido", "Apellido", TxtCliente.Text)
    End Sub

    Private Sub llenarComboxRetira(ByVal display As String, ByVal value As String, ByVal idcliente As String)
        Dim dtClienteretira As New DataTable
        Dim miGestionMySQLCliente As New GestionMySQL
        dtClienteretira = miGestionMySQLCliente.Consulta("select apellido from Clienteretira where idcliente = " & idcliente & ";")
        With CBClienteRetira
            .DataSource = dtClienteretira      ' DataSource = DataTable
            .DisplayMember = display           ' DisplayMember = "Nombre" Nombre del campo que quieres que muestre el combo.
            .ValueMember = value               ' ValueMembes = "ID" Nombre de campo que utilizaras como identificador
        End With
        miGestionMySQLCliente.Dispose()
    End Sub

    Private Sub CBClienteRetira_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBClienteRetira.SelectedIndexChanged
        GlobalClienteCCRetira = CBClienteRetira.Text.Trim
        Get_idClienteRetira(CBClienteRetira.Text)
    End Sub

    Private Sub Get_idClienteRetira(ByVal Apellido As String)
        Dim dtidcliente As New DataTable
        Dim miConexionIdCliente As New GestionMySQL
        Dim sql As String = ""
        Try
            sql = "select DNI from clienteRetira where Apellido = '" & Apellido & "'"
            'MsgBox(sql)
            dtidcliente = miConexionIdCliente.Consulta(sql)
            For Each MiDataRow In dtidcliente.Rows
                TxtRetira.Text = MiDataRow("dni")
            Next
            miConexionIdCliente.Dispose()
        Catch ex As Exception
            MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
        End Try
    End Sub


    Private Sub BtnInfClienteRetira_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInfClienteRetira.Click
        BtnInfClienteRetira.Enabled = False

        GlobalDesdeClienteCCRetira = Convert.ToDateTime(DTPdesde.Text)
        GlobalHastaClienteCCRetira = Convert.ToDateTime(DTPhasta.Text)
        
        GlobalIdClienteCCClienteretira = TxtCliente.Text.Trim
        GlobalClienteCCClienteretira = CBRazonSocial.Text
        GlobalIdClienteCCRetira = TxtRetira.Text
        GlobalClienteCCRetira = CBClienteRetira.Text
        FrmInformeDesdeHastaClienteRetira.MdiParent = MDIMenu
        FrmInformeDesdeHastaClienteRetira.Show()
        Me.Close()
    End Sub

End Class