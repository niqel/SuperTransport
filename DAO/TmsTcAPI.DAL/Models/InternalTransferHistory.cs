using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class InternalTransferHistory
    {
        public int Id { get; set; }
        public int InternalTransfer { get; set; }
        public int ApprovalStatus { get; set; }
        public string Comment { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ApprovalStatus ApprovalStatusNavigation { get; set; }
        public virtual InternalTransfer InternalTransferNavigation { get; set; }
    }
}
