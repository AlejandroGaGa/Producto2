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
                        dplClient.Items.Add(new ListItem(cliente.name + " " + cliente.ApP + " " + cliente.ApM + " " ));
                    }
                }
            }
            catch (Exception error)
            {
                Label1.Text = "Hubo un error" + error;

            }

            //obtener nombredeclientes
           
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
                       
                        DropDownList1.Items.Add(new ListItem(Carn.name + " " ));
                    }
                }
            }
            catch (Exception error)
            {
                Label1.Text = "Hubo un error" + error;

            }

            //lleno drop para seleccionar activo o no
            ListItem i;
            i = new ListItem("Aceptado", "1");
            Dpnodp.Items.Add(i);
            i = new ListItem("En proceso", "2");
            Dpnodp.Items.Add(i);
   
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

            EntPedido objPEDIDO = new EntPedido
            {
               
                FechaHra = fecha,
                F_cliente = dplClient.SelectedIndex + 1,
                F_Carnicero = DropDownList1.SelectedIndex + 1,
                Envio = Dpnodp.SelectedIndex,
                Pago = TextBox2.Text



            };

            EntProducto objprod = new EntProducto
            {
                nameP = txtname.Text,
                Peso =  Convert.ToInt16(txtpeso.Text),
                Cantidad = Convert.ToInt16(txtcantidad.Text),
                PrecioF = Convert.ToSingle(txtprecio.Text),
                Nota = txtnota.Text,
                f_pedido = Convert.ToInt16(txtNumPedido.Text),


          };

            string smsref = "";
            obj.InsertarPedido(objPEDIDO, ref smsref);
            TextBox2.Text = smsref;
            obj.InsertarProducto(objprod, ref smsref);
            TextBox2.Text = smsref;
        }

        protected void dplClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sms = "";
            sms = (dplClient.SelectedIndex).ToString();
            TextBox2.Text = sms;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sms = "";
         sms =   (DropDownList1.SelectedIndex).ToString();
            TextBox2.Text = sms;

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
    }
}