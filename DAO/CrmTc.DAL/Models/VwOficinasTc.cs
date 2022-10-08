using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class VwOficinasTc
    {
        public int IdOficinaTc { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool EsRegreso { get; set; }
    }
}
