using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Modelo;

namespace Tienda.Interfaces
{
    interface InterfazTipoUsuario
    {
        List<TipoUsuario> GetAllTipoUsuario();
        int AñadirTipoUsuario(TipoUsuario tipousuario);
        int UpdateTipoUsuario(TipoUsuario tipousuario);
        TipoUsuario GetTipoUsuarioData(int idTipoUsuario);
        string DeleteTipoUsuario(int idTipoUsuario);
    
    }
}
