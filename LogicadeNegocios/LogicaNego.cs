using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoaDatos;

namespace LogicadeNegocios
{
    public class LogicaNego
    {
        PedidosCarniceriaEntities obj = new PedidosCarniceriaEntities();

        public string insertarCarnicero(string name, string cel, string email, short anos)
        {
            string res = "";
            if (name != "" && cel != "" && email != "" && anos != 0)
            {
                obj.InsertCarn(name, cel, email, anos);
                res = "Se inserto correctamente";
            }
            return res;

        }
    }// fin de logica de negocio
}// fin de namespace
