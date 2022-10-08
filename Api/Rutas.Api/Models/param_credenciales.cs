using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TmsTcAPI.Models
{
    public class param_credenciales
    {
        public string user { get; set; }
        public string pass { get; set; }

        public param_credenciales(string usuario, string contraseña)
        {
            user = usuario;
            pass = contraseña;
        }
    }
}