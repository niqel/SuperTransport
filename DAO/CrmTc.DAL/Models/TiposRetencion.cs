using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class TiposRetencion
    {
        public TiposRetencion()
        {
            Clientes = new HashSet<Clientes>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Clientes> Clientes { get; set; }
    }
}
