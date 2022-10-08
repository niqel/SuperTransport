using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class CotizaEstatusRevisionRuta
    {
        public CotizaEstatusRevisionRuta()
        {
            CotizaComentariosRuta = new HashSet<CotizaComentariosRuta>();
            CotizaRutas = new HashSet<CotizaRutas>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual ICollection<CotizaComentariosRuta> CotizaComentariosRuta { get; set; }
        public virtual ICollection<CotizaRutas> CotizaRutas { get; set; }
    }
}
