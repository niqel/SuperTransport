using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class OficinasOperativas
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? HoraLimiteLlegada { get; set; }
        public int? CapacidadMaxTractores { get; set; }
        public float? Geocerca { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Keyword { get; set; }
        public int Clientesid { get; set; }
        public int Oficinasid { get; set; }

        public virtual Clientes Clientes { get; set; }
        public virtual Oficinas Oficinas { get; set; }
    }
}
