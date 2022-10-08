using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class Regresos
    {
        public int Id { get; set; }
        public int DestinoId { get; set; }
        public int RegresoId { get; set; }
        public int? Kms { get; set; }
        public decimal? Autopistas { get; set; }
        public decimal? Tiempo { get; set; }
        public decimal? PorcDeCargado { get; set; }
        public decimal? PorcDeVacio { get; set; }
        public bool? Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? UpdatedGloblaMap { get; set; }

        public virtual Destinos Destino { get; set; }
        public virtual Origenes Regreso { get; set; }
    }
}
