Module Module_Variables_Globales

    Public Global_Conexion_Local As String = ("Server=localhost;Port=3307;Database=Gestion_Comercial;User=GiFSys;Password=GiFSys1502;")

    'Usado para pasar de frmLogin-Usuario al MDIParent
    Public usuarioGlobal As String
    'Usado para pasar por parametro el numero del presupuesto e imprimir
    Public Global_numeroPresupuesto As Integer
    'Usado para asignar el idCompras 
    Public Global_numeroCompra As Integer
    Public Global_numeroVenta As Integer
    '-------------caja-----
    Public Global_ultimoGrabado As Integer
    Public flag As String
    '---------------------
    Public GlobalDesdeVentas As Date
    Public GlobalHastaVentas As Date
    Public GlobalDesdeCaja As Date
    Public GlobalHastaCaja As Date

    'usado para anular una Venta
    Public Global_AnularVenta As Integer
    Public Global_RazonSocialCliente As String

    '------ventasCC------------------
    Public Global_numeroVentacc As Integer

    Public Global_saldo As Double


    Public GlobalDesdeClienteCC As Date
    Public GlobalHastaClienteCC As Date
    Public GlobalIdClienteCC As String
    Public GlobalClienteCC As String

    Public GlobalDesdeClienteCCRetira As Date
    Public GlobalHastaClienteCCRetira As Date
    Public GlobalIdClienteCCClienteretira As String
    Public GlobalClienteCCClienteretira As String
    Public GlobalIdClienteCCRetira As String
    Public GlobalClienteCCRetira As String

    Public GlobalDesdeProveedor As Date
    Public GlobalHastaProveedor As Date
    Public GlobalIdProveedor As String
    Public GlobalProveedor As String

End Module
