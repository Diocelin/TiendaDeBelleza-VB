Public Class FormAlmacen
    Dim dtAlmacen As New DataTable
    Private Sub FormAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        btnguardar.Enabled = False
        btncancelar.Enabled = False
        btneliminar.Enabled = False
        btnmodificar.Enabled = False
        mostrar_almacen()
    End Sub
    Sub buscar_almacen()
        Dim fc As New FAlmacen
        dtAlmacen = fc.buscar_almacen(txtbuscar.Text)
        dgvAlmacen.DataSource = dtAlmacen
    End Sub
    Sub mostrar_almacen()
        Dim fc As New FAlmacen
        dtAlmacen = fc.mostrar_almacen()
        dgvAlmacen.DataSource = dtAlmacen
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
        txtcapacidad.Clear()
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
        txtcapacidad.Enabled = va
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
        Dim fc As New FAlmacen
        If (txtnombre.Text <> String.Empty And txtdireccion.Text <> String.Empty And txtcapacidad.Text <> String.Empty And txtcrea.Text <> String.Empty And txtestado.Text <> String.Empty And txtmodifica.Text <> String.Empty) Then

            If (txtcodigo.Text <> String.Empty) Then
                If (fc.edita_almacen(txtcodigo.Text, txtnombre.Text, txtcrea.Text, txtestado.Text, txtmodifica.Text, txtdireccion.Text, txtcapacidad.Text) = True) Then
                    MessageBox.Show("Almacen editado Correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cancelar()
                    mostrar_almacen()
                Else
                    MessageBox.Show("Error al Modificar el almacen")
                End If
            Else


                If (fc.ingresa_almacen(txtcodigo.Text, txtnombre.Text, txtcrea.Text, txtestado.Text, txtmodifica.Text, txtdireccion.Text, txtcapacidad.Text) = True) Then
                    MessageBox.Show("almacen registrado Correctamente", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cancelar()
                    mostrar_almacen()
                Else
                    MessageBox.Show("Error al registrar el almacen")
                End If
            End If

        Else
            MessageBox.Show("Complete todos los datos")
        End If
    End Sub

    Private Sub dgvAlmacen_DoubleClick(sender As Object, e As EventArgs) Handles dgvAlmacen.DoubleClick
        txtcodigo.Text = dgvAlmacen.CurrentRow.Cells("cod_almacen").Value
        txtnombre.Text = dgvAlmacen.CurrentRow.Cells("nombre_almacen").Value
        txtdireccion.Text = dgvAlmacen.CurrentRow.Cells("direccion_almacen").Value
        txtcapacidad.Text = dgvAlmacen.CurrentRow.Cells("capacidad").Value
        txtestado.Text = dgvAlmacen.CurrentRow.Cells("estado").Value
        txtmodifica.Text = dgvAlmacen.CurrentRow.Cells("modificado_por").Value
        txtcrea.Text = dgvAlmacen.CurrentRow.Cells("creado_por").Value


        btnguardar.Enabled = False
        btnmodificar.Enabled = True
        btneliminar.Enabled = True
        btncancelar.Enabled = True
        btnnuevo.Enabled = True
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim c As New FAlmacen
        If (c.elimina_almacen(txtcodigo.Text) = True) Then
            MessageBox.Show("Almacen Eliminadaa Correctamente", "Elimacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cancelar()
            mostrar_almacen()
        Else
            MessageBox.Show("Error al eliminar el almacen")
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        buscar_almacen()
    End Sub



    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        SoloLetras(e)
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs)
        mostrar_almacen()
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