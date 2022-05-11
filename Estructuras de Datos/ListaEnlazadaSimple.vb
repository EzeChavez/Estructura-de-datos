Public Class ListaEnlazadaSimple
    Private ObjListaEnlazadaSimple As New ObjListaEnlazadaSimple

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim Nvos As New Nodo
        Nvos.Codigo = TBCodigo.Text
        Nvos.Nombre = TBNombre.Text
        Nvos.Tramite = TBtramite.Text
        ObjListaEnlazadaSimple.AgregarAlistaEnlazadaSimple(Nvos)
        ObjListaEnlazadaSimple.ListarListaEnlazadaSimpleGRILLA(Dgv1)
        ObjListaEnlazadaSimple.ListarListaEnlazadaSimpleLISTA(ListB)
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If TBCodigoEliminado.text = 0 Or TBCodigoEliminado.text = 1 Or TBCodigoEliminado.text = 2 Or TBCodigoEliminado.text = 3 Or TBCodigoEliminado.text = 4 Or TBCodigoEliminado.text = 5 Or TBCodigoEliminado.text = 6 Or TBCodigoEliminado.text = 7 Or TBCodigoEliminado.text = 8 Or TBCodigoEliminado.text = 9 Or TBCodigoEliminado.text = 10 Then
            ObjListaEnlazadaSimple.EliminarNodo(TBCodigo.Text)
            ObjListaEnlazadaSimple.ListarListaEnlazadaSimpleGRILLA(Dgv1)
            ObjListaEnlazadaSimple.ListarListaEnlazadaSimpleLISTA(ListB)
        Else
            MessageBox.Show("Debe ingresar un codigo del 1 al 10", "ADVERTENCIA")

        End If

    End Sub
End Class