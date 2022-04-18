Public Class Form1
    Private Sub DatosDelDesarrolladorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosDelDesarrolladorToolStripMenuItem.Click
        Desarrolladorvb.Show()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub ListaEnlazadaSimpleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaEnlazadaSimpleToolStripMenuItem.Click
        ListaEnlazadaSimple.Show()

    End Sub

    Private Sub ColaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColaToolStripMenuItem.Click
        Cola.Show()

    End Sub

    Private Sub PilaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PilaToolStripMenuItem.Click
        Pilavb.Show()

    End Sub

    Private Sub ListaDoblementeEnlazadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDoblementeEnlazadaToolStripMenuItem.Click
        ListaDoblementeEnlazada.Show()

    End Sub

    Private Sub ArbolBinarioDeBusquedaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArbolBinarioDeBusquedaToolStripMenuItem.Click
        Arbol_binario_de_busqueda.Show()

    End Sub

    Private Sub GrafoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrafoToolStripMenuItem.Click
        Grafo.Show()

    End Sub
End Class
