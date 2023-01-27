using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Interfaces;
using Tienda.Modelo;

namespace Tienda.Servicios
{
    public class CarritoData : InterfazCarrito
    {
        readonly ContextoProductoDB _dbContext;

        public CarritoData(ContextoProductoDB dbContext)
        {
            this._dbContext = dbContext;
        }
        public int AñadirCarrito(Carrito carrito)
        {
            try
            {
                _dbContext.Carrito.Add(carrito);
                _dbContext.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        public string DeleteCarrito(int idcarrito)
        {
            try
            {
                Carrito carrito = _dbContext.Carrito.Find(idcarrito);
                _dbContext.Carrito.Remove(carrito);
                _dbContext.SaveChanges();

                return (carrito.idCarrito);
            }
            catch
            {
                throw;
            }
        }

        public List<Carrito> GetAllCarrito()
        {
            try
            {
                return _dbContext.Carrito.ToList();
            }
            catch
            {
                throw;
            }
        }

        public Carrito GetCarritoData(int idcarrito)
        {
            try
            {
                Carrito carrito = _dbContext.Carrito.FirstOrDefault(x => Int32.Parse(x.idCarrito) == idcarrito);
                if (carrito != null)
                {
                    _dbContext.Entry(carrito).State = EntityState.Detached;
                    return carrito;
                }
                return null;
            }
            catch
            {
                throw;
            }
        }

        public int UpdateCarrito(Carrito carrito)
        {
            try
            {
                Carrito oldDataCarrito = GetCarritoData(Int32.Parse(carrito.idCarrito));

                if (oldDataCarrito.idCarrito != null)
                {
                    if (carrito.idCarrito == null)
                    {
                        carrito.idCarrito = oldDataCarrito.idCarrito;
                    }
                }

                _dbContext.Entry(carrito).State = EntityState.Modified;
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
