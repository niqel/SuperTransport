using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class GeneralParameters
    {
        public GeneralParameters()
        {
            GeneralParametersHistory = new HashSet<GeneralParametersHistory>();
        }

        public int Id { get; set; }
        public string Module { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Regex { get; set; }
        public int Order { get; set; }
        public string Value { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Usuarios CreatedByNavigation { get; set; }
        public virtual Usuarios UpdatedByNavigation { get; set; }
        public virtual ICollection<GeneralParametersHistory> GeneralParametersHistory { get; set; }
    }
}
