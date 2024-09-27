using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda
{
    internal class Ticket
    {
        public List<Articulo> Inventario { get; set; }

        public decimal Total { get; set; }

        public decimal Pagado { get; set; }

        public decimal Cambio { get; set; }

        public DateTime Fecha { get; set; }

        public int MyProperty { get; set; }

        public decimal IVA { get; set; }
         


    }   

}
