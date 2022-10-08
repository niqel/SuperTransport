using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class CalendarEmployee
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool? Available { get; set; }
        public int CreatedBy { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public int Employeeid { get; set; }
        public int CEmployeeUnavailableReasonTypeid { get; set; }

        public virtual CEmployeeUnavailableReasonType CEmployeeUnavailableReasonType { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
