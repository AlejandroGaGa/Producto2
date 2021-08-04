using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using LogicadeNegocios;


namespace WebPresentacion
{
    public partial class Inicio : System.Web.UI.Page
    {
    
        LogicaNego obj = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                obj = new LogicaNego();
                Session["obj"] = obj;
            }
            else
            {
                obj = (LogicaNego)Session["obj"];
            }


          

            //obtener nombredeclientes
          



            //lleno drop para seleccionar activo o no
            //ListItem i;
            //i = new ListItem("Aceptado", "1");
            //DropEnespera.Items.Add(i);
            //i = new ListItem("En proceso", "2");
            //DropEnespera.Items.Add(i);

           


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Carnicero.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cliente.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //obj de carnicero de capa entidades
            DateTime fecha = DateTime.Now;
            bool envio = false;
            if (DropEnespera.SelectedIndex + 1 != 0) {
                envio = true;
            }

            EntPedido objPEDIDO = new EntPedido
            {

                FechaHra = fecha,
                F_cliente = dplClient.SelectedIndex + 1,
                F_Carnicero = DropDownList1.SelectedIndex + 1,
                Envio = envio,
                Pago = TextBox2.Text



            };



            string smsref = "";
            obj.InsertarPedido(objPEDIDO, ref smsref);
            TextBox2.Text = smsref;

        }

        protected void dplClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sms = "";
            sms = (dplClient.SelectedIndex).ToString();
            TextBox2.Text = sms;
            lbClient.Text = (dplClient.SelectedIndex + 1).ToString();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sms = "";
            sms =   (DropDownList1.SelectedIndex).ToString();
            TextBox2.Text = sms;
            lbCarn.Text = (DropDownList1.SelectedIndex + 1).ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string sms = "";
            GridView1.DataSource = obj.showPedidos(ref sms);
            GridView1.DataBind();
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string res = "";
            GridView1.DataSource = obj.showPedidosClient(txtname.Text, ref res);
            GridView1.DataBind();
            TextBox2.Text = res;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            EntProducto objprod = new EntProducto
            {
                nameP = txtname.Text,
                Peso = Convert.ToInt16(txtpeso.Text),
                Cantidad = Convert.ToInt16(txtcantidad.Text),
                PrecioF = Convert.ToSingle(txtprecio.Text),
                Nota = txtnota.Text,
                f_pedido = DropDownList2.SelectedIndex + 1,


            };
            string res = "";
            obj.InsertarProducto(objprod, ref res);
            TextBox2.Text = res;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            try
            {
               
                string mensaje = "";
                List<EntPedido> listpedidos = null;

                listpedidos = obj.GetPedidos(ref mensaje);
                if (listpedidos != null)
                {
                    DropDownList2.Items.Clear();
                    foreach (EntPedido pedido in listpedidos)
                    {
                        //+ cliente.Cel + " " + cliente.Correo + " " + Convert.ToInt32(cliente.idclient) Para obtenjmer datos y actualizar mas adelante
                        DropDownList2.Items.Add(new ListItem(pedido.id.ToString()));
                    }
                }
            }
            catch (Exception error)
            {
                Label1.Text = "Hubo un error" + error;

            }
        }

        protected void DropEnespera_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTrue.Text = DropEnespera.SelectedIndex.ToString();

        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            DropEnespera.Items.Clear();
            DropEnespera.Items.Add(new ListItem("En espera", "0"));
            DropEnespera.Items.Add(new ListItem("Aceptado", "1"));
        }

        protected void Button9_Click(object sender, EventArgs e)
        {

            try
            {
                LogicaNego obj = new LogicaNego();
                string mensaje = "";
                List<EntCarnicero> listaCarnicero = null;

                listaCarnicero = obj.GetCarniceros(ref mensaje);
                if (listaCarnicero != null)
                {
                    DropDownList1.Items.Clear();
                    foreach (EntCarnicero Carn in listaCarnicero)
                    {

                        DropDownList1.Items.Add(new ListItem(Carn.name + " ", Carn.idcarn.ToString()));
                    }
                }
            }
            catch (Exception error)
            {
                Label1.Text = "Hubo un error" + error;

            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            try
            {
                LogicaNego obj = new LogicaNego();
                string mensaje = "";
                List<EntCliente> listaClientes = null;

                listaClientes = obj.GetClientes(ref mensaje);
                if (listaClientes != null)
                {
                    dplClient.Items.Clear();
                    foreach (EntCliente cliente in listaClientes)
                    {
                        //+ cliente.Cel + " " + cliente.Correo + " " + Convert.ToInt32(cliente.idclient) Para obtenjmer datos y actualizar mas adelante
                        dplClient.Items.Add(new ListItem(cliente.name + " " + cliente.ApP + " " + cliente.ApM + " ", cliente.idclient.ToString()));
                    }
                }
            }
            catch (Exception error)
            {
                Label1.Text = "Hubo un error" + error;

            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            try
            {

                string mensaje = "";
                List<EntPedido> listpedidos = null;

                listpedidos = obj.GetPedidos(ref mensaje);
                if (listpedidos != null)
                {
                    DropClienteConsulta.Items.Clear();
                    foreach (EntPedido pedido in listpedidos)
                    {
                        //+ cliente.Cel + " " + cliente.Correo + " " + Convert.ToInt32(cliente.idclient) Para obtenjmer datos y actualizar mas adelante
                        DropClienteConsulta.Items.Add(new ListItem(pedido.id.ToString()));
                    }
                }
            }
            catch (Exception error)
            {
                Label1.Text = "Hubo un error" + error;

            }
        }

        protected void DropClienteConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sms = "";
            sms = (DropClienteConsulta.SelectedIndex).ToString();
            TextBox2.Text = sms;
            Label10.Text = (DropClienteConsulta.SelectedIndex + 1).ToString();

            string res = "";
            GridView2.DataSource = obj.showCarniceroProduct(DropClienteConsulta.SelectedIndex + 1, ref res);
            GridView2.DataBind();
            TextBox2.Text = res;


        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Response.Redirect("Delivery.aspx");
        }
    }
}