Public Class FrmCreaCodigos

    Private Sub BtnGenerarCodigos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerarCodigos.Click

        If TxtCodigo.Text = "Codigo" Then
            MsgBox("Ingrese un codigo de articulo")
        Else
            Try
                Dim alto As Single = 15
                Dim Nombre As String = TxtArticulo.Text.Trim
                Dim bm As Bitmap = Nothing
                bm = Codigos.codigo128(TxtArticulo.Text, "A" & TxtCodigo.Text & "B", alto)
                If Not IsNothing(bm) Then
                    PBCodigo.Image = bm
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            buscoNombre(TxtCodigo.Text)
        End If
    End Sub


    Private Sub buscoNombre(ByVal idArticulo As String)
        Dim dtcodigo As New DataTable
        Dim miConexionIdCliente As New GestionMySQL
        Dim sql As String = ""
        Dim nombre As String = ""
        If TxtCodigo.Text = "Codigo" Then
            MsgBox("Ingrese un codigo de articulo")
        Else
            Try
                sql = "select descripcion from articulo where idarticulo = '" & idArticulo & "'"
                'MsgBox(sql)
                dtcodigo = miConexionIdCliente.Consulta(sql)
                For Each MiDataRow In dtcodigo.Rows
                    nombre = MiDataRow("descripcion")
                Next
                miConexionIdCliente.Dispose()
            Catch ex As Exception
                MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
            End Try
            TxtArticulo.Text = nombre
            If TxtArticulo.Text = "" Then
                MsgBox("Codigo de articulo no cargado")
                TxtCodigo.Text = "Codigo"
                TxtArticulo.Text = ""
                PBCodigo.Image = Nothing
                TxtCodigo.Focus()
            End If
        End If
        LblArticulo.Text = nombre
    End Sub


End Class