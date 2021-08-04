<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="WebPresentacion.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Creaciones de pedidos"></asp:Label>
             <div style="width: 287px">
             <asp:Label ID="Label2" runat="server" Text="Registralo si es nuevo en tu carniceria"></asp:Label>
             <br />
             <asp:Button ID="Button1" runat="server" Text="Nuevo Carnicero" OnClick="Button1_Click" />
          </div>
              <div>
           <p>
             <asp:Label ID="Label3" runat="server" Text="Registralo si es nuevo en tu carniceria"></asp:Label>
             </p> 
             <asp:Button ID="Button2" runat="server" Text="Nuevo Cliente" OnClick="Button2_Click" />
           </div>
            <p>Seleccionar un Carnicero*</p> 
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
           </div>

        
        <div>
           <p>Seleccionar cliente*</p> 
        <asp:DropDownList ID="dplClient" runat="server" OnSelectedIndexChanged="dplClient_SelectedIndexChanged"></asp:DropDownList>
            <br />
            <p>Pedido Aceptado - En espera*</p>
            <p>
                <asp:DropDownList ID="Dpnodp" runat="server">
                </asp:DropDownList>
            </p>
            <p>Monto a cobrar*</p>
            <p>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Crear Pedido" />
&nbsp;<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Mostrar Pedidos" />
            </p>
            <p>&nbsp;Los pedidos los busca por nombre de cliente(Solo nombre)*</p>
            <p>Ingrese el nombre del cliente
                <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Mostrar Los pedidos del cliente" />
            </p>
           </div>
       
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
       
    </form>
</body>
</html>
