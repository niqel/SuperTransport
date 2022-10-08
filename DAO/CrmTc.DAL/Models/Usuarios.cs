using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Cotizacion = new HashSet<Cotizacion>();
            UsuariosRoles = new HashSet<UsuariosRoles>();
        }

        public int Id { get; set; }
        public int IdActiveDirectory { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Email { get; set; }
        public string SesionToken { get; set; }
        public DateTime? SesionFechaHora { get; set; }
        public int? SesionMinutos { get; set; }
        public byte[] Imagen { get; set; }
        public DateTime? FechaCreacionSesion { get; set; }
        public DateTime? FechaUltimaActividadSesion { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }

        public virtual ICollection<Cotizacion> Cotizacion { get; set; }
        public virtual ICollection<UsuariosRoles> UsuariosRoles { get; set; }
    }
}
