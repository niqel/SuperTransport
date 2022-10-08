using System;
using System.Collections.Generic;

namespace InnovaLinks.DAL.Models
{
    public partial class ViajesRendimientoInnovalinks
    {
        public int? Id { get; set; }
        public double? Rendimiento { get; set; }
        public double? KmsRecorridos { get; set; }
        public double? LitrosDiesel { get; set; }
        public DateTime? InicioViaje { get; set; }
        public DateTime? TerminoViaje { get; set; }
        public int? VelocidadPromedio { get; set; }
        public int? VelocidadMax { get; set; }
    }
}
