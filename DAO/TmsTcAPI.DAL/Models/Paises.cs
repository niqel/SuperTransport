using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class Paises
    {
        public Paises()
        {
            Estados = new HashSet<Estados>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Alpha3 { get; set; }
        public short Codigo { get; set; }
        public bool? Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<Estados> Estados { get; set; }
    }
}
