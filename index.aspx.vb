Imports System.Data.SqlClient

Public Class index
    Inherits System.Web.UI.Page
    Dim WithEvents objMantenimiento As New mantenimiento

    Protected Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim codigo As Integer = 0
        Dim pais As String = ""
        Dim marca As String = ""
        Dim stringHtml As String = ""

        Try
            If txtCodigo.Text = "" Then
                lblCodigo.Text = "Debe completar el campo"
            Else
                codigo = txtCodigo.Text
                lblCodigo.Text = ""
                txtCodigo.Text = ""
            End If
        Catch ex As Exception
            lblCodigo.Text = "Debe ingresar un numero"
        End Try

        Try
            If txtMarca.Text = "" Then
                lblMarca.Text = "Debe completar el campo"
            Else
                marca = txtMarca.Text.ToUpper
                lblMarca.Text = ""
                txtMarca.Text = ""
            End If
        Catch ex As Exception
            lblMarca.Text = "Debe ingresar una marca"
        End Try

        Try
            If txtPais.Text = "" Then
                lblPais.Text = "Debe completar el campo"
            Else
                pais = txtPais.Text.ToUpper
                lblPais.Text = ""
                txtPais.Text = ""
            End If
        Catch ex As Exception
            lblPais.Text = "Debe ingresar un pais"
        End Try

        If codigo <> 0 Or marca <> "" Or pais <> "" Then
            Dim resultado As String = objMantenimiento.fAgregarMarca(codigo, marca, pais)
            grilla.InnerHtml = "<p>" & resultado & "</p>"
        End If


        Dim tabla As New DataTable
        tabla = objMantenimiento.fListar()

        'dgv.DataSource = tabla 'PASAR TABLA A GRILLA EN LIMPIO
        'dgv.DataBind()

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

        grilla.InnerHtml = stringHtml

        'If dgv.Rows.Count() < 1 Then
        '    lblMensaje.Text = "No se encontraron registros en la base de datos"
        'Else
        '    lblMensaje.Text = ""
        'End If
    End Sub

    Protected Sub cmdListar_Click(sender As Object, e As EventArgs) Handles cmdListar.Click

    End Sub
End Class