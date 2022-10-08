using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class VwColonias
    {
        public int IdColonia { get; set; }
        public string Colonia { get; set; }
        public int IdMunicipio { get; set; }
        public string Municipio { get; set; }
        public int IdEstado { get; set; }
        public string Estado { get; set; }
        public int IdZona { get; set; }
        public string Zona { get; set; }
        public int IdPais { get; set; }
        public string Pais { get; set; }
    }
}
