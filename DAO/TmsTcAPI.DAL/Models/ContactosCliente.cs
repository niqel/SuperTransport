using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class ContactosCliente
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Cp { get; set; }
        public int? IdColonia { get; set; }
        public int? IdMunicipio { get; set; }
        public string NumExterior { get; set; }
        public string NumInterior { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Puesto { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Clientes IdClienteNavigation { get; set; }
    }
}
