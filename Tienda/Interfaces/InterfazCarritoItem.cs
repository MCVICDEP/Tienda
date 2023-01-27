using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Modelo;

namespace Tienda.Interfaces
{
    interface InterfazCarritoItem
    {
        List<CarritoItem> GetAllCarritoItem();
        int AñadirCarritoItem(CarritoItem carritoItem);
        int UpdateCarritoItem(CarritoItem carritoItem);
        CarritoItem GetCarritoItemData(int idcarritoItem);
        string DeleteCarritoItem(int idcarritoItem);
    }

}
