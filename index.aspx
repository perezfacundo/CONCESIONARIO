<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="index.aspx.vb" Inherits="CONCESIONARIO.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>CONCESIONARIO</title>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="cajaTexto">
                 CODIGO
            <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
                 <asp:Label ID="lblCodigo" runat="server" ForeColor="Red"></asp:Label>
            </div>

            <div class="cajaTexto">
                MARCA&nbsp; 
            <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
                <asp:Label ID="lblMarca" runat="server" ForeColor="Red"></asp:Label>
            </div>

            <div class="cajaTexto">
                PAIS&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="txtPais" runat="server"></asp:TextBox>
                <asp:Label ID="lblPais" runat="server" ForeColor="Red"></asp:Label>
            </div>
        </div>

        <div class="botones">
            <asp:Button ID="cmdAgregar" runat="server" Text="AGREGAR" />
            <asp:Button ID="cmdListar" runat="server" Text="LISTAR" />
        </div>

        <hr />

        <div class="grilla" id="grilla" runat="server">

            <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            <%-- <br />
            <asp:GridView ID="dgv" runat="server"></asp:GridView>--%>
        </div>
    </form>
</body>
</html>
