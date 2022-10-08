using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class CTruckUnavailableReasonType
    {
        public CTruckUnavailableReasonType()
        {
            CalendarTruck = new HashSet<CalendarTruck>();
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

        public virtual ICollection<CalendarTruck> CalendarTruck { get; set; }
    }
}
