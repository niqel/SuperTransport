using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class EstatusContrato
    {
        public EstatusContrato()
        {
            Contratos = new HashSet<Contratos>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool? Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<Contratos> Contratos { get; set; }
    }
}
