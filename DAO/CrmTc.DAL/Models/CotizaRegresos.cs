using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class CotizaRegresos
    {
        public int Id { get; set; }
        public decimal Kms { get; set; }
        public decimal CostoCasetas { get; set; }
        public float? Tiempo { get; set; }
        public decimal ProbabilidadCarga { get; set; }
        public int IdOrigenes { get; set; }
        public int IdCotizaRutas { get; set; }
        public decimal? PorcentajeVacio { get; set; }
        public decimal? PorcentajeCargado { get; set; }
        public decimal? TotalGastosVariables { get; set; }
        public decimal? TotalGastosFijos { get; set; }
        public decimal? PrecioFlete { get; set; }
        public decimal? PrecioPorKilometro { get; set; }
        public bool? Sugerido { get; set; }
        public bool? Seleccionado { get; set; }
        public decimal? AcumuladoProbabilidadCarga { get; set; }
        public bool? Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual CotizaRutas IdCotizaRutasNavigation { get; set; }
        public virtual Origenes IdOrigenesNavigation { get; set; }
    }
}
