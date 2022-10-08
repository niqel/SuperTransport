using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TmsTcAPI.Models
{
    public class EvaluationResult
    {
        public DateTime Fecha { get; set; }
        public int IdFormulario { get; set; }
        public int IdDiligencia { get; set; }
        public int Atencion { get; set; }
        public int Orden { get; set; }
        public int Control { get; set; }
    }
}