using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class TripsStatusZam
    {
        public int Id { get; set; }
        public int Idzam { get; set; }
        public bool Cartaporte { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int TripsStatusid { get; set; }
        public int TruckStatusid { get; set; }
        public int? OperatorStatusid { get; set; }

        public virtual OperatorStatus OperatorStatus { get; set; }
        public virtual TripsStatus TripsStatus { get; set; }
        public virtual TruckStatus TruckStatus { get; set; }
    }
}
