using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class LoadPlan
    {
        public int MarketType { get; set; }
        public int Customer { get; set; }
        public int Office { get; set; }
        public DateTime Date { get; set; }
        public int? VinsPlanned { get; set; }
        public int? VinsPositioned { get; set; }
        public int? VinsLoaded { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual MarketType MarketTypeNavigation { get; set; }
    }
}
