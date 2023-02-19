Public Class FrmDesdeHasta

    Private Sub FrmDesdeHasta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnInfVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInfVenta.Click
        BtnInfVenta.Enabled = False
        GlobalDesdeVentas = Convert.ToDateTime(DTPdesde.Text)
        GlobalHastaVentas = Convert.ToDateTime(DTPhasta.Text)
        FrmImpresionVentas.MdiParent = MDIMenu
        FrmImpresionVentas.Show()
        Me.Close()
    End Sub

    Private Sub BtnCaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInfCaja.Click
        BtnInfCaja.Enabled = False
        GlobalDesdeCaja = Convert.ToDateTime(DTPdesde.Text)
        GlobalHastaCaja = Convert.ToDateTime(DTPhasta.Text)
        FrmImpresionCaja.MdiParent = MDIMenu
        FrmImpresionCaja.Show()
        Me.Close()
    End Sub

End Class