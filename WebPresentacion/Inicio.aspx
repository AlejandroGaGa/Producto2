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
        <img src="../Imag/carne.png" ><h1>Caniceria AGI</h1> 
        <div style="flex-direction:row">
         <asp:Button ID="Button13" class="btn btn-danger" runat="server" OnClick="Button12_Click" Text="REPARTIDOR"  BorderColor="#FFD5D5" BorderStyle="Double" />
             <asp:Button ID="Button14" class="btn btn-danger" runat="server" Text="CARNICERO" OnClick="Button1_Click"  BorderColor="#FFD5D5" BorderStyle="Double" />
             <asp:Button ID="Button15" class="btn btn-danger" runat="server" Text="CLIENTE" OnClick="Button2_Click" BorderColor="#FFD5D5" BorderStyle="Double" />
            </div>
    </div>
    </header>
    <Center>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <div class="container">
            
            <div class="a col-xs-12 col-sm-8 col-md-4 col-lg-4">
            <asp:Label ID="Label1" runat="server" Text="Creaciones de pedidos" Font-Size="XX-Large"></asp:Label>
             <h6>* Deberas ingresar todos estos datos para crear el pedido</h6>
                <h6>* Antes de usar los dropdownlist deberar recargarlos</h6>
                <h6>* Deberas crear primero el pedido y despues asignarle un producto</h6>
                <h4>
            
        </div>
            

        <div class="container">
            <div class="a col-xs-12 col-sm-8 col-md-4 col-lg-4">
                <br />
                
                            <p>Seleccionar un Carnicero*</p> 
            <asp:DropDownList ID="DropDownList1" class="btn btn-secondary dropdown-toggle" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                <asp:Button ID="Button9"  class="btn btn-danger" runat="server" OnClick="Button9_Click" Text="CargarCarniceros"  BorderColor="#FFD5D5" BorderStyle="Double" />
                    <br />
            <asp:Label ID="lbCarn" runat="server"></asp:Label><br />
            <p>Seleccionar cliente*</p> 
            <asp:DropDownList ID="dplClient" class="btn btn-secondary dropdown-toggle" runat="server" OnSelectedIndexChanged="dplClient_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            <asp:Button ID="Button10" class="btn btn-danger" runat="server" OnClick="Button10_Click" Text="Cargar Clientes"  BorderColor="#FFD5D5" BorderStyle="Double" />
            <br />
            <asp:Label ID="lbClient" runat="server" Text="Label"></asp:Label>
            <br />
            <p>Pedido Aceptado - En espera*</p>
            <p>
                <asp:DropDownList ID="DropEnespera" class="btn btn-secondary dropdown-toggle" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropEnespera_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:Button ID="Button8" class="btn btn-danger" runat="server" OnClick="Button8_Click" Text="Cargar"  BorderColor="#FFD5D5" BorderStyle="Double" />
            </p>
            <p>
                <asp:Label ID="lbTrue" runat="server" Text="Label"></asp:Label>
            </p>
            </div>
        </div>



        <div class="container">
            <div class="a col-xs-12 col-sm-8 col-md-4 col-lg-4">
            <p>Monto a cobrar*</p>
            <p>
                <span class="input-group-text" id="inputGroup-sizing-lg">Monto a cobrar</span>
                <asp:TextBox ID="TextBox2" class="form-control" aria-describedby="inputGroup-sizing-lg" runat="server"></asp:TextBox>
            </p>
            </div>
        </div>


        <div class="container">
            <div class="a col-xs-12 col-sm-8 col-md-4 col-lg-4">
            <p>
                <asp:Button ID="Button3" class="btn btn-success" runat="server" OnClick="Button3_Click" Text="Crear Pedido"  BorderColor="#FFD5D5" BorderStyle="Double" />
                <asp:Button ID="Button4" class="btn btn-danger"  runat="server" OnClick="Button4_Click" Text="Mostrar Pedidos"  BorderColor="#FFD5D5" BorderStyle="Double" />
            </p>
            <p>
                 <span class="input-group-text" id="inputGroup-sizing-lg">Ingrese el producto</span>
                <asp:TextBox ID="txtprod" class="form-control" aria-describedby="inputGroup-sizing-lg" runat="server"></asp:TextBox>
                <br />
               <br />
                <span class="input-group-text" id="inputGroup-sizing-lg">Peso</span>
                <asp:TextBox ID="txtpeso" class="form-control" aria-describedby="inputGroup-sizing-lg" runat="server"></asp:TextBox>
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <span class="input-group-text" id="inputGroup-sizing-lg">Cantidad</span>
                <asp:TextBox ID="txtcantidad" class="form-control" aria-describedby="inputGroup-sizing-lg" runat="server"></asp:TextBox>
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <span class="input-group-text" id="inputGroup-sizing-lg">Precio final</span>
                <asp:TextBox ID="txtprecio" class="form-control" aria-describedby="inputGroup-sizing-lg" runat="server"></asp:TextBox>
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <span class="input-group-text" id="inputGroup-sizing-lg">Nota especial</span>
&nbsp;<asp:TextBox ID="txtnota" class="form-control" aria-describedby="inputGroup-sizing-lg" runat="server"></asp:TextBox>
            </p>
            <p>
                <br />
                <asp:Label ID="Label9" runat="server" Text="Numero de pedido: "></asp:Label>
                <asp:DropDownList ID="DropDownList2" class="btn btn-secondary dropdown-toggle" runat="server">
                </asp:DropDownList>
            </p>
            <p>
                <asp:Button ID="Button7" class="btn btn-danger" runat="server" OnClick="Button7_Click" Text="Cargar Pedidos"  BorderColor="#FFD5D5" BorderStyle="Double" />
            </p>
            <p>
                <br />
                <asp:Button ID="Button6" class="btn btn-success" runat="server" OnClick="Button6_Click" Text="Agregar Producto"  BorderColor="#FFD5D5" BorderStyle="Double" />
            </p>
                </div>
            </div>


            <div class="container">
                <div class="a col-xs-12 col-sm-12 col-md-12 col-lg-12">
            <h4>Los pedidos los busca por nombre de cliente(Solo nombre)*</h4>
            <p>Ingrese el nombre del cliente: 
                <asp:TextBox ID="txtname" class="form-control" aria-describedby="inputGroup-sizing-lg" runat="server"></asp:TextBox> <br />

                <asp:Button ID="Button5" class="btn btn-danger" runat="server" OnClick="Button5_Click" Text="Mostrar Los pedidos del cliente"  BorderColor="#FFD5D5" BorderStyle="Double" />
            </p>
           
       
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#E68282" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
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
                    </div>
        </div>
       

        <div class="container">
                <div class="a col-xs-12 col-sm-12 col-md-12 col-lg-12">
        <p>
            ¿Qué carnicero atendio el pedido Número
            <asp:DropDownList ID="DropClienteConsulta" class="btn btn-secondary dropdown-toggle" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropClienteConsulta_SelectedIndexChanged">
            </asp:DropDownList>
&nbsp;?
            <br />

            <asp:Button ID="Button11" class="btn btn-danger" runat="server" OnClick="Button11_Click" Text="Cargar Pendidos" BorderColor="#FFD5D5" BorderStyle="Double" />
        </p>
        <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#E68282" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
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
       </div>
    </div>
       
    </form>
     </Center>
    <p>
        &nbsp;</p>
    <!-- Footer -->
<footer class="text-center text-lg-start bg-light text-muted">
  <!-- Section: Social media -->
  <section
    class="d-flex justify-content-center justify-content-lg-between p-4 border-bottom"
  >
    <!-- Left -->
    <div class="me-5 d-none d-lg-block">
      <span>Elaborado por Alejandro, Itzel y Guillermo </span>
    </div>
    <!-- Left -->


  <!-- Copyright -->
  <div class="text-center p-4" style="background-color: rgba(0, 0, 0, 0.05);">
    © 2021 Copyright
    
  </div>
  <!-- Copyright -->
</footer>
<!-- Footer -->
    
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-U1DAWAznBHeqEIlVSCgzq+c9gqGAJn5c/t99JyeKa9xxaYpSvHU5awsuZVVFIhvj" crossorigin="anonymous"></script>
    <script src="http://code.jquery.com/jquery-latest.js"></script>
</body>
</html>
