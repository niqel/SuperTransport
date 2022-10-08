using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TmsTcAPI.Models
{
    public class custom_diligenciaasignacion
    {
        public int id_diligencia { get; set; }
        public string nombre_usuario { get; set; }
        public string nombre_demandado { get; set; }
        public string nombre_tipo_diligencia { get; set; }
        public string nombre_estatus_diligencia { get; set; }
        public System.DateTime fecha { get; set; }

    }
}