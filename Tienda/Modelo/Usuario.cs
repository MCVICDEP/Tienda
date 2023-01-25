using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tienda.Modelo
{
    public partial class Usuario
    {
        public int idUsuario { get; set; }
        public string dniUsuario { get; set; }
        public string nombresUsuario { get; set; }
        public string correoUsuario { get; set; }
        public string passwordUsuario { get; set; }
        public string celular { get; set; }
        public int rolUsuario { get; set; }
        public DateTime fechaCreacion { get; set; }
        public string region { get; set; }


    }
}
