using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tienda.Modelo
{
    public partial class CarritoItem
    {
        public int itemCarritoId { get; set; }
        public string idCarrito { get; set; }
        public int idProducto { get; set; }
        public int cantidad { get; set; }
    }
}
