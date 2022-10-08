using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class Rutas
    {
        public Rutas()
        {
            CotizaRutas = new HashSet<CotizaRutas>();
            RutaTipoTractor = new HashSet<RutaTipoTractor>();
        }

        public int Id { get; set; }
        public int Origenesid { get; set; }
        public int Destinosid { get; set; }
        public bool? Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int? IdRutaZam { get; set; }
        public int? KmNegociados { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public bool? CalculadoGlobalMap { get; set; }

        public virtual Destinos Destinos { get; set; }
        public virtual Origenes Origenes { get; set; }
        public virtual ICollection<CotizaRutas> CotizaRutas { get; set; }
        public virtual ICollection<RutaTipoTractor> RutaTipoTractor { get; set; }
    }
}
