using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Modelo;

namespace Tienda.Interfaces
{
    interface InterfazUsuario
    {
        List<Usuario> GetAllUsuarios();
        int Addusuario(Usuario usuario);
        int UpdateUsuario(Usuario usuario);
        Usuario GetUsuarioData(int idusuario);
        string DeleteUsuario(int idusuario);
        List<TipoUsuario> GetTipoUsuario();

    }
}
