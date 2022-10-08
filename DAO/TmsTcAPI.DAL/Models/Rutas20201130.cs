using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class Rutas20201130
    {
        public int Id { get; set; }
        public int? KmNegociados { get; set; }
        public int? IdRutaZam { get; set; }
        public float? TiempoTotal { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Clientesid { get; set; }
        public int Origenesid { get; set; }
        public int Destinosid { get; set; }
        public int? IdRutaInnovaLinks { get; set; }
        public int? Kilometros { get; set; }
        public decimal? CostoCasetas { get; set; }
        public bool? UpdatedGlobalMap { get; set; }
    }
}
