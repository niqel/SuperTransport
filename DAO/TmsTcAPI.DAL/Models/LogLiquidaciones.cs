using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class LogLiquidaciones
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Liquidacionid { get; set; }
        public int LiquidacionStatusid { get; set; }

        public virtual Liquidacion Liquidacion { get; set; }
        public virtual LiquidacionStatus LiquidacionStatus { get; set; }
    }
}
