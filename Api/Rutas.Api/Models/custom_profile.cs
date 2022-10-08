using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TmsTcAPI.Models
{
    public class custom_profile
    {
        public int id_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string domicilio { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string username { get; set; }
        public string sexo { get; set; }
        public Nullable<System.DateTime> fecha_nacimiento { get; set; }
        public byte[] imagen { get; set; }
        public string nombre_zona { get; set; }
    }
}