using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class Origenes
    {
        public Origenes()
        {
            Regresos = new HashSet<Regresos>();
            Rutas = new HashSet<Rutas>();
        }

        public int Id { get; set; }
        public bool? Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Ciudadesid { get; set; }

        public virtual Ciudades Ciudades { get; set; }
        public virtual ICollection<Regresos> Regresos { get; set; }
        public virtual ICollection<Rutas> Rutas { get; set; }
    }
}
