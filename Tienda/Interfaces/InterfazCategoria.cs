using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Modelo;

namespace Tienda.Interfaces
{
    interface InterfazCategoria
    {
        List<Categoria> GetAllCategorias();
        int AñadirCategoria(Categoria categoria);
        int UpdateCategoria(Categoria categoria);
        Categoria GetCategoriaData(int idcategoria);
        string DeleteCategoria(int idcategoria);
    }
}
