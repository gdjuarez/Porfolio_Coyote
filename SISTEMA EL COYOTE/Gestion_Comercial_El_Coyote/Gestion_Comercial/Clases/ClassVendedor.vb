Public Class ClassVendedor
    Private _idVendedor As String
    Private _Nombre As String
    Private _Apellido As String
    Private _Sucursal As String
    Private _Domicilio As String
    Private _Ciudad As String
    Private _Provincia As String
    Private _CodigoPostal As String
    Private _TelFijo As String
    Private _TelCelular As String
    Private _Email As String
    Private _Cuil As String
    Private _Observaciones As String
    Private _Nivel As String

    Public Property idVendedor As String
        Get
            Return _idVendedor
        End Get
        Set(ByVal value As String)
            _idVendedor = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return _Apellido
        End Get
        Set(ByVal value As String)
            _Apellido = value
        End Set
    End Property

    Public Property Sucursal As String
        Get
            Return _Sucursal
        End Get
        Set(ByVal value As String)
            _Sucursal = value
        End Set
    End Property

    Public Property Domicilio As String
        Get
            Return _Domicilio
        End Get
        Set(ByVal value As String)
            _Domicilio = value
        End Set
    End Property

    Public Property Ciudad As String
        Get
            Return _Ciudad
        End Get
        Set(ByVal value As String)
            _Ciudad = value
        End Set
    End Property

    Public Property Provincia As String
        Get
            Return _Provincia
        End Get
        Set(ByVal value As String)
            _Provincia = value
        End Set
    End Property

    Public Property CodigoPostal As String
        Get
            Return _CodigoPostal
        End Get
        Set(ByVal value As String)
            _CodigoPostal = value
        End Set
    End Property

    Public Property TelFijo As String
        Get
            Return _TelFijo
        End Get
        Set(ByVal value As String)
            _TelFijo = value
        End Set
    End Property

    Public Property TelCelular As String
        Get
            Return _TelCelular
        End Get
        Set(ByVal value As String)
            _TelCelular = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(ByVal value As String)
            _Email = value
        End Set
    End Property

    Public Property Cuil As String
        Get
            Return _Cuil
        End Get
        Set(ByVal value As String)
            _Cuil = value
        End Set
    End Property

    Public Property Observaciones As String
        Get
            Return _Observaciones
        End Get
        Set(ByVal value As String)
            _Observaciones = value
        End Set
    End Property

    Public Property Nivel As String
        Get
            Return _Nivel
        End Get
        Set(ByVal value As String)
            _Nivel = value
        End Set
    End Property

End Class
