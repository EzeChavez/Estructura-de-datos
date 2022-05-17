Public Class Arbol_binario_de_busqueda
    'Instancio el objeto'
    Private ObjArbol As New ObjArbol

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim Nvos As New Nodo
        Nvos.Codigo = TBCodigo.Text
        Nvos.Nombre = TBNombre.Text
        Nvos.Tramite = TBtramite.Text
        ObjArbol.AgregarNodoArbol(Nvos)
        ObjArbol.ListarArbol(ListB)
        ObjArbol.ListarArbolGrilla(Dgv1)
    End Sub

    Private Sub BtnEquilibrar_Click(sender As Object, e As EventArgs) Handles BtnEquilibrar.Click
        ObjArbol.Equilibrar()
        ''ObjArbol.ListarArbol(ListB)
        ''ObjArbol.ListarArbolGrilla(Dgv1)

    End Sub
End Class