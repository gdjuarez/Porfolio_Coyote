Public Class ClassCuentaCorriente
    'idpagocc, idcliente, fecha, debe, haber, saldo
    Private _IdCliente As Integer
    Private _Fecha As Date
    Private _Debe As Double
    Private _Haber As Double
    Private _Saldo As Double


    Public Property IdCliente As Integer
        Get
            Return _IdCliente
        End Get
        Set(ByVal value As Integer)
            _IdCliente = value
        End Set
    End Property


    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
        End Set
    End Property

    Public Property Debe As Double
        Get
            Return _Debe
        End Get
        Set(ByVal value As Double)
            _Debe = value
        End Set
    End Property

    Public Property Haber As Double
        Get
            Return _Haber
        End Get
        Set(ByVal value As Double)
            _Haber = value
        End Set
    End Property

    Public Property Saldo As Double
        Get
            Return _Saldo
        End Get
        Set(ByVal value As Double)
            _Saldo = value
        End Set
    End Property

End Class
