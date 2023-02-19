Public Class FrmConsultaPrecio

    Private Sub FrmConsultaPrecio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCodigo.KeyDown

        Select Case e.KeyData
            Case Keys.Enter
                buscoPrecio(TxtCodigo.Text)
        End Select


    End Sub

    Private Sub buscoPrecio(ByVal idArticulo As String)
        Dim dtcodigo As New DataTable
        Dim miConexionIdCliente1 As New GestionMySQL
        Dim miConexionIdCliente2 As New GestionMySQL
        Dim sql1 As String = ""
        Dim sql2 As String = ""
        Dim nombre As String = ""
        Dim precio As Double = 0
        If TxtCodigo.Text = "Codigo" Then
            MsgBox("Ingrese un codigo de articulo")
        Else
            'BUsco el nombre
            Try
                sql1 = "select descripcion from articulo where idarticulo = '" & idArticulo & "'"
                'MsgBox(sql)
                dtcodigo = miConexionIdCliente1.Consulta(sql1)
                For Each MiDataRow In dtcodigo.Rows
                    nombre = MiDataRow("descripcion")
                Next
                miConexionIdCliente1.Dispose()
            Catch ex As Exception
                MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
            End Try
            'Busco el precio
            Try
                sql2 = "select PrecioVenta from articulo where idarticulo = '" & idArticulo & "'"
                'MsgBox(sql)
                dtcodigo = miConexionIdCliente2.Consulta(sql2)
                For Each MiDataRow In dtcodigo.Rows
                    precio = MiDataRow("PrecioVenta")
                Next
                miConexionIdCliente2.Dispose()
            Catch ex As Exception
                MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
            End Try
            TxtArticulo.Text = nombre
            TxtPrecio.Text = precio.ToString("c2")
            'Si no hay dato limpio
            If TxtArticulo.Text = "" Or TxtPrecio.Text = "" Then
                MsgBox("Codigo de articulo no cargado")
                TxtCodigo.Text = "Codigo"
                TxtArticulo.Text = ""
                TxtPrecio.Text = ""
                TxtCodigo.Focus()
            End If
        End If
    End Sub





    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TxtCodigo.Text = "Codigo"
        TxtArticulo.Clear()
        TxtPrecio.Clear()
        TxtCodigo.Select
    End Sub

    Private Sub BtnArticulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArticulos.Click
        FrmBusquedaArticulo.MdiParent = MDIMenu
        FrmBusquedaArticulo.Show()
        FrmBusquedaArticulo.BtnCopiarPrecio.Visible = True
    End Sub
End Class