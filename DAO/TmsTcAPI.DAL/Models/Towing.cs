using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class Towing
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public int? Year { get; set; }
        public string SerialNumber { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Truckid { get; set; }

        public virtual Truck Truck { get; set; }
    }
}
