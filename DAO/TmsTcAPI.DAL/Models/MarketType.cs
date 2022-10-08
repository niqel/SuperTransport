using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class MarketType
    {
        public MarketType()
        {
            Forecast = new HashSet<Forecast>();
            LoadPlan = new HashSet<LoadPlan>();
            Trips = new HashSet<Trips>();
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
        public string NameZam { get; set; }

        public virtual ICollection<Forecast> Forecast { get; set; }
        public virtual ICollection<LoadPlan> LoadPlan { get; set; }
        public virtual ICollection<Trips> Trips { get; set; }
        public virtual ICollection<TruckStatusHistory> TruckStatusHistory { get; set; }
    }
}
