using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Interfaces;
using Tienda.Modelo;

namespace Tienda.Servicios
{
    public class ListaDeseosData : InterfazListaDeseos
    {
        readonly ContextoProductoDB _dbContext;

        public ListaDeseosData(ContextoProductoDB dbContext)
        {
            this._dbContext = dbContext;
        }

        public int AñadirListaDeseos(ListaDeseos listaDeseos)
        {
            try
            {
                _dbContext.ListaDeseos.Add(listaDeseos);
                _dbContext.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        public string DeleteListaDeseos(int idListaDeseos)
        {
            try
            {
                ListaDeseos listaDeseos = _dbContext.ListaDeseos.Find(idListaDeseos);
                _dbContext.ListaDeseos.Remove(listaDeseos);
                _dbContext.SaveChanges();

                return (listaDeseos.idListaDeseos);
            }
            catch
            {
                throw;
            }
        }

        public List<ListaDeseos> GetAllListaDeseos()
        {
            try
            {
                return _dbContext.ListaDeseos.ToList();
            }
            catch
            {
                throw;
            }
        }

        public ListaDeseos GetListaDeseosData(int idListaDeseos)
        {
            try
            {
                ListaDeseos listaDeseos = _dbContext.ListaDeseos.FirstOrDefault(x => Int32.Parse(x.idListaDeseos) == idListaDeseos);
                if (listaDeseos != null)
                {
                    _dbContext.Entry(listaDeseos).State = EntityState.Detached;
                    return listaDeseos;
                }
                return null;
            }
            catch
            {
                throw;
            }
        }

        public int UpdateListaDeseos(ListaDeseos listaDeseos)
        {
            try
            {
                ListaDeseos oldDataListaDeseos = GetListaDeseosData(Int32.Parse(listaDeseos.idListaDeseos));

                if (oldDataListaDeseos.idListaDeseos != null)
                {
                    if (listaDeseos.idListaDeseos == null)
                    {
                        listaDeseos.idListaDeseos = oldDataListaDeseos.idListaDeseos;
                    }
                }

                _dbContext.Entry(listaDeseos).State = EntityState.Modified;
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
