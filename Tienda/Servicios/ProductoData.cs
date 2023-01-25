using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Modelo;
using Microsoft.EntityFrameworkCore;
using EntityState = Microsoft.EntityFrameworkCore.EntityState;

namespace Tienda.Servicios
{
    public class ProductoData : InterfazProducto
    {
        readonly ContextoProductoDB _dbContext;

        public ProductoData(ContextoProductoDB dbContext)
        {
            this._dbContext = dbContext;
        }
        public int UpdateProducto(Producto producto)
        {
            try
            {
                Producto oldDataProducto = GetProductoData(producto.idproducto);

                if (oldDataProducto.nom_producto != null)
                {
                    if (producto.nom_producto == null)
                    {
                        producto.nom_producto = oldDataProducto.nom_producto;
                    }
                }

                _dbContext.Entry(producto).State = EntityState.Modified;
                _dbContext.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        public Producto GetProductoData(int idproducto)
        {
            try
            {
                Producto producto = _dbContext.Producto.FirstOrDefault(x => x.idproducto == idproducto);
                if (producto != null)
                {
                    _dbContext.Entry(producto).State = EntityState.Detached;
                    return producto;
                }
                return null;
            }
            catch
            {
                throw;
            }
        }

        public string DeleteProducto(int idproducto)
        {
            try
            {
                Producto producto = _dbContext.Producto.Find(idproducto);
                _dbContext.Producto.Remove(producto);
                _dbContext.SaveChanges();

                return (producto.nom_producto);
            }
            catch
            {
                throw;
            }
        }

        public List<Producto> GetAllProductos()
        {
            try
            {
                return _dbContext.Producto.ToList();
            }
            catch
            {
                throw;
            }
        }

        public int AñadirProducto(Producto producto)
        {
            try
            {
                _dbContext.Producto.Add(producto);
                _dbContext.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        public List<Categoria> GetCategorias()
        {
            List<Categoria> lstCategories = new List<Categoria>();
            lstCategories = (from CategoriesList in _dbContext.Categoria select CategoriesList).ToList();

            return lstCategories;
        }
    }
}