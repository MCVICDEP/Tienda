using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tienda.Modelo
{
    public partial class OrdenCliente
    {
        public string idOrden { get; set; }
        public int idUsuario { get; set; }
        public DateTime fechaCreaciom { get; set; }
        public decimal totalCarrito { get; set; }
    }
}
