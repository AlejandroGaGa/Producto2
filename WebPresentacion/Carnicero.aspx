<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carnicero.aspx.cs" Inherits="WebPresentacion.Presentacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Carnicero</title>
    <link href="Style.css" rel="stylesheet" />
    <link rel="shortcut icon" href="/Imag/carni.png">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KyZXEAg3QhqLMpG8r+8fhAXLRk2vvoC2f3B09zVXn8CA5QIVfZOJ3BCsw2P0p/We" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <header>
    <div class="container">
        <h1>Canicero</h1>
    </div>
    </header>
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
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insertar" BackColor="#E68282" BorderColor="#FFD5D5" BorderStyle="Double" />
        <asp:Button ID="Button2" runat="server" Text="Mostrar" OnClick="Button2_Click" BackColor="#E68282" BorderColor="#FFD5D5" BorderStyle="Double" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Actualizar" BackColor="#E68282" BorderColor="#FFD5D5" BorderStyle="Double" />
        <br />
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#E68282" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Editar" ShowHeader="True" Text="Elegir" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-U1DAWAznBHeqEIlVSCgzq+c9gqGAJn5c/t99JyeKa9xxaYpSvHU5awsuZVVFIhvj" crossorigin="anonymous"></script>
    <script src="http://code.jquery.com/jquery-latest.js"></script>
</body>
</html>
