using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class ProcesoEnvioNotificaciones
    {
        public int Id { get; set; }
        public int IdObjeto { get; set; }
        public int IdAplicacion { get; set; }
        public DateTime? FechaInicial { get; set; }
        public DateTime? FechaFinal { get; set; }
        public int? DiasPorVencer { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
