using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class InternalTransferTruck
    {
        public int Id { get; set; }
        public int InternalTransfer { get; set; }
        public int Truck { get; set; }
        public int Origin { get; set; }
        public int Destination { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual InternalTransfer InternalTransferNavigation { get; set; }
        public virtual Truck TruckNavigation { get; set; }
    }
}
