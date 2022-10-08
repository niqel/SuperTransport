using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class Ciudades
    {
        public Ciudades()
        {
            Destinos = new HashSet<Destinos>();
            Origenes = new HashSet<Origenes>();
            PuntosEntrega = new HashSet<PuntosEntrega>();
            Repartos = new HashSet<Repartos>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Municipiosid { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public bool? Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? IdZona { get; set; }

        public virtual Zonas IdZonaNavigation { get; set; }
        public virtual Municipios Municipios { get; set; }
        public virtual ICollection<Destinos> Destinos { get; set; }
        public virtual ICollection<Origenes> Origenes { get; set; }
        public virtual ICollection<PuntosEntrega> PuntosEntrega { get; set; }
        public virtual ICollection<Repartos> Repartos { get; set; }
    }
}
