using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tienda.Modelo
{
    public partial class Producto
    {
        public int idproducto { get; set; }
        public string cod_producto { get; set; }
        public string nom_producto { get; set; }
        public string desc_producto { get; set; }
        public double precio_producto { get; set; }
        public int cant_producto { get; set; }
        public string img_producto { get; set; } 
    }
}
