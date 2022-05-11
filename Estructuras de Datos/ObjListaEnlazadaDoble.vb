Public Class ObjListaEnlazadaDoble
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
    'Declaro el ultimo puntero'
    Private Cpultimo As Nodo

    'Declaro las propiedades'

    Public Property ultimo As Nodo
        Get
            Return Cpultimo
        End Get
        Set(value As Nodo)
            Cpultimo = value

        End Set
    End Property


    Public Sub Agregar(Nvo As Nodo)
        If Primero Is Nothing And Ultimo Is Nothing Then
            primero = Nvo
            ultimo = Nvo
        Else
            If Nvo.Codigo < primero.Codigo Then
                Nvo.siguiente = primero
                primero.Anterior = Nvo
                primero = Nvo
            Else
                If Nvo.Codigo > ultimo.Codigo Then
                    ultimo.siguiente = Nvo
                    Nvo.Anterior = ultimo
                    ultimo = Nvo
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
                    Nvo.Anterior = aux
                    Nvo.siguiente = Nvo
                    aux.siguiente = Nvo
                    Nvo.siguiente.Anterior = Nvo
                End If

            End If

        End If
    End Sub

    Public Sub Eliminar(Codigo As Integer)
        If primero.Codigo = Codigo And ultimo Is primero Then
            primero = Nothing
            ultimo = Nothing
        Else
            If primero.Codigo = Codigo Then
                primero = primero.siguiente
                primero.Anterior = Nothing
            Else
                If ultimo.Codigo = Codigo Then
                    ultimo = ultimo.Anterior
                    ultimo.siguiente = Nothing
                Else
                    Dim aux = primero
                    While (aux.siguiente.Codigo < Codigo)
                        aux = aux.siguiente
                    End While
                    aux.siguiente = aux.siguiente.siguiente
                    aux.siguiente.Anterior = aux

                End If
            End If
        End If
    End Sub

    Public Sub Listar_Grilla_Descendente(Grilla As DataGridView)
        Dim x As Nodo = ultimo
        Grilla.Rows.Clear()
        While x IsNot Nothing
            Grilla.Rows.Add(x.Codigo, x.Nombre, x.Tramite)
            x = x.Anterior
        End While

    End Sub

    Public Sub Listar_Grilla_Asc(Grilla As DataGridView, cod As Decimal)
        Dim x As Nodo = primero

        Grilla.Rows.Clear()
        While x IsNot Nothing
            If x.Codigo > cod Then
                Grilla.Rows.Add(x.Codigo, x.Nombre, x.Tramite)
            End If
            x = x.siguiente
        End While

    End Sub

    Public Sub Listar_Lista_Descendente(Lista As ListBox, cod As Decimal)
        Dim x As Nodo = primero
        Lista.Items.Clear()
        While x IsNot Nothing
            If x.Codigo > cod Then
                Lista.Items.Add(x.Nombre)
            End If
            x = x.siguiente
        End While

    End Sub

    Public Sub Listar_Lista_Asc(Lista As ListBox)
        Dim x As Nodo = primero

        Lista.Items.Clear()
        While x IsNot Nothing

            Lista.Items.Add(x.Nombre)

            x = x.siguiente
        End While

    End Sub
End Class
