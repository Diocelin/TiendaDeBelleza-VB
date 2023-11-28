Imports System.Data.SqlClient
Imports System.Runtime.ConstrainedExecution
Public Class FAlmacen
    Inherits Conexion


    Public Function ingresa_almacen(cod As String, nomA As String, cap As String, cre As String, est As String, modi As String, dir As String) As Boolean
        conectado()
        cmd = New SqlCommand("insertar_almacen", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cod_almacen", cod)
        cmd.Parameters.AddWithValue("@nombre_almacen", nomA)
        cmd.Parameters.AddWithValue("@direccion_almacen", dir)
        cmd.Parameters.AddWithValue("@capacidad", cap)
        cmd.Parameters.AddWithValue("@estado", est)
        cmd.Parameters.AddWithValue("@creado_por", cre)
        cmd.Parameters.AddWithValue("@modificado_por", modi)

        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function edita_almacen(cod As String, nomA As String, cap As String, cre As String, est As String, modi As String, dir As String) As Boolean
        conectado()
        cmd = New SqlCommand("editat_almacen", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cod_almacen", cod)
        cmd.Parameters.AddWithValue("@nombre_almacen", nomA)
        cmd.Parameters.AddWithValue("@direccion_almacen", dir)
        cmd.Parameters.AddWithValue("@capacidad", cap)
        cmd.Parameters.AddWithValue("@estado", est)
        cmd.Parameters.AddWithValue("@creado_por", cre)
        cmd.Parameters.AddWithValue("@modificado_por", modi)

        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function elimina_almacen(cod As String) As Boolean
        conectado()
        cmd = New SqlCommand("eliminar_almacen", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cod_almacen", cod)

        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function mostrar_almacen() As DataTable
        conectado()
        cmd = New SqlCommand("mostrar_almacen", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function

    Public Function buscar_almacen(txtbus As String) As DataTable
        conectado()
        cmd = New SqlCommand("buscar_cliente", ccn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@texto", txtbus)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function

End Class

