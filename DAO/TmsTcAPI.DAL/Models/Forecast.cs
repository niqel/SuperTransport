using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class Forecast
    {
        public int Customer { get; set; }
        public int Origin { get; set; }
        public DateTime Date { get; set; }
        public int MarketType { get; set; }
        public int TruckType { get; set; }
        public int? TrucksQuantity { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? TrucksQuantityEdited { get; set; }

        public virtual MarketType MarketTypeNavigation { get; set; }
        public virtual TruckType TruckTypeNavigation { get; set; }
    }
}
