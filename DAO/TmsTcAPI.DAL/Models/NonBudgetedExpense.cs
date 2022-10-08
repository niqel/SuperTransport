using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class NonBudgetedExpense
    {
        public NonBudgetedExpense()
        {
            EvidenceNonBudgetedExpense = new HashSet<EvidenceNonBudgetedExpense>();
        }

        public int Id { get; set; }
        public int TripId { get; set; }
        public int OperatorId { get; set; }
        public int NonBudgetedExpenseStatusId { get; set; }
        public int NonBudgetedExpenseTypeId { get; set; }
        public bool? IsBillable { get; set; }
        public decimal? Amount { get; set; }
        public string Comment { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual CNonBudgetedExpenseStatus NonBudgetedExpenseStatus { get; set; }
        public virtual CNonBudgetedExpenseType NonBudgetedExpenseType { get; set; }
        public virtual Operator Operator { get; set; }
        public virtual Trips Trip { get; set; }
        public virtual ICollection<EvidenceNonBudgetedExpense> EvidenceNonBudgetedExpense { get; set; }
    }
}
