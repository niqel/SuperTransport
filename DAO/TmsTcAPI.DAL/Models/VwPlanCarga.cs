using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class VwPlanCarga
    {
        public DateTime Fecha { get; set; }
        public int Cliente { get; set; }
        public int Oficina { get; set; }
        public int Mercado { get; set; }
        public int? Demanda { get; set; }
        public int Posicionado { get; set; }
        public int Arribo { get; set; }
        public int Cargado { get; set; }
        public int? Faltante { get; set; }
        public int? Total { get; set; }
    }
}
