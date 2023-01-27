using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Modelo;

namespace Tienda.Interfaces
{
    interface InterfazListaDeseos
    {
        List<ListaDeseos> GetAllListaDeseos();
        int AñadirListaDeseos(ListaDeseos listaDeseos);
        int UpdateListaDeseos(ListaDeseos listaDeseos);
        ListaDeseos GetListaDeseosData(int idListaDeseos);
        string DeleteListaDeseos(int idListaDeseos);
    }
}
