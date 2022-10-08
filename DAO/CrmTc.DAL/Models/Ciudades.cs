using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class Ciudades
    {
        public Ciudades()
        {
            Destinos = new HashSet<Destinos>();
            Oficinas = new HashSet<Oficinas>();
            Origenes = new HashSet<Origenes>();
            Paradas = new HashSet<Paradas>();
            PuntosEntrega = new HashSet<PuntosEntrega>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Municipiosid { get; set; }
        public int? IdZona { get; set; }
        public bool? Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Zonas IdZonaNavigation { get; set; }
        public virtual Municipios Municipios { get; set; }
        public virtual ICollection<Destinos> Destinos { get; set; }
        public virtual ICollection<Oficinas> Oficinas { get; set; }
        public virtual ICollection<Origenes> Origenes { get; set; }
        public virtual ICollection<Paradas> Paradas { get; set; }
        public virtual ICollection<PuntosEntrega> PuntosEntrega { get; set; }
    }
}
