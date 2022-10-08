using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class EvidenceNonBudgetedExpense
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public int NonBudgetedExpenseId { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual NonBudgetedExpense NonBudgetedExpense { get; set; }
    }
}
