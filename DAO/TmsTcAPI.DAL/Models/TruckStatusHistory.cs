using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class TruckStatusHistory
    {
        public int Id { get; set; }
        public int TruckId { get; set; }
        public int TruckStatusId { get; set; }
        public int MarketTypeId { get; set; }
        public int? OfficeAssigned { get; set; }
        public DateTime? ArrivalTime { get; set; }
        public DateTime? PositionedDate { get; set; }

        public virtual MarketType MarketType { get; set; }
        public virtual Truck Truck { get; set; }
        public virtual TruckStatus TruckStatus { get; set; }
    }
}
