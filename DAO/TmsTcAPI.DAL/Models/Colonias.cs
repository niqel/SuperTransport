using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class Colonias
    {
        public Colonias()
        {
            Addresses = new HashSet<Addresses>();
            Clientes = new HashSet<Clientes>();
            ClientesFacturacion = new HashSet<ClientesFacturacion>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public int Municipiosid { get; set; }
        public int Statesid { get; set; }
        public bool? Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Municipios Municipios { get; set; }
        public virtual ICollection<Addresses> Addresses { get; set; }
        public virtual ICollection<Clientes> Clientes { get; set; }
        public virtual ICollection<ClientesFacturacion> ClientesFacturacion { get; set; }
    }
}
