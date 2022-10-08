using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class CotizaRutas
    {
        public CotizaRutas()
        {
            CotizaComentariosRuta = new HashSet<CotizaComentariosRuta>();
            CotizaDetalleRuta = new HashSet<CotizaDetalleRuta>();
            CotizaParadas = new HashSet<CotizaParadas>();
            CotizaPuntosDeEntrega = new HashSet<CotizaPuntosDeEntrega>();
            CotizaRegresos = new HashSet<CotizaRegresos>();
        }

        public int Id { get; set; }
        public int IdCotizacion { get; set; }
        public int IdCotizaTiposMercados { get; set; }
        public int IdCotizaEstatusRevisionRuta { get; set; }
        public int IdRutas { get; set; }
        public int? IdEstructuraCostosFijos { get; set; }
        public bool? Calculada { get; set; }
        public bool? Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual CotizaEstatusRevisionRuta IdCotizaEstatusRevisionRutaNavigation { get; set; }
        public virtual CotizaTiposMercados IdCotizaTiposMercadosNavigation { get; set; }
        public virtual Cotizacion IdCotizacionNavigation { get; set; }
        public virtual Rutas IdRutasNavigation { get; set; }
        public virtual ICollection<CotizaComentariosRuta> CotizaComentariosRuta { get; set; }
        public virtual ICollection<CotizaDetalleRuta> CotizaDetalleRuta { get; set; }
        public virtual ICollection<CotizaParadas> CotizaParadas { get; set; }
        public virtual ICollection<CotizaPuntosDeEntrega> CotizaPuntosDeEntrega { get; set; }
        public virtual ICollection<CotizaRegresos> CotizaRegresos { get; set; }
    }
}
