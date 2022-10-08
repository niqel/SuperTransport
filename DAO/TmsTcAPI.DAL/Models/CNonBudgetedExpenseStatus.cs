using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class CNonBudgetedExpenseStatus
    {
        public CNonBudgetedExpenseStatus()
        {
            NonBudgetedExpense = new HashSet<NonBudgetedExpense>();
        }

        public int Id { get; set; }
        public string Key { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Name { get; set; }

        public virtual ICollection<NonBudgetedExpense> NonBudgetedExpense { get; set; }
    }
}
