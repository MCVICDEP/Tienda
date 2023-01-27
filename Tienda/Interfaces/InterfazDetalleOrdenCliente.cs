using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Modelo;

namespace Tienda.Interfaces
{
    interface InterfazDetalleOrdenCliente
    {
        List<DetalleOrdenCliente> GetAllDetalleOrdenCliente();
        int AñadirDetalleOrdenCliente(DetalleOrdenCliente carrito);
        int UpdateDetalleOrdenCliente(DetalleOrdenCliente carrito);
        DetalleOrdenCliente GetDetalleOrdenClienteData(int idcarrito);
        string DeleteDetalleOrdenCliente(int idcarrito);
    }
}
