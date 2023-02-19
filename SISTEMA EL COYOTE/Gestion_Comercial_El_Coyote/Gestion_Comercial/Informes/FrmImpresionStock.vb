Public Class FrmImpresionStock
    Dim dt As New DataTable
    Dim tabla As New DataTable
    Dim Articulo As New ClassArticulo
    'conecto a base de datos
    Dim miGestionMySQL As New GestionMySQL
    Dim maquetaSuperior As String = "<!DOCTYPE html>  <html lang='es'>    <head>   <meta charset='utf-8'>   <meta name='viewport' content='width=device-width, initial-scale=1, shrink-to-fit=no'><!-- Latest compiled and minified CSS --> <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css'>  </head><body>  <h1 class='text-center'>Informe de Artículos</h1> <br> <div class='container'> <table class='table table-hover'><thead><tr class='active'> <th>Articulo</th> <th>Descripcion</th> <th>PrecioCompra</th><th>PrecioVenta</th> <th>Marca</th> <th>Rubro</th> <th>Stock</th><th>Stockminimo</th> </tr></thead> <tbody>"
    ' filas del grid van aca ****
    Dim maquetaInferior As String = "</tbody> </table></div><p>GiFSys</p> </body> </html>"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Genera_Informe()
    End Sub

    Private Sub BtnEjecutar_Click(sender As Object, e As EventArgs)
        WebBrowser1.DocumentText = RichTextBox1.Text
    End Sub

    Private Sub Genera_Informe()
        dt = miGestionMySQL.ConsultarTabla("vistaConsultarArticuloStock")
        'cierro conexion
        miGestionMySQL.Dispose()
        'idArticulo, Descripcion, PrecioCompra, PrecioVenta, Marca,Rubro, Stock, StockMinimo
        Dim idArticulo, Descripcion, PrecioCompra, PrecioVenta, Marca, Rubro, Stock, StockMinimo As String
        Dim filahtml As String = ""
        For Each fila As DataRow In dt.Rows
            idArticulo = fila("idArticulo")
            Descripcion = fila("Descripcion")
            PrecioCompra = fila("PrecioCompra")
            PrecioVenta = fila("PrecioVenta")
            Marca = fila("Marca")
            Rubro = fila("Rubro")
            Stock = fila("Stock")
            StockMinimo = fila("StockMinimo")
            filahtml += " <tr> <td>" & idArticulo & "</td> <td> " & Descripcion & " </td> <td>" & PrecioCompra & "</td>  <td>" & PrecioVenta & "</td> <td>" & Marca & "</td> <td>" & Rubro & "</td> <td>" & Stock & "</td> <td>" & StockMinimo & "</td>   </tr>"
        Next
        RichTextBox1.Text = maquetaSuperior + filahtml + maquetaInferior
        WebBrowser1.DocumentText = RichTextBox1.Text
    End Sub
End Class
