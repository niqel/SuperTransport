using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class Origenes
    {
        public Origenes()
        {
            CotizaRegresos = new HashSet<CotizaRegresos>();
            Rutas = new HashSet<Rutas>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public bool? Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Ciudadesid { get; set; }

        public virtual Ciudades Ciudades { get; set; }
        public virtual ICollection<CotizaRegresos> CotizaRegresos { get; set; }
        public virtual ICollection<Rutas> Rutas { get; set; }
    }
}
