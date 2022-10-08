using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class VwContratos
    {
        public int Id { get; set; }
        public int IdCotizacion { get; set; }
        public int IdCliente { get; set; }
        public string ClaveContrato { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int IdEstatusContrato { get; set; }
        public string EstatusContrato { get; set; }
        public bool Active { get; set; }
    }
}
