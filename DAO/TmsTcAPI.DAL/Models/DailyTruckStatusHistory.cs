using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class DailyTruckStatusHistory
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int TruckStatusid { get; set; }
        public int Truckid { get; set; }

        public virtual Truck Truck { get; set; }
        public virtual TruckStatus TruckStatus { get; set; }
    }
}
