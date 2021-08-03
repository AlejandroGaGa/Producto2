using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        public DateTime FechaHra { get; set; }
        public int F_cliente { get; set; }
        public int F_Carnicero { get; set; }
        public int Envio { get; set; }
        public string Pago { get; set; }
    }
}
