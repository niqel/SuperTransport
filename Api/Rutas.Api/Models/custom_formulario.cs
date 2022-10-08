using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TmsTcAPI.Models
{
    public class custom_formulario
    {
        public int id_formulario { get; set; }
        public int id_demandado { get; set; }
        public string nombre_demandado { get; set; }
        public string nombre_tipo_formato { get; set; }
        public System.DateTime fecha { get; set; }

    }
}