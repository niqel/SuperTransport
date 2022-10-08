using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class CotizacionParametros
    {
        public int Id { get; set; }
        public int IdCotizacion { get; set; }
        public int IdParametroCotizacion { get; set; }
        public string Nombre { get; set; }
        public string Valor { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Cotizacion IdCotizacionNavigation { get; set; }
        public virtual CatalogoParametrosCotizacion IdParametroCotizacionNavigation { get; set; }
    }
}
