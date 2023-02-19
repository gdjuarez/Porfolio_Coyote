Imports System.IO
Public Class FrmEtiquetasPrecio
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

    'Actualizo precio
    Private Sub GeneraEtiqueta()
        'Hay que chequear que al menos halla una fila seleccionada
        Dim CodArticulo As String = ""
        Dim Precio As String = ""
        Dim Descripcion As String = ""
        Dim cadena As String = ""
        'con este ciclo recorro el datagridview
        For Each row As DataGridViewRow In DGVArticulos.Rows
            If row.Cells(0).Value = True Then

                cadena += "" & row.Cells(1).Value & "," & row.Cells(2).Value & "," & Replace(row.Cells(6).Value, ",", ".") & vbCrLf
                '-----------------------------------------------------
            End If
        Next
        MsgBox(cadena)
        GeneraArchivo(cadena)
    End Sub

    Private Sub GeneraArchivo(ByVal cadena As String)
        Const fic As String = "c:\temp\Etiqueta.txt"
        Dim sw As New System.IO.StreamWriter(fic)
        sw.WriteLine(cadena)
        sw.Close()
        MsgBox("Archivo exportado a C:\temp\Etiqueta.txt")
    End Sub

    'Codigo del boton actualizar
    Private Sub BtnGenera_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnGenera.Click
        GeneraEtiqueta()
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