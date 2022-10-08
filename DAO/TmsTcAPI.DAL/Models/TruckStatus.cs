using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class TruckStatus
    {
        public TruckStatus()
        {
            DailyTruckStatusHistory = new HashSet<DailyTruckStatusHistory>();
            TripsStatusZam = new HashSet<TripsStatusZam>();
            Truck = new HashSet<Truck>();
            TruckStatusHistory = new HashSet<TruckStatusHistory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<DailyTruckStatusHistory> DailyTruckStatusHistory { get; set; }
        public virtual ICollection<TripsStatusZam> TripsStatusZam { get; set; }
        public virtual ICollection<Truck> Truck { get; set; }
        public virtual ICollection<TruckStatusHistory> TruckStatusHistory { get; set; }
    }
}
