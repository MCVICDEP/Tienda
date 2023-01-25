using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Modelo;

namespace Tienda.Interfaces
{
    public class InterfazUsuario
    {
        List<Usuario> GetAllUsuarios();
        int AñadirProducto(Producto producto);
        int UpdateProducto(Producto producto);
        Producto GetProductoData(int idproducto);
        string DeleteProducto(int idproducto);
        List<Categoria> GetCategorias();
    }
}
