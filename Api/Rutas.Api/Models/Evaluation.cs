using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TmsTcAPI.Models
{
    public class Evaluation
    {
        public int IdFormulario { get; set; }
        public DateTime Fecha { get; set; }
        public int IdDiligencia { get; set; }
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public int IdZona { get; set; }
        public int IdDemandado { get; set; }
        public string NombreDemandado { get; set; }
        public int IdCampo { get; set; }
        public string Respuesta { get; set; }

    }
}