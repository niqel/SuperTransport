using System;
using System.Collections.Generic;

namespace InnovaLinks.DAL.Models
{
    public partial class TblTiemposBitacora
    {
        public int Id { get; set; }
        public string Unidad { get; set; }
        public DateTime? Fecha { get; set; }
        public double? Transito { get; set; }
        public double? Maniobras { get; set; }
        public double? Descansando { get; set; }
        public double? Comiendo { get; set; }
        public double? Durmiendo { get; set; }
        public int? IdConductor { get; set; }
        public string Conductor { get; set; }
        public int? IdViajeTc { get; set; }
        public DateTime? FechaRegistro { get; set; }
    }
}
