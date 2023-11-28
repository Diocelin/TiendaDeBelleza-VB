Imports System.Data.SqlClient
Imports System.Runtime.ConstrainedExecution
Public Class Fempleado
    Inherits Conexion

    Public Function ingresa_empleado(cod As String, nom As String, pue As String, cre As String, est As String, modi As String, dir As String, sue As String) As Boolean
        conectado()
        cmd = New SqlCommand("insertar_empleado", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@id_Personal", cod)
        cmd.Parameters.AddWithValue("@nombre", nom)
        cmd.Parameters.AddWithValue("@puesto", pue)
        cmd.Parameters.AddWithValue("@direccion", dir)
        cmd.Parameters.AddWithValue("@sueldo", sue)
        cmd.Parameters.AddWithValue("@estado", est)
        cmd.Parameters.AddWithValue("@creado_por", cre)
        cmd.Parameters.AddWithValue("@modificado_por", modi)

        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function edita_empleado(cod As String, nom As String, pue As String, cre As String, est As String, modi As String, dir As String, sue As String) As Boolean
        conectado()
        cmd = New SqlCommand("edita_empleado", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@id_Personal", cod)
        cmd.Parameters.AddWithValue("@nombre", nom)
        cmd.Parameters.AddWithValue("@puesto", pue)
        cmd.Parameters.AddWithValue("@direccion", dir)
        cmd.Parameters.AddWithValue("@sueldo", sue)
        cmd.Parameters.AddWithValue("@estado", est)
        cmd.Parameters.AddWithValue("@creado_por", cre)
        cmd.Parameters.AddWithValue("@modificado_por", modi)
        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function elimina_empleado(cod As String) As Boolean
        conectado()
        cmd = New SqlCommand("eliminar_empleado", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cod_empleado", cod)

        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function mostrar_empleado() As DataTable
        conectado()
        cmd = New SqlCommand("mostrar_empleado", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function

    Public Function buscar_empleado(txtbus As String) As DataTable
        conectado()
        cmd = New SqlCommand("buscar_empleado", ccn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@texto", txtbus)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function

End Class
