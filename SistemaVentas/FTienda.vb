Imports System.Data.SqlClient
Imports System.Runtime.ConstrainedExecution
Public Class FTienda
    Inherits Conexion

    Public Function ingresa_tienda(cod As String, nomC As String, cre As String, est As String, modi As String, dirP As String, telP As String) As Boolean
        conectado()
        cmd = New SqlCommand("insertar_Tiendas", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cod_cadena", cod)
        cmd.Parameters.AddWithValue("@nombre_cadena", nomC)
        cmd.Parameters.AddWithValue("@direccion_principal", dirP)
        cmd.Parameters.AddWithValue("@telefono_principal", telP)
        cmd.Parameters.AddWithValue("@estado", est)
        cmd.Parameters.AddWithValue("@creado_por", cre)
        cmd.Parameters.AddWithValue("@modificado_por", modi)

        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function edita_tienda(cod As String, nomC As String, cre As String, est As String, modi As String, dirP As String, telP As String) As Boolean
        conectado()
        cmd = New SqlCommand("edita_Tiendas", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cod_cadena", cod)
        cmd.Parameters.AddWithValue("@nombre_cadena", nomC)
        cmd.Parameters.AddWithValue("@direccion_principal", dirP)
        cmd.Parameters.AddWithValue("@telefono_principal", telP)
        cmd.Parameters.AddWithValue("@estado", est)
        cmd.Parameters.AddWithValue("@creado_por", cre)
        cmd.Parameters.AddWithValue("@modificado_por", modi)
        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function elimina_Tiendas(cod As String) As Boolean
        conectado()
        cmd = New SqlCommand("eliminar_Tiendas", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cod_Tiendas", cod)

        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function mostrar_tienda() As DataTable
        conectado()
        cmd = New SqlCommand("mostrar_Tiendas", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function

    Public Function buscar_tienda(txtbus As String) As DataTable
        conectado()
        cmd = New SqlCommand("buscar_Tiendas", ccn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@texto", txtbus)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function

End Class
