using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class Oficinas
    {
        public Oficinas()
        {
            DistanciasRegresos = new HashSet<DistanciasRegresos>();
            OficinaDisponibilidad = new HashSet<OficinaDisponibilidad>();
            OficinasOperativas = new HashSet<OficinasOperativas>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public bool? EsRegreso { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? HoraLimiteLlegada { get; set; }
        public int? CapacidadMaxTractores { get; set; }
        public DateTime? Calendario { get; set; }
        public double? Geocerca { get; set; }
        public int? IdOficinaZam { get; set; }

        public virtual Ciudades IdOficinaZamNavigation { get; set; }
        public virtual ICollection<DistanciasRegresos> DistanciasRegresos { get; set; }
        public virtual ICollection<OficinaDisponibilidad> OficinaDisponibilidad { get; set; }
        public virtual ICollection<OficinasOperativas> OficinasOperativas { get; set; }
    }
}
