using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class RoutesHotels
    {
        public int Id { get; set; }
        public int RouteId { get; set; }
        public int Hotelsid { get; set; }

        public virtual Hotels Hotels { get; set; }
    }
}
