using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class RTripsOperator
    {
        public int Tripsid { get; set; }
        public int Operatorid { get; set; }
        public int? Rating { get; set; }

        public virtual Operator Operator { get; set; }
        public virtual Trips Trips { get; set; }
    }
}
