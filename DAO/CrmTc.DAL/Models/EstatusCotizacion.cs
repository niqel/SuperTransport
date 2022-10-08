using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class EstatusCotizacion
    {
        public EstatusCotizacion()
        {
            Cotizacion = new HashSet<Cotizacion>();
            EstatusCotizacionHistory = new HashSet<EstatusCotizacionHistory>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? IdFaseEstatusCotizacion { get; set; }

        public virtual FasesEstatusCotizacion IdFaseEstatusCotizacionNavigation { get; set; }
        public virtual ICollection<Cotizacion> Cotizacion { get; set; }
        public virtual ICollection<EstatusCotizacionHistory> EstatusCotizacionHistory { get; set; }
    }
}
