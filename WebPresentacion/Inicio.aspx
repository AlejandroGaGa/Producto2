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
             &nbsp;/ Deberas ingresar todos estos datos para crear el pedido<div >
             <asp:Label ID="Label11" runat="server" Text="Registralo si es nuevo en tu carniceria"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="REPARTIDOR" />
                <br />
             <asp:Label ID="Label2" runat="server" Text="Registralo si es nuevo en tu carniceria"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
             <asp:Button ID="Button1" runat="server" Text="CARNICERO" OnClick="Button1_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <br />
          </div>
              <div>
           <p>
             <asp:Label ID="Label3" runat="server" Text="Registralo si es nuevo en tu carniceria"></asp:Label>
             </p> 
             <asp:Button ID="Button2" runat="server" Text="CLIENTE" OnClick="Button2_Click" />
           </div>
            <p>Seleccionar un Carnicero*</p> 
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="CargarCarniceros" />
            <br />
            <asp:Label ID="lbCarn" runat="server"></asp:Label>
           </div>

        
        <div>
           <p>Seleccionar cliente*</p> 
        <asp:DropDownList ID="dplClient" runat="server" OnSelectedIndexChanged="dplClient_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="Cargar Clientes" />
            <br />
            <asp:Label ID="lbClient" runat="server" Text="Label"></asp:Label>
            <br />
            <p>Pedido Aceptado - En espera*</p>
            <p>
                <asp:DropDownList ID="DropEnespera" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropEnespera_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Cargar" />
            </p>
            <p>
                <asp:Label ID="lbTrue" runat="server" Text="Label"></asp:Label>
            </p>
            <p>Monto a cobrar*</p>
            <p>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Crear Pedido" />
&nbsp;<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Mostrar Pedidos" />
            </p>
            <p>
                <asp:Label ID="Label4" runat="server" Text="Nombre del producto a vender"></asp:Label>
                <asp:TextBox ID="txtprod" runat="server"></asp:TextBox>
                <br />
&nbsp;&nbsp;
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <asp:Label ID="Label5" runat="server" Text="Peso"></asp:Label>
                <asp:TextBox ID="txtpeso" runat="server"></asp:TextBox>
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <asp:Label ID="Label6" runat="server" Text="Cantidad"></asp:Label>
                <asp:TextBox ID="txtcantidad" runat="server"></asp:TextBox>
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <asp:Label ID="Label7" runat="server" Text="Preciofinal"></asp:Label>
                <asp:TextBox ID="txtprecio" runat="server"></asp:TextBox>
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <asp:Label ID="Label8" runat="server" Text="Nota especial"></asp:Label>
&nbsp;<asp:TextBox ID="txtnota" runat="server"></asp:TextBox>
            </p>
            <p>
                <br />
                <asp:Label ID="Label9" runat="server" Text="Numero de pedido"></asp:Label>
                <asp:DropDownList ID="DropDownList2" runat="server">
                </asp:DropDownList>
                <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Cargar Pedidos" />
            </p>
            <p>
                <br />
                <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Agregar Producto" />
            </p>
            <p>&nbsp;Los pedidos los busca por nombre de cliente(Solo nombre)*</p>
            <p>Ingrese el nombre del cliente
                <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Mostrar Los pedidos del cliente" />
            </p>
           </div>
       
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
       
        <p>
            ¿que carnicero atendio el pedido Número
            <asp:DropDownList ID="DropClienteConsulta" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropClienteConsulta_SelectedIndexChanged">
            </asp:DropDownList>
&nbsp;?
            <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="Cargar Pendidos" />
        </p>
        <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
       
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
