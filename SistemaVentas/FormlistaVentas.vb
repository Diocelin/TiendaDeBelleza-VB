Public Class FormlistaVentas
    Dim dtventas As New DataTable
    Private Sub FormlistaVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ver_ventas()
    End Sub

    Sub ver_ventas()
        Dim fv As New Fventa
        dtventas = fv.ver_ventas()
        Dgventas.DataSource = dtventas
    End Sub

    Sub buscar_ventas()
        Dim fv As New Fventa
        dtventas = fv.buscar_venta(txtbsucar.Text)
        Dgventas.DataSource = dtventas
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        buscar_ventas()
    End Sub
End Class