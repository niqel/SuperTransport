using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class RolesHistory
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string IdActiveDirectory { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Usuarios CreatedByNavigation { get; set; }
        public virtual Roles Role { get; set; }
    }
}
