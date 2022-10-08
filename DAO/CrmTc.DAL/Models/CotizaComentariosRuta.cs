using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class CotizaComentariosRuta
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int IdCotizaRutas { get; set; }
        public int IdCotizaEstatusRevisionRuta { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual CotizaEstatusRevisionRuta IdCotizaEstatusRevisionRutaNavigation { get; set; }
        public virtual CotizaRutas IdCotizaRutasNavigation { get; set; }
    }
}
