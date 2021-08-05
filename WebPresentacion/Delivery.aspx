﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delivery.aspx.cs" Inherits="WebPresentacion.Delivery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Delivery</title>
    <link href="Style.css" rel="stylesheet" />
    <link rel="shortcut icon" href="/Imag/entre.png">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KyZXEAg3QhqLMpG8r+8fhAXLRk2vvoC2f3B09zVXn8CA5QIVfZOJ3BCsw2P0p/We" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <header>
    <div class="container">
        <img src="../Imag/entre.png" ><h1>Delivery</h1>
    </div>
    </header>
          <br />
        <br />
        <br />
        <br />
         <br />
        <br />
        <br />
        <div>

            <span class="input-group-text" id="inputGroup-sizing-lg">Nombre</span>
            <asp:TextBox ID="TextBox1" class="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-lg" runat="server"></asp:TextBox>
            <br />
            <span class="input-group-text" id="inputGroup-sizing-lg">Celular:</span>
            <asp:TextBox ID="TextBox2" class="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-lg" runat="server"></asp:TextBox>
            <br />
            <span class="input-group-text" id="inputGroup-sizing-lg">Licencia:</span>
            <asp:TextBox ID="TextBox3" class="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-lg" runat="server"></asp:TextBox>
        </div>
        <br />
        <asp:Button ID="Button1" class="btn btn-danger" runat="server" OnClick="Button1_Click" Text="Insertar " BorderColor="#FFD5D5" BorderStyle="Double" />
        <asp:Button ID="Button2" class="btn btn-danger" runat="server" OnClick="Button2_Click" Text="Mostrar" BorderColor="#FFD5D5" BorderStyle="Double" />
        <asp:Button ID="Button3" class="btn btn-danger" runat="server" OnClick="Button3_Click" Text="Editar" BorderColor="#FFD5D5" BorderStyle="Double" />
        <br />
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#E68282" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Editar" ShowHeader="True" Text="Editar" />
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
        <asp:Button ID="Button4" class="btn btn-danger" runat="server" OnClick="Button4_Click" Text="Inicio" BorderColor="#FFD5D5" BorderStyle="Double" Width="250px"/>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-U1DAWAznBHeqEIlVSCgzq+c9gqGAJn5c/t99JyeKa9xxaYpSvHU5awsuZVVFIhvj" crossorigin="anonymous"></script>
    <script src="http://code.jquery.com/jquery-latest.js"></script>
</body>
</html>
