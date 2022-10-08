using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class CotizaPuntosDeEntregaCondicionesEspeciales
    {
        public int IdCotizaPuntosDeEntrega { get; set; }
        public int IdCondicionesEspeciales { get; set; }
        public decimal? Valor { get; set; }

        public virtual CondicionesEspeciales IdCondicionesEspecialesNavigation { get; set; }
        public virtual CotizaPuntosDeEntrega IdCotizaPuntosDeEntregaNavigation { get; set; }
    }
}
