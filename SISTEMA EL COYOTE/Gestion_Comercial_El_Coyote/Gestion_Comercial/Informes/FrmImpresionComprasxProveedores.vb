Public Class FrmImpresionComprasxProveedores
    Dim dt As New DataTable
    Dim tabla As New DataTable
    Dim Articulo As New ClassArticulo
    'conecto a base de datos
    Dim miGestionMySQL As New GestionMySQL
    Dim maquetaSuperior As String = "<!DOCTYPE html><html lang='es'> <head> <meta charset='utf-8'> <meta name='viewport' content='width=device-width, initial-scale=1, shrink-to-fit=no'> <!-- Latest compiled and minified CSS --> <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css'> </head>  <body>  <h1 class='text-center'>Listado de compras al proveedor " & GlobalProveedor & " desde: " & GlobalDesdeProveedor & " hasta: " & GlobalHastaProveedor & "</h1>  <br> <div class='container'><table class='table table-hover'> <thead><tr class='active'><th>idCompras</th> <th>Fecha</th><th>idProveedor</th> <th>RazonSocial</th><th>Total</th><th>Pagado</th>  </tr> </thead> <tbody>"

    ' filas del grid van aca ****

    Dim maquetaInferior As String = "</tbody>  </table>   </div>     <p>GiFSys</p>        </body>  </html>"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Genera_Informe()
    End Sub

    Private Sub BtnEjecutar_Click(sender As Object, e As EventArgs)
        WebBrowser1.DocumentText = RichTextBox1.Text
    End Sub

    Private Sub Genera_Informe()

        dt = miGestionMySQL.Consulta("call Get_ComprasXvendedorYfecha(" & GlobalIdProveedor & ", STR_TO_DATE('" & GlobalDesdeProveedor & "','%d/%m/%Y'), STR_TO_DATE('" & GlobalHastaProveedor & "','%d/%m/%Y'))")
        'STR_TO_DATE('" & GlobalDesdeProveedor & "','%d/%m/%Y')  ,  STR_TO_DATE('" & GlobalHastaProveedor & "','%d/%m/%Y'))
        'cierro conexion
        miGestionMySQL.Dispose()

        'idCompras, Fecha, idProveedor, RazonSocial, Total, Pagado
        Dim idCompras, Fecha, idProveedor, RazonSocial, Total, Pagado As String
        Dim filahtml As String = ""

        For Each fila As DataRow In dt.Rows
            idCompras = fila("idCompras")
            Fecha = fila("Fecha")
            idProveedor = fila("idProveedor")
            RazonSocial = fila("RazonSocial")
            Total = fila("Total")
            Pagado = fila("Pagado")
            filahtml += " <tr> <td> " & idCompras & "  </td> <td> " & Fecha & " </td> <td>" & idProveedor & "</td>  <td>" & RazonSocial & "</td> <td>" & Total & "</td> <td>" & Pagado & "</td>  </tr>"
        Next
        RichTextBox1.Text = maquetaSuperior + filahtml + maquetaInferior
        WebBrowser1.DocumentText = RichTextBox1.Text
    End Sub

End Class