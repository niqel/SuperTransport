using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class Repartos20201130
    {
        public int Id { get; set; }
        public short? Orden { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Rutasid { get; set; }
        public int Ciudadesid { get; set; }
        public decimal? Kms { get; set; }
        public decimal? KmsAcum { get; set; }
        public decimal? Casetas { get; set; }
        public decimal? CasetasAcum { get; set; }
        public decimal? TiempoTotal { get; set; }
        public decimal? TiempoTotalAcum { get; set; }
    }
}
