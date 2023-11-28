Imports System.Data.SqlClient
Public Class Fventa
    Inherits Conexion

    Public Function ingresa_Ventas(cod As String, feec As Date, tot As Decimal) As Boolean
        conectado()
        cmd = New SqlCommand("insertar_Ventas", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cod_venta", cod)
        cmd.Parameters.AddWithValue("@fecha", feec)
        cmd.Parameters.AddWithValue("@Monto", tot)

        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function ingresa_detalle(numdoc As String, codpro As String, cant As Int32, pre As Decimal) As Boolean
        conectado()
        cmd = New SqlCommand("ingresa_detalle", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@num_documento", numdoc)
        cmd.Parameters.AddWithValue("@cod_producto", codpro)
        cmd.Parameters.AddWithValue("@cantidad", cant)
        cmd.Parameters.AddWithValue("@precio", pre)

        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ver_ventas() As DataTable
        conectado()
        cmd = New SqlCommand("mostrar_venta", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt

    End Function
    Public Function buscar_venta(txtbus As String) As DataTable
        conectado()
        cmd = New SqlCommand("buscar_ventas", ccn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@documento", txtbus)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function

    Public Function total_ventas() As DataTable
        conectado()
        cmd = New SqlCommand("vertotal", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt

    End Function

    Public Function bajar_stock(cod As String, cant As Integer) As Boolean
        conectado()
        cmd = New SqlCommand("bajar_stock", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cod_producto", cod)
        cmd.Parameters.AddWithValue("@stock", cant)

        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function ingresa_venta_sin_cliente(numdoc As String, fecha As Decimal, total As Decimal, cant As Decimal, pre As Decimal) As Boolean

        conectado()
        Dim cmd As New SqlCommand("ingresar_detalle")

        cmd.CommandText = "insertar_venta"
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@num_documento", numdoc)
        cmd.Parameters.AddWithValue("@fecha", fecha)
        cmd.Parameters.AddWithValue("@total", total)
        cmd.Parameters.AddWithValue("@cantidad", cant)
        cmd.Parameters.AddWithValue("@precio", pre)

        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function mostrar_producto() As DataTable
        conectado()
        cmd = New SqlCommand("mostrar_producto", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function

    Public Function buscar_producto(texto As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("buscar_producto", ccn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@texto", texto)
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            ' Manejar la excepción de manera apropiada, como registrarla en un archivo de registro o mostrar un mensaje al usuario
            MessageBox.Show("Error al buscar productos: " + ex.Message)
            Return New DataTable() ' Devolver una tabla vacía en caso de error
        Finally

        End Try
    End Function
    Public Function verr_ventas()
        conectado()
        cmd = New SqlCommand("mostrar_venta", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt

    End Function


End Class
