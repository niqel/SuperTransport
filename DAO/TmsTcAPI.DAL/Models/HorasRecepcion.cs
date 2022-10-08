using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class HorasRecepcion
    {
        public int Id { get; set; }
        public int IdPuntoEntrega { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual PuntosEntrega IdPuntoEntregaNavigation { get; set; }
    }
}
