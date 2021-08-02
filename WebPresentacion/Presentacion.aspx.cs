using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicadeNegocios;

namespace WebPresentacion
{
    public partial class Presentacion : System.Web.UI.Page
    {
        LogicaNego obj = new LogicaNego();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          Label1.Text =  obj.insertarCarnicero(TextBox1.Text, TextBox2.Text, TextBox3.Text, Convert.ToInt16(TextBox4.Text));
        }
    }
}