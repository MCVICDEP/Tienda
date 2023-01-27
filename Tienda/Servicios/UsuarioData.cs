using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Interfaces;
using Tienda.Modelo;

namespace Tienda.Servicios
{
    public class UsuarioData : InterfazUsuario
    {
        readonly ContextoProductoDB _dbContext;

        public UsuarioData(ContextoProductoDB dbContext)
        {
            this._dbContext = dbContext;
        }
        public int Addusuario(Usuario usuario)
        {
            try
            {
                _dbContext.Usuario.Add(usuario);
                _dbContext.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        public string DeleteUsuario(int idusuario)
        {
            try
            {
                Usuario usuario = _dbContext.Usuario.Find(idusuario);
                _dbContext.Usuario.Remove(usuario);
                _dbContext.SaveChanges();

                return (usuario.nombresUsuario);
            }
            catch
            {
                throw;
            }
        }

        public List<Usuario> GetAllUsuarios()
        {
            try
            {
                return _dbContext.Usuario.ToList();
            }
            catch
            {
                throw;
            }
        }

        public List<TipoUsuario> GetTipoUsuario()
        {
            List<TipoUsuario> lstTipoUsuario = new List<TipoUsuario>();
            lstTipoUsuario = (from TipoUsuarioLst in _dbContext.TipoUsuario select TipoUsuarioLst).ToList();

            return lstTipoUsuario;
        }

        public Usuario GetUsuarioData(int idusuario)
        {
            try
            {
                Usuario usuario = _dbContext.Usuario.FirstOrDefault(x => x.idUsuario == idusuario);
                if (usuario != null)
                {
                    _dbContext.Entry(usuario).State = EntityState.Detached;
                    return usuario;
                }
                return null;
            }
            catch
            {
                throw;
            }
        }

        public int UpdateUsuario(Usuario usuario)
        {
            try
            {
                Usuario oldDataUsuario = GetUsuarioData(usuario.idUsuario);

                if (oldDataUsuario.nombresUsuario != null)
                {
                    if (usuario.nombresUsuario == null)
                    {
                        usuario.nombresUsuario = oldDataUsuario.nombresUsuario;
                    }
                }

                _dbContext.Entry(usuario).State = EntityState.Modified;
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
