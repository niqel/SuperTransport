using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class CEmployeeUnavailableReasonType
    {
        public CEmployeeUnavailableReasonType()
        {
            CalendarEmployee = new HashSet<CalendarEmployee>();
        }

        public int Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }

        public virtual ICollection<CalendarEmployee> CalendarEmployee { get; set; }
    }
}
