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

    Public Function fListar() As String
        Dim stringHtml As String = ""
        Dim codigo As String = ""
        Dim marca As String = ""
        Dim pais As String = ""

        query = "SELECT * FROM marcas"

        Try
            fConectar()
            Dim cmd As New SqlCommand(query, conn)
            cmd.CommandType = CommandType.Text
            Dim datareader As SqlDataReader = cmd.ExecuteReader()
            Dim tabla As DataTable = New DataTable()
            tabla.Load(datareader)

            stringHtml = "<table border=1><tbody><tr><th> CODIGO </th><th> DESCRIPCION </th><th> PAIS </th></tr>"


            For Each row As DataRow In tabla.Rows

                codigo = CStr(row("codigo"))
                marca = CStr(row("descripcion"))
                pais = CStr(row("pais"))


                stringHtml = stringHtml & "<tr>"
                stringHtml = stringHtml & "<td>" & codigo & "</td>"
                stringHtml = stringHtml & "<td>" & marca & "</td>"
                stringHtml = stringHtml & "<td>" & pais & "</td>"
                'stringHtml = stringHtml & tachito de basura para eliminar el registro
                stringHtml = stringHtml & "</tr>"

            Next
            stringHtml = stringHtml & "</tbody></table>"

            Return stringHtml
        Catch ex As Exception
            RaiseEvent MantenimientosError(ex.Message)
            Return Nothing
        Finally
            fDesconectar()
        End Try
    End Function


End Class
