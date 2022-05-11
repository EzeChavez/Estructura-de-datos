Public Class Pilavb
    Private ObjPila As New ObjPila
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim Nvos As New Nodo
        Nvos.Codigo = TBCodigo.Text
        Nvos.Nombre = TBNombre.Text
        Nvos.Tramite = TBtramite.Text
        ObjPila.AgregarPila(Nvos)
        ObjPila.ListarPila(ListB)
        ObjPila.ListarPila(Dgv1)

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ObjPila.EliminarPila()
        ObjPila.ListarPila(ListB)
        ObjPila.ListarPila(Dgv1)
    End Sub
End Class