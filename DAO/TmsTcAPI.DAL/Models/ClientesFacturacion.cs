using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class ClientesFacturacion
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdTipoCliente { get; set; }
        public string Nombres { get; set; }
        public string RazonSocial { get; set; }
        public string ApellidoPat { get; set; }
        public string ApellidoMat { get; set; }
        public string Rfc { get; set; }
        public int? Codigo { get; set; }
        public string Calle { get; set; }
        public string NumExterior { get; set; }
        public string NumInterior { get; set; }
        public int? IdColonia { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Localidad { get; set; }
        public int IdMetodoPago { get; set; }
        public string NumeroCuenta { get; set; }
        public int IdFormaPago { get; set; }
        public bool EsPrincipal { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Clientes IdClienteNavigation { get; set; }
        public virtual Colonias IdColoniaNavigation { get; set; }
        public virtual FormaPago IdFormaPagoNavigation { get; set; }
        public virtual MetodoPago IdMetodoPagoNavigation { get; set; }
    }
}
