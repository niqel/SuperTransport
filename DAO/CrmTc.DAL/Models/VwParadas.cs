using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class VwParadas
    {
        public int IdParada { get; set; }
        public int IdCiudad { get; set; }
        public int? PlantaId { get; set; }
        public string NombrePlanta { get; set; }
        public string DescripcionPlanta { get; set; }
        public string LatitudParada { get; set; }
        public string LongitudParada { get; set; }
        public string CiudadPlanta { get; set; }
        public int? Rutasid { get; set; }
        public bool? EsReparto { get; set; }
        public short? Orden { get; set; }
    }
}
