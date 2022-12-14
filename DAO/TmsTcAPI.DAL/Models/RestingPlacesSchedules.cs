using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class RestingPlacesSchedules
    {
        public int Id { get; set; }
        public int RestingPlacesid { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public byte? DayOfWeek { get; set; }
        public TimeSpan? InitialTime { get; set; }
        public TimeSpan? FinalTime { get; set; }
    }
}
