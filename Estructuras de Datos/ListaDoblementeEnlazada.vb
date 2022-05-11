Public Class ListaDoblementeEnlazada
    Private ObjListaEnlazadaDoble As New ObjListaEnlazadaDoble

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim Nvos As New Nodo
        Nvos.Codigo = TBCodigo.Text
        Nvos.Nombre = TBNombre.Text
        Nvos.Tramite = TBtramite.Text
        ObjListaEnlazadaDoble.Agregar(Nvos)
        ObjListaEnlazadaDoble.Listar_Grilla_Descendente(Dgv1)
        ObjListaEnlazadaDoble.Listar_Lista_Asc(ListB)



    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ObjListaEnlazadaDoble.Eliminar(TBCodigoEliminado.Text)
        ObjListaEnlazadaDoble.Listar_Grilla_Descendente(Dgv1)
        ObjListaEnlazadaDoble.Listar_Lista_Asc(ListB)
    End Sub
End Class