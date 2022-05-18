Public Class ObjArbol
    'Creo  los punteros'
    Private CpRaiz As Nodo
    Dim i As Integer


    'Declaro la propiedad'
    Public Property Raiz As Nodo
        Get
            Return CpRaiz
        End Get
        Set(value As Nodo)
            CpRaiz = value
        End Set
    End Property

    Public Sub AgregarNodoArbol(Codigo As Integer, Nombre As String, Tramite As String)
        If Raiz Is Nothing Then
            Raiz = New Nodo
            Raiz.Codigo = Codigo
            Raiz.Nombre = Nombre
            Raiz.Tramite = Tramite
            Return

        Else
            Dim NodoPadre As Nodo = Raiz
            Dim Aux As Nodo = Raiz
            While Aux IsNot Nothing
                NodoPadre = Aux
                If Codigo < Aux.Codigo Then
                    Aux = Aux.Izquierdo
                Else
                    Aux = Aux.Derecho
                End If
            End While

            If Codigo < NodoPadre.Codigo Then
                NodoPadre.Izquierdo = New Nodo
                NodoPadre.Izquierdo.Codigo = Codigo
                NodoPadre.Izquierdo.Nombre = Nombre
                NodoPadre.Izquierdo.Tramite = Tramite

            Else
                NodoPadre.Derecho = New Nodo
                NodoPadre.Derecho.Codigo = Codigo
                NodoPadre.Derecho.Nombre = Nombre
                NodoPadre.Derecho.Tramite = Tramite
            End If


        End If

    End Sub

    Public Sub ListarArbol(Lista As ListBox)
        Lista.Items.Clear()

        InOrden(Lista, Raiz)
    End Sub

    Private Sub InOrden(Lista As ListBox, NodoPadre As Nodo)
        If NodoPadre.Izquierdo IsNot Nothing Then
            Return
        End If
        If NodoPadre IsNot Nothing Then
            Lista.Items.Add(NodoPadre.Codigo)
        End If

        Lista.Items.Add(NodoPadre.Codigo)

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
        If Raiz Is Nothing Then
            Return
        End If
        i = 0
        Dim Vector(100) As Nodo
        GrabarVectorInOrden(Raiz, i, Vector)

        Raiz = Nothing
        EquilibrarArbol(0, i - 1, Vector)

    End Sub

    Public Sub GrabarVectorInOrden(NodoPadre As Nodo, ByRef i As Integer, ByRef Vector As Nodo())
        If NodoPadre.Izquierdo IsNot Nothing Then
            GrabarVectorInOrden(NodoPadre.Izquierdo, i, Vector)
        End If
        Vector(i) = NodoPadre
        i += 1

        If NodoPadre.Derecho IsNot Nothing Then
            GrabarVectorInOrden(NodoPadre.Derecho, i, Vector)
        End If
    End Sub

    Private Sub EquilibrarArbol(ini As Integer, fin As Integer, ByRef vector As Nodo())
        Dim m As Integer = (ini + fin) / 2

        If ini <= fin Then
            AgregarNodoArbol(vector(m).Codigo, vector(m).Nombre, vector(m).Tramite)
            EquilibrarArbol(ini, m - 1, vector)
            EquilibrarArbol(m + 1, fin, vector)

        End If
    End Sub

    Public Sub EliminarNodoArbol(codigo As Integer)
        i = 0
        Dim vector(100) As Nodo

        GrabarVector(Raiz, codigo, i, vector)
        Raiz = Nothing
        EquilibrarArbol(0, i - 1, vector)
    End Sub

    Private Sub GrabarVector(NodoPadre As Nodo, Codigo As Integer, ByRef i As Integer, ByRef vector As Nodo())
        If NodoPadre.Izquierdo IsNot Nothing Then
            GrabarVector(NodoPadre.Izquierdo, Codigo, i, vector)
        End If

        If NodoPadre.Codigo <> Codigo Then
            vector(i) = NodoPadre
            i += 1
        End If

        If NodoPadre.Derecho IsNot Nothing Then
            GrabarVector(NodoPadre.Derecho, Codigo, i, vector)
        End If
    End Sub

End Class
