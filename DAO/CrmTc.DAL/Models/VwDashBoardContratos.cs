using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class VwDashBoardContratos
    {
        public DateTime? Fecha { get; set; }
        public string FechaCadena { get; set; }
        public string Cliente { get; set; }
        public int? Activos { get; set; }
        public int? Inactivos { get; set; }
        public int? TotalRegistros { get; set; }
    }
}
