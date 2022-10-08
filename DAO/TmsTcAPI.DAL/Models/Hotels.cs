using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class Hotels
    {
        public Hotels()
        {
            RoutesHotels = new HashSet<RoutesHotels>();
        }

        public int Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<RoutesHotels> RoutesHotels { get; set; }
    }
}
