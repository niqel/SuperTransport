using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class DealerTelefonos
    {
        public int Id { get; set; }
        public string Telefono { get; set; }
        public bool EsPrincipal { get; set; }
        public bool EsFax { get; set; }
        public int IdPuntoEntrega { get; set; }

        public virtual PuntosEntrega IdPuntoEntregaNavigation { get; set; }
    }
}
