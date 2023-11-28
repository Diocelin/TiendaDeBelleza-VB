Imports System.Data.SqlClient
Imports System.Runtime.ConstrainedExecution
Public Class FProveedor

    Inherits Conexion


    Public Function ingresa_proveedor(cod As String, nome As String, connom As String, tel As String, est As String, modi As String, cre As String) As Boolean
        conectado()
        cmd = New SqlCommand("insertar_proveedor", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cod_proveedor", cod)
        cmd.Parameters.AddWithValue("@nombre_empresa", nome)
        cmd.Parameters.AddWithValue("@contacto_nombre", connom)
        cmd.Parameters.AddWithValue("@contacto_telefono", tel)
        cmd.Parameters.AddWithValue("@estado", est)
        cmd.Parameters.AddWithValue("@creado_por", cre)
        cmd.Parameters.AddWithValue("@modificado_por", modi)

        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function edita_proveedor(cod As String, nome As String, connom As String, tel As String, est As String, modi As String, cre As String) As Boolean
        conectado()
        cmd = New SqlCommand("editar_proveedor", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cod_proveedor", cod)
        cmd.Parameters.AddWithValue("@nombre_empresa", nome)
        cmd.Parameters.AddWithValue("@contacto_nombre", connom)
        cmd.Parameters.AddWithValue("@contacto_telefono", tel)
        cmd.Parameters.AddWithValue("@estado", est)
        cmd.Parameters.AddWithValue("@creado_por", cre)
        cmd.Parameters.AddWithValue("@modificado_por", modi)
        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function elimina_proveedor(cod As String) As Boolean
        conectado()
        cmd = New SqlCommand("eliminar_proveedor", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cod_proveedor", cod)

        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function mostrar_proveedor() As DataTable
        conectado()
        cmd = New SqlCommand("mostrar_proveedor", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function

    Public Function buscar_proveedor(txtbus As String) As DataTable
        conectado()
        cmd = New SqlCommand("buscar_proveedor", ccn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@texto", txtbus)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function

End Class

