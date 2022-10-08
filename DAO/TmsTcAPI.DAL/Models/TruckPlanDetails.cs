using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class TruckPlanDetails
    {
        public int Id { get; set; }
        public int? OfficeAssigned { get; set; }
        public DateTime? ArrivalTime { get; set; }
        public int MarketType { get; set; }
        public int Truckid { get; set; }

        public virtual Truck Truck { get; set; }
    }
}
