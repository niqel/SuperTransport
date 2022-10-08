using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class VwDocumentosContrato
    {
        public int IdContrato { get; set; }
        public string ClaveContrato { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int IdEstatusContrato { get; set; }
        public string EstatusContrato { get; set; }
        public int IdDocumento { get; set; }
        public int IdCotizacion { get; set; }
        public string NombreDocumento { get; set; }
        public string DescripcionDocumento { get; set; }
        public string ReferenciaDocumento { get; set; }
        public bool Active { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
    }
}
