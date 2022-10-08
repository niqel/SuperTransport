using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class TripsLog
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Tripsid { get; set; }
        public int TripsStatusid { get; set; }

        public virtual Trips Trips { get; set; }
        public virtual TripsStatus TripsStatus { get; set; }
    }
}
