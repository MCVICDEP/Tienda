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
    public class CarritoItemData : InterfazCarritoItem
    {
        readonly ContextoProductoDB _dbContext;

        public CarritoItemData(ContextoProductoDB dbContext)
        {
            this._dbContext = dbContext;
        }
        public int UpdateCarritoItem(CarritoItem carritoitem)
        {
            try
            {
                CarritoItem oldDataCarritoItem = GetCarritoItemData(carritoitem.itemCarritoId);

                if (oldDataCarritoItem.itemCarritoId != null)
                {
                    if (carritoitem.itemCarritoId == null)
                    {
                        carritoitem.itemCarritoId = oldDataCarritoItem.itemCarritoId;
                    }
                }

                _dbContext.Entry(carritoitem).State = EntityState.Modified;
                _dbContext.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        public CarritoItem GetCarritoItemData(int itemCarritoId)
        {
            try
            {
                CarritoItem carritoItem = _dbContext.CarritoItem.FirstOrDefault(x => x.itemCarritoId == itemCarritoId);
                if (carritoItem != null)
                {
                    _dbContext.Entry(carritoItem).State = EntityState.Detached;
                    return carritoItem;
                }
                return null;
            }
            catch
            {
                throw;
            }
        }

        public string DeleteCarritoItem(int itemCarritoId)
        {
            try
            {
                CarritoItem carritoItem = _dbContext.CarritoItem.Find(itemCarritoId);
                _dbContext.CarritoItem.Remove(carritoItem);
                _dbContext.SaveChanges();

                return (carritoItem.idCarrito);
            }
            catch
            {
                throw;
            }
        }

        public List<CarritoItem> GetAllCarritoItem()
        {
            try
            {
                return _dbContext.CarritoItem.ToList();
            }
            catch
            {
                throw;
            }
        }

        public int AñadirCarritoItem(CarritoItem carritoItem)
        {
            try
            {
                _dbContext.CarritoItem.Add(carritoItem);
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