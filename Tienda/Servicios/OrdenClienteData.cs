using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Interfaces;
using Tienda.Modelo;

namespace Tienda.Servicios
{
    public class OrdenClienteData : InterfazOrdenCliente
    {
        readonly ContextoProductoDB _dbContext;

        public OrdenClienteData(ContextoProductoDB dbContext)
        {
            this._dbContext = dbContext;
        }

        public int AñadirOrdenCliente(OrdenCliente ordenCliente)
        {
            try
            {
                _dbContext.OrdenCliente.Add(ordenCliente);
                _dbContext.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        public string DeleteOrdenCliente(int idOrden)
        {
            try
            {
                OrdenCliente ordenCliente = _dbContext.OrdenCliente.Find(idOrden);
                _dbContext.OrdenCliente.Remove(ordenCliente);
                _dbContext.SaveChanges();

                return (ordenCliente.idOrden);
            }
            catch
            {
                throw;
            }
        }

        public List<OrdenCliente> GetAllOrdenCliente()
        {
            try
            {
                return _dbContext.OrdenCliente.ToList();
            }
            catch
            {
                throw;
            }
        }

        public OrdenCliente GetOrdenClienteData(int idOrden)
        {
            try
            {
                OrdenCliente ordenCliente = _dbContext.OrdenCliente.FirstOrDefault(x => idOrden == idOrden);
                if (ordenCliente != null)
                {
                    _dbContext.Entry(ordenCliente).State = EntityState.Detached;
                    return ordenCliente;
                }
                return null;
            }
            catch
            {
                throw;
            }
        }

        public int UpdateOrdenCliente(OrdenCliente ordenCliente)
        {
            try
            {
                OrdenCliente oldDataOrdenCliente = GetOrdenClienteData(Int32.Parse(ordenCliente.idOrden));

                if (oldDataOrdenCliente.idOrden != null)
                {
                    if (ordenCliente.idOrden == null)
                    {
                        ordenCliente.idOrden = oldDataOrdenCliente.idOrden;
                    }
                }

                _dbContext.Entry(ordenCliente).State = EntityState.Modified;
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
    