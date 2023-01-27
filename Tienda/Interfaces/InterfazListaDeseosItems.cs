using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Modelo;

namespace Tienda.Interfaces
{
    interface InterfazListaDeseosItems
    {
        List<ListaDeseosItems> GetAllListaDeseosItems();
        int AñadirListaDeseosItems(ListaDeseosItems listaDeseosItems);
        int UpdateListaDeseosItems(ListaDeseosItems listaDeseosItems);
        ListaDeseosItems GetListaDeseosItemsData(int idListaDeItem);
        string DeleteListaDeseosItems(int idListaDeItem);
    }
}
