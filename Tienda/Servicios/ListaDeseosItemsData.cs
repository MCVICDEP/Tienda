using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Interfaces;
using Tienda.Modelo;

namespace Tienda.Servicios
{
    public class ListaDeseosItemsData : InterfazListaDeseosItems
    {
        readonly ContextoProductoDB _dbContext;

        public ListaDeseosItemsData(ContextoProductoDB dbContext)
        {
            this._dbContext = dbContext;
        }
        public int AñadirListaDeseosItems(ListaDeseosItems listaDeseosItems)
        {
            try
            {
                _dbContext.ListaDeseosItems.Add(listaDeseosItems);
                _dbContext.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        public string DeleteListaDeseosItems(int idListaDeItem)
        {
            try
            {
                ListaDeseosItems listaDeseosItems = _dbContext.ListaDeseosItems.Find(idListaDeItem);
                _dbContext.ListaDeseosItems.Remove(listaDeseosItems);
                _dbContext.SaveChanges();

                return (listaDeseosItems.idListaDeseos);
            }
            catch
            {
                throw;
            }
        }

        public List<ListaDeseosItems> GetAllListaDeseosItems()
        {
            try
            {
                return _dbContext.ListaDeseosItems.ToList();
            }
            catch
            {
                throw;
            }
        }

        public ListaDeseosItems GetListaDeseosItemsData(int idListaDeItem)
        {
            try
            {
                ListaDeseosItems listaDeseosItems = _dbContext.ListaDeseosItems.FirstOrDefault(x => x.idListaDeItem == idListaDeItem);
                if (listaDeseosItems!= null)
                {
                    _dbContext.Entry(idListaDeItem).State = EntityState.Detached;
                    return listaDeseosItems;
                }
                return null;
            }
            catch
            {
                throw;
            }
        }

        public int UpdateListaDeseosItems(ListaDeseosItems listaDeseosItems)
        {
            try
            {
                ListaDeseosItems oldDataListaDeseosItems = GetListaDeseosItemsData(listaDeseosItems.idListaDeItem);

                if (oldDataListaDeseosItems.idListaDeItem != null)
                {
                    if (listaDeseosItems.idListaDeItem == null)
                    {
                        listaDeseosItems.idListaDeItem = oldDataListaDeseosItems.idListaDeItem;
                    }
                }

                _dbContext.Entry(listaDeseosItems).State = EntityState.Modified;
                _dbContext.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }
    }
}
