﻿Imports System.Windows.Forms

Public Class MDIMenu

    Private Sub MDIMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Gestión Comercial - GiF Sys - " & Date.Today

        Me.ToolStripLabelUsuario.Text = usuarioGlobal
        If usuarioGlobal = "Admin" Or "1" Then
            'acceso total
        Else

            CajaToolStripMenuItem1.Visible = False
            ActualizaPrecioToolStripMenuItem.Visible = False
            ArticulosToolStripMenuItem1.Visible = False
            MarcaToolStripMenuItem.Visible = False
            ActualizaPrecioToolStripMenuItem.Visible = False
            MovimientosDeCajaToolStripMenuItem.Visible = False
            BackUpToolStripMenuItem1.Visible = False
            UsuariosToolStripMenuItem1.Visible = False
            GestionDePagoDeComprasToolStripMenuItem.Visible = False
            ComprasPorProveedorToolStripMenuItem.Visible = False
        End If

    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).WindowState = FormWindowState.Normal
        Next
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).WindowState = FormWindowState.Minimized
        Next
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub ConfiguraciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraciónToolStripMenuItem.Click
        FrmMisDatos.MdiParent = Me
        FrmMisDatos.Show()
    End Sub

    Private Sub ArticulosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArticulosToolStripMenuItem1.Click
        FrmArticulos.MdiParent = Me
        FrmArticulos.Show()
        FrmArticulos.BtnSeleccionar.Visible = True
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        frmClientes.MdiParent = Me
        frmClientes.Show()
    End Sub

    Private Sub ClienteRetiraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteRetiraToolStripMenuItem.Click
        FrmClienteRetira.MdiParent = Me
        FrmClienteRetira.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
        frmProveedores.MdiParent = Me
        frmProveedores.Show()
        frmProveedores.BtnCopiar.Visible = True
    End Sub

    Private Sub ActualizaPrecioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizaPrecioToolStripMenuItem.Click
        FrmActualizaPrecio.MdiParent = Me
        FrmActualizaPrecio.Show()
    End Sub

    Private Sub GestionDePagoDeComprasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDePagoDeComprasToolStripMenuItem.Click
        FrmGestionCompras.MdiParent = Me
        FrmGestionCompras.Show()
    End Sub

    Private Sub ComprasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem1.Click
        frmCompras.MdiParent = Me
        frmCompras.Show()
    End Sub

    Private Sub PresupuestoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PresupuestoToolStripMenuItem2.Click
        FrmPresupuestos.MdiParent = Me
        FrmPresupuestos.Show()
    End Sub

    Private Sub VentasToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem2.Click
        FrmVentas.MdiParent = Me
        FrmVentas.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        FrmAbout.MdiParent = Me
        FrmAbout.Show()
    End Sub

    Private Sub BackUpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackUpToolStripMenuItem1.Click
        FrmBackUp.MdiParent = Me
        FrmBackUp.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem1.Click
        LoginFormUsuarios.MdiParent = Me
        LoginFormUsuarios.Show()
    End Sub

    Private Sub ComprasPorProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprasPorProveedorToolStripMenuItem.Click
        FrmDesdeHastaProveedores.MdiParent = Me
        FrmDesdeHastaProveedores.Show()
        FrmDesdeHastaProveedores.BtnInfProveedor.Visible = True
    End Sub

    Private Sub PresupuestoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PresupuestoToolStripMenuItem1.Click
        FrmBusquedaPresupuesto.MdiParent = Me
        FrmBusquedaPresupuesto.Show()
    End Sub

    Private Sub VentasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasToolStripMenuItem1.Click
        FrmBusquedaVenta.MdiParent = Me
        FrmBusquedaVenta.Show()
    End Sub

    Private Sub VentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentaToolStripMenuItem.Click
        FrmVentas.MdiParent = Me
        FrmVentas.Show()
    End Sub

    Private Sub VentaCCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentaCCToolStripMenuItem.Click
        FrmVentasCC.MdiParent = Me
        FrmVentasCC.Show()
        FrmVentasCC.TxtBuscarCodigoBarra.Select()
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmCompras.MdiParent = Me
        frmCompras.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim resultado As DialogResult = MessageBox.Show("Está seguro de salir?",
                                            "Atención", MessageBoxButtons.YesNo)
        If resultado = Windows.Forms.DialogResult.Yes Then
            'Deja el formulario activo 
            FrmLogin.Show()
            FrmLogin.UsernameTextBox.Focus()
            Me.Close()
        End If
    End Sub

    Private Sub CajaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CajaToolStripMenuItem1.Click
        frmCaja.MdiParent = Me
        frmCaja.Show()
    End Sub

    'Informes
    Private Sub StockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockToolStripMenuItem.Click
        FrmImpresionStock.MdiParent = Me
        FrmImpresionStock.Show()
    End Sub

    Private Sub StockMinimoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockMinimoToolStripMenuItem.Click
        FrmImpresionStockMinimo.MdiParent = Me
        FrmImpresionStockMinimo.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem1.Click
        FrmImpresionClientes.MdiParent = Me
        FrmImpresionClientes.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        FrmImpresionProveedores.MdiParent = Me
        FrmImpresionProveedores.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasToolStripMenuItem.Click
        FrmDesdeHasta.MdiParent = Me
        FrmDesdeHasta.Show()
        FrmDesdeHasta.BtnInfVenta.Visible = True
    End Sub

    Private Sub MovimientosDeCajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientosDeCajaToolStripMenuItem.Click
        FrmDesdeHasta.MdiParent = Me
        FrmDesdeHasta.Show()
        FrmDesdeHasta.BtnInfCaja.Visible = True
    End Sub

    Private Sub CuentaCorrientePorClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentaCorrientePorClienteToolStripMenuItem.Click
        FrmDesdeHastaProveedores.MdiParent = Me
        FrmDesdeHastaProveedores.Show()
        FrmDesdeHastaProveedores.BtnInfProveedor.Visible = True
    End Sub

    Private Sub CuentaCorrientePorClienteQueRetiraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentaCorrientePorClienteQueRetiraToolStripMenuItem.Click
        FrmDesdeHastaClienteRetira.MdiParent = Me
        FrmDesdeHastaClienteRetira.Show()
        FrmDesdeHastaClienteRetira.BtnInfClienteRetira.Visible = True
    End Sub

    Private Sub ConsultaPrecioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaPrecioToolStripMenuItem.Click
        FrmConsultaPrecio.MdiParent = Me
        FrmConsultaPrecio.Show()
    End Sub

    'Private Sub EtiquetasConPrecioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EtiquetasConPrecioToolStripMenuItem.Click
    '    FrmEtiquetasPrecio.MdiParent = Me
    '    FrmEtiquetasPrecio.Show()
    'End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Dim d
        d = Shell("Calc.exe")
    End Sub

 
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        FrmNavegador.MdiParent = Me
        FrmNavegador.Show()
    End Sub

    Private Sub CuentaCorrienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentaCorrienteToolStripMenuItem.Click
        FrmBusquedaVentaSinPago.MdiParent = Me
        FrmBusquedaVentaSinPago.Show()
    End Sub

    Private Sub CargaPagoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargaPagoToolStripMenuItem.Click
        FrmCargaPagoCC.MdiParent = Me
        FrmCargaPagoCC.Show()
    End Sub

    Private Sub MarcaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarcaToolStripMenuItem.Click
        FrmMarca.MdiParent = Me
        FrmMarca.Show()
    End Sub

    Private Sub TouchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TouchToolStripMenuItem.Click
        FrmVentasTouch.MdiParent = Me
        FrmVentasTouch.Show()
    End Sub

End Class
