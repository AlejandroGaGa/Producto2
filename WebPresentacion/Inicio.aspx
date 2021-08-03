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
             <div>
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
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
           </div>

        
        <div>
           <p>Seleccionar cliente*</p> 
        <asp:DropDownList ID="dplClient" runat="server"></asp:DropDownList>
           </div>
       
    </form>
</body>
</html>
