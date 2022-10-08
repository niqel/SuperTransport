using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class VwCiudades
    {
        public int IdCiudad { get; set; }
        public string Ciudad { get; set; }
        public int? IdEstado { get; set; }
        public string Estado { get; set; }
        public int? IdZona { get; set; }
        public string Zona { get; set; }
        public int? IdPais { get; set; }
        public string Pais { get; set; }
        public int IdCliente { get; set; }
        public int? IdMunicipio { get; set; }
        public string Municipio { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public bool Active { get; set; }
    }
}
