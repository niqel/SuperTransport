using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class CondicionesEspeciales
    {
        public CondicionesEspeciales()
        {
            CondicionesEspecialesPuntosEntrega = new HashSet<CondicionesEspecialesPuntosEntrega>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<CondicionesEspecialesPuntosEntrega> CondicionesEspecialesPuntosEntrega { get; set; }
    }
}
