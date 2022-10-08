using IO.Swagger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Viajes.Api.Models
{
    public class Regreso
    {
        public int Origin { get; set; }
        public int ReturnTo { get; set; }
        public int MarketType { get; set; }
        public decimal? Distance { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime Time { get; set; }
        public TrucksPlan Plan { get; set; }
    }
}
