Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.ConstrainedExecution
Public Class Fcategoria
    Inherits Conexion

    Public Function ingresa_categoria(cod As String, cat As String, est As String, codp As String, cre As String, modi As String) As Boolean
        conectado()
        cmd = New SqlCommand("insertar_categoria", ccn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@cod_categoria", cod)
        cmd.Parameters.AddWithValue("@Categoria", cat)
        cmd.Parameters.AddWithValue("@estado", est)
        cmd.Parameters.AddWithValue("@cod_proveedor", codp)
        cmd.Parameters.AddWithValue("@creado_por", cre)
        cmd.Parameters.AddWithValue("@modificado_por", modi)


        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function edita_categoria(cod As String, cat As String, est As String, codp As String, cre As String, modi As String) As Boolean
        conectado()
        cmd = New SqlCommand("edita_categoria", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cod_categoria", cod)
        cmd.Parameters.AddWithValue("@Categoria", cat)
        cmd.Parameters.AddWithValue("@estado", est)
        cmd.Parameters.AddWithValue("@cod_proveedor", codp)
        cmd.Parameters.AddWithValue("@creado_por", cre)
        cmd.Parameters.AddWithValue("@modificado_por", modi)

        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function elimina_categoria(cod As String) As Boolean
        conectado()
        cmd = New SqlCommand("elimina_categoria", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cod_categoria", cod)

        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function mostrar_categoria() As DataTable
        conectado()
        cmd = New SqlCommand("mostrar_categoria", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function

    Public Function buscar_categoria(txtbus As String) As DataTable
        conectado()
        cmd = New SqlCommand("buscar_categoria", ccn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@texto", txtbus)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function

End Class
