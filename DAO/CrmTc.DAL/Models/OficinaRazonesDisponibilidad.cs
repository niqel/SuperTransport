using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class OficinaRazonesDisponibilidad
    {
        public OficinaRazonesDisponibilidad()
        {
            OficinaDisponibilidad = new HashSet<OficinaDisponibilidad>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual ICollection<OficinaDisponibilidad> OficinaDisponibilidad { get; set; }
    }
}
