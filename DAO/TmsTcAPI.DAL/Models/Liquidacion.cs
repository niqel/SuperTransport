using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class Liquidacion
    {
        public Liquidacion()
        {
            LogLiquidaciones = new HashSet<LogLiquidaciones>();
            Trips = new HashSet<Trips>();
        }

        public int Id { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int LiquidacionStatusid { get; set; }

        public virtual LiquidacionStatus LiquidacionStatus { get; set; }
        public virtual ICollection<LogLiquidaciones> LogLiquidaciones { get; set; }
        public virtual ICollection<Trips> Trips { get; set; }
    }
}
