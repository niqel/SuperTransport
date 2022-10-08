using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TmsTcAPI.Models
{
    public class param_iddemandado
    {
        public int id_demandado { get; set; }

        public param_iddemandado(int id)
        {
            id_demandado = id;
        }
    }
}