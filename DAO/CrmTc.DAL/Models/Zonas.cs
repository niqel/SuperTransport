using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class Zonas
    {
        public Zonas()
        {
            Ciudades = new HashSet<Ciudades>();
            Estados = new HashSet<Estados>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public bool? Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<Ciudades> Ciudades { get; set; }
        public virtual ICollection<Estados> Estados { get; set; }
    }
}
