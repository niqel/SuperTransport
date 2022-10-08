using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TmsTcAPI.Models
{
    public class custom_respuesta
    {
        public int id_campo { get; set; }
        public string respuesta { get; set; }

        public custom_respuesta(int id, string resp)
        {
            id_campo = id;
            respuesta = resp;
        }
    }
}