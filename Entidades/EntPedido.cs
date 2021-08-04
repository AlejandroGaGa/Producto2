using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntPedido
    {
        public int id { get; set; }
        public DateTime FechaHra { get; set; }
        public int F_cliente { get; set; }
        public int F_Carnicero { get; set; }
        public Boolean Envio { get; set; }
        public string Pago { get; set; }
     

    }
}
