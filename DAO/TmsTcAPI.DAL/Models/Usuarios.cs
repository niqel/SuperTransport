using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            GeneralParametersCreatedByNavigation = new HashSet<GeneralParameters>();
            GeneralParametersHistory = new HashSet<GeneralParametersHistory>();
            GeneralParametersUpdatedByNavigation = new HashSet<GeneralParameters>();
            PermisosCreatedByNavigation = new HashSet<Permisos>();
            PermisosUpdatedByNavigation = new HashSet<Permisos>();
            RolesHistory = new HashSet<RolesHistory>();
            RolesUsuarios = new HashSet<RolesUsuarios>();
        }

        public int Id { get; set; }
        public int IdActiveDirectory { get; set; }
        public string SesionToken { get; set; }
        public DateTime? SesionFechaHora { get; set; }
        public int? SesionMinutos { get; set; }
        public byte[] Imagen { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public string Password { get; set; }
        public int Employeeid { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual ICollection<GeneralParameters> GeneralParametersCreatedByNavigation { get; set; }
        public virtual ICollection<GeneralParametersHistory> GeneralParametersHistory { get; set; }
        public virtual ICollection<GeneralParameters> GeneralParametersUpdatedByNavigation { get; set; }
        public virtual ICollection<Permisos> PermisosCreatedByNavigation { get; set; }
        public virtual ICollection<Permisos> PermisosUpdatedByNavigation { get; set; }
        public virtual ICollection<RolesHistory> RolesHistory { get; set; }
        public virtual ICollection<RolesUsuarios> RolesUsuarios { get; set; }
    }
}
