using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class ComentariosCotizacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? IdEstatusCotizacionHistory { get; set; }

        public virtual EstatusCotizacionHistory IdEstatusCotizacionHistoryNavigation { get; set; }
    }
}
