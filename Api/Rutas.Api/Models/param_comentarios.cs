using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TmsTcAPI.Models
{
    public class param_comentarios
    {
        public int id_diligencia { get; set; }
        public string comentarios { get; set; }
        public int id_estatus_diligencia { get; set; }

        public param_comentarios(int id, string coment, int status)
        {
            id_diligencia = id;
            comentarios = coment;
            id_estatus_diligencia = status;
        }
    }
}