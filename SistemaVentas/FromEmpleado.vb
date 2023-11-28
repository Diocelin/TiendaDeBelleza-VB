Public Class FromEmpleado
    Dim dtempleado As New DataTable
    Private Sub FormEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        btnguardar.Enabled = False
        btncancelar.Enabled = False
        btneliminar.Enabled = False
        btnmodificar.Enabled = False
        mostrar_empleado()
    End Sub
    Sub buscar_empleado()
        Dim fc As New Fempleado
        dtempleado = fc.buscar_empleado(txtbuscar.Text)
        dgvEmpleado.DataSource = dtempleado
    End Sub
    Sub mostrar_empleado()
        Dim fc As New Fempleado
        dtempleado = fc.mostrar_empleado()
        dgvEmpleado.DataSource = dtempleado
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
        txtpuesto.Clear()
        txtdireccion.Clear()
        txtSueldo.Clear()
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
        txtpuesto.Enabled = va
        txtdireccion.Enabled = va
        txtSueldo.Enabled = va
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
        Dim fc As New Fempleado
        If (txtnombre.Text <> String.Empty And txtpuesto.Text <> String.Empty And txtcrea.Text <> String.Empty And txtestado.Text <> String.Empty And txtmodifica.Text <> String.Empty) Then

            If (txtcodigo.Text <> String.Empty) Then
                If (fc.edita_empleado(txtcodigo.Text, txtnombre.Text, txtpuesto.Text, txtestado.Text, txtcrea.Text, txtmodifica.Text, txtdireccion.Text, txtSueldo.Text) = True) Then
                    MessageBox.Show("Empleado editado Correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cancelar()
                    mostrar_empleado()
                Else
                    MessageBox.Show("Error al Modificar el empleado")
                End If
            Else


                If (fc.ingresa_empleado(txtcodigo.Text, txtnombre.Text, txtpuesto.Text, txtcrea.Text, txtestado.Text, txtmodifica.Text, txtdireccion.Text, txtSueldo.Text) = True) Then
                    MessageBox.Show("Empleado registrado Correctamente", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cancelar()
                    mostrar_empleado()
                Else
                    MessageBox.Show("Error al registrar el empleado")
                End If
            End If

        Else
            MessageBox.Show("Complete todos los datos")
        End If
    End Sub

    Private Sub dgvempleado_DoubleClick(sender As Object, e As EventArgs) Handles dgvEmpleado.DoubleClick
        txtcodigo.Text = dgvEmpleado.CurrentRow.Cells("id_Personal").Value
        txtnombre.Text = dgvEmpleado.CurrentRow.Cells("nombre").Value
        txtpuesto.Text = dgvEmpleado.CurrentRow.Cells("puesto").Value
        txtdireccion.Text = dgvEmpleado.CurrentRow.Cells("direccion").Value
        txtSueldo.Text = dgvEmpleado.CurrentRow.Cells("sueldo").Value
        txtestado.Text = dgvEmpleado.CurrentRow.Cells("estado").Value
        txtmodifica.Text = dgvEmpleado.CurrentRow.Cells("modificado_por").Value
        txtcrea.Text = dgvEmpleado.CurrentRow.Cells("creado_por").Value


        btnguardar.Enabled = False
        btnmodificar.Enabled = True
        btneliminar.Enabled = True
        btncancelar.Enabled = True
        btnnuevo.Enabled = True
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim c As New Fempleado
        If (c.elimina_empleado(txtcodigo.Text) = True) Then
            MessageBox.Show("empleado Eliminadaa Correctamente", "Elimacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cancelar()
            mostrar_empleado()
        Else
            MessageBox.Show("Error al eliminar el empleado")
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        buscar_empleado()
    End Sub

    Private Sub txtsueldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSueldo.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub txtapuesto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpuesto.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        mostrar_empleado()
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