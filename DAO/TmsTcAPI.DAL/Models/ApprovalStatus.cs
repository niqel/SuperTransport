﻿using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class ApprovalStatus
    {
        public ApprovalStatus()
        {
            InternalTransfer = new HashSet<InternalTransfer>();
            InternalTransferHistory = new HashSet<InternalTransferHistory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<InternalTransfer> InternalTransfer { get; set; }
        public virtual ICollection<InternalTransferHistory> InternalTransferHistory { get; set; }
    }
}
