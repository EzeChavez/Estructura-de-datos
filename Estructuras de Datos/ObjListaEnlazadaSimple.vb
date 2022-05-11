Public Class ObjListaEnlazadaSimple
    'Declaro el puntero'
    Private CpPrimero As Nodo

    'Declaro las propiedades'

    Public Property primero As Nodo
        Get
            Return CpPrimero
        End Get
        Set(value As Nodo)
            CpPrimero = value

        End Set
    End Property

    'Defino los metodos'

    Public Sub AgregarAlistaEnlazadaSimple(Nvo As Nodo)

        If primero Is Nothing Then
            primero = Nvo
        Else
            If Nvo.Codigo < primero.Codigo Then
                Nvo.siguiente = primero
                primero = Nvo
            Else
                Dim aux = primero
                If (aux.siguiente IsNot Nothing) Then
                    While (aux.siguiente.Codigo < Nvo.Codigo)
                        aux = aux.siguiente
                        If (aux.siguiente Is Nothing) Then
                            Exit While
                        End If
                    End While
                End If
                Nvo.siguiente = aux.siguiente
                aux.siguiente = Nvo
            End If
        End If

    End Sub

    Public Sub ListarListaEnlazadaSimpleGRILLA(Grilla As DataGridView)
        Dim x As Nodo = primero
        Grilla.Rows.Clear()
        While x IsNot Nothing
            Grilla.Rows.Add(x.Codigo, x.Nombre, x.Tramite)
            x = x.siguiente

        End While
    End Sub

    Public Sub ListarListaEnlazadaSimpleLISTA(Lista As ListBox)
        Dim x As Nodo = primero
        Lista.Items.Clear()
        While x IsNot Nothing
            Lista.Items.Add(x.Nombre)
            x = x.siguiente
        End While
    End Sub
    Public Sub EliminarNodo(Codigo As Integer)
        If primero.Codigo = Codigo Then
            primero = primero.siguiente
        Else
            Dim aux = primero
            If (aux.siguiente IsNot Nothing) Then
                While (aux.siguiente.Codigo < Codigo)
                    aux = aux.siguiente
                    If (aux.siguiente Is Nothing) Then
                        Exit While
                    End If
                End While
            End If
            aux.siguiente = aux.siguiente.siguiente

        End If

    End Sub
End Class
