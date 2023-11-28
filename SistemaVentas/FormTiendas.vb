Public Class FormTiendas
    Dim dttienda As New DataTable
    Private Sub FormTiendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        btnguardar.Enabled = False
        btncancelar.Enabled = False
        btneliminar.Enabled = False
        btnmodificar.Enabled = False
        mostrar_tienda()
    End Sub
    Sub buscar_tienda()
        Dim fc As New FTienda
        dttienda = fc.buscar_tienda(txtbuscar.Text)
        dgvtienda.DataSource = dttienda
    End Sub
    Sub mostrar_tienda()
        Dim fc As New FTienda
        dttienda = fc.mostrar_tienda()
        dgvtienda.DataSource = dttienda
    End Sub
    Sub nuevo()
        btncancelar.Enabled = True
        btnguardar.Enabled = True
        limpiar()
        bloqueacajas(True)
    End Sub
    Sub limpiar()
        txtcodigo.Clear()
        txtnombre.Clear()
        txttelefono.Clear()
        txtdireccion.Clear()
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
        txtnombre.Enabled = va
        txttelefono.Enabled = va
        txtdireccion.Enabled = va
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
        Dim fc As New FTienda
        If (txtnombre.Text <> String.Empty And txttelefono.Text <> String.Empty And txtcrea.Text <> String.Empty And txtestado.Text <> String.Empty And txtmodifica.Text <> String.Empty) Then

            If (txtcodigo.Text <> String.Empty) Then
                If (fc.edita_tienda(txtcodigo.Text, txtnombre.Text, txttelefono.Text, txtestado.Text, txtcrea.Text, txtmodifica.Text, txtdireccion.Text) = True) Then
                    MessageBox.Show("Tiendas editado Correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cancelar()
                    mostrar_tienda()
                Else
                    MessageBox.Show("Error al Modificar el tienda")
                End If
            Else


                If (fc.ingresa_tienda(txtcodigo.Text, txtnombre.Text, txttelefono.Text, txtcrea.Text, txtestado.Text, txtmodifica.Text, txtdireccion.Text) = True) Then
                    MessageBox.Show("Tienda registrado Correctamente", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cancelar()
                    mostrar_tienda()
                Else
                    MessageBox.Show("Error al registrar el tienda")
                End If
            End If

        Else
            MessageBox.Show("Complete todos los datos")
        End If
    End Sub

    Private Sub dgvtienda_DoubleClick(sender As Object, e As EventArgs) Handles dgvtienda.DoubleClick
        txtcodigo.Text = dgvtienda.CurrentRow.Cells("cod_cadena").Value
        txtnombre.Text = dgvtienda.CurrentRow.Cells("nombre_cadena").Value
        txttelefono.Text = dgvtienda.CurrentRow.Cells("direccion_principal").Value
        txtdireccion.Text = dgvtienda.CurrentRow.Cells("telefono_principal").Value
        txtestado.Text = dgvtienda.CurrentRow.Cells("estado").Value
        txtmodifica.Text = dgvtienda.CurrentRow.Cells("modificado_por").Value
        txtcrea.Text = dgvtienda.CurrentRow.Cells("creado_por").Value


        btnguardar.Enabled = False
        btnmodificar.Enabled = True
        btneliminar.Enabled = True
        btncancelar.Enabled = True
        btnnuevo.Enabled = True
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim c As New FTienda
        If (c.elimina_Tiendas(txtcodigo.Text) = True) Then
            MessageBox.Show("Tienda Eliminadaa Correctamente", "Elimacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cancelar()
            mostrar_tienda()
        Else
            MessageBox.Show("Error al eliminar el tienda")
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        buscar_tienda()
    End Sub

    Private Sub txttelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefono.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        SoloLetras(e)
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs)
        mostrar_tienda()
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