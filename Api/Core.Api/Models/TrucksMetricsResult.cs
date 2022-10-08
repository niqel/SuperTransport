using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Api.Models
{
    public class TrucksMetricsResult
    {
        public DateTime fecha { set; get; }

        public List<TruckStatus> truckStatuses { get; set; }
    }

    public class TruckStatus
    {
        public string estatus { get; set; }
        public int cantidad { get; set; }
        public int idEstatus { get; set; }
    }
}
