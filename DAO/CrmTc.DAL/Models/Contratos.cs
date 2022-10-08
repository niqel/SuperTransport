using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class Contratos
    {
        public Contratos()
        {
            Cotizacion = new HashSet<Cotizacion>();
            DocumentosCotizacion = new HashSet<DocumentosCotizacion>();
            TarifasContratos = new HashSet<TarifasContratos>();
        }

        public int Id { get; set; }
        public string ClaveContrato { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int IdEstatusContrato { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual EstatusContrato IdEstatusContratoNavigation { get; set; }
        public virtual ICollection<Cotizacion> Cotizacion { get; set; }
        public virtual ICollection<DocumentosCotizacion> DocumentosCotizacion { get; set; }
        public virtual ICollection<TarifasContratos> TarifasContratos { get; set; }
    }
}
