<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="WebPresentacion.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Carniceria AGI</title>
    <link href="Style.css" rel="stylesheet" />
    <link rel="shortcut icon" href="/Imag/carne.png">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KyZXEAg3QhqLMpG8r+8fhAXLRk2vvoC2f3B09zVXn8CA5QIVfZOJ3BCsw2P0p/We" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
    <header>
    <div class="container">
        <h1>Caniceria AGI</h1>
    </div>
    </header>
    
        <div class="container">
            <div class="col-xs-12 col-sm-8 col-md-4 col-lg-4">

            <asp:Label ID="Label1" runat="server" Text="Creaciones de pedidos"></asp:Label>
             <h5>* Deberas ingresar todos estos datos para crear el pedido</h5>
             <asp:Label ID="Label11" runat="server" Text="Registralo si es nuevo en tu carniceria"></asp:Label>
             <br />
                <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="REPARTIDOR" />
                <br />
                <br />
             <asp:Label ID="Label2" runat="server" Text="Registralo si es nuevo en tu carniceria"></asp:Label>
             <br />
             
             <asp:Button ID="Button1" runat="server" Text="CARNICERO" OnClick="Button1_Click" />
                <br />
             <br />
            <h4>
             <asp:Label ID="Label3" runat="server" Text="Registralo si es nuevo en tu carniceria"></asp:Label>
             </h4>
             <asp:Button ID="Button2" runat="server" Text="CLIENTE" OnClick="Button2_Click" />
           </div>
        </div>
            

        <div class="container">
            <div class="col-xs-12 col-sm-8 col-md-4 col-lg-4">
                            <p>Seleccionar un Carnicero*</p> 
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="CargarCarniceros" />
                    <br />
            <asp:Label ID="lbCarn" runat="server"></asp:Label>
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
            </div>
        </div>



        <div class="container">
            <div class="col-xs-12 col-sm-8 col-md-4 col-lg-4">
            <p>Monto a cobrar*</p>
            <p>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </p>
            </div>
        </div>


        <div class="container">
            <div class="col-xs-12 col-sm-8 col-md-4 col-lg-4">
            <p>
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Crear Pedido" />
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Mostrar Pedidos" />
            </p>
            <p>
                <asp:Label ID="Label4" runat="server" Text="Nombre del producto a vender"></asp:Label>
                <asp:TextBox ID="txtprod" runat="server"></asp:TextBox>
                <br />
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
            </p>
            <p>
                <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Cargar Pedidos" />
            </p>
            <p>
                <br />
                <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Agregar Producto" />
            </p>
                </div>
            </div>


            <div class="container">
                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
            <h4>Los pedidos los busca por nombre de cliente(Solo nombre)*</h4>
            <p>Ingrese el nombre del cliente
                <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Mostrar Los pedidos del cliente" />
            </p>
           
       
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
                    </div>
        </div>
       

        <div class="container">
                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
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
       </div>
    </div>
    </form>
    <p>
        &nbsp;</p>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-U1DAWAznBHeqEIlVSCgzq+c9gqGAJn5c/t99JyeKa9xxaYpSvHU5awsuZVVFIhvj" crossorigin="anonymous"></script>
    <script src="http://code.jquery.com/jquery-latest.js"></script>
</body>
</html>
