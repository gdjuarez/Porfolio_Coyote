Public Class FrmGestionCompras
    Dim dtMitabla As New DataTable
    Dim dtTabla As New DataTable
    Dim miArticulo As New ClassArticulo
    Dim dtp As New DataTable

    Private Sub FrmActualizaPrecio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Llenargrid()
    End Sub

    Private Sub Llenargrid()
        'conecto a base de datos
        Dim miGestionMySQLllenaGrid As New GestionMySQL
        'uso la funcion ConsultarArticuloStock() de la claseGestionMySQL 
        dtMitabla = miGestionMySQLllenaGrid.ConsultarTabla("vista_compras")
        'con el dt devuelto lleno el datagriedview
        DGVCompras.DataSource = dtMitabla
    End Sub

   

    'Paga Compra ----->  marcando en campo pagado(string) PAGADO + FECHA
    Private Sub PagarCompra()
        'Hay que chequear que al menos halla una fila seleccionada
        Dim miCompra As New ClassCompra
        Dim miconexion As New GestionMySQL

        'con este ciclo recorro el datagridview
        For Each row As DataGridViewRow In DGVCompras.Rows
            If row.Cells(0).Value = True Then
                Dim consultaMysql As String = ""
                consultaMysql = "Update compras SET "
                consultaMysql += "Pagado = 'PAGADO " & " " & DateTimePicker1.Text & "'  "
                consultaMysql += "WHERE idCompras = '" & row.Cells(1).Value & "'; "
                'MsgBox(consultaMysql)
                Try
                    miconexion.EjecutarSQL(consultaMysql)

                    'MsgBox("Registro Guardado", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical)
                End Try
                '-----------------------------------------------------
            End If
        Next
        miconexion.Dispose()

    End Sub

    'Codigo del boton actualizar
    Private Sub BtnActualiza_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnActualiza.Click

        If CheckBoxProveedor.Text = "" Then
            MsgBox("Atencion !!, " & vbNewLine &
                   "Seleccione Proveedor")
        Else
            PagarCompra()
            Llenargrid()
            CheckBoxProveedor.Checked = False
            ComboBoxProveedor.Text = ""

        End If
    End Sub

    'Lleno combobox Proveedor
    Private Sub llenarComboxProveedor(ByVal tabla As String, ByVal display As String, ByVal value As String)
        Dim miGestionMySQLMarca As New GestionMySQL
        dtp = miGestionMySQLMarca.ConsultarTabla("proveedores")
        With ComboBoxProveedor
            .DataSource = dtP                ' DataSource = DataTable
            .DisplayMember = display           ' DisplayMember = "Nombre" Nombre del campo que quieres que muestre el combo.
            .ValueMember = value               ' ValueMembes = "ID" Nombre de campo que utilizaras como identificador
        End With
        miGestionMySQLMarca.Dispose()
    End Sub

    'Seleciono Marca para aumentar 
    Private Sub CheckBoxProveedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxProveedor.CheckedChanged
      
        If CheckBoxProveedor.Checked = True Then
            ComboBoxProveedor.Enabled = True
            llenarComboxProveedor("Proveedores", "RazonSocial", "RazonSocial")
        ElseIf CheckBoxProveedor.Checked = False Then
            ComboBoxProveedor.Enabled = False
            ComboBoxProveedor.Text = ""
            Llenargrid()
        End If
    End Sub

    Private Sub ComboBoxProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxProveedor.SelectedIndexChanged
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion ConsultarArticuloStock() de la claseGestionMySQL 
        Dim sql As String = "SELECT * FROM vista_compras  where RazonSocial = '" & ComboBoxProveedor.Text & "';"
        dtMitabla = miGestionMySQL.Consulta(sql)
        'con el dt devuelto lleno el datagriedview
        DGVCompras.DataSource = dtMitabla
    End Sub


End Class