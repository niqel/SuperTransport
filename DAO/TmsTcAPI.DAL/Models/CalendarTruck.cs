using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class CalendarTruck
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool? Available { get; set; }
        public int CreatedBy { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public int Truckid { get; set; }
        public int CTruckUnavailableReasonTypeid { get; set; }

        public virtual CTruckUnavailableReasonType CTruckUnavailableReasonType { get; set; }
        public virtual Truck Truck { get; set; }
    }
}
