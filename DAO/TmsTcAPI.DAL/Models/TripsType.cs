using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class TripsType
    {
        public TripsType()
        {
            Trips = new HashSet<Trips>();
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

        public virtual ICollection<Trips> Trips { get; set; }
    }
}
