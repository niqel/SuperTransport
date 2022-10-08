using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class TiposTractor
    {
        public TiposTractor()
        {
            Cotizacion = new HashSet<Cotizacion>();
            RutaTipoTractor = new HashSet<RutaTipoTractor>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Ejes { get; set; }
        public string Configuracion { get; set; }
        public int Llantas { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<Cotizacion> Cotizacion { get; set; }
        public virtual ICollection<RutaTipoTractor> RutaTipoTractor { get; set; }
    }
}
