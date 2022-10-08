using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class RolesUsuarios
    {
        public int UsuariosId { get; set; }
        public int Rolesid { get; set; }

        public virtual Roles Roles { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
