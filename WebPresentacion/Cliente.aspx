<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="WebPresentacion.Cliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<br />
            <asp:Label ID="Label2" runat="server" Text="ApP"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="ApM"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Cel"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insertar" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Mostrar Todos" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Actualizar" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Eliminar" />
        <br />
        <br />
        No podra eliminar un cliente a menos que no tenga un pedido en curso<asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Editar" ShowHeader="True" Text="Elegir" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
