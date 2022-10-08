using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class CatalogoParametrosCotizacion
    {
        public CatalogoParametrosCotizacion()
        {
            CotizacionParametros = new HashSet<CotizacionParametros>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Seccion { get; set; }
        public string Valor { get; set; }
        public byte Orden { get; set; }
        public bool? EsOperativo { get; set; }
        public bool? EditableEnCotizacion { get; set; }
        public bool? VisibleEnCotizacion { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<CotizacionParametros> CotizacionParametros { get; set; }
    }
}
