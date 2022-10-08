using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class Municipios
    {
        public Municipios()
        {
            Ciudades = new HashSet<Ciudades>();
            Colonias = new HashSet<Colonias>();
            Ubicaciones = new HashSet<Ubicaciones>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public int Statesid { get; set; }
        public bool? Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Estados States { get; set; }
        public virtual ICollection<Ciudades> Ciudades { get; set; }
        public virtual ICollection<Colonias> Colonias { get; set; }
        public virtual ICollection<Ubicaciones> Ubicaciones { get; set; }
    }
}
