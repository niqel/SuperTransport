using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class TripsStatus
    {
        public TripsStatus()
        {
            Trips = new HashSet<Trips>();
            TripsLog = new HashSet<TripsLog>();
            TripsStatusZam = new HashSet<TripsStatusZam>();
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
        public int? IdStatusZam { get; set; }

        public virtual ICollection<Trips> Trips { get; set; }
        public virtual ICollection<TripsLog> TripsLog { get; set; }
        public virtual ICollection<TripsStatusZam> TripsStatusZam { get; set; }
    }
}
