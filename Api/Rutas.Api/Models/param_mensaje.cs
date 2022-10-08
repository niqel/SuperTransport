using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TmsTcAPI.Models
{
    public class param_mensaje
    {
        public int id_usuario { get; set; }
        public string mensaje { get; set; }
        public DateTime fecha { get; set; }
        public int id_diligencia { get; set; }

        public param_mensaje(int id, string msg, DateTime fec, int id_d)
        {
            id_usuario = id;
            mensaje = msg;
            fecha = fec;
            id_diligencia = id_d;
        }
    }
}