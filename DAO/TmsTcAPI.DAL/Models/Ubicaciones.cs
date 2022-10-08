using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class Ubicaciones
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Calle { get; set; }
        public string Cp { get; set; }
        public string NumExterior { get; set; }
        public string NumInterior { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public bool EsOrigen { get; set; }
        public bool EsDestino { get; set; }
        public bool EsRegreso { get; set; }
        public bool EsDealer { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? IdMunicipios { get; set; }
        public int? IdEstado { get; set; }
        public int? IdColonia { get; set; }

        public virtual Municipios IdMunicipiosNavigation { get; set; }
    }
}
