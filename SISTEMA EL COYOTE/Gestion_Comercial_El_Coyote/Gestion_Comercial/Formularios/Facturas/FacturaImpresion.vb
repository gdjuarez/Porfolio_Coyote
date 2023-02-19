Public Class FacturaImpresion

    Dim misDatosdt As New DataTable
    Dim dt As New DataTable
    Dim Articulo As New ClassArticulo
    'conecto a base de datos
    Dim miGestionMySQL As New GestionMySQL
    Dim miDatosGestionMySQL As New GestionMySQL


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Genera_Informe()
    End Sub


    Private Sub Genera_Informe()

        misDatosdt = miDatosGestionMySQL.ConsultarTabla("misdatos")
        'cierro conexion
        miDatosGestionMySQL.Dispose()
        'RazonSocial, Direccion, Ciudad, Telefono, Email, Cuit
        Dim miRazonSocial, miDireccion, miCiudad, miTelefono, miEmail, miCuit As String
        Dim tabla_misdatos As String = ""

        For Each fila As DataRow In misDatosdt.Rows
            'cabecera
            miRazonSocial = fila("RazonSocial")
            miDireccion = fila("Direccion")
            miCiudad = fila("Ciudad")
            miTelefono = fila("Telefono")
            miEmail = fila("Email")
            miCuit = fila("Cuit")

            ' tabla_misdatos = " <table> <tr> <td>" & miRazonSocial & "</td> <td>" & miDireccion & "</td> <td> " & miCiudad & " </td> <td>" & miTelefono & "</td> <td>" & miEmail & "</td><td> " & miCuit & "</td> </tr> </table>"

        Next

        ' MsgBox(tabla_misdatos)

        '*********************************************************************
        dt = miGestionMySQL.Consulta("CALL get_Factura(" & Global_numeroVenta & ")")
        'cierro conexion
        miGestionMySQL.Dispose()
        'RazonSocial, Apellido, Nombre, Domicilio, idVentas, Fecha, Total, idVentaArticulo, idArticulo, Descripcion, Cantidad, PrecioUnitario, Importe
        Dim RazonSocial, Apellido, Nombre, Domicilio, idVentas, Fecha, Total, idArticulo, Descripcion, Cantidad, PrecioUnitario, Importe As String
        Total = ""
        Dim tabla_grid As String = ""
        For Each fila As DataRow In dt.Rows
            'cabecera
            If IsDBNull(fila("RazonSocial")) Then
                RazonSocial = ""
            Else
                RazonSocial = fila("RazonSocial")
            End If
            If IsDBNull(fila("Apellido")) Then
                Apellido = ""
            Else
                Apellido = fila("Apellido")
            End If
            If IsDBNull(fila("Nombre")) Then
                Nombre = ""
            Else
                Nombre = fila("Nombre")
            End If
            'Domicilio = fila("Domicilio")
            idVentas = fila("idVentas")
            Fecha = fila("Fecha")
            Total = fila("Total")
            idVentas = fila("idVentas")
            'grid
            Cantidad = fila("Cantidad")
            idArticulo = fila("idArticulo")
            Descripcion = fila("Descripcion")
            PrecioUnitario = fila("PrecioUnitario")
            Importe = fila("Importe")

            tabla_grid += " <tr>  <td>" & Cantidad & "</td> <td>" & idArticulo & "</td> <td> " & Descripcion & " </td> <td>" & PrecioUnitario & "</td> <td>" & Importe & "</td> </tr>"

        Next

        ' DOCUMENTO HTML formado por (Html_Doc + tabla_Titulo + tabla_grid + tabla_pie)
        Dim Html_Doc As String = "<!DOCTYPE html> <html lang='es'> <head> <meta charset='utf-8'>  <meta name='viewport' content='width=device-width, initial-scale=1, shrink-to-fit=no'>  <!-- Latest compiled and minified CSS -->  <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css'>  </head> <body> <div style='margin-left:10px'>    <table width='100%' cellspacing='4' cellpadding='1'> <tr> <td> " & miRazonSocial & " </td> <td>  </td>  <td> </td> </tr> <tr> <td> " & miDireccion & "- " & miCiudad & " </td> <td> Fecha: " & Fecha & "</td> <td>" & RazonSocial & "</td>  </tr>  <tr> <td> " & miTelefono & " </td> <td>  </td> <td> " & Nombre & " </td> </tr>  <tr> <td> " & miEmail & " </td> <td> n°:0001-" & idVentas & " </td> <td>" & Apellido & "</td> </tr> <tr> <td> " & miCuit & "</td> <td>  </td> <td>  </td> </tr>  </table>    </div>      "

        Dim tabla_Titulo As String = "<div class='container'>  <table class='table table-active'> <thead><tr class='active'> <th>Cantidad</th> <th>Codigo</th> th>Descripcion</th> <th>PrecioUnitario</th> <th>Importe</th> </tr>  </thead>  <tbody>"

        'tabla_grid

        Dim tabla_pie As String = "<tr>  <td> </td> <td></td> <td>  </td> <td> Total: </td> <td>" & Total & "</td> </tr> </tbody> </table> <hr>  <footer>      <p>No Valido como Factura</p> </footer> </body> </html>"


        RichTextBox1.Text = Html_Doc + tabla_Titulo + tabla_grid + tabla_pie
        WebBrowser1.DocumentText = RichTextBox1.Text

    End Sub


End Class