Public Class Formmenu
    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Dim dtproducto As New DataTable
    Dim dtventa As New DataTable
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim Fc As New Formcategorias
        Fc.Show()
    End Sub



    Public cantp As Int32
    Public cantv As Int32
    Public cantt As Int32
    Private Sub Formmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim fp As New Fproducto
        dtproducto = fp.mostrar_producto()
        cantp = dtproducto.Rows.Count
        lblcantpro.Text = cantp

        Dim fv As New Fventa
        dtventa = fv.ver_ventas
        cantp = dtventa.Rows.Count
        lblcantv.Text = cantp

        Try
            dtventa = fv.total_ventas()

            lbltotal.Text = Convert.ToString(dtventa.Rows(0)("total"))
        Catch ex As Exception
            lbltotal.Text = "0"
        End Try

    End Sub



    Private Sub Panel17_Click(sender As Object, e As EventArgs) Handles Panel17.Click
        Dim ex = MessageBox.Show("¿Seguro que desea cerrar sesion?", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (ex = vbYes) Then
            Login1.Show()
            Me.Hide()

        Else

        End If
    End Sub

    Private Sub Panel16_Click(sender As Object, e As EventArgs) Handles Panel16.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Formmenu_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub Formmenu_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then
            Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
        End If
    End Sub






    Private Sub Panel19_Click(sender As Object, e As EventArgs) Handles Panel19.Click
        Dim fp As New Fproducto
        dtproducto = fp.mostrar_producto()
        cantp = dtproducto.Rows.Count
        lblcantpro.Text = cantp

        Dim fv As New Fventa
        dtventa = fv.ver_ventas
        cantp = dtventa.Rows.Count
        lblcantv.Text = cantp

        Try
            dtventa = fv.total_ventas()
            lbltotal.Text = Convert.ToString(dtventa.Rows(0)("total"))

            MessageBox.Show("Los datos fueron actualizados")
        Catch ex As Exception
            lbltotal.Text = "0"
        End Try


    End Sub

    Private Sub Formmenu_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub

    Private Sub VentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaToolStripMenuItem.Click
        FormVenta.Show()
    End Sub

    Private Sub listaVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaToolStripMenuItem.Click
        FormlistaVentas.Show()
    End Sub
    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        Formproducto.Show()
    End Sub



    Private Sub FormVenta_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        ' Check if the mouse is outside the form's bounds
        If Not Me.Bounds.Contains(Cursor.Position) Then
            Me.Close()
        End If
    End Sub

    Private Sub EmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem.Click
        FromEmpleado.Show()
    End Sub

    Private Sub ProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedorToolStripMenuItem.Click
        FormProveedor.Show()
    End Sub

    Private Sub AlmacenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlmacenToolStripMenuItem.Click
        FormAlmacen.Show()
    End Sub

    Private Sub TiendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiendasToolStripMenuItem.Click
        FormTiendas.Show()
    End Sub

    Private Sub ClenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClenteToolStripMenuItem.Click
        Formcliente.Show()
    End Sub

    Private Sub Panel9_Click(sender As Object, e As EventArgs) Handles Panel9.Click

    End Sub
End Class