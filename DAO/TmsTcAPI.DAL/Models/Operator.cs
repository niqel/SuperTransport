using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class Operator
    {
        public Operator()
        {
            DailyOperatorStatusHistory = new HashSet<DailyOperatorStatusHistory>();
            NonBudgetedExpense = new HashSet<NonBudgetedExpense>();
            OperatorLog = new HashSet<OperatorLog>();
            RTripsOperator = new HashSet<RTripsOperator>();
            Suggestions = new HashSet<Suggestions>();
        }

        public int Id { get; set; }
        public short NumOperadorZam { get; set; }
        public int Rating { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int OperatorStatusid { get; set; }
        public int Employeeid { get; set; }
        public int? Truckid { get; set; }
        public byte? Priority { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual OperatorStatus OperatorStatus { get; set; }
        public virtual Truck Truck { get; set; }
        public virtual ICollection<DailyOperatorStatusHistory> DailyOperatorStatusHistory { get; set; }
        public virtual ICollection<NonBudgetedExpense> NonBudgetedExpense { get; set; }
        public virtual ICollection<OperatorLog> OperatorLog { get; set; }
        public virtual ICollection<RTripsOperator> RTripsOperator { get; set; }
        public virtual ICollection<Suggestions> Suggestions { get; set; }
    }
}
