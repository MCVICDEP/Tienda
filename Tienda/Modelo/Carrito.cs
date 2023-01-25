using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tienda.Modelo
{
    public partial class Carrito
    {
        public string idCarrito { get; set; }
        public int idUsuario { get; set; }
        public DateTime fechaCreacion { get; set; }
    }
}
