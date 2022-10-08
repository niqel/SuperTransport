using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class Paradas
    {
        public Paradas()
        {
            CotizaParadas = new HashSet<CotizaParadas>();
        }

        public int Id { get; set; }
        public decimal? Casetas { get; set; }
        public decimal? CasetasAcum { get; set; }
        public decimal? Kms { get; set; }
        public decimal? KmsAcum { get; set; }
        public decimal? TiempoTotal { get; set; }
        public decimal? TiempoTotalAcum { get; set; }
        public short? Orden { get; set; }
        public bool? EsReparto { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public bool? Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Ciudadesid { get; set; }
        public int RutaTipoTractorid { get; set; }

        public virtual Ciudades Ciudades { get; set; }
        public virtual RutaTipoTractor RutaTipoTractor { get; set; }
        public virtual ICollection<CotizaParadas> CotizaParadas { get; set; }
    }
}
