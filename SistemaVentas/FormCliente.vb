
Public Class Formcliente
    Dim dtcliente As New DataTable
    Private Sub Formcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        btnguardar.Enabled = False
        btncancelar.Enabled = False
        btneliminar.Enabled = False
        btnmodificar.Enabled = False
        mostrar_clientes()
    End Sub
    Sub buscar_cliente()
        Dim fc As New Fcliente
        dtcliente = fc.buscar_cliente(txtbuscar.Text)
        dgvcliente.DataSource = dtcliente
    End Sub
    Sub mostrar_clientes()
        Dim fc As New Fcliente
        dtcliente = fc.mostrar_cliente()
        dgvcliente.DataSource = dtcliente
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
        txtapellidos.Clear()
        txtdireccion.Clear()
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
        txtnombre.Enabled = va
        txtapellidos.Enabled = va
        txtdireccion.Enabled = va
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
        Dim fc As New Fcliente
        If (txtnombre.Text <> String.Empty And txtapellidos.Text <> String.Empty And txtcrea.Text <> String.Empty And txtestado.Text <> String.Empty And txtmodifica.Text <> String.Empty) Then

            If (txtcodigo.Text <> String.Empty) Then
                If (fc.edita_cliente(txtcodigo.Text, txtnombre.Text, txtapellidos.Text, txtestado.Text, txtcrea.Text, txtmodifica.Text, txtdireccion.Text, txttelefono.Text) = True) Then
                    MessageBox.Show("Cliente editado Correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cancelar()
                    mostrar_clientes()
                Else
                    MessageBox.Show("Error al Modificar el cliente")
                End If
            Else


                If (fc.ingresa_cliente(txtcodigo.Text, txtnombre.Text, txtapellidos.Text, txtcrea.Text, txtestado.Text, txtmodifica.Text, txtdireccion.Text, txttelefono.Text) = True) Then
                    MessageBox.Show("Cliente registrado Correctamente", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cancelar()
                    mostrar_clientes()
                Else
                    MessageBox.Show("Error al registrar el cliente")
                End If
            End If

        Else
            MessageBox.Show("Complete todos los datos")
        End If
    End Sub

    Private Sub dgvcliente_DoubleClick(sender As Object, e As EventArgs) Handles dgvcliente.DoubleClick
        txtcodigo.Text = dgvcliente.CurrentRow.Cells("cod_cliente").Value
        txtnombre.Text = dgvcliente.CurrentRow.Cells("nombres").Value
        txtapellidos.Text = dgvcliente.CurrentRow.Cells("apellidos").Value
        txtdireccion.Text = dgvcliente.CurrentRow.Cells("direccion").Value
        txttelefono.Text = dgvcliente.CurrentRow.Cells("telefono").Value
        txtestado.Text = dgvcliente.CurrentRow.Cells("estado").Value
        txtmodifica.Text = dgvcliente.CurrentRow.Cells("modificado_por").Value
        txtcrea.Text = dgvcliente.CurrentRow.Cells("creado_por").Value


        btnguardar.Enabled = False
        btnmodificar.Enabled = True
        btneliminar.Enabled = True
        btncancelar.Enabled = True
        btnnuevo.Enabled = True
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim c As New Fcliente
        If (c.elimina_cliente(txtcodigo.Text) = True) Then
            MessageBox.Show("Cliente Eliminadaa Correctamente", "Elimacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cancelar()
            mostrar_clientes()
        Else
            MessageBox.Show("Error al eliminar el cliente")
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        buscar_cliente()
    End Sub

    Private Sub txttelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefono.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub txtapellidos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellidos.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        mostrar_clientes()
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