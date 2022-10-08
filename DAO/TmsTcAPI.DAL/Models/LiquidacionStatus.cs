using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class LiquidacionStatus
    {
        public LiquidacionStatus()
        {
            Liquidacion = new HashSet<Liquidacion>();
            LogLiquidaciones = new HashSet<LogLiquidaciones>();
        }

        public int Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<Liquidacion> Liquidacion { get; set; }
        public virtual ICollection<LogLiquidaciones> LogLiquidaciones { get; set; }
    }
}
