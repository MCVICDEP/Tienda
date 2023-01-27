using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Modelo;

namespace Tienda.Interfaces
{
    interface InterfazOrdenCliente
    {
        List<OrdenCliente> GetAllOrdenCliente();
        int AñadirOrdenCliente(OrdenCliente carrito);
        int UpdateOrdenCliente(OrdenCliente carrito);
        OrdenCliente GetOrdenClienteData(int idcarrito);
        string DeleteOrdenCliente(int idcarrito);
    }
}
