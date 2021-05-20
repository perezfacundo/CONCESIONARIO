Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class conexion
    Protected conn As New SqlConnection

    Event ConexionesError(descripcion As String)

    Public Function fConectar(Optional CadenaConexion = Nothing)
        Dim Cadena As String

        If CadenaConexion = Nothing Then
            Cadena = ConfigurationManager.ConnectionStrings("CONCESIONARIOConnectionString").ConnectionString
        Else
            Cadena = CadenaConexion
        End If

        Try
            conn = New SqlConnection(Cadena)
            conn.Open()
            Return True
        Catch ex As Exception
            RaiseEvent ConexionesError(ex.Message)
            Return False
        End Try
    End Function

    Public Function fDesconectar()

        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            RaiseEvent ConexionesError(ex.Message)
            Return False
        End Try

    End Function
End Class
