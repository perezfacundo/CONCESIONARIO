<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="index.aspx.vb" Inherits="CONCESIONARIO.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            CODIGO
            <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
        </div>
        <div>
            ORIGEN
            <asp:TextBox ID="txtOrigen" runat="server"></asp:TextBox>
        </div>
        <div>
            MARCA
            <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Button ID="cmdAgregar" runat="server" Text="Button" />
        </div>
    </form>
</body>
</html>
