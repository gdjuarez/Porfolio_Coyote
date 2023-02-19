Public Class FrmImpresionProveedores

    Dim dt As New DataTable
    Dim tabla As New DataTable
    Dim Articulo As New ClassArticulo
    'conecto a base de datos
    Dim miGestionMySQL As New GestionMySQL
    Dim maquetaSuperior As String = "<!DOCTYPE html><html lang='es'> <head> <meta charset='utf-8'>   <meta name='viewport' content='width=device-width, initial-scale=1, shrink-to-fit=no'>  <!-- Latest compiled and minified CSS --> <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css'>  </head> <body><h1 class='text-center'>Listado de proveedores </h1><br> <div class='container'> <table class='table table-hover'> <thead> <tr class='active'><th>idProveedor</th> <th>RazonSocial</th> <th>Domicilio</th> <th>TelFijo</th>  <th>TelCelular</th>  <th>Email</th> <th>Cuit</th> <th>Comentarios</th> </tr> </thead> <tbody>"

    ' filas del grid van aca ****

    Dim maquetaInferior As String = "</tbody> </table>   </div>     <p>GiFSys</p>       </body>  </html>"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Genera_Informe()
    End Sub

    Private Sub BtnEjecutar_Click(sender As Object, e As EventArgs)
        WebBrowser1.DocumentText = RichTextBox1.Text
    End Sub

    Private Sub Genera_Informe()

        dt = miGestionMySQL.Consulta("SELECT * FROM proveedores ")
        'cierro conexion
        miGestionMySQL.Dispose()

        'idProveedor, RazonSocial, Domicilio, Localidad, TelFijo, TelCelular, CUIT, email, Comentarios
        Dim idProveedor, RazonSocial, Domicilio, TelFijo, TelCelular, CUIT, email, Comentarios As String
        Dim filahtml As String = ""

        For Each fila As DataRow In dt.Rows
            idProveedor = fila("idProveedor")
            RazonSocial = fila("RazonSocial")
            Domicilio = fila("Domicilio")
            Domicilio += " " & fila("Localidad")
            TelFijo = fila("TelFijo")
            TelCelular = fila("TelCelular")
            CUIT = fila("Cuit")
            email = fila("Email")
            Comentarios = fila("Comentarios")
            filahtml += " <tr> <td> " & idProveedor & "  </td> <td> " & RazonSocial & " </td> <td>" & Domicilio & "</td>  <td>" & TelFijo & "</td> <td>" & TelCelular & "</td> <td>" & email & "</td> <td>" & CUIT & "</td> <td>" & Comentarios & "</td>  </tr>"
        Next
        RichTextBox1.Text = maquetaSuperior + filahtml + maquetaInferior
        WebBrowser1.DocumentText = RichTextBox1.Text
    End Sub


End Class