using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class TruckType
    {
        public TruckType()
        {
            Forecast = new HashSet<Forecast>();
            Truck = new HashSet<Truck>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Key { get; set; }
        public int? IdTruckTypeZam { get; set; }

        public virtual ICollection<Forecast> Forecast { get; set; }
        public virtual ICollection<Truck> Truck { get; set; }
    }
}
