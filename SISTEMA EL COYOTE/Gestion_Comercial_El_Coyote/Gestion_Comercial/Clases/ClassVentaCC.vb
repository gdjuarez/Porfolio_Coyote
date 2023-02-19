Public Class ClassVentaCC

    'Tabla Venta
    Private _IdVentacc As Integer
    Private _Fecha As Date
    Private _Total As Decimal
    'Tabla VentaArticulo
    Private _IdVentaccArticulos As Integer
    Private _idArticulo As Integer
    Private _Cantidad As Integer
    Private _PrecioUnitario As Decimal
    Private _Importe As Decimal

    Public Property IdVentacc As Integer
        Get
            Return _IdVentacc
        End Get
        Set(value As Integer)
            _IdVentacc = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(value As Date)
            _Fecha = value
        End Set
    End Property

    Public Property Total As Decimal
        Get
            Return _Total
        End Get
        Set(value As Decimal)
            _Total = value
        End Set
    End Property

    Public Property IdVentaccArticulos As Integer
        Get
            Return _IdVentaccArticulos
        End Get
        Set(value As Integer)
            _IdVentaccArticulos = value
        End Set
    End Property

    Public Property IdArticulo As Integer
        Get
            Return _idArticulo
        End Get
        Set(value As Integer)
            _idArticulo = value
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return _Cantidad
        End Get
        Set(value As Integer)
            _Cantidad = value
        End Set
    End Property

    Public Property PrecioUnitario As Decimal
        Get
            Return _PrecioUnitario
        End Get
        Set(value As Decimal)
            _PrecioUnitario = value
        End Set
    End Property

    Public Property Importe As Decimal
        Get
            Return _Importe
        End Get
        Set(value As Decimal)
            _Importe = value
        End Set
    End Property
End Class
