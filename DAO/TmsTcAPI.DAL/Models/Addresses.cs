using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class Addresses
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string ExternalNumber { get; set; }
        public string InternalNumber { get; set; }
        public int? PostalCode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Reference { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? Coloniasid { get; set; }
        public int CAddressTypeid { get; set; }
        public int Employeeid { get; set; }

        public virtual CAddressType CAddressType { get; set; }
        public virtual Colonias Colonias { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
