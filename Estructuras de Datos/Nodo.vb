'Creo una clase y declaro el objeto nodo'
'Este objeto contendra la informacion en variables'
'Y los punteros el puntero para determinar quien es el objeto siguiente'

Public Class Nodo
    'creo una clase nodo con tres campos privados'
    Private CpCodigo As Integer
    Private CpNombre As String
    Private CpTramite As String
    'Este es el puntero siguiente'
    Private CpSiguiente As Nodo

    'Este es el puntero para la lista doblemente enlazada'
    Private CpAnterior As Nodo

    'Declaro el puntero al primer elemento de la lista'
    Private CpPrimero As Nodo

    'Declaro los punteros para el Arbol "Similares a los punteros Anterior y Sieguiente en la lista enlazada"'
    Private CpIzquierdo As Nodo
    Private CpDerecho As Nodo



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

    Public Property Anterior As Nodo
        Get
            Return CpAnterior

        End Get
        Set(value As Nodo)
            CpAnterior = value
        End Set
    End Property


    'Declaro las propiedades'

    Public Property primero As Nodo
        Get
            Return CpPrimero
        End Get
        Set(value As Nodo)
            CpPrimero = value

        End Set
    End Property

    Public Property Izquierdo As Nodo
        Get
            Return CpIzquierdo
        End Get
        Set(value As Nodo)
            CpIzquierdo = value

        End Set
    End Property

    Public Property Derecho As Nodo
        Get
            Return CpDerecho
        End Get
        Set(value As Nodo)
            CpDerecho = value

        End Set
    End Property
End Class
