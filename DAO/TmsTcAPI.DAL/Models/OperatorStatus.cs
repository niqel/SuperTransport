using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class OperatorStatus
    {
        public OperatorStatus()
        {
            DailyOperatorStatusHistory = new HashSet<DailyOperatorStatusHistory>();
            Operator = new HashSet<Operator>();
            OperatorLog = new HashSet<OperatorLog>();
            OperatorStatusZam = new HashSet<OperatorStatusZam>();
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

        public virtual ICollection<DailyOperatorStatusHistory> DailyOperatorStatusHistory { get; set; }
        public virtual ICollection<Operator> Operator { get; set; }
        public virtual ICollection<OperatorLog> OperatorLog { get; set; }
        public virtual ICollection<OperatorStatusZam> OperatorStatusZam { get; set; }
        public virtual ICollection<TripsStatusZam> TripsStatusZam { get; set; }
    }
}
