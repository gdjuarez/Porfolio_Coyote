Public Class FrmImpresionCaja
    Dim dt As New DataTable
    Dim tabla As New DataTable
    Dim Articulo As New ClassArticulo
    'conecto a base de datos
    Dim miGestionMySQL As New GestionMySQL
    Dim maquetaSuperior As String = "<!DOCTYPE html> <html lang='es'> <head>   <meta charset='utf-8'> <meta name='viewport' content='width=device-width, initial-scale=1, shrink-to-fit=no'>  <!-- Latest compiled and minified CSS --> <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css'> </head> <body> <h1 class='text-center'>Informe de Movimientos de caja desde : " & GlobalDesdeCaja & " hasta: " & GlobalHastaCaja & "</h1> <br> <div class='container'>   <table class='table table-hover'> <thead> <tr class='active'> <th>Fecha</th> <th>Tipomovimiento</th> <th>Descripcion</th> <th>TipoComprobante</th> <th>SerieNumero</th>  <th>ImporteIngreso</th> <th>ImporteSalida</th> </thead><tbody> ' filas del grid van aca ****"

    Dim maquetaInferior As String = "</tbody>  </table>   </div>     <p>GiFSys</p> </body>  </html>"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Genera_Informe()
    End Sub

    Private Sub BtnEjecutar_Click(sender As Object, e As EventArgs)
        WebBrowser1.DocumentText = RichTextBox1.Text
    End Sub

    Private Sub Genera_Informe()

        dt = miGestionMySQL.Consulta("CALL get_inf_CajaxDia(STR_TO_DATE('" & GlobalDesdeCaja & "','%d/%m/%Y')  ,  STR_TO_DATE('" & GlobalHastaCaja & "','%d/%m/%Y'))")
        'cierro conexion
        miGestionMySQL.Dispose()

        'Fecha, TipoMovimiento, Descripcion, TipoComprobante, SerieNumero, ImporteIngreso, ImporteSalida
        Dim Fecha, TipoMovimiento, Descripcion, TipoComprobante, SerieNumero, ImporteIngreso, ImporteSalida As String
        Dim filahtml As String = ""

        For Each fila As DataRow In dt.Rows
            Fecha = fila("Fecha")
            TipoMovimiento = fila("TipoMovimiento")
            Descripcion = fila("Descripcion")
            TipoComprobante = fila("TipoComprobante")
            SerieNumero = fila("SerieNumero")
            ImporteIngreso = fila("ImporteIngreso")
            ImporteSalida = fila("ImporteSalida")
            filahtml += " <tr> <td> " & Fecha & "  </td> <td> " & TipoMovimiento & " </td> <td>" & Descripcion & "</td>  <td>" & TipoComprobante & "</td> <td>" & SerieNumero & "</td> <td>" & ImporteIngreso & "</td> <td>" & ImporteSalida & "</td>  </tr>"
        Next
        RichTextBox1.Text = maquetaSuperior + filahtml + maquetaInferior
        WebBrowser1.DocumentText = RichTextBox1.Text
    End Sub
End Class