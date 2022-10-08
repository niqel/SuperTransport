using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class PreciosHistoricosRutas
    {
        public int Id { get; set; }
        public decimal? Precio { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Rutasid { get; set; }

        public virtual Rutas Rutas { get; set; }
    }
}
