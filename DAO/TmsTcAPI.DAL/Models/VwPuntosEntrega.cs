using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class VwPuntosEntrega
    {
        public int IdPuntoEntrega { get; set; }
        public int IdCliente { get; set; }
        public int IdUbicacion { get; set; }
        public int IdTipoPuntoEntrega { get; set; }
        public int IdPlazaCliente { get; set; }
        public int Numero { get; set; }
        public bool CalculoSeguroEspecial { get; set; }
        public string Alias { get; set; }
        public string Cuenta { get; set; }
        public string Email { get; set; }
        public float KmsNegociados { get; set; }
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
