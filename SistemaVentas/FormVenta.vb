Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormVenta

    Dim dtcliente As New DataTable
    Dim dtproducto As New DataTable
    Dim dtventa As New DataTable


    Sub mostrar_producto()
        Dim c As New Fproducto
        dtproducto = c.mostrar_producto
        cbproducto.DataSource = cbproducto
        cbproducto.DisplayMember = "titulo"
        cbproducto.ValueMember = "id_Libro"
    End Sub

    Private Sub FormVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim fv As New Fventa
        dtventa = fv.verr_ventas()
        txtnumdocu.Text = "CPT-" & dtventa.Rows.Count + 1

        'Dejar controles habilitados
        btnegregar.Enabled = True
        btnguardar.Enabled = True
        cbproducto.Enabled = True
        txtcabtidad.Enabled = True

        Try

            mostrar_producto()
            With dgvdetalles.ColumnHeadersDefaultCellStyle
                .BackColor = Color.Chartreuse
                .Font = New Font("Tahoma", 8, FontStyle.Bold)
                .Alignment = DataGridViewContentAlignment.MiddleCenter
            End With

        Catch ex As Exception
            MessageBox.Show("Para realizar una venta debe tener un cliente registrado y productos ")

        End Try


    End Sub


    Private Sub btnegregar_Click(sender As Object, e As EventArgs) Handles btnegregar.Click
        If (cbproducto.Text <> String.Empty And txtcabtidad.Value > 0) Then
            Dim fila As Int32
            fila = cbproducto.SelectedIndex
            Dim ultima As Int32
            dgvdetalles.Rows.Add()
            ultima = dgvdetalles.Rows.Count - 1
            dgvdetalles.Item(0, ultima).Value = cbproducto.SelectedValue
            dgvdetalles.Item(1, ultima).Value = txtcabtidad.Value
            dgvdetalles.Item(2, ultima).Value = cbproducto.Text
            dgvdetalles.Item(3, ultima).Value = dtproducto.Rows(fila)("Montomulta")
            dgvdetalles.Item(4, ultima).Value = dgvdetalles.Item(1, ultima).Value * dgvdetalles.Item(3, ultima).Value


            Dim razon As Int32
            razon = 0
            razon = Convert.ToInt32(dtproducto.Rows(fila)(3)) - Convert.ToInt32(dgvdetalles.Item(1, ultima).Value)
            If (razon < 0) Then
                MessageBox.Show("Usted solo cuenta con" + Convert.ToString(dtproducto.Rows(fila)("Cantidad")) + "" + dgvdetalles.Item(2, ultima).Value)
                dgvdetalles.Rows.RemoveAt(ultima)
            Else

            End If

        Else
            MessageBox.Show("Seleccione un producto y/o cantidad")
        End If
        total()
    End Sub

    Private Sub dgvdetalles_DoubleClick(sender As Object, e As EventArgs) Handles dgvdetalles.DoubleClick
        Dim ex
        ex = MessageBox.Show("¿Seguro que desea eliminar el item seleccionado?", "Eliminar item", MessageBoxButtons.YesNo)
        If (ex = vbYes) Then
            dgvdetalles.Rows.Remove(dgvdetalles.CurrentRow)
            total()
        Else

        End If


    End Sub
    Sub total()
        Dim total As Int32
        total = 0
        For i = 0 To dgvdetalles.Rows.Count - 1
            total = total + dgvdetalles.Item(4, i).Value
        Next
        txttotal.Text = total
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If (dgvdetalles.RowCount > 0) Then
            Dim fv As New Fventa

            If (fv.ingresa_Ventas(txtnumdocu.Text, txtfecha.Value, txttotal.Text)) Then

                For i = 0 To dgvdetalles.Rows.Count - 1
                    If (fv.ingresa_detalle(txtnumdocu.Text, dgvdetalles.Item(0, i).Value, dgvdetalles.Item(1, i).Value, dgvdetalles.Item(4, i).Value) = False) Then
                        MessageBox.Show("Error al registrar el item dentro de la venta")
                    Else

                    End If
                    If (fv.bajar_stock(dgvdetalles.Item(0, i).Value, dgvdetalles.Item(1, i).Value) = False) Then
                        MessageBox.Show("Error al reducir el stock")
                    Else

                    End If
                Next
                MessageBox.Show("Venta registrada correctamente")
                Dim dt = fv.ver_ventas()

                Dim nuevoDoc = "CPT-" & (dt.Rows.Count + 1).ToString()

                txtnumdocu.Text = nuevoDoc
            Else
                MessageBox.Show("Error al registrar la venta")
            End If
        Else
            MessageBox.Show("Ingrese items para poder realizar la venta")
        End If
        If txtnumdocu.Text = "" Then
            MessageBox.Show("Debe generar el número de documento")
            Return
        End If


        LimpiarFormulario()


    End Sub


    Private Sub BusquedaProductos_KeyDown(sender As Object, e As KeyEventArgs) Handles BusquedaProductos.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim f As New Fproducto()
                Dim textoBusqueda As String = BusquedaProductos.Text.Trim()
                Dim dt As DataTable = f.buscar_producto(textoBusqueda)

                If dt.Rows.Count > 0 Then
                    Dim fila As Int32
                    fila = cbproducto.SelectedIndex
                    Dim ultima As Int32
                    dgvdetalles.Rows.Add()
                    ultima = dgvdetalles.Rows.Count - 1
                    dgvdetalles.Item(0, ultima).Value = dt.Rows(0)("cod_producto")
                    dgvdetalles.Item(1, ultima).Value = txtcabtidad.Value
                    dgvdetalles.Item(2, ultima).Value = dt.Rows(0)("nombre")
                    dgvdetalles.Item(3, ultima).Value = dt.Rows(0)("precio")
                    dgvdetalles.Item(4, ultima).Value = dt.Rows(0)("precio")
                    Dim razon As Int32
                    razon = 0
                    razon = Convert.ToInt32(dtproducto.Rows(fila)(3)) - Convert.ToInt32(dgvdetalles.Item(1, ultima).Value)
                    If (razon < 0) Then
                        MessageBox.Show("Usted solo cuenta con" + Convert.ToString(dtproducto.Rows(fila)("stock")) + "" + dgvdetalles.Item(2, ultima).Value)
                        dgvdetalles.Rows.RemoveAt(ultima)
                    Else

                    End If

                Else
                    MessageBox.Show("Producto no encontrado")
                End If

            Catch ex As Exception
                MessageBox.Show("Error al buscar el producto")
            End Try
        End If
    End Sub




    Sub LimpiarFormulario()
        dgvdetalles.Rows.Clear()
        cbproducto.Text = ""
        txtcabtidad.Text = "1"
        txttotal.Clear()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Formcliente.Show()
    End Sub
    Private Sub FormVenta_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        ' Check if the mouse is outside the form's bounds
        If Not Me.Bounds.Contains(Cursor.Position) Then
            Me.Close()
        End If
    End Sub


End Class