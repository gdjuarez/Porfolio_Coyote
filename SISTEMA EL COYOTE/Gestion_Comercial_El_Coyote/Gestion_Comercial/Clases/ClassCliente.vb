﻿Public Class ClassCliente
    'idCliente, Nombre, Apellido, RazonSocial, Domicilio, Ciudad, Provincia, CodigoPostal, TelFijo, TelCelular, Email, Cuil, Observaciones
    Private _idCliente As String
    Private _Nombre As String
    Private _Apellido As String
    Private _RazonSocial As String
    Private _Domicilio As String
    Private _Ciudad As String
    Private _Provincia As String
    Private _CodigoPostal As String
    Private _TelFijo As String
    Private _TelCelular As String
    Private _Email As String
    Private _Cuil As String
    Private _Observaciones As String

    Public Property IdCliente As String
        Get
            Return _idCliente
        End Get
        Set(value As String)
            _idCliente = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return _Apellido
        End Get
        Set(value As String)
            _Apellido = value
        End Set
    End Property

    Public Property RazonSocial As String
        Get
            Return _RazonSocial
        End Get
        Set(value As String)
            _RazonSocial = value
        End Set
    End Property

    Public Property Domicilio As String
        Get
            Return _Domicilio
        End Get
        Set(value As String)
            _Domicilio = value
        End Set
    End Property

    Public Property Ciudad As String
        Get
            Return _Ciudad
        End Get
        Set(value As String)
            _Ciudad = value
        End Set
    End Property

    Public Property Provincia As String
        Get
            Return _Provincia
        End Get
        Set(value As String)
            _Provincia = value
        End Set
    End Property

    Public Property CodigoPostal As String
        Get
            Return _CodigoPostal
        End Get
        Set(value As String)
            _CodigoPostal = value
        End Set
    End Property

    Public Property TelFijo As String
        Get
            Return _TelFijo
        End Get
        Set(value As String)
            _TelFijo = value
        End Set
    End Property

    Public Property TelCelular As String
        Get
            Return _TelCelular
        End Get
        Set(value As String)
            _TelCelular = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property

    Public Property Cuil As String
        Get
            Return _Cuil
        End Get
        Set(value As String)
            _Cuil = value
        End Set
    End Property

    Public Property Observaciones As String
        Get
            Return _Observaciones
        End Get
        Set(value As String)
            _Observaciones = value
        End Set
    End Property
End Class
