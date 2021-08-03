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
            Carnicero objcarnicero = new Carnicero
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
    }
}