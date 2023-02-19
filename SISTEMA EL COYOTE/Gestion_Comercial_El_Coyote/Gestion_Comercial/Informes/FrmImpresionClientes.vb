Public Class FrmImpresionClientes

    Dim dt As New DataTable
    Dim tabla As New DataTable
    Dim Articulo As New ClassArticulo
    'conecto a base de datos
    Dim miGestionMySQL As New GestionMySQL
    Dim maquetaSuperior As String = "<!DOCTYPE html> <html lang='es'> <head>  <meta charset='utf-8'> <meta name='viewport' content='width=device-width, initial-scale=1, shrink-to-fit=no'>  <!-- Latest compiled and minified CSS --> <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css'> </head>  <body> <h1 class='text-center'>Listado de clientes </h1> <br><div class='container'> <table class='table table-hover'> <thead><tr class='active'> <th>idCliente</th> <th>Nombre</th><th>RazonSocial</th><th>Domicilio</th> <th>TelFijo</th><th>TelCelular</th>  <th>Email</th>  <th>Cuil</th><th>Observaciones</th> </tr> </thead>  <tbody>"

    ' filas del grid van aca ****

    Dim maquetaInferior As String = " </tbody> </table>  </div>  <p>GiFSys</p> </body>  </html>"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Genera_Informe()
    End Sub

    Private Sub BtnEjecutar_Click(sender As Object, e As EventArgs)
        WebBrowser1.DocumentText = RichTextBox1.Text
    End Sub

    Private Sub Genera_Informe()

        dt = miGestionMySQL.Consulta("SELECT * FROM cliente ")
        'cierro conexion
        miGestionMySQL.Dispose()

        'idCliente, Nombre, Apellido, RazonSocial, Domicilio, Ciudad, Provincia, CodigoPostal, TelFijo, TelCelular, Email, Cuil, Observaciones
        Dim idCliente, Nombre, RazonSocial, Domicilio, TelFijo, TelCelular, Email, Cuil, Observaciones As String
        Dim filahtml As String = ""

        For Each fila As DataRow In dt.Rows
            idCliente = fila("idCliente")
            Nombre = fila("Apellido")
            Nombre += " " & fila("Nombre")
            RazonSocial = fila("RazonSocial")
            Domicilio = fila("Domicilio")
            Domicilio += " " & fila("Ciudad")
            Domicilio += " " & fila("Provincia")
            Domicilio += " " & fila("CodigoPostal")

            TelFijo = fila("TelFijo")
            TelCelular = fila("TelCelular")
            Email = fila("Email")
            Cuil = fila("Cuil")
            Observaciones = fila("Observaciones")
            filahtml += " <tr> <td> " & idCliente & "  </td> <td> " & Nombre & " </td> <td>" & RazonSocial & "</td>  <td>" & Domicilio & "</td> <td>" & TelFijo & "</td> <td>" & TelCelular & "</td> <td>" & Email & "</td> <td>" & Cuil & "</td> <td>" & Observaciones & "</td>  </tr>"
        Next
        RichTextBox1.Text = maquetaSuperior + filahtml + maquetaInferior
        WebBrowser1.DocumentText = RichTextBox1.Text
    End Sub
End Class