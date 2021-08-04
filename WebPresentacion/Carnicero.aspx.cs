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
    public partial class Presentacion : System.Web.UI.Page
    {

        // este el el objeto de la capa negocio 
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
            EntCarnicero objcarnicero = new EntCarnicero
            {
                name = TextBox1.Text,
                cel = TextBox2.Text,
                email = TextBox3.Text,
                exp = Convert.ToInt16(TextBox4.Text)
            };

            string smsref = "";
            obj.InsertarCarnicero(objcarnicero, ref smsref);
            TextBox1.Text = smsref;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string res = "";
          GridView1.DataSource = obj.showCarnicero(ref res);

            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text =  GridView1.Rows[GridView1.SelectedIndex].Cells[2].Text;
            TextBox2.Text = GridView1.Rows[GridView1.SelectedIndex].Cells[3].Text;
            TextBox3.Text = GridView1.Rows[GridView1.SelectedIndex].Cells[4].Text;
            TextBox4.Text = GridView1.Rows[GridView1.SelectedIndex].Cells[5].Text;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            EntCarnicero objcarnicero = new EntCarnicero
            {
             
                name = TextBox1.Text,
                cel = TextBox2.Text,
                email = TextBox3.Text,
                exp = Convert.ToInt16(TextBox4.Text),
                idcarn = Convert.ToInt16(GridView1.Rows[GridView1.SelectedIndex].Cells[1].Text),


            };

            string smsref = "";
            obj.ActualizarCarnicero(objcarnicero, ref smsref);
            TextBox1.Text = smsref;
           
        }
    }
}