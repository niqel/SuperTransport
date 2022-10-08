using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TmsTcAPI.Models
{
    public class param_idusuario
    {
        public int id_usuario { get; set; }

        public param_idusuario(int id)
        {
            id_usuario = id;
        }
    }
}