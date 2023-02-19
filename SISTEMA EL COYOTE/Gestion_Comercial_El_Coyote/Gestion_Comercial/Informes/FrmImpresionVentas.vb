Public Class FrmImpresionVentas

    Dim dt As New DataTable
    Dim tabla As New DataTable
    Dim Articulo As New ClassArticulo
    'conecto a base de datos
    Dim miGestionMySQL As New GestionMySQL
    Dim maquetaSuperior As String = "<!DOCTYPE html>   <html lang='es'>    <head>   <meta charset='utf-8'>  <meta name='viewport' content='width=device-width, initial-scale=1, shrink-to-fit=no'>  <!-- Latest compiled and minified CSS -->  <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css'>  </head>     <body>     <h1 class='text-center'>Informe de Ventas desde : " & GlobalDesdeVentas & " hasta: " & GlobalHastaVentas & "</h1>  <br> <div class='container'>    <table class='table table-hover'>    <thead>      <tr class='active'><th>idVentas</th><th>Fecha</th> <th>Total</th></tr></thead><tbody>"

    ' filas del grid van aca ****

    Dim maquetaInferior As String = "    </tbody>   </table>   </div>     <p>GiFSys</p>       </body>  </html>"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Genera_Informe()
    End Sub

    Private Sub BtnEjecutar_Click(sender As Object, e As EventArgs)
        WebBrowser1.DocumentText = RichTextBox1.Text
    End Sub

    Private Sub Genera_Informe()

        dt = miGestionMySQL.Consulta("CALL get_inf_Venta_4(STR_TO_DATE('" & GlobalDesdeVentas & "','%d/%m/%Y')  ,  STR_TO_DATE('" & GlobalHastaVentas & "','%d/%m/%Y'))")
        'cierro conexion
        miGestionMySQL.Dispose()

        'idVentas, Fecha, Total
        Dim idVentas, Fecha, Total As String
        Dim filahtml As String = ""

        For Each fila As DataRow In dt.Rows
            idVentas = fila("idVentas")
            Fecha = fila("Fecha")
            Total = fila("Total")
            filahtml += " <tr> <td> " & idVentas & "  </td> <td> " & Fecha & " </td> <td>" & Total & "</td> </tr>"
        Next
        RichTextBox1.Text = maquetaSuperior + filahtml + maquetaInferior
        WebBrowser1.DocumentText = RichTextBox1.Text
    End Sub
End Class