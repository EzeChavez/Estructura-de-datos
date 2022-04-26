
Public Class Cola
    Private ObjCola As New ObjCola


    Private Sub Cola_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim Nvo As New Nodo
        Nvo.Codigo = TBCodigo.Text
        Nvo.Nombre = TBNombre.Text
        Nvo.Tramite = TBtramite.Text
        ObjCola.Agregar(Nvo)
        ObjCola.Listar(ListB)
        ObjCola.Listar(Dgv1)

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If ObjCola.Primero IsNot Nothing Then
            LblCodigoEliminado.Text = ObjCola.Primero.Codigo
            LblNombreEliminado.Text = ObjCola.Primero.Nombre
            LblTramiteEliminado.Text = ObjCola.Primero.Tramite
            ObjCola.Eliminar()
            ObjCola.Listar(ListB)
            ObjCola.Listar(Dgv1)
        Else
            MessageBox.Show("No se encontraron datos")
        End If
    End Sub
End Class