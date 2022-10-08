using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Api.Models
{
    public class OperatorsMetricsResult
    {
        public DateTime fecha { get; set; }
        public List<OperatorStatus> operatorStatuses { get; set; }
    }

    public class OperatorStatus
    {
        public string estatus { get; set; }
        public int cantidad { get; set; }
        public int idEstatus { get; set; }
    }
}
