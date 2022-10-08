using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class TiposCredito
    {
        public TiposCredito()
        {
            Clientes = new HashSet<Clientes>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int? DiasCredito { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<Clientes> Clientes { get; set; }
    }
}
