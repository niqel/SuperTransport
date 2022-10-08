using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TmsTcAPI.Models
{
    public class custom_formulariodetail
    {
        public int id_formulario { get; set; }
        public string titulo { get; set; }
        public int id_tipo_control { get; set; }
        public string imagen { get; set; }
        public string respuesta1 { get; set; }
    }
}