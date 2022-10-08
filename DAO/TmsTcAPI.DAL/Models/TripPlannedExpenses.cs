using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class TripPlannedExpenses
    {
        public int Id { get; set; }
        public int? IdPezam { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? IssueDate { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Tripsid { get; set; }
        public int CPlannedExpensesTypeid { get; set; }

        public virtual CPlannedExpensesType CPlannedExpensesType { get; set; }
        public virtual Trips Trips { get; set; }
    }
}
