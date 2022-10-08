using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class VwOrigenes
    {
        public int IdOrigen { get; set; }
        public int Codigo { get; set; }
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Calle { get; set; }
        public string Cp { get; set; }
        public string NumExterior { get; set; }
        public string NumInterior { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public int IdColonia { get; set; }
        public string Colonia { get; set; }
        public int? IdCiudad { get; set; }
        public string Ciudad { get; set; }
        public int? IdEstado { get; set; }
        public string Estado { get; set; }
        public int? IdZona { get; set; }
        public string Zona { get; set; }
        public int? IdPais { get; set; }
        public string Pais { get; set; }
        public int PlantaId { get; set; }
        public string NombrePlanta { get; set; }
        public string DescripcionPlanta { get; set; }
        public string LatitudOrigen { get; set; }
        public string LongitudOrigen { get; set; }
        public string CiudadPlanta { get; set; }
    }
}
