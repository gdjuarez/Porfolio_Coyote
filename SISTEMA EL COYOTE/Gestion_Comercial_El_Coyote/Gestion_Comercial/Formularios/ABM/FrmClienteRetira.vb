Public Class FrmClienteRetira
    Dim miConexion As New GestionMySQL
    Dim Dtcliente As New DataTable
    Dim DtRetira As New DataTable
    Dim dtIdCliente As New DataTable
    Dim RazonSocial As String = ""

    Private Sub FrmClienteRetira_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarListaCliente("Cliente", "RazonSocial")
    End Sub

    Private Sub inicio()
        TxtCliente.ReadOnly = True
        TxtApellidoRetira.ReadOnly = True
        TxtDNIRetira.ReadOnly = True
        TxtCliente.BackColor = Color.LightGreen
        TxtApellidoRetira.BackColor = Color.LightGreen
        TxtDNIRetira.BackColor = Color.LightGreen
        TxtCliente.Clear()
        TxtApellidoRetira.Clear()
        TxtDNIRetira.Clear()
        BtnGrabaRetira.Enabled = False
    End Sub

    Private Sub llenarListaCliente(ByVal tabla As String, ByVal display As String)
        Dtcliente = miConexion.ConsultarTabla("Cliente")
        With ListBoxCliente
            .DataSource = Dtcliente
            .DisplayMember = display
        End With
    End Sub

    Private Sub llenarDGVRetira(ByVal idcliente As String)
        Dim sql As String
        sql = "SELECT DNI, Apellido FROM clienteretira  where idcliente = '" & idcliente & "';"
        DtRetira = miConexion.Consulta(sql)
        DGVRetira.DataSource = DtRetira
    End Sub

    Private Sub ListBoxCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxCliente.SelectedIndexChanged
        RazonSocial = ListBoxCliente.Text
        TxtCliente.Text = RazonSocial
        Get_idcliente(RazonSocial)
        llenarDGVRetira(LblIdCliente.Text)
    End Sub

    Private Sub Get_idcliente(ByVal RazonSocial As String)
        Dim miConexionIdCliente As New GestionMySQL
        Dim sql As String = ""
        Try
            sql = "select idcliente from cliente where Razonsocial = '" & RazonSocial & "'"
            'MsgBox(sql)
            dtIdCliente = miConexionIdCliente.Consulta(sql)
            For Each MiDataRow In dtIdCliente.Rows
                LblIdCliente.Text = MiDataRow("idcliente")
            Next
            miConexionIdCliente.Dispose()
        Catch ex As Exception
            MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
        End Try
    End Sub

    Private Sub BtnAgregaRetira_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregaRetira.Click
        If TxtCliente.Text = "" Then
            MsgBox("Debe tener selecionada un cliente")
        Else
            BtnGrabaRetira.Enabled = True
            BtnAgregaRetira.Enabled = False
            TxtApellidoRetira.ReadOnly = False
            TxtDNIRetira.ReadOnly = False
            TxtApellidoRetira.BackColor = Color.White
            TxtDNIRetira.BackColor = Color.White
        End If
    End Sub

    Private Sub BtnGrabaRetira_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabaRetira.Click
        Dim miConexionRetira As New GestionMySQL
        Dim IdCliente As String = LblIdCliente.Text
        Dim Apellido As String = TxtApellidoRetira.Text
        Dim Dni As String = TxtDNIRetira.Text
        Dim sql As String = ""
        Try
            'DNI, Apellido, IdCliente
            sql = "INSERT INTO Clienteretira (DNI, Apellido, IdCliente)"
            sql += "VALUES ('" & Dni & "','" & Apellido & "','" & IdCliente & "')"
            'MsgBox(sql)
            miConexionRetira.EjecutarSQL(sql)
            miConexionRetira.Dispose()
        Catch ex As Exception
            MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
        End Try
        inicio()
        BtnAgregaRetira.Enabled = True
        llenarDGVRetira(LblIdCliente.Text)
    End Sub

    Private Sub BtnBorraRetira_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorraRetira.Click
        Dim miConexion As New GestionMySQL
        Dim idcliente As String = LblIdCliente.Text
        Dim dniRetira As String = ""
        If DGVRetira.RowCount > 0 Then
            If IsDBNull(DGVRetira.SelectedCells(0).Value) Then
                dniRetira = ""
            Else
                dniRetira = DGVRetira.SelectedCells(0).Value
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Dim resultado As DialogResult = MessageBox.Show("Está seguro de Eliminar?",
                                                    "Atención", MessageBoxButtons.YesNo)
            If resultado = Windows.Forms.DialogResult.Yes Then
                Try
                    miConexion.Consulta("DELETE FROM clienteretira WHERE DNI = '" & dniRetira & "' and idcliente =  '" & idcliente & "';")
                    MsgBox("Registro Eliminado", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical)
                End Try
                miConexion.Dispose()
            End If
        End If
        inicio()
        llenarDGVRetira(LblIdCliente.Text)
    End Sub

    Private Sub BtnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
End Class