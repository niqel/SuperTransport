using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class DistanciasRegresos
    {
        public int Id { get; set; }
        public bool? CalculadoGlobalMap { get; set; }
        public decimal? Kms { get; set; }
        public int Oficinasid { get; set; }
        public int Destinosid { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public decimal? CostoCasetas { get; set; }
        public float? Tiempo { get; set; }

        public virtual Destinos Destinos { get; set; }
        public virtual Oficinas Oficinas { get; set; }
    }
}
