Public Class FrmInformeDesdeHastaClienteRetira
    Dim dt As New DataTable
    Dim tabla As New DataTable
    Dim Articulo As New ClassArticulo
    'conecto a base de datos
    Dim miGestionMySQL As New GestionMySQL
    Dim maquetaSuperior As String = "<!DOCTYPE html><html lang='es'>    <head>   <meta charset='utf-8'>   <meta name='viewport' content='width=device-width, initial-scale=1, shrink-to-fit=no'>    <!-- Latest compiled and minified CSS -->    <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css'>  </head><body><h1 class='text-center'>Listado de ventas al cliente: " & GlobalProveedor & " desde: " & GlobalDesdeClienteCCRetira & " hasta: " & GlobalHastaClienteCCRetira & "</h1>  <br> <div class='container'> <table class='table table-hover'> <thead>  <tr class='active'> <th>Codigo</th> <th>Fecha</th><th>Cantidad</th> <th>idarticulo</th> <th>Descripcion</th> <th>PrecioUnitario</th> <th>Importe</th> <th>Apellido_Retira</th><th>Pagado</th> <th>idventaccarticulo</th> </tr>    </thead>    <tbody>"

    ' filas del grid van aca ****
    Dim maquetaInferior As String = "</tbody>  </table> </div> <p>GiFSys</p>  </body>  </html>"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Genera_Informe()
    End Sub

    Private Sub BtnEjecutar_Click(sender As Object, e As EventArgs)
        WebBrowser1.DocumentText = RichTextBox1.Text
    End Sub

    Private Sub Genera_Informe()

        dt = miGestionMySQL.Consulta("call Get_ArticulosEnCCporClienteRetiraXFecha(" & GlobalIdProveedor & ", STR_TO_DATE('" & GlobalDesdeClienteCCRetira & "','%d/%m/%Y'), STR_TO_DATE('" & GlobalHastaClienteCCRetira & "','%d/%m/%Y')," & GlobalIdClienteCCClienteretira & ", " & GlobalIdClienteCCRetira & ")")
        'cierro conexion
        miGestionMySQL.Dispose()

        'Codigo, Fecha, Cantidad, idarticulo, Descripcion, PrecioUnitario, Importe, Apellido_Retira, Pagado, idventaccarticulo
        Dim Codigo, Fecha, Cantidad, idarticulo, Descripcion, PrecioUnitario, Importe, Apellido_Retira, Pagado, idventaccarticulo As String
        Dim filahtml As String = ""

        For Each fila As DataRow In dt.Rows
            Codigo = fila("Codigo")
            Fecha = fila("Fecha")
            Cantidad = fila("Cantidad")
            idarticulo = fila("idarticulo")
            Descripcion = fila("Descripcion")
            PrecioUnitario = fila("PrecioUnitario")
            Importe = fila("Importe")
            Apellido_Retira = fila("Apellido_Retira")
            Pagado = fila("Pagado")
            idventaccarticulo = fila("idventaccarticulo")
            filahtml += " <tr> <td> " & Codigo & "  </td> <td> " & Fecha & " </td> <td>" & Cantidad & "</td>  <td>" & idarticulo & "</td> <td>" & Descripcion & "</td> <td>" & PrecioUnitario & "</td> <td>" & Importe & "</td>  <td>" & Apellido_Retira & "</td> <td>" & Pagado & "</td> <td>" & idventaccarticulo & "</td> </tr>"
        Next
        RichTextBox1.Text = maquetaSuperior + filahtml + maquetaInferior
        WebBrowser1.DocumentText = RichTextBox1.Text
    End Sub

    'Private Sub FrmInformeDesdeHastaClienteRetira_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    'TODO: esta línea de código carga datos en la tabla 'libreria_bigognoDataSetDesdeHastaClienteRetira.Get_ArticulosEnCCporClienteRetiraXFecha' Puede moverla o quitarla según sea necesario.
    '    'Me.Get_ArticulosEnCCporClienteRetiraXFechaTableAdapter.Fill(Me.libreria_bigognoDataSetDesdeHastaClienteRetira.Get_ArticulosEnCCporClienteRetiraXFecha, GlobalDesdeClienteCCRetira, GlobalHastaClienteCCRetira, GlobalIdClienteCCClienteretira, GlobalIdClienteCCRetira)
    '    Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Desde", GlobalDesdeClienteCCRetira))
    '    Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Hasta", GlobalHastaClienteCCRetira))
    '    Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Cliente", GlobalClienteCCClienteretira))
    '    Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Retira", GlobalClienteCCRetira))
    '    Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
    '    Me.ReportViewer1.RefreshReport()
    'End Sub
End Class