Public Class ComprobanteCC

    Dim misDatosdt As New DataTable
    Dim dt As New DataTable
    Dim Articulo As New ClassArticulo
    'conecto a base de datos
    Dim miGestionMySQL As New GestionMySQL
    Dim miDatosGestionMySQL As New GestionMySQL

    Private Sub ComprobanteCC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Genera_Informe()
    End Sub

    Private Sub Genera_Informe()


        misDatosdt = miDatosGestionMySQL.ConsultarTabla("misdatos")
        'cierro conexion
        miDatosGestionMySQL.Dispose()
        'RazonSocial, Direccion, Ciudad, Telefono, Email, Cuit
        Dim miRazonSocial, miDireccion, miCiudad, miTelefono, miEmail, miCuit As String
        Dim tabla_misdatos As String = ""
        miRazonSocial = ""
        miDireccion = ""
        miCiudad = ""
        miTelefono = ""
        miEmail = ""
        miCuit = ""

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
        dt = miGestionMySQL.get_ComprobanteCC(Global_numeroVentacc)
        'cierro conexion
        miGestionMySQL.Dispose()
        'RazonSocial, Apellido, Nombre, Domicilio, idVentascc, Fecha, Total, idVentaccArticulo, idArticulo, Descripcion, Cantidad, PrecioUnitario, Importe
        Dim RazonSocial, Apellido, Nombre, idVentascc, Fecha, Total, idArticulo, Descripcion, Cantidad, PrecioUnitario, Importe As String
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
            idVentascc = fila("idVentascc")
            Fecha = fila("Fecha")
            Total = fila("Total")

            'grid
            Cantidad = fila("Cantidad")
            idArticulo = fila("idArticulo")
            Descripcion = fila("Descripcion")
            PrecioUnitario = fila("PrecioUnitario")
            Importe = fila("Importe")

            tabla_grid += " <tr>  <td>" & Cantidad & "</td> <td>" & idArticulo & "</td> <td> " & Descripcion & " </td> <td>" & PrecioUnitario & "</td> <td>" & Importe & "</td> </tr>"

        Next

        ' DOCUMENTO HTML formado por (Html_Doc + tabla_Titulo + tabla_grid + tabla_pie)
        Dim Html_Doc As String = "<!DOCTYPE html>"
        Html_Doc += "<html lang='es'>"
        Html_Doc += "<head> <meta charset='utf-8'> <meta name='viewport' content='width=device-width, initial-scale=1, shrink-to-fit=no'> <!-- Latest compiled and minified CSS -->"
        Html_Doc += "<link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css'> "
        Html_Doc += "</head>"

        Html_Doc += "<body>     <h1> Cuenta Corriente </h1> <div style='margin-left:10px'>"
        Html_Doc += "<table width='100%' cellspacing='4' cellpadding='1'>"
        Html_Doc += "<tr> <td> " & miRazonSocial & " </td> <td>  </td>  <td> </td> </tr>"
        Html_Doc += "<tr> <td> " & miDireccion & "- " & miCiudad & " </td> <td> Fecha: " & Fecha & "</td> <td>" & RazonSocial & "</td>  </tr> "
        Html_Doc += "<tr> <td> " & miTelefono & " </td> <td>  </td> <td> " & Nombre & " </td> </tr>   "
        Html_Doc += "<tr> <td> " & miEmail & " </td> <td> n°:0001-" & idVentascc & " </td> <td>" & Apellido & "</td> </tr>"
        Html_Doc += "<tr> <td> " & miCuit & "</td> <td>  </td> <td>  </td> </tr>   "
        Html_Doc += "</table>"
        Html_Doc += "</div>"

        Dim tabla_Titulo As String = " <div class='container'><table class='table table-active'> <thead> <tr class='active'> <th>Cantidad</th><th>Codigo</th><th>Descripcion</th> <th>PrecioUnitario</th><th>Importe</th></tr></thead> <tbody>"

        'tabla_grid

        Dim tabla_pie As String = "<tr>  <td> </td> <td></td> <td>  </td> <td> Total: </td> <td>" & Total & "</td> </tr> </tbody> </table> <hr><footer> <p>No Valido como Factura</p></footer></body> </html>"


        RichTextBox1.Text = Html_Doc + tabla_Titulo + tabla_grid + tabla_pie
        WebBrowser1.DocumentText = RichTextBox1.Text

    End Sub




End Class