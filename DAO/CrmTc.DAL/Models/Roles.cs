using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class Roles
    {
        public Roles()
        {
            RolesPermisos = new HashSet<RolesPermisos>();
            UsuariosRoles = new HashSet<UsuariosRoles>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string IdActiveDirectory { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<RolesPermisos> RolesPermisos { get; set; }
        public virtual ICollection<UsuariosRoles> UsuariosRoles { get; set; }
    }
}
