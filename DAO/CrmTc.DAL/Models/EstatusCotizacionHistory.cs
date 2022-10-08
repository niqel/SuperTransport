using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class EstatusCotizacionHistory
    {
        public EstatusCotizacionHistory()
        {
            ComentariosCotizacion = new HashSet<ComentariosCotizacion>();
        }

        public int Id { get; set; }
        public int IdEstatusCotizacion { get; set; }
        public int IdCotizacion { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }

        public virtual Cotizacion IdCotizacionNavigation { get; set; }
        public virtual EstatusCotizacion IdEstatusCotizacionNavigation { get; set; }
        public virtual ICollection<ComentariosCotizacion> ComentariosCotizacion { get; set; }
    }
}
