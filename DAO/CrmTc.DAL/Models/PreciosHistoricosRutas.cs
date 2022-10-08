using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class PreciosHistoricosRutas
    {
        public int Id { get; set; }
        public decimal? Precio { get; set; }
        public int RutaTipoTractorid { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual RutaTipoTractor RutaTipoTractor { get; set; }
    }
}
