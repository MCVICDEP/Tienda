using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tienda.Modelo
{
    public partial class Politicas
    {
        //POLITICAS DE ADMINISTRADOR
        public static AuthorizationPolicy PoliticaAdministrador()
        {
            return new AuthorizationPolicyBuilder().RequireAuthenticatedUser().RequireRole(RolUsuario.Administrador).Build();
        }

        //POLITICAS DE USUARIO
        public static AuthorizationPolicy PoliticaUsuario()
        {
            return new AuthorizationPolicyBuilder().RequireAuthenticatedUser().RequireRole(RolUsuario.Cliente).Build();
        }
    }
}
