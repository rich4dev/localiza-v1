Public Class Envios


    Private _IdEnvio As String

    Public Property IdEnvio() As String
        Get
            Return _IdEnvio
        End Get
        Private Set(ByVal value As String)
            _IdEnvio = value
        End Set
    End Property

    Private _IdCliente As String

    Public Property IdCliente() As String
        Get
            Return _IdCliente
        End Get
        Private Set(ByVal value As String)
            _IdCliente = value
        End Set
    End Property


    Private _Cantidad As String

    Public Property Cantidad() As String
        Get
            Return _Cantidad
        End Get
        Private Set(ByVal value As String)
            _Cantidad = value
        End Set
    End Property


    Private _Peso As String

    Public Property Peso() As String
        Get
            Return _Peso
        End Get
        Private Set(ByVal value As String)
            _Peso = value
        End Set
    End Property


    Private _DestinoInicio As String

    Public Property DestinoInicio() As String
        Get
            Return _DestinoInicio
        End Get
        Private Set(ByVal value As String)
            _DestinoInicio = value
        End Set
    End Property


    Private _DestinoFin As String

    Public Property DestinoFin() As String
        Get
            Return _DestinoFin
        End Get
        Private Set(ByVal value As String)
            _DestinoFin = value
        End Set
    End Property


    Private _IdTransporte As String

    Public Property IdTransporte() As String
        Get
            Return _IdTransporte
        End Get
        Private Set(ByVal value As String)
            _IdTransporte = value
        End Set
    End Property


    Private _Estado As String

    Public Property Estado() As String
        Get
            Return _Estado
        End Get
        Private Set(ByVal value As String)
            _Estado = value
        End Set
    End Property


End Class
