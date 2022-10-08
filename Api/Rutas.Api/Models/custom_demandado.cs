using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TmsTcAPI.Models
{
    public class custom_demandado
    {
        public int id_demandado { get; set; }
        public string nombre_demandado { get; set; }
        public Nullable<int> id_zona { get; set; }

    }
}