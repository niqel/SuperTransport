using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TmsTcAPI.Models
{
    public class param_formulario
    {
        public int id_diligencia { get; set; }

        public int id_tipo_formato { get; set; }

        public List<custom_respuesta> respuestas { get; set; }

        public DateTime fecha { get; set; }
    }
}