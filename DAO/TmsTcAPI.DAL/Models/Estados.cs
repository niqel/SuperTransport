using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class Estados
    {
        public Estados()
        {
            Municipios = new HashSet<Municipios>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public int Countriesid { get; set; }
        public int IdZona { get; set; }
        public bool? Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Paises Countries { get; set; }
        public virtual Zonas IdZonaNavigation { get; set; }
        public virtual ICollection<Municipios> Municipios { get; set; }
    }
}
