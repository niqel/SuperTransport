using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class OficinaDisponibilidad
    {
        public int Id { get; set; }
        public int IdOficina { get; set; }
        public DateTime Fecha { get; set; }
        public int IdOficinaRazonDisponibilidad { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Oficinas IdOficinaNavigation { get; set; }
        public virtual OficinaRazonesDisponibilidad IdOficinaRazonDisponibilidadNavigation { get; set; }
    }
}
