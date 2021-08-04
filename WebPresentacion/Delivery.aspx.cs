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
    public partial class Delivery : System.Web.UI.Page
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
            EntDelivery objDelicery = new EntDelivery
            {
                name = TextBox1.Text,
                cel = TextBox2.Text,
                Licencia= TextBox3.Text
            
            };

            string smsref = "";
            obj.InsertarRepartidor(objDelicery, ref smsref);
            TextBox1.Text = smsref;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string res = "";
            GridView1.DataSource = obj.showDelivery(ref res);
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            EntDelivery objDel = new EntDelivery
            {
                name = TextBox1.Text,
                cel =TextBox2.Text,
                Licencia = TextBox3.Text
            };

            string smsref = "";
            obj.ActualizarDelivery(objDel, ref smsref);
            TextBox1.Text = smsref;
        }
    }
}