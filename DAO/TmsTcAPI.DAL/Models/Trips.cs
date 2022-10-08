using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class Trips
    {
        public Trips()
        {
            NonBudgetedExpense = new HashSet<NonBudgetedExpense>();
            RTripsOperator = new HashSet<RTripsOperator>();
            TripPlannedExpenses = new HashSet<TripPlannedExpenses>();
            TripsLog = new HashSet<TripsLog>();
        }

        public int Id { get; set; }
        public int MarketType { get; set; }
        public int Customer { get; set; }
        public int Origin { get; set; }
        public int Destination { get; set; }
        public int ReturnTo { get; set; }
        public int Idtravelzam { get; set; }
        public int Truck { get; set; }
        public string Reason { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int TripsStatusid { get; set; }
        public int? LiquidacionId { get; set; }
        public byte? VinsQuantity { get; set; }
        public float? ExpectedPerformance { get; set; }
        public float? RealPerformance { get; set; }
        public decimal? Kms { get; set; }
        public string CartaPorte { get; set; }
        public int TripsTypeid { get; set; }
        public bool? SetManually { get; set; }

        public virtual Liquidacion Liquidacion { get; set; }
        public virtual MarketType MarketTypeNavigation { get; set; }
        public virtual TripsStatus TripsStatus { get; set; }
        public virtual TripsType TripsType { get; set; }
        public virtual Truck TruckNavigation { get; set; }
        public virtual ICollection<NonBudgetedExpense> NonBudgetedExpense { get; set; }
        public virtual ICollection<RTripsOperator> RTripsOperator { get; set; }
        public virtual ICollection<TripPlannedExpenses> TripPlannedExpenses { get; set; }
        public virtual ICollection<TripsLog> TripsLog { get; set; }
    }
}
