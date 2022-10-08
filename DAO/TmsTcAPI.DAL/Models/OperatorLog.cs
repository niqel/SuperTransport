using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class OperatorLog
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int OperatorStatusid { get; set; }
        public int Operatorid { get; set; }

        public virtual Operator Operator { get; set; }
        public virtual OperatorStatus OperatorStatus { get; set; }
    }
}
