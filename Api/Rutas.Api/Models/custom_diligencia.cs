using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TmsTcAPI.Models
{
    public class custom_diligencia
    {
        public int id_diligencia { get; set; }
        public string nombre_demandado { get; set; }
        public string nombre_tipo_diligencia { get; set; }
        public string nombre_estatus_diligencia { get; set; }
        public string nombre_prioridad_diligencia { get; set; }
        public string resumen { get; set; }
        public string comentarios { get; set; }
        public System.DateTime fecha { get; set; }

    }
}