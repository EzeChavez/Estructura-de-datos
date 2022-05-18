Public Class Arbol_binario_de_busqueda
    'Instancio el objeto'
    Private ObjArbol As New ObjArbol

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim Nvos As New Nodo
        Nvos.Codigo = TBCodigo.Text
        Nvos.Nombre = TBNombre.Text
        Nvos.Tramite = TBtramite.Text
        ObjArbol.AgregarNodoArbol(TBCodigo.Text, TBNombre.Text, TBtramite.Text)
        ObjArbol.ListarArbolGrilla(Dgv1)
    End Sub

    Private Sub BtnEquilibrar_Click(sender As Object, e As EventArgs) Handles BtnEquilibrar.Click
        ObjArbol.Equilibrar()
        ObjArbol.ListarArbolGrilla(Dgv1)
        MessageBox.Show("Arbol Equilibrado", "Exito")

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ObjArbol.EliminarNodoArbol(TBCodigoEliminado.Text)
        ObjArbol.ListarArbolGrilla(Dgv1)
    End Sub
End Class