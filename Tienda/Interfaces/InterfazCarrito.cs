using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Modelo;

namespace Tienda.Interfaces
{
    interface InterfazCarrito
    {
        List<Carrito> GetAllCarrito();
        int AñadirCarrito(Carrito carrito);
        int UpdateCarrito(Carrito carrito);
        Carrito GetCarritoData(int idcarrito);
        string DeleteCarrito(int idcarrito);
    }
}
