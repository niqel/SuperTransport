using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class DetalleRuta
    {
        public int Id { get; set; }
        public decimal? Kms { get; set; }
        public decimal? CostoCasetas { get; set; }
        public float? TiempoTotal { get; set; }
        public int? IdRutaInnovaLinks { get; set; }
        public bool? Active { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int RutaTipoTractorid { get; set; }

        public virtual RutaTipoTractor RutaTipoTractor { get; set; }
    }
}
