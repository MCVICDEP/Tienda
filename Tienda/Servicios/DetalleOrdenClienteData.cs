using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Modelo;
using Microsoft.EntityFrameworkCore;
using EntityState = Microsoft.EntityFrameworkCore.EntityState;
using Tienda.Interfaces;

namespace Tienda.Servicios
{
    public class DetalleOrdenClienteData : InterfazDetalleOrdenCliente
    {
        readonly ContextoProductoDB _dbContext;

        public DetalleOrdenClienteData(ContextoProductoDB dbContext)
        {
            this._dbContext = dbContext;
        }
        public int UpdateDetalleOrdenCliente(DetalleOrdenCliente detalleordencliente)
        {
            try
            {
                DetalleOrdenCliente oldDataDetalleOrdenCliente = GetDetalleOrdenClienteData(detalleordencliente.idDetalleOrden);

                if (oldDataDetalleOrdenCliente.idDetalleOrden != null)
                {
                    if (detalleordencliente.idDetalleOrden == null)
                    {
                        detalleordencliente.idDetalleOrden = oldDataDetalleOrdenCliente.idDetalleOrden;
                    }
                }

                _dbContext.Entry(detalleordencliente).State = EntityState.Modified;
                _dbContext.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        public DetalleOrdenCliente GetDetalleOrdenClienteData(int idDetalleOrden)
        {
            try
            {
                DetalleOrdenCliente detalleordencliente = _dbContext.DetalleOrdenCliente.FirstOrDefault(x => x.idDetalleOrden == idDetalleOrden);
                if (detalleordencliente != null)
                {
                    _dbContext.Entry(detalleordencliente).State = EntityState.Detached;
                    return detalleordencliente;
                }
                return null;
            }
            catch
            {
                throw;
            }
        }

        public string DeleteDetalleOrdenCliente(int idDetalleOrden)
        {
            try
            {
                DetalleOrdenCliente detalleordencliente = _dbContext.DetalleOrdenCliente.Find(idDetalleOrden);
                _dbContext.DetalleOrdenCliente.Remove(detalleordencliente);
                _dbContext.SaveChanges();

                return (detalleordencliente.idOrden);
            }
            catch
            {
                throw;
            }
        }

        public List<DetalleOrdenCliente> GetAllDetalleOrdenCliente()
        {
            try
            {
                return _dbContext.DetalleOrdenCliente.ToList();
            }
            catch
            {
                throw;
            }
        }

        public int AñadirDetalleOrdenCliente(DetalleOrdenCliente detalleOrdenCliente)
        {
            try
            {
                _dbContext.DetalleOrdenCliente.Add(detalleOrdenCliente);
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