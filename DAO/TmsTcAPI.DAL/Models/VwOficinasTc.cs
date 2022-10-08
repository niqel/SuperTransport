using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class VwOficinasTc
    {
        public int IdOficinaTc { get; set; }
        public int? Telefono { get; set; }
        public string Email { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Calle { get; set; }
        public string Cp { get; set; }
        public string NumExterior { get; set; }
        public string NumInterior { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public int IdColonia { get; set; }
        public string Colonia { get; set; }
        public int IdMunicipio { get; set; }
        public string Municipio { get; set; }
        public int IdEstado { get; set; }
        public string Estado { get; set; }
        public int IdPais { get; set; }
        public string Pais { get; set; }
        public int IdZona { get; set; }
        public string Zona { get; set; }
    }
}
