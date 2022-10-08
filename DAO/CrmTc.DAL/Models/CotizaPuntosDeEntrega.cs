using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class CotizaPuntosDeEntrega
    {
        public CotizaPuntosDeEntrega()
        {
            CotizaPuntosDeEntregaCondicionesEspeciales = new HashSet<CotizaPuntosDeEntregaCondicionesEspeciales>();
        }

        public int Id { get; set; }
        public int IdPuntosEntrega { get; set; }
        public int IdCotizaRutas { get; set; }

        public virtual CotizaRutas IdCotizaRutasNavigation { get; set; }
        public virtual PuntosEntrega IdPuntosEntregaNavigation { get; set; }
        public virtual ICollection<CotizaPuntosDeEntregaCondicionesEspeciales> CotizaPuntosDeEntregaCondicionesEspeciales { get; set; }
    }
}
