using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class RegistrosActividad
    {
        public int Id { get; set; }
        public bool? RealizaProceso { get; set; }
        public string Mensaje { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CantidadRegistrosAfectados { get; set; }
    }
}
