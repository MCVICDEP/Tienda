using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Interfaces;
using Tienda.Modelo;

namespace Tienda.Servicios
{
    public class CategoriaData : InterfazCategoria
    {
        readonly ContextoProductoDB _dbContext;

        public CategoriaData(ContextoProductoDB dbContext)
        {
            this._dbContext = dbContext;
        }

        public int AñadirCategoria(Categoria categoria)
        {
            try
            {
                _dbContext.Categoria.Add(categoria);
                _dbContext.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        public string DeleteCategoria(int idcategoria)
        {
            try
            {
                Categoria categoria = _dbContext.Categoria.Find(idcategoria);
                _dbContext.Categoria.Remove(categoria);
                _dbContext.SaveChanges();

                return (categoria.nombreCategoria);
            }
            catch
            {
                throw;
            }
        }

        public List<Categoria> GetAllCategorias()
        {
            try
            {
                return _dbContext.Categoria.ToList();
            }
            catch
            {
                throw;
            }
        }

        public Categoria GetCategoriaData(int idcategoria)
        {
            try
            {
                Categoria categoria = _dbContext.Categoria.FirstOrDefault(x => x.idCategoria == idcategoria);
                if (categoria != null)
                {
                    _dbContext.Entry(categoria).State = EntityState.Detached;
                    return categoria;
                }
                return null;
            }
            catch
            {
                throw;
            }
        }

        public int UpdateCategoria(Categoria categoria)
        {
            try
            {
                Categoria oldDataCategoria = GetCategoriaData(categoria.idCategoria);

                if (oldDataCategoria.idCategoria != null)
                {
                    if (categoria.idCategoria == null)
                    {
                        categoria.idCategoria = oldDataCategoria.idCategoria;
                    }
                }

                _dbContext.Entry(categoria).State = EntityState.Modified;
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
