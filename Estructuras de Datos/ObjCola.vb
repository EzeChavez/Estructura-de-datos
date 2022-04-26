
'Basicamente creo una clase donde declaro el objeto de tipo nodo y lo relaciono 
' los punteros '
Public Class ObjCola

    'Declaro los punteros'
    Private cpPrimero As Nodo
    Private cpUltimo As Nodo

    'Declaro las propiedades de los campos'
    Public Property Primero As Nodo
        Get
            Return cpPrimero
        End Get
        Set(value As Nodo)
            cpPrimero = value
        End Set
    End Property

    Public Property Ultimo
        Get
            Return cpUltimo
        End Get
        Set(value)
            cpUltimo = value
        End Set
    End Property

    Public Sub Agregar(Nvo As Nodo)
        If Primero Is Nothing Then
            Primero = Nvo
            Ultimo = Nvo
        Else
            Ultimo.siguiente = Nvo
            Ultimo = Nvo
        End If
    End Sub

    Public Sub Eliminar()
        If Primero IsNot Nothing Then
            If Primero Is Ultimo Then
                Primero = Nothing
                Ultimo = Nothing
            Else
                Primero = Primero.siguiente
            End If
        End If
    End Sub

    Public Sub Listar(Lista As ListBox)
        Dim x As Nodo = Primero
        Lista.Items.Clear()
        While x IsNot Nothing
            Lista.Items.Add(x.Nombre)
            x = x.siguiente
        End While
    End Sub

    Public Sub Listar(Grilla As DataGridView)

        Dim x As Nodo = Primero
        Grilla.Rows.Clear()
        While x IsNot Nothing
            Grilla.Rows.Add(x.Codigo, x.Nombre, x.Tramite)
            x = x.siguiente
        End While
    End Sub
End Class
