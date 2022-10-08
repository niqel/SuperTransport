using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace TmsTcAPI.Models
{
    public class custom_posicion
    {
        public double lat { get; set; }
        public double lng { get; set; }

        public custom_posicion(double latitude, double longitude)
        {
            lat = latitude;
            lng = longitude;
        }
    }
}