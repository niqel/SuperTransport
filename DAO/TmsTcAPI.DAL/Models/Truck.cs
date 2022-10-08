using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class Truck
    {
        public Truck()
        {
            CalendarTruck = new HashSet<CalendarTruck>();
            DailyTruckStatusHistory = new HashSet<DailyTruckStatusHistory>();
            InternalTransferTruck = new HashSet<InternalTransferTruck>();
            Operator = new HashSet<Operator>();
            Towing = new HashSet<Towing>();
            Trips = new HashSet<Trips>();
            TruckPlanDetails = new HashSet<TruckPlanDetails>();
            TruckStatusHistory = new HashSet<TruckStatusHistory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? TruckType { get; set; }
        public int TruckStatus { get; set; }
        public string Brand { get; set; }
        public int? Year { get; set; }
        public string SerialNumber { get; set; }
        public string EngineNumber { get; set; }
        public string LicensePlate { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public byte? TotalTires { get; set; }
        public int? EngineTypeId { get; set; }
        public decimal? KmsAccumulated { get; set; }
        public byte? ExtraTires { get; set; }
        public short? InsuranceSubsectionNumber { get; set; }
        public decimal? KmsLastService { get; set; }
        public decimal? KmsNextService { get; set; }
        public decimal? KmsNewCicle { get; set; }
        public decimal? TruckCost { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? LastCheckDate { get; set; }
        public DateTime? NewCicleDate { get; set; }
        public int? HourForNextService { get; set; }
        public decimal? Weight { get; set; }
        public int? FuelCapacity { get; set; }
        public string EconomicNumber { get; set; }
        public string TransitCard { get; set; }
        public string InvoiceNumber { get; set; }
        public string Color { get; set; }
        public string InsurancePolicy { get; set; }
        public int? SellerId { get; set; }
        public string HasIaveCard { get; set; }
        public string IaveCardNumber { get; set; }
        public string FuelType { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public decimal? KmsLastReview { get; set; }
        public string Key { get; set; }
        public int? IdTruckTypeZam { get; set; }
        public int? TrackingId { get; set; }

        public virtual TruckStatus TruckStatusNavigation { get; set; }
        public virtual TruckType TruckTypeNavigation { get; set; }
        public virtual ICollection<CalendarTruck> CalendarTruck { get; set; }
        public virtual ICollection<DailyTruckStatusHistory> DailyTruckStatusHistory { get; set; }
        public virtual ICollection<InternalTransferTruck> InternalTransferTruck { get; set; }
        public virtual ICollection<Operator> Operator { get; set; }
        public virtual ICollection<Towing> Towing { get; set; }
        public virtual ICollection<Trips> Trips { get; set; }
        public virtual ICollection<TruckPlanDetails> TruckPlanDetails { get; set; }
        public virtual ICollection<TruckStatusHistory> TruckStatusHistory { get; set; }
    }
}
