using CrmTc.DAL.Models;
using IO.Swagger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Viajes.Api.Extensions
{
    public class Office
    {
        public Location Location { get; set; }
        public double Geofence { get; set; }
        public List<OficinaDisponibilidad> Availability {get; set; }
        public Office(Location location, double geofence)
        {
            Location = location;
            Geofence = geofence;
        }

    }
}
