using System;
using System.Collections.Generic;

namespace CrmTc.DAL.Models
{
    public partial class VwPuntosEntrega
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Alias { get; set; }
        public int IdTipoPuntoEntrega { get; set; }
        public string TipoPuntoEntrega { get; set; }
        public string Calle { get; set; }
        public string NumInterior { get; set; }
        public string NumExterior { get; set; }
        public int? Cp { get; set; }
        public int? IdColonia { get; set; }
        public string Colonia { get; set; }
        public int? IdMunicipio { get; set; }
        public string Municipio { get; set; }
        public int? IdEstado { get; set; }
        public string Estado { get; set; }
        public int IdPlazaCliente { get; set; }
        public string PlazaCliente { get; set; }
        public bool CalculoSeguroEspecial { get; set; }
        public string Cuenta { get; set; }
        public string Email { get; set; }
        public decimal KmsNegociados { get; set; }
        public string Horas { get; set; }
        public string Telefono { get; set; }
        public int IdCliente { get; set; }
        public string Cliente { get; set; }
    }
}
