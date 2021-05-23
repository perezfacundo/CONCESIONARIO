Imports System.Data.SqlClient

Public Class mantenimiento

    Inherits conexion
    Event MantenimientosError(descripcion As String)

    Dim query As String

    Public Function fAgregarMarca(codigo As Integer, marca As String, pais As String)
        query = "INSERT INTO marcas (codigo, descripcion, pais) VALUES (" & codigo & ", '" & marca & "', '" & pais & "')"

        Try
            fConectar()
            Dim cmd As New SqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            Return "El registro fue insertado exitosamente"
        Catch ex As Exception
            RaiseEvent MantenimientosError(ex.Message)
            Return "Ocurrio un error al intentar insertar el registro"
        Finally
            fDesconectar()
        End Try

    End Function

    Public Function fListar() As DataTable
        query = "SELECT * FROM marcas"

        Try
            fConectar()
            Dim cmd As New SqlCommand(query, conn)
            cmd.CommandType = CommandType.Text
            Dim datareader As SqlDataReader = cmd.ExecuteReader()
            Dim tabla As DataTable = New DataTable()
            tabla.Load(datareader)
            Return tabla
        Catch ex As Exception
            RaiseEvent MantenimientosError(ex.Message)
            Return Nothing
        Finally
            fDesconectar()
        End Try
    End Function


End Class
