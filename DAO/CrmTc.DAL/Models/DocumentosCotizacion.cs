using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class DocumentosCotizacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string ReferenciaDocumento { get; set; }
        public int IdCotizacion { get; set; }
        public int? IdContrato { get; set; }
        public int IdTipoDocumento { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Contratos IdContratoNavigation { get; set; }
        public virtual Cotizacion IdCotizacionNavigation { get; set; }
        public virtual TiposDocumento IdTipoDocumentoNavigation { get; set; }
    }
}
