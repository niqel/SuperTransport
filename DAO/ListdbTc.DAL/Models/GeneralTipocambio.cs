using System;
using System.Collections.Generic;

namespace ListdbTc.DAL.Models
{
    public partial class GeneralTipocambio
    {
        public DateTime IdFecha { get; set; }
        public int IdModulo { get; set; }
        public int IdTipocambio { get; set; }
        public int IdTipomoneda { get; set; }
        public int IdBanco { get; set; }
        public decimal? TipoCambio { get; set; }
    }
}
