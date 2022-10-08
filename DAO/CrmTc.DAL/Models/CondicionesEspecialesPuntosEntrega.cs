using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class CondicionesEspecialesPuntosEntrega
    {
        public int IdCondicionesEspeciales { get; set; }
        public int IdPuntoEntrega { get; set; }
        public decimal? Valor { get; set; }
        public string Telefono { get; set; }

        public virtual CondicionesEspeciales IdCondicionesEspecialesNavigation { get; set; }
        public virtual PuntosEntrega IdPuntoEntregaNavigation { get; set; }
    }
}
