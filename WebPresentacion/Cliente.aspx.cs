using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AccessData;
using Entidades;
using LogicadeNegocios;

namespace WebPresentacion
{
    public partial class Cliente : System.Web.UI.Page
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
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //obj de carnicero de capa entidades
            EntCliente objclient = new EntCliente
            {
                name = TextBox1.Text,
                ApP = TextBox2.Text,
                ApM = TextBox3.Text,
                Cel = TextBox5.Text,
                Correo = TextBox4.Text
            };

            string smsref = "";
            obj.InsertarCliente(objclient, ref smsref);
            TextBox1.Text = smsref;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string res = "";
            GridView1.DataSource = obj.showClients(ref res);
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = GridView1.Rows[GridView1.SelectedIndex].Cells[2].Text;
            TextBox2.Text = GridView1.Rows[GridView1.SelectedIndex].Cells[3].Text;
            TextBox3.Text = GridView1.Rows[GridView1.SelectedIndex].Cells[4].Text;
            TextBox5.Text = GridView1.Rows[GridView1.SelectedIndex].Cells[5].Text;
            TextBox4.Text = GridView1.Rows[GridView1.SelectedIndex].Cells[6].Text;
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            EntCliente objclient = new EntCliente
            {
                name = TextBox1.Text,
                ApP = TextBox2.Text,
                ApM = TextBox3.Text,
                Cel = TextBox5.Text,
                Correo = TextBox4.Text,
                idclient = Convert.ToInt16(GridView1.Rows[GridView1.SelectedIndex].Cells[1].Text),
            };

            string smsref = "";
            obj.ActualizarCliente(objclient, ref smsref);
            TextBox1.Text = smsref;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            EntCliente objclient = new EntCliente
            {
                idclient = Convert.ToInt16(GridView1.Rows[GridView1.SelectedIndex].Cells[1].Text),
            };

            string smsref = "";
            obj.EliminarCliente(objclient, ref smsref);
            TextBox1.Text = smsref;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
    }
}