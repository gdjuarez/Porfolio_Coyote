Public Class FrmMarca
    Dim miConexion As New GestionMySQL
    Dim DtMarca As New DataTable

    Private Sub FrmMarcaModelo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarListaMarca("marcaArticulo", "Marca")
    End Sub

    Private Sub llenarListaMarca(ByVal tabla As String, ByVal display As String)
        DtMarca = miConexion.ConsultarTabla("marcaArticulo")
        With ListBoxMarca
            .DataSource = DtMarca
            .DisplayMember = display
        End With
    End Sub

    Private Sub inicio()
        TxtMarca.ReadOnly = True
        TxtMarca.BackColor = Color.LightGreen
        TxtMarca.Clear()
        BtnGrabaMarca.Enabled = False
        llenarListaMarca("marcaArticulo", "Marca")
    End Sub

    Private Sub BtnAgregaMarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregaMarca.Click
        TxtMarca.Clear()
        TxtMarca.ReadOnly = False
        TxtMarca.BackColor = Color.White
        BtnGrabaMarca.Enabled = True
    End Sub

    Private Sub ListBoxMarca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxMarca.SelectedIndexChanged
        Dim Marca As String
        Marca = ListBoxMarca.Text
        TxtMarca.Text = Marca
    End Sub

    Private Sub BtnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCerrar.Click
        Me.Close()
        FrmArticulos.llenarComboxMarca("marcaarticulo", "Marca", "Marca")
    End Sub

    Private Sub BtnGrabaMarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabaMarca.Click
        Dim miConexion As New GestionMySQL
        Dim marca As String = TxtMarca.Text
        Dim sql As String
        Try
            sql = "INSERT INTO marcaArticulo "
            sql += "VALUES ('" & marca & "')"
            miConexion.EjecutarSQL(sql)
            miConexion.Dispose()
        Catch ex As Exception
            MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
        End Try

        Marca = ListBoxMarca.Text
        TxtMarca.Text = Marca
        inicio()
    End Sub

    Private Sub BtnBorraMarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorraMarca.Click
        Dim miConexion As New GestionMySQL
        Dim marca As String = TxtMarca.Text
        Dim sql As String
        Try
            sql = "DELETE FROM marcaArticulo "
            sql += "WHERE marca= '" & marca & "'"
            miConexion.EjecutarSQL(sql)
            miConexion.Dispose()
        Catch ex As Exception
            MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
        End Try
        marca = ListBoxMarca.Text
        TxtMarca.Text = marca
        inicio()
    End Sub

End Class