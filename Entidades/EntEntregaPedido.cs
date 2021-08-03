using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntEntregaPedido
    {
        public int F_pedido { get; set; }
        public int F_repartidor { get; set; }
        public DateTime Salida { get; set; }
        public DateTime Entregado { get; set; }
        public string Estado { get; set; }
    }
}
