using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TmsTcAPI.Models
{
    public class PermisosRol
    {
        public int usuariosId { get; set; }
        public int rolesId { get; set; }
        //public string nombre { get; set; }
        //public string mail { get; set; }
        public string nombreFuncionalidad { get; set; }
        public string nombreModulo { get; set; }
        public string descripcionModulo { get; set; }

        public PermisosRol()
        {
        }
    }
}