Public Class ObjArbol
    'Creo  los punteros'
    Private CpRaiz As Nodo
    Dim i As Integer
    Public Vector(45) As Nodo

    'Declaro la propiedad'
    Public Property Raiz As Nodo
        Get
            Return CpRaiz
        End Get
        Set(value As Nodo)
            CpRaiz = value
        End Set
    End Property

    Public Sub AgregarNodoArbol(Nvo As Nodo)
        If Raiz Is Nothing Then
            Raiz = Nvo

        Else
            Dim NodoPadre As Nodo = Raiz
            Dim Aux As Nodo = Raiz
            While Aux IsNot Nothing
                NodoPadre = Aux
                If Nvo.Codigo < Aux.Codigo Then
                    Aux = Aux.Izquierdo
                Else
                    Aux = Aux.Derecho
                End If
            End While

            If Nvo.Codigo < NodoPadre.Codigo Then
                NodoPadre.Izquierdo = Nvo
            Else
                NodoPadre.Derecho = Nvo
            End If


        End If

    End Sub

    Public Sub ListarArbol(Lista As ListBox)
        Lista.Items.Clear()
        InOrden(Lista, Raiz)
    End Sub

    Private Sub InOrden(Lista As ListBox, NodoPadre As Nodo)
        If NodoPadre.Izquierdo IsNot Nothing Then
            InOrden(Lista, NodoPadre.Izquierdo)
        End If
        If NodoPadre IsNot Nothing Then
            Lista.Items.Add(NodoPadre.Codigo)
        End If


        If NodoPadre.Derecho IsNot Nothing Then
            InOrden(Lista, NodoPadre.Derecho)

        End If
    End Sub

    Public Sub ListarArbolGrilla(DGV As DataGridView)
        DGV.Rows.Clear()
        InOrdenDGV(DGV, Raiz)
    End Sub

    Public Sub InOrdenDGV(DGV As DataGridView, NodoPadre As Nodo)
        If NodoPadre.Izquierdo IsNot Nothing Then
            InOrdenDGV(DGV, NodoPadre.Izquierdo)

        End If

        DGV.Rows.Add(NodoPadre.Codigo, NodoPadre.Nombre, NodoPadre.Tramite)

        If NodoPadre.Derecho IsNot Nothing Then
            InOrdenDGV(DGV, NodoPadre.Derecho)

        End If
    End Sub

    Public Sub Equilibrar()
        i = 0
        GrabarVectorInOrden(Raiz)
        Raiz = Nothing
        EquilibrarArbol(0, i - 1)
    End Sub

    Public Sub GrabarVectorInOrden(NodoPadre As Nodo)
        If NodoPadre.Izquierdo IsNot Nothing Then
            GrabarVectorInOrden(NodoPadre.Izquierdo)
        End If
        Vector(i) = NodoPadre
        i += 1

        If NodoPadre.Derecho IsNot Nothing Then
            GrabarVectorInOrden(NodoPadre.Derecho)
        End If
    End Sub

    Private Sub EquilibrarArbol(ini As Integer, fin As Integer)
        Dim m As Integer = (ini + fin) / 2
        If ini <= fin Then
            AgregarNodoArbol(Vector(m))
            EquilibrarArbol(ini, m - 1)
            EquilibrarArbol(m + 1, fin)

        End If
    End Sub


End Class
