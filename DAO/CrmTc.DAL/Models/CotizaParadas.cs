using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class CotizaParadas
    {
        public int Id { get; set; }
        public decimal CostoCasetas { get; set; }
        public decimal CostoCasetasAcum { get; set; }
        public decimal Kms { get; set; }
        public decimal KmsAcumulados { get; set; }
        public int IdParadas { get; set; }
        public int IdCotizaRutas { get; set; }
        public short? Orden { get; set; }
        public bool? Incluido { get; set; }
        public bool? EsReparto { get; set; }
        public float? TiempoTotal { get; set; }
        public float? TiempoTotalAcum { get; set; }
        public bool? Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual CotizaRutas IdCotizaRutasNavigation { get; set; }
        public virtual Paradas IdParadasNavigation { get; set; }
    }
}
