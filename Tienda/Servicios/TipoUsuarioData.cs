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
    public class TipoUsuarioData : InterfazTipoUsuario
    {
        readonly ContextoProductoDB _dbContext;

        public TipoUsuarioData(ContextoProductoDB dbContext)
        {
            this._dbContext = dbContext;
        }
        public int UpdateTipoUsuario(TipoUsuario tipousuario)
        {
            try
            {
                TipoUsuario oldDataTipoUsuario = GetTipoUsuarioData(tipousuario.idTipoUsuario); 

                if (oldDataTipoUsuario.nombreTipoUsuario != null)
                {
                    if (tipousuario.nombreTipoUsuario == null)
                    {
                        tipousuario.nombreTipoUsuario = oldDataTipoUsuario.nombreTipoUsuario;
                    }
                }

                _dbContext.Entry(tipousuario).State = EntityState.Modified;
                _dbContext.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        public TipoUsuario GetTipoUsuarioData(int idTipoUsuario)
        {
            try
            {
                TipoUsuario tipousuario = _dbContext.TipoUsuario.FirstOrDefault(x => x.idTipoUsuario == idTipoUsuario);
                if (tipousuario != null)
                {
                    _dbContext.Entry(tipousuario).State = EntityState.Detached;
                    return tipousuario;
                }
                return null;
            }
            catch
            {
                throw;
            }
        }

        public string DeleteTipoUsuario(int idTipoUsuario)
        {
            try
            {
                TipoUsuario tipousuario = _dbContext.TipoUsuario.Find(idTipoUsuario);
                _dbContext.TipoUsuario.Remove(tipousuario);
                _dbContext.SaveChanges();

                return (tipousuario.nombreTipoUsuario);
            }
            catch
            {
                throw;
            }
        }

        public List<TipoUsuario> GetAllTipoUsuario()
        {
            try
            {
                return _dbContext.TipoUsuario.ToList();
            }
            catch
            {
                throw;
            }
        }

        public int AñadirTipoUsuario(TipoUsuario tipousuario)
        {
            try
            {
                _dbContext.TipoUsuario.Add(tipousuario);
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