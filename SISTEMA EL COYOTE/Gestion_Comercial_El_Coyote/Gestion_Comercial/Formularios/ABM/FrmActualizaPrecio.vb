Public Class FrmActualizaPrecio
    Dim dtMitabla As New DataTable
    Dim dtTabla As New DataTable
    Dim miArticulo As New ClassArticulo
    Dim dtMarca As New DataTable

    Private Sub FrmActualizaPrecio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Llenargrid()
    End Sub

    Private Sub Llenargrid()
        'conecto a base de datos
        Dim miGestionMySQLllenaGrid As New GestionMySQL
        'uso la funcion ConsultarArticuloStock() de la claseGestionMySQL 
        dtMitabla = miGestionMySQLllenaGrid.ConsultarTabla("vistaarticulosystockyprecio")
        'con el dt devuelto lleno el datagriedview
        DGVArticulos.DataSource = dtMitabla
    End Sub

    Private Sub TBAumento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBAumento.TextChanged
        If IsNumeric(TBAumento.Text) Then
            'Nada
        Else
            MsgBox("DEBE CARGAR SOLO NUMEROS", MsgBoxStyle.Critical)
        End If
    End Sub

    'Actualizo precio
    Private Sub UpdatePrecio()
        'Hay que chequear que al menos halla una fila seleccionada
        Dim miVenta As New ClassVenta
        Dim miconexion As New GestionMySQL
        Dim nuevoprecio As Decimal = 0
        Dim precio As Decimal = 0
        Dim porcentaje As Decimal = 0
        porcentaje = CDec(TBAumento.Text.Trim)
        Dim modificados As Integer = 0
        'con este ciclo recorro el datagridview
        For Each row As DataGridViewRow In DGVArticulos.Rows
            If row.Cells(0).Value = True Then
                nuevoprecio = 0
                nuevoprecio = Math.Round((row.Cells(6).Value * porcentaje) / 100, 0)
                'MsgBox(nuevoprecio)
                Dim consultaMysql As String = ""
                consultaMysql = "Update Articulo SET "
                consultaMysql += "Precioventa = Precioventa + " & Replace(nuevoprecio, ",", ".") & "  "
                consultaMysql += "WHERE idArticulo = '" & row.Cells(1).Value & "'; "
                'MsgBox(consultaMysql)
                Try
                    miconexion.EjecutarSQL(consultaMysql)
                    modificados += 1
                    'MsgBox("Registro Guardado", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical)
                End Try
                '-----------------------------------------------------
            End If
        Next
        miconexion.Dispose()
        MsgBox("Precio/s Actualizado/s (cantidad: " & modificados & ")", MsgBoxStyle.Information)
        CheckBoxTodos.Checked = False
    End Sub

    'Codigo del boton actualizar
    Private Sub BtnActualiza_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnActualiza.Click

        If TBAumento.Text = "0" Then
            MsgBox("Porcentaje 0 % ?, " & vbNewLine &
                   "Ingrese el porcentaje deseado" & vbNewLine &
                   "por ej: -5 %  o por ej: 10 %")
        Else
            UpdatePrecio()
            Llenargrid()
            CheckBoxMarca.Checked = False
            CheckBoxTodos.Checked = False
            ComboBoxMarca.Text = ""
            TBAumento.Text = "0"
        End If
    End Sub

    'Selecciono todo
    Private Sub CheckBoxTodos_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBoxTodos.CheckedChanged
        If CheckBoxTodos.Checked = True Then
            For Each row As DataGridViewRow In DGVArticulos.Rows
                row.Cells(0).Value = True
            Next
        Else
            For Each row As DataGridViewRow In DGVArticulos.Rows
                row.Cells(0).Value = False
            Next
        End If
    End Sub

    'Lleno combobox Marca
    Private Sub llenarComboxMarca(ByVal tabla As String, ByVal display As String, ByVal value As String)
        Dim miGestionMySQLMarca As New GestionMySQL
        dtMarca = miGestionMySQLMarca.ConsultarTabla("marcaarticulo")
        With ComboBoxMarca
            .DataSource = dtMarca              ' DataSource = DataTable
            .DisplayMember = display           ' DisplayMember = "Nombre" Nombre del campo que quieres que muestre el combo.
            .ValueMember = value               ' ValueMembes = "ID" Nombre de campo que utilizaras como identificador
        End With
        miGestionMySQLMarca.Dispose()
    End Sub

    'Seleciono Marca para aumentar 
    Private Sub CheckBoxMarca_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxMarca.CheckedChanged
        CheckBoxTodos.Checked = False

        If CheckBoxMarca.Checked = True Then
            ComboBoxMarca.Enabled = True
            llenarComboxMarca("maraarticulo", "Marca", "Marca")
        ElseIf CheckBoxMarca.Checked = False Then
            ComboBoxMarca.Enabled = False
            ComboBoxMarca.Text = ""
            Llenargrid()
        End If
    End Sub

    Private Sub ComboBoxMarca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxMarca.SelectedIndexChanged
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion ConsultarArticuloStock() de la claseGestionMySQL 
        Dim sql As String = "SELECT * FROM vistaarticulosystockyprecio  where Marca = '" & ComboBoxMarca.Text & "';"
        dtMitabla = miGestionMySQL.Consulta(sql)
        'con el dt devuelto lleno el datagriedview
        DGVArticulos.DataSource = dtMitabla
    End Sub


End Class