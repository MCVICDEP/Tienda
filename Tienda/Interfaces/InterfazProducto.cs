using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Modelo;

namespace Tienda.Servicios
{
    interface InterfazProducto
    {
        List<Producto> GetAllProductos();

        int AñadirProducto(Producto producto);
        int UpdateProducto(Producto producto);
        Producto GetProductoData(int idproducto);
        string DeleteProducto(int idproducto);
        List<Categoria> GetCategorias();
    }
}
