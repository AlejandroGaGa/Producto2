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
        protected void Page_Load(object sender, EventArgs e)
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
                        dplClient.Items.Add(new ListItem(cliente.name + " " + cliente.ApP + " " + cliente.ApM + " " ));
                    }
                }
            }
            catch (Exception error)
            {
                Label1.Text = "Hubo un error" + error;

            }

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
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Carnicero.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cliente.aspx");
        }
    }
}