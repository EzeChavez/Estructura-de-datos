'Creo una clase y declaro el objeto nodo'
'Este objeto contendra la informacion en variables'
'Y los punteros el puntero para determinar quien es el objeto siguiente'

Public Class Nodo
    'creo una clase nodo con tres campos privados'
    Private CpCodigo As Integer
    Private CpNombre As String
    Private CpTramite As String
    'Este es el puntero'
    Private CpSiguiente As Nodo


    'Declaro las propiedades de los campos'
    Public Property Codigo As Integer
        Get
            Return CpCodigo
        End Get

        Set(value As Integer)
            CpCodigo = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return CpNombre
        End Get
        Set(value As String)
            CpNombre = value
        End Set
    End Property

    Public Property Tramite As String
        Get
            Return CpTramite
        End Get
        Set(value As String)
            CpTramite = value
        End Set
    End Property

    Public Property siguiente As Nodo
        Get
            Return CpSiguiente
        End Get
        Set(value As Nodo)
            CpSiguiente = value
        End Set
    End Property

End Class
