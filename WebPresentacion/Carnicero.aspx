<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carnicero.aspx.cs" Inherits="WebPresentacion.Presentacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Carnicero</title>
    <link rel="shortcut icon" href="/Imag/carni.png">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KyZXEAg3QhqLMpG8r+8fhAXLRk2vvoC2f3B09zVXn8CA5QIVfZOJ3BCsw2P0p/We" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Insertar Carnicero<br />
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Cel"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Año de experiencia"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insertar" />
        <asp:Button ID="Button2" runat="server" Text="Mostrar" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Actualizar" />
        <br />
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Editar" ShowHeader="True" Text="Elegir" />
            </Columns>
        </asp:GridView>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-U1DAWAznBHeqEIlVSCgzq+c9gqGAJn5c/t99JyeKa9xxaYpSvHU5awsuZVVFIhvj" crossorigin="anonymous"></script>
    <script src="http://code.jquery.com/jquery-latest.js"></script>
</body>
</html>
