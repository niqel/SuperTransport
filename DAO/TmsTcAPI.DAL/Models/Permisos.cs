using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class Permisos
    {
        public Permisos()
        {
            InverseIdPermisoRefNavigation = new HashSet<Permisos>();
            RolesPermisos = new HashSet<RolesPermisos>();
        }

        public int Id { get; set; }
        public int IdFuncionalidad { get; set; }
        public int? R { get; set; }
        public int? W { get; set; }
        public int? X { get; set; }
        public int? IdPermisoRef { get; set; }
        public bool? Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Usuarios CreatedByNavigation { get; set; }
        public virtual Funcionalidad IdFuncionalidadNavigation { get; set; }
        public virtual Permisos IdPermisoRefNavigation { get; set; }
        public virtual Usuarios UpdatedByNavigation { get; set; }
        public virtual ICollection<Permisos> InverseIdPermisoRefNavigation { get; set; }
        public virtual ICollection<RolesPermisos> RolesPermisos { get; set; }
    }
}
