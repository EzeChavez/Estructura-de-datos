Public Class ObjPila

    'Declaro el puntero'
    Private CpPrimero As Nodo

    'Declaro las Propiedades'
    Public Property Primero As Nodo
        Get
            Return CpPrimero
        End Get
        Set(value As Nodo)
            CpPrimero = value
        End Set
    End Property

    'Defino los metodos'
    Public Sub AgregarPila(Nvos As Nodo)
        If Primero Is Nothing Then
            Primero = Nvos
        Else
            Nvos.siguiente = Primero
            Primero = Nvos

        End If
    End Sub
    Public Sub EliminarPila()
        Primero = Primero.siguiente
    End Sub

    Public Sub ListarPila(Grilla As DataGridView)
        Dim x As Nodo = Primero
        Grilla.Rows.Clear()
        While x IsNot Nothing
            Grilla.Rows.Add(x.Codigo, x.Nombre, x.Tramite)
            x = x.siguiente

        End While
    End Sub

    Public Sub ListarPila(Lista As ListBox)
        Dim x As Nodo = Primero
        Lista.Items.Clear()
        While x IsNot Nothing
            Lista.Items.Add(x.Nombre)
            x = x.siguiente
        End While
    End Sub



End Class
