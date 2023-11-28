Public Class FormProveedor
    Dim dtProveedor As New DataTable
    Private Sub FormProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        limpiar()
        btnguardar.Enabled = False
        btncancelar.Enabled = False
        btneliminar.Enabled = False
        btnmodificar.Enabled = False
        mostrar_proveedor()
    End Sub
    Sub buscar_proveedor()
        Dim fc As New FProveedor
        dtProveedor = fc.buscar_proveedor(txtbuscar.Text)
        dgvproveedor.DataSource = dtProveedor
    End Sub
    Sub mostrar_proveedor()
        Dim fc As New FProveedor
        dtProveedor = fc.mostrar_proveedor()
        dgvproveedor.DataSource = dtProveedor
    End Sub
    Sub nuevo()
        btncancelar.Enabled = True
        btnguardar.Enabled = True
        limpiar()
        bloqueacajas(True)
    End Sub
    Sub limpiar()
        txtcodigo.Clear()
        txtnombreE.Clear()
        txtnombre.Clear()
        txttelefono.Clear()
        txtestado.Clear()
        txtcrea.Clear()
        txtmodifica.Clear()
    End Sub
    Sub cancelar()
        btnnuevo.Enabled = True
        btnguardar.Enabled = False
        btneliminar.Enabled = False
        btncancelar.Enabled = False
        btnmodificar.Enabled = False
        limpiar()
        bloqueacajas(False)
    End Sub

    Sub bloqueacajas(va As Boolean)
        txtnombreE.Enabled = va
        txtnombre.Enabled = va
        txttelefono.Enabled = va
        txtestado.Enabled = va
        txtcrea.Enabled = va
        txtmodifica.Enabled = va
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        btnguardar.Enabled = True
        btneliminar.Enabled = False
        bloqueacajas(True)
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        nuevo()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        cancelar()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim fc As New FProveedor
        If (txtnombreE.Text <> String.Empty And txtnombre.Text <> String.Empty And txtcrea.Text <> String.Empty And txtestado.Text <> String.Empty And txtmodifica.Text <> String.Empty) Then

            If (txtcodigo.Text <> String.Empty) Then
                If (fc.edita_proveedor(txtcodigo.Text, txtnombreE.Text, txtnombre.Text, txtestado.Text, txtcrea.Text, txtmodifica.Text, txttelefono.Text) = True) Then
                    MessageBox.Show("Proveedor editado Correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cancelar()
                    mostrar_proveedor()
                Else
                    MessageBox.Show("Error al Modificar el proveedor")
                End If
            Else


                If (fc.ingresa_proveedor(txtcodigo.Text, txtnombreE.Text, txtnombre.Text, txtcrea.Text, txtestado.Text, txtmodifica.Text, txttelefono.Text) = True) Then
                    MessageBox.Show("Proveedor registrado Correctamente", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cancelar()
                    mostrar_proveedor()
                Else
                    MessageBox.Show("Error al registrar el proveedor")
                End If
            End If

        Else
            MessageBox.Show("Complete todos los datos")
        End If
    End Sub

    Private Sub dgvproveedor_DoubleClick(sender As Object, e As EventArgs) Handles dgvproveedor.DoubleClick
        txtcodigo.Text = dgvproveedor.CurrentRow.Cells("cod_proveedor").Value
        txtnombreE.Text = dgvproveedor.CurrentRow.Cells("nombre_empresa").Value
        txtnombre.Text = dgvproveedor.CurrentRow.Cells("contacto_nombre").Value
        txttelefono.Text = dgvproveedor.CurrentRow.Cells("contacto_telefono").Value
        txtestado.Text = dgvproveedor.CurrentRow.Cells("estado").Value
        txtmodifica.Text = dgvproveedor.CurrentRow.Cells("modificado_por").Value
        txtcrea.Text = dgvproveedor.CurrentRow.Cells("creado_por").Value


        btnguardar.Enabled = False
        btnmodificar.Enabled = True
        btneliminar.Enabled = True
        btncancelar.Enabled = True
        btnnuevo.Enabled = True
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim c As New FProveedor
        If (c.elimina_proveedor(txtcodigo.Text) = True) Then
            MessageBox.Show("Proveedor Eliminadaa Correctamente", "Elimacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cancelar()
            mostrar_proveedor()
        Else
            MessageBox.Show("Error al eliminar el Proveedor")
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        buscar_proveedor()
    End Sub

    Private Sub txttelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefono.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombreE.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub txtapellidos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        mostrar_proveedor()
        txtbuscar.Clear()
    End Sub

    Private Sub txtbuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbuscar.KeyPress
        SoloLetras(e)
    End Sub
    Private Sub FormVenta_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        ' Check if the mouse is outside the form's bounds
        If Not Me.Bounds.Contains(Cursor.Position) Then
            Me.Close()
        End If
    End Sub

End Class