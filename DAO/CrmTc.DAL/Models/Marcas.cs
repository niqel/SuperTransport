using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class Marcas
    {
        public Marcas()
        {
            AutosFamilias = new HashSet<AutosFamilias>();
            AutosModelos = new HashSet<AutosModelos>();
            Clientes = new HashSet<Clientes>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<AutosFamilias> AutosFamilias { get; set; }
        public virtual ICollection<AutosModelos> AutosModelos { get; set; }
        public virtual ICollection<Clientes> Clientes { get; set; }
    }
}
